using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class Room : BaseEntity
    {
        public Room() { }
        public Room(int IdRoom, String Nombre)
        {
            this.IdRoom = IdRoom;
            this.Nombre = Nombre;
        }

        public int IdRoom { get; set; }
        public string Nombre { get; set; }
    }
}
