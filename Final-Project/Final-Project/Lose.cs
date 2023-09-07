using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();

            Welcome.music.Stop();
            System.Media.SoundPlayer musicWin = new System.Media.SoundPlayer();
            musicWin.SoundLocation = "D:\\study\\FinalProject\\Final-Project\\Final-Project\\Resources\\sound-lose.wav";
            musicWin.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome.music.Play();
            Hide();
            Game form = new Game();
            form.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Welcome.music.Play();
            Hide();
            Welcome form = new Welcome();
            form.ShowDialog();
        }
    }
}
