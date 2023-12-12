using System.CodeDom;

namespace PlanMap.Models
{
    public class Plantio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        public string Description { get; set; }   
        public DateTime DataPlantio { get; set; } = DateTime.Now;
        public int EspecieId { get; set; }
        public Especie Especie { get; set; }
        
        public Plantio()
        {
            //DataPlantio = DateTime.Now;
        }

    }


}
