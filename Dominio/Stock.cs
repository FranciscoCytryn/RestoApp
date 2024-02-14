using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Stock
    {
        public Stock() { }
        public int IdStock { get; set; }
        public int IdInsumo { get; set; }
        public int Cantidad { get; set; }
    }
}
