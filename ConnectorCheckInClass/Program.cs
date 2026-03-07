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
            //string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;"
            //                           + "Initial Catalog=Movies_SPU_411;"
            //                           + "Integrated Security=True;"
            //                           + "Connect Timeout=30;"
            //                           + "Encrypt=False;"
            //                           + "TrustServerCertificate=False;"
            //                           + "ApplicationIntent=ReadWrite;"
            //                           + "MultiSubnetFailover=False";
            string connection_string = "Data Source=DESKTOP-MU2UJAA\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Connector.Connector connector = new Connector.Connector(connection_string);
            connector.Select("SELECT * FROM Directions");
        }
    }
}
