using Actividad_Práctica_04.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Práctica_04.Data.Repositorio.Interfaces
{
    public interface IServicioRepositori
    {
        void Save(T_SERVICIOS tservicio);
        List<T_SERVICIOS> GetAll();
        T_SERVICIOS? GetId(int id);
        void Update(T_SERVICIOS tServicio);
        void Delete(T_SERVICIOS tServicio);
        void Delete(int id);
    }
}
