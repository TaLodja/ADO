using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Academy
{
    static class DataBase
    {
        public static DBtools.Connector Connector { get; set; } = new DBtools.Connector
            (
                ConfigurationManager.ConnectionStrings["SPU_411_import"].ConnectionString
            );
    }
}
