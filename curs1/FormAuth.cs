using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace curs1
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            textBoxLogin.Text = textBoxLogin.Text.Trim();
            textBoxPassword.Text = textBoxPassword.Text.Trim();
            try
            {
                string hash = textBoxPassword.Text;
                User user = new User(textBoxLogin.Text, textBoxPassword.Text);
                
                if (user.UserAutorisation())
                {
                    this.Hide();
                    var formMain = new FormMain();
                    formMain.Closed += (s, args) => this.Close();
                    formMain.Show();
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formReg = new FormReg();
            formReg.Closed += (s, args) => this.Close();
            formReg.Show();
            //DialogResult authDialogResult = new FormReg().ShowDialog();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
