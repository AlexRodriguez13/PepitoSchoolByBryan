using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class EFEstudianteRepository : IEstudianteRepository
    {
        public IPepitoContext pepitoSchoolDBContext;

        public EFEstudianteRepository(IPepitoContext pepitoSchoolDBContext)
        {
            this.pepitoSchoolDBContext = pepitoSchoolDBContext;
        }
        public void Create(Estudiante t)
        {
            try
            {
                pepitoSchoolDBContext.Estudiantes.Add(t);
                pepitoSchoolDBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Asset no puede ser null.");
                }

                Estudiante estudiante = FindByCarnet(t.Carnet);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto con id {t.Carnet} no existe.");
                }

                pepitoSchoolDBContext.Estudiantes.Remove(estudiante);
                int result = pepitoSchoolDBContext.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindByCarnet(string carnet)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(carnet))
                {
                    throw new Exception($"El parametro carnet {carnet} no tiene el formato correcto.");
                }

                return pepitoSchoolDBContext.Estudiantes.FirstOrDefault(x => x.Carnet.Equals(carnet));
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> FindByLastnames(string lastnames)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lastnames))
                {
                    throw new Exception($"El parametro carnet {lastnames} no tiene el formato correcto.");
                }

                return pepitoSchoolDBContext.Estudiantes.Where(x => x.Apellidos.Equals(lastnames)).ToList(); ;
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> FindByNames(string names)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(names))
                {
                    throw new Exception($"El parametro carnet {names} no tiene el formato correcto.");
                }

                return pepitoSchoolDBContext.Estudiantes.Where(x => x.Nombres.Equals(names)).ToList(); ;
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            return pepitoSchoolDBContext.Estudiantes.ToList();
        }

        public int Update(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto asset no puede ser null.");
                }

                Estudiante estudiantes = FindByCarnet(t.Carnet);
                if (estudiantes == null)
                {
                    throw new Exception($"El objeto Estudiante con id {t.Carnet} no existe.");
                }
                estudiantes.Id = t.Id;
                estudiantes.Nombres = t.Nombres;
                estudiantes.Apellidos = t.Apellidos;
                estudiantes.Phone = t.Phone;
                estudiantes.Carnet = t.Carnet;
                estudiantes.Direccion = t.Direccion;
                estudiantes.Correo = t.Correo;
                estudiantes.Matematica = t.Matematica;
                estudiantes.Estadistica = t.Estadistica;
                estudiantes.Contabilidad = t.Contabilidad;
                estudiantes.Programacion = t.Programacion;

                pepitoSchoolDBContext.Estudiantes.Update(estudiantes);
                return pepitoSchoolDBContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
