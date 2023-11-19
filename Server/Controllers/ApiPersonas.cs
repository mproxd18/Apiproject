using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Apiproject.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PersonaController : ControllerBase
	{
		private static List<Persona> Personas = new List<Persona>
		{
			new Persona { Id = 1, Nombre = "Marcos Cervantes", Telefono = "3121139949", Correo = "mcervantes5@ucol.mx" },
			new Persona { Id = 2, Nombre = "Luis Hernández", Telefono = "987654321", Correo = "Luis19@ucol.mx" },

            new Persona { Id = 2, Nombre = "Antonio Gónzales", Telefono = "3122294658", Correo = "Agonzales11@ucol.mx" },

             new Persona { Id = 2, Nombre = "María Gómez", Telefono = "3121097576", Correo = "Agonzales11@ucol.mx" }
        };  

		[HttpGet]
		public ActionResult<IEnumerable<Persona>> Get()
		{
			return Ok(Personas);
		}

		public class Persona
		{


			public int Id{ get; set; }
			public string? Nombre { get; set; }
			public string? Telefono { get; set; }
			public string? Correo { get; set; }
		}
	}
}
