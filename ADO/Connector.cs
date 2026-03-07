using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace ADO
{
    internal class Connector
    {
        string connection_string;
        SqlConnection connection;
        public Connector(string connection_string)
        {
            this.connection_string = connection_string;
            this.connection = new SqlConnection(connection_string);
        }
        public void Select(string fields, string tables, string condition = "")
        {
            string cmd = $"SELECT {fields} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            Select(cmd);
            //connection.Open();
            //SqlCommand command = new SqlCommand(cmd, connection);
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
            //    for (int i = 0; i < reader.FieldCount; i++)
            //    {
            //        Console.Write(reader[i].ToString().PadRight(29));
            //    }
            //    Console.WriteLine();
            //}
            //reader.Close();
            //connection.Close();
        }
        public void Select(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i].ToString().PadRight(29));
                }
                Console.WriteLine();
            }
            reader.Close();
            connection.Close();
        }
        public string GetTableFromInsert(string cmd)
        {
            string[] parts = cmd.Split(' ', '(', ')');
            return parts[1];
        }
        public string GetFieldsFromInsert(string cmd)
        {
            string parts = "";
            connection.Open();
            SqlCommand command = new SqlCommand($"SELECT * FROM {GetTableFromInsert(cmd)}", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                parts += reader.GetName(i);
                if (i < reader.FieldCount - 1) parts += ",";
            }
            reader.Close();
            connection.Close();
            return parts;
            //string[] parts = cmd.Split('(', ')');
            //return parts[1];
        }
        public string GetValuesFromInsert(string cmd)
        {
            string[] parts = cmd.Split('(', ')');
            return parts[1];
        }
        public void Insert(string cmd)
        {
            Console.WriteLine(cmd);
            Console.WriteLine(GetTableFromInsert(cmd));
            Console.WriteLine(GetFieldsFromInsert(cmd));
            Console.WriteLine(GetValuesFromInsert(cmd));
            if (GetPrimaryKey(GetTableFromInsert(cmd),GetFieldsFromInsert(cmd),GetValuesFromInsert(cmd))!=null) 
                return;
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Insert(string table, string values) => Insert($"INSERT INTO {table} VALUES ({values})");
        //{
            //=======In Home=========
            //string[] value = values.Split(',');
            //string select_condition = "";
            //connection.Open();
            //SqlCommand command = new SqlCommand($"SELECT * FROM {table}", connection);
            //SqlDataReader reader = command.ExecuteReader();
            //reader.Read();
            //string[] column = new string[reader.FieldCount];
            //for (int i = 0; i < reader.FieldCount; i++)
            //{
            //    column[i] = reader.GetName(i);
            //    if (i == 1) select_condition += $"{column[i]} = {value[i]}";
            //    if (i > 2) select_condition += $"AND {column[i]} = {value[i]}";
            //    //Console.WriteLine(column[i]);
            //}
            //reader.Close();
            //connection.Close();
            //string cmd = $"IF NOT EXISTS (SELECT * FROM {table} WHERE {select_condition}) INSERT INTO {table} VALUES ({values})";
            
            //=======In Class=========
            //string cmd = $"INSERT INTO {table} VALUES ({values})";
            //Insert(cmd);
        //}
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
            //int value = Convert.ToInt32(command.ExecuteScalar());
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
            //string key_name = $"{table.Substring(0, table.Length-1)}_id";
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
    }
}
