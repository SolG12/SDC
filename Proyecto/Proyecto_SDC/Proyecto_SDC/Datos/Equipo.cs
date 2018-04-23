using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_SDC.Datos
{
   public class Equipo
    {
        public int ID { get; set; }
        public int id_cliente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Funcionalidad { get; set; }
        public string Tipo { get; set; }
        public string No_Orden { get; set; }
        
    }
}
