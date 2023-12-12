namespace PlanMap.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CodigoEspecie { get; set; }
        public List<Plantio> Plants { get; set; } = new List<Plantio>();
    }
}
