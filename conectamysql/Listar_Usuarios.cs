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
    public partial class Listar_Usuarios : Form
    {
        public Listar_Usuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string resultado = UsuariosDAO.Consultar3();
            string[] separado;
            txtListado.Text = resultado;
            separado = resultado.Split('-');


            var totalElements = (separado.Count()-1)/4;
            

            int contador = 0;
            for (int z = 0; z < totalElements; z++)
            {

                 dataGridView1.Rows.Add(separado[contador].Trim(), separado[contador+1].Trim(), separado[contador+2].Trim(), separado[contador+3].Trim());
                  contador = contador + 4;

            }

        }

        private void Listar_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }
    }
}
