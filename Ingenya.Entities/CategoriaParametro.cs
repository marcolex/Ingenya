using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class CategoriaParametro : BaseEntity
    {
        public CategoriaParametro() { }

        public CategoriaParametro(int IdCategoriaParametro, SubCategoriaParametro ObjSubCategoriaParametro,String Nombre)
        {
            this.IdCategoriaParametro = IdCategoriaParametro;
            this.ObjSubCategoriaParametro = ObjSubCategoriaParametro;
            this.Nombre = Nombre;
        }

        public int IdCategoriaParametro { get; set; }
        public SubCategoriaParametro ObjSubCategoriaParametro { get; set; }
        public string Nombre { get; set; }
    }
}
