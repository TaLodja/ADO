using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Academy.Models
{
    internal class Student : Human
    {
        int group;
        public Student
            (
            int id,
            string last_name, string first_name, string middle_name, string birth_date,
            string email, string phone, Image photo,
            int group
            ) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
        {
            this.group = group;
        }
        public override string GetNames()
        {
            return base.GetNames() + ",[group]";
        }
        public override string ToString()
        {
            return base.ToString() + $",{group}";
        }
        public override string ToStringUpdate()
        {
            return base.ToStringUpdate()+$",[group]={group}";
        }
        public string GetCondition()
        {
            return $"last_name=N'{last_name}' AND first_name=N'{first_name}' AND middle_name=N'{middle_name}' AND birth_date=N'{birth_date}'";
        }
    }
}
