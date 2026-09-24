namespace Uno
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnAtrasos = new System.Windows.Forms.Button();
            this.btnSalidasAnticipadas = new System.Windows.Forms.Button();
            this.btnFaltas = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.calendarDia = new System.Windows.Forms.MonthCalendar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.checkCualquiera = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntradas
            // 
            this.btnEntradas.Location = new System.Drawing.Point(48, 236);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(235, 23);
            this.btnEntradas.TabIndex = 0;
            this.btnEntradas.Text = "Mostrar Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(48, 265);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(235, 23);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "Mostrar Salidas";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnAtrasos
            // 
            this.btnAtrasos.Location = new System.Drawing.Point(48, 294);
            this.btnAtrasos.Name = "btnAtrasos";
            this.btnAtrasos.Size = new System.Drawing.Size(235, 23);
            this.btnAtrasos.TabIndex = 2;
            this.btnAtrasos.Text = "Mostrar Atrasos";
            this.btnAtrasos.UseVisualStyleBackColor = true;
            this.btnAtrasos.Click += new System.EventHandler(this.btnAtrasos_Click);
            // 
            // btnSalidasAnticipadas
            // 
            this.btnSalidasAnticipadas.Location = new System.Drawing.Point(48, 323);
            this.btnSalidasAnticipadas.Name = "btnSalidasAnticipadas";
            this.btnSalidasAnticipadas.Size = new System.Drawing.Size(235, 23);
            this.btnSalidasAnticipadas.TabIndex = 3;
            this.btnSalidasAnticipadas.Text = "Mostrar Salidas anticipadas";
            this.btnSalidasAnticipadas.UseVisualStyleBackColor = true;
            this.btnSalidasAnticipadas.Click += new System.EventHandler(this.btnSalidasAnticipadas_Click);
            // 
            // btnFaltas
            // 
            this.btnFaltas.Location = new System.Drawing.Point(48, 352);
            this.btnFaltas.Name = "btnFaltas";
            this.btnFaltas.Size = new System.Drawing.Size(235, 23);
            this.btnFaltas.TabIndex = 4;
            this.btnFaltas.Text = "Mostrar Faltas";
            this.btnFaltas.UseVisualStyleBackColor = true;
            this.btnFaltas.Click += new System.EventHandler(this.btnFaltas_Click);
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(350, 22);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(438, 407);
            this.dgvReportes.TabIndex = 5;
            // 
            // calendarDia
            // 
            this.calendarDia.Location = new System.Drawing.Point(48, 22);
            this.calendarDia.MaxSelectionCount = 1;
            this.calendarDia.Name = "calendarDia";
            this.calendarDia.ShowTodayCircle = false;
            this.calendarDia.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(48, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSalir.Size = new System.Drawing.Size(235, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // checkCualquiera
            // 
            this.checkCualquiera.AutoSize = true;
            this.checkCualquiera.Location = new System.Drawing.Point(48, 196);
            this.checkCualquiera.Name = "checkCualquiera";
            this.checkCualquiera.Size = new System.Drawing.Size(89, 17);
            this.checkCualquiera.TabIndex = 8;
            this.checkCualquiera.Text = "Cualquier día";
            this.checkCualquiera.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkCualquiera);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.calendarDia);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.btnFaltas);
            this.Controls.Add(this.btnSalidasAnticipadas);
            this.Controls.Add(this.btnAtrasos);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntradas);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnAtrasos;
        private System.Windows.Forms.Button btnSalidasAnticipadas;
        private System.Windows.Forms.Button btnFaltas;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.MonthCalendar calendarDia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox checkCualquiera;
    }
}