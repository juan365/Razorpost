using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploRazor.Models
{
    public class ModeloPlantilla
    {
        REAL_MADRIDEntities contexto;
        public ModeloPlantilla()
        {
            this.contexto = new REAL_MADRIDEntities();
        }
        public MADRID GetJugador()
        {
            var consulta = from datos in contexto.MADRID
                           select datos;
            return consulta.FirstOrDefault();
        }
        public List<MADRID> GetPlantilla()
        {
            var consulta = from datos in contexto.MADRID
                           select datos;
            return consulta.ToList();
        }

        public MADRID GetDetalles(int dorsal)
        {
            var consulta = from datos in contexto.MADRID
                           where datos.DORSAL == dorsal
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}