using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class Reporte : BaseEntity
    {
        public Reporte() { }

        public Reporte(int IdReporte,ProyectoRoom ObjProyectoRoom,DateTime Fecha,byte[] Archivo)
        {
            this.IdReporte = IdReporte;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Fecha = Fecha;
            this.Archivo = Archivo;
        }

        public int IdReporte { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Archivo { get; set; }
    }
}
