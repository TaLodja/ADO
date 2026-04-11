using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Academy.Models
{
    internal class Teacher : Human
    {
        string work_since;
        string rate;
        public Teacher
            (
            int id,
            string last_name, string first_name, string middle_name, string birth_date,
            string email, string phone, Image photo,
            string work_since, string rate
            ) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
        {
            this.work_since = work_since;
            this.rate = rate;
        }
        public override string GetNames()
        {
            return base.GetNames() + ",work_since,rate";
        }
        public override string ToString()
        {
            return base.ToString() + $",N'{work_since}',N'{rate}'";
        }
        public override string ToStringUpdate()
        {
            return base.ToStringUpdate() + $",work_since=N'{work_since}',rate=N'{rate}'";
        }
    }
}
