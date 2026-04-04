using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Academy
{
    public partial class StudentForm : HumanForm
    {
        public StudentForm()
        {
            InitializeComponent();
            //rtbLastName.Text = "Тупенко";
            //rtbFirstName.Text = "Василий";
            //rtbMiddleName.Text = "Петрович";

            cbStudentsGroup.DataSource = DataBase.Connector.Select("*", "Groups");
            cbStudentsGroup.DisplayMember = "group_name";
            cbStudentsGroup.ValueMember = "group_id";

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Academy.Models.Student student = new Models.Student
                (
                0,
                rtbLastName.Text,
                rtbFirstName.Text,
                rtbMiddleName.Text,
                dtpBirthDate.Value.ToString("yyyy-MM-dd"),
                rtbEmail.Text,
                rtbPhone.Text,
                pictureBoxPhoto.Image,
                Convert.ToInt32(cbStudentsGroup.SelectedValue)
                );
            DataBase.Connector.Insert($"INSERT Students({student.GetNames()}) VALUES ({student})");
           //DBtools.Connector connector = new DBtools  //create class DataBase
           //     .Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
            //connector.Insert($"INSERT Students(last_name,first_name,middle_name,birth_date,[group])"
            //    + $" VALUES (N'{rtbLastName.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleName.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{1})");
            //DataBase.Connector.Insert("Students", "last_name,first_name,middle_name,birth_date,[group]",
            //    $"N'{rtbLastName.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleName.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{cbStudentsGroup.SelectedValue}");
        }
    }
}
