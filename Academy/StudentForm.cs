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
        private MainForm mainForm;
        public StudentForm(MainForm fromForm)
        {
            InitializeComponent();
            //rtbLastName.Text = "Тупенко";
            //rtbFirstName.Text = "Василий";
            //rtbMiddleName.Text = "Петрович";
            fromForm.LoadDataToComboBox(cbStudentsGroup);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
           DBtools.Connector connector = new DBtools
                .Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
            //connector.Insert($"INSERT Students(last_name,first_name,middle_name,birth_date,[group])"
            //    + $" VALUES (N'{rtbLastName.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleName.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{1})");
            connector.Insert("Students", "last_name,first_name,middle_name,birth_date,[group]",
                $"N'{rtbLastName.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleName.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{cbStudentsGroup.SelectedIndex+1}");
        }
    }
}
