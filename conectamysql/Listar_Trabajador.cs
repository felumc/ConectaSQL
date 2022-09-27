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
    public partial class frmListar_Trabajador : Form
    {
        public frmListar_Trabajador()
        {
            InitializeComponent();
        }

        private void frmListar_Trabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmListar_Trabajador_Load(object sender, EventArgs e)
        {
            string resultado = TrabajadorDAO.Consultar3();
            string[] separado;
            
            separado = resultado.Split('-');


            var totalElements = (separado.Count() - 1) / 8;


            int contador = 0;
            for (int z = 0; z < totalElements; z++)
            {

                dataGridView1.Rows.Add(separado[contador].Trim(), separado[contador + 1].Trim(), separado[contador + 2].Trim(), separado[contador + 3].Trim(),
                    separado[contador+4].Trim(), separado[contador + 5].Trim(), separado[contador + 6].Trim(), separado[contador + 7].Trim()

                    );
                contador = contador +8;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInicio Principal = new frmInicio();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }
    }
}
