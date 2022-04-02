using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class GraficoNivelActividad :BaseEntity
    {
        public GraficoNivelActividad() { }

        public GraficoNivelActividad(int IdGraficoNivelActividad,NombreParametro ObjNombreParametro, ProyectoRoom ObjProyectoRoom, double Porcentaje,double CalorSensible)
        {
            this.IdGraficoNivelActividad = IdGraficoNivelActividad;
            this.ObjNombreParametro = ObjNombreParametro;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Porcentaje = Porcentaje;
            this.CalorSensible = CalorSensible;
        }

        public int IdGraficoNivelActividad { get; set; }
        public NombreParametro ObjNombreParametro { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public double Porcentaje { get; set; }
        public double CalorSensible { get; set; }
    }
}
