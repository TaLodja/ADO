using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Academy.Models
{
    internal class Human
    {
        public int id;
        public string last_name;
        public string first_name;
        public string middle_name;
        public string birth_date;
        public string email;
        public string phone;
        public Image photo;
        public Human
            (
            int id, 
            string last_name, string first_name, string middle_name, string birth_date, 
            string email, string phone, Image photo
            )
        {
            this.id = id;
            this.last_name = last_name;
            this.first_name = first_name;
            this.middle_name = middle_name;
            this.birth_date = birth_date;
            this.email = email;
            this.phone = phone;
            this.photo = photo;
        }
        public byte[] SerializePhoto()
        {
            MemoryStream ms = new MemoryStream();
            photo.Save(ms, photo.RawFormat);
            return ms.ToArray();
        }
        public virtual string GetNames()
        {
            return $"last_name,first_name,middle_name,birth_date,email,phone,photo";
        }
        public override string ToString()
        {
            return $"N'{last_name}',N'{first_name}',N'{middle_name}',N'{birth_date}',N'{email}',N'{phone}',{SerializePhoto()}"; 
        }
    }
}
