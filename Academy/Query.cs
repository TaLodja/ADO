using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Query
    {
        public string Tables { get; set; }
        public string Fields { get; set; }
        public string Condition { get; set; }
        public Query(string tables, string fields, string condition = "")
        {
            this.Tables = tables;
            this.Fields = fields;
            this.Condition = condition;
        }
        public override string ToString()
        {
            string cmd = $"SELECT {Fields} FROM {Tables}";
            if (Condition != "" && Condition != " ") cmd += $" WHERE {Condition}";
            //cmd += ";";
            return cmd;
        }
        public Query ChangeQuery(string addTables, string addFields = "", string addCondition = "")
        {
            Query newQuery = new Query(this.Tables, this.Fields, this.Condition);
            if (addTables != "") newQuery.Tables += $",{addTables}";
            if (addFields != "")
            {
                if (newQuery.Fields == "*") newQuery.Fields = "";
                else newQuery.Fields += ",";
                newQuery.Fields += $"{addFields}";
            }

            if (newQuery.Condition != "" && addCondition != "")
                newQuery.Condition += " AND ";
            if (addCondition != "")
                newQuery.Condition += $"{addCondition}";
            return newQuery;
        }
    }
}
