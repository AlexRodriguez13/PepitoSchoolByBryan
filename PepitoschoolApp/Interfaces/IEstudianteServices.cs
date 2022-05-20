using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoschoolApp.Interfaces
{
    public interface IEstudianteServices : IService<Estudiante>
    {
        Estudiante FindByCarnet(string carnet);
        List<Estudiante> FindByNames(string names);
        List<Estudiante> FindByLastnames(string lastnames);
    }
}
