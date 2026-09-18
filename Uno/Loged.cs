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
    public partial class Loged : Form
    {
        //Atributos
        private Users user;

        public Loged(Users user)
        {
            InitializeComponent();

            this.user = user;
            this.lblTitulo.Text = user.FullName;

            if (CheckEntrada())
            {
                btnMarcarEntrada.Enabled = false;
                if (CheckSalida())
                {
                    btnMarcarSalida.Enabled = false;
                }
                else
                {
                    btnMarcarSalida.Enabled = true;
                }
            }
            else
            {
                btnMarcarEntrada.Enabled = true;
                btnMarcarSalida.Enabled = false;
            }
        }

        private bool CheckEntrada()
        {
           foreach (var entrada in user.Entradas)
            {
                if (entrada.Fecha == DateTime.Today)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckSalida()
        {
            foreach (var salida in user.Salidas)
            {
                if (salida.Fecha == DateTime.Today)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnMarcarEntrada_Click(object sender, EventArgs e)
        {
            if (CheckEntrada()) { return; }
            Entradas new_entrada = new Entradas();
            new_entrada.UserId = user.Id;
            new_entrada.Fecha = DateTime.Today;
            new_entrada.Hora = DateTime.Now.TimeOfDay;

            if (DateTime.Now.TimeOfDay < user.hora_inicio)
            {
                new_entrada.Tipo = "Correcto";
            }
            else
            {
                new_entrada.Tipo = "Atrasado";
            }

            //Añadir entrada a la base de datos
            using (var context = new DB1Entities())
            {
                context.Entradas.Add(new_entrada);
                context.SaveChanges();
            }

            //Cambiar botones
            bool check = CheckEntrada();
            btnMarcarEntrada.Enabled = check;
            btnMarcarSalida.Enabled = !check;
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            if (CheckSalida()){ return; }
            Salidas new_salida = new Salidas();
            new_salida.UserId = user.Id;
            new_salida.Fecha = DateTime.Today;
            new_salida.Hora = DateTime.Now.TimeOfDay;
            if (DateTime.Now.TimeOfDay < user.hora_final)
            {
                new_salida.Tipo = "Anticipado";
            }
            else
            {
                new_salida.Tipo = "Correcto";
            }

            //Añadir salida a la base de datos
            using (var context = new DB1Entities())
            {
                context.Salidas.Add(new_salida);
                context.SaveChanges();
            }

            //Cambiar boton
            btnMarcarSalida.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
