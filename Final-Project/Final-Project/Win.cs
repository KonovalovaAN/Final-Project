using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Final_Project
{
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
            label3.Text = "Your score: " + Game.score.ToString() + "\n" + "Max score: 210";

            Welcome.music.Stop();
            System.Media.SoundPlayer musicWin = new System.Media.SoundPlayer();
            musicWin.SoundLocation = "D:\\study\\FinalProject\\Final-Project\\Final-Project\\Resources\\sound-win.wav";
            musicWin.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Welcome.music.Play();
            Hide();
            Welcome form = new Welcome();
            form.ShowDialog();
        }
    }
}