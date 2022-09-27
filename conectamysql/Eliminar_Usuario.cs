using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conectasql
{
    public partial class Eliminar_Usuario : Form
    {
        public Eliminar_Usuario()
        {
            InitializeComponent();
        }

        private void elimina2_Load(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            // Usuario.Usuario = txtuser.Text.Trim();
            string resultado = UsuariosDAO.Consultar();
            string[] separado;
            //MessageBox.Show(resultado.ToString(),"final");
            separado = resultado.Split('-');
            cmbUsuarios.Items.Clear();
            for ( int i=0;i<separado.Length;i++) {
                cmbUsuarios.Items.Add(separado[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
           
            Usuario.Usuario = cmbUsuarios.SelectedItem.ToString();
            int resultado = UsuariosDAO.Eliminar(Usuario);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Borrado Con Exito!!", "Usuario Borrado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cmbUsuarios.Items.Clear();
                elimina2_Load(sender,e);
            }
            else
            {
                MessageBox.Show("No se pudo borrar el Usuario", "Fallo al borrar!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void Eliminar_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
   
}
