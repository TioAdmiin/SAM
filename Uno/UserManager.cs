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
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
            loadUsers();
        }

        private void loadUsers()
        {
            DB1Entities db = new DB1Entities();
            dgvUsuarios.DataSource = db.Users.ToList();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }
    }
}
