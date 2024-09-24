using Actividad_Práctica_04.Data.Models;
using Actividad_Práctica_04.Data.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Práctica_04.Data.Repositorio.Implemetacion
{
    public class ServicioRepositorio : IServicioRepositori
    {
        private db_turnosContext Contex;
        public ServicioRepositorio(db_turnosContext db_TurnosContext)
        {
            Contex = db_TurnosContext;
        }
        public void Delete(T_SERVICIOS tServicio)
        {
            Contex.TServicios.Remove(tServicio);
            Contex.SaveChanges();
        }

        public void Delete(int id)
        {
            var ServicioDelte = GetId(id);
            Contex.TServicios.Remove(ServicioDelte);
            Contex.SaveChanges();
        }

        public List<T_SERVICIOS> GetAll()
        {
            return Contex.TServicios.ToList();
        }

        public T_SERVICIOS? GetId(int id)
        {
            return Contex.TServicios.Find(id);
        }

        public void Save(T_SERVICIOS tservicio)
        {
            Contex.TServicios.Add(tservicio);
            Contex.SaveChanges();
        }

        public void Update(T_SERVICIOS tServicio)
        {
            if(tServicio != null)
            {
                Contex.TServicios.Update(tServicio);
                Contex.SaveChanges();
            }
           
        }
    }
}
