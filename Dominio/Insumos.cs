using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumos
    {
        public Insumos()
        {
            Guarnicion = false;
            Salsa = false;
        }
        public int IdInsumos { get; set; }
        public string Decripcion { get; set; }
        public int Precio { get; set; }
        public bool Guarnicion { get; set; }
        public bool Salsa { get; set; }
        public Guarnicion Guarniciones { get; set; }
        public Salsa Salsas { get; set; }
    }
}
