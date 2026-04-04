using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBtools;

namespace Academy
{
    public partial class TeacherForm : HumanForm
    {
        Connector connector = new Connector(ConfigurationManager.ConnectionStrings["SPU_411_Import"].ConnectionString);
        string current_photo_path = "";
        string cmd = "";
        public TeacherForm(MainForm fromForm)
        {
            InitializeComponent();
            //dgvDisciplinesToTeacher.DataSource = connector.Select("SELECT discipline_name FROM Disciplines,TeachersDisciplinesRelation,Teachers WHERE discipline_id = discipline AND teacher = teacher_id");
            fromForm.LoadDataToComboBox(cbTeachersDiscipline);
        }
        public TeacherForm(MainForm fromForm, string last_name, string first_name, string middle_name, string birth_date, string work_since = "")
        {
            InitializeComponent();
            rtbLastName.Text = last_name;
            rtbFirstName.Text = first_name;
            rtbMiddleName.Text = middle_name;
            dtpBirthDate.Value = DateTime.Parse(birth_date);
            if (work_since != "") dtpWorkSince.Value = DateTime.Parse(work_since);
            cmd = $"SELECT photo FROM Teachers WHERE last_name=N'{rtbLastName.Text}' AND first_name=N'{rtbFirstName.Text}' AND middle_name=N'{rtbMiddleName.Text}' AND birth_date=N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}'";
            string photo_value = connector.Scalar(cmd).ToString();
            fromForm.LoadDataToComboBox(cbTeachersDiscipline);
            if (photo_value != "")
            {
                byte[] photo = connector.PhotoFromDB(cmd);
                ByteArrayToImage(photo);
                current_photo_path = photoPath;
                current_photo_path = photoPath;
            }
            dgvDisciplinesToTeacher.DataSource = connector.Select($"SELECT discipline_name FROM Disciplines,TeachersDisciplinesRelation,Teachers WHERE discipline_id = discipline AND teacher = teacher_id AND last_name=N'{rtbLastName.Text}' AND first_name=N'{rtbFirstName.Text}' AND middle_name=N'{rtbMiddleName.Text}' AND birth_date=N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}'");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            connector.Insert
                (
                "Teachers", "teacher_id,last_name,first_name,middle_name,birth_date,work_since",
                $"{connector.GetNextPrimaryKey("Teachers")}"
                +$",N'{rtbLastName.Text}'"
                + $",N'{rtbFirstName.Text}'"
                + $",N'{rtbMiddleName.Text}'"
                + $",N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}'"
                + $",N'{dtpWorkSince.Value.ToString("yyyy-MM-dd")}'"
                );
            string photo_condition = $"last_name=N'{rtbLastName.Text}' AND first_name=N'{rtbFirstName.Text}' AND middle_name=N'{rtbMiddleName.Text}' AND birth_date=N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}'";
            if (pictureBoxPhoto.Image != null && (connector.Scalar($"SELECT photo FROM Teachers WHERE {photo_condition}").ToString() == "" || current_photo_path != photoPath))
                connector.Update($"UPDATE Teachers SET photo = (SELECT BulkColumn FROM OPENROWSET(BULK N'{photoPath}', SINGLE_BLOB) AS image) WHERE {photo_condition}");
        }

        private void cbTeachersDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            string addDiscipline = cbTeachersDiscipline.SelectedItem.ToString();
            Console.WriteLine( addDiscipline );
            string teacher_id = connector.Scalar($"SELECT teacher_id FROM Teachers WHERE last_name=N'{rtbLastName.Text}' AND first_name=N'{rtbFirstName.Text}' AND middle_name=N'{rtbMiddleName.Text}' AND birth_date=N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}'").ToString();
            string discipline_id = connector.Scalar($"SELECT discipline_id FROM Disciplines WHERE discipline_name=N'{addDiscipline}'").ToString();
            connector.Insert
                (
                "TeachersDisciplinesRelation",
                "teacher,discipline",
                $"{teacher_id},{discipline_id}"
                );
        }
    }
}
