using Domain.Entities;
using Domain.Interfaces;
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
            if (t == null)
            {
                throw new ArgumentNullException("El estudiante no puede ser null.");
            }

            estudianteRepository.Create(t);
        }

        public bool Delete(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El estudiante no puede ser null.");
            }
            return estudianteRepository.Delete(t);
        }

        public Estudiante FindByCarnet(string carnet)
        {
            return estudianteRepository.FindByCarnet(carnet);
        }

        public List<Estudiante> FindByLastnames(string lastnames)
        {
            return estudianteRepository.FindByLastnames(lastnames);
        }

        public List<Estudiante> FindByNames(string names)
        {
            return estudianteRepository.FindByNames(names);
        }

        public List<Estudiante> GetAll()
        {
            return estudianteRepository.GetAll();
        }

        public int Update(Estudiante t)
        {
            return estudianteRepository.Update(t);
        }
    }
}
