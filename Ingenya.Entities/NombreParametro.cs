using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class NombreParametro: BaseEntity
    {
        private readonly int idNombreParametro;

        public NombreParametro() { }

        public NombreParametro(int IdNombreParametro,String Medida,DateTime Fecha,String Nombre)
        {
            idNombreParametro = IdNombreParametro;
            this.Medida = Medida;
            this.Fecha = Fecha;
            this.Nombre = Nombre;
        }

        public int IdNombreParametro { get; set; }

        public string Medida { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
    }
}
