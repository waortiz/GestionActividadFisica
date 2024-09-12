using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("CondicionesEmocionales")]
    public class CondicionEmocional
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Evaluacion> Evaluaciones { get; set; }
    }
}