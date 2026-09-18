namespace Uno
{
    partial class Loged
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMarcarEntrada = new System.Windows.Forms.Button();
            this.btnMarcarSalida = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(776, 67);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SAM";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMarcarEntrada
            // 
            this.btnMarcarEntrada.Location = new System.Drawing.Point(322, 132);
            this.btnMarcarEntrada.Name = "btnMarcarEntrada";
            this.btnMarcarEntrada.Size = new System.Drawing.Size(165, 23);
            this.btnMarcarEntrada.TabIndex = 2;
            this.btnMarcarEntrada.Text = "Marcar Entrada";
            this.btnMarcarEntrada.UseVisualStyleBackColor = true;
            this.btnMarcarEntrada.Click += new System.EventHandler(this.btnMarcarEntrada_Click);
            // 
            // btnMarcarSalida
            // 
            this.btnMarcarSalida.Location = new System.Drawing.Point(322, 176);
            this.btnMarcarSalida.Name = "btnMarcarSalida";
            this.btnMarcarSalida.Size = new System.Drawing.Size(165, 23);
            this.btnMarcarSalida.TabIndex = 3;
            this.btnMarcarSalida.Text = "Marcar Salida";
            this.btnMarcarSalida.UseVisualStyleBackColor = true;
            this.btnMarcarSalida.Click += new System.EventHandler(this.btnMarcarSalida_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Enabled = false;
            this.btnAdministrar.Location = new System.Drawing.Point(322, 220);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(165, 23);
            this.btnAdministrar.TabIndex = 4;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(322, 264);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Loged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.btnMarcarSalida);
            this.Controls.Add(this.btnMarcarEntrada);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Loged";
            this.Text = "Loged";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMarcarEntrada;
        private System.Windows.Forms.Button btnMarcarSalida;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnSalir;
    }
}