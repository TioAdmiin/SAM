namespace Uno
{
    partial class UserManager
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.checkLunes = new System.Windows.Forms.CheckBox();
            this.checkMartes = new System.Windows.Forms.CheckBox();
            this.checkMiercoles = new System.Windows.Forms.CheckBox();
            this.checkJueves = new System.Windows.Forms.CheckBox();
            this.checkDomingo = new System.Windows.Forms.CheckBox();
            this.checkSabado = new System.Windows.Forms.CheckBox();
            this.checkViernes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 32);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(401, 293);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 20);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Administrar Usuarios";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(419, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(525, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(49, 20);
            this.tbId.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(419, 58);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(525, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 10;
            // 
            // lblFullname
            // 
            this.lblFullname.Location = new System.Drawing.Point(419, 84);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(100, 23);
            this.lblFullname.TabIndex = 9;
            this.lblFullname.Text = "Nombre:";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(525, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 20);
            this.lblPassword.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(419, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contraseña:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(525, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(525, 330);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // lblSalida
            // 
            this.lblSalida.Location = new System.Drawing.Point(419, 330);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(100, 23);
            this.lblSalida.TabIndex = 16;
            this.lblSalida.Text = "Hora de Salida:";
            this.lblSalida.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEntrada
            // 
            this.lblEntrada.Location = new System.Drawing.Point(419, 304);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(100, 23);
            this.lblEntrada.TabIndex = 15;
            this.lblEntrada.Text = "Hora de entrada:";
            this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDias
            // 
            this.lblDias.Location = new System.Drawing.Point(419, 140);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(100, 23);
            this.lblDias.TabIndex = 17;
            this.lblDias.Text = "Dias trabajados:";
            this.lblDias.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDias.Click += new System.EventHandler(this.lblDias_Click);
            // 
            // checkLunes
            // 
            this.checkLunes.AutoSize = true;
            this.checkLunes.Location = new System.Drawing.Point(525, 139);
            this.checkLunes.Name = "checkLunes";
            this.checkLunes.Size = new System.Drawing.Size(55, 17);
            this.checkLunes.TabIndex = 18;
            this.checkLunes.Text = "Lunes";
            this.checkLunes.UseVisualStyleBackColor = true;
            // 
            // checkMartes
            // 
            this.checkMartes.AutoSize = true;
            this.checkMartes.Location = new System.Drawing.Point(525, 159);
            this.checkMartes.Name = "checkMartes";
            this.checkMartes.Size = new System.Drawing.Size(58, 17);
            this.checkMartes.TabIndex = 19;
            this.checkMartes.Text = "Martes";
            this.checkMartes.UseVisualStyleBackColor = true;
            // 
            // checkMiercoles
            // 
            this.checkMiercoles.AutoSize = true;
            this.checkMiercoles.Location = new System.Drawing.Point(525, 182);
            this.checkMiercoles.Name = "checkMiercoles";
            this.checkMiercoles.Size = new System.Drawing.Size(71, 17);
            this.checkMiercoles.TabIndex = 20;
            this.checkMiercoles.Text = "Miercoles";
            this.checkMiercoles.UseVisualStyleBackColor = true;
            // 
            // checkJueves
            // 
            this.checkJueves.AutoSize = true;
            this.checkJueves.Location = new System.Drawing.Point(525, 205);
            this.checkJueves.Name = "checkJueves";
            this.checkJueves.Size = new System.Drawing.Size(60, 17);
            this.checkJueves.TabIndex = 21;
            this.checkJueves.Text = "Jueves";
            this.checkJueves.UseVisualStyleBackColor = true;
            // 
            // checkDomingo
            // 
            this.checkDomingo.AutoSize = true;
            this.checkDomingo.Location = new System.Drawing.Point(525, 274);
            this.checkDomingo.Name = "checkDomingo";
            this.checkDomingo.Size = new System.Drawing.Size(68, 17);
            this.checkDomingo.TabIndex = 24;
            this.checkDomingo.Text = "Domingo";
            this.checkDomingo.UseVisualStyleBackColor = true;
            // 
            // checkSabado
            // 
            this.checkSabado.AutoSize = true;
            this.checkSabado.Location = new System.Drawing.Point(525, 251);
            this.checkSabado.Name = "checkSabado";
            this.checkSabado.Size = new System.Drawing.Size(63, 17);
            this.checkSabado.TabIndex = 23;
            this.checkSabado.Text = "Sabado";
            this.checkSabado.UseVisualStyleBackColor = true;
            // 
            // checkViernes
            // 
            this.checkViernes.AutoSize = true;
            this.checkViernes.Location = new System.Drawing.Point(525, 228);
            this.checkViernes.Name = "checkViernes";
            this.checkViernes.Size = new System.Drawing.Size(61, 17);
            this.checkViernes.TabIndex = 22;
            this.checkViernes.Text = "Viernes";
            this.checkViernes.UseVisualStyleBackColor = true;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 363);
            this.Controls.Add(this.checkDomingo);
            this.Controls.Add(this.checkSabado);
            this.Controls.Add(this.checkViernes);
            this.Controls.Add(this.checkJueves);
            this.Controls.Add(this.checkMiercoles);
            this.Controls.Add(this.checkMartes);
            this.Controls.Add(this.checkLunes);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "UserManager";
            this.Text = "UserManager";
            this.Load += new System.EventHandler(this.UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox lblPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.CheckBox checkLunes;
        private System.Windows.Forms.CheckBox checkMartes;
        private System.Windows.Forms.CheckBox checkMiercoles;
        private System.Windows.Forms.CheckBox checkJueves;
        private System.Windows.Forms.CheckBox checkDomingo;
        private System.Windows.Forms.CheckBox checkSabado;
        private System.Windows.Forms.CheckBox checkViernes;
    }
}