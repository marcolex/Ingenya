using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class GraNivActCalorLatente :BaseEntity
    {
        public GraNivActCalorLatente() { }

        public GraNivActCalorLatente(int IdGravNivActCalorLatente,ProyectoRoom ObjProyectoRoom,String TipoAplicacion, double Porcentaje,double CalorSensible) {
            this.IdGravNivActCalorLatente = IdGravNivActCalorLatente;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.TipoAplicacion = TipoAplicacion;
            this.Porcentaje = Porcentaje;
            this.CalorSensible = CalorSensible;
        }

        public int IdGravNivActCalorLatente { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public string TipoAplicacion { get; set; }
        public double Porcentaje { get; set; }
        public double CalorSensible { get; set; }
    }
}
