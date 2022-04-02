using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class PreparaMezcla: BaseEntity
    {
        public PreparaMezcla() { }

        public PreparaMezcla(int IdPreparaMezcla,ProyectoRoom ObjProyectoRoom,NombreParametro ObjNombreParametro,double MakeUpAir,double Retorno)
        {
            this.IdPreparaMezcla = IdPreparaMezcla;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.ObjNombreParametro = ObjNombreParametro;
            this.MakeUpAir = MakeUpAir;
            this.Retorno = Retorno;
        }

        public int IdPreparaMezcla { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public NombreParametro ObjNombreParametro { get; set; }
        public double MakeUpAir { get; set; }
        public double Retorno { get; set; }
    }
}
