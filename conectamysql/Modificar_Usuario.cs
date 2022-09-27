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
    public partial class frmmodifica2 : Form
    {
        public frmmodifica2()
        {
            InitializeComponent();
        }
        string nombre;
        private void modifica2_Load(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();        
            string resultado = UsuariosDAO.Consultar();
            string[] separado;
            separado = resultado.Split('-');
            cmbUsuarios.Items.Clear();
            for (int i = 0; i < separado.Length; i++)
            {
                cmbUsuarios.Items.Add(separado[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios Usuario2 = new Usuarios();
            Usuario2.Usuario = cmbUsuarios.SelectedItem.ToString().Trim();
            nombre = Usuario2.Usuario;
            string resultado = UsuariosDAO.Consultar2(Usuario2);
            string[] separado;
            separado = resultado.Split('-');
            
            txtpass.Text = separado[0].Trim();
            TxtEstado.Text = separado[1].Trim();
            TxtTipoUsuario.Text = separado[2].Trim();
            
            

        }

        private void btnok_Click(object sender, EventArgs e)
        {

            object S1 = TxtEstado.SelectedItem;
            String T1 = TxtEstado.GetItemText(S1);

            object S2 = TxtTipoUsuario.SelectedItem;
            String T2 = TxtTipoUsuario.GetItemText(S2);


            Usuarios Usuario3 = new Usuarios();
            Usuario3.Usuario = nombre;        
            Usuario3.Passwd = txtpass.Text.Trim();
            Usuario3.Estado = T1;
            Usuario3.Tipo_usuario = T2;
            int resultado = UsuariosDAO.Modificar(Usuario3);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Modificado Con Exito!!", "Usuario Modificado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cmbUsuarios.Items.Clear();
                modifica2_Load(sender, e);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Usuario", "Fallo al modificar!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbUsuarios.Text="";
            txtpass.Text = "";
            TxtEstado.Text = "";
            TxtTipoUsuario.Text = "";
        }

        private void frmmodifica2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
