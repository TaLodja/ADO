using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConnectorLib;

namespace ConnectorCheck
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
            SqlConnection connection = new SqlConnection(connection_string);
            //string cmd = "SELECT title,year,first_name,last_name FROM Movies JOIN Directors ON(director=director_id)";

            Connector connector = new Connector(connection_string);
            connector.Select("title,year,first_name,last_name", "Movies,Directors", "director=director_id");
            Console.WriteLine("\n---------------------------------------------------------\n");

            connector.Update("UPDATE Directors SET last_name = N'Besson',first_name = N'Luc' WHERE director_id = 7");
            connector.Select("SELECT * FROM Directors");
            Console.WriteLine("\n---------------------------------------------------------\n");

            connector.Insert("Movies", $"{connector.GetNextPrimaryKey("Movies")},N'A Little Chaos',N'2015-08-20',10");
            connector.Select("SELECT * FROM Movies");
            Console.WriteLine("\n---------------------------------------------------------\n");
        }
    }
}
