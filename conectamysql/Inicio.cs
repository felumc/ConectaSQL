using System;
using System.Windows.Forms;

namespace conectasql
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertarUsuario frmInsertarUsuario = new frmInsertarUsuario();
            frmInsertarUsuario.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar_Usuario frmelimina2 = new Eliminar_Usuario();
            frmelimina2.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmodifica2 frmmodifica2 = new frmmodifica2();
            frmmodifica2.Show();
            this.Hide();
        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Usuarios Listar = new Listar_Usuarios();
            Listar.Show();
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar_Trabajador Agregar_Trabajador = new frmAgregar_Trabajador();
            Agregar_Trabajador.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminar_Trabajador Eliminar_Trabajador = new Eliminar_Trabajador();
            Eliminar_Trabajador.Show();
            this.Hide();
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmActualizar_Trabajador Actualizar_Trabajador = new frmActualizar_Trabajador();
            Actualizar_Trabajador.Show();
            this.Hide();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListar_Trabajador Listar_Trabajador = new frmListar_Trabajador();
            Listar_Trabajador.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
    }

