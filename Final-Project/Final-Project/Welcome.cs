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
using System.Media;

namespace Final_Project
{
    public partial class Welcome : Form
    {
        private static bool simpleCheck;
        private static bool audioFlag;
        public static SoundPlayer music = new SoundPlayer();
        public Welcome()
        {
            InitializeComponent();
        }

        public static bool GetSimpleCheck()
        {
            return simpleCheck;
        }
        public static bool GetAudioFlag()
        {
            return audioFlag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            simpleCheck = false;
            Hide();
            Game form = new Game();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            music.SoundLocation = "D:\\study\\FinalProject\\Final-Project\\Final-Project\\Resources\\sound-1.wav";
            if (!audioFlag)
            {
                music.Play();
                audioFlag = true;
            }
            else
            {
                music.Stop();
                audioFlag = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            simpleCheck = true;
            Game.score = 0;
            Hide();
            Game form = new Game();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Instruction form = new Instruction();
            form.ShowDialog();
        }
    }
}
