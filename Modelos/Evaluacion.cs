using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Evaluaciones")]
    public class Evaluacion
    {
        public long Id { get; set; }
        public DateTime Fecha {  get; set; }
        public int IdPersona { get; set; }
        public virtual Persona Persona { get; set; }
        public bool AntecendenteDiabetes { get; set; }
        public bool AntecendenteCancer { get; set; }
        public int IdCiudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public decimal Peso { get; set; }
        public decimal Talla { get; set; }
        public int IdCondicionEmocional { get; set; }
        public virtual CondicionEmocional CondicionEmocional { get; set; }
    }
}
