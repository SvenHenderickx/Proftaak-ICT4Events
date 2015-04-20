using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Events_S24_Groep_E
{
    public partial class PostFormImage : Form
    {
        Administratie administratie;

        public PostFormImage()
        {
            InitializeComponent();
            administratie = new Administratie();
            LaadAfbeelding();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void LaadAfbeelding()
        {
            Image image = Image.FromFile(administratie.TempBericht.GeefBestandPad());
            pbFoto.Image = image;
            pbFoto.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Height = pbFoto.Height;
            this.Width = pbFoto.Width;
        }
    }
}
