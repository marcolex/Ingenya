using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class Fuga:BaseEntity
    {
        public Fuga() { }

        public Fuga(int IdFuga,ProyectoRoom ObjProyectoRoom, NombreParametro ObjNombreParametro, double Cantidad,double Area,double Factor,double Flow)
        {
            this.IdFuga = IdFuga;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.ObjNombreParametro = ObjNombreParametro;
            this.Cantidad = Cantidad;
            this.Area = Area;
            this.Factor = Factor;
            this.Flow = Flow;
        }

        public int IdFuga { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public NombreParametro ObjNombreParametro { get; set; }
        public double Cantidad { get; set; }
        public double Area { get; set; }
        public double Factor { get; set; }
        public double Flow { get; set; }
    }
}
