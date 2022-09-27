using System;
using System.Windows.Forms;

namespace conectasql
{
    public partial class frmAgregar_Trabajador : Form
    {
        public frmAgregar_Trabajador()
        {
            InitializeComponent();
        }

        private void Agregar_Trabajador_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void frmAgregar_Trabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Trabajador Trabajador = new Trabajador();
            //Trabajador.Id = int.Parse(Txt_ID.Text.Trim());
            Trabajador.Nombre = txtNombre.Text.Trim();
            Trabajador.Ape_pat = TxtApepat.Text.Trim();
            Trabajador.Ape_mat = TxtApemat.Text.Trim();
            Trabajador.Direccion = TxtDireccion.Text.Trim();
            Trabajador.Telefono = TxtTelefono.Text.Trim();
            Trabajador.Num_empleado = int.Parse(TxtNoempleado.Text.Trim());
            Trabajador.Id_usuario = int.Parse(TxtIDusuario.Text.Trim());
            Trabajador.Id_puesto = int.Parse(TxtIDpuesto.Text.Trim());

            int resultado = TrabajadorDAO.Agregar_Trabajador(Trabajador);
            if (resultado > 0)
            {
                MessageBox.Show("Trabajador Guardado Con Exito!!", "Trabajador Guardado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
              MessageBox.Show("No se pudo guardar al Trabajador", "Fallo al insertar!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            TxtApepat.Text = "";
            TxtApemat.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtNoempleado.Text = "";
            TxtIDusuario.Text = "";
            TxtIDpuesto.Text = "";
        }
    }
}
