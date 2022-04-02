using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class Parametro:BaseEntity
    {
        public Parametro() { }

        public Parametro(int IdParametro,NombreParametro ObjNombreParametro,double Valor,int Editable,DateTime Fecha)
        {
            this.IdParametro = IdParametro;
            this.ObjNombreParametro = ObjNombreParametro;
            this.Valor = Valor;
            this.Editable = Editable;
            this.Fecha = Fecha;
        }

        public int IdParametro { get; set; }
        public NombreParametro ObjNombreParametro { get; set; }
        public double Valor { get; set; }
        public int Editable { get; set; }
        public DateTime Fecha { get; set; }
    }
}
