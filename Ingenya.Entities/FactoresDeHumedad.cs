using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class FactoresDeHumedad : BaseEntity
    {
        public FactoresDeHumedad() { }
        public FactoresDeHumedad(int IdFactoresDeHumedad, ProyectoRoom objProyectoRoom, Parametro objParametro)
        {
            this.IdFactoresDeHumedad = IdFactoresDeHumedad;
            ObjProyectoRoom = objProyectoRoom;
            ObjParametro = objParametro;
        }

        public int IdFactoresDeHumedad { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public Parametro ObjParametro { get; set; }
    }
}
