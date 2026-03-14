using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLParsing
{
    public class SQLParsing
    {
        public string[] GetTableFromSelect(string cmd)
        {
            if (cmd.Contains("JOIN"))
            {
                string[] stringDelimiter = new string[] { "JOIN", "join", "Join" };
                string[] part_0_Delimiter = new string[] { "FROM", "from", "From" };
                string[] part_i_Delimiter = new string[] { "ON", "on", "On" };
                string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
                string[] tables = parts;
                string[] tables0 = parts[0].Split(part_0_Delimiter, StringSplitOptions.RemoveEmptyEntries);
                tables[0] = tables0[1].Trim();
                for (int i = 1; i < tables.Length; i++)
                {
                    string[] table_i = parts[i].Split(part_i_Delimiter, StringSplitOptions.RemoveEmptyEntries);
                    tables[i] = table_i[0].Trim();
                }
                for (int i = 0; i < tables.Length; i++) Console.WriteLine(tables[i]);
                return tables;
            }
            else
            {
                string[] stringDelimiter = new string[] { "FROM", "from", "From", "WHERE", "where", "Where", "GROUP", "group", "Group" };
                string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
                string[] tables = parts[1].Split(',');
                Console.WriteLine("SELECT tables:\n");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i] = tables[i].Trim();
                    Console.WriteLine(tables[i]);
                }
                return tables;
            }
        }
        public string[] GetFieldFromSelect(string cmd)
        {
            string[] stringDelimiter = new string[] { "SELECT", "select", "Select", "FROM", "from", "From" };
            string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] fields = parts[0].Split(',');
            Console.WriteLine("SELECT fields:\n");
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = fields[i].Trim();
                Console.WriteLine(fields[i]);
            }
            return fields;
        }
        public string[] GetConditions(string cmd, string fieldORvalue, string[] stringDelimiter)
        {
            string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] partDelimiter = new string[] { "AND", "and", "And", "," };
            string[] conditions = parts[1].Split(partDelimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] fieldInCondition = parts[1].Split(partDelimiter, StringSplitOptions.RemoveEmptyEntries); ;
            string[] valueInCondition = parts[1].Split(partDelimiter, StringSplitOptions.RemoveEmptyEntries); ;
            for (int i = 0; i < conditions.Length; i++)
            {
                conditions[i] = conditions[i].Trim();
            }
            for (int i = 0; i < conditions.Length; i++)
            {
                string[] partsCondition = conditions[i].Split('=', '<', '>', '!');
                fieldInCondition[i] = partsCondition[0].Trim();
                valueInCondition[i] = partsCondition[1].Trim();
            }
            if (fieldORvalue == "fields")
            {
                Console.WriteLine("condition fields:\n");
                for (int i = 0; i < fieldInCondition.Length; i++) Console.WriteLine(fieldInCondition[i]);
                return fieldInCondition;
            }
            else if (fieldORvalue == "values")
            {
                Console.WriteLine("condition values:\n");
                for (int i = 0; i < valueInCondition.Length; i++) Console.WriteLine(valueInCondition[i]);
                return valueInCondition;
            }
            else
            {
                Console.WriteLine("conditions:\n");
                for (int i = 0; i < conditions.Length; i++) Console.WriteLine(conditions[i]);
                return conditions;
            }
        }
        public string[] GetWHERECondition(string cmd, string fieldORvalue = "")
        {
            string[] stringDelimiter = new string[] { "WHERE", "where", "Where", "GROUP", "group", "Group", "HAVING", "having", "Having", "ORDER", "order", "Order" };
            return GetConditions(cmd, fieldORvalue, stringDelimiter);
        }

        public string[] GetHAVINGCondition(string cmd, string fieldORvalue = "")
        {
            string[] stringDelimiter = new string[] { "HAVING", "having", "Having", "ORDER", "order", "Order" };
            return GetConditions(cmd, fieldORvalue, stringDelimiter);
        }
        public string[] GetJOINCondition(string cmd)
        {
            string[] stringDelimiter = new string[] { "JOIN", "join", "Join", "WHERE", "where", "Where", "GROUP", "group", "Group" };
            string[] partDelimiter = new string[] { "ON", "on", "On" };
            string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i=0; i<parts.Length; i++)
            {
                if (parts[i].Contains("ON") || parts[i].Contains("on") || parts[i].Contains("On")) count++;
            }
            string[] conditions = new string[count];
            for (int i=0; i < count; i++)
            {
                string[] partCondition = parts[i+1].Split(partDelimiter, StringSplitOptions.RemoveEmptyEntries);
                if (partCondition[1].Contains("(")) partCondition[1] = partCondition[1].Split('(', ')')[1];
                conditions[i] = (partCondition[1]).Trim();
            }
            for (int i = 0; i < conditions.Length; i++) Console.WriteLine(conditions[i]);
            return conditions;
        }
        public string[] GetGROUPFieldsFromSelect(string cmd)
        {
            string[] stringDelimiter = new string[] { "GROUP BY", "group by", "Group By", "Group by", "HAVING", "having", "Having", "ORDER", "order", "Order" };
            string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] fields = parts[1].Split(',');
            Console.WriteLine("GROUP BY fields:\n");
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = fields[i].Trim();
                Console.WriteLine(fields[i]);
            }
            return fields;
        }
        public string GetORDERFieldFromSelect(string cmd)
        {
            string[] stringDelimiter = new string[] { "ORDER BY", "order by", "Order By", "Order by", "ASC", "asc", "DESC", "desk" };
            string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("ORDER BY field:\n");
            Console.WriteLine(parts[1].Trim());
            return parts[1].Trim();
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
            string[] stringDelimiter = new string[] { "VALUES"};
            string[] parts = cmd.Split(stringDelimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] values = parts[1].Split('(', ')');
            return values[1].Trim();
        }

        public string GetTableFromUpdate(string cmd)
        {
            string[] parts = cmd.Split(' ');
            return parts[1];
        }
        public string[] GetSETConditions(string cmd, string fieldORvalue = "")
        {
            string[] stringDelimiter = new string[] { "SET", "set", "Set", "WHERE", "where", "Where" };
            return GetConditions(cmd, fieldORvalue, stringDelimiter);
        }
    }
}
