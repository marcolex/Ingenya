using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ingenya
{
    public partial class frm_Grafico : Form
    {
        double vElevation;
        public frm_Grafico()
        {
            InitializeComponent();
        }

        public frm_Grafico(Int32 tipo, double[] SeriesPoint , double elevation)
        {
            InitializeComponent();

            vElevation = elevation;


            MaximizeBox = false;

            MinimizeBox = false;


            if (tipo == 1)//Particle Concentration
            {

                this.Text = "Particle Concetration";

                ParticleConcetration(SeriesPoint);
            }
           
            lineChart.Legends[0].BackColor = Color.LightGray;

        }

        public frm_Grafico(Int32 tipo, double[,] matrizCP , double elevation)
        {
            InitializeComponent();

            vElevation = elevation;

            if (tipo == 2)
            {
                CargarLegendas();

                PsychrometricChart();
            }
            else if (tipo == 3)
            {
                //CargarLegendas2();

                //PsychrometricChartII();

                CargarBaseCPTemp(matrizCP);
            }
            else if (tipo == 4)//MAKE UP PRECOOLING
            {
                //CargarLegendas2();

                //PsychrometricChartII();

                // CargarBaseCPBasico(matrizCP);

                this.Text = "Make up Precooling";

                CargarBaseCPBasico(matrizCP, vElevation);
            }
            else if (tipo == 5)//MAKE UP COOLING
            {
                //CargarLegendas2();

                //PsychrometricChartII();

                this.Text = "Make up Cooling";

                CargarBaseCPBasico(matrizCP, vElevation);

                //CargarBaseCPNormal(matrizCP);
            }
            else if (tipo == 6)//MAKE UP Heating
            {
                //CargarLegendas2();

                //PsychrometricChartII();

                this.Text = "Make up Heating";

                CargarBaseCPBasico(matrizCP, vElevation);

                //CargarBaseCPNormal(matrizCP);
            }
            else if (tipo == 7)//Recirculating Air Handler
            {
                //CargarLegendas2();

                //PsychrometricChartII();

                this.Text = "Make up Heating";

                CargarBaseCPBasicoRAH(matrizCP,vElevation);

                //CargarBaseCPNormal(matrizCP);
            }
            else
            {
                //CargarLegendas2();

                //PsychrometricChartII();

                this.Text = "Carta Psicrometrica";

                CargarBaseCPBasicoCarta(matrizCP);

                //CargarBaseCPNormal(matrizCP);
            }



            //lineChart.Series["Series1"].Points[0].LegendText = "wo";
            //lineChart.Series["Series1"].Points[1].LegendText = "wa";
            //lineChart.Series["Series1"].Points[2].LegendText = "wi";

            //lineChart.Series["Series1"].IsValueShownAsLabel = true;



            lineChart.Legends[0].BackColor = Color.LightGray;

            //lineChart.Series["Series1"].Label = "#PERCENT";
            //lineChart.Series[0].LegendText = "#VALX";


            // chart1.ChartAreas[0].AxisY.LabelStyle.Format = "";
        }

        public void CargarBaseCP(double[,] matrizCP)
        {
            DataTable dt = new DataTable();            //dt.Columns.Add(new DataColumn("180"));
            dt.Columns.Add(new DataColumn("100%"));
            dt.Columns.Add(new DataColumn("80%"));
            dt.Columns.Add(new DataColumn("60%"));
            dt.Columns.Add(new DataColumn("40%"));
            dt.Columns.Add(new DataColumn("20%"));
            dt.Columns.Add(new DataColumn("MUP"));
            //35, 45 , 55, 65, 75, 85 , 95, 105,110,115,120,125,130
            //dt.Columns.Add(new DataColumn("35"));
            //dt.Columns.Add(new DataColumn("40"));
            //dt.Columns.Add(new DataColumn("45"));//EVALUADO 2
            //dt.Columns.Add(new DataColumn("50"));
            //dt.Columns.Add(new DataColumn("55"));//EVALUADO 4
            //dt.Columns.Add(new DataColumn("60"));
            //dt.Columns.Add(new DataColumn("65"));//EVALUADO 6
            //dt.Columns.Add(new DataColumn("70"));
            //dt.Columns.Add(new DataColumn("75"));//EVALUADO 8
            //dt.Columns.Add(new DataColumn("80"));
            //dt.Columns.Add(new DataColumn("85"));//EVALUADO 10
            //dt.Columns.Add(new DataColumn("90"));
            //dt.Columns.Add(new DataColumn("95"));//EVALUADO 12
            //dt.Columns.Add(new DataColumn("100"));
            //dt.Columns.Add(new DataColumn("105"));//EVALUADO 14
            //dt.Columns.Add(new DataColumn("110"));//EVALUADO 15
            //dt.Columns.Add(new DataColumn("115"));//EVALUADO 16
            //dt.Columns.Add(new DataColumn("120"));//EVALUADO 17
            //dt.Columns.Add(new DataColumn("125"));
            //dt.Columns.Add(new DataColumn("130"));
            //dt.Columns.Add(new DataColumn("135"));
            //dt.Columns.Add(new DataColumn("140"));
            //dt.Columns.Add(new DataColumn("145"));
            //dt.Columns.Add(new DataColumn("150"));
            //dt.Columns.Add(new DataColumn("155"));
            //dt.Columns.Add(new DataColumn("160"));
            //dt.Columns.Add(new DataColumn("165"));
            //dt.Columns.Add(new DataColumn("170"));
            //dt.Columns.Add(new DataColumn("175"));
            //dt.Columns.Add(new DataColumn("180"));
            //dt.Columns.Add(new DataColumn("185"));
            //dt.Columns.Add(new DataColumn("190"));
            //dt.Columns.Add(new DataColumn("195"));
            //dt.Columns.Add(new DataColumn("200"));

            for (int row = 0; row < 34; row++)
            {
                //if (row == 2 || row == 4 || row == 6 || row == 8 || row == 10 || row == 12
                //    || row == 14 || row == 15 || row == 16 || row == 17)
                    dt.Rows.Add(matrizCP[row, 0], matrizCP[row, 1], matrizCP[row, 2], matrizCP[row, 3], matrizCP[row, 4]);
                //dt.Rows.Add(new DataRow() )
                //dt.Rows.Add(matrizCP[row, 0],matrizCP[row,1], matrizCP[row, 2], matrizCP[row, 3], matrizCP[row, 4], 
                //    matrizCP[row, 5], matrizCP[row, 6], matrizCP[row, 7], matrizCP[row, 8], matrizCP[row, 9], 
                //    matrizCP[row, 10], matrizCP[row, 11], matrizCP[row, 12], matrizCP[row, 13], matrizCP[row, 14]
                //    , matrizCP[row, 15], matrizCP[row, 16], matrizCP[row, 17], matrizCP[row, 18], matrizCP[row, 19]
                //    , matrizCP[row, 20], matrizCP[row, 21], matrizCP[row, 22], matrizCP[row, 23], matrizCP[row, 24]
                //    , matrizCP[row, 25], matrizCP[row, 26], matrizCP[row, 27], matrizCP[row, 28], matrizCP[row, 29]
                //    , matrizCP[row, 30], matrizCP[row, 31], matrizCP[row, 32], matrizCP[row, 33]);       

            }

            Title title = lineChart.Titles.Add("Psychrometric Chart");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            lineChart.Series.Add("100%");
            lineChart.Series.Add("80%");
            lineChart.Series.Add("60%");
            lineChart.Series.Add("40%");
            lineChart.Series.Add("20%");


            lineChart.DataSource = dt;

            //lineChart.Series["Series1"].XValueMember = "OSA";

            lineChart.Series["100%"].BorderWidth = 3;
            //lineChart.Series["100%"].MarkerStyle = MarkerStyle.Square;
            lineChart.Series["100%"].MarkerSize = 8;
            lineChart.Series["100%"].MarkerColor = Color.Blue;

            lineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;


            lineChart.Series["100%"].BorderColor = Color.Blue;

            lineChart.Series["100%"].Color = Color.Blue;

            lineChart.Series["100%"].YAxisType = AxisType.Primary;
            lineChart.Series["100%"].YValueMembers = "100%";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["100%"].ChartType = SeriesChartType.Line;

            //lineChart.Series["100%"].IsVisibleInLegend = false;


            //lineChart.Series.Add("Series2");
            
            lineChart.Series["80%"].BorderWidth = 3;
            lineChart.Series["80%"].MarkerSize = 8;
            lineChart.Series["80%"].MarkerColor = Color.Yellow;

            lineChart.Series["80%"].BorderColor = Color.Yellow;

            lineChart.Series["80%"].Color = Color.Yellow;

            lineChart.Series["80%"].XAxisType = AxisType.Primary;
            lineChart.Series["80%"].YValueMembers = "80%";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["80%"].ChartType = SeriesChartType.Line;



            lineChart.Series["60%"].BorderWidth = 3;
            lineChart.Series["60%"].MarkerSize = 8;
            lineChart.Series["60%"].MarkerColor = Color.Orange;

            lineChart.Series["60%"].BorderColor = Color.Orange;

            lineChart.Series["60%"].Color = Color.Orange;

            lineChart.Series["60%"].XAxisType = AxisType.Primary;
            lineChart.Series["60%"].YValueMembers = "60%";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["60%"].ChartType = SeriesChartType.Line;


            lineChart.Series["40%"].BorderWidth = 3;
            lineChart.Series["40%"].MarkerSize = 8;
            lineChart.Series["40%"].MarkerColor = Color.Purple;

            lineChart.Series["40%"].BorderColor = Color.Purple;

            lineChart.Series["40%"].Color = Color.Purple;

            lineChart.Series["40%"].XAxisType = AxisType.Primary;
            lineChart.Series["40%"].YValueMembers = "40%";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["40%"].ChartType = SeriesChartType.Line;



            lineChart.Series["20%"].BorderWidth = 3;
            lineChart.Series["20%"].MarkerSize = 8;
            lineChart.Series["20%"].MarkerColor = Color.DarkBlue;

            lineChart.Series["20%"].BorderColor = Color.DarkBlue;

            lineChart.Series["20%"].Color = Color.DarkBlue;

            lineChart.Series["20%"].XAxisType = AxisType.Primary;
            lineChart.Series["20%"].YValueMembers = "20%";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["20%"].ChartType = SeriesChartType.Line;
        }

        public void CargarBaseCPBasico(double[,] matrizCP, double Elevation)
        {
            //lineChart.DataSource = dt;

            Title title = lineChart.Titles.Add("Psychrometric Chart");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            lineChart.ChartAreas.Add("MAH");

            lineChart.Series.Add("MAH");

            //45°F wbT
            lineChart.Series.Add("45");

            lineChart.Series["45"].BorderWidth = 1;
            lineChart.Series["45"].Color = Color.Gray;
            lineChart.Series["45"].ChartType = SeriesChartType.Spline;
            lineChart.Series["45"].LegendText = "45°F wbT";

            //55°F wbT
            lineChart.Series.Add("55");

            lineChart.Series["55"].BorderWidth = 1;
            lineChart.Series["55"].Color = Color.Gray;
            lineChart.Series["55"].ChartType = SeriesChartType.Spline;
            lineChart.Series["55"].LegendText = "55°F wbT";

            //65°F wbT
            lineChart.Series.Add("65");

            lineChart.Series["65"].BorderWidth = 1;
            lineChart.Series["65"].Color = Color.Gray;
            lineChart.Series["65"].ChartType = SeriesChartType.Spline;
            lineChart.Series["65"].LegendText = "65°F wbT";

            //75°F wbT
            lineChart.Series.Add("75");

            lineChart.Series["75"].BorderWidth = 1;
            lineChart.Series["75"].Color = Color.Gray;
            lineChart.Series["75"].ChartType = SeriesChartType.Spline;
            lineChart.Series["75"].LegendText = "75°F wbT";

            //85°F wbT
            lineChart.Series.Add("85");

            lineChart.Series["85"].BorderWidth = 1;
            lineChart.Series["85"].Color = Color.Gray;
            lineChart.Series["85"].ChartType = SeriesChartType.Spline;
            lineChart.Series["85"].LegendText = "85°F wbT";

            //95°F wbT
            lineChart.Series.Add("95");

            lineChart.Series["95"].BorderWidth = 1;
            lineChart.Series["95"].Color = Color.Gray;
            lineChart.Series["95"].ChartType = SeriesChartType.Spline;
            lineChart.Series["95"].LegendText = "95°F wbT";

            //105°F wbT
            lineChart.Series.Add("105");

            lineChart.Series["105"].BorderWidth = 1;
            lineChart.Series["105"].Color = Color.Gray;
            lineChart.Series["105"].ChartType = SeriesChartType.Spline;
            lineChart.Series["105"].LegendText = "105°F wbT";

            //110°F wbT
            lineChart.Series.Add("110");

            lineChart.Series["110"].BorderWidth = 1;
            lineChart.Series["110"].Color = Color.Gray;
            lineChart.Series["110"].ChartType = SeriesChartType.Spline;
            lineChart.Series["110"].LegendText = "110°F wbT";

            //115°F wbT
            lineChart.Series.Add("115");

            lineChart.Series["115"].BorderWidth = 1;
            lineChart.Series["115"].Color = Color.Gray;
            lineChart.Series["115"].ChartType = SeriesChartType.Spline;
            lineChart.Series["115"].LegendText = "115°F wbT";

            //120°F wbT
            lineChart.Series.Add("120");

            lineChart.Series["120"].BorderWidth = 1;
            lineChart.Series["120"].Color = Color.Gray;
            lineChart.Series["120"].ChartType = SeriesChartType.Spline;
            lineChart.Series["120"].LegendText = "120°F wbT";

            //SERIES 100
            lineChart.Series.Add("100%");

            CalcularGraficaPsico(lineChart.Series["100%"],1, Elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["100%"].BorderWidth = 4;
            lineChart.Series["100%"].MarkerSize = 8;
            lineChart.Series["100%"].MarkerColor = Color.Black;

            lineChart.Series["100%"].BorderColor = Color.Black;

            lineChart.Series["100%"].Color = Color.Black;

            lineChart.Series["100%"].ChartArea = "MAH";

            lineChart.Series["100%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["100%"].ToolTip = "#VAL - #VALX";

            lineChart.Series["100%"].Label = "#VALX";

            /////////////////////////////////////////////////////////////
            
            //SERIES 80
            lineChart.Series.Add("80%");

            CalcularGraficaPsico(lineChart.Series["80%"],0.80, Elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["80%"].BorderWidth = 1;
            lineChart.Series["80%"].MarkerSize = 8;
            lineChart.Series["80%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["80%"].BorderColor = Color.SkyBlue;

            lineChart.Series["80%"].Color = Color.SkyBlue;

            lineChart.Series["80%"].ChartArea = "MAH";

            lineChart.Series["80%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["80%"].ToolTip = "#VAL - #VALX";

            /////////////////////////////////////////////////////////////

            //SERIES 60
            lineChart.Series.Add("60%");

            CalcularGraficaPsico(lineChart.Series["60%"],0.60, Elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["60%"].BorderWidth = 1;
            lineChart.Series["60%"].MarkerSize = 8;
            lineChart.Series["60%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["60%"].BorderColor = Color.SkyBlue;

            lineChart.Series["60%"].Color = Color.SkyBlue;

            lineChart.Series["60%"].ChartArea = "MAH";

            lineChart.Series["60%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["60%"].ToolTip = "#VAL - #VALX";

            /////////////////////////////////////////////////////////////

            //SERIES 40
            lineChart.Series.Add("40%");

            CalcularGraficaPsico(lineChart.Series["40%"],0.40, Elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["40%"].BorderWidth = 1;
            lineChart.Series["40%"].MarkerSize = 8;
            lineChart.Series["40%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["40%"].BorderColor = Color.SkyBlue;

            lineChart.Series["40%"].Color = Color.SkyBlue;

            lineChart.Series["40%"].ChartArea = "MAH";

            lineChart.Series["40%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["40%"].ToolTip = "#VAL  - #VALX";

            /////////////////////////////////////////////////////////////

            //SERIES 20
            lineChart.Series.Add("20%");

            CalcularGraficaPsico(lineChart.Series["20%"],0.20, Elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["20%"].BorderWidth = 1;
            lineChart.Series["20%"].MarkerSize = 8;
            lineChart.Series["20%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["20%"].BorderColor = Color.SkyBlue;

            lineChart.Series["20%"].Color = Color.SkyBlue;

            lineChart.Series["20%"].ChartArea = "MAH";

            lineChart.Series["20%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["20%"].ToolTip = "#VAL - #VALX";


            /////////////////////////////////////////////////////////////
            ///
            lineChart.Series["MAH"].Points.AddXY(matrizCP[0, 0], matrizCP[0, 1]);
            lineChart.Series["MAH"].Points.AddXY(matrizCP[1, 0], matrizCP[1, 1]);

            lineChart.Series["MAH"].BorderWidth = 3;
            lineChart.Series["MAH"].MarkerSize = 8;
            lineChart.Series["MAH"].MarkerColor = Color.Blue;

            lineChart.Series["MAH"].BorderColor = Color.Blue;

            lineChart.Series["MAH"].Color = Color.Blue;

            lineChart.Series["MAH"].MarkerStyle = MarkerStyle.Square;

            //lineChart.Series["MAH"].YValueMembers = "w";

            //lineChart.Series["MAH"].XValueMember = "dbt";

            lineChart.Series["MAH"].ChartArea = "MAH";

            lineChart.Series["MAH"].ToolTip = "#VAL - #VALX";

            lineChart.ChartAreas[0].Visible = false;

            lineChart.ChartAreas["MAH"].AxisY.Title = "W (Lba/Lbw)";

            lineChart.ChartAreas["MAH"].AxisY.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas["MAH"].AxisX.Title = "dbT (F)";

            lineChart.ChartAreas["MAH"].AxisX.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas["MAH"].Visible = true;

            lineChart.ChartAreas["MAH"].AxisY.Interval = 0.01;

            lineChart.ChartAreas["MAH"].AxisY.Minimum = 0.00;

            lineChart.ChartAreas["MAH"].AxisY.Maximum = 0.03;

            lineChart.ChartAreas["MAH"].AxisX.Minimum = 35;

            lineChart.ChartAreas["MAH"].AxisX.Interval = 10;

            lineChart.ChartAreas["MAH"].AxisX.Maximum = 115;

            //lineChart.ChartAreas["MAH"].AxisX.IsReversed = true;

            lineChart.Series["MAH"].ChartType = SeriesChartType.Line;

            lineChart.ChartAreas["MAH"].AxisX.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.ChartAreas["MAH"].AxisX.MajorGrid.Interval = 10;

            lineChart.ChartAreas["MAH"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.Series["Series1"].IsVisibleInLegend = false;
        }

        public void CargarBaseCPBasicoRAH(double[,] matrizCP,double elevation)
        {
            //lineChart.DataSource = dt;

            Title title = lineChart.Titles.Add("Psychrometric Chart");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            lineChart.ChartAreas.Add("RAH");

            lineChart.Series.Add("RAH");

            //ReH

            lineChart.Series.Add("Re-Heaters");

            lineChart.Series["Re-Heaters"].Points.AddXY(matrizCP[4, 0], matrizCP[4, 1]);
            lineChart.Series["Re-Heaters"].Points.AddXY(matrizCP[5, 0], matrizCP[5, 1]);

            lineChart.Series["Re-Heaters"].BorderWidth = 3;
            lineChart.Series["Re-Heaters"].MarkerSize = 8;
            lineChart.Series["Re-Heaters"].MarkerColor = Color.DarkRed;

            lineChart.Series["Re-Heaters"].BorderColor = Color.DarkRed;

            lineChart.Series["Re-Heaters"].Color = Color.DarkRed;

            lineChart.Series["Re-Heaters"].MarkerStyle = MarkerStyle.Diamond;

            lineChart.Series["Re-Heaters"].ChartArea = "RAH";

            lineChart.Series["Re-Heaters"].ChartType = SeriesChartType.Line;

            //45°F wbT
            lineChart.Series.Add("45");

            lineChart.Series["45"].BorderWidth = 1;
            lineChart.Series["45"].Color = Color.Gray;
            lineChart.Series["45"].ChartType = SeriesChartType.Spline;
            lineChart.Series["45"].LegendText = "45°F wbT";

            //55°F wbT
            lineChart.Series.Add("55");

            lineChart.Series["55"].BorderWidth = 1;
            lineChart.Series["55"].Color = Color.Gray;
            lineChart.Series["55"].ChartType = SeriesChartType.Spline;
            lineChart.Series["55"].LegendText = "55°F wbT";

            //65°F wbT
            lineChart.Series.Add("65");

            lineChart.Series["65"].BorderWidth = 1;
            lineChart.Series["65"].Color = Color.Gray;
            lineChart.Series["65"].ChartType = SeriesChartType.Spline;
            lineChart.Series["65"].LegendText = "65°F wbT";

            //75°F wbT
            lineChart.Series.Add("75");

            lineChart.Series["75"].BorderWidth = 1;
            lineChart.Series["75"].Color = Color.Gray;
            lineChart.Series["75"].ChartType = SeriesChartType.Spline;
            lineChart.Series["75"].LegendText = "75°F wbT";

            //85°F wbT
            lineChart.Series.Add("85");

            lineChart.Series["85"].BorderWidth = 1;
            lineChart.Series["85"].Color = Color.Gray;
            lineChart.Series["85"].ChartType = SeriesChartType.Spline;
            lineChart.Series["85"].LegendText = "85°F wbT";

            //95°F wbT
            lineChart.Series.Add("95");

            lineChart.Series["95"].BorderWidth = 1;
            lineChart.Series["95"].Color = Color.Gray;
            lineChart.Series["95"].ChartType = SeriesChartType.Spline;
            lineChart.Series["95"].LegendText = "95°F wbT";

            //105°F wbT
            lineChart.Series.Add("105");

            lineChart.Series["105"].BorderWidth = 1;
            lineChart.Series["105"].Color = Color.Gray;
            lineChart.Series["105"].ChartType = SeriesChartType.Spline;
            lineChart.Series["105"].LegendText = "105°F wbT";

            //110°F wbT
            lineChart.Series.Add("110");

            lineChart.Series["110"].BorderWidth = 1;
            lineChart.Series["110"].Color = Color.Gray;
            lineChart.Series["110"].ChartType = SeriesChartType.Spline;
            lineChart.Series["110"].LegendText = "110°F wbT";

            //115°F wbT
            lineChart.Series.Add("115");

            lineChart.Series["115"].BorderWidth = 1;
            lineChart.Series["115"].Color = Color.Gray;
            lineChart.Series["115"].ChartType = SeriesChartType.Spline;
            lineChart.Series["115"].LegendText = "115°F wbT";

            //120°F wbT
            lineChart.Series.Add("120");

            lineChart.Series["120"].BorderWidth = 1;
            lineChart.Series["120"].Color = Color.Gray;
            lineChart.Series["120"].ChartType = SeriesChartType.Spline;
            lineChart.Series["120"].LegendText = "120°F wbT";

            //SERIES 100
            lineChart.Series.Add("100%");

            CalcularGraficaPsico(lineChart.Series["100%"], 1, elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["100%"].BorderWidth = 4;
            lineChart.Series["100%"].MarkerSize = 8;
            lineChart.Series["100%"].MarkerColor = Color.Black;

            lineChart.Series["100%"].BorderColor = Color.Black;

            lineChart.Series["100%"].Color = Color.Black;

            lineChart.Series["100%"].ChartArea = "RAH";

            lineChart.Series["100%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["100%"].ToolTip = "#VAL - #VALX";

            lineChart.Series["100%"].Label = "#VALX";

            /////////////////////////////////////////////////////////////

            //SERIES 80
            lineChart.Series.Add("80%");

            CalcularGraficaPsico(lineChart.Series["80%"], 0.80, elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["80%"].BorderWidth = 1;
            lineChart.Series["80%"].MarkerSize = 8;
            lineChart.Series["80%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["80%"].BorderColor = Color.SkyBlue;

            lineChart.Series["80%"].Color = Color.SkyBlue;

            lineChart.Series["80%"].ChartArea = "RAH";

            lineChart.Series["80%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["80%"].ToolTip = "#VAL - #VALX";

            /////////////////////////////////////////////////////////////

            //SERIES 60
            lineChart.Series.Add("60%");

            CalcularGraficaPsico(lineChart.Series["60%"], 0.60, elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["60%"].BorderWidth = 1;
            lineChart.Series["60%"].MarkerSize = 8;
            lineChart.Series["60%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["60%"].BorderColor = Color.SkyBlue;

            lineChart.Series["60%"].Color = Color.SkyBlue;

            lineChart.Series["60%"].ChartArea = "RAH";

            lineChart.Series["60%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["60%"].ToolTip = "#VAL - #VALX";

            /////////////////////////////////////////////////////////////

            //SERIES 40
            lineChart.Series.Add("40%");

            CalcularGraficaPsico(lineChart.Series["40%"], 0.40, elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["40%"].BorderWidth = 1;
            lineChart.Series["40%"].MarkerSize = 8;
            lineChart.Series["40%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["40%"].BorderColor = Color.SkyBlue;

            lineChart.Series["40%"].Color = Color.SkyBlue;

            lineChart.Series["40%"].ChartArea = "RAH";

            lineChart.Series["40%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["40%"].ToolTip = "#VAL  - #VALX";

            /////////////////////////////////////////////////////////////

            //SERIES 20
            lineChart.Series.Add("20%");

            CalcularGraficaPsico(lineChart.Series["20%"], 0.20, elevation);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["20%"].BorderWidth = 1;
            lineChart.Series["20%"].MarkerSize = 8;
            lineChart.Series["20%"].MarkerColor = Color.SkyBlue;

            lineChart.Series["20%"].BorderColor = Color.SkyBlue;

            lineChart.Series["20%"].Color = Color.SkyBlue;

            lineChart.Series["20%"].ChartArea = "RAH";

            lineChart.Series["20%"].ChartType = SeriesChartType.Spline;

            lineChart.Series["20%"].ToolTip = "#VAL - #VALX";


            /////////////////////////////////////////////////////////////
            ///
            //lineChart.Series.Add("RAH");

            lineChart.Series["RAH"].Points.AddXY(matrizCP[3, 0], matrizCP[3, 1]);
            lineChart.Series["RAH"].Points.AddXY(matrizCP[2, 0], matrizCP[2, 1]);

            lineChart.Series["RAH"].BorderWidth = 3;
            lineChart.Series["RAH"].MarkerSize = 8;
            lineChart.Series["RAH"].MarkerColor = Color.LimeGreen;

            lineChart.Series["RAH"].BorderColor = Color.LimeGreen;

            lineChart.Series["RAH"].Color = Color.LimeGreen;

            lineChart.Series["RAH"].MarkerStyle = MarkerStyle.Square;

            /////////////////////////////////////////////////////////////
            ///

            lineChart.Series.Add("RAH1");

            lineChart.Series["RAH1"].Points.AddXY(matrizCP[1, 0], matrizCP[1, 1]);
            lineChart.Series["RAH1"].Points.AddXY(matrizCP[2, 0], matrizCP[2, 1]);
           

            lineChart.Series["RAH1"].BorderWidth = 3;
            lineChart.Series["RAH1"].MarkerSize = 8;
            lineChart.Series["RAH1"].MarkerColor = Color.LimeGreen;

            lineChart.Series["RAH1"].BorderColor = Color.LimeGreen;

            lineChart.Series["RAH1"].Color = Color.LimeGreen;

            lineChart.Series["RAH1"].MarkerStyle = MarkerStyle.Square;

            lineChart.Series["RAH1"].IsVisibleInLegend = false;

            lineChart.Series["RAH1"].ChartArea = "RAH";

            lineChart.Series["RAH1"].ChartType = SeriesChartType.Line;

            /////////////////////////////////////////////////////////////
            ///

            lineChart.Series.Add("RAH2");

            lineChart.Series["RAH2"].Points.AddXY(matrizCP[1, 0], matrizCP[1, 1]);
            lineChart.Series["RAH2"].Points.AddXY(matrizCP[0, 0], matrizCP[0, 1]);

            lineChart.Series["RAH2"].BorderWidth = 3;
            lineChart.Series["RAH2"].MarkerSize = 8;
            lineChart.Series["RAH2"].MarkerColor = Color.LimeGreen;

            lineChart.Series["RAH2"].BorderColor = Color.LimeGreen;

            lineChart.Series["RAH2"].Color = Color.LimeGreen;

            lineChart.Series["RAH2"].MarkerStyle = MarkerStyle.Square;

            lineChart.Series["RAH2"].IsVisibleInLegend = false;

            lineChart.Series["RAH2"].ChartArea = "RAH";

            lineChart.Series["RAH2"].ChartType = SeriesChartType.Line;

            //lineChart.Series["MAH"].YValueMembers = "w";

            //lineChart.Series["MAH"].XValueMember = "dbt";

            lineChart.Series["RAH"].ChartArea = "RAH";

            lineChart.Series["RAH"].ToolTip = "#VAL - #VALX";

            lineChart.ChartAreas[0].Visible = false;

            lineChart.ChartAreas["RAH"].AxisY.Title = "W (Lba/Lbw)";

            lineChart.ChartAreas["RAH"].AxisY.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas["RAH"].AxisX.Title = "dbT (F)";

            lineChart.ChartAreas["RAH"].AxisX.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas["RAH"].Visible = true;

            lineChart.ChartAreas["RAH"].AxisY.Interval = 0.01;

            lineChart.ChartAreas["RAH"].AxisY.Minimum = 0.00;

            lineChart.ChartAreas["RAH"].AxisY.Maximum = 0.03;

            lineChart.ChartAreas["RAH"].AxisX.Minimum = 35;

            lineChart.ChartAreas["RAH"].AxisX.Interval = 10;

            lineChart.ChartAreas["RAH"].AxisX.Maximum = 115;

            //lineChart.ChartAreas["MAH"].AxisX.IsReversed = true;

            lineChart.Series["RAH"].ChartType = SeriesChartType.Line;

            lineChart.ChartAreas["RAH"].AxisX.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.ChartAreas["RAH"].AxisX.MajorGrid.Interval = 10;

            lineChart.ChartAreas["RAH"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.Series["Series1"].IsVisibleInLegend = false;
        }

        public void CargarBaseCPBasicoCarta(double[,] matrizCP)
        {
            //lineChart.DataSource = dt;

            Title title = lineChart.Titles.Add("Carta Psicrometrica");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            Title title2 = lineChart.Titles.Add("Elev = "+ vElevation + " Ft");
            title2.Font = new Font("Arial", 12, FontStyle.Bold);

            lineChart.ChartAreas.Add("Carta");

            lineChart.Series.Add("Carta");

            //SERIES 100
            lineChart.Series.Add("100%");

            CalcularGraficaPsico(lineChart.Series["100%"], 1, 3200);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["100%"].BorderWidth = 2;
            lineChart.Series["100%"].MarkerSize = 8;
            lineChart.Series["100%"].MarkerColor = Color.Black;

            lineChart.Series["100%"].BorderColor = Color.Black;

            lineChart.Series["100%"].Color = Color.Black;

            lineChart.Series["100%"].ChartArea = "Carta";

            lineChart.Series["100%"].ChartType = SeriesChartType.Spline;

            //lineChart.Series["100%"].ToolTip = "#VAL - #VALX";

            //lineChart.Series["100%"].Label = "#VALX";

            lineChart.Series["100%"].IsVisibleInLegend = false;

            /////////////////////////////////////////////////////////////

            //SERIES 80
            lineChart.Series.Add("80%");

            CalcularGraficaPsico(lineChart.Series["80%"], 0.80, 3200);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["80%"].BorderWidth = 1;
            lineChart.Series["80%"].MarkerSize = 8;
            lineChart.Series["80%"].MarkerColor = Color.Gainsboro;

            lineChart.Series["80%"].BorderColor = Color.Gainsboro;

            lineChart.Series["80%"].Color = Color.Gainsboro;

            lineChart.Series["80%"].ChartArea = "Carta";

            lineChart.Series["80%"].ChartType = SeriesChartType.Spline;

            //lineChart.Series["80%"].ToolTip = "#VAL - #VALX";

            lineChart.Series["80%"].IsVisibleInLegend = false;

            /////////////////////////////////////////////////////////////

            //SERIES 60
            lineChart.Series.Add("60%");

            CalcularGraficaPsico(lineChart.Series["60%"], 0.60, 3200);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["60%"].BorderWidth = 1;
            lineChart.Series["60%"].MarkerSize = 8;
            lineChart.Series["60%"].MarkerColor = Color.Gainsboro;

            lineChart.Series["60%"].BorderColor = Color.Gainsboro;

            lineChart.Series["60%"].Color = Color.Gainsboro;

            lineChart.Series["60%"].ChartArea = "Carta";

            lineChart.Series["60%"].ChartType = SeriesChartType.Spline;

            //lineChart.Series["60%"].ToolTip = "#VAL - #VALX";

            lineChart.Series["60%"].IsVisibleInLegend = false;

            /////////////////////////////////////////////////////////////

            //SERIES 40
            lineChart.Series.Add("40%");

            CalcularGraficaPsico(lineChart.Series["40%"], 0.40, 3200);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["40%"].BorderWidth = 1;
            lineChart.Series["40%"].MarkerSize = 8;
            lineChart.Series["40%"].MarkerColor = Color.Gainsboro;

            lineChart.Series["40%"].BorderColor = Color.Gainsboro;

            lineChart.Series["40%"].Color = Color.Gainsboro;

            lineChart.Series["40%"].ChartArea = "Carta";

            lineChart.Series["40%"].ChartType = SeriesChartType.Spline;

           // lineChart.Series["40%"].ToolTip = "#VAL  - #VALX";

            lineChart.Series["40%"].IsVisibleInLegend = false;

            /////////////////////////////////////////////////////////////

            //SERIES 20
            lineChart.Series.Add("20%");

            CalcularGraficaPsico(lineChart.Series["20%"], 0.20, 3200);

            //lineChart.Series["100"].Points.AddXY(65, 0.015);
            //lineChart.Series["100"].Points.AddXY(70, 0.017);

            lineChart.Series["20%"].BorderWidth = 1;
            lineChart.Series["20%"].MarkerSize = 8;
            lineChart.Series["20%"].MarkerColor = Color.Gainsboro;

            lineChart.Series["20%"].BorderColor = Color.Gainsboro;

            lineChart.Series["20%"].Color = Color.Gainsboro;

            lineChart.Series["20%"].ChartArea = "Carta";

            lineChart.Series["20%"].ChartType = SeriesChartType.Spline;

           // lineChart.Series["20%"].ToolTip = "#VAL - #VALX";

            lineChart.Series["20%"].IsVisibleInLegend = false;


            /////////////////////////////////////////////////////////////
            ///
            //lineChart.Series.Add("Carta");

            lineChart.Series["Carta"].Points.AddXY(matrizCP[3, 0], matrizCP[3, 1]);
            lineChart.Series["Carta"].Points.AddXY(matrizCP[2, 0], matrizCP[2, 1]);

            lineChart.Series["Carta"].Points[0].Label = "4";
            lineChart.Series["Carta"].Points[1].Label = "3";

            lineChart.Series["Carta"].BorderWidth = 3;
            lineChart.Series["Carta"].MarkerSize = 8;
            lineChart.Series["Carta"].MarkerColor = Color.Red;

            lineChart.Series["Carta"].BorderColor = Color.Red;

            lineChart.Series["Carta"].Color = Color.Red;

            lineChart.Series["Carta"].ChartArea = "Carta";

            lineChart.Series["Carta"].ToolTip = "#VAL - #VALX";

            lineChart.Series["Carta"].IsVisibleInLegend = false;

            /////////////////////////////////////////////////////////////
            ///

            lineChart.Series.Add("Carta1");

            lineChart.Series["Carta1"].Points.AddXY(matrizCP[1, 0], matrizCP[1, 1]);
            lineChart.Series["Carta1"].Points.AddXY(matrizCP[2, 0], matrizCP[2, 1]);

            lineChart.Series["Carta1"].BorderWidth = 3;
            lineChart.Series["Carta1"].MarkerSize = 8;
            lineChart.Series["Carta1"].MarkerColor = Color.Red;

            lineChart.Series["Carta1"].BorderColor = Color.Red;

            lineChart.Series["Carta1"].Color = Color.Red;

            lineChart.Series["Carta1"].IsVisibleInLegend = false;

            lineChart.Series["Carta1"].ChartArea = "Carta";

            lineChart.Series["Carta1"].ToolTip = "#VAL - #VALX";

            lineChart.Series["Carta1"].ChartType = SeriesChartType.Line;

            /////////////////////////////////////////////////////////////
            ///

            lineChart.Series.Add("Carta2");

            lineChart.Series["Carta2"].Points.AddXY(matrizCP[1, 0], matrizCP[1, 1]);
            lineChart.Series["Carta2"].Points.AddXY(matrizCP[0, 0], matrizCP[0, 1]);

            lineChart.Series["Carta2"].Points[0].Label = "2";

            lineChart.Series["Carta2"].Points[1].Label = "1";

            lineChart.Series["Carta2"].BorderWidth = 3;
            lineChart.Series["Carta2"].MarkerSize = 8;
            lineChart.Series["Carta2"].MarkerColor = Color.Red;

            lineChart.Series["Carta2"].BorderColor = Color.Red;

            lineChart.Series["Carta2"].Color = Color.Red;

            lineChart.Series["Carta2"].IsVisibleInLegend = false;

            lineChart.Series["Carta2"].ChartArea = "Carta";

            lineChart.Series["Carta2"].ToolTip = "#VAL - #VALX";

            lineChart.Series["Carta2"].ChartType = SeriesChartType.Line;

            /////////////////////////////////////////////////////////////

            //lineChart.Series["MAH"].YValueMembers = "w";

            //lineChart.Series["MAH"].XValueMember = "dbt";

            lineChart.Series["Carta"].ChartArea = "Carta";

            lineChart.Series["Carta"].ToolTip = "#VAL - #VALX";

            lineChart.ChartAreas[0].Visible = false;

            lineChart.ChartAreas["Carta"].AxisY.Title = "W (Lba/Lbw)";

            lineChart.ChartAreas["Carta"].AxisY.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas["Carta"].AxisX.Title = "TBS (F)";

            lineChart.ChartAreas["Carta"].AxisX.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas["Carta"].Visible = true;

            lineChart.ChartAreas["Carta"].AxisY.Interval = 0.01;

            lineChart.ChartAreas["Carta"].AxisY.Minimum = 0.00;

            lineChart.ChartAreas["Carta"].AxisY.Maximum = 0.10;

            lineChart.ChartAreas["Carta"].AxisX.Minimum = 35;

            lineChart.ChartAreas["Carta"].AxisX.Interval = 10;

            lineChart.ChartAreas["Carta"].AxisX.Maximum = 115;

            //lineChart.ChartAreas["MAH"].AxisX.IsReversed = true;

            lineChart.Series["Carta"].ChartType = SeriesChartType.Line;

            lineChart.ChartAreas["Carta"].AxisX.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.ChartAreas["Carta"].AxisX.MajorGrid.Interval = 10;

            lineChart.ChartAreas["Carta"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.Series["Series1"].IsVisibleInLegend = false;
        }




        public void CargarBaseCPExperimental(double[,] matrizCP)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("dbt"));
            dt.Columns.Add(new DataColumn("w"));
            dt.Columns.Add(new DataColumn("100%"));
            dt.Columns.Add(new DataColumn("wbt"));

            dt.Rows.Add(matrizCP[0, 0], matrizCP[0, 1] , 69 , 0.011);

            dt.Rows.Add(matrizCP[1, 0], matrizCP[1, 1], 87, 0.011);

            Title title = lineChart.Titles.Add("Psychrometric Chart");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            lineChart.ChartAreas.Add("MAH");

            lineChart.Series.Add("MAH");
            lineChart.Series.Add("100%");

            lineChart.DataSource = dt;

            lineChart.Series["MAH"].BorderWidth = 3;
            lineChart.Series["MAH"].MarkerSize = 8;
            lineChart.Series["MAH"].MarkerColor = Color.Blue;

            lineChart.Series["100%"].BorderWidth = 3;
            lineChart.Series["100%"].MarkerSize = 8;
            lineChart.Series["100%"].MarkerColor = Color.Red;
            lineChart.Series["100%"].BorderColor = Color.Red;


            lineChart.Series["MAH"].YValueMembers = "w";

            lineChart.Series["MAH"].XValueMember = "dbt";

            lineChart.Series["100%"].YValueMembers = "wbt";

            lineChart.Series["100%"].XValueMember = "100%";

            lineChart.Series["MAH"].ChartArea = "MAH";

            lineChart.Series["100%"].ChartArea = "MAH";

            lineChart.Series["100%"].IsVisibleInLegend = true;

            lineChart.ChartAreas[0].Visible = false;

            lineChart.ChartAreas["MAH"].Visible = true;

            lineChart.ChartAreas["MAH"].AxisY.Interval = 0.01;

            lineChart.ChartAreas["MAH"].AxisY.Minimum = 0.00;
            lineChart.ChartAreas["MAH"].AxisY.Maximum = 0.03;

            //lineChart.ChartAreas["MAH"].AxisX.Minimum = 35;
            //lineChart.ChartAreas["MAH"].AxisX.Maximum = 115;


            lineChart.ChartAreas["MAH"].AxisX.IsReversed = true;

            lineChart.Series["MAH"].ChartType = SeriesChartType.Line;

            lineChart.Series["100%"].ChartType = SeriesChartType.Spline;

            lineChart.ChartAreas["MAH"].AxisX.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.ChartAreas["MAH"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.Series["Series1"].IsVisibleInLegend = false;

            //Graphics grap;

            //grap = this.CreateGraphics();

            //Rectangle rectangle1 = new Rectangle(50, 50, 200, 100);

            //PaintEventArgs paint = new PaintEventArgs(grap, rectangle1);

            //LineChart_Paint(new object(), paint);

        }

        public void CargarBaseCPTemp(double[,] matrizCP)
        {

            string[] seriesArray = { "Cats", "Dogs" };
            int[] pointsArray = { 1, 2 };

            // Set palette.
            this.lineChart.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.lineChart.Titles.Add("Pets");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.lineChart.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.AddXY(pointsArray[i], pointsArray[i]*6);

                series.ChartType = SeriesChartType.Line;
            }

            MemoryStream stream = new MemoryStream();

            //Saving the chart as image
            this.lineChart.SaveImage(stream,ChartImageFormat.Png);

            Image image = Image.FromStream(stream);

            //image

            //    DataTable dt = new DataTable();            //dt.Columns.Add(new DataColumn("180"));
            //    //dt.Columns.Add(new DataColumn("100%"));
            //    //dt.Columns.Add(new DataColumn("80%"));
            //    //dt.Columns.Add(new DataColumn("60%"));
            //    //dt.Columns.Add(new DataColumn("40%"));
            //    //dt.Columns.Add(new DataColumn("20%"));
            //    //35, 45 , 55, 65, 75, 85 , 95, 105,110,115,120,125,130
            //    dt.Columns.Add(new DataColumn("35"));
            //    dt.Columns.Add(new DataColumn("40"));
            //    dt.Columns.Add(new DataColumn("45"));//EVALUADO 2
            //    dt.Columns.Add(new DataColumn("50"));
            //    dt.Columns.Add(new DataColumn("55"));//EVALUADO 4
            //    dt.Columns.Add(new DataColumn("60"));
            //    dt.Columns.Add(new DataColumn("65"));//EVALUADO 6
            //    dt.Columns.Add(new DataColumn("70"));
            //    dt.Columns.Add(new DataColumn("75"));//EVALUADO 8
            //    dt.Columns.Add(new DataColumn("80"));
            //    dt.Columns.Add(new DataColumn("85"));//EVALUADO 10
            //    dt.Columns.Add(new DataColumn("90"));
            //    dt.Columns.Add(new DataColumn("95"));//EVALUADO 12
            //    dt.Columns.Add(new DataColumn("100"));
            //    dt.Columns.Add(new DataColumn("105"));//EVALUADO 14
            //    dt.Columns.Add(new DataColumn("110"));//EVALUADO 15
            //    dt.Columns.Add(new DataColumn("115"));//EVALUADO 16
            //    dt.Columns.Add(new DataColumn("120"));//EVALUADO 17
            //    dt.Columns.Add(new DataColumn("125"));
            //    dt.Columns.Add(new DataColumn("130"));
            //    dt.Columns.Add(new DataColumn("135"));
            //    dt.Columns.Add(new DataColumn("140"));
            //    dt.Columns.Add(new DataColumn("145"));
            //    dt.Columns.Add(new DataColumn("150"));
            //    dt.Columns.Add(new DataColumn("155"));
            //    dt.Columns.Add(new DataColumn("160"));
            //    dt.Columns.Add(new DataColumn("165"));
            //    dt.Columns.Add(new DataColumn("170"));
            //    dt.Columns.Add(new DataColumn("175"));
            //    dt.Columns.Add(new DataColumn("180"));
            //    dt.Columns.Add(new DataColumn("185"));
            //    dt.Columns.Add(new DataColumn("190"));
            //    dt.Columns.Add(new DataColumn("195"));
            //    dt.Columns.Add(new DataColumn("200"));

            //    for (int row = 0; row < 34; row++)
            //    {
            //        //if (row == 2 || row == 4 || row == 6 || row == 8 || row == 10 || row == 12
            //        //    || row == 14 || row == 15 || row == 16 || row == 17)
            //        lineChart.Series["45"].Points.AddXY(,matrizCP[row, 0])
            //        dt.Rows.Add(matrizCP[row, 0], matrizCP[row, 1], matrizCP[row, 2], matrizCP[row, 3], matrizCP[row, 4]);
            //        //dt.Rows.Add(new DataRow() )
            //        //dt.Rows.Add(matrizCP[row, 0], matrizCP[row, 1], matrizCP[row, 2], matrizCP[row, 3], matrizCP[row, 4],
            //        //    matrizCP[row, 5], matrizCP[row, 6], matrizCP[row, 7], matrizCP[row, 8], matrizCP[row, 9],
            //        //    matrizCP[row, 10], matrizCP[row, 11], matrizCP[row, 12], matrizCP[row, 13], matrizCP[row, 14]
            //        //    , matrizCP[row, 15], matrizCP[row, 16], matrizCP[row, 17], matrizCP[row, 18], matrizCP[row, 19]
            //        //    , matrizCP[row, 20], matrizCP[row, 21], matrizCP[row, 22], matrizCP[row, 23], matrizCP[row, 24]
            //        //    , matrizCP[row, 25], matrizCP[row, 26], matrizCP[row, 27], matrizCP[row, 28], matrizCP[row, 29]
            //        //    , matrizCP[row, 30], matrizCP[row, 31], matrizCP[row, 32], matrizCP[row, 33]);

            //    }

            //    Title title = lineChart.Titles.Add("Psychrometric Chart");
            //    title.Font = new Font("Arial", 12, FontStyle.Bold);

            //    lineChart.Series.Add("45");
            //    lineChart.Series.Add("55");
            //    lineChart.Series.Add("65");
            //    lineChart.Series.Add("75");
            //    lineChart.Series.Add("85");
            //    lineChart.Series.Add("95");
            //    lineChart.Series.Add("105");
            //    lineChart.Series.Add("110");
            //    lineChart.Series.Add("115");
            //    lineChart.Series.Add("120");


            //    lineChart.DataSource = dt;

            //    //lineChart.Series["Series1"].XValueMember = "OSA";

            //    lineChart.Series["45"].BorderWidth = 3;
            //    //lineChart.Series["100%"].MarkerStyle = MarkerStyle.Square;
            //    lineChart.Series["45"].MarkerSize = 8;
            //    lineChart.Series["45"].MarkerColor = Color.Blue;

            //    lineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            //    lineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;


            //    lineChart.Series["45"].BorderColor = Color.Blue;

            //    lineChart.Series["45"].Color = Color.Blue;

            //    lineChart.Series["45"].XValueType = ChartValueType.String;

            //    lineChart.Series["45"].XAxisType = AxisType.Primary;
            //    //lineChart.Series["45"].YValueMembers = "45";
            //    // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //    lineChart.Series["45"].ChartType = SeriesChartType.Line;

            //    //lineChart.Series["100%"].IsVisibleInLegend = false;


            //    //lineChart.Series.Add("Series2");

            //    lineChart.Series["55"].BorderWidth = 3;
            //    lineChart.Series["55"].MarkerSize = 8;
            //    lineChart.Series["55"].MarkerColor = Color.Yellow;

            //    lineChart.Series["55"].BorderColor = Color.Yellow;

            //    lineChart.Series["55"].Color = Color.Yellow;

            //    lineChart.Series["55"].XAxisType = AxisType.Primary;
            //    lineChart.Series["55"].YValueMembers = "55";
            //    // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //    lineChart.Series["55"].ChartType = SeriesChartType.Line;



            //    lineChart.Series["65"].BorderWidth = 3;
            //    lineChart.Series["65"].MarkerSize = 8;
            //    lineChart.Series["65"].MarkerColor = Color.Orange;

            //    lineChart.Series["65"].BorderColor = Color.Orange;

            //    lineChart.Series["65"].Color = Color.Orange;

            //    lineChart.Series["65"].XAxisType = AxisType.Primary;
            //    lineChart.Series["65"].YValueMembers = "65";
            //    // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //    lineChart.Series["65"].ChartType = SeriesChartType.Line;


            //    lineChart.Series["85"].BorderWidth = 3;
            //    lineChart.Series["85"].MarkerSize = 8;
            //    lineChart.Series["85"].MarkerColor = Color.Purple;

            //    lineChart.Series["85"].BorderColor = Color.Purple;

            //    lineChart.Series["85"].Color = Color.Purple;

            //    lineChart.Series["85"].XAxisType = AxisType.Primary;
            //    lineChart.Series["85"].YValueMembers = "85";
            //    // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //    lineChart.Series["85"].ChartType = SeriesChartType.Line;



            //    lineChart.Series["95"].BorderWidth = 3;
            //    lineChart.Series["95"].MarkerSize = 8;
            //    lineChart.Series["95"].MarkerColor = Color.DarkBlue;

            //    lineChart.Series["95"].BorderColor = Color.DarkBlue;

            //    lineChart.Series["95"].Color = Color.DarkBlue;

            //    lineChart.Series["95"].XAxisType = AxisType.Primary;
            //    lineChart.Series["95"].YValueMembers = "95";
            //    // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //    lineChart.Series["95"].ChartType = SeriesChartType.Line;
        }

        public void ParticleConcetration(double[] SeriesPoint)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Horas", typeof(string));
            dt.Columns.Add("Points", typeof(double));

            String[] Horas = { "00:00", "00:01", "00:02", "00:03", "00:04", "00:05", "00:06", "00:07", "00:08", "00:09", "00:10", "00:11", "00:12", "00:13", "00:14", "00:15", "00:16", "00:17", "00:18", "00:19" };

            for (int i = 0; i < Horas.Count(); i++)
            {
                dt.Rows.Add(Horas[i], SeriesPoint[i]);
            }

            lineChart.DataSource = dt;

            Title title = lineChart.Titles.Add("Particle Concetration");
            title.Font = new Font("Arial", 16, FontStyle.Bold);

            lineChart.Series["Series1"].XValueMember = "Horas";

            lineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            lineChart.Series["Series1"].XAxisType = AxisType.Primary;
            lineChart.Series["Series1"].YValueMembers = "Points";
            lineChart.Series["Series1"].ChartType = SeriesChartType.Line;

            lineChart.Series["Series1"].BorderWidth = 4;

            lineChart.Series["Series1"].IsVisibleInLegend = false;

            lineChart.Series["Series1"].BorderColor = Color.GreenYellow;

            lineChart.Series["Series1"].Color = Color.GreenYellow;

            lineChart.Series["Series1"].ToolTip = "#VAL";

            lineChart.ChartAreas[0].AxisY.Title = "Particles / ft³";

            lineChart.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas[0].AxisX.Title = "Times (minutes)";

            lineChart.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12);

            lineChart.ChartAreas[0].AxisX.Interval = 2;

            lineChart.ChartAreas[0].AxisY.Minimum = 5000;
        }

        public void PsychrometricChart()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("OSA", typeof(string));
            dt.Columns.Add("MUA", typeof(double));

            String[] OSA  = { "47", "64" };

            Double[] MUA = { 0.012 , 0.018 };

            for (int i = 0; i < OSA.Count(); i++)
            {
                dt.Rows.Add(OSA[i], MUA[i]);
            }

            Title title = lineChart.Titles.Add("Psychrometric Chart");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            lineChart.DataSource = dt;
            lineChart.Series["Series1"].XValueMember = "OSA";

            lineChart.Series["Series1"].BorderWidth = 3;
            lineChart.Series["Series1"].MarkerStyle = MarkerStyle.Square;
            lineChart.Series["Series1"].MarkerSize = 8;
            lineChart.Series["Series1"].MarkerColor = Color.Blue;

            lineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;


            lineChart.Series["Series1"].BorderColor = Color.Blue;

            lineChart.Series["Series1"].Color = Color.Blue;

            lineChart.Series["Series1"].XAxisType = AxisType.Primary;
            lineChart.Series["Series1"].YValueMembers = "MUA";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["Series1"].ChartType = SeriesChartType.Line;

            lineChart.Series["Series1"].IsVisibleInLegend = false;
        }

        public void PsychrometricChartII()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("OSA", typeof(string));
            dt.Columns.Add("MUA", typeof(double));

            String[] OSA = { "47", "64", "69.18", "70" };

            Double[] MUA = { 0.012, 0.018, 0.019,0.022 };

            for (int i = 0; i < OSA.Count(); i++)
            {
                dt.Rows.Add(OSA[i], MUA[i]);
            }

            Title title = lineChart.Titles.Add("Psychrometric Chart");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            //lineChart.DataSource = dt;

            lineChart.Series.Add("SeriesRAH");
            lineChart.Series.Add("SeriesRE");
            // lineChart.Series["SeriesRAH"].XValueMember = "OSA";


            for (int i = 0; i < OSA.Count(); i++)
            {
                lineChart.Series["SeriesRAH"].Points.AddXY(OSA[i], MUA[i]);
            }

            lineChart.Series["SeriesRAH"].BorderWidth = 3;
            lineChart.Series["SeriesRAH"].MarkerStyle = MarkerStyle.Square;
            lineChart.Series["SeriesRAH"].MarkerSize = 8;
            lineChart.Series["SeriesRAH"].MarkerColor = Color.LimeGreen;

            lineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;


            lineChart.Series["SeriesRAH"].BorderColor = Color.LimeGreen;

            lineChart.Series["SeriesRAH"].Color = Color.LimeGreen;

            lineChart.Series["SeriesRAH"].XAxisType = AxisType.Primary;
            lineChart.Series["SeriesRAH"].YValueMembers = "MUA";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["SeriesRAH"].ChartType = SeriesChartType.Line;

            lineChart.Series["SeriesRAH"].IsVisibleInLegend = false;

            //Series s = new Series("First");
            //s.Points.AddXY("a", 10);
            //s.Points.AddXY("b", 10);
            //s.Points.AddXY("c", 10);
            //chart1.Series.Add(s);
            //Series s2 = new Series("Second");
            //s2.Points.AddXY("c", 30);
            //chart1.Series.Add(s2);

           // lineChart.DataSource = dt;
            //lineChart.Series["SeriesRE"].XValueMember = "OSA";

            String[] OSA2 = { "85", "105" };

            Double[] MUA2 = { 0.013, 0.010 };

            for (int i = 0; i < OSA2.Count(); i++)
            {
                lineChart.Series["SeriesRE"].Points.AddXY(OSA2[i], MUA2[i]);
            }

            lineChart.Series["SeriesRE"].BorderWidth = 3;
            lineChart.Series["SeriesRE"].MarkerStyle = MarkerStyle.Diamond;
            lineChart.Series["SeriesRE"].MarkerSize = 8;
            lineChart.Series["SeriesRE"].MarkerColor = Color.DarkRed;

            lineChart.Series["SeriesRE"].BorderColor = Color.DarkRed;

            lineChart.Series["SeriesRE"].Color = Color.DarkRed;

            lineChart.Series["SeriesRE"].XAxisType = AxisType.Primary;
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            lineChart.Series["SeriesRE"].ChartType = SeriesChartType.Line;

            lineChart.Series["SeriesRE"].IsVisibleInLegend = false;

            lineChart.Series["Series1"].IsVisibleInLegend = false;


        }

        public void Carta()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("OSA", typeof(string));
            dt.Columns.Add("MUA", typeof(double));

            //String[] OSA = { "72" , "80" , "80"};

            //Double[] MUA = { 0.01100 , 0.01100, 0.02000 };

            //for (int i = 0; i < OSA.Count(); i++)
            //{
            //    dt.Rows.Add(OSA[i], MUA[i]);
            //}

            Title title = lineChart.Titles.Add("Carta Psicometrica");
            title.Font = new Font("Arial", 12, FontStyle.Bold);

            Title title2 = lineChart.Titles.Add("Elev = 3200 Ft");
            title2.Font = new Font("Arial", 10, FontStyle.Bold);

            //lineChart.DataSource = dt;

            lineChart.Series.Add("Punto1");
            lineChart.Series.Add("Punto2");
            lineChart.Series.Add("Punto3");
            lineChart.Series.Add("Punto4");

            // lineChart.Series["SeriesRAH"].XValueMember = "OSA";


            //for (int i = 0; i < OSA.Count(); i++)
            //{
            //    lineChart.Series["Punto1"].Points.AddXY(OSA[i], MUA[i]);
            //}


            //lineChart.Series["Punto1"].Points.AddY

            //lineChart.Series["Punto1"].Points.AddXY("72", "0.01100");
            //lineChart.Series["Punto1"].Points.AddXY("80", "0.01100");
            //lineChart.Series["Punto1"].Points.AddXY("80", "0.02000");
            //lineChart.Series["Punto1"].Points.AddXY("72", "0.01800");

            lineChart.Series["Punto1"].IsXValueIndexed = true;

            //lineChart.Series["Punto1"].Points. stepDirection("forward");
            //lineChart.Series.Clear();
            //this.lineChart.Series.Add(series3);

            String[] OSA = { "72", "80", "80" };

            Double[] MUA = { 0.01100, 0.01100, 0.02000 };

            //Adding individual points too does not work
            //series3.Points.AddXY(startPosition, startForceLow);
            //series3.Points.AddXY(startPosition, startForceHigh);
            //series3.Points.AddXY(endPosition, endForceHigh);
            //series3.Points.AddXY(endPosition, endForceLow);
            //series3.Points.AddXY(startPosition, startForceLow);

            lineChart.Series["Punto1"].XValueType = ChartValueType.String;
            lineChart.Series["Punto1"].YValueType = ChartValueType.Double;

            lineChart.Series["Punto1"].Points.DataBindXY(OSA, MUA);

            lineChart.ChartAreas[0].AxisX.IsReversed = true;

            lineChart.Series["Punto1"].ChartType = SeriesChartType.Line;

            // lineChart.Series["Punto1"].BorderWidth = 3;
            // lineChart.Series["Punto1"].MarkerStyle = MarkerStyle.Square;
            // lineChart.Series["Punto1"].MarkerSize = 8;
            // lineChart.Series["Punto1"].MarkerColor = Color.LimeGreen;


            // lineChart.Series["Punto1"].BorderColor = Color.LimeGreen;

            // lineChart.Series["Punto1"].Color = Color.LimeGreen;

            // lineChart.Series["Punto1"].XAxisType = AxisType.Primary;
            // lineChart.Series["Punto1"].YValueMembers = "MUA";
            // lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //  lineChart.Series["Punto1"].ChartType = SeriesChartType.Line;

            lineChart.Series["Punto1"].IsVisibleInLegend = false;

            //String[] OSA2 = {"80" , "80" };

            //Double[] MUA2 = {0.01100 , 0.02000 };

            //for (int i = 0; i < OSA2.Count(); i++)
            //{
            //    lineChart.Series["Punto2"].Points.AddXY(OSA2[i], MUA2[i]);
            //}

            //lineChart.Series["Punto2"].BorderWidth = 3;
            //lineChart.Series["Punto2"].MarkerStyle = MarkerStyle.Diamond;
            //lineChart.Series["Punto2"].MarkerSize = 8;
            //lineChart.Series["Punto2"].MarkerColor = Color.DarkRed;

            //lineChart.Series["Punto2"].BorderColor = Color.DarkRed;

            //lineChart.Series["Punto2"].Color = Color.DarkRed;

            //lineChart.Series["Punto2"].XAxisType = AxisType.Primary;
            //// lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //lineChart.Series["Punto2"].ChartType = SeriesChartType.Line;

            //lineChart.Series["Punto2"].IsVisibleInLegend = false;


            //String[] OSA3 = { "80"};

            //Double[] MUA3 = { 0.02000 };

            //for (int i = 0; i < OSA3.Count(); i++)
            //{
            //    lineChart.Series["Punto3"].Points.AddXY(OSA3[i], MUA3[i]);
            //}

            //lineChart.Series["Punto3"].BorderWidth = 3;
            //lineChart.Series["Punto3"].MarkerStyle = MarkerStyle.Diamond;
            //lineChart.Series["Punto3"].MarkerSize = 8;
            //lineChart.Series["Punto3"].MarkerColor = Color.DarkRed;

            //lineChart.Series["Punto3"].BorderColor = Color.DarkRed;

            //lineChart.Series["Punto3"].Color = Color.DarkRed;

            //lineChart.Series["Punto3"].XAxisType = AxisType.Primary;
            //// lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //lineChart.Series["Punto3"].ChartType = SeriesChartType.Line;

            //lineChart.Series["Punto3"].IsVisibleInLegend = false;


            //String[] OSA4 = { "72" };

            //Double[] MUA4 = { 0.01800 };

            //for (int i = 0; i < OSA4.Count(); i++)
            //{
            //    lineChart.Series["Punto4"].Points.AddXY(OSA4[i], MUA4[i]);
            //}

            //lineChart.Series["Punto4"].BorderWidth = 3;
            //lineChart.Series["Punto4"].MarkerStyle = MarkerStyle.Diamond;
            //lineChart.Series["Punto4"].MarkerSize = 8;
            //lineChart.Series["Punto4"].MarkerColor = Color.DarkRed;

            //lineChart.Series["Punto4"].BorderColor = Color.DarkRed;

            //lineChart.Series["Punto4"].Color = Color.DarkRed;

            //lineChart.Series["Punto4"].XAxisType = AxisType.Primary;
            //// lineChart.Series["Series1"].AxisLabel = "Time(Minutes)";
            //lineChart.Series["Punto4"].ChartType = SeriesChartType.Line;

            //lineChart.Series["Punto4"].IsVisibleInLegend = false;

            lineChart.Series["Series1"].IsVisibleInLegend = false;
        }

        public void CargarLegendas()
        {
            LegendItem item1 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerStyle = MarkerStyle.Square,
                MarkerSize = 15,
                Color = Color.Blue
            };
            item1.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item1.Cells.Add(LegendCellType.Text, "MHA", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item1);

            LegendItem item2 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item2.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item2.Cells.Add(LegendCellType.Text, "45°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item2);

            LegendItem item3 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item3.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item3.Cells.Add(LegendCellType.Text, "55°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item3);

            LegendItem item4 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item4.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item4.Cells.Add(LegendCellType.Text, "65°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item4);

            LegendItem item5 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item5.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item5.Cells.Add(LegendCellType.Text, "75°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item5);

            LegendItem item6 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item6.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item6.Cells.Add(LegendCellType.Text, "85°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item6);

            LegendItem item7 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item7.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item7.Cells.Add(LegendCellType.Text, "95°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item7);

            LegendItem item8 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item8.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item8.Cells.Add(LegendCellType.Text, "105°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item8);

            LegendItem item9 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item9.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item9.Cells.Add(LegendCellType.Text, "110°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item9);

            LegendItem item10 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item10.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item10.Cells.Add(LegendCellType.Text, "115°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item10);

            LegendItem item11 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item11.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item11.Cells.Add(LegendCellType.Text, "120°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item11);

            LegendItem item12 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerSize = 10,
                Color = Color.DarkGreen
            };
            item12.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item12.Cells.Add(LegendCellType.Text, "100%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item12);

            LegendItem item13 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerSize = 5,
                Color = Color.LightSkyBlue
            };
            item13.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item13.Cells.Add(LegendCellType.Text, "80%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item13);

            LegendItem item14 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.LightSkyBlue
            };
            item14.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item14.Cells.Add(LegendCellType.Text, "60%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item14);

            LegendItem item15 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.LightSkyBlue
            };
            item15.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item15.Cells.Add(LegendCellType.Text, "40%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item15);

            LegendItem item16 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.LightSkyBlue
            };
            item16.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item16.Cells.Add(LegendCellType.Text, "20%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item16);
        }

        public void CargarLegendas2()
        {
            LegendItem item1 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerStyle = MarkerStyle.Square,
                MarkerSize = 15,
                MarkerBorderWidth = 0,
                Color = Color.LimeGreen
            };
            item1.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item1.Cells.Add(LegendCellType.Text, "RAH", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item1);

            LegendItem item17 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerStyle = MarkerStyle.Diamond,
                MarkerSize = 15,
                MarkerBorderWidth = 0,
                Color = Color.DarkRed
            };
            item17.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item17.Cells.Add(LegendCellType.Text, "Re-", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item17);

            LegendItem item18 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerBorderWidth = 0,
                Color = Color.LightGray
            };
            item18.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item18.Cells.Add(LegendCellType.Text, "Heaters", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item18);

            LegendItem item2 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item2.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item2.Cells.Add(LegendCellType.Text, "45°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item2);

            LegendItem item3 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item3.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item3.Cells.Add(LegendCellType.Text, "55°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item3);

            LegendItem item4 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item4.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item4.Cells.Add(LegendCellType.Text, "65°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item4);

            LegendItem item5 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item5.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item5.Cells.Add(LegendCellType.Text, "75°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item5);

            LegendItem item6 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item6.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item6.Cells.Add(LegendCellType.Text, "85°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item6);

            LegendItem item7 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item7.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item7.Cells.Add(LegendCellType.Text, "95°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item7);

            LegendItem item8 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item8.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item8.Cells.Add(LegendCellType.Text, "105°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item8);

            LegendItem item9 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item9.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item9.Cells.Add(LegendCellType.Text, "110°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item9);

            LegendItem item10 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item10.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item10.Cells.Add(LegendCellType.Text, "115°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item10);

            LegendItem item11 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.DarkGray
            };
            item11.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item11.Cells.Add(LegendCellType.Text, "120°F wbT", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item11);

            LegendItem item12 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerSize = 10,
                Color = Color.DarkGreen
            };
            item12.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item12.Cells.Add(LegendCellType.Text, "100%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item12);

            LegendItem item13 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                MarkerSize = 5,
                Color = Color.LightSkyBlue
            };
            item13.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item13.Cells.Add(LegendCellType.Text, "80%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item13);

            LegendItem item14 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.LightSkyBlue
            };
            item14.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item14.Cells.Add(LegendCellType.Text, "60%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item14);

            LegendItem item15 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.LightSkyBlue
            };
            item15.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item15.Cells.Add(LegendCellType.Text, "40%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item15);

            LegendItem item16 = new LegendItem
            {
                ImageStyle = LegendImageStyle.Line,
                Color = Color.LightSkyBlue
            };
            item16.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter);
            item16.Cells.Add(LegendCellType.Text, "20%", ContentAlignment.MiddleLeft);
            lineChart.Legends[0].CustomItems.Add(item16);
        }

        //    ChartControl chartControl1 = new ChartControl();

        //    // Create two series. 
        //    Series series1 = new Series("Series 1", ViewType.Bar);
        //    Series series2 = new Series("Series 2", ViewType.Line);

        //    // Add points to them, with their arguments different. 
        //    series1.Points.Add(new SeriesPoint("A", 10));
        //series1.Points.Add(new SeriesPoint("B", 12));
        //series1.Points.Add(new SeriesPoint("C", 17));
        //series1.Points.Add(new SeriesPoint("D", 14));
        //series2.Points.Add(new SeriesPoint("I", 1500));
        //series2.Points.Add(new SeriesPoint("II", 1800));
        //series2.Points.Add(new SeriesPoint("III", 2500));
        //series2.Points.Add(new SeriesPoint("IV", 3300));

        //// Add both series to the chart. 
        //chartControl1.Series.AddRange(new Series[] { series1, series2
        //});

        //// Hide the legend (optional). 
        //chartControl1.Legend.Visible = false;

        //// Create two secondary axes, and add them to the chart's Diagram. 
        //SecondaryAxisX myAxisX = new SecondaryAxisX("my X-Axis");
        //SecondaryAxisY myAxisY = new SecondaryAxisY("my Y-Axis");

        //((XYDiagram) chartControl1.Diagram).SecondaryAxesX.Add(myAxisX);
        //((XYDiagram) chartControl1.Diagram).SecondaryAxesY.Add(myAxisY);

        //// Assign the series2 to the created axes. 
        //((LineSeriesView) series2.View).AxisX = myAxisX;
        //((LineSeriesView) series2.View).AxisY = myAxisY;

        //// Customize the appearance of the secondary axes (optional). 
        //myAxisX.Title.Text = "A Secondary X-Axis";
        //myAxisX.Title.Visible = true;
        //myAxisX.Title.TextColor = Color.Red;
        //myAxisX.Label.TextColor = Color.Red;
        //myAxisX.Color = Color.Red;

        //myAxisY.Title.Text = "A Secondary Y-Axis";
        //myAxisY.Title.Visible = true;
        //myAxisY.Title.TextColor = Color.Blue;
        //myAxisY.Label.TextColor = Color.Blue;
        //myAxisY.Color = Color.Blue;

        //// Add the chart to the form. 
        //chartControl1.Dock = DockStyle.Fill;
        //this.Controls.Add(chartControl1);

        public void CalcularGraficaPsico(Series series , double porcentage ,  double elevation)
        {
            double[] Horas = { 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 , 85, 90, 95,
                100, 105, 110, 115, 120, 125 , 130, 135, 140, 145, 150,155,160, 165
            , 170, 175, 180, 185, 190, 195, 200};

            for (int i = 0; i < Horas.Count(); i++)
            {
                //.Rows.Add(Horas[i], );
                series.Points.AddXY(Horas[i], Utilities.Formulas.HUMRATHR(Horas[i], porcentage, elevation));
            }
        }

        public string GuardarReporte()
        {
            MemoryStream stream = new MemoryStream();

            //Saving the chart as image
            lineChart.SaveImage(stream, ChartImageFormat.Png);

            // frm_Grafico grafico = new frm_Grafico(4, CargarMUP(), Elevation);

            Image image = Image.FromStream(stream);

            String path = "C:\\Referencias\\Imagenes\\";

            String myUniqueFileName = string.Format(@"{0}.jpg", DateTime.Now.Ticks);

            if (File.Exists(path + myUniqueFileName))
            {
                File.Delete(path + myUniqueFileName);
            }

            FileStream file = new FileStream(path + myUniqueFileName, FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
            stream.Close();

            return path + myUniqueFileName;
        }
    }
}
