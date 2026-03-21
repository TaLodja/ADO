using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

using DBtools;

namespace Academy
{
    public partial class MainForm : Form
    {
        Query[] queries =
        {
            new Query
                (
                "Students,Groups,Directions",
                "[Student] = FORMATMESSAGE(N'%s %s %s',last_name,first_name,middle_name),group_name,direction_name",
                "[group]=group_id AND direction=direction_id"
                ),
            new Query
                (
                "Groups,Directions",
                "group_name,weekdays,start_time,start_date,direction_name",
                "direction = direction_id"
                ),
            new Query("Directions", "*"),
            new Query("Disciplines", "discipline_id,discipline_name,number_of_lessons"),
            new Query("Teachers",   "*")
        };

        Query TeachersForDiscipline = new Query
            (
            "Teachers,TeachersDisciplinesRelation,Disciplines",
            "[Teachers] = FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name)",
            "teacher_id = teacher AND discipline_id = discipline"
            );
        Query DisciplinesForTeacher = new Query
            (
            "Teachers,TeachersDisciplinesRelation,Disciplines",
            "discipline_name",
            "teacher_id = teacher AND discipline_id = discipline"
            );

        Connector connector;
        //Connector movies_connector;
        DataGridView[] tables = null;
        ComboBox[] filters = null;
        string[] statusBarSignatures =
        {
            "Количество студетов",
            "Количество групп",
            "Количество направлений",
            "Количество дисциплин",
            "Количество преподавателей"
        };
        public MainForm()
        {
            InitializeComponent();
            tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
            filters = new ComboBox[] { cbStudents, cbGroups, null, cbDisciplines, null, cbStudentsGroup };
            AllocConsole();
            connector = new Connector("Data Source=DESKTOP-MU2UJAA\\SQLEXPRESS;"
                                        + "Initial Catalog=SPU_411_Import;"
                                        + "Integrated Security=True;"
                                        + "Connect Timeout=30;"
                                        + "Encrypt=True;"
                                        + "TrustServerCertificate=True;"
                                        + "ApplicationIntent=ReadWrite;"
                                        + "MultiSubnetFailover=False");
            tabControl_SelectedIndexChanged(tabControl, null);
        }
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = tabControl.SelectedIndex;
            tables[i].DataSource = connector.Select(queries[i].ToString());
            toolStripStatusLabel.Text = $"{statusBarSignatures[i]}: {tables[i].RowCount - 1}";
            if (filters[i] != null) FillComboBoxDirections();
            FillComboBoxGroups();
            dgvTeachersDiscipline.Visible = false;
            dgvDisciplinesTeacher.Visible = false;
        }

        private void FillComboBoxDirections()
        {
            string cmd = "SELECT direction_name FROM Directions";
            DataTable directions = new DataTable();
            directions = connector.Select(cmd);
            DataRow allDirections = directions.NewRow();
            directions.Rows.InsertAt(allDirections, 0);
            allDirections[0] = "All Directions";
            filters[tabControl.SelectedIndex].DataSource = directions;
            filters[tabControl.SelectedIndex].DisplayMember = "direction_name";
        }
        private void FillComboBoxGroups()
        {
            string cmd = "SELECT group_name FROM Groups";
            DataTable groups = new DataTable();
            groups = connector.Select(cmd);
            DataRow allGroups = groups.NewRow();
            groups.Rows.InsertAt(allGroups, 0);
            allGroups[0] = "All Groups";
            cbStudentsGroup.DataSource = groups;
            cbStudentsGroup.DisplayMember = "group_name";
        }
        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable directions = new DataTable();
            if (cbGroups.SelectedIndex == 0)
                directions = connector.Select(queries[1].ToString());
            if (cbGroups.SelectedIndex > 0)
            {
                string filterOnDirections = queries[1].AddCondition($"direction = N'{cbGroups.SelectedIndex}'");
                directions = connector.Select(filterOnDirections);
            }
            tables[1].DataSource = directions;
        }

        private void cbDisciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable directions = new DataTable();
            if (cbDisciplines.SelectedIndex == 0)
                directions = connector.Select(queries[3].ToString());
            if (cbDisciplines.SelectedIndex > 0)
            {
                string filterOnDirections = queries[3].AddTableWithConditions("DisciplinesDirectionsRelation,Directions", $"discipline_id = discipline AND direction = direction_id AND direction = N'{cbDisciplines.SelectedIndex}'");
                directions = connector.Select(filterOnDirections);
            }
            tables[3].DataSource = directions;
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable directions = new DataTable();
            string filterOnDirections = "";
            if (cbStudents.SelectedIndex == 0 && cbStudentsGroup.SelectedIndex == 0)
                directions = connector.Select(queries[0].ToString());
            if (cbStudents.SelectedIndex > 0 && cbStudentsGroup.SelectedIndex == 0)
            {
                filterOnDirections = queries[0].AddCondition($"direction = N'{cbStudents.SelectedIndex}'");
                directions = connector.Select(filterOnDirections);
            }
            if (cbStudentsGroup.SelectedIndex > 0 && cbStudents.SelectedIndex == 0)
            {
                filterOnDirections = queries[0].AddCondition($"[group] = N'{cbStudentsGroup.SelectedIndex}'");
                directions = connector.Select(filterOnDirections);
            }
            if (cbStudentsGroup.SelectedIndex > 0 && cbStudents.SelectedIndex > 0)
            {
                filterOnDirections = queries[0].AddCondition($"[group] = N'{cbStudentsGroup.SelectedIndex}' AND direction = N'{cbStudents.SelectedIndex}'");
                directions = connector.Select(filterOnDirections);
            }
            tables[0].DataSource = directions;
        }

        private void cbStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable groups = new DataTable();
            string filterOnGroups = "";
            if (cbStudentsGroup.SelectedIndex == 0 && cbStudents.SelectedIndex == 0)
                groups = connector.Select(queries[0].ToString());
            if (cbStudentsGroup.SelectedIndex == 0 && cbStudents.SelectedIndex > 0)
            {
                filterOnGroups = queries[0].AddCondition($"direction = N'{cbStudents.SelectedIndex}'");
                groups = connector.Select(filterOnGroups);
            }
            if (cbStudentsGroup.SelectedIndex > 0 && cbStudents.SelectedIndex == 0)
            {
                filterOnGroups = queries[0].AddCondition($"[group] = N'{cbStudentsGroup.SelectedIndex}'");
                groups = connector.Select(filterOnGroups);
            }
            if (cbStudentsGroup.SelectedIndex > 0 && cbStudents.SelectedIndex > 0)
            {
                filterOnGroups = queries[0].AddCondition($"[group] = N'{cbStudentsGroup.SelectedIndex}' AND direction = N'{cbStudents.SelectedIndex}'");
                groups = connector.Select(filterOnGroups);
            }
            tables[0].DataSource = groups;
        }


        private void dgvDisciplines_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedItem = dgvDisciplines.CurrentRow.Cells[0].Value.ToString();
            dgvDisciplines.Rows[dgvDisciplines.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
            string cmd = TeachersForDiscipline.AddCondition($"discipline = {selectedItem}").ToString();
            dgvTeachersDiscipline.DataSource = connector.Select(cmd);
            //dgvTeachersDiscipline.Location = new Point(e.X, e.Y);
            dgvTeachersDiscipline.Visible = true;
            if (dgvDisciplines.CurrentRow.Cells[0].Value.ToString() == "") dgvTeachersDiscipline.Visible = false;
            else dgvTeachersDiscipline.Visible = true;
        }

        private void dgvTeachers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dgvTeachers.CurrentCell.RowIndex < dgvTeachers.RowCount)
            //{
                string selectedItem = dgvTeachers.CurrentRow.Cells[0].Value.ToString();
                dgvTeachers.Rows[dgvTeachers.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
                string cmd = DisciplinesForTeacher.AddCondition($"teacher = {selectedItem}").ToString();
                dgvDisciplinesTeacher.Visible = true;
                dgvDisciplinesTeacher.DataSource = connector.Select(cmd);
                //dgvDisciplinesTeacher.Location = new Point(e.X, e.Y);
                dgvDisciplinesTeacher.Visible = true;
            //}
        }

        private void dgvDisciplines_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedItem = dgvDisciplines.CurrentRow.Cells[0].Value.ToString();
            dgvDisciplines.Rows[Convert.ToInt32(selectedItem) - 1].DefaultCellStyle.BackColor = DefaultBackColor;
        }

        private void dgvTeachers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string selectedItem = dgvTeachers.CurrentRow.Cells[0].Value.ToString();
            dgvTeachers.Rows[Convert.ToInt32(selectedItem) - 1].DefaultCellStyle.BackColor = DefaultBackColor;
        }
    }
}
