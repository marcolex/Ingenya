using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenya.Entities
{
    public class CartaPsicometrica :BaseEntity
    {
        public CartaPsicometrica() { }
        public CartaPsicometrica(int IdCartaPsicometrica, ProyectoRoom ObjProyectoRoom, double Dbt, double CienPorCiento,double OchentaProCiento,double SesentaPorCiento,double CuarentaPorCiento,double VeintePorCiento,double TreintaYCientoTem,double CuarentaYCientoTem,double CincuentaYCincoTem,double SesentaYCincoTem,double SetentaYCincoTem,double OchentaYCincoTem,double NoventaYCincoTem,double CientoCincoTem,double CientoDiezTem,double CientoQuinceTem,double CientoVeinteTem,double CientoVeintiCincoTem,double CientoTreintaTem) {
            this.IdCartaPsicometrica = IdCartaPsicometrica;
            this.ObjProyectoRoom = ObjProyectoRoom;
            this.Dbt = Dbt;
            this.CienPorCiento = CienPorCiento;
            this.OchentaProCiento = OchentaProCiento;
            this.SesentaPorCiento = SesentaPorCiento;
            this.CuarentaPorCiento = CuarentaPorCiento;
            this.VeintePorCiento = VeintePorCiento;
            this.TreintaYCientoTem = TreintaYCientoTem;
            this.CuarentaYCientoTem = CuarentaYCientoTem;
            this.CincuentaYCincoTem = CincuentaYCincoTem;
            this.SesentaYCincoTem = SesentaYCincoTem;
            this.SetentaYCincoTem = SetentaYCincoTem;
            this.OchentaYCincoTem = OchentaYCincoTem;
            this.NoventaYCincoTem = NoventaYCincoTem;
            this.CientoCincoTem = CientoCincoTem;
            this.CientoDiezTem = CientoDiezTem;
            this.CientoQuinceTem = CientoQuinceTem;
            this.CientoVeinteTem = CientoVeinteTem;
            this.CientoVeintiCincoTem = CientoVeintiCincoTem;
            this.CientoTreintaTem = CientoTreintaTem;
        }

        public int IdCartaPsicometrica { get; set; }
        public ProyectoRoom ObjProyectoRoom { get; set; }
        public double Dbt { get; set; }
        public double CienPorCiento { get; set; }
        public double OchentaProCiento { get; set; }
        public double SesentaPorCiento { get; set; }
        public double CuarentaPorCiento { get; set; }
        public double VeintePorCiento { get; set; }
        public double TreintaYCientoTem { get; set; }
        public double CuarentaYCientoTem { get; set; }
        public double CincuentaYCincoTem { get; set; }
        public double SesentaYCincoTem { get; set; }
        public double SetentaYCincoTem { get; set; }
        public double OchentaYCincoTem { get; set; }
        public double NoventaYCincoTem { get; set; }
        public double CientoCincoTem { get; set; }
        public double CientoDiezTem { get; set; }
        public double CientoQuinceTem { get; set; }
        public double CientoVeinteTem { get; set; }
        public double CientoVeintiCincoTem { get; set; }
        public double CientoTreintaTem { get; set; }
    }
}
