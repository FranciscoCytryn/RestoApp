using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleados
    {
        public Empleados() { }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Pass { get; set; }
        public enum PerfilUsuario
        {
            Mesero = 1,
            Gerente = 2
        }
    }
}
