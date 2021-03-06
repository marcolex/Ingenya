using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class SubCategoriaParametro : BaseEntity
    {
        public SubCategoriaParametro() { }

        public SubCategoriaParametro(int IdSubCategoriaParametro,Parametro ObjParametro,String Nombre)
        {
            this.IdSubCategoriaParametro = IdSubCategoriaParametro;
            this.ObjParametro = ObjParametro;
            this.Nombre = Nombre;
        }

        public int IdSubCategoriaParametro { get; set; }
        public Parametro ObjParametro { get; set; }
        public string Nombre { get; set; }
    }
}
