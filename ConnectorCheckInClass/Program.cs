using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectorCheckInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;"
                                       + "Initial Catalog=Movies_SPU_411;"
                                       + "Integrated Security=True;"
                                       + "Connect Timeout=30;"
                                       + "Encrypt=False;"
                                       + "TrustServerCertificate=False;"
                                       + "ApplicationIntent=ReadWrite;"
                                       + "MultiSubnetFailover=False";
            //string connection_string = "Data Source=DESKTOP-MU2UJAA\\SQLEXPRESS;"
            //                            + "Initial Catalog=SPU_411_Import;"
            //                            +"Integrated Security=True;"
            //                            +"Connect Timeout=30;"
            //                            +"Encrypt=True;"
            //                            +"TrustServerCertificate=True;"
            //                            +"ApplicationIntent=ReadWrite;"
            //                            +"MultiSubnetFailover=False";
            Connector.Connector connector = new Connector.Connector(connection_string);
            SQLParsing.SQLParsing sqlParsing = new SQLParsing.SQLParsing();
            //connector.Select("SELECT * FROM Directions");

            string cmd =
            "SELECT title,year,first_name,last_name FROM Movies JOIN Directors ON(director=director_id) JOIN Titles ON title = movie_id";
            //"SELECT director_id FROM Directors, Movies,      Directions,   Teacher GROUP BY teacher_id HAVING last_name = N'Cameron' AND first_name = N'James'";
            //"SELECT director_id FROM Directors, Movies,      Directions,   Teacher WHERE last_name = N'Cameron' AND first_name = N'James' ORDER BY direction_id";
            //"INSERT Movies VALUES(6,N'Transformers',N'2007-07-04',13)";
            //$"INSERT Movies(movie_id, title, year, director) VALUES({connector.GetNextPrimaryKey("Movies")},N'Transformers',N'2007-07-04',13)";
            //"UPDATE Directors SET last_name = N'Besson',first_name = N'Luc' WHERE director_id = 7";


            //===================================== SELECT Check ========================================
            Console.WriteLine("\n=====================================SELECT Check========================================\n");
            Console.WriteLine(cmd);


            Console.WriteLine("\n---------------------------------------------------------\n");
            string[] tables = sqlParsing.GetTableFromSelect(cmd);
            Console.WriteLine("\n---------------------------------------------------------\n");
            string[] fields = sqlParsing.GetFieldFromSelect(cmd);
            Console.WriteLine("\n---------------------------------------------------------\n");
            if (cmd.Contains("WHERE"))
            {
                string[] conditions = sqlParsing.GetWHERECondition(cmd);
                Console.WriteLine("\n---------------------------------------------------------\n");
                string[] fieldInCondition = sqlParsing.GetWHERECondition(cmd, "fields");
                Console.WriteLine("\n---------------------------------------------------------\n");
                string[] valueInCondition = sqlParsing.GetWHERECondition(cmd, "values");
                Console.WriteLine("\n---------------------------------------------------------\n");
            }
            if (cmd.Contains("GROUP"))
            {
                string[] having_fields = sqlParsing.GetGROUPFieldsFromSelect(cmd);
                Console.WriteLine("\n---------------------------------------------------------\n");
                string[] conditions = sqlParsing.GetHAVINGCondition(cmd);
                Console.WriteLine("\n---------------------------------------------------------\n");
                string[] fieldInCondition = sqlParsing.GetHAVINGCondition(cmd, "fields");
                Console.WriteLine("\n---------------------------------------------------------\n");
                string[] valueInCondition = sqlParsing.GetHAVINGCondition(cmd, "values");
                Console.WriteLine("\n---------------------------------------------------------\n");
            }
            if (cmd.Contains("ORDER"))
            {
                string order_fields = sqlParsing.GetORDERFieldFromSelect(cmd);
                Console.WriteLine("\n---------------------------------------------------------\n");
            }
            if (cmd.Contains("JOIN"))
            {
                Console.WriteLine("\nJOIN Conditions\n");
                string[] joinConditions = sqlParsing.GetJOINCondition(cmd);
                Console.WriteLine(joinConditions);
                Console.WriteLine("\n---------------------------------------------------------\n");
            }

            //=====================================INSERT Check========================================
            //Console.WriteLine("\n=====================================INSERT Check========================================\n");
            //Console.WriteLine(cmd);
            //Console.WriteLine("\n---------------------------------------------------------\n");
            //
            //string table =sqlParsing.GetTableFromInsert(cmd);
            //Console.WriteLine(table);
            //Console.WriteLine("\n---------------------------------------------------------\n");
            //string fields = connector.GetFields(cmd);
            //Console.WriteLine(fields);
            //Console.WriteLine("\n---------------------------------------------------------\n");
            //string values = sqlParsing.GetValuesFromInsert(cmd);
            //Console.WriteLine(values);
            //Console.WriteLine("\n---------------------------------------------------------\n");

            //===================================== UPDATE Check ========================================
            //Console.WriteLine("\n=====================================UPDATE Check========================================\n");
            //Console.WriteLine(cmd);
            //string table = sqlParsing.GetTableFromUpdate(cmd);
            //Console.WriteLine(table);
            //Console.WriteLine("\n---------------------------------------------------------\n");
            //Console.WriteLine("\nSET Conditions\n");
            //string[] setConditions = sqlParsing.GetSETConditions(cmd);
            //Console.WriteLine("\n---------------------------------------------------------\n");
            //string[] setFields = sqlParsing.GetSETConditions(cmd, "fields");
            //Console.WriteLine("\n---------------------------------------------------------\n");
            //string[] setValues = sqlParsing.GetSETConditions(cmd, "values");
            //Console.WriteLine("\n---------------------------------------------------------\n");
            //if (cmd.Contains("WHERE"))
            //{
            //    Console.WriteLine("\nWHERE Conditions\n");
            //    string[] conditions = sqlParsing.GetWHERECondition(cmd);
            //    Console.WriteLine("\n---------------------------------------------------------\n");
            //    string[] fieldInCondition = sqlParsing.GetWHERECondition(cmd, "fields");
            //    Console.WriteLine("\n---------------------------------------------------------\n");
            //    string[] valueInCondition = sqlParsing.GetWHERECondition(cmd, "values");
            //    Console.WriteLine("\n---------------------------------------------------------\n");
            //}

            //connector.Select("title,year,first_name,last_name", "Movies,Directors", "director=director_id");
            //Console.WriteLine("\n---------------------------------------------------------\n");

            //connector.Update("UPDATE Directors SET first_name = N'Michael' WHERE director_id = 13");
            //connector.Select("SELECT * FROM Directors");
            //Console.WriteLine("\n---------------------------------------------------------\n");

            //connector.Insert("Movies", "movie_id, title, year, director", $"{connector.GetNextPrimaryKey("Movies")},N'Transformers: Age of Extinction',N'2014-06-26',13");
            //connector.Select("SELECT * FROM Movies");
            //Console.WriteLine("\n---------------------------------------------------------\n");
        }
    }
}
