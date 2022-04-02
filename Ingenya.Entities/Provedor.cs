using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class Provedor : BaseEntity
    {
        public Provedor() { }

        public Provedor(int IdProvedor, String NombreProyecto, String Site, String Telefono, String Direccion, String CorreoContacto)
        {
            this.IdProvedor = IdProvedor;
            this.NombreProyecto = NombreProyecto;
            this.Site = Site;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.CorreoContacto = CorreoContacto;
        }

        public int IdProvedor { get; set; }
        public string NombreProyecto { get; set; }
        public string Site { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CorreoContacto { get; set; }
    }
}
