using Unidad2_Act2.Models.Entities;
using Unidad2_Act2.Models.MyEntities;

namespace Unidad2_Act2.Models.ViewModels
{
    public class RazaViewModel
    {
        public List<Perro> PerrosAleatorios { get; set; } = null!;
        public Razas Perro { get; set; } = null!;
    }
}
