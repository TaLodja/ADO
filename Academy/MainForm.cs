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
        string[] statusBarSignatures =
        {
            "Количество студетов",
            "Количество групп",
            "Количество направлеоий",
            "Количество дисциплин",
            "Количество преподавателей"
        };
        public MainForm()
        {
            InitializeComponent();
            tables = new DataGridView[] {dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers};
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
        }
    }
}
