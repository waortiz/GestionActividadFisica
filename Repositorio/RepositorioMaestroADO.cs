using Entidades;
using System.Configuration;
using System.Data.SqlClient;

namespace Repositorio
{
    public class RepositorioMaestroADO : IRepositorioMaestro
    {
        public List<Ciudad> ObtenerCiudades()
        {
            var ciudades = new List<Ciudad>();

            using (var conexion = new SqlConnection(ConfigurationManager.
                ConnectionStrings["GestionActividadFisica"].ConnectionString))
            {
                conexion.Open();
            }

            return ciudades;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();


            return tiposDocumento;
        }
    }
}
