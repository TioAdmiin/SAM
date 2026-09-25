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
        private Users admin;
        private Users selectedUser;
        DB1Entities db = new DB1Entities();

        public UserManager(Users admin)
        {
            this.admin = admin;
            InitializeComponent();
            loadUsers();
        }

        private void loadUsers()
        {
            dgvUsuarios.DataSource = db.Users.ToList();
            dgvUsuarios.Columns["Password"].Visible = false;
            dgvUsuarios.Columns["Entradas"].Visible = false;
            dgvUsuarios.Columns["Faltas"].Visible = false;
            dgvUsuarios.Columns["Salidas"].Visible = false;
            dgvUsuarios.Columns["UserWorkDays"].Visible = false;
            dgvUsuarios.Columns["Admin"].ReadOnly = true;
        }

        private void dgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //desseleccionar todos los CheckBox de días de trabajo
            checkLunes.Checked = false;
            checkMartes.Checked = false;
            checkMiercoles.Checked = false;
            checkJueves.Checked = false;
            checkViernes.Checked = false;
            checkSabado.Checked = false;
            checkDomingo.Checked = false;

            //seleccionar el usuario de la fila seleccionada
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0 && selectedRowIndex < dgvUsuarios.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvUsuarios.Rows[selectedRowIndex];
                selectedUser = (Users) selectedRow.DataBoundItem;
                // Mostrar los datos del usuario seleccionado en los TextBox
                tbId.Text = selectedUser.Id.ToString();
                tbFullName.Text = selectedUser.FullName;
                tbUsername.Text = selectedUser.Username;
                tbPassword.Clear();
                checkAdmin.Checked = selectedUser.Admin;

                dateEntrada.Value = DateTime.Today.Add(selectedUser.hora_inicio);
                dateSalida.Value = DateTime.Today.Add(selectedUser.hora_final);

                // Mostrar los días de trabajo del usuario seleccionado en los CheckBox
                foreach (var day in selectedUser.UserWorkDays)
                {
                    switch (day.DiaSemana)
                    {
                        case 1:
                            checkLunes.Checked = true;
                            break;
                        case 2:
                            checkMartes.Checked = true;
                            break;
                        case 3:
                            checkMiercoles.Checked = true;
                            break;
                        case 4:
                            checkJueves.Checked = true;
                            break;
                        case 5:
                            checkViernes.Checked = true;
                            break;
                        case 6:
                            checkSabado.Checked = true;
                            break;
                        case 7:
                            checkDomingo.Checked = true;
                            break;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUser == null) { return; }
            selectedUser.FullName = tbFullName.Text;
            selectedUser.Username = tbUsername.Text;
            if (!string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                selectedUser.Password = PasswordHasher.HashPassword(tbPassword.Text);
            }
            selectedUser.Admin = checkAdmin.Checked;
            
            //Horas
            selectedUser.hora_inicio = dateEntrada.Value.TimeOfDay;
            selectedUser.hora_final = dateSalida.Value.TimeOfDay;

            selectedUser.UserWorkDays.Clear();

            //Dias
                    //Lunes
            if (checkLunes.Checked) 
            { 
                selectedUser.UserWorkDays.Add(new UserWorkDays { UserId = selectedUser.Id, DiaSemana = (byte) 1 }); 
            }
                    //Martes
            if (checkMartes.Checked) { 
                selectedUser.UserWorkDays.Add(new UserWorkDays { UserId = selectedUser.Id, DiaSemana = (byte) 2 });
            }

                    //Miercoles
            if (checkMiercoles.Checked) { 
                selectedUser.UserWorkDays.Add(new UserWorkDays { UserId = selectedUser.Id, DiaSemana = (byte) 3 });
            }
           
                    //Jueves
            if (checkJueves.Checked) {
                selectedUser.UserWorkDays.Add(new UserWorkDays { UserId = selectedUser.Id, DiaSemana = (byte) 4 });
            }
            
                    //Viernes
            if (checkViernes.Checked) {
                selectedUser.UserWorkDays.Add(new UserWorkDays { UserId = selectedUser.Id, DiaSemana = (byte) 5 });
            }
            
                    //Sabado
            if (checkSabado.Checked) {
                selectedUser.UserWorkDays.Add(new UserWorkDays { UserId = selectedUser.Id, DiaSemana = (byte) 6 });
            }
            
                    //Domingo
            if (checkDomingo.Checked) { 
                selectedUser.UserWorkDays.Add(new UserWorkDays { UserId = selectedUser.Id, DiaSemana = (byte) 7 }); 
            }

            db.SaveChanges();

            loadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
                return;
            }

            //Existe un usuario con ese username
            if (db.Users.Any(u => u.Username == tbUsername.Text))
            {
                MessageBox.Show("Ya existe un usuario con ese username.");
                return;
            }

            //Crear nuevo usuario
            Users newUser = new Users
            {
                FullName = tbFullName.Text,
                Username = tbUsername.Text,
                Password = PasswordHasher.HashPassword(tbPassword.Text),
                Admin = checkAdmin.Checked,
                hora_inicio = dateEntrada.Value.TimeOfDay,
                hora_final = dateSalida.Value.TimeOfDay
            };

            db.Users.Add(newUser);
            db.SaveChanges();
            loadUsers();
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            //Eliminar usuario
            //  Usuario nulo
            if (selectedUser == null) {
                MessageBox.Show("Sin usuario seleccionado.");
                return; 
            }

            DialogResult result = MessageBox.Show( "¿Realmente quieres borrar al usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Autoeliminación
            if (selectedUser.Id == admin.Id) {
                MessageBox.Show("No puedes eliminarte a ti mismo.");
                return; 
            }

            db.Users.Remove(selectedUser);

            selectedUser = null;

            db.SaveChanges();
            loadUsers();
        }
    }
}
