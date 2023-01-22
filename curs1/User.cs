using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace curs1
{
    class User
    {
        private string UserName;
        private string UserPassword;
        private string PasswordConfirm;
        Database database = new Database();
        public User(string username, string password, string passwordconfirm = null)
        {
            UserName = username;
            UserPassword = password;
            PasswordConfirm = passwordconfirm;
        }

        // Проверяет правильность введенных данных в форме входа
        public bool CorrectEntered()
        {
            if (UserName == "" || UserName == null)
            {
                MessageBox.Show("Введите имя пользователя.");
                return false;
            }
            if (UserPassword == "" || UserPassword == null)
            {
                MessageBox.Show("Введите пароль.");
                return false;
            }

            if (UserName.Length < 4)
            {
                MessageBox.Show("Имя пользователя должно быть больше 4 символов.");
                return false;
            }

            if (UserName.Length > 15)
            {
                MessageBox.Show("Имя пользователя должно быть меньше 15 символов.");
                return false;
            }

            if (UserPassword.Length < 5)
            {
                MessageBox.Show("Пароль должен быть больше 5 символов.");
                return false;
            }
            if (UserPassword.Length > 10)
            {
                MessageBox.Show("Пароль должен быть меньше 10 символов.");
                return false;
            }

            if (UserPassword != PasswordConfirm)
            {
                MessageBox.Show("Пароли не совпадают.");
                return false;
            }
            return true;

            
            
        }
        //создание пользователя
        public void CreateUser()
        {
            database.CreateUser(UserName, UserPassword);
        }

        public bool UsernameCheck()
        {
            bool Check = database.UsernameCheck(UserName);
            if (!Check)
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
            }
            return Check;
        }
        public bool UserAutorisation()
        {
            bool Check = database.Autorisation(UserName, UserPassword);
            if (!Check)
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
            return Check;
        }
    }
}
