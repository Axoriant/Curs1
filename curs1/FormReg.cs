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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace curs1
{
    public partial class FormReg : Form
    {
       

        public FormReg()
        {
            InitializeComponent();

           

        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           
            textBoxLogin.Text = textBoxLogin.Text.Trim();
            textBoxPassword.Text = textBoxPassword.Text.Trim();
            textBoxPassword_2.Text = textBoxPassword_2.Text.Trim();

            User user = new User(textBoxLogin.Text, textBoxPassword.Text, textBoxPassword_2.Text);
            bool CorrectEnteredBool = user.CorrectEntered();
            bool CorrectUsername = user.UsernameCheck();
            if (CorrectEnteredBool && CorrectUsername)
            {
                user.CreateUser();
                MessageBox.Show("Вы зарегистрировались");
                this.Hide();
                var formAuth = new FormAuth();
                formAuth.Closed += (s, args) => this.Close();
                formAuth.Show();
            }
        }  

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBoxPassword_2.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword_2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            if (checkBox2.Checked)
            {
                textBoxPassword_2.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword_2.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}

