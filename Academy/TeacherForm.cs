using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class TeacherForm : HumanForm
    {
        public TeacherForm()
        {
            InitializeComponent();
            cbDisciplines.DataSource = DataBase.Connector.Select("*", "Disciplines");
            cbDisciplines.DisplayMember = "discipline_name";
            cbDisciplines.ValueMember = "discipline_id";
            DisciplineVisibility(false);
        }
        public TeacherForm(int id) : this()
        {
            DisciplineVisibility(true);
            DataTable data = DataBase.Connector.Select("*", "teachers", $"teacher_id={id}");
            labelID.Text = $"ID: {id}";
            rtbLastName.Text = data.Rows[0]["last_name"].ToString();
            rtbFirstName.Text = data.Rows[0]["first_name"].ToString();
            rtbMiddleName.Text = data.Rows[0]["middle_name"].ToString();
            dtpBirthDate.Value = Convert.ToDateTime(data.Rows[0]["birth_date"].ToString());
            rtbEmail.Text = data.Rows[0]["email"].ToString();
            rtbPhone.Text = data.Rows[0]["phone"].ToString();
            pictureBoxPhoto.Image = DataBase.Connector.DownloadPhoto(id, "Teachers", "photo");
            DateTime work_since = data.Rows[0]["work_since"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(data.Rows[0]["work_since"].ToString());
            dtpWorkSince.Value = work_since;
            decimal rate = data.Rows[0]["rate"] == DBNull.Value ? 0 : decimal.Parse(data.Rows[0]["rate"].ToString());
            numericUpDownRate.Value = rate;
            dgvTeachersDisciplines.DataSource = DataBase.Connector.Select
                (
                "discipline_name",
                "Disciplines,TeachersDisciplinesRelation,Teachers",
                $"discipline_id=discipline AND teacher_id=teacher AND teacher_id={id}"
                );
            labelDisciplines.Text = $"Читает {dgvTeachersDisciplines.RowCount} дисциплин(ы)";
        }
        private void DisciplineVisibility(bool visible)
        {
            labelChooseDiscipline.Visible = visible;
            cbDisciplines.Visible = visible;
            labelDisciplines.Visible = visible;
            dgvTeachersDisciplines.Visible = visible;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            int id = labelID.Text.Split(':').Last() == "" ? 0 : Convert.ToInt32(labelID.Text.Split(':').Last());
            Academy.Models.Teacher teacher = new Models.Teacher
                (
                id,
                rtbLastName.Text,
                rtbFirstName.Text,
                rtbMiddleName.Text,
                dtpBirthDate.Value.ToString("yyyy-MM-dd"),
                rtbEmail.Text,
                rtbPhone.Text,
                pictureBoxPhoto.Image,
                dtpWorkSince.Value.ToString("yyyy-MM-dd"),
                numericUpDownRate.Value.ToString("#,####")
                );
            if (teacher.id == 0)
            {
                teacher.id = DataBase.Connector.GetNextPrimaryKey("Teachers");
                DataBase.Connector.Insert($"INSERT Teachers(teacher_id,{teacher.GetNames()}) VALUES ({teacher.id},{teacher})");
            }
            else
            {
                DataBase.Connector.Update($"UPDATE Teachers SET {teacher.ToStringUpdate()} WHERE teacher_id={teacher.id}");
            }
            if (teacher.photo != null)
                DataBase.Connector.UploadPhoto(teacher.SerializePhoto(), teacher.id, "photo", "Teachers");
        }

        private void cbDisciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            int discipline_id = Convert.ToInt32(cbDisciplines.SelectedValue);
            int id = Convert.ToInt32(labelID.Text.Split(':').Last());
            DataBase.Connector.Insert
                (
                "TeachersDisciplinesRelation",
                "teacher,discipline",
                $"{id},{discipline_id}"
                );
        }
    }
}
