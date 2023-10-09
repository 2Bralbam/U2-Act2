using Unidad2_Act2.Models.MyEntities;

namespace Unidad2_Act2.Models.ViewModels
{
    public class PaisPerrosViewModel
    {
        public string Pais { get; set; } = null!;
        public List<Perro> Perros { get; set; } = null!;
    }
}
