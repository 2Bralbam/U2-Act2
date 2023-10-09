using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unidad2_Act2.Models.Entities;
using Unidad2_Act2.Models.MyEntities;
using Unidad2_Act2.Models.ViewModels;

namespace Unidad2_Act2.Controllers
{
    public class HomeController : Controller
    {
        private readonly PerrosContext _context;
        public HomeController(PerrosContext context)
        {
            _context = context;
        }
        public IActionResult Index(string Id)
        {

            IndexViewModel vm = new IndexViewModel();

            List<Perro> ListaPerros = _context.Razas
                .OrderBy(Perro => Perro.Nombre)
                .Select(Perro => new Perro
                {
                    Id = (int)Perro.Id,
                    Nombre = Perro.Nombre
                }).ToList();

            var FiltroPorLetraInicial = ListaPerros.GroupBy(Perro => Perro.Nombre.Substring(0, 1)).ToList();

            vm.FiltroLetras = new();

            foreach (var GrupoLetra in FiltroPorLetraInicial)
            {
                vm.FiltroLetras.Add(GrupoLetra.Key.ToString());
            }

            if (Id == null)
            {
                vm.Perros = ListaPerros;
            }
            else
            {
                vm.Perros = ListaPerros.Where(Perro => Perro.Nombre.StartsWith(Id)).ToList();
            }
            return View(vm);
        }
        [Route("Raza/{Id}")]
        public IActionResult Raza(string Id)
        {
            Id = Id.Replace("-", " ");
            RazaViewModel vm = new();
            var PerrosAleatorios = _context.Razas.Where(x => x.Nombre != Id)
                .Select(x => new Perro 
                { 
                    Id= (int)x.Id,
                    Nombre=x.Nombre
                }).ToList();
            Razas Perro = _context.Razas.Include(x=>x.Caracteristicasfisicas)
                .Include(x=>x.IdPaisNavigation)
                .Include(x=>x.Estadisticasraza)
                .First(x=>x.Nombre == Id);
            vm.Perro = Perro;
            vm.PerrosAleatorios = PerrosAleatorios;
            return View(vm);
        }
        [Route("Pais")]
        public IActionResult Pais() 
        {

            var ListaPaisPerro = _context.Paises.Include(x => x.Razas).Select(x => new PaisPerrosViewModel
            {
                Pais = x.Nombre ?? "Sin nombre pais",
                Perros = x.Razas.Select(Perros => new Perro
                {
                    Id = (int)Perros.Id,
                    Nombre = Perros.Nombre
                }).ToList()
            }).OrderBy(x=>x.Pais).ToList();

            return View(ListaPaisPerro);
        }
        public IActionResult FiltroLetra(string Id)
        {
            return View();
        }
    }
}
