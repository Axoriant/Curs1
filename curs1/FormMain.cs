using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace curs1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("do-major.wav");
            Simple.Play();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("re-major.wav");
            Simple.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("G-major.wav");
            Simple.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("A-major.wav");
            Simple.Play();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Am", "Dm", "F", "C", "G", "Em" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonFsharpm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "F#m", "C#m", "Bm", "D", "A", "E" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonEm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Em", "Am", "C", "G", "D", "A" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonBm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Bm", "Em", "G", "D", "A", "F#m" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonCshm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "C#m", "F#m", "A", "E", "B", "G#m" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonGsham_Click(object sender, EventArgs e)
        {
            string[] myArr = { "G#m", "C#m", "E", "B", "F#", "Ebm" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonCm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Cm", "Fm", "Ab", "Eb", "Bb", "Gm" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonEbm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Ebm", "G#m", "B", "F#", "C#", "Bbm" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonBbm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Bbm", "Ebm", "F#", "C#", "Ab", "Fm" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonFm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Fm", "Bbm", "C#", "Ab", "Eb", "Cm" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0)) 
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonGm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Gm", "Cm", "Eb", "Bb", "F", "Dm" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void buttonDm_Click(object sender, EventArgs e)
        {
            string[] myArr = { "Dm", "Gm", "Bb", "F", "C", "Am" };
            Random r = new Random();
            int[] gen = { 0, 0, 0, 0, 0, 0 };
            string result = "";
            int t = 0;
            while ((gen[0] == 0) || (gen[1] == 0) || (gen[2] == 0) || (gen[3] == 0) || (gen[4] == 0) || (gen[5] == 0))
            {
                t = r.Next(0, 6);
                if (gen[t] == 0)
                {
                    result += " ";
                    result += myArr[t];
                    gen[t] = 1;
                }

            }
            MessageBox.Show(result);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("E.wav");
            Simple.Play();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("F.wav");
            Simple.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("B.wav");
            Simple.Play();
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("Am.wav");
            Simple.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("Bm.wav");
            Simple.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("Cm.wav");
            Simple.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("Dm.wav");
            Simple.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("Em.wav");
            Simple.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("Fm.wav");
            Simple.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer("Gm.wav");
            Simple.Play();

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage16_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

