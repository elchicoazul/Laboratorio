using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LABORATORIO.Models;

namespace calculadoramvc.Controllers
{
    public class EstudianteController : Controller
    {

       private readonly ILogger<EstudianteController> _logger;

        public EstudianteController(ILogger<EstudianteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Estudiante objContacto){
            if (ModelState.IsValid)
            {
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View("index", objContacto);
        }

    }
}