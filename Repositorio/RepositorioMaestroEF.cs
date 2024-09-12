using Entidades;

namespace Repositorio
{
    public class RepositorioMaestroEF : IRepositorioMaestro
    {
        public List<Ciudad> ObtenerCiudades()
        {
            var ciudades = new List<Ciudad>();
                        

            return ciudades;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();

            
            return tiposDocumento;
        }
    }
}
