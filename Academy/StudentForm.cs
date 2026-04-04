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
using DBtools;

namespace Academy
{
    public partial class StudentForm : HumanForm
    {
        private MainForm mainForm;
        Connector connector;
        public StudentForm(MainForm fromForm)
        {
            InitializeComponent();
            connector = new Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
            rtbLastName.Text = "Карлсон";
            rtbFirstName.Text = "Карл";
            rtbMiddleName.Text = "Карлович";
            dtpBirthDate.Value = DateTime.Parse("2010-08-12");
            fromForm.LoadDataToComboBox(cbStudentsGroup);
        }
        public StudentForm(MainForm fromForm, string last_name, string first_name, string middle_name, string birth_date, string group)
        {
            InitializeComponent();
            connector = new Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
            rtbLastName.Text = last_name;
            rtbFirstName.Text = first_name;
            rtbMiddleName.Text = middle_name;
            dtpBirthDate.Value = DateTime.Parse(birth_date);
            fromForm.LoadDataToComboBox(cbStudentsGroup);
            cbStudentsGroup.Text = group;
            //cbStudentsGroup.SelectedIndex = cbStudentsGroup.Items.IndexOf(group);
            string photo_value = connector.Scalar($"SELECT photo FROM Students WHERE last_name=N'{last_name}'").ToString();
            if (photo_value != "")
            {
                byte[] photo = connector.PhotoFromDB($"SELECT photo FROM Students WHERE last_name=N'{last_name}'");
                ByteArrayToImage(photo);
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //Connector connector = new Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
            //connector.Insert($"INSERT Students(last_name,first_name,middle_name,birth_date,[group])"
            //    + $" VALUES (N'{rtbLastName.Text}',N'{rtbFirstName.Text}',N'{rtbMiddleName.Text}',N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}',{1})");
            connector.Insert
                (
                "Students", "last_name,first_name,middle_name,birth_date,[group]",
                $"N'{rtbLastName.Text}'"
                + $",N'{rtbFirstName.Text}'"
                + $",N'{rtbMiddleName.Text}'"
                + $",N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}'"
                + $",{cbStudentsGroup.SelectedIndex + 1}"
                //+ $",{GetPhoto(photoPath) as SqlDbType.Image}"
                );
            string photo_condition = $"last_name=N'{rtbLastName.Text}' AND first_name=N'{rtbFirstName.Text}' AND middle_name=N'{rtbMiddleName.Text}'"
                //+ $"AND birth_date=N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}'"
                ;
            //Console.WriteLine($"{connector.Scalar($"SELECT photo FROM Students WHERE last_name=N'{rtbLastName.Text}'")}");
            if (pictureBoxPhoto.Image != null && connector.Scalar($"SELECT photo FROM Students WHERE {photo_condition}").ToString() == "" )
                connector.Update($"UPDATE Students SET photo = (SELECT BulkColumn FROM OPENROWSET(BULK N'{photoPath}', SINGLE_BLOB) AS image) WHERE {photo_condition}");
        }
    }
}
