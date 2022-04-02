using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class Ocupacion: BaseEntity
    {
        public Ocupacion() { }

        public Ocupacion(int IdOcupacion,NombreParametro ObjNombreParametro,ProyectoRoom ObjProyectoRoom,double Porcentaje,int GeneracionXPersona)
        {
            this.IdOcupacion = IdOcupacion;
            this.ObjNombreParametro = ObjNombreParametro;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Porcentaje = Porcentaje;
            this.GeneracionXPersona = GeneracionXPersona;
        }

        public int IdOcupacion { get; set; }
        public NombreParametro ObjNombreParametro { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public double Porcentaje { get; set; }
        public int GeneracionXPersona { get; set; }
    }
}
