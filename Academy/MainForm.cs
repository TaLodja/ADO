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
            new Query("Disciplines","*"),
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
            filters = new ComboBox[] { cbStudents, cbGroups, null, cbDisciplines, null };
            AllocConsole();
            connector = new Connector("Data Source=DESKTOP-MU2UJAA\\SQLEXPRESS;"
                                        + "Initial Catalog=SPU_411_Import;"
                                        + "Integrated Security=True;"
                                        + "Connect Timeout=30;"
                                        + "Encrypt=True;"
                                        + "TrustServerCertificate=True;"
                                        + "ApplicationIntent=ReadWrite;"
                                        + "MultiSubnetFailover=False");
            //movies_connector = new Connector("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_SPU_411;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //dgvDirections.DataSource = movies_connector.Select("SELECT [№\nп/п] = movie_id,[Название фильма] = title,[Режиссер] = FORMATMESSAGE(N'%s %s', first_name,last_name) FROM Movies, Directors WHERE director = director_id ORDER BY movie_id");
            //dgvDirections.DataSource = movies_connector.Select("SELECT * FROM Movies");
            tabControl_SelectedIndexChanged(tabControl, null);
            //tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            //dgvGroups.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvGroups_EditingControlShowing);
        }
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine($"{(sender as TabControl).SelectedIndex}\t{tabControl.SelectedTab.Text}");

            //Работает при модификаторе доступа у dvg - public
            /*DataGridView dgv = this.GetType().GetField($"dgv{tabControl.SelectedTab.Text}").GetValue(this) as DataGridView;
            dgv.DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
            toolStripStatusLabel.Text = $"Количество записей: {dgv.RowCount - 1}";*/

            int i = tabControl.SelectedIndex;
            tables[i].DataSource = connector.Select(queries[i].ToString());
            toolStripStatusLabel.Text = $"{statusBarSignatures[i]}: {tables[i].RowCount - 1}";
            if (filters[i] != null) FillComboBoxDirections();
        }

        private void FillComboBoxDirections()
        {
            Query directions_name = new Query("Directions", "direction_name");
            DataSet dataSet = new DataSet();
            //int n = dgvDirections.RowCount;
            DataTable directions = new DataTable();
            directions = connector.Select(directions_name.ToString());
            DataRow allDirections = directions.NewRow();
            directions.Rows.InsertAt(allDirections, 0);
            allDirections[0] = "All Directions";
            int i = tabControl.SelectedIndex;
            filters[i].DataSource = directions;
            filters[i].DisplayMember = "direction_name";
        }

        private void cbGroups_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable directions = new DataTable();
            Console.WriteLine("\n======================================================================================\n");
            Console.WriteLine(cbGroups.SelectedItem.ToString());
            Console.WriteLine("\n======================================================================================\n");
            if (cbGroups.SelectedIndex > -1 || cbGroups.SelectedItem.ToString() != "All Directions")
            {
                //string filterOnDirections = queries[1].AddCondition("direction_name LIKE N'Разработка%'");
                string filterOnDirections = queries[1].AddCondition($"direction_name = N'{cbGroups.SelectedItem.ToString()}'");
                directions = connector.Select(filterOnDirections);
            }
            if (cbGroups.SelectedIndex > -1 && cbGroups.SelectedText == "All Directions") 
                directions = connector.Select(queries[1].ToString());
            tables[1].DataSource = directions;
        }


        //private void dgvGroups_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    ComboBox comboBoxGroups = e.Control as ComboBox;
        //    if (comboBoxGroups != null)
        //    {
        //        comboBoxGroups.SelectedIndexChanged -= new EventHandler(cbGroups_SelectionChangeCommitted);
        //        comboBoxGroups.SelectedIndexChanged += new EventHandler(cbGroups_SelectionChangeCommitted);
        //    }
        //}

        //
        //private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataTable directions = new DataTable();
        //    if (cbGroups.SelectedIndex > -1 && cbGroups.SelectedText != "All Directions")
        //    if (cbGroups.SelectedIndex == -1) directions = connector.Select(queries[1].ToString());
        //    {
        //        string filterOnDirections = queries[1].AddCondition("direction_name LIKE N'Разработка%'");
        //        //string filterOnDirections = queries[1].AddCondition($"direction_name = N'{cbGroups.SelectedItem.ToString()}'");
        //        directions = connector.Select(filterOnDirections);
        //    }
        //    if (cbGroups.SelectedText == "All Directions") directions = connector.Select(queries[1].ToString());
        //    tables[1].DataSource = directions;
        //}

    }
}
