using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

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
        public void Insert(string table, string values)
        {
            string cmd = $"INSERT INTO {table} VALUES ({values})";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(string table, string fields, string new_value, string condition = "")
        { 
            string cmd = $"UPDATE {table} SET {fields} = {new_value}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
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
    }
}
