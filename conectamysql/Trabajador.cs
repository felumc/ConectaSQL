using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectasql
{
    public class Trabajador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ape_pat { get; set; }
        public string Ape_mat { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Num_empleado { get; set; }
        public int Id_usuario { get; set; }
        public int Id_puesto { get; set; }

        public Trabajador() {}

        public Trabajador(int Id, string Nombre, string Ape_pat, string Ape_mat, string Direccion, string Telefono, int Num_empleado, int Id_Usuario, int Id_puesto)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Ape_pat = Ape_pat;
            this.Ape_mat = Ape_mat;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Num_empleado = Num_empleado;
            this.Id_usuario = Id_Usuario;
            this.Id_puesto = Id_puesto;


        }

        }
    }
    

    

