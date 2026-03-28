using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBtools;

namespace Academy
{
    public partial class AddGroup : Form
    {
        Connector connector;
        public AddGroup()
        {
            InitializeComponent();
            connector = new Connector("Data Source=DESKTOP-MU2UJAA\\SQLEXPRESS;"
                                        + "Initial Catalog=SPU_411_Import;"
                                        + "Integrated Security=True;"
                                        + "Connect Timeout=30;"
                                        + "Encrypt=True;"
                                        + "TrustServerCertificate=True;"
                                        + "ApplicationIntent=ReadWrite;"
                                        + "MultiSubnetFailover=False");
            FillComboBoxDirections();

        }

        private void FillComboBoxDirections()
        {
            string cmd = "SELECT direction_name FROM Directions";
            DataTable directions = new DataTable();
            directions = connector.Select(cmd);
            cbDirections.DataSource = directions;
            cbDirections.DisplayMember = "direction_name";
        }
        private void buttonSaveGroup_Click(object sender, EventArgs e)
        {
            int last_id = connector.MAX_PrimaryKey("Groups", "group_id");
            string fields = $"group_id,{lbGroupName.Text},{lbDirection.Text},{lbWeekdays.Text},{lbStartTime.Text},{lbStartDate.Text}";
            string values = $"{last_id+1},{tbGroupName.Text},{cbDirections.SelectedIndex + 1},{tbWeekdays.Text},{tbStartTime.Text},{tbStartDate.Text}";
            connector.Insert("Groups",fields,values);
            Close();
        }

    }
}
