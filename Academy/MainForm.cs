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
            new Query(
                "Disciplines,DisciplinesDirectionsRelation,Directions",
                "discipline_id, discipline_name, number_of_lessons, direction_name",
                "discipline_id = discipline AND direction = direction_id"
                ),
            new Query("Teachers",   "*")
        };
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
                string filterOnDirections = queries[1].AddCondition($"direction = N'{cbGroups.GetItemText(cbGroups.SelectedIndex)}'");
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
                string filterOnDirections = queries[3].AddCondition($"direction = N'{cbDisciplines.GetItemText(cbDisciplines.SelectedIndex)}'");
                directions = connector.Select(filterOnDirections);
            }
            tables[3].DataSource = directions;
        }
    }
}
