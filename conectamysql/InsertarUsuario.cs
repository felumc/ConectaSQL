using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace conectasql
{
    public partial class frmInsertarUsuario : Form
    {
        public frmInsertarUsuario()
        {
            InitializeComponent();
        }
     
        private void btnok_Click(object sender, EventArgs e)
        {

            object S1 = comboBox1.SelectedItem;
            String T1 = comboBox1.GetItemText(S1);

            object S2 = comboBox2.SelectedItem;
            String T2 = comboBox2.GetItemText(S2);



            Usuarios Usuario = new Usuarios();
            Usuario.Usuario = txtuser.Text.Trim();
            Usuario.Passwd = txtpass.Text.Trim();
            Usuario.Estado = T1;
            Usuario.Tipo_usuario = T2;


            

            int resultado = UsuariosDAO.Agregar(Usuario);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Guardado Con Exito!!", "Usuario Guardado", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo al insertar!!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }

        }
       
            
      
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmInsertarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmInsertarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
