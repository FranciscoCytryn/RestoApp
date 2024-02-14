using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetallePedidos
    {
        public DetallePedidos() { }
        public int IdDetallePedido { get; set; }
        public int IdPedido { get; set; }
        public int IdInsummo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }

    }

}
