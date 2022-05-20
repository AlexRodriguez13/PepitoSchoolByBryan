using Domain.Entities;
using PepitoschoolApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoschoolApp.Services
{
    public class EstudianteServices : IEstudianteServices
    {
        public IEstudianteRepository estudianteRepository;
        public EstudianteServices(IEstudianteRepository estudianteRepository)
        {
            this.estudianteRepository = estudianteRepository;
        }
        public void Create(Estudiante t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Estudiante t)
        {
            throw new NotImplementedException();
        }

        public Estudiante FindByCarnet(string carnet)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> FindByLastnames(string lastnames)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> FindByNames(string names)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Estudiante t)
        {
            throw new NotImplementedException();
        }
    }
}
