using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frogs_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ChangeImages((PictureBox)sender);
            if (leftPictureBox1.Location.X < 400 && leftPictureBox2.Location.X < 400 && leftPictureBox3.Location.X < 400 && leftPictureBox4.Location.X < 400 && emptyPictureBox.Location.X < 450)
            {
                Message message = new Message();
                message.Result = scoreLabel.Text;
                message.ShowDialog();
            }
        }

        private void ChangeImages(PictureBox pictureBox)
        {
            if (Math.Abs(pictureBox.Location.X - emptyPictureBox.Location.X) <= 200)
            {
                var TempPictureBox = pictureBox.Location;
                pictureBox.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = TempPictureBox;
                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Такой ход недопустим!");
            }
        }
    }
}
