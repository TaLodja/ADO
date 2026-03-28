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
        AddGroup addGroup;
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
        Query TeachersAndDiscipline = new Query
                (
                "Teachers,TeachersDisciplinesRelation,Disciplines",
                "*",
                "teacher_id = teacher AND discipline_id = discipline"
                );
        Connector connector;
        //Connector movies_connector;
        DataGridView[] tables = null;
        ///////////////////////////////////

        Dictionary<string, int> d_directions = null;
        Dictionary<string, Dictionary<string, int>> d_trees = null;
        string[] statusBarSignatures =
        {
            "Количество студетов",
            "Количество групп",
            "Количество направлеоий",
            "Количество дисциплин",
            "Количество преподавателей"
        };
        DataGridViewComboBoxCell cbDirections = new DataGridViewComboBoxCell();
        public MainForm()
        {
            InitializeComponent();
            tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
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

            d_trees = new Dictionary<string, Dictionary<string, int>>();
            d_trees.Add(nameof(d_directions), d_directions);
            LoadDataToComboBox(cbGroupsDirection);
            LoadDataToComboBox(cbStudentsGroup);
            LoadDataToComboBox(cbStudentsDirection);
            LoadDataToComboBox(cbDisciplinesDirection);

            addGroup = new AddGroup();
        }
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        void LoadDataToComboBox(ComboBox comboBox)
        {
            string table = comboBox.Name.Substring(Array.FindLastIndex<char>(comboBox.Name.ToCharArray(), Char.IsUpper)) + "s";
            string dictionary_name = $"d_{table}".ToLower();
            Console.WriteLine("======================================");
            Console.WriteLine(table);
            Console.WriteLine(dictionary_name);
            Console.WriteLine(nameof(dictionary_name));
            Console.WriteLine("======================================");
            d_trees[dictionary_name] = connector.LoadDictionary(table);
            foreach (KeyValuePair<string, int> i in d_trees[dictionary_name])
            {
                comboBox.Items.Add(i.Key);
            }
            comboBox.Items.Insert(0, "All");
        }

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
            if (i == 3) dgvTeachersToDiscipline.Visible = false;
            if (i == 4) dgvDisciplinesToTeacher.Visible = false;
        }

        private void cbGroupsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupsDirection.SelectedIndex > 0)
                tables[1].DataSource = connector.Select
                    (
                    queries[1].ToString() + $" AND direction = {d_trees["d_directions"][cbGroupsDirection.SelectedItem.ToString()]}"
                    );
            if (cbGroupsDirection.SelectedIndex == 0)
                tables[1].DataSource = connector.Select(queries[1].ToString());
            toolStripStatusLabel.Text = $"{statusBarSignatures[1]}: {tables[1].RowCount - 1}";
        }
        void cbStudentsFilters()
        {
            if (cbStudentsDirection.SelectedIndex > 0 && cbStudentsGroup.SelectedIndex <= 0)
                tables[0].DataSource = connector.Select
                    (
                    queries[0].ToString()
                    + $" AND direction = {d_trees["d_directions"][cbStudentsDirection.SelectedItem.ToString()]}"
                    );
            if (cbStudentsDirection.SelectedIndex == 0 && cbStudentsDirection.SelectedIndex == 0)
                tables[0].DataSource = connector.Select(queries[0].ToString());
            if (cbStudentsDirection.SelectedIndex <= 0 && cbStudentsGroup.SelectedIndex > 0)
                tables[0].DataSource = connector.Select
                    (
                    queries[0].ToString()
                    + $" AND [group] = {d_trees["d_groups"][cbStudentsGroup.SelectedItem.ToString()]}"
                    );
            if (cbStudentsDirection.SelectedIndex > 0 && cbStudentsGroup.SelectedIndex > 0)
                tables[0].DataSource = connector.Select
                    (
                    queries[0].ToString()
                    + $" AND direction = {d_trees["d_directions"][cbStudentsDirection.SelectedItem.ToString()]}"
                    + $" AND [group] = {d_trees["d_groups"][cbStudentsGroup.SelectedItem.ToString()]}"
                    );
            toolStripStatusLabel.Text = $"{statusBarSignatures[0]}: {tables[0].RowCount - 1}";
        }

        private void cbStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStudentsFilters();
        }

        private void cbStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStudentsFilters();
        }

        private void cbDisciplinesDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDisciplinesDirection.SelectedIndex > 0)
            {
                tables[3].DataSource = connector.Select
                    (
                    queries[3].ChangeQuery("DisciplinesDirectionsRelation,Directions", "discipline_id,discipline_name,number_of_lessons", "discipline_id = discipline AND direction = direction_id").ToString()
                    + $" AND direction = {d_trees["d_directions"][cbDisciplinesDirection.SelectedItem.ToString()]}"
                    );
            }
            if (cbDisciplinesDirection.SelectedIndex == 0)
                tables[3].DataSource = connector.Select(queries[3].ToString());
            toolStripStatusLabel.Text = $"{statusBarSignatures[3]}: {tables[3].RowCount - 1}";
        }
        void FilterReset()
        {
            string tabName = tabControl.SelectedTab.Text;
            (tabControl.SelectedTab.Controls[$"cb{tabName}Direction"] as ComboBox).SelectedIndex = -1;
            if (tabName == "Students") (tabControl.SelectedTab.Controls[$"cb{tabName}Group"] as ComboBox).SelectedIndex = -1;
            tabControl_SelectedIndexChanged(tabControl, EventArgs.Empty);
        }
        private void buttonStudentsFilterReset_Click(object sender, EventArgs e)
        {
            FilterReset();
        }

        private void buttonGroupsFilterReset_Click(object sender, EventArgs e)
        {
            FilterReset();
        }

        private void buttonDisciplinesFilterReset_Click(object sender, EventArgs e)
        {
            FilterReset();
        }

        void TeachersDisciplineRelation()
        {
            string dgvName = $"dgv{tabControl.SelectedTab.Text}";
            string dgvRelationName =
                tabControl.SelectedTab.Text == "Disciplines" ?
                $"dgvTeachersTo{tabControl.SelectedTab.Text.Substring(0, tabControl.SelectedTab.Text.Length - 1)}" :
                $"dgvDisciplinesTo{tabControl.SelectedTab.Text.Substring(0, tabControl.SelectedTab.Text.Length - 1)}";
            DataGridView dgv = (DataGridView)tabControl.SelectedTab.Controls[dgvName];
            DataGridView dgvRelation = (DataGridView)tabControl.SelectedTab.Controls[dgvRelationName];
            string selectedId = dgv.CurrentRow.Cells[0].Value.ToString();
            dgv.Rows[dgv.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
            string fields =
                tabControl.SelectedTab.Text == "Disciplines" ?
                "[Teachers] = FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name)" :
                "discipline_name";
            string conditions =
                tabControl.SelectedTab.Text == "Disciplines" ?
                $"discipline = {selectedId}" :
                $"teacher = {selectedId}";
            dgvRelation.DataSource = connector.Select(TeachersAndDiscipline.ChangeQuery("", fields, conditions).ToString());
            //dgvRelation.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            dgvRelation.Visible = true;
        }
        private void dgvDisciplines_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TeachersDisciplineRelation();
        }
        private void dgvTeachers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TeachersDisciplineRelation();
        }
        private void dgvDisciplines_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) =>
            dgvDisciplines.Rows[dgvDisciplines.CurrentCell.RowIndex].DefaultCellStyle.BackColor = DefaultBackColor;

        private void dgvTeachers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) =>
            dgvTeachers.Rows[dgvTeachers.CurrentCell.RowIndex].DefaultCellStyle.BackColor = DefaultBackColor;


        private void dgvGroups_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGroups.Columns[dgvGroups.CurrentCell.ColumnIndex].Name == "direction_name")
            {
                Console.WriteLine("----------------------------------------------");
                for (int i = 1; i < cbGroupsDirection.Items.Count; i++)
                {
                    //cbDirections.DataSource = cbGroupsDirection.Items[i];
                    cbDirections.Items.Add(cbGroupsDirection.Items[i]);
                    Console.WriteLine($"{cbGroupsDirection.Items[i]}");
                }
                dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[dgvGroups.CurrentCell.ColumnIndex] = cbDirections;
                string selectedValue = cbDirections.Value.ToString();
                Console.WriteLine($"-------{dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[dgvGroups.CurrentCell.ColumnIndex].EditedFormattedValue.ToString()}");
                Console.WriteLine($"--------------------------------------");
                //dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[dgvGroups.CurrentCell.ColumnIndex].Value = cbDirections.Value;
            }
            for (int i = 0; i < dgvGroups.ColumnCount - 1; i++)
            {

            }
        }

        private void dgvGroups_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGroups.Columns[dgvGroups.CurrentCell.ColumnIndex].Name == "direction_name")
            {
                //dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[dgvGroups.CurrentCell.ColumnIndex].Value = cbDirections.ValueMember;
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"{cbDirections.Value.ToString()}");
                Console.WriteLine($"--------------------------------------");
            }
            Console.WriteLine($"-------{dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[dgvGroups.CurrentCell.ColumnIndex].Value.ToString()}");
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            addGroup.ShowDialog();
        }
        


        //private void cbDirections_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[dgvGroups.CurrentCell.ColumnIndex].Value = cbDirections.ToString();
        //    Console.WriteLine("----------------------------------------------");
        //    Console.WriteLine($"{dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[dgvGroups.CurrentCell.ColumnIndex].Value}");
        //    Console.WriteLine("----------------------------------------------");
        //        if (cbDirections.Selected == true)
        //        {

        //        }
        //}



        //private void dgvStudents_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    string[] values = new string[] { };
        //        for (int i = 0; i < dgvStudents.ColumnCount; i++)
        //        {
        //            values[i] = dgvStudents.CurrentRow.Cells[i].Value.ToString();
        //            Console.WriteLine(values[i]);
        //        }
        //}
        //private void dgvStudents_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyValue == (char)Keys.Enter)
        //    {
        //        string[] values = new string[] { };
        //        for (int i = 0; i < dgvStudents.ColumnCount; i++)
        //        {
        //            values[i] = dgvStudents.CurrentRow.Cells[i].Value.ToString();
        //            Console.WriteLine(values[i]);
        //        }
        //    }
        //}


        //private void dgvStudents_Enter(object sender, EventArgs e)
        //{
        //    string[] values = new string[] { };
        //    for (int i = 0; i < dgvStudents.ColumnCount; i++)
        //    {
        //        values[i] = dgvStudents.CurrentRow.Cells[i].Value.ToString();
        //        Console.WriteLine(values[i]);
        //    }
        //}
    }
}
