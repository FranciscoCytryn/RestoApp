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
                    Mesas mesas = new Mesas();
                    mesas.IdMesa = (int)datos.Lector["IDMesa"];
                    mesas.Descripcion = (datos.Lector["Descripcion"] as string) ?? "";
                    lista.Add(mesas);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
