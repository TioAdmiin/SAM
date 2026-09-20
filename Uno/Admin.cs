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
    public partial class Admin : Form
    {

        private Users admin;
        public Admin(Users user)
        {
            if (user.Admin != true)
            {
                this.Close();
            }
            admin = user;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            new Reports(admin).Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UserManager(admin).Show();
        }
    }
}
