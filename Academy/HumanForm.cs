using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Academy
{
    public partial class HumanForm : Form
    {
        public HumanForm()
        {
            InitializeComponent();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog photoDialog = new OpenFileDialog();
            photoDialog.ShowDialog();
            if (photoDialog.FileName != "")
                pictureBoxPhoto.Image = Image.FromFile(photoDialog.FileName);
        }
    }
}
