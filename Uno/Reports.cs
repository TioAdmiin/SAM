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
    public partial class Reports : Form
    {
        DB1Entities db = new DB1Entities();
        public Reports(Users admin)
        {
            InitializeComponent();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Entradas.ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Entradas.Where(x => x.Fecha == calendarDia.SelectionStart.Date).ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Salidas.ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Salidas.Where(x => x.Fecha == calendarDia.SelectionEnd.Date).ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }
        }

        private void btnAtrasos_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Entradas.ToList().Where(x => x.Tipo == "Atrasado").ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Entradas.ToList().Where(x => x.Tipo == "Atrasado" && x.Fecha == calendarDia.SelectionEnd.Date).ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }

        }

        private void btnSalidasAnticipadas_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Salidas.ToList().Where(x => x.Tipo == "Anticipado").ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Salidas.ToList().Where(x => x.Tipo == "Anticipado").ToList().Where(x => x.Fecha == calendarDia.SelectionEnd.Date).ToList().Select(x => new { x.Id, x.Fecha, x.Hora, x.Tipo, x.Users.FullName }).ToList();
            }
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Faltas.ToList().Select(x => new { x.Id, x.Fecha, x.Users.FullName }).ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Faltas.ToList().Where(x => x.Fecha == calendarDia.SelectionEnd.Date).ToList().Select(x => new { x.Id, x.Fecha, x.Users.FullName }).ToList();
            }
        }
    }
}
