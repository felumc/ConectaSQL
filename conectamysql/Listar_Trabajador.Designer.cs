namespace conectasql
{
    partial class frmListar_Trabajador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Paterno,
            this.Materno,
            this.Direccion,
            this.Telefono,
            this.Num_empleado,
            this.Id_usuario,
            this.Id_puesto});
            this.dataGridView1.Location = new System.Drawing.Point(39, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Paterno
            // 
            this.Paterno.HeaderText = "Paterno";
            this.Paterno.MinimumWidth = 6;
            this.Paterno.Name = "Paterno";
            this.Paterno.ReadOnly = true;
            this.Paterno.Width = 125;
            // 
            // Materno
            // 
            this.Materno.HeaderText = "Materno";
            this.Materno.MinimumWidth = 6;
            this.Materno.Name = "Materno";
            this.Materno.ReadOnly = true;
            this.Materno.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Num_empleado
            // 
            this.Num_empleado.HeaderText = "Num Empleado";
            this.Num_empleado.MinimumWidth = 6;
            this.Num_empleado.Name = "Num_empleado";
            this.Num_empleado.ReadOnly = true;
            this.Num_empleado.Width = 125;
            // 
            // Id_usuario
            // 
            this.Id_usuario.HeaderText = "ID Usuario";
            this.Id_usuario.MinimumWidth = 6;
            this.Id_usuario.Name = "Id_usuario";
            this.Id_usuario.ReadOnly = true;
            this.Id_usuario.Width = 125;
            // 
            // Id_puesto
            // 
            this.Id_puesto.HeaderText = "ID Puesto";
            this.Id_puesto.MinimumWidth = 6;
            this.Id_puesto.Name = "Id_puesto";
            this.Id_puesto.ReadOnly = true;
            this.Id_puesto.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmListar_Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListar_Trabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Trabajador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListar_Trabajador_FormClosed);
            this.Load += new System.EventHandler(this.frmListar_Trabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_puesto;
        private System.Windows.Forms.Button button2;
    }
}