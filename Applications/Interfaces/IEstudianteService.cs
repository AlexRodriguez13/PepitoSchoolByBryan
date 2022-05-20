using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Interfaces
{
    public interface IEstudianteService : IService<Estudiante>
    {
        Estudiante FindByCarnet(string carnet);
        List<Estudiante> FindByNames(string names);
        List<Estudiante> FindByLastnames(string lastnames);
    }
}
