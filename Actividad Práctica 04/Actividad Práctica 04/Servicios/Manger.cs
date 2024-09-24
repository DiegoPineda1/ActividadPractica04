using Actividad_Práctica_04.Data.Models;
using Actividad_Práctica_04.Data.Repositorio.Implemetacion;
using Actividad_Práctica_04.Data.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Práctica_04.Servicio
{
    public class Manger : IManeger
    {
        private IServicioRepositori _servicioRepositori;
        public Manger(IServicioRepositori servicioRepositori)
        {
            _servicioRepositori = servicioRepositori;
        }

        public void Delete(T_SERVICIOS tServicio)
        {
            _servicioRepositori.Delete(tServicio);
        }

        public void Delete(int id)
        {
            _servicioRepositori.Delete(id);
        }

        public List<T_SERVICIOS> GetAll()
        {
            return _servicioRepositori.GetAll();
        }

        public T_SERVICIOS? GetId(int id)
        {
            return _servicioRepositori.GetId(id);
        }

        public void Save(T_SERVICIOS tservicio)
        {
            _servicioRepositori.Save(tservicio);
        }

        public void Update(T_SERVICIOS tServicio)
        {
            _servicioRepositori.Update(tServicio);
        }
    }
}
