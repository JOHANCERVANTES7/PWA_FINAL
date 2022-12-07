using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PWA_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA_FINAL.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("lista")]

        public IActionResult Lista()
        {
            return Ok(new List<MCliente>() {
            new MCliente()
            {
                Nombre = "Cliente 1",
                Apellido = "Apellido 1",
                Edad = CalcularEdad(new DateTime(1956, 6, 6)),
                FechaDeNacimiento = new DateTime (1956, 3, 6).ToString("dd/MM/yyyy")


            },
            new MCliente()
            {
                Nombre ="Cliente 2",
                Apellido = "Apellido2",
                Edad = CalcularEdad(new DateTime(1988, 12, 25)),
                FechaDeNacimiento = (new DateTime(1988, 12, 25)).ToString("dd/MM/yyyy")
            }
            });
        }
            private int CalcularEdad(DateTime Fecha)
            {
                int edad = DateTime.Today.AddTicks(-Fecha.Ticks).Year - 1;
                return edad;
            }
        
    }
}
