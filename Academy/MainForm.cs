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
    public partial class MainForm : Form
    {
        Connector connector;
        Connector movies_connector;
        public MainForm()
        {
            InitializeComponent();
            connector = new Connector("Data Source=DESKTOP-MU2UJAA\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            movies_connector = new Connector("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_SPU_411;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //dgvDirections.DataSource = movies_connector.Select("SELECT [№\nп/п] = movie_id,[Название фильма] = title,[Режиссер] = FORMATMESSAGE(N'%s %s', first_name,last_name) FROM Movies, Directors WHERE director = director_id ORDER BY movie_id");
            //dgvDirections.DataSource = movies_connector.Select("SELECT * FROM Movies");
            dgvDirections.DataSource = connector.Select("SELECT * FROM Directions");
            toolStripStatusLabel.Text = $"Количество направлений обучения: {dgvDirections.RowCount-1}";
            //toolStripStatusLabel.Text = $"Количество направлений обучения: {connector.Scalar("SELECT COUNT(*) FROM Directions")}";

        }
    }
}
