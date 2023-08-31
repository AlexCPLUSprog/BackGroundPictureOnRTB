using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackGroundPictureOnRTB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string open_file()
        {
            string file_name = "<none>";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Картинки *.bmp| *.bmp| Картинки *.jpg | *.jpg";
            ofd.InitialDirectory = Environment.CurrentDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file_name = ofd.FileName;
            }
            return file_name;
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string path = open_file();
            if (path != "<none>")
            {
                this.BackgroundImage = new Bitmap(path);
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.BackColor = colorDialog.Color;
                }
                
            }
            else 
            {
                MessageBox.Show("Фоновая картинка прежняя");
            }
            
        }
    }
}
