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
                dgvReportes.DataSource = db.Entradas.ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Entradas.ToList().Where(x => x.Fecha == calendarDia.SelectionStart.Date).ToList();
            }
            dgvReportes.Columns["Users"].Visible = false;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Salidas.ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Salidas.ToList().Where(x => x.Fecha == calendarDia.SelectionEnd.Date).ToList();
            }
            dgvReportes.Columns["Users"].Visible = false;
        }

        private void btnAtrasos_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Entradas.ToList().Where(x => x.Tipo == "Atrasado").ToList();
            }
            else
            {
                dgvReportes.DataSource = dgvReportes.DataSource = db.Entradas.ToList().Where(x => x.Tipo == "Atrasado").ToList().Where(x => x.Fecha == calendarDia.SelectionEnd.Date).ToList();
            }
        }

        private void btnSalidasAnticipadas_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Salidas.ToList().Where(x => x.Tipo == "Anticipado").ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Salidas.ToList().Where(x => x.Tipo == "Anticipado").ToList().Where(x => x.Fecha == calendarDia.SelectionEnd.Date).ToList();
            }
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            dgvReportes.Columns.Clear();
            if (checkCualquiera.Checked)
            {
                dgvReportes.DataSource = db.Faltas.ToList();
            }
            else
            {
                dgvReportes.DataSource = db.Faltas.ToList().Where(x => x.Fecha == calendarDia.SelectionEnd.Date).ToList();
            }
        }

        private void calendarDia_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
