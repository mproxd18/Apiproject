using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apiproject.Shared.Models;

namespace TuEspacioDeNombresDondeQuieresClasificacion
{
    public class Clasificacion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        
        public ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}