using Unidad2_Act2.Models.MyEntities;

namespace Unidad2_Act2.Models.ViewModels
{
    public class PaisViewModel
    {
        public Dictionary<string, List<Perro>> PerrosPorPais { get; set; } = null!;
    }
}
