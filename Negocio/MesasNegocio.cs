using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MesasNegocio
    {
        public List<Mesas> Listar()
        {
            List<Mesas> lista = new List<Mesas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select IdMesa, Descripcion from Mesas");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Mesas mesas = new Mesas
                    {
                        IdMesa = (int)datos.Lector["IDMesa"],
                        Descripcion = (datos.Lector["Descripcion"] as string) ?? "",
                        IdMesero = 0,
                        Ocupada = false
                    };
                    lista.Add(mesas);
                }

            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
            return lista;
        }
    }
}
