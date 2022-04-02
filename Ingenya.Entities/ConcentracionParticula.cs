using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class ConcentracionParticula :BaseEntity
    {
        public ConcentracionParticula() { }

        public ConcentracionParticula(int IdConcentracionParticula,ProyectoRoom ObjProyectoRoom, string Tiempo,double ConcenPartiIni,double ConcenPartiGen,double PartiIni,double PartiRetorna,double PartiFin,double ConcenPartiFin,double ConceIncome)
        {
            this.IdConcentracionParticula = IdConcentracionParticula;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Tiempo = Tiempo;
            this.ConcenPartiIni = ConcenPartiIni;
            this.ConcenPartiGen = ConcenPartiGen;
            this.PartiIni = PartiIni;
            this.PartiRetorna = PartiRetorna;
            this.PartiFin = PartiFin;
            this.ConcenPartiFin = ConcenPartiFin;
            this.ConceIncome = ConceIncome;
        }

        public int IdConcentracionParticula { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public string Tiempo { get; set; }
        public double ConcenPartiIni { get; set; }
        public double ConcenPartiGen { get; set; }
        public double PartiIni { get; set; }
        public double PartiRetorna { get; set; }
        public double PartiFin { get; set; }
        public double ConcenPartiFin { get; set; }

        public double ConceIncome { get; set; }

        
    }
}
