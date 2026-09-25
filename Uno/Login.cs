using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            
            Users user = ValidateCredentials(username, password);

            if (user != null)
            {
                Loged loged = new Loged(user);
                loged.Show();

                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas.");
            }
        }

        private Users ValidateCredentials(string username, string password)
        {
            using (DB1Entities db = new DB1Entities())
            {
                Users user = db.Users
                    .Include("Entradas")
                    .Include("Salidas")
                    .Include("UserWorkDays")
                    .FirstOrDefault(u => u.Username == username);

                if (user == null)
                {
                    return null;
                }

                if (!PasswordHasher.VerifyPassword(password, user.Password))
                {
                    return null;
                }

                if (!PasswordHasher.IsHashedPassword(user.Password))
                {
                    user.Password = PasswordHasher.HashPassword(password);
                    db.SaveChanges();
                }

                return user;
            }
        }
    }
}
