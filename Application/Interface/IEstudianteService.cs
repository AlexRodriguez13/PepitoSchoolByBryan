using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
   public interface IEstudianteService<T>
    {
        void Añadir(T t);
        bool eliminar(T t);
        void FindByName(T t);
        void FindByLastName(T t);
        void FindByCarnet(T t);
        void Update(T t);

    }
}
