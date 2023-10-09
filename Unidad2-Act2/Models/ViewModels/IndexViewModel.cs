using Unidad2_Act2.Models.MyEntities;

namespace Unidad2_Act2.Models.ViewModels
{
    public class IndexViewModel
    {

        public List<Perro> Perros { get; set; } = null!;
        public List<string> FiltroLetras = null!;
    }
}
