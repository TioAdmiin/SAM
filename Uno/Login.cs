using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DB1Entities db = new DB1Entities();
            List<Users> users = db.Users.ToList();
            foreach (Users u in users)
            {
                if (u.Username == username && u.Password == password)
                {
                    return u;
                }
            }
            return null; // Cambia esto según tu lógica de validación
        }
    }
}
