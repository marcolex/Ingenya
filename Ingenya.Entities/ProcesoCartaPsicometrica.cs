using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class ProcesoCartaPsicometrica:BaseEntity
    {
        public ProcesoCartaPsicometrica() { }

        public ProcesoCartaPsicometrica(int IdProcesoCartaPsicometrica,ProyectoRoom ObjProyectoRoom,double Punto,double Dbt,double W,String Description,String Tipo)
        {
            this.IdProcesoCartaPsicometrica = IdProcesoCartaPsicometrica;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Punto = Punto;
            this.Dbt = Dbt;
            this.W = W;
            this.Description = Description;
            this.Tipo = Tipo;
        }

        public int IdProcesoCartaPsicometrica { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public double Punto { get; set; }
        public double Dbt { get; set; }
        public double W { get; set; }
        public string Description { get; set; }
        public string Tipo { get; set; }
    }
}
