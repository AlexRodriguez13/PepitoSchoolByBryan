using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public string Phone { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int Matematica { get; set; }
        public int Contabilidad { get; set; }
        public int Programacion { get; set; }
        public int Estadistica { get; set; }
    }
}
