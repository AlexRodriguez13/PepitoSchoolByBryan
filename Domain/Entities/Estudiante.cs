using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Estudiante
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public int Phone { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

    }
}
