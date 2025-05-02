using Microsoft.AspNetCore.Mvc;
using MVC.Servicio;

namespace PracticaMVC.Controllers
{
    public class PokemonController : Controller
    {

        private IPokemonServicio _pokemonServicio;

        public PokemonController(IPokemonServicio pokemonServicio)
        {
            _pokemonServicio = pokemonServicio;
        }   

        public IActionResult Index()
        {
            var pokemons = _pokemonServicio.ObtenerPokemones();
            return View(pokemons);
        }
    }
}
