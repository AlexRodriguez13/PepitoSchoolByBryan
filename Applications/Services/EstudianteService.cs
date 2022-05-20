using Applications.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class EstudianteService : IEstudianteService
    {
        public IEstudianteRepository estudianteRepository;
        public EstudianteService(IEstudianteRepository estudianteRepository)
        {
            this.estudianteRepository = estudianteRepository;
        }
        public void Create(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El estudiante no puede ser null.");
            }

            estudianteRepository.Create(t);
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
