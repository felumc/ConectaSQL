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
    public partial class frmActualizar_Trabajador : Form
    {
        public frmActualizar_Trabajador()
        {
            InitializeComponent();
        }

        private void frmActualizar_Trabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbNombre.Text = "";
            TxtApepat.Text = "";
            TxtApemat.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtNoempleado.Text = "";
            TxtIDusuario.Text = "";
            TxtIDpuesto.Text = "";
        }
        string nombre;
        private void frmActualizar_Trabajador_Load(object sender, EventArgs e)
        {
            Trabajador Trabajador = new Trabajador();
            string resultado = TrabajadorDAO.Consultar();
            string[] separado;
            separado = resultado.Split('-');
            cmbNombre.Items.Clear();
            for (int i = 0; i < separado.Length; i++)
            {
                cmbNombre.Items.Add(separado[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Trabajador Trabajador2 = new Trabajador();
            Trabajador2.Nombre= cmbNombre.SelectedItem.ToString().Trim();
            nombre = Trabajador2.Nombre;
            string resultado = TrabajadorDAO.Consultar2(Trabajador2);
            string[] separado;
            separado = resultado.Split('-');

    
            TxtApepat.Text = separado[0].Trim(); 
            TxtApemat.Text = separado[1].Trim(); 
            TxtDireccion.Text = separado[2].Trim(); 
            TxtTelefono.Text = separado[3].Trim(); 
            TxtNoempleado.Text = separado[4].Trim(); 
            TxtIDusuario.Text = separado[5].Trim(); ;
            TxtIDpuesto.Text = separado[6].Trim(); ;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Trabajador Trabajador3 = new Trabajador();
            Trabajador3.Nombre = nombre;
            Trabajador3.Ape_pat = TxtApepat.Text.Trim();
            Trabajador3.Ape_mat = TxtApemat.Text.Trim();
            Trabajador3.Direccion = TxtDireccion.Text.Trim();
            Trabajador3.Telefono = TxtTelefono.Text.Trim();
            Trabajador3.Num_empleado = int.Parse(TxtNoempleado.Text.Trim());
            Trabajador3.Id_usuario = int.Parse(TxtIDusuario.Text.Trim());
            Trabajador3.Id_puesto = int.Parse(TxtIDpuesto.Text.Trim());
            int resultado = TrabajadorDAO.Modificar(Trabajador3);
            if (resultado > 0)
            {
                MessageBox.Show("Trabajador Modificado Con Exito!!", "Usuario Modificado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cmbNombre.Items.Clear();
                frmActualizar_Trabajador_Load(sender, e);
            }
            else
            {
                MessageBox.Show("No se pudo modificar al Trabajador", "Fallo al modificar!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
