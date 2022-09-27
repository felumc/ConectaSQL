namespace conectasql
{
    partial class frmmodifica2
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.ComboBox();
            this.TxtTipoUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(64, 55);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(306, 24);
            this.cmbUsuarios.TabIndex = 4;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(209, 340);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(183, 37);
            this.btnvolver.TabIndex = 19;
            this.btnvolver.Text = "Cerrar";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(367, 264);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(157, 39);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Limpiar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(64, 264);
            this.btnok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(158, 39);
            this.btnok.TabIndex = 14;
            this.btnok.Text = "Modificar";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(187, 110);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(337, 22);
            this.txtpass.TabIndex = 11;
            // 
            // TxtEstado
            // 
            this.TxtEstado.FormattingEnabled = true;
            this.TxtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo ",
            "Suspendido"});
            this.TxtEstado.Location = new System.Drawing.Point(187, 159);
            this.TxtEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(337, 24);
            this.TxtEstado.TabIndex = 20;
            // 
            // TxtTipoUsuario
            // 
            this.TxtTipoUsuario.FormattingEnabled = true;
            this.TxtTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Root",
            "Solo lectura",
            "Normal",
            "Trabajador",
            "Restringido"});
            this.TxtTipoUsuario.Location = new System.Drawing.Point(187, 204);
            this.TxtTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTipoUsuario.Name = "TxtTipoUsuario";
            this.TxtTipoUsuario.Size = new System.Drawing.Size(337, 24);
            this.TxtTipoUsuario.TabIndex = 21;
            // 
            // frmmodifica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 436);
            this.Controls.Add(this.TxtTipoUsuario);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmmodifica2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmodifica2_FormClosed);
            this.Load += new System.EventHandler(this.modifica2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox TxtEstado;
        private System.Windows.Forms.ComboBox TxtTipoUsuario;
    }
}