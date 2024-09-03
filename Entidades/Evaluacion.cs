namespace Entidades
{
    public class Evaluacion
    {
        public DateTime Fecha {  get; set; }
        public Persona Persona { get; set; }
        public bool AntecendenteDiabetes { get; set; }
        public bool AntecendenteCancer { get; set; }
        public Ciudad Ciudad { get; set; }
        public decimal Peso { get; set; }
        public decimal Talla { get; set; }
        public CondicionEmocional CondicionEmocional { get; set; }
    }
}
