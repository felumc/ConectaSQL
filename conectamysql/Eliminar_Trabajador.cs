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
    public partial class Eliminar_Trabajador : Form
    {
        public Eliminar_Trabajador()
        {
            InitializeComponent();
        }

        private void Eliminar_Trabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void Eliminar_Trabajador_Load(object sender, EventArgs e)
        {
            Trabajador Trabajador = new Trabajador();
            string resultado = TrabajadorDAO.Consultar();
            string[] separado;
            separado = resultado.Split('-');
            cmbTrabajador.Items.Clear();
            for (int i = 0; i < separado.Length; i++)
            {
                cmbTrabajador.Items.Add(separado[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trabajador Trabajador = new Trabajador();

            Trabajador.Nombre = cmbTrabajador.SelectedItem.ToString();
            int resultado = TrabajadorDAO.Eliminar_Trabajador(Trabajador);
            if (resultado > 0)
            {
                MessageBox.Show("Trabajador Borrado Con Exito!!", "Trabajador Borrado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cmbTrabajador.Items.Clear();
                Eliminar_Trabajador_Load(sender, e);
            }
            else
            {
                MessageBox.Show("No se pudo borrar al Trabajador", "Fallo al borrar!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
