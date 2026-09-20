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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 32);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(401, 319);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuarios_RowHeaderMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelate
            // 
            this.btnDelate.Location = new System.Drawing.Point(311, 357);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(102, 23);
            this.btnDelate.TabIndex = 3;
            this.btnDelate.Text = "Eliminar";
            this.btnDelate.UseVisualStyleBackColor = true;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
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
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(525, 58);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(200, 20);
            this.tbUsername.TabIndex = 8;
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
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(525, 84);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(200, 20);
            this.tbFullName.TabIndex = 10;
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
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(525, 110);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(200, 20);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.PasswordChar = '*';
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(419, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateEntrada
            // 
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateEntrada.Location = new System.Drawing.Point(525, 304);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(82, 20);
            this.dateEntrada.TabIndex = 13;
            // 
            // dateSalida
            // 
            this.dateSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateSalida.Location = new System.Drawing.Point(525, 330);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.Size = new System.Drawing.Size(82, 20);
            this.dateSalida.TabIndex = 14;
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
            // lblAdmin
            // 
            this.lblAdmin.Location = new System.Drawing.Point(419, 357);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(100, 23);
            this.lblAdmin.TabIndex = 25;
            this.lblAdmin.Text = "Administrador:";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(525, 356);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(89, 17);
            this.checkAdmin.TabIndex = 26;
            this.checkAdmin.Text = "Administrador";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 389);
            this.Controls.Add(this.checkAdmin);
            this.Controls.Add(this.lblAdmin);
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
            this.Controls.Add(this.dateSalida);
            this.Controls.Add(this.dateEntrada);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "UserManager";
            this.Text = "UserManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.DateTimePicker dateSalida;
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
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.CheckBox checkAdmin;
    }
}