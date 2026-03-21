using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cmd += ";";
            return cmd;
        }
        public string AddCondition(string addConditions)
        {
            string cmd = $"SELECT {Fields} FROM {Tables}";
            if (Condition != "" && Condition != " ") cmd += $" WHERE {Condition} AND {addConditions}";
            cmd += ";";
            return cmd;
        }
        public string AddTableWithConditions(string addTables, string addConditions)
        {
            string cmd = $"SELECT {Fields} FROM {Tables},{addTables} WHERE {addConditions}";
            cmd += ";";
            return cmd;
        }
    }
}
