using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using static Dominio.Empleados;

namespace Negocio
{
    public class EmpleadosNegocio
    {
        List<Empleados> Listar()
        {
            List<Empleados> lista = new List<Empleados>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select IdEmpleado, IdPerfil, Nombre, Apellido, CorreoElectronico, Pass from Empleados");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Empleados empleados = new Empleados
                    {
                        IdEmpleado = (int)datos.Lector["IdEmpleado"],
                        PerfilUsuario = (int)datos.Lector["IdPerfil"] == 1 ? PerfilUsuario.Mesero : PerfilUsuario.Gerente,
                        Nombre = datos.Lector["Nombre"].ToString(),
                        Apellido = datos.Lector["Apellido"].ToString(),
                        CorreoElectronico = datos.Lector["CorreoElectronico"].ToString(),
                        Pass = datos.Lector["Pass"].ToString()
                    };

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
