using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class HumanForm : Form
    {
        public string photoPath { get; set; }
        //public byte[] photo { get; set; }
        public HumanForm()
        {
            InitializeComponent();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            string directory = $"{Application.ExecutablePath}\\..\\..\\..\\photo";
            Directory.SetCurrentDirectory(directory);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                //photo = GetPhoto(openFileDialog.FileName);
                photoPath = openFileDialog.FileName;
                //string directoryName = Path.GetDirectoryName(filePath);
                //if (directoryName.Contains("Students"))
                //{
                //    
                //}
            }
        }
        public byte[] GetPhoto(string photoPath)
        {
            FileStream stream = new FileStream(photoPath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);
            Console.WriteLine(photo);
            reader.Close();
            stream.Close();
            return photo;
        }
        public void ByteArrayToImage(byte[] bytes)
        {
                MemoryStream stream = new MemoryStream(bytes);
                pictureBoxPhoto.Image = Image.FromStream(stream);
                stream.Close();
        }
    }
}
