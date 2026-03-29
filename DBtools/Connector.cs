using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DBtools
{
    public class Connector
    {
        string connection_string;
        SqlConnection connection;
        public Connector(string connection_string)
        {
            this.connection_string = connection_string;
            this.connection = new SqlConnection(connection_string);
        }
        public DataTable Select(string fields, string tables, string condition = "")
        {
            string cmd = $"SELECT {fields} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            return Select(cmd);
        }
        public DataTable Select(string cmd)
        {
            DataTable table = new DataTable();
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataReader reader = command.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
                table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                    Console.Write(reader[i].ToString().PadRight(29));
                }
                Console.WriteLine();
                table.Rows.Add(row);
            }
            reader.Close();
            connection.Close();
            return table;
        }
        public string GetTableFromInsert(string cmd)
        {
            string[] parts = cmd.Split(' ', '(', ')');
            return parts[1];
        }
        public string GetFieldsFromInsert(string cmd)
        {
            string[] parts = cmd.Split('(', ')');
            return parts[1];
        }
        public string GetValuesFromInsert(string cmd)
        {
            string[] stringDelimiter = new string[] { "VALUES" };
            string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] values = parts[1].Split('(', ')');
            return values[1].Trim();
        }
        public void Insert(string cmd)
        {
            Console.WriteLine(cmd);
            Console.WriteLine(GetTableFromInsert(cmd));
            Console.WriteLine(GetFieldsFromInsert(cmd));
            Console.WriteLine(GetValuesFromInsert(cmd));
            if (GetPrimaryKey(GetTableFromInsert(cmd), GetFieldsFromInsert(cmd), GetValuesFromInsert(cmd)) != null)
                return;
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        //public void Insert(string table, string values) => Insert($"INSERT {table} VALUES ({values})");
        public void Insert(string table, string fields, string values) => Insert($"INSERT {table}({fields}) VALUES ({values})");
        public void Update(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(string table, string fields, string new_value, string condition = "")
        {
            string cmd = $"UPDATE {table} SET {fields} = {new_value}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            Update(cmd);
        }
        public int MAX_PrimaryKey(string table, string field_id)
        {
            string cmd = $"SELECT MAX({field_id}) FROM {table}";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            int MAX_key = (Int32)command.ExecuteScalar();
            connection.Close();
            return MAX_key;
        }
        public object Scalar(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            object value = command.ExecuteScalar();
            connection.Close();
            return value;
        }
        public string GetPrimaryKeyColumn(string table)
        {
            return (string)Scalar
                (
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE "
                + "WHERE CONSTRAINT_NAME = "
                + "(SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS "
                + $"WHERE TABLE_NAME = N'{table}' AND CONSTRAINT_TYPE = N'PRIMARY KEY');"
                //$"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'{table}'"
                );
        }
        public object GetPrimaryKey(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            object primary_key = command.ExecuteScalar();
            connection.Close();
            return primary_key;
        }
        public object GetPrimaryKey(string table, string fields, string values)
        {
            string[] s_fields = fields.Split(',');
            string[] s_values = values.Split(',');
            if (s_fields.Length != s_values.Length) return null;
            string condition = "";
            for (int i = 0; i < s_values.Length; i++)
            {
                if (s_fields[i].Contains("_id")) continue;
                string value = s_values[i].Trim();
                condition +=
                    (value.Length > 1 && value[0] != 'N' && value[1] != '\'')
                    ? $"{s_fields[i].Trim()} = N'{s_values[i].Trim()}'"
                    : $"{s_fields[i].Trim()}={s_values[i].Trim()}";
                if (i != s_values.Length - 1) condition += " AND ";
            }
            string cmd = $"SELECT {GetPrimaryKeyColumn(table)} FROM {table} WHERE {condition}";
            return Scalar(cmd);
        }
        public int GetLastPrimaryKey(string table)
        {
            return Convert.ToInt32(Scalar($"SELECT MAX({GetPrimaryKeyColumn(table)}) FROM {table}"));
        }
        public int GetNextPrimaryKey(string table)
        {
            return GetLastPrimaryKey(table) + 1;
        }
        //////////////////////////////////////////////////////////////////
        
        public Dictionary<string,int> LoadDictionary(string table, string condition = "")
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string prefix = table.ToLower().Substring(0, table.Length - 1);
            string key_name = $"{prefix}_name";
            string value_name = $"{prefix}_id";
            string cmd = $"SELECT {key_name},{value_name} FROM {table}";
            if (condition != "") cmd += $" WHERE {condition}";
            
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                dictionary.Add(Convert.ToString(reader[0]), Convert.ToInt32(reader[1]));
            connection.Close();
            
            return dictionary;
        }
    }
}
