using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesas
    {
        public Mesas() { }
        public int IdMesa { get; set; }
        public string Descripcion { get; set; }
        public int IdMesero { get; set; }
        public bool Ocupada { get; set; }
    }
}
