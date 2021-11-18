using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Interfaces;

namespace WebMVC.Controllers
{
    public class CargoController : Controller
    {
        private readonly ICargoService _cargoService;

        public CargoController(ICargoService cargoService)
        {
            _cargoService = cargoService;
        }
        public IActionResult Index()
        {
            var cargos = _cargoService.GetAllCargos();
            return View(cargos);
        }
    }
}
