using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Ingenya.ApiCore;
using Ingenya.Entities;
using System.Linq;
using Ingenya.Utilities;
using System.Drawing;

namespace Ingenya
{
    public partial class frm_CreaProyecto : MaterialSkin.Controls.MaterialForm
    {
        //Valores Generales
        double DryBulbA;
        double Relative;
        double Elevation;
        double WetBulbA;
        double HumityRadioA;
        double DryBulbB;
        double WetBuilB;
        double HumityRadioB;
        double LenghtM;
        double WidthM;
        double FloorAreaM;
        double AvgCeilingM;
        double WallAreaM;
        double VolumeM;
        double VolumeE;

        double OutsideTempRoof;
        double InsideTempRoof;
        double FloorAreaE;
        double TempDiffRoof;
        double UFactorRoof;
        double RoofArea;

        double OutsideTempWall;
        double InsideTempWall;
        double TempDiffWall;
        double UFactorWall;
        double WallArea;
        double OutsideTempFloor;
        double InsideTempFloor;
        double TempDiffFloor;
        double UFactorFloor;
        double FloorArea;

        double HeatGainRoof;
        double HeatGainWall;
        double HeatGainFloor;
        double SubtotalFloor;
        double LightDensity;
        double FloorAreaLight;

        double SeatedRest;
        double SeatedLight;
        double OfficeWork;
        double Standing;
        double Waking;
        double ModerateWork;
        double LightBench;
        double ModerateDancing;
        double FastWaking;
        double HevyWork;

        double SeatedRestP;
        double SeatedLightP;
        double OfficeWorkP;
        double StandingP;
        double WakingP;
        double ModerateWorkP;
        double LightBenchP;
        double ModerateDancingP;
        double FastWakingP;
        double HevyWorkP;
        double TotalPercentage;
        double TotalSensibleHeat;
        double SubtotalPeoGain;
        double HeadcountD;

        double InsideTemp;
        double FloorAreaEquip;

        double GainWRF;
        double HeatGainLight;
        double HeatGainPeople;
        double GainEquip;

        double TotalSensibleHeatKW;

        double HeadcountE;
        double Seated;
        double SeatedVeLight;
        double OffWork;
        double LabWork;
        double WalkSea;
        double ModWork;
        double LigBenWork;
        double ModDance;
        double FastWalk;
        double HeaWork;

        double SeatedP;
        double SeatedVeLightP;
        double OffWorkP;
        double LabWorkP;
        double WalkSeaP;
        double ModWorkP;
        double LigBenWorkP;
        double ModDanceP;
        double FastWalkP;
        double HeaWorkP;

        double TotalLatentHeatP;
        double TotalLatentHeat;
        double SubtotalLatHeat;

        double HumityRadioGRB;
        double HumityRadioGRA;

        double HumDiff;
        double VolumeLate;
        double HumityFact;
        double VolumeFact;
        double ConstructionFact;
        double VaporFact;
        double HumGainGR;
        double HumGainLB;
        double VapoHeat;
        double SubtotalHumidity;
        double HeatGaPeople;
        double HumHeatGain;
        double TotalLatentHeatKW;

        //Valores Outside Air
        double DesignDiffWG;
        double LeakArea;
        double LeakLeakArea;
        double LeakLoss;

        double RegularArea;
        double RegularLeak;
        double RegularLoss;

        double AverageArea;
        double AverageLeak;
        double AverageLoss;

        double GoodArea;
        double GoodLeak;
        double GoodLoss;

        double TightArea;
        double TightLeak;
        double TightLoss;

        double LeakFlow;
        double RegularFlow;
        double AverageFlow;
        double GoodFlow;
        double TightFlow;

        double Qty1;
        double LeakA1;
        double Loss1;

        double Qty2;
        double LeakA2;
        double Loss2;

        double Qty3;
        double LeakA3;
        double Loss3;

        double Qty4;
        double LeakA4;
        double Loss4;

        double Qty5;
        double LeakA5;
        double Loss5;

        double Flow1;
        double Flow2;
        double Flow3;
        double Flow4;
        double Flow5;

        double ProcessExhaust;
        double LeaksDueBuilding;
        double LeaksDueDoors;
        double GeneralExhaust;

        double VentHeadCount;
        double UnitaryVentReq;
        double VentilationReq;
        double OSATotal;

        //Valores Particle Concentration
        double AvgCeilingE;
        double WidthE;
        double LenghtE;

        double EnviHeight;
        double EnviWidth;
        double EnviLenght;

        double Motionless;
        double HeadArm;
        double FoodMotion;
        double StandSit;
        double Walk20;
        double Walk35;
        double Walk50;

        double MotionlessP;
        double HeadArmP;
        double FoodMotionP;
        double StandSitP;
        double Walk20P;
        double Walk35P;
        double Walk50P;
        double WeiAverageP;

        double HeadCountOccu;
        double WeiAverage;
        double PartGenDueOccu;
        double PartGenDueBuild;
        double PartGenDueMfg;
        double EnviVolume;
        double AirChange;

        double AirFlow;
        double AirFilter;
        double TotalPartGenDue;
        double AirDistVentilation;

        double PartConBeg1;
        double PartCount1;
        double PartGen1;
        double PartIncome1;
        double PartGoing1;
        double PartCountEnd1;
        double PartConEndPer1;

        double PartConBeg2;
        double PartCount2;
        double PartGen2;
        double PartIncome2;
        double PartGoing2;
        double PartCountEnd2;
        double PartConEndPer2;

        double PartConBeg3;
        double PartCount3;
        double PartGen3;
        double PartIncome3;
        double PartGoing3;
        double PartCountEnd3;
        double PartConEndPer3;

        double PartConBeg4;
        double PartCount4;
        double PartGen4;
        double PartIncome4;
        double PartGoing4;
        double PartCountEnd4;
        double PartConEndPer4;

        double PartConBeg5;
        double PartCount5;
        double PartGen5;
        double PartIncome5;
        double PartGoing5;
        double PartCountEnd5;
        double PartConEndPer5;

        double PartConBeg6;
        double PartCount6;
        double PartGen6;
        double PartIncome6;
        double PartGoing6;
        double PartCountEnd6;
        double PartConEndPer6;

        double PartConBeg7;
        double PartCount7;
        double PartGen7;
        double PartIncome7;
        double PartGoing7;
        double PartCountEnd7;
        double PartConEndPer7;

        double PartConBeg8;
        double PartCount8;
        double PartGen8;
        double PartIncome8;
        double PartGoing8;
        double PartCountEnd8;
        double PartConEndPer8;

        double PartConBeg9;
        double PartCount9;
        double PartGen9;
        double PartIncome9;
        double PartGoing9;
        double PartCountEnd9;
        double PartConEndPer9;

        double PartConBeg10;
        double PartCount10;
        double PartGen10;
        double PartIncome10;
        double PartGoing10;
        double PartCountEnd10;
        double PartConEndPer10;

        double PartConBeg11;
        double PartCount11;
        double PartGen11;
        double PartIncome11;
        double PartGoing11;
        double PartCountEnd11;
        double PartConEndPer11;

        double PartConBeg12;
        double PartCount12;
        double PartGen12;
        double PartIncome12;
        double PartGoing12;
        double PartCountEnd12;
        double PartConEndPer12;

        double PartConBeg13;
        double PartCount13;
        double PartGen13;
        double PartIncome13;
        double PartGoing13;
        double PartCountEnd13;
        double PartConEndPer13;

        double PartConBeg14;
        double PartCount14;
        double PartGen14;
        double PartIncome14;
        double PartGoing14;
        double PartCountEnd14;
        double PartConEndPer14;

        double PartConBeg15;
        double PartCount15;
        double PartGen15;
        double PartIncome15;
        double PartGoing15;
        double PartCountEnd15;
        double PartConEndPer15;

        double PartConBeg16;
        double PartCount16;
        double PartGen16;
        double PartIncome16;
        double PartGoing16;
        double PartCountEnd16;
        double PartConEndPer16;

        double PartConBeg17;
        double PartCount17;
        double PartGen17;
        double PartIncome17;
        double PartGoing17;
        double PartCountEnd17;
        double PartConEndPer17;

        double PartConBeg18;
        double PartCount18;
        double PartGen18;
        double PartIncome18;
        double PartGoing18;
        double PartCountEnd18;
        double PartConEndPer18;

        double PartConBeg19;
        double PartCount19;
        double PartGen19;
        double PartIncome19;
        double PartGoing19;
        double PartCountEnd19;
        double PartConEndPer19;

        double PartConBeg20;
        double PartCount20;
        double PartGen20;
        double PartIncome20;
        double PartGoing20;
        double PartCountEnd20;
        double PartConEndPer20;
        string nombreAvgParticle;

        double AirDistMax;
        double AvgPartConc;

        double OSADBT;
        double OSAWBT;
        double OSAFlow;
        double OSADensity;
        double PCCDBT;
        double PCCWBT;
        double OSAEnthalpy;
        double PCCEnthalpy;
        double EnthalpyDiff;
        double TotalMAHCool;
        double OSAMass;
        double EnthalDiffMAH;
        double MAHSensibleCooling;
        double MAHLatentCooling;
        double OSAHumidity;
        double PCCHumidity;
        double PCC2DBT;
        double PCC2WBT;
        double PCC2Flow;
        double PCC2Density;
        double CCDBT;
        double CCWBT;
        double PCC2Enthalpy;
        double CCEnthalpy;
        double CCEnthalpyDiff;
        double PCC2Mass;
        double CCTotalCooling;
        double CCSensEnthalpyDiff;
        double CCSensCoolCap;
        double CCLatCoolCap;
        double PCC2Humidity;
        double CCHumidity;
        double CC2DBT;
        double CC2WBT;
        double CC2Flow;
        double CC2Density;
        double HCDBT;
        double HCHumidity;
        double MUHElevation;
        double HCWBT;
        double CC2Humidity;
        double CC2Enthalpy;
        double HCEnthalpy;
        double HCEntDiff;
        double CC2Mass;
        double HCCooling;
        double HCEnthDifference;
        double HCSensiCool;
        double HCLatentCool;
        double WallAreaE;

        double RAHDBT;
        double RAHHumidity;
        double RAHElevation;
        double RAHWBT;
        double RAHFlow;
        double RAHDBTR;
        double RAHRHR;
        double RAHWBTR;
        double RAHFlowR;
        double MAFlow;
        double MADBT;
        double MAWBT;
        double MADensity;
        double TotalLatentHeatBTU;
        double RAHEthalpyR;
        double MAInternalLat;
        double MAMass;
        double MACCEntalphy;
        double MACCHumidity;
        double MACCDew;
        double TotalSensibleHeatBTU;
        double MACCInternal;
        double MACCEntDecrease;
        double MACCReqDryBulb;
        double MADew;
        double MACCResDewPoint;
        double MACCHumRatio;
        double MACCDry;
        double RAHCCDBT;
        double RAHCCDPT;
        double RACCCWBT;
        double MAHumidity;
        double RACCCHumidity;
        double MAEnthalpy;
        double RAHTotalEnthalpyDiff;
        double TotalRAHCool;
        double RAHCCEnthalpy;
        double RAHSenCoolEnthDiff;
        double RAHSenCoolCap;
        double RAHLatCoolCap;
        double HeatingPower;
        double ElectricalPow;
        double RAHeHDBT;
        double RAHeHumRat;

        double valRAHDBT;
        double valRAHDPT;
        double ReHeatersQ;

        double MUP_DBT1;
        double MUP_DBT2;

        double MUP_W1;
        double MUP_W2;

        double MUC_DBT1;
        double MUC_DBT2;

        double MUC_W1;
        double MUC_W2;

        double RAH_DBT1;
        double RAH_W1;

        double RAH_DBT2;
        double RAH_W2;

        double CP_Dbt1;
        double CP_W1;

        double CP_Dbt2;
        double CP_W2;

        double CP_Dbt3;
        double CP_W3;

        double CP_Dbt4;
        double CP_W4;

        double RAH_DBT3;
        double RAH_W3;

        double RAH_DBT4;
        double RAH_W4;

        double MUH_DBT1;
        double MUH_DBT2;

        double MUH_W1;
        double MUH_W2;

        // REH

        double ReH_DBT1;
        double ReH_W1;

        double ReH_DBT2;
        double ReH_W2;

        double[,] matrizCP;

        double[,] matrizMUC;

        double[,] matrizRAH;

        double[,] matrizCarta;

        double[,] matrizCompletaCP;

        EventArgs ea;
        ToolTip toolTipVentilation;
        ToolTip toolTipMAxFactor;
        ToolTip toolTipRecovery;
        KeyEventArgs Key;

        TabActiva tabActiva;

        TabActivaGeneralInfo tabActivaGeneralInfo;

        Boolean Guardar = true;


        List<ProyectoParametro> listaCargada;

        List<ConcentracionParticula> listaPC;

        List<Fuga> listaFuga;

        ProyectoRoom gProyectoRoom;

        Dictionary<string, Int32> tabsVisitadas;


        public frm_CreaProyecto(ProyectoRoom proyectoRoom, string Proyecto, string Room)
        {
            Cursor.Current = Cursors.WaitCursor;

            tabsVisitadas = new Dictionary<string, int>();
            tabsVisitadas.Add("General_Information", 1);
            tabsVisitadas.Add("Outside_Air", 0);
            tabsVisitadas.Add("Particle_Concentration", 0);
            tabsVisitadas.Add("Make_Up_Precooling", 0);
            tabsVisitadas.Add("Make_Up_Cooling", 0);
            tabsVisitadas.Add("Make_Up_Heating", 0);
            tabsVisitadas.Add("Recirculating_Air_Handler", 0);
            tabsVisitadas.Add("Carta", 0);
            tabsVisitadas.Add("Design", 1);
            tabsVisitadas.Add("LHL", 0);
            tabsVisitadas.Add("SHL", 0);
            tabsVisitadas.Add("PC", 1);
            tabsVisitadas.Add("Graphic", 0);



            InitializeComponent();


            Size size = new Size(1000, 800);
            this.Size = size;

            gProyectoRoom = proyectoRoom;

            txt_Project.Text = Proyecto;

            txt_Room.Text = Room;

            this.Text = Proyecto + " - " + Room;

            ea = new EventArgs();

            Key = new KeyEventArgs(Keys.Enter);

            toolTipVentilation = new ToolTip();

            toolTipMAxFactor = new ToolTip();

            toolTipRecovery = new ToolTip();

            ProyectoParametroManagement proyectoParametroManagement = new ProyectoParametroManagement();

            ProyectoParametro proyectoParametro = new ProyectoParametro
            {
                ObjProyectoRoom = proyectoRoom
            };

            try
            {
                listaCargada = (List<ProyectoParametro>)proyectoParametroManagement.RetriveParametrosByProyRoom(proyectoParametro);
            }
            catch (Exception)
            {

                throw;
            }

            ConcentracionParticulaManagement concentracionParticulaManagement = new ConcentracionParticulaManagement();

            ConcentracionParticula concentracionParticula = new ConcentracionParticula
            {
                ObjProyectoRoom = proyectoRoom
            };

            listaPC = (List<ConcentracionParticula>)concentracionParticulaManagement.RetriveByProRoomStatement(concentracionParticula);


            tabActiva = Utilities.TabActiva.TabGeneralInformation;

            tabActivaGeneralInfo = Utilities.TabActivaGeneralInfo.TabDesignCond;

            CargarTodosTabs();

            //CargarFuga(proyectoRoom);

            //CargarVariables();

            //CargarGeneralInfo();

            CargarDesignCond();

            CargarInternalSHL();

            CargarInternalLHL();

            CargarFuga();

            CargarOutsideAir();

            ParticleConcentration();

            MakeUpPrecooling();

            MakeUpPrecoolingGraphic();

            MakeUpCooling();

            MakeUpCoolingGraphic();

            MakeUpHeating();

            MakeUpHeatingGraphic();

            RecirculatingAirHandler();

            RecirculatingAirHandlerGraphicTab();

            Cursor.Current = Cursors.Default;

        }

        public void LlamarListaFugaDB()
        {
            FugaManagement fugaManagement = new FugaManagement();

            Fuga fuga = new Fuga
            {
                ObjProyectoRoom = gProyectoRoom
            };

            try
            {
                listaFuga = (List<Fuga>)fugaManagement.RetrieveAllFugaByProyecto(fuga);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarFuga()
        {
            LlamarListaFugaDB();

            foreach (var item in listaFuga)
            {
                if (item.ObjNombreParametro.IdNombreParametro == 88)//Leakiest
                {
                    txt_LeakArea.Text = item.Cantidad.ToString("#0.########");
                    txt_LeakArea.Tag = item.IdFuga.ToString();
                    txt_LeakLeakArea.Text = item.Area.ToString("#0.########");
                    txt_LeakLeakArea.Tag = item.IdFuga.ToString();
                    txt_LeakLoss.Text = item.Factor.ToString("#0.########");
                    txt_LeakLoss.Tag = item.IdFuga.ToString();
                    txt_LeakFlow.Text = item.Flow.ToString("#0.########");
                    txt_LeakFlow.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 89)//Regular
                {
                    txt_RegularArea.Text = item.Cantidad.ToString("#0.########");
                    txt_RegularArea.Tag = item.IdFuga.ToString();
                    txt_RegularLeak.Text = item.Area.ToString("#0.########");
                    txt_RegularLeak.Tag = item.IdFuga.ToString();
                    txt_RegularLoss.Text = item.Factor.ToString("#0.########");
                    txt_RegularLoss.Tag = item.IdFuga.ToString();
                    txt_RegularFlow.Text = item.Flow.ToString("#0.########");
                    txt_RegularFlow.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 90)//Average
                {
                    txt_AverageArea.Text = item.Cantidad.ToString("#0.########");
                    txt_AverageArea.Tag = item.IdFuga.ToString();
                    txt_AverageLeak.Text = item.Area.ToString("#0.########");
                    txt_AverageLeak.Tag = item.IdFuga.ToString();
                    txt_AverageLoss.Text = item.Factor.ToString("#0.########");
                    txt_AverageLoss.Tag = item.IdFuga.ToString();
                    txt_AverageFlow.Text = item.Flow.ToString("#0.########");
                    txt_AverageFlow.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 91)//Good
                {
                    txt_GoodArea.Text = item.Cantidad.ToString("#0.########");
                    txt_GoodArea.Tag = item.IdFuga.ToString();
                    txt_GoodLeak.Text = item.Area.ToString("#0.########");
                    txt_GoodLeak.Tag = item.IdFuga.ToString();
                    txt_GoodLoss.Text = item.Factor.ToString("#0.########");
                    txt_GoodLoss.Tag = item.IdFuga.ToString();
                    txt_GoodFlow.Text = item.Flow.ToString("#0.########");
                    txt_GoodFlow.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 92)//Tightest
                {
                    txt_TightArea.Text = item.Cantidad.ToString("#0.########");
                    txt_TightArea.Tag = item.IdFuga.ToString();
                    txt_TightLeak.Text = item.Area.ToString("#0.########");
                    txt_TightLeak.Tag = item.IdFuga.ToString();
                    txt_TightLoss.Text = item.Factor.ToString("#0.########");
                    txt_TightLoss.Tag = item.IdFuga.ToString();
                    txt_TightFlow.Text = item.Flow.ToString("#0.########");
                    txt_TightFlow.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 94)//Qty1
                {
                    txt_Qty1.Text = item.Cantidad.ToString("#0.########");
                    txt_Qty1.Tag = item.IdFuga.ToString();
                    txt_LeakA1.Text = item.Area.ToString("#0.########");
                    txt_LeakA1.Tag = item.IdFuga.ToString();
                    txt_Loss1.Text = item.Factor.ToString("#0.########");
                    txt_Loss1.Tag = item.IdFuga.ToString();
                    txt_Flow1.Text = item.Flow.ToString("#0.########");
                    txt_Flow1.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 95)//Qty2
                {
                    txt_Qty2.Text = item.Cantidad.ToString("#0.########");
                    txt_Qty2.Tag = item.IdFuga.ToString();
                    txt_LeakA2.Text = item.Area.ToString("#0.########");
                    txt_LeakA2.Tag = item.IdFuga.ToString();
                    txt_Loss2.Text = item.Factor.ToString("#0.########");
                    txt_Loss2.Tag = item.IdFuga.ToString();
                    txt_Flow2.Text = item.Flow.ToString("#0.########");
                    txt_Flow2.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 96)//Qty3
                {
                    txt_Qty3.Text = item.Cantidad.ToString("#0.########");
                    txt_Qty3.Tag = item.IdFuga.ToString();
                    txt_LeakA3.Text = item.Area.ToString("#0.########");
                    txt_LeakA3.Tag = item.IdFuga.ToString();
                    txt_Loss3.Text = item.Factor.ToString("#0.########");
                    txt_Loss3.Tag = item.IdFuga.ToString();
                    txt_Flow3.Text = item.Flow.ToString("#0.########");
                    txt_Flow3.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 97)//Qty4
                {
                    txt_Qty4.Text = item.Cantidad.ToString("#0.########");
                    txt_Qty4.Tag = item.IdFuga.ToString();
                    txt_LeakA4.Text = item.Area.ToString("#0.########");
                    txt_LeakA4.Tag = item.IdFuga.ToString();
                    txt_Loss4.Text = item.Factor.ToString("#0.########");
                    txt_Loss4.Tag = item.IdFuga.ToString();
                    txt_Flow4.Text = item.Flow.ToString("#0.########");
                    txt_Flow4.Tag = item.IdFuga.ToString();
                }
                else if (item.ObjNombreParametro.IdNombreParametro == 98)//Qty5
                {
                    txt_Qty5.Text = item.Cantidad.ToString("#0.########");
                    txt_Qty5.Tag = item.IdFuga.ToString();
                    txt_LeakA5.Text = item.Area.ToString("#0.########");
                    txt_LeakA5.Tag = item.IdFuga.ToString();
                    txt_Loss5.Text = item.Factor.ToString("#0.########");
                    txt_Loss5.Tag = item.IdFuga.ToString();
                    txt_Flow5.Text = item.Flow.ToString("#0.########");
                    txt_Flow5.Tag = item.IdFuga.ToString();
                }
            }
        }

        public void GuardarValorFuga(string valor, string ID, string nombre)
        {
            if (Guardar)
            {
                FugaManagement fugaManagement = new FugaManagement();

                Fuga fuga = new Fuga();

                var parametrosFuga = listaFuga.Where(x => x.IdFuga == Int32.Parse(ID)).FirstOrDefault();

                if (nombre.Equals("txt_LeakArea") || nombre.Equals("txt_RegularArea") || nombre.Equals("txt_AverageArea") || nombre.Equals("txt_GoodArea") || nombre.Equals("txt_TightArea") ||
                    nombre.Equals("txt_Qty1") || nombre.Equals("txt_Qty2") || nombre.Equals("txt_Qty3") || nombre.Equals("txt_Qty4") || nombre.Equals("txt_Qty5"))
                {
                    fuga.Cantidad = Double.Parse(valor);
                    fuga.Area = parametrosFuga.Area;
                    fuga.Factor = parametrosFuga.Factor;
                    fuga.Flow = parametrosFuga.Flow;
                }
                else if (nombre.Equals("txt_LeakLeakArea") || nombre.Equals("txt_RegularLeak") || nombre.Equals("txt_AverageLeak") || nombre.Equals("txt_GoodLeak") || nombre.Equals("txt_TightLeak") ||
                        nombre.Equals("txt_LeakA1") || nombre.Equals("txt_LeakA2") || nombre.Equals("txt_LeakA3") || nombre.Equals("txt_LeakA4") || nombre.Equals("txt_LeakA5"))
                {
                    fuga.Cantidad = parametrosFuga.Cantidad;
                    fuga.Area = Double.Parse(valor);
                    fuga.Factor = parametrosFuga.Factor;
                    fuga.Flow = parametrosFuga.Flow;
                }
                else if (nombre.Equals("txt_LeakLoss") || nombre.Equals("txt_RegularLoss") || nombre.Equals("txt_AverageLoss") || nombre.Equals("txt_GoodLoss") || nombre.Equals("txt_TightLoss") ||
                    nombre.Equals("txt_Loss1") || nombre.Equals("txt_Loss2") || nombre.Equals("txt_Loss3") || nombre.Equals("txt_Loss4") || nombre.Equals("txt_Loss5"))
                {
                    fuga.Cantidad = parametrosFuga.Cantidad;
                    fuga.Area = parametrosFuga.Area;
                    fuga.Factor = Double.Parse(valor);
                    fuga.Flow = parametrosFuga.Flow;
                }
                else if (nombre.Equals("txt_LeakFlow") || nombre.Equals("txt_RegularFlow") || nombre.Equals("txt_AverageFlow") || nombre.Equals("txt_GoodFlow") || nombre.Equals("txt_TightFlow") ||
                    nombre.Equals("txt_Flow1") || nombre.Equals("txt_Flow2") || nombre.Equals("txt_Flow3") || nombre.Equals("txt_Flow4") || nombre.Equals("txt_Flow5"))
                {
                    fuga.Cantidad = parametrosFuga.Cantidad;
                    fuga.Area = parametrosFuga.Area;
                    fuga.Factor = parametrosFuga.Factor;
                    fuga.Flow = Double.Parse(valor);
                }

                fuga.IdFuga = Int32.Parse(ID);
                fuga.ObjNombreParametro = parametrosFuga.ObjNombreParametro;
                fuga.ObjProyectoRoom = parametrosFuga.ObjProyectoRoom;

                try
                {
                    fugaManagement.UpdateFuga(fuga);
                }
                catch (Exception)
                {

                    throw;
                }

                LlamarListaFugaDB();

            }
        }

        public void CargarInfoCartaPsicometricaPorcentaje(double Elevation)
        {
            double[] listaPorcentajes = new double[] { 100, 80, 60, 40, 20 };

            matrizCP = new double[34, 5];

            int contadorColumnas = 0;

            foreach (var item in listaPorcentajes)
            {
                int contadorFilas = 0;

                for (int contadorDBT = 35; contadorDBT <= 200; contadorDBT += 5)
                {
                    matrizCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRATHR(contadorDBT, item, Elevation);

                    contadorFilas++;
                }

                contadorColumnas++;
            }
        }

        public void CargarInfoCartaPsicometricaTemp(double Elevation)
        {
            double[] listaTemperaturas = new double[] { 35, 45, 55, 65, 75, 85, 95, 105, 110, 115, 120, 125, 130 };

            matrizCompletaCP = new double[34, 13];

            int contadorColumnas = 0;

            foreach (var item in listaTemperaturas)
            {
                int contadorFilas = 0;

                for (double contadorDBT = 35; contadorDBT <= 200; contadorDBT += 5)
                {
                    if (item == 35)
                    {
                        if (contadorDBT >= 35 && contadorDBT <= 50)
                            matrizCompletaCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRAT(contadorDBT, item, Elevation);
                    }
                    else if (item == 45)
                    {
                        if ((contadorDBT >= 45) && (contadorDBT <= 70))
                            matrizCompletaCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRAT(contadorDBT, item, Elevation);
                    }
                    else if (item == 55)
                    {
                        if ((contadorDBT >= 55) && (contadorDBT <= 95))
                            matrizCompletaCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRAT(contadorDBT, item, Elevation);
                    }
                    else if (item == 65)
                    {
                        if ((contadorDBT >= 65) && (contadorDBT <= 130))
                            matrizCompletaCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRAT(contadorDBT, item, Elevation);
                    }
                    else if (item == 75)
                    {
                        if ((contadorDBT >= 75) && (contadorDBT <= 165))
                            matrizCompletaCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRAT(contadorDBT, item, Elevation);
                    }
                    else if (item == 85)
                    {
                        if ((contadorDBT >= 85) && (contadorDBT <= 200))
                            matrizCompletaCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRAT(contadorDBT, item, Elevation);
                    }
                    else if (item == 95 || item == 105 || item == 110 || item == 115 || item == 120)
                    {
                        if ((contadorDBT >= item) && (contadorDBT <= 200))
                            matrizCompletaCP[contadorFilas, contadorColumnas] = Utilities.Formulas.HUMRAT(contadorDBT, item, Elevation);
                    }
                    contadorFilas++;
                }

                contadorColumnas++;
            }
        }

        public void CargarVariables()
        {
            DryBulbA = double.Parse(txt_DryBulbA.Text);
            Relative = double.Parse(txt_Relative.Text);
            Elevation = double.Parse(txt_Elevation.Text);
            WetBulbA = double.Parse(txt_WetBulbA.Text);
            HumityRadioA = double.Parse(txt_HumityRadioA.Text);
            HumityRadioGRA = double.Parse(txt_HumityRadioGRA.Text);

            DryBulbB = double.Parse(txt_DryBulbB.Text);
            WetBuilB = double.Parse(txt_WetBuilB.Text);
            HumityRadioB = double.Parse(txt_HumityRadioB.Text);
            HumityRadioGRB = double.Parse(txt_HumityRadioGRB.Text);

            LenghtM = double.Parse(txt_LenghtM.Text);
            WidthM = double.Parse(txt_WidthM.Text);
            AvgCeilingM = double.Parse(txt_AvgCeilingM.Text);
            FloorAreaM = double.Parse(txt_FloorAreaM.Text);
            WallAreaM = double.Parse(txt_WallAreaM.Text);
            VolumeM = double.Parse(txt_VolumeM.Text);
            LenghtE = double.Parse(txt_LenghtE.Text);
            WidthE = double.Parse(txt_WidthE.Text);
            AvgCeilingE = double.Parse(txt_AvgCeilingE.Text);
            FloorAreaE = double.Parse(txt_FloorAreaE.Text);
            // WallAreaE = double.Parse(txt_WallAreaE.Text);
            VolumeE = double.Parse(txt_VolumeE.Text);

            OutsideTempRoof = double.Parse(txt_OutsideTempRoof.Text);
            InsideTempRoof = double.Parse(txt_InsideTempRoof.Text);
            TempDiffRoof = double.Parse(txt_TempDiffRoof.Text);
            UFactorRoof = double.Parse(txt_UFactorRoof.Text);
            RoofArea = double.Parse(txt_RoofArea.Text);
            HeatGainRoof = double.Parse(txt_HeatGainRoof.Text);

            OutsideTempWall = double.Parse(txt_OutsideTempWall.Text);
            InsideTempWall = double.Parse(txt_InsideTempWall.Text);
            TempDiffWall = double.Parse(txt_TempDiffWall.Text);
            UFactorWall = double.Parse(txt_UFactorWall.Text);
            WallArea = double.Parse(txt_WallArea.Text);
            HeatGainWall = double.Parse(txt_HeatGainWall.Text);

            OutsideTempFloor = double.Parse(txt_OutsideTempFloor.Text);
            InsideTempFloor = double.Parse(txt_InsideTempFloor.Text);
            TempDiffFloor = double.Parse(txt_TempDiffFloor.Text);
            UFactorFloor = double.Parse(txt_UFactorFloor.Text);
            FloorArea = double.Parse(txt_FloorArea.Text);
            HeatGainFloor = double.Parse(txt_HeatGainFloor.Text);

            SubtotalFloor = double.Parse(txt_SubtotalFloor.Text);
            GainWRF = double.Parse(txt_GainWRF.Text);
            LightDensity = double.Parse(txt_LightDensity.Text);
            FloorAreaLight = double.Parse(txt_FloorAreaLight.Text);
            HeatGainLight = double.Parse(txt_HeatGainLight.Text);
            HeadcountD = double.Parse(txt_HeadcountD.Text);

            SeatedRest = double.Parse(txt_SeatedRest.Text);
            SeatedLight = double.Parse(txt_SeatedLight.Text);
            OfficeWork = double.Parse(txt_OfficeWork.Text);
            Standing = double.Parse(txt_Standing.Text);
            Waking = double.Parse(txt_Waking.Text);
            ModerateWork = double.Parse(txt_ModerateWork.Text);
            LightBench = double.Parse(txt_LightBench.Text);
            ModerateDancing = double.Parse(txt_ModerateDancing.Text);
            FastWaking = double.Parse(txt_FastWaking.Text);
            HevyWork = double.Parse(txt_HevyWork.Text);

            SubtotalPeoGain = double.Parse(txt_SubtotalPeoGain.Text);
            HeatGainPeople = double.Parse(txt_HeatGainPeople.Text);

            InsideTemp = double.Parse(txt_InsideTemp.Text);
            FloorAreaEquip = double.Parse(txt_FloorAreaEquip.Text);
            GainEquip = double.Parse(txt_GainEquip.Text);

            HeadcountE = double.Parse(txt_HeadcountE.Text);
            Seated = double.Parse(txt_Seated.Text);
            SeatedVeLight = double.Parse(txt_SeatedVeLight.Text);
            OffWork = double.Parse(txt_OffWork.Text);
            LabWork = double.Parse(txt_LabWork.Text);
            WalkSea = double.Parse(txt_WalkSea.Text);
            ModWork = double.Parse(txt_ModWork.Text);
            LigBenWork = double.Parse(txt_LigBenWork.Text);
            ModDance = double.Parse(txt_ModDance.Text);
            FastWalk = double.Parse(txt_FastWalk.Text);
            HeaWork = double.Parse(txt_HeaWork.Text);

            SubtotalLatHeat = double.Parse(txt_SubtotalLatHeat.Text);
            HeatGaPeople = double.Parse(txt_HeatGaPeople.Text);

            VolumeLate = double.Parse(txt_VolumeLate.Text);
            HumDiff = double.Parse(txt_HumDiff.Text);
            HumityFact = double.Parse(txt_HumityFact.Text);
            VolumeFact = double.Parse(txt_VolumeFact.Text);
            ConstructionFact = double.Parse(txt_ConstructionFact.Text);
            VaporFact = double.Parse(txt_VaporFact.Text);

            HumGainGR = double.Parse(txt_HumGainGR.Text);
            HumGainLB = double.Parse(txt_HumGainLB.Text);
            VapoHeat = double.Parse(txt_VapoHeat.Text);

            SubtotalHumidity = double.Parse(txt_SubtotalHumidity.Text);

            LeaksDueBuilding = double.Parse(txt_LeaksDueBuilding.Text);

            LeaksDueDoors = double.Parse(txt_LeaksDueDoors.Text);
            GeneralExhaust = double.Parse(txt_GeneralExhaust.Text);

            VentHeadCount = double.Parse(txt_VentHeadCount.Text);
            UnitaryVentReq = double.Parse(txt_UnitaryVentReq.Text);
            VentilationReq = double.Parse(txt_VentilationReq.Text);

            EnviHeight = double.Parse(txt_EnviHeight.Text);
            EnviWidth = double.Parse(txt_EnviWidth.Text);
            EnviLenght = double.Parse(txt_EnviLenght.Text);
            EnviVolume = double.Parse(txt_EnviVolume.Text);

            HeadCountOccu = double.Parse(txt_HeadCountOccu.Text);

            Motionless = double.Parse(txt_Motionless.Text);
            HeadArm = double.Parse(txt_HeadArm.Text);
            FoodMotion = double.Parse(txt_FoodMotion.Text);
            StandSit = double.Parse(txt_StandSit.Text);
            Walk20 = double.Parse(txt_Walk20.Text);
            Walk35 = double.Parse(txt_Walk35.Text);
            Walk50 = double.Parse(txt_Walk50.Text);

            MotionlessP = double.Parse(txt_MotionlessP.Text);
            HeadArmP = double.Parse(txt_HeadArmP.Text);
            FoodMotionP = double.Parse(txt_FoodMotionP.Text);
            StandSitP = double.Parse(txt_StandSitP.Text);
            Walk20P = double.Parse(txt_Walk20P.Text);
            Walk35P = double.Parse(txt_Walk35P.Text);
            Walk50P = double.Parse(txt_Walk50P.Text);

            PartGenDueOccu = double.Parse(txt_PartGenDueOccu.Text);
            PartGenDueBuild = double.Parse(txt_PartGenDueBuild.Text);
            PartGenDueMfg = double.Parse(txt_PartGenDueMfg.Text);

            AirChange = double.Parse(txt_AirChange.Text);
            AirFlow = double.Parse(txt_AirFlow.Text);
            AirFilter = double.Parse(txt_AirFilter.Text);

            AirDistVentilation = double.Parse(txt_AirDistVentilation.Text);
            AirDistMax = double.Parse(txt_AirDistMax.Text);
            // AirDistRecovery = double.Parse(txt_AirDistRecovery.Text);

            AvgPartConc = double.Parse(txt_AvgPartConc.Text);
            // MaxPartConc = double.Parse(txt_MaxPartConc.Text);

            // ElevationMAH = double.Parse(txt_ElevationMAH.Text);

            OSADBT = double.Parse(txt_OSADBT.Text);
            OSAWBT = double.Parse(txt_OSAWBT.Text);
            OSAEnthalpy = double.Parse(txt_OSAEnthalpy.Text);
            OSADensity = double.Parse(txt_OSADensity.Text);
            OSAFlow = double.Parse(txt_OSAFlow.Text);
            OSAMass = double.Parse(txt_OSAMass.Text);
            OSAHumidity = double.Parse(txt_OSAHumidity.Text);

            PCCDBT = double.Parse(txt_PCCDBT.Text);
            PCCWBT = double.Parse(txt_PCCWBT.Text);
            PCCEnthalpy = double.Parse(txt_PCCEnthalpy.Text);
            PCCHumidity = double.Parse(txt_PCCHumidity.Text);

            EnthalpyDiff = double.Parse(txt_EnthalpyDiff.Text);
            TotalMAHCool = double.Parse(txt_TotalMAHCool.Text);

            EnthalDiffMAH = double.Parse(txt_EnthalDiffMAH.Text);
            MAHSensibleCooling = double.Parse(txt_MAHSensibleCooling.Text);

            MAHLatentCooling = double.Parse(txt_MAHLatentCooling.Text);

            // ElevationCooling = double.Parse(txt_ElevationCooling.Text);

            PCC2DBT = double.Parse(txt_PCC2DBT.Text);
            PCC2WBT = double.Parse(txt_PCC2WBT.Text);
            PCC2Enthalpy = double.Parse(txt_PCC2Enthalpy.Text);
            PCC2Density = double.Parse(txt_PCC2Density.Text);
            PCC2Flow = double.Parse(txt_PCC2Flow.Text);
            PCC2Mass = double.Parse(txt_PCC2Mass.Text);
            PCC2Humidity = double.Parse(txt_PCC2Humidity.Text);

            CCDBT = double.Parse(txt_CCDBT.Text);
            CCWBT = double.Parse(txt_CCWBT.Text);

            CCEnthalpy = double.Parse(txt_CCEnthalpy.Text);
            CCHumidity = double.Parse(txt_CCHumidity.Text);

            CCEnthalpyDiff = double.Parse(txt_CCEnthalpyDiff.Text);
            CCTotalCooling = double.Parse(txt_CCTotalCooling.Text);

            CCSensEnthalpyDiff = double.Parse(txt_CCSensEnthalpyDiff.Text);
            CCSensCoolCap = double.Parse(txt_CCSensCoolCap.Text);

            CCLatCoolCap = double.Parse(txt_CCLatCoolCap.Text);

            MUHElevation = double.Parse(txt_MUHElevation.Text);

            CC2DBT = double.Parse(txt_CC2DBT.Text);
            CC2WBT = double.Parse(txt_CC2WBT.Text);
            CC2Enthalpy = double.Parse(txt_CC2Enthalpy.Text);
            CC2Density = double.Parse(txt_CC2Density.Text);
            CC2Flow = double.Parse(txt_CC2Flow.Text);
            CC2Mass = double.Parse(txt_CC2Mass.Text);
            CC2Humidity = double.Parse(txt_CC2Humidity.Text);

            HCDBT = double.Parse(txt_HCDBT.Text);
            HCWBT = double.Parse(txt_HCWBT.Text);
            HCEnthalpy = double.Parse(txt_HCEnthalpy.Text);
            HCHumidity = double.Parse(txt_HCHumidity.Text);
            HCEntDiff = double.Parse(txt_HCEntDiff.Text);
            HCCooling = double.Parse(txt_HCCooling.Text);
            HCEnthDifference = double.Parse(txt_HCEnthDifference.Text);
            HCSensiCool = double.Parse(txt_HCSensiCool.Text);
            HCLatentCool = double.Parse(txt_HCLatentCool.Text);

            RAHElevation = double.Parse(txt_RAHElevation.Text);

            RAHFlow = double.Parse(txt_RAHFlow.Text);
            RAHDBT = double.Parse(txt_RAHDBT.Text);
            // RAHRH = double.Parse(txt_RAHRH.Text);
            RAHWBT = double.Parse(txt_RAHWBT.Text);
            RAHHumidity = double.Parse(txt_RAHHumidity.Text);
            //  RAHEthalpy = double.Parse(txt_RAHEthalpy.Text);

            RAHFlowR = double.Parse(txt_RAHFlowR.Text);
            RAHDBTR = double.Parse(txt_RAHDBTR.Text);
            RAHRHR = double.Parse(txt_RAHRHR.Text);
            RAHWBTR = double.Parse(txt_RAHWBTR.Text);
            //  RAHHumidityR = double.Parse(txt_RAHHumidityR.Text);
            RAHEthalpyR = double.Parse(txt_RAHEthalpyR.Text);

            MAFlow = double.Parse(txt_MAFlow.Text);
            MADBT = double.Parse(txt_MADBT.Text);
            MAWBT = double.Parse(txt_MAWBT.Text);
            MADew = double.Parse(txt_MADew.Text);
            MAEnthalpy = double.Parse(txt_MAEnthalpy.Text);
            MAHumidity = double.Parse(txt_MAHumidity.Text);
            MADensity = double.Parse(txt_MADensity.Text);
            MAMass = double.Parse(txt_MAMass.Text);

            MAInternalLat = double.Parse(txt_MAInternalLat.Text);
            MACCEntalphy = double.Parse(txt_MACCEntalphy.Text);
            MACCHumidity = double.Parse(txt_MACCHumidity.Text);
            MACCDew = double.Parse(txt_MACCDew.Text);
            MACCDry = double.Parse(txt_MACCDry.Text);

            MACCInternal = double.Parse(txt_MACCInternal.Text);
            MACCEntDecrease = double.Parse(txt_MACCEntDecrease.Text);
            MACCReqDryBulb = double.Parse(txt_MACCReqDryBulb.Text);
            MACCResDewPoint = double.Parse(txt_MACCResDewPoint.Text);
            MACCHumRatio = double.Parse(txt_MACCHumRatio.Text);

            RAHCCDBT = double.Parse(txt_RAHCCDBT.Text);
            RAHCCDPT = double.Parse(txt_RAHCCDPT.Text);
            RACCCWBT = double.Parse(txt_RACCCWBT.Text);
            RAHCCEnthalpy = double.Parse(txt_RAHCCEnthalpy.Text);
            RACCCHumidity = double.Parse(txt_RACCCHumidity.Text);

            //SenCoolOnly = double.Parse(txt_SenCoolOnly.Text);

            RAHTotalEnthalpyDiff = double.Parse(txt_RAHTotalEnthalpyDiff.Text);
            TotalRAHCool = double.Parse(txt_TotalRAHCool.Text);

            RAHSenCoolEnthDiff = double.Parse(txt_RAHSenCoolEnthDiff.Text);
            RAHSenCoolCap = double.Parse(txt_RAHSenCoolCap.Text);

            RAHLatCoolCap = double.Parse(txt_RAHLatCoolCap.Text);

            HeatingPower = double.Parse(txt_HeatingPower.Text);
            RAHeHDBT = double.Parse(txt_RAHeHDBT.Text);
            RAHeHumRat = double.Parse(txt_RAHeHumRat.Text);
            ElectricalPow = double.Parse(txt_ElectricalPow.Text);
            //  ElectricalPowFlow = double.Parse(txt_ElectricalPowFlow.Text);

            //  ElevationCart = double.Parse(txt_ElevationCart.Text);

            SeatedRestP = double.Parse(txt_SeatedRestP.Text);
            SeatedLightP = double.Parse(txt_SeatedLightP.Text);
            OfficeWorkP = double.Parse(txt_OfficeWorkP.Text);
            StandingP = double.Parse(txt_StandingP.Text);
            WakingP = double.Parse(txt_WakingP.Text);
            ModerateWorkP = double.Parse(txt_ModerateWorkP.Text);
            LightBenchP = double.Parse(txt_LightBenchP.Text);
            ModerateDancingP = double.Parse(txt_ModerateDancingP.Text);
            FastWakingP = double.Parse(txt_FastWakingP.Text);
            HevyWorkP = double.Parse(txt_HevyWorkP.Text);


            SeatedP = double.Parse(txt_SeatedP.Text);
            SeatedVeLightP = double.Parse(txt_SeatedVeLightP.Text);
            OffWorkP = double.Parse(txt_OffWorkP.Text);
            LabWorkP = double.Parse(txt_LabWorkP.Text);
            WalkSeaP = double.Parse(txt_WalkSeaP.Text);
            ModWorkP = double.Parse(txt_ModWorkP.Text);
            LigBenWorkP = double.Parse(txt_LigBenWorkP.Text);
            ModDanceP = double.Parse(txt_ModDanceP.Text);
            FastWalkP = double.Parse(txt_FastWalkP.Text);
            HeaWorkP = double.Parse(txt_HeaWorkP.Text);


        }

        public void CalcularVariables()
        {
            object objeto = new object();

            Txt_SubtotalHumidity_KeyDown(objeto, Key);

            Txt_LeaksDueBuilding_KeyDown(objeto, Key);

            Txt_LeaksDueDoors_KeyDown(objeto, Key);
            Txt_GeneralExhaust_KeyDown(objeto, Key);

            Txt_VentHeadCount_KeyDown(objeto, Key);
            Txt_UnitaryVentReq_KeyDown(objeto, Key);
            Txt_VentilationReq_KeyDown(objeto, Key);

            Txt_EnviHeight_KeyDown(objeto, Key);
            Txt_EnviWidth_KeyDown(objeto, Key);
            Txt_EnviLenght_KeyDown(objeto, Key);
            Txt_EnviVolume_KeyDown(objeto, Key);

            //txt_HeadCountOccu

            Txt_Motionless_KeyDown(objeto, Key);
            Txt_HeadArm_KeyDown(objeto, Key);
            Txt_FoodMotion_KeyDown(objeto, Key);
            Txt_StandSit_KeyDown(objeto, Key);
            Txt_Walk20_KeyDown(objeto, Key);
            Txt_Walk35_KeyDown(objeto, Key);
            Txt_Walk50_KeyDown(objeto, Key);

            Txt_MotionlessP_KeyDown(objeto, Key);
            Txt_HeadArmP_KeyDown(objeto, Key);
            Txt_FoodMotionP_KeyDown(objeto, Key);
            Txt_StandSitP_KeyDown(objeto, Key);
            Txt_Walk20P_KeyDown(objeto, Key);
            Txt_Walk35P_KeyDown(objeto, Key);
            Txt_Walk50P_KeyDown(objeto, Key);

            Txt_PartGenDueOccu_KeyDown(objeto, Key);
            Txt_PartGenDueBuild_KeyDown(objeto, Key);
            Txt_PartGenDueMfg_KeyDown(objeto, Key);

            Txt_AirChange_KeyDown(objeto, Key);
            Txt_AirFlow_KeyDown(objeto, Key);
            //txt_AirFilter

            //txt_AirDistVentilation
            Txt_AirDistMax_KeyDown(objeto, Key);
            // AirDistRecovery = double.Parse(txt_AirDistRecovery.Text);

            Txt_AvgPartConc_KeyDown(objeto, Key);
            // MaxPartConc = double.Parse(txt_MaxPartConc.Text);

            // ElevationMAH = double.Parse(txt_ElevationMAH.Text);

            Txt_OSADBT_KeyDown(objeto, Key);
            Txt_OSAWBT_KeyDown(objeto, Key);
            Txt_OSAEnthalpy_KeyDown(objeto, Key);
            Txt_OSADensity_KeyDown(objeto, Key);
            Txt_OSAFlow_KeyDown(objeto, Key);
            Txt_OSAMass_KeyDown(objeto, Key);
            Txt_OSAHumidity_KeyDown(objeto, Key);

            Txt_PCCDBT_KeyDown(objeto, Key);
            Txt_PCCWBT_KeyDown(objeto, Key);
            Txt_PCCEnthalpy_KeyDown(objeto, Key);
            Txt_PCCHumidity_KeyDown(objeto, Key);

            Txt_EnthalpyDiff_KeyDown(objeto, Key);
            Txt_TotalMAHCool_KeyDown(objeto, Key);

            Txt_EnthalDiffMAH_KeyDown(objeto, Key);
            Txt_MAHSensibleCooling_KeyDown(objeto, Key);

            Txt_MAHLatentCooling_KeyDown(objeto, Key);

            // ElevationCooling = double.Parse(txt_ElevationCooling.Text);

            Txt_PCC2DBT_KeyDown(objeto, Key);
            Txt_PCC2WBT_KeyDown(objeto, Key);
            Txt_PCC2Enthalpy_KeyDown(objeto, Key);
            Txt_PCC2Density_KeyDown(objeto, Key);
            Txt_PCC2Flow_KeyDown(objeto, Key);
            Txt_PCC2Mass_KeyDown(objeto, Key);
            Txt_PCC2Humidity_KeyDown(objeto, Key);

            Txt_CCDBT_KeyDown(objeto, Key);
            Txt_CCWBT_KeyDown(objeto, Key);

            Txt_CCEnthalpy_KeyDown(objeto, Key);
            Txt_CCHumidity_KeyDown(objeto, Key);

            Txt_CCEnthalpyDiff_KeyDown(objeto, Key);
            Txt_CCTotalCooling_KeyDown(objeto, Key);

            Txt_CCSensEnthalpyDiff_KeyDown(objeto, Key);
            Txt_CCSensCoolCap_KeyDown(objeto, Key);

            Txt_CCLatCoolCap_KeyDown(objeto, Key);

            Txt_MUHElevation_KeyDown(objeto, Key);

            Txt_CC2DBT_KeyDown(objeto, Key);
            Txt_CC2WBT_KeyDown(objeto, Key);
            //txt_CC2Enthalpy
            Txt_CC2Density_KeyDown(objeto, Key);
            Txt_CC2Flow_KeyDown(objeto, Key);
            Txt_CC2Mass_KeyDown(objeto, Key);
            Txt_CC2Humidity_KeyDown(objeto, Key);

            Txt_HCDBT_KeyDown(objeto, Key);
            Txt_HCWBT_KeyDown(objeto, Key);
            Txt_HCEnthalpy_KeyDown(objeto, Key);
            Txt_HCHumidity_KeyDown(objeto, Key);
            Txt_HCEntDiff_KeyDown(objeto, Key);
            Txt_HCCooling_KeyDown(objeto, Key);
            Txt_HCEnthDifference_KeyDown(objeto, Key);
            Txt_HCSensiCool_KeyDown(objeto, Key);
            Txt_HCLatentCool_KeyDown(objeto, Key);

            Txt_RAHElevation_KeyDown(objeto, Key);

            Txt_RAHFlow_KeyDown(objeto, Key);
            Txt_RAHDBT_KeyDown(objeto, Key);
            // RAHRH = double.Parse(txt_RAHRH.Text);
            Txt_RAHWBT_KeyDown(objeto, Key);
            Txt_RAHHumidity_KeyDown(objeto, Key);
            //  RAHEthalpy = double.Parse(txt_RAHEthalpy.Text);

            Txt_RAHFlowR_KeyDown(objeto, Key);
            Txt_RAHDBTR_KeyDown(objeto, Key);
            Txt_RAHRHR_KeyDown(objeto, Key);
            Txt_RAHWBTR_KeyDown(objeto, Key);
            //  RAHHumidityR = double.Parse(txt_RAHHumidityR.Text);
            Txt_RAHEthalpyR_KeyDown(objeto, Key);

            Txt_MAFlow_KeyDown(objeto, Key);
            Txt_MADBT_KeyDown(objeto, Key);
            Txt_MAWBT_KeyDown(objeto, Key);
            Txt_MADew_KeyDown(objeto, Key);
            Txt_MAEnthalpy_KeyDown(objeto, Key);
            Txt_MAHumidity_KeyDown(objeto, Key);
            Txt_MADensity_KeyDown(objeto, Key);
            Txt_MAMass_KeyDown(objeto, Key);

            Txt_MAInternalLat_KeyDown(objeto, Key);
            Txt_MACCEntalphy_KeyDown(objeto, Key);
            Txt_MACCHumidity_KeyDown(objeto, Key);
            Txt_MACCDew_KeyDown(objeto, Key);
            Txt_MACCDry_KeyDown(objeto, Key);

            Txt_MACCInternal_KeyDown(objeto, Key);
            Txt_MACCEntDecrease_KeyDown(objeto, Key);
            Txt_MACCReqDryBulb_KeyDown(objeto, Key);
            Txt_MACCResDewPoint_KeyDown(objeto, Key);
            Txt_MACCHumRatio_KeyDown(objeto, Key);

            Txt_RAHCCDBT_KeyDown(objeto, Key);
            Txt_RAHCCDPT_KeyDown(objeto, Key);
            Txt_RACCCWBT_KeyDown(objeto, Key);
            Txt_RAHCCEnthalpy_KeyDown(objeto, Key);
            Txt_RACCCHumidity_KeyDown(objeto, Key);

            //SenCoolOnly = double.Parse(txt_SenCoolOnly.Text);

            Txt_RAHTotalEnthalpyDiff_KeyDown(objeto, Key);
            Txt_TotalRAHCool_KeyDown(objeto, Key);

            Txt_RAHSenCoolEnthDiff_KeyDown(objeto, Key);
            Txt_RAHSenCoolCap_KeyDown(objeto, Key);

            Txt_RAHLatCoolCap_KeyDown(objeto, Key);

            Txt_HeatingPower_KeyDown(objeto, Key);
            Txt_RAHeHDBT_KeyDown(objeto, Key);
            Txt_RAHeHumRat_KeyDown(objeto, Key);
            Txt_ElectricalPow_KeyDown(objeto, Key);
            //  ElectricalPowFlow = double.Parse(txt_ElectricalPowFlow.Text);

            //  ElevationCart = double.Parse(txt_ElevationCart.Text);





        }

        public void CargarTodosTabs()
        {
            CargarInfoTabDesignCond();

            CargarInfoTabInternalSHL();

            CargarInfoTabInternalLHL();

            CargarInfoTabOutSideAir();

            CargarInfoTabParticConc();

            CargarInfoTabMUP();

            CargarInfoTabMUH();

            CargarInfoTabMUC();

            CargarInfoTabRAH();

            CargarInfoTabPCGraphic();

            CargarInfoTabCarta();
        }

        public void CargarInfoTabDesignCond()
        {
            object objeto = new object();

            foreach (Control x in this.panelDesignCond.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.AccessibleDescription = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabInternalSHL()
        {
            object objeto = new object();

            foreach (Control x in this.panelInternalSHL.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabInternalLHL()
        {
            object objeto = new object();

            foreach (Control x in this.panelInternalLHL.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabOutSideAir()
        {
            object objeto = new object();

            foreach (Control x in this.panelOutsideAir.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabParticConc()
        {
            object objeto = new object();

            foreach (Control x in this.panelParticConc.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabCarta()
        {
            object objeto = new object();

            foreach (Control x in this.panelCarta.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabPCGraphic()
        {
            //List<ConcentracionParticula> listaCP;

            //ConcentracionParticulaManagement concentracionParticulaManagement = new ConcentracionParticulaManagement();

            //ConcentracionParticula concentracionParticula = new ConcentracionParticula
            //{
            //    ObjProyectoRoom = gProyectoRoom
            //};

            //try
            //{
            //    listaCP = (List<ConcentracionParticula>)concentracionParticulaManagement.RetriveByProRoomStatement(concentracionParticula);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //Int32 count=1;

            //foreach (var item in listaCP)
            //{
            //    string PartConBeg = "txt_PartConBeg" + count;
            //    string PartIncome = "txt_PartIncome" + count;
            //    string PartGen = "txt_PartGen" + count;
            //    string PartCount = "txt_PartCount" + count;
            //    string PartGoing = "txt_PartGoing" + count;
            //    string PartCountEnd = "txt_PartCountEnd" + count;
            //    string PartConEndPer = "txt_PartConEndPer" + count;

            //    foreach (Control x in this.panelPCGraphic.Controls)
            //    {
            //        //if (x is TextBox || x is Label)
            //        if (x is TextBox)
            //        {
            //            if (x.Name.Equals(PartConBeg))
            //            {
            //                x.Text = item.ConcenPartiIni.ToString("#0.########");
            //                x.Tag = item.IdConcentracionParticula;
            //            }
            //            else if (x.Name.Equals(PartIncome))
            //            {
            //                x.Text = item.ConceIncome.ToString("#0.########");
            //                x.Tag = item.IdConcentracionParticula;
            //            }
            //            else if (x.Name.Equals(PartGen))
            //            {
            //                x.Text = item.ConcenPartiGen.ToString("#0.########");
            //                x.Tag = item.IdConcentracionParticula;
            //            }
            //            else if (x.Name.Equals(PartCount))
            //            {
            //                x.Text = item.PartiIni.ToString("#0.########");
            //                x.Tag = item.IdConcentracionParticula;
            //            }
            //            else if (x.Name.Equals(PartGoing))
            //            {
            //                x.Text = item.PartiRetorna.ToString("#0.########");
            //                x.Tag = item.IdConcentracionParticula;
            //            }
            //            else if (x.Name.Equals(PartCountEnd))
            //            {
            //                x.Text = item.PartiFin.ToString("#0.########");
            //                x.Tag = item.IdConcentracionParticula;
            //            }
            //            else if (x.Name.Equals(PartConEndPer))
            //            {
            //                x.Text = item.ConcenPartiFin.ToString("#0.########");
            //                x.Tag = item.IdConcentracionParticula;
            //            }
            //        }
            //    }

            //    count++;
            //}

            foreach (Control x in this.panelPCGraphic.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (x.Name.Equals("txt_PartConBeg1"))
                    {
                        if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                        {
                            ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                            if (search != null)
                            {
                                x.Text = search.Valor.ToString("#0.########");
                                x.AccessibleDescription = search.Valor.ToString("#0.########");
                                x.Tag = search.IdProyectoParametro;
                            }

                        }
                    }
                }
            }
        }

        public void CargarInfoTabMUP()
        {
            object objeto = new object();

            foreach (Control x in this.panelMUP.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabMUC()
        {
            object objeto = new object();

            foreach (Control x in this.panelMUC.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabMUH()
        {
            object objeto = new object();

            foreach (Control x in this.panelMUH.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }

        public void CargarInfoTabRAH()
        {
            object objeto = new object();

            foreach (Control x in this.panelRAH.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }


        public void CargarInfoTabRAHGraphic()
        {
            object objeto = new object();

            foreach (Control x in this.panelRAHGraphic.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox || x is Label)
                {
                    if (listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).Count() > 0)
                    {
                        ProyectoParametro search = listaCargada.Where(y => y.ObjParametro.ObjNombreParametro.Nombre == x.Name).First();

                        if (search != null)
                        {
                            x.Text = search.Valor.ToString("#0.########");
                            x.Tag = search.IdProyectoParametro;
                        }

                    }
                }
            }
        }



        public void GuardarValor(string valor, string ID)
        {
            if (Guardar)
            {
                ProyectoParametroManagement proyectoParametroManagement = new ProyectoParametroManagement();

                ProyectoParametro proyectoParametro = new ProyectoParametro
                {
                    Valor = Double.Parse(valor),

                    IdProyectoParametro = Int32.Parse(ID)
                };

                proyectoParametroManagement.UpdateValorProyectoParametro(proyectoParametro);
            }
        }

        public void CargarDesignCond()
        {
            #region Design Conditions

            DryBulbA = double.Parse(txt_DryBulbA.Text);

            Relative = double.Parse(txt_Relative.Text);

            Elevation = double.Parse(txt_Elevation.Text);

            //txt_WetBulbA.Text = Utilities.Formulas.WbtHR(DryBulbA, (Relative / 100), Elevation).ToString("#.##");

            //txt_WetBulbA.Text = "59.57";

            WetBulbA = double.Parse(txt_WetBulbA.Text);

            txt_Enthalpy.Text = Utilities.Formulas.ENT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

            txt_HumityRadioA.Text = Utilities.Formulas.HUMRAT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

            txt_Density.Text = Utilities.Formulas.DENS(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

            HumityRadioA = double.Parse(txt_HumityRadioA.Text);

            #endregion

            #region Outside Conditions

            txt_HumityRadioGRA.Text = Math.Round((HumityRadioA * 7000), 2, MidpointRounding.ToEven).ToString("#0.########");

            DryBulbB = double.Parse(txt_DryBulbB.Text);

            WetBuilB = double.Parse(txt_WetBuilB.Text);

            txt_HumityRadioB.Text = Utilities.Formulas.HUMRAT(DryBulbB, WetBuilB, Elevation).ToString("#0.########");

            HumityRadioB = double.Parse(txt_HumityRadioB.Text);

            txt_HumityRadioGRB.Text = (HumityRadioB * 7000).ToString("#0.########");

            #endregion

            #region Dimensions

            LenghtM = double.Parse(txt_LenghtM.Text);

            WidthM = double.Parse(txt_WidthM.Text);

            txt_FloorAreaM.Text = (LenghtM * WidthM).ToString("#0.#####");

            FloorAreaM = double.Parse(txt_FloorAreaM.Text);

            AvgCeilingM = double.Parse(txt_AvgCeilingM.Text);

            txt_WallAreaM.Text = (AvgCeilingM * 2 * (LenghtM + WidthM)).ToString("#0.#####");

            txt_VolumeM.Text = (FloorAreaM * AvgCeilingM).ToString("#0.#####");

            txt_LenghtE.Text = (LenghtM * 3.28).ToString("#0.#####");

            txt_WidthE.Text = (WidthM * 3.28).ToString("#0.#####");

            txt_AvgCeilingE.Text = (AvgCeilingM * 3.28).ToString("#0.#####");

            txt_FloorAreaE.Text = (FloorAreaM * Math.Pow(3.28, 2)).ToString("#0.#####");

            WallAreaM = double.Parse(txt_WallAreaM.Text);

            txt_WallAreaE.Text = (WallAreaM * Math.Pow(3.28, 2)).ToString("#0.#####");

            VolumeM = double.Parse(txt_VolumeM.Text);

            txt_VolumeE.Text = (VolumeM * 35.31).ToString("#0.#####");

            #endregion

            MUHElevation = double.Parse(txt_HCHumidity.Text);

            MAMass = double.Parse(txt_MAMass.Text);

            MAFlow = double.Parse(txt_MAMass.Text);

        }

        public void CargarInternalSHL()
        {
            #region Internal Sensible Heat Loads

            #region  Sensible heat gain thru Walls, Roof and Floor

            #region Roof

            OutsideTempRoof = double.Parse(txt_OutsideTempRoof.Text);

            InsideTempRoof = double.Parse(txt_InsideTempRoof.Text);

            txt_TempDiffRoof.Text = (OutsideTempRoof - InsideTempRoof).ToString("#0.########");

            FloorAreaE = double.Parse(txt_FloorAreaE.Text);

            txt_RoofArea.Text = FloorAreaE.ToString("#0.########");

            TempDiffRoof = double.Parse(txt_TempDiffRoof.Text);

            UFactorRoof = double.Parse(txt_UFactorRoof.Text);

            RoofArea = double.Parse(txt_RoofArea.Text);

            txt_HeatGainRoof.Text = (TempDiffRoof * UFactorRoof * RoofArea).ToString("#0.########");

            #endregion

            #region Walls

            OutsideTempWall = double.Parse(txt_OutsideTempWall.Text);

            InsideTempWall = double.Parse(txt_InsideTempWall.Text);

            txt_TempDiffWall.Text = (OutsideTempWall - InsideTempWall).ToString("#0.########");

            WallAreaE = double.Parse(txt_WallAreaE.Text);

            txt_WallArea.Text = WallAreaE.ToString("#0.########");

            TempDiffWall = double.Parse(txt_TempDiffWall.Text);

            UFactorWall = double.Parse(txt_UFactorWall.Text);

            WallArea = double.Parse(txt_WallArea.Text);

            txt_HeatGainWall.Text = (TempDiffWall * UFactorWall * WallArea).ToString("#0.########");

            #endregion

            #region  Floor

            OutsideTempFloor = double.Parse(txt_OutsideTempFloor.Text);

            InsideTempFloor = double.Parse(txt_InsideTempFloor.Text);

            txt_TempDiffFloor.Text = (OutsideTempFloor - InsideTempFloor).ToString("#0.########");

            txt_FloorArea.Text = FloorAreaE.ToString("#0.########");

            TempDiffFloor = double.Parse(txt_TempDiffFloor.Text);

            UFactorFloor = double.Parse(txt_UFactorFloor.Text);

            FloorArea = double.Parse(txt_FloorArea.Text);

            txt_HeatGainFloor.Text = (TempDiffFloor * UFactorFloor * FloorArea).ToString("#0.########");

            #endregion

            HeatGainRoof = double.Parse(txt_HeatGainRoof.Text);

            HeatGainWall = double.Parse(txt_HeatGainWall.Text);

            HeatGainFloor = double.Parse(txt_HeatGainFloor.Text);

            txt_SubtotalFloor.Text = (HeatGainRoof + HeatGainWall + HeatGainFloor).ToString("#0.########");

            SubtotalFloor = double.Parse(txt_SubtotalFloor.Text);

            txt_GainWRF.Text = (SubtotalFloor / 3412).ToString("#0.########");

            #endregion

            #region Sensible heat gain lighting

            FloorAreaM = double.Parse(txt_FloorAreaM.Text);

            txt_FloorAreaLight.Text = FloorAreaM.ToString("#0.#####");

            LightDensity = double.Parse(txt_LightDensity.Text);

            FloorAreaLight = double.Parse(txt_FloorAreaLight.Text);

            txt_HeatGainLight.Text = (LightDensity * FloorAreaLight / 1000).ToString("#0.########");

            #endregion

            #region Sensible heat gain from people occupancy

            SeatedRest = double.Parse(txt_SeatedRest.Text);
            SeatedLight = double.Parse(txt_SeatedLight.Text);
            OfficeWork = double.Parse(txt_OfficeWork.Text);
            Standing = double.Parse(txt_Standing.Text);
            Waking = double.Parse(txt_Waking.Text);
            ModerateWork = double.Parse(txt_ModerateWork.Text);
            LightBench = double.Parse(txt_LightBench.Text);
            ModerateDancing = double.Parse(txt_ModerateDancing.Text);
            FastWaking = double.Parse(txt_FastWaking.Text);
            HevyWork = double.Parse(txt_HevyWork.Text);

            SeatedRestP = double.Parse(txt_SeatedRestP.Text);
            SeatedLightP = double.Parse(txt_SeatedLightP.Text);
            OfficeWorkP = double.Parse(txt_OfficeWorkP.Text);
            StandingP = double.Parse(txt_StandingP.Text);
            WakingP = double.Parse(txt_WakingP.Text);
            ModerateWorkP = double.Parse(txt_ModerateWorkP.Text);
            LightBenchP = double.Parse(txt_LightBenchP.Text);
            ModerateDancingP = double.Parse(txt_ModerateDancingP.Text);
            FastWakingP = double.Parse(txt_FastWakingP.Text);
            HevyWorkP = double.Parse(txt_HevyWorkP.Text);

            TotalPercentage = SeatedRestP + SeatedLightP + OfficeWorkP + StandingP + WakingP + ModerateWorkP + LightBenchP + ModerateDancingP + FastWakingP + HevyWorkP;

            if (TotalPercentage < 100)
            {
                txt_TotalPercentage.Text = "Must Add 100 %";
            }
            else
            {
                txt_TotalPercentage.Text = TotalPercentage.ToString("#0.########");
            }

            SeatedRestP = 0;

            if (SeatedRestP != 0)
                TotalSensibleHeat += SeatedRest * (SeatedRestP / 100);
            if (SeatedLightP != 0)
                TotalSensibleHeat += SeatedLight * (SeatedLightP / 100);
            if (OfficeWorkP != 0)
                TotalSensibleHeat += OfficeWork * (OfficeWorkP / 100);
            if (StandingP != 0)
                TotalSensibleHeat += Standing * (StandingP / 100);
            if (WakingP != 0)
                TotalSensibleHeat += Waking * (WakingP / 100);
            if (ModerateWorkP != 0)
                TotalSensibleHeat += ModerateWork * (ModerateWorkP / 100);
            if (LightBenchP != 0)
                TotalSensibleHeat += LightBench * (LightBenchP / 100);
            if (ModerateDancingP != 0)
                TotalSensibleHeat += ModerateDancing * (ModerateDancingP / 100);
            if (FastWakingP != 0)
                TotalSensibleHeat += FastWaking * (FastWakingP / 100);
            if (HevyWorkP != 0)
                TotalSensibleHeat += HevyWork * (HevyWorkP / 100);

            txt_TotalSensibleHeat.Text = TotalSensibleHeat.ToString("#0.########");

            TotalSensibleHeat = double.Parse(txt_TotalSensibleHeat.Text);

            HeadcountD = double.Parse(txt_HeadcountD.Text);

            txt_SubtotalPeoGain.Text = (TotalSensibleHeat * HeadcountD).ToString("#0.########");

            SubtotalPeoGain = double.Parse(txt_SubtotalPeoGain.Text);

            txt_HeatGainPeople.Text = (SubtotalPeoGain / 3412).ToString("#0.########");

            #endregion

            #region Sensible heat gain from equipment

            FloorAreaM = double.Parse(txt_FloorAreaM.Text);

            txt_FloorAreaEquip.Text = FloorAreaM.ToString("#0.########");

            InsideTemp = double.Parse(txt_InsideTemp.Text);

            FloorAreaEquip = double.Parse(txt_FloorAreaEquip.Text);

            txt_GainEquip.Text = ((InsideTemp * FloorAreaEquip) / 1000).ToString("#0.########");

            #endregion

            GainWRF = double.Parse(txt_GainWRF.Text);

            HeatGainLight = double.Parse(txt_HeatGainLight.Text);

            HeatGainPeople = double.Parse(txt_HeatGainPeople.Text);

            GainEquip = double.Parse(txt_GainEquip.Text);

            lbl_TotalSensibleHeatKW.Text = (GainWRF + HeatGainLight + HeatGainPeople + GainEquip).ToString("#0.########");

            TotalSensibleHeatKW = double.Parse(lbl_TotalSensibleHeatKW.Text);

            lbl_TotalSensibleHeatBTU.Text = (TotalSensibleHeatKW * 3412).ToString("#0.########");

            #endregion
        }

        public void CargarInternalLHL()
        {
            #region Internal Latent Heat Loads

            HeadcountD = double.Parse(txt_HeadcountD.Text);

            txt_HeadcountE.Text = HeadcountD.ToString("#0.########");

            Seated = double.Parse(txt_Seated.Text);
            SeatedVeLight = double.Parse(txt_SeatedVeLight.Text);
            OffWork = double.Parse(txt_OffWork.Text);
            LabWork = double.Parse(txt_LabWork.Text);
            WalkSea = double.Parse(txt_WalkSea.Text);
            ModWork = double.Parse(txt_ModWork.Text);
            LigBenWork = double.Parse(txt_LigBenWork.Text);
            ModDance = double.Parse(txt_ModDance.Text);
            FastWalk = double.Parse(txt_FastWalk.Text);
            HeaWork = double.Parse(txt_HeaWork.Text);

            SeatedP = double.Parse(txt_SeatedP.Text);
            SeatedVeLightP = double.Parse(txt_SeatedVeLightP.Text);
            OffWorkP = double.Parse(txt_OffWorkP.Text);
            LabWorkP = double.Parse(txt_LabWorkP.Text);
            WalkSeaP = double.Parse(txt_WalkSeaP.Text);
            ModWorkP = double.Parse(txt_ModWorkP.Text);
            LigBenWorkP = double.Parse(txt_LigBenWorkP.Text);
            ModDanceP = double.Parse(txt_ModDanceP.Text);
            FastWalkP = double.Parse(txt_FastWalkP.Text);
            HeaWorkP = double.Parse(txt_HeaWorkP.Text);

            TotalLatentHeatP = SeatedP + SeatedVeLightP + OffWorkP + LabWorkP + WalkSeaP + ModWorkP + LigBenWorkP + ModDanceP + FastWalkP + HeaWorkP;

            if (TotalLatentHeatP < 100)
            {
                txt_TotalLatentHeatP.Text = "Must Add 100 %";
            }
            else
            {
                txt_TotalLatentHeatP.Text = TotalLatentHeatP.ToString("#0.########");
            }

            TotalLatentHeat = 0;

            if (SeatedP != 0)
                TotalLatentHeat += Seated * (SeatedP / 100);
            if (SeatedVeLightP != 0)
                TotalLatentHeat += SeatedVeLight * (SeatedVeLightP / 100);
            if (OffWorkP != 0)
                TotalLatentHeat += OffWork * (OffWorkP / 100);
            if (LabWorkP != 0)
                TotalLatentHeat += LabWork * (LabWorkP / 100);
            if (WalkSeaP != 0)
                TotalLatentHeat += WalkSea * (WalkSeaP / 100);
            if (ModWorkP != 0)
                TotalLatentHeat += ModWork * (ModWorkP / 100);
            if (LigBenWorkP != 0)
                TotalLatentHeat += LigBenWork * (LigBenWorkP / 100);
            if (ModDanceP != 0)
                TotalLatentHeat += ModDance * (ModDanceP / 100);
            if (FastWalkP != 0)
                TotalLatentHeat += FastWalk * (FastWalkP / 100);
            if (HeaWorkP != 0)
                TotalLatentHeat += HeaWork * (HeaWorkP / 100);

            txt_TotalLatentHeat.Text = TotalLatentHeat.ToString("#0.########");

            TotalLatentHeat = double.Parse(txt_TotalLatentHeat.Text);

            HeadcountE = double.Parse(txt_HeadcountE.Text);

            txt_SubtotalLatHeat.Text = (TotalLatentHeat * HeadcountE).ToString("#0.########");

            SubtotalLatHeat = double.Parse(txt_SubtotalLatHeat.Text);

            txt_HeatGaPeople.Text = (SubtotalLatHeat / 3412).ToString("#0.########");

            #endregion

            #region  Latent humidity gain from building

            VolumeE = double.Parse(txt_VolumeE.Text);

            txt_VolumeLate.Text = VolumeE.ToString("#0.########");

            HumityRadioGRB = double.Parse(txt_HumityRadioGRB.Text);

            HumityRadioGRA = double.Parse(txt_HumityRadioGRA.Text);

            txt_HumDiff.Text = (HumityRadioGRB - HumityRadioGRA).ToString("#0.########");

            HumDiff = double.Parse(txt_HumDiff.Text);

            txt_HumityFact.Text = ((HumDiff - 35) / 42.5 + 1).ToString("#0.########");

            VolumeLate = double.Parse(txt_VolumeLate.Text);

            HumityFact = double.Parse(txt_HumityFact.Text);

            VolumeFact = double.Parse(txt_VolumeFact.Text);

            ConstructionFact = double.Parse(txt_ConstructionFact.Text);

            VaporFact = double.Parse(txt_VaporFact.Text);

            txt_HumGainGR.Text = (VolumeLate / 14 * HumDiff * HumityFact * VolumeFact * ConstructionFact * VaporFact).ToString("#0.########");

            HumGainGR = double.Parse(txt_HumGainGR.Text);

            txt_HumGainLB.Text = (HumGainGR / 7000).ToString("#0.########");

            HumGainLB = double.Parse(txt_HumGainLB.Text);

            VapoHeat = double.Parse(txt_VapoHeat.Text);

            txt_SubtotalHumidity.Text = (HumGainLB * VapoHeat).ToString("#0.########");

            SubtotalHumidity = double.Parse(txt_SubtotalHumidity.Text);

            txt_HumHeatGain.Text = (SubtotalHumidity / 3412).ToString("#0.########");

            HeatGaPeople = double.Parse(txt_HeatGaPeople.Text);

            HumHeatGain = double.Parse(txt_HumHeatGain.Text);

            lbl_TotalLatentHeatKW.Text = (HeatGaPeople + HumHeatGain).ToString("#0.########");

            TotalLatentHeatKW = double.Parse(lbl_TotalLatentHeatKW.Text);

            lbl_TotalLatentHeatBTU.Text = (TotalLatentHeatKW * 3412).ToString("#0.########");


            #endregion
        }

        ///<summary>
        ///Carga la informacion de la seccion de General Info
        ///</summary>
        public void CargarGeneralInfo()
        {

            #region Design Conditions

            DryBulbA = double.Parse(txt_DryBulbA.Text);

            Relative = double.Parse(txt_Relative.Text);

            Elevation = double.Parse(txt_Elevation.Text);

           // txt_WetBulbA.Text = Utilities.Formulas.WbtHR(DryBulbA, (Relative / 100), Elevation).ToString("#.##");

            WetBulbA = double.Parse(txt_WetBulbA.Text);

            txt_Enthalpy.Text = Utilities.Formulas.ENT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

            txt_HumityRadioA.Text = Utilities.Formulas.HUMRAT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

            txt_Density.Text = Utilities.Formulas.DENS(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

            HumityRadioA = double.Parse(txt_HumityRadioA.Text);

            #endregion

            #region Outside Conditions

            txt_HumityRadioGRA.Text = (HumityRadioA * 7000).ToString("#0.########");

            DryBulbB = double.Parse(txt_DryBulbB.Text);

            WetBuilB = double.Parse(txt_WetBuilB.Text);

            txt_HumityRadioB.Text = Utilities.Formulas.HUMRAT(DryBulbB, WetBuilB, Elevation).ToString("#0.########");

            HumityRadioB = double.Parse(txt_HumityRadioB.Text);

            txt_HumityRadioGRB.Text = (HumityRadioB * 7000).ToString("#0.########");

            #endregion

            #region Dimensions

            LenghtM = double.Parse(txt_LenghtM.Text);

            WidthM = double.Parse(txt_WidthM.Text);

            txt_FloorAreaM.Text = (LenghtM * WidthM).ToString("#0.#####");

            FloorAreaM = double.Parse(txt_FloorAreaM.Text);

            AvgCeilingM = double.Parse(txt_AvgCeilingM.Text);

            txt_WallAreaM.Text = (AvgCeilingM * 2 * (LenghtM + WidthM)).ToString("#0.#####");

            txt_VolumeM.Text = (FloorAreaM * AvgCeilingM).ToString("#0.#####");

            txt_LenghtE.Text = (LenghtM * 3.28).ToString("#0.#####");

            txt_WidthE.Text = (WidthM * 3.28).ToString("#0.#####");

            txt_AvgCeilingE.Text = (AvgCeilingM * 3.28).ToString("#0.#####");

            txt_FloorAreaE.Text = (FloorAreaM * Math.Pow(3.28, 2)).ToString("#0.#####");

            WallAreaM = double.Parse(txt_WallAreaM.Text);

            txt_WallAreaE.Text = (WallAreaM * Math.Pow(3.28, 2)).ToString("#0.#####");

            VolumeM = double.Parse(txt_VolumeM.Text);

            txt_VolumeE.Text = (VolumeM * 35.31).ToString("#0.#####");

            #endregion
        }

        ///<summary>
        ///Carga la informacion de la seccion de Outside Air
        ///</summary>
        public void CargarOutsideAir()
        {
            DesignDiffWG = double.Parse(txt_DesignDiffWG.Text);

            txt_DesignDiffPA.Text = (DesignDiffWG * 248.84).ToString("#0.########");

            txt_ProcessExhaust.Text = (320 * 21).ToString("#0.########");

            LeakArea = double.Parse(txt_DesignDiffWG.Text);
            LeakLeakArea = double.Parse(txt_LeakLeakArea.Text);
            //DesignDiffWG = double.Parse(txt_DesignDiffWG.Text);
            LeakLoss = double.Parse(txt_LeakLoss.Text);

            // txt_LeakFlow.Text = Math.Pow((4005 * LeakArea * LeakLeakArea * (DesignDiffWG / LeakLoss)), 0.5).ToString("#0.########");

            RegularArea = double.Parse(txt_RegularArea.Text);
            RegularLeak = double.Parse(txt_RegularLeak.Text);
            //DesignDiffWG = double.Parse(txt_DesignDiffWG.Text);
            RegularLoss = double.Parse(txt_DesignDiffWG.Text);

            //  txt_RegularFlow.Text = Math.Pow((4005 * RegularArea * RegularLeak * (DesignDiffWG / RegularLoss)), 0.5).ToString("#0.########");

            AverageArea = double.Parse(txt_AverageArea.Text);
            AverageLeak = double.Parse(txt_AverageLeak.Text);
            //DesignDiffWG = double.Parse(txt_DesignDiffWG.Text);
            AverageLoss = double.Parse(txt_AverageLoss.Text);

            //  txt_AverageFlow.Text = Math.Pow((4005 * AverageArea * AverageLeak * (DesignDiffWG / AverageLoss)), 0.5).ToString("#0.########");

            GoodArea = double.Parse(txt_GoodArea.Text);
            GoodLeak = double.Parse(txt_GoodLeak.Text);
            //DesignDiffWG = double.Parse(txt_DesignDiffWG.Text);
            GoodLoss = double.Parse(txt_GoodLoss.Text);

            //  txt_GoodFlow.Text = Math.Pow((4005 * GoodArea * GoodLeak * (DesignDiffWG / GoodLoss)), 0.5).ToString("#0.########");

            TightArea = double.Parse(txt_TightArea.Text);
            TightLeak = double.Parse(txt_TightLeak.Text);
            //DesignDiffWG = double.Parse(txt_DesignDiffWG.Text);
            TightLoss = double.Parse(txt_TightLoss.Text);

            //  txt_TightFlow.Text = Math.Pow((4005 * TightArea * TightLeak * (DesignDiffWG / TightLoss)), 0.5).ToString("#0.########");

            LeakFlow = double.Parse(txt_LeakFlow.Text);
            RegularFlow = double.Parse(txt_RegularFlow.Text);
            AverageFlow = double.Parse(txt_AverageFlow.Text);
            GoodFlow = double.Parse(txt_GoodFlow.Text);
            TightFlow = double.Parse(txt_TightFlow.Text);

            //  txt_LeaksDueBuilding.Text = (LeakFlow + RegularFlow + AverageFlow + GoodFlow + TightFlow).ToString("#0.########");

            Qty1 = double.Parse(txt_Qty1.Text);
            LeakA1 = double.Parse(txt_LeakA1.Text);
            Loss1 = double.Parse(txt_Loss1.Text);

            //  txt_Flow1.Text = Math.Pow((Qty1 * 4005 * LeakA1 * (DesignDiffWG / Loss1)), 0.5).ToString("#0.########");

            Qty2 = double.Parse(txt_Qty2.Text);
            LeakA2 = double.Parse(txt_LeakA2.Text);
            Loss2 = double.Parse(txt_Loss2.Text);

            //  txt_Flow2.Text = Math.Pow((Qty2 * 4005 * LeakA2 * (DesignDiffWG / Loss2)), 0.5).ToString("#0.########");

            Qty3 = double.Parse(txt_Qty3.Text);
            LeakA3 = double.Parse(txt_LeakA3.Text);
            Loss3 = double.Parse(txt_Loss3.Text);

            // txt_Flow3.Text = Math.Pow((Qty3 * 4005 * LeakA3 * (DesignDiffWG / Loss3)), 0.5).ToString("#0.########");

            Qty4 = double.Parse(txt_Qty4.Text);
            LeakA4 = double.Parse(txt_LeakA4.Text);
            Loss4 = double.Parse(txt_Loss4.Text);

            //  txt_Flow4.Text = Math.Pow((Qty4 * 4005 * LeakA4 * (DesignDiffWG / Loss4)), 0.5).ToString("#0.########");

            Qty5 = double.Parse(txt_Qty5.Text);
            LeakA5 = double.Parse(txt_LeakA5.Text);
            Loss5 = double.Parse(txt_Loss5.Text);

            //  txt_Flow5.Text = Math.Pow((Qty5 * 4005 * LeakA5 * (DesignDiffWG / Loss5)), 0.5).ToString("#0.########");

            Flow1 = double.Parse(txt_Flow1.Text);
            Flow2 = double.Parse(txt_Flow2.Text);
            Flow3 = double.Parse(txt_Flow3.Text);
            Flow4 = double.Parse(txt_Flow4.Text);
            Flow5 = double.Parse(txt_Flow5.Text);

            // txt_LeaksDueDoors.Text = (Flow1 + Flow2 + Flow3 + Flow4 + Flow5).ToString("#0.########");

            ProcessExhaust = double.Parse(txt_ProcessExhaust.Text);
            LeaksDueBuilding = double.Parse(txt_LeaksDueBuilding.Text);
            LeaksDueDoors = double.Parse(txt_LeaksDueDoors.Text);
            GeneralExhaust = double.Parse(txt_GeneralExhaust.Text);

            txt_OSATotal.Text = (ProcessExhaust + LeaksDueBuilding + LeaksDueDoors + GeneralExhaust).ToString("#0.########");

            HeadcountD = double.Parse(txt_HeadcountD.Text);

            txt_VentHeadCount.Text = HeadcountD.ToString("#0.########");

            VentHeadCount = double.Parse(txt_VentHeadCount.Text);
            UnitaryVentReq = double.Parse(txt_UnitaryVentReq.Text);

            txt_VentilationReq.Text = (VentHeadCount * UnitaryVentReq).ToString("#0.########");

            VentilationReq = double.Parse(txt_VentilationReq.Text);

            OSATotal = double.Parse(txt_OSATotal.Text);

            //IF(C37>=C42,"YES","NO, Increase General Exhaust")
            if (OSATotal >= VentilationReq)
            {
                lbl_VentilationReq.Text = "YES";
            }
            else
            {
                lbl_VentilationReq.Text = "NO, Increase General Exhaust";
            }
        }

        ///<summary>
        ///Carga la informacion de la seccion de Particle Concentration
        ///</summary>
        public void ParticleConcentration()
        {
            AvgCeilingE = double.Parse(txt_AvgCeilingE.Text);

            txt_EnviHeight.Text = AvgCeilingE.ToString("#0.########");

            WidthE = double.Parse(txt_WidthE.Text);

            txt_EnviWidth.Text = WidthE.ToString("#0.########");

            LenghtE = double.Parse(txt_LenghtE.Text);

            txt_EnviLenght.Text = LenghtE.ToString("#0.########");

            EnviHeight = double.Parse(txt_EnviHeight.Text);
            EnviWidth = double.Parse(txt_EnviWidth.Text);
            EnviLenght = double.Parse(txt_EnviLenght.Text);

            txt_EnviVolume.Text = (EnviLenght * EnviWidth * EnviHeight).ToString("#0.########");

            txt_HeadCountOccu.Text = HeadcountD.ToString("#0.########");


            Motionless = double.Parse(txt_Motionless.Text);
            HeadArm = double.Parse(txt_HeadArm.Text);
            FoodMotion = double.Parse(txt_FoodMotion.Text);
            StandSit = double.Parse(txt_StandSit.Text);
            Walk20 = double.Parse(txt_Walk20.Text);
            Walk35 = double.Parse(txt_Walk35.Text);
            Walk50 = double.Parse(txt_Walk50.Text);

            MotionlessP = double.Parse(txt_MotionlessP.Text);
            HeadArmP = double.Parse(txt_HeadArmP.Text);
            FoodMotionP = double.Parse(txt_FoodMotionP.Text);
            StandSitP = double.Parse(txt_StandSitP.Text);
            Walk20P = double.Parse(txt_Walk20P.Text);
            Walk35P = double.Parse(txt_Walk35P.Text);
            Walk50P = double.Parse(txt_Walk50P.Text);

            WeiAverageP = MotionlessP + HeadArmP + FoodMotionP + StandSitP + Walk20P + Walk35P + Walk50P;

            if (WeiAverageP < 100)
            {
                txt_WeiAverageP.Text = "Must Add 100 %";
            }
            else
            {
                txt_WeiAverageP.Text = WeiAverageP.ToString("#0.########");
            }

            WeiAverage = 0;

            if (MotionlessP != 0)
                WeiAverage += Motionless * (MotionlessP / 100);
            if (HeadArmP != 0)
                WeiAverage += HeadArm * (HeadArmP / 100);
            if (FoodMotionP != 0)
                WeiAverage += FoodMotion * (FoodMotionP / 100);
            if (StandSitP != 0)
                WeiAverage += StandSit * (StandSitP / 100);
            if (Walk20P != 0)
                WeiAverage += Walk20 * (Walk20P / 100);
            if (Walk35P != 0)
                WeiAverage += Walk35 * (Walk35P / 100);
            if (Walk50P != 0)
                WeiAverage += Walk50 * (Walk50P / 100);

            txt_WeiAverage.Text = WeiAverage.ToString("#0.########");

            HeadCountOccu = double.Parse(txt_HeadCountOccu.Text);

            WeiAverage = double.Parse(txt_WeiAverage.Text);

            txt_PartGenDueOccu.Text = (HeadCountOccu * WeiAverage).ToString("#0.########");

            PartGenDueOccu = double.Parse(txt_PartGenDueOccu.Text);

            txt_PartGenDueBuild.Text = (0.1 * PartGenDueOccu).ToString("#0.########");

            txt_PartGenDueMfg.Text = (PartGenDueOccu * 0.25).ToString("#0.########");

            PartGenDueBuild = double.Parse(txt_PartGenDueBuild.Text);
            PartGenDueMfg = double.Parse(txt_PartGenDueMfg.Text);

            txt_TotalPartGenDue.Text = (PartGenDueOccu + PartGenDueBuild + PartGenDueMfg).ToString("#0.########");

            EnviVolume = double.Parse(txt_EnviVolume.Text);
            AirChange = double.Parse(txt_AirChange.Text);

            txt_AirFlow.Text = (EnviVolume * AirChange / 60).ToString("#0.########");

            CargarInfoTabPCGraphic();

            ParticleConcentrationGraphic();

            nombreAvgParticle = string.Concat("txt_PartConEndPer", txt_AirDistRecovery.Text);

            TextBox tbx = this.Controls.Find(nombreAvgParticle, true)[0] as TextBox;

            txt_AvgPartConc.Text = tbx.Text;

            AirDistMax = double.Parse(txt_AirDistMax.Text);

            AvgPartConc = double.Parse(txt_AvgPartConc.Text);

            txt_MaxPartConc.Text = (AirDistMax * AvgPartConc).ToString("#0.########");

        }

        public void ParticleConcentrationGraphic()
        {
            AirFlow = double.Parse(txt_AirFlow.Text);
            AirFilter = double.Parse(txt_AirFilter.Text);
            TotalPartGenDue = double.Parse(txt_TotalPartGenDue.Text);
            EnviVolume = double.Parse(txt_EnviVolume.Text);
            AirDistVentilation = double.Parse(txt_AirDistVentilation.Text);

            //TIME 00:00
            PartConBeg1 = double.Parse(txt_PartConBeg1.Text);

            txt_PartIncome1.Text = (AirFlow * PartConBeg1 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen1.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount1.Text = (PartConBeg1 * EnviVolume).ToString("#0.########");

            txt_PartGoing1.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg1 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg1 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount1 = double.Parse(txt_PartCount1.Text);

            PartGen1 = double.Parse(txt_PartGen1.Text);

            PartIncome1 = double.Parse(txt_PartIncome1.Text);

            PartGoing1 = double.Parse(txt_PartGoing1.Text);

            txt_PartCountEnd1.Text = (PartCount1 + PartGen1 + PartIncome1 - PartGoing1).ToString("#0.########");

            PartCountEnd1 = double.Parse(txt_PartCountEnd1.Text);

            txt_PartConEndPer1.Text = (PartCountEnd1 / EnviVolume).ToString("#0.########");

            //TIME 00:01

            PartConEndPer1 = double.Parse(txt_PartConEndPer1.Text);

            txt_PartConBeg2.Text = PartConEndPer1.ToString("#0.########");

            PartConBeg2 = double.Parse(txt_PartConBeg2.Text);

            txt_PartIncome2.Text = (AirFlow * PartConBeg2 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen2.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount2.Text = (PartConBeg2 * EnviVolume).ToString("#0.########");

            txt_PartGoing2.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg2 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg2 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount2 = double.Parse(txt_PartCount2.Text);

            PartGen2 = double.Parse(txt_PartGen2.Text);

            PartIncome2 = double.Parse(txt_PartIncome2.Text);

            PartGoing2 = double.Parse(txt_PartGoing2.Text);

            txt_PartCountEnd2.Text = (PartCount2 + PartGen2 + PartIncome2 - PartGoing2).ToString("#0.########");

            PartCountEnd2 = double.Parse(txt_PartCountEnd2.Text);

            txt_PartConEndPer2.Text = (PartCountEnd2 / EnviVolume).ToString("#0.########");

            //TIME 00:02

            PartConEndPer2 = double.Parse(txt_PartConEndPer2.Text);

            txt_PartConBeg3.Text = PartConEndPer2.ToString("#0.########");

            PartConBeg3 = double.Parse(txt_PartConBeg3.Text);

            txt_PartIncome3.Text = (AirFlow * PartConBeg3 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen3.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount3.Text = (PartConBeg3 * EnviVolume).ToString("#0.########");

            txt_PartGoing3.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg3 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg3 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount3 = double.Parse(txt_PartCount3.Text);

            PartGen3 = double.Parse(txt_PartGen3.Text);

            PartIncome3 = double.Parse(txt_PartIncome3.Text);

            PartGoing3 = double.Parse(txt_PartGoing3.Text);

            txt_PartCountEnd3.Text = (PartCount3 + PartGen3 + PartIncome3 - PartGoing3).ToString("#0.########");

            PartCountEnd3 = double.Parse(txt_PartCountEnd3.Text);

            txt_PartConEndPer3.Text = (PartCountEnd3 / EnviVolume).ToString("#0.########");

            //TIME 00:03

            PartConEndPer3 = double.Parse(txt_PartConEndPer3.Text);

            txt_PartConBeg4.Text = PartConEndPer3.ToString("#0.########");

            PartConBeg4 = double.Parse(txt_PartConBeg4.Text);

            txt_PartIncome4.Text = (AirFlow * PartConBeg4 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen4.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount4.Text = (PartConBeg4 * EnviVolume).ToString("#0.########");

            txt_PartGoing4.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg4 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg4 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount4 = double.Parse(txt_PartCount4.Text);

            PartGen4 = double.Parse(txt_PartGen4.Text);

            PartIncome4 = double.Parse(txt_PartIncome4.Text);

            PartGoing4 = double.Parse(txt_PartGoing4.Text);

            txt_PartCountEnd4.Text = (PartCount4 + PartGen4 + PartIncome4 - PartGoing4).ToString("#0.########");

            PartCountEnd4 = double.Parse(txt_PartCountEnd4.Text);

            txt_PartConEndPer4.Text = (PartCountEnd4 / EnviVolume).ToString("#0.########");

            //TIME 00:04

            PartConEndPer4 = double.Parse(txt_PartConEndPer4.Text);

            txt_PartConBeg5.Text = PartConEndPer4.ToString("#0.########");

            PartConBeg5 = double.Parse(txt_PartConBeg5.Text);

            txt_PartIncome5.Text = (AirFlow * PartConBeg5 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen5.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount5.Text = (PartConBeg5 * EnviVolume).ToString("#0.########");

            txt_PartGoing5.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg5 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg5 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount5 = double.Parse(txt_PartCount5.Text);

            PartGen5 = double.Parse(txt_PartGen5.Text);

            PartIncome5 = double.Parse(txt_PartIncome5.Text);

            PartGoing5 = double.Parse(txt_PartGoing5.Text);

            txt_PartCountEnd5.Text = (PartCount5 + PartGen5 + PartIncome5 - PartGoing5).ToString("#0.########");

            PartCountEnd5 = double.Parse(txt_PartCountEnd5.Text);

            txt_PartConEndPer5.Text = (PartCountEnd5 / EnviVolume).ToString("#0.########");

            //TIME 00:05

            PartConEndPer5 = double.Parse(txt_PartConEndPer5.Text);

            txt_PartConBeg6.Text = PartConEndPer5.ToString("#0.########");

            PartConBeg6 = double.Parse(txt_PartConBeg6.Text);

            txt_PartIncome6.Text = (AirFlow * PartConBeg6 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen6.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount6.Text = (PartConBeg6 * EnviVolume).ToString("#0.########");

            txt_PartGoing6.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg6 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg6 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount6 = double.Parse(txt_PartCount6.Text);

            PartGen6 = double.Parse(txt_PartGen6.Text);

            PartIncome6 = double.Parse(txt_PartIncome6.Text);

            PartGoing6 = double.Parse(txt_PartGoing6.Text);

            txt_PartCountEnd6.Text = (PartCount6 + PartGen6 + PartIncome6 - PartGoing6).ToString("#0.########");

            PartCountEnd6 = double.Parse(txt_PartCountEnd6.Text);

            txt_PartConEndPer6.Text = (PartCountEnd6 / EnviVolume).ToString("#0.########");

            //TIME 00:06

            PartConEndPer6 = double.Parse(txt_PartConEndPer6.Text);

            txt_PartConBeg7.Text = PartConEndPer6.ToString("#0.########");

            PartConBeg7 = double.Parse(txt_PartConBeg7.Text);

            txt_PartIncome7.Text = (AirFlow * PartConBeg7 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen7.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount7.Text = (PartConBeg7 * EnviVolume).ToString("#0.########");

            txt_PartGoing7.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg7 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg7 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount7 = double.Parse(txt_PartCount7.Text);

            PartGen7 = double.Parse(txt_PartGen7.Text);

            PartIncome7 = double.Parse(txt_PartIncome7.Text);

            PartGoing7 = double.Parse(txt_PartGoing7.Text);

            txt_PartCountEnd7.Text = (PartCount7 + PartGen7 + PartIncome7 - PartGoing7).ToString("#0.########");

            PartCountEnd7 = double.Parse(txt_PartCountEnd7.Text);

            txt_PartConEndPer7.Text = (PartCountEnd7 / EnviVolume).ToString("#0.########");

            //TIME 00:07

            PartConEndPer7 = double.Parse(txt_PartConEndPer7.Text);

            txt_PartConBeg8.Text = PartConEndPer7.ToString("#0.########");

            PartConBeg8 = double.Parse(txt_PartConBeg8.Text);

            txt_PartIncome8.Text = (AirFlow * PartConBeg8 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen8.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount8.Text = (PartConBeg8 * EnviVolume).ToString("#0.########");

            txt_PartGoing8.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg8 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg8 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount8 = double.Parse(txt_PartCount8.Text);

            PartGen8 = double.Parse(txt_PartGen8.Text);

            PartIncome8 = double.Parse(txt_PartIncome8.Text);

            PartGoing8 = double.Parse(txt_PartGoing8.Text);

            txt_PartCountEnd8.Text = (PartCount8 + PartGen8 + PartIncome8 - PartGoing8).ToString("#0.########");

            PartCountEnd8 = double.Parse(txt_PartCountEnd8.Text);

            txt_PartConEndPer8.Text = (PartCountEnd8 / EnviVolume).ToString("#0.########");

            //TIME 00:08

            PartConEndPer8 = double.Parse(txt_PartConEndPer8.Text);

            txt_PartConBeg9.Text = PartConEndPer8.ToString("#0.########");

            PartConBeg9 = double.Parse(txt_PartConBeg9.Text);

            txt_PartIncome9.Text = (AirFlow * PartConBeg9 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen9.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount9.Text = (PartConBeg9 * EnviVolume).ToString("#0.########");

            txt_PartGoing9.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg9 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg9 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount9 = double.Parse(txt_PartCount9.Text);

            PartGen9 = double.Parse(txt_PartGen9.Text);

            PartIncome9 = double.Parse(txt_PartIncome9.Text);

            PartGoing9 = double.Parse(txt_PartGoing9.Text);

            txt_PartCountEnd9.Text = (PartCount9 + PartGen9 + PartIncome9 - PartGoing9).ToString("#0.########");

            PartCountEnd9 = double.Parse(txt_PartCountEnd9.Text);

            txt_PartConEndPer9.Text = (PartCountEnd9 / EnviVolume).ToString("#0.########");

            //TIME 00:09

            PartConEndPer9 = double.Parse(txt_PartConEndPer9.Text);

            txt_PartConBeg10.Text = PartConEndPer9.ToString("#0.########");

            PartConBeg10 = double.Parse(txt_PartConBeg10.Text);

            txt_PartIncome10.Text = (AirFlow * PartConBeg10 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen10.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount10.Text = (PartConBeg10 * EnviVolume).ToString("#0.########");

            txt_PartGoing10.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg10 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg10 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount10 = double.Parse(txt_PartCount10.Text);

            PartGen10 = double.Parse(txt_PartGen10.Text);

            PartIncome10 = double.Parse(txt_PartIncome10.Text);

            PartGoing10 = double.Parse(txt_PartGoing10.Text);

            txt_PartCountEnd10.Text = (PartCount10 + PartGen10 + PartIncome10 - PartGoing10).ToString("#0.########");

            PartCountEnd10 = double.Parse(txt_PartCountEnd10.Text);

            txt_PartConEndPer10.Text = (PartCountEnd10 / EnviVolume).ToString("#0.########");

            //TIME 00:10

            PartConEndPer10 = double.Parse(txt_PartConEndPer10.Text);

            txt_PartConBeg11.Text = PartConEndPer10.ToString("#0.########");

            PartConBeg11 = double.Parse(txt_PartConBeg11.Text);

            txt_PartIncome11.Text = (AirFlow * PartConBeg11 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen11.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount11.Text = (PartConBeg11 * EnviVolume).ToString("#0.########");

            txt_PartGoing11.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg11 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg11 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount11 = double.Parse(txt_PartCount11.Text);

            PartGen11 = double.Parse(txt_PartGen11.Text);

            PartIncome11 = double.Parse(txt_PartIncome11.Text);

            PartGoing11 = double.Parse(txt_PartGoing11.Text);

            txt_PartCountEnd11.Text = (PartCount11 + PartGen11 + PartIncome11 - PartGoing11).ToString("#0.########");

            PartCountEnd11 = double.Parse(txt_PartCountEnd11.Text);

            txt_PartConEndPer11.Text = (PartCountEnd11 / EnviVolume).ToString("#0.########");

            //TIME 00:11

            PartConEndPer11 = double.Parse(txt_PartConEndPer11.Text);

            txt_PartConBeg12.Text = PartConEndPer11.ToString("#0.########");

            PartConBeg12 = double.Parse(txt_PartConBeg12.Text);

            txt_PartIncome12.Text = (AirFlow * PartConBeg12 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen12.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount12.Text = (PartConBeg12 * EnviVolume).ToString("#0.########");

            txt_PartGoing12.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg12 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg12 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount12 = double.Parse(txt_PartCount12.Text);

            PartGen12 = double.Parse(txt_PartGen12.Text);

            PartIncome12 = double.Parse(txt_PartIncome12.Text);

            PartGoing12 = double.Parse(txt_PartGoing12.Text);

            txt_PartCountEnd12.Text = (PartCount12 + PartGen12 + PartIncome12 - PartGoing12).ToString("#0.########");

            PartCountEnd12 = double.Parse(txt_PartCountEnd12.Text);

            txt_PartConEndPer12.Text = (PartCountEnd12 / EnviVolume).ToString("#0.########");

            //TIME 00:12

            PartConEndPer12 = double.Parse(txt_PartConEndPer12.Text);

            txt_PartConBeg13.Text = PartConEndPer12.ToString("#0.########");

            PartConBeg13 = double.Parse(txt_PartConBeg13.Text);

            txt_PartIncome13.Text = (AirFlow * PartConBeg13 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen13.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount13.Text = (PartConBeg13 * EnviVolume).ToString("#0.########");

            txt_PartGoing13.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg13 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg13 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount13 = double.Parse(txt_PartCount13.Text);

            PartGen13 = double.Parse(txt_PartGen13.Text);

            PartIncome13 = double.Parse(txt_PartIncome13.Text);

            PartGoing13 = double.Parse(txt_PartGoing13.Text);

            txt_PartCountEnd13.Text = (PartCount13 + PartGen13 + PartIncome13 - PartGoing13).ToString("#0.########");

            PartCountEnd13 = double.Parse(txt_PartCountEnd13.Text);

            txt_PartConEndPer13.Text = (PartCountEnd13 / EnviVolume).ToString("#0.########");

            //TIME 00:13

            PartConEndPer13 = double.Parse(txt_PartConEndPer13.Text);

            txt_PartConBeg14.Text = PartConEndPer13.ToString("#0.########");

            PartConBeg14 = double.Parse(txt_PartConBeg14.Text);

            txt_PartIncome14.Text = (AirFlow * PartConBeg14 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen14.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount14.Text = (PartConBeg14 * EnviVolume).ToString("#0.########");

            txt_PartGoing14.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg14 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg14 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount14 = double.Parse(txt_PartCount14.Text);

            PartGen14 = double.Parse(txt_PartGen14.Text);

            PartIncome14 = double.Parse(txt_PartIncome14.Text);

            PartGoing14 = double.Parse(txt_PartGoing14.Text);

            txt_PartCountEnd14.Text = (PartCount14 + PartGen14 + PartIncome14 - PartGoing14).ToString("#0.########");

            PartCountEnd14 = double.Parse(txt_PartCountEnd14.Text);

            txt_PartConEndPer14.Text = (PartCountEnd14 / EnviVolume).ToString("#0.########");

            //TIME 00:14

            PartConEndPer14 = double.Parse(txt_PartConEndPer14.Text);

            txt_PartConBeg15.Text = PartConEndPer14.ToString("#0.########");

            PartConBeg15 = double.Parse(txt_PartConBeg15.Text);

            txt_PartIncome15.Text = (AirFlow * PartConBeg15 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen15.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount15.Text = (PartConBeg15 * EnviVolume).ToString("#0.########");

            txt_PartGoing15.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg15 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg15 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount15 = double.Parse(txt_PartCount15.Text);

            PartGen15 = double.Parse(txt_PartGen15.Text);

            PartIncome15 = double.Parse(txt_PartIncome15.Text);

            PartGoing15 = double.Parse(txt_PartGoing15.Text);

            txt_PartCountEnd15.Text = (PartCount15 + PartGen15 + PartIncome15 - PartGoing15).ToString("#0.########");

            PartCountEnd15 = double.Parse(txt_PartCountEnd15.Text);

            txt_PartConEndPer15.Text = (PartCountEnd15 / EnviVolume).ToString("#0.########");

            //TIME 00:15

            PartConEndPer15 = double.Parse(txt_PartConEndPer15.Text);

            txt_PartConBeg16.Text = PartConEndPer15.ToString("#0.########");

            PartConBeg16 = double.Parse(txt_PartConBeg16.Text);

            txt_PartIncome16.Text = (AirFlow * PartConBeg16 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen16.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount16.Text = (PartConBeg16 * EnviVolume).ToString("#0.########");

            txt_PartGoing16.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg16 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg16 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount16 = double.Parse(txt_PartCount16.Text);

            PartGen16 = double.Parse(txt_PartGen16.Text);

            PartIncome16 = double.Parse(txt_PartIncome16.Text);

            PartGoing16 = double.Parse(txt_PartGoing16.Text);

            txt_PartCountEnd16.Text = (PartCount16 + PartGen16 + PartIncome16 - PartGoing16).ToString("#0.########");

            PartCountEnd16 = double.Parse(txt_PartCountEnd16.Text);

            txt_PartConEndPer16.Text = (PartCountEnd16 / EnviVolume).ToString("#0.########");

            //TIME 00:16

            PartConEndPer16 = double.Parse(txt_PartConEndPer16.Text);

            txt_PartConBeg17.Text = PartConEndPer16.ToString("#0.########");

            PartConBeg17 = double.Parse(txt_PartConBeg17.Text);

            txt_PartIncome17.Text = (AirFlow * PartConBeg17 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen17.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount17.Text = (PartConBeg17 * EnviVolume).ToString("#0.########");

            txt_PartGoing17.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg17 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg17 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount17 = double.Parse(txt_PartCount17.Text);

            PartGen17 = double.Parse(txt_PartGen17.Text);

            PartIncome17 = double.Parse(txt_PartIncome17.Text);

            PartGoing17 = double.Parse(txt_PartGoing17.Text);

            txt_PartCountEnd17.Text = (PartCount17 + PartGen17 + PartIncome17 - PartGoing17).ToString("#0.########");

            PartCountEnd17 = double.Parse(txt_PartCountEnd17.Text);

            txt_PartConEndPer17.Text = (PartCountEnd17 / EnviVolume).ToString("#0.########");

            //TIME 00:17

            PartConEndPer17 = double.Parse(txt_PartConEndPer17.Text);

            txt_PartConBeg18.Text = PartConEndPer17.ToString("#0.########");

            PartConBeg18 = double.Parse(txt_PartConBeg18.Text);

            txt_PartIncome18.Text = (AirFlow * PartConBeg18 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen18.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount18.Text = (PartConBeg18 * EnviVolume).ToString("#0.########");

            txt_PartGoing18.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg18 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg18 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount18 = double.Parse(txt_PartCount18.Text);

            PartGen18 = double.Parse(txt_PartGen18.Text);

            PartIncome18 = double.Parse(txt_PartIncome18.Text);

            PartGoing18 = double.Parse(txt_PartGoing18.Text);

            txt_PartCountEnd18.Text = (PartCount18 + PartGen18 + PartIncome18 - PartGoing18).ToString("#0.########");

            PartCountEnd18 = double.Parse(txt_PartCountEnd18.Text);

            txt_PartConEndPer18.Text = (PartCountEnd18 / EnviVolume).ToString("#0.########");

            //TIME 00:18

            PartConEndPer18 = double.Parse(txt_PartConEndPer18.Text);

            txt_PartConBeg19.Text = PartConEndPer18.ToString("#0.########");

            PartConBeg19 = double.Parse(txt_PartConBeg19.Text);

            txt_PartIncome19.Text = (AirFlow * PartConBeg19 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen19.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount19.Text = (PartConBeg19 * EnviVolume).ToString("#0.########");

            txt_PartGoing19.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg19 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg19 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount19 = double.Parse(txt_PartCount19.Text);

            PartGen19 = double.Parse(txt_PartGen19.Text);

            PartIncome19 = double.Parse(txt_PartIncome19.Text);

            PartGoing19 = double.Parse(txt_PartGoing19.Text);

            txt_PartCountEnd19.Text = (PartCount19 + PartGen19 + PartIncome19 - PartGoing19).ToString("#0.########");

            PartCountEnd19 = double.Parse(txt_PartCountEnd19.Text);

            txt_PartConEndPer19.Text = (PartCountEnd19 / EnviVolume).ToString("#0.########");

            //TIME 00:19

            PartConEndPer19 = double.Parse(txt_PartConEndPer19.Text);

            txt_PartConBeg20.Text = PartConEndPer19.ToString("#0.########");

            PartConBeg20 = double.Parse(txt_PartConBeg20.Text);

            txt_PartIncome20.Text = (AirFlow * PartConBeg20 * (1 - (AirFilter / 100))).ToString("#0.########");

            txt_PartGen20.Text = TotalPartGenDue.ToString("#0.########");

            txt_PartCount20.Text = (PartConBeg20 * EnviVolume).ToString("#0.########");

            txt_PartGoing20.Text = (AirFlow * (AirDistVentilation / 100) * PartConBeg20 + AirFlow * (1 - (AirDistVentilation / 100)) * PartConBeg20 * (1 - (AirFilter / 100))).ToString("#0.########");

            PartCount20 = double.Parse(txt_PartCount20.Text);

            PartGen20 = double.Parse(txt_PartGen20.Text);

            PartIncome20 = double.Parse(txt_PartIncome20.Text);

            PartGoing20 = double.Parse(txt_PartGoing20.Text);

            txt_PartCountEnd20.Text = (PartCount20 + PartGen20 + PartIncome20 - PartGoing20).ToString("#0.########");

            PartCountEnd20 = double.Parse(txt_PartCountEnd20.Text);

            txt_PartConEndPer20.Text = (PartCountEnd20 / EnviVolume).ToString("#0.########");

            PartConEndPer20 = double.Parse(txt_PartConEndPer20.Text);


        }

        public void MakeUpPrecooling()
        {
            txt_ElevationMAH.Text = Elevation.ToString("#0.########");

            txt_OSADBT.Text = DryBulbB.ToString("#0.########");

            OSADBT = double.Parse(txt_OSADBT.Text);

            OSAWBT = double.Parse(txt_OSAWBT.Text);

            txt_OSAEnthalpy.Text = Utilities.Formulas.ENT(OSADBT, OSAWBT, 3200).ToString("#0.########");

            txt_OSADensity.Text = Utilities.Formulas.DENS(OSADBT, OSAWBT, 3200).ToString("#0.########");

            OSAFlow = double.Parse(txt_OSAFlow.Text);

            OSADensity = double.Parse(txt_OSADensity.Text);

            txt_OSAMass.Text = (OSAFlow * OSADensity * 60).ToString("#0.########");

            txt_OSAHumidity.Text = Utilities.Formulas.HUMRAT(OSADBT, OSAWBT, 3200).ToString("#0.########");

            PCCDBT = double.Parse(txt_PCCDBT.Text);

            //txt_PCCWBT.Text = Math.Min(Utilities.Formulas.WbtHR(PCCDBT, 0.95, 3200), OSAWBT).ToString("#0.########");

            //txt_PCCWBT.Text = "66.94";

            PCCWBT = double.Parse(txt_PCCWBT.Text);

            txt_PCCEnthalpy.Text = Utilities.Formulas.ENT(PCCDBT, PCCWBT, 3200).ToString("#0.########");

            txt_PCCHumidity.Text = Utilities.Formulas.HUMRAT(PCCDBT, PCCWBT, 3200).ToString("#0.########");

            OSAEnthalpy = double.Parse(txt_OSAEnthalpy.Text);

            PCCEnthalpy = double.Parse(txt_PCCEnthalpy.Text);

            txt_EnthalpyDiff.Text = (OSAEnthalpy - PCCEnthalpy).ToString("#0.########");

            EnthalpyDiff = double.Parse(txt_EnthalpyDiff.Text);

            OSAMass = double.Parse(txt_OSAMass.Text);

            txt_TotalMAHCool.Text = (EnthalpyDiff * OSAMass).ToString("#0.########");

            TotalMAHCool = double.Parse(txt_TotalMAHCool.Text);

            txt_TotalMAHCoolTON.Text = (TotalMAHCool / 12000).ToString("#0.########");

            txt_EnthalDiffMAH.Text = (0.24 * (OSADBT - PCCDBT)).ToString("#0.########");

            EnthalDiffMAH = double.Parse(txt_EnthalDiffMAH.Text);

            txt_MAHSensibleCooling.Text = (OSAMass * EnthalDiffMAH).ToString("#0.########");

            MAHSensibleCooling = double.Parse(txt_MAHSensibleCooling.Text);

            txt_MAHSensibleCoolingTON.Text = (MAHSensibleCooling / 12000).ToString("#0.########");

            txt_MAHLatentCooling.Text = (TotalMAHCool - MAHSensibleCooling).ToString("#0.########");

            MAHLatentCooling = double.Parse(txt_MAHLatentCooling.Text);

            txt_MAHLatentCoolingTON.Text = (MAHLatentCooling / 12000).ToString("#0.########");

        }

        public void MakeUpPrecoolingGraphic()
        {
            txt_MUP_DBT1.Text = OSADBT.ToString("#0.########");

            txt_MUP_DBT2.Text = PCCDBT.ToString("#0.########");

            OSAHumidity = double.Parse(txt_OSAHumidity.Text);

            txt_MUP_W1.Text = OSAHumidity.ToString("#0.########");

            PCCHumidity = double.Parse(txt_PCCHumidity.Text);

            txt_MUP_W2.Text = PCCHumidity.ToString("#0.########");

        }

        public void MakeUpCooling()
        {
            txt_ElevationCooling.Text = Elevation.ToString("#0.########");

            txt_PCC2DBT.Text = PCCDBT.ToString("#0.########");

            txt_PCC2WBT.Text = PCCWBT.ToString("#0.########");

            PCC2DBT = double.Parse(txt_PCC2DBT.Text);

            PCC2WBT = double.Parse(txt_PCC2WBT.Text);

            txt_PCC2Enthalpy.Text = Utilities.Formulas.ENT(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

            txt_PCC2Density.Text = Utilities.Formulas.DENS(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

            txt_PCC2Flow.Text = OSAFlow.ToString("#0.########");

            PCC2Flow = double.Parse(txt_PCC2Flow.Text);

            PCC2Density = double.Parse(txt_PCC2Density.Text);

            txt_PCC2Mass.Text = (PCC2Flow * PCC2Density * 60).ToString("#0.########");

            txt_PCC2Humidity.Text = Utilities.Formulas.HUMRAT(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

            CCDBT = double.Parse(txt_CCDBT.Text);

           // txt_CCWBT.Text = Math.Min(Utilities.Formulas.WbtHR(CCDBT, 0.95, 3200), PCC2WBT).ToString("#0.########");

            //txt_CCWBT.Text = "46.25";

            CCWBT = double.Parse(txt_CCWBT.Text);

            txt_CCEnthalpy.Text = Utilities.Formulas.ENT(CCDBT, CCWBT, 3200).ToString("#0.########");

            txt_CCHumidity.Text = Utilities.Formulas.HUMRAT(CCDBT, CCWBT, 3200).ToString("#0.########");

            PCC2Enthalpy = double.Parse(txt_PCC2Enthalpy.Text);

            CCEnthalpy = double.Parse(txt_CCEnthalpy.Text);

            txt_CCEnthalpyDiff.Text = (PCC2Enthalpy - CCEnthalpy).ToString("#0.########");

            CCEnthalpyDiff = double.Parse(txt_CCEnthalpy.Text);

            PCC2Mass = double.Parse(txt_PCC2Mass.Text);

            txt_CCTotalCooling.Text = (CCEnthalpyDiff * PCC2Mass).ToString("#0.########");

            CCTotalCooling = double.Parse(txt_CCTotalCooling.Text);

            txt_CCTotalCoolingTON.Text = CCTotalCooling.ToString("#0.########");

            txt_CCSensEnthalpyDiff.Text = (0.24 * (PCC2DBT - CCDBT)).ToString("#0.########");

            CCSensEnthalpyDiff = double.Parse(txt_CCSensEnthalpyDiff.Text);

            txt_CCSensCoolCap.Text = (PCC2Mass * CCSensEnthalpyDiff).ToString("#0.########");

            CCSensCoolCap = double.Parse(txt_CCSensCoolCap.Text);

            txt_CCSensCoolCapTON.Text = (CCSensCoolCap / 12000).ToString("#0.########");

            txt_CCLatCoolCap.Text = (CCTotalCooling - CCSensCoolCap).ToString("#0.########");

            CCLatCoolCap = double.Parse(txt_CCLatCoolCap.Text);

            txt_CCLatCoolCapTON.Text = (CCLatCoolCap / 12000).ToString("#0.########");

        }

        public void MakeUpCoolingGraphic()
        {
            txt_MUC_DBT1.Text = PCC2DBT.ToString("#0.########");

            txt_MUC_DBT2.Text = CCDBT.ToString("#0.########");

            PCC2Humidity = double.Parse(txt_PCC2Humidity.Text);

            txt_MUC_W1.Text = PCC2Humidity.ToString("#0.########");

            CCHumidity = double.Parse(txt_CCHumidity.Text);

            txt_MUC_W2.Text = CCHumidity.ToString("#0.########");
        }

        public void MakeUpHeating()
        {
            txt_MUHElevation.Text = Elevation.ToString("#0.########");

            txt_CC2DBT.Text = CCDBT.ToString("#0.########");

            txt_CC2WBT.Text = CCWBT.ToString("#0.########");

            CC2DBT = double.Parse(txt_CC2DBT.Text);

            CC2WBT = double.Parse(txt_CC2WBT.Text);

            txt_CC2Enthalpy.Text = Utilities.Formulas.ENT(CC2DBT, CC2WBT, 3200).ToString("#0.########");

            txt_CC2Density.Text = Utilities.Formulas.DENS(CC2DBT, CC2WBT, 3200).ToString("#0.########");

            txt_CC2Flow.Text = PCC2Flow.ToString("#0.########");

            CC2Flow = double.Parse(txt_CC2Flow.Text);

            CC2Density = double.Parse(txt_CC2Density.Text);

            txt_CC2Mass.Text = (CC2Flow * CC2Density * 60).ToString("#0.########");

            txt_CC2Humidity.Text = Utilities.Formulas.HUMRAT(CC2DBT, CC2WBT, 3200).ToString("#0.########");

            CC2Humidity = double.Parse(txt_CC2Humidity.Text);

            txt_HCHumidity.Text = CC2Humidity.ToString("#0.########");

            HCDBT = double.Parse(txt_HCDBT.Text);

            HCHumidity = double.Parse(txt_HCHumidity.Text);

            if (HCHumidity == -1)
                HCHumidity = 1;

            MUHElevation = double.Parse(txt_MUHElevation.Text);

            //txt_HCWBT.Text = Utilities.Formulas.WbtW(HCDBT, HCHumidity, MUHElevation).ToString("#0.########");

            //txt_HCWBT.Text = "53.30";

            HCWBT = double.Parse(txt_HCWBT.Text);

            txt_HCEnthalpy.Text = Utilities.Formulas.ENT(HCDBT, HCWBT, 3200).ToString("#0.########");

            CC2Enthalpy = double.Parse(txt_CC2Enthalpy.Text);

            HCEnthalpy = double.Parse(txt_HCEnthalpy.Text);

            txt_HCEntDiff.Text = (CC2Enthalpy - HCEnthalpy).ToString("#0.########");

            HCEntDiff = double.Parse(txt_HCEntDiff.Text);

            CC2Mass = double.Parse(txt_CC2Mass.Text);

            txt_HCCooling.Text = (HCEntDiff * CC2Mass).ToString("#0.########");

            HCCooling = double.Parse(txt_HCCooling.Text);

            txt_HCCoolingTON.Text = (HCCooling / 12000).ToString("#0.########");

            txt_HCEnthDifference.Text = (0.24 * (CC2DBT - HCDBT)).ToString("#0.########");

            HCEnthDifference = double.Parse(txt_HCEnthDifference.Text);

            txt_HCSensiCool.Text = (CC2Mass * HCEnthDifference).ToString("#0.########");

            HCSensiCool = double.Parse(txt_HCSensiCool.Text);

            txt_HCSensiCoolTON.Text = (HCSensiCool / 12000).ToString("#0.########");

            txt_HCLatentCool.Text = (HCCooling - HCSensiCool).ToString("#0.########");

            HCLatentCool = double.Parse(txt_HCLatentCool.Text);

            txt_HCLatentCoolTON.Text = (HCLatentCool / 12000).ToString("#0.########");

        }

        public void MakeUpHeatingGraphic()
        {
            txt_MUH_DBT1.Text = CC2DBT.ToString("#0.########");

            txt_MUH_DBT2.Text = HCDBT.ToString("#0.########");

            CC2Humidity = double.Parse(txt_CC2Humidity.Text); 

            txt_MUH_W1.Text = CC2Humidity.ToString("#0.########");

            CCHumidity = double.Parse(txt_CCHumidity.Text);

            txt_MUH_W2.Text = CCHumidity.ToString("#0.########");
        }

        public void RecirculatingAirHandler()
        {
            txt_RAHElevation.Text = Elevation.ToString("#0.########");

            txt_RAHFlow.Text = OSAFlow.ToString("#0.########");

            txt_RAHDBT.Text = HCDBT.ToString("#0.########");

            RAHDBT = double.Parse(txt_RAHDBT.Text);

            txt_RAHHumidity.Text = HCHumidity.ToString("#0.########");

            RAHElevation = double.Parse(txt_RAHElevation.Text);

            RAHHumidity = double.Parse(txt_RAHHumidity.Text);

            txt_RAHRH.Text = (Utilities.Formulas.HRW(RAHDBT, RAHHumidity, RAHElevation) * 100).ToString("#0.########");

           // txt_RAHWBT.Text = Utilities.Formulas.WbtW(RAHDBT, RAHHumidity, RAHElevation).ToString("#0.########");

           // txt_RAHWBT.Text = "53.3";

            RAHWBT = double.Parse(txt_RAHWBT.Text);

            txt_RAHEthalpy.Text = Utilities.Formulas.ENT(RAHDBT, RAHWBT, RAHElevation).ToString("#0.########");

            RAHFlow = double.Parse(txt_RAHFlow.Text);

            txt_RAHFlowR.Text = (AirFlow - RAHFlow).ToString("#0.########");

            RAHDBTR = double.Parse(txt_RAHDBTR.Text);

            RAHRHR = double.Parse(txt_RAHRHR.Text);

            //txt_RAHWBTR.Text = Utilities.Formulas.WbtHR(RAHDBTR, RAHRHR, RAHElevation).ToString("#0.########");

            //txt_RAHWBTR.Text = "58.14";

            RAHWBTR = double.Parse(txt_RAHWBTR.Text);

            txt_RAHEthalpyR.Text = Utilities.Formulas.ENT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

            txt_RAHHumidityR.Text = Utilities.Formulas.HUMRAT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

            RAHFlowR = double.Parse(txt_RAHFlowR.Text);

            txt_MAFlow.Text = (RAHFlow + RAHFlowR).ToString("#0.########");

            MAFlow = double.Parse(txt_MAFlow.Text);

            if (MAFlow == 0)
                MAFlow = 1;

            txt_MADBT.Text = ((RAHDBT * RAHFlow + RAHDBTR * RAHFlowR) / MAFlow).ToString("#0.########");

            //txt_MAWBT.Text = ((RAHWBTR * RAHFlow + RAHDBTR * RAHFlowR) / MAFlow).ToString("#0.########");

            txt_MAWBT.Text = ((RAHWBT * RAHFlow + RAHWBTR * RAHFlowR) / MAFlow).ToString("#0.########");

            MADBT = double.Parse(txt_MADBT.Text);

            MAWBT = double.Parse(txt_MAWBT.Text);

            txt_MADew.Text = Utilities.Formulas.TDP(MADBT, MAWBT, RAHElevation).ToString("#0.########");

            txt_MAEnthalpy.Text = Utilities.Formulas.ENT(MADBT, MAWBT, 3200).ToString("#0.########");

            // txt_MAHumidity.Text = Utilities.Formulas.HUMRAT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

            txt_MAHumidity.Text = Utilities.Formulas.HUMRAT(MADBT, MAWBT, RAHElevation).ToString("#0.########");

            txt_MADensity.Text = Utilities.Formulas.DENS(MADBT, MAWBT, RAHElevation).ToString("#0.########");

            MADensity = double.Parse(txt_MADensity.Text);

            txt_MAMass.Text = (MAFlow * MADensity * 60).ToString("#0.########");

            TotalLatentHeatBTU = double.Parse(lbl_TotalLatentHeatBTU.Text);

            txt_MAInternalLat.Text = TotalLatentHeatBTU.ToString("#0.########");

            RAHEthalpyR = double.Parse(txt_RAHEthalpyR.Text);

            MAInternalLat = double.Parse(txt_MAInternalLat.Text);

            MAMass = double.Parse(txt_MAMass.Text);

            txt_MACCEntalphy.Text = (RAHEthalpyR - MAInternalLat / MAMass).ToString("#0.########");

            MACCEntalphy = double.Parse(txt_MACCEntalphy.Text);

            txt_MACCHumidity.Text = Utilities.Formulas.HUMRATH(RAHDBTR, MACCEntalphy).ToString("#0.########");

            MACCHumidity = double.Parse(txt_MACCHumidity.Text);

            txt_MACCDew.Text = Utilities.Formulas.TDW(MACCHumidity, RAHElevation).ToString("#0.########");

            MACCDew = double.Parse(txt_MACCDew.Text);

            txt_MACCDry.Text = (MACCDew + 2).ToString("#0.########");

            TotalSensibleHeatBTU = double.Parse(lbl_TotalSensibleHeatBTU.Text);

            txt_MACCInternal.Text = TotalSensibleHeatBTU.ToString("#0.########");

            MACCInternal = double.Parse(txt_MACCInternal.Text);

            txt_MACCEntDecrease.Text = (MACCInternal / MAMass).ToString("#0.########");

            MACCEntDecrease = double.Parse(txt_MACCEntDecrease.Text);

            txt_MACCReqDryBulb.Text = (RAHDBTR - MACCEntDecrease / 0.24).ToString("#0.########");

            MACCReqDryBulb = double.Parse(txt_MACCReqDryBulb.Text);

            MADew = double.Parse(txt_MADew.Text);

            txt_MACCResDewPoint.Text = Math.Min(MADew, MACCReqDryBulb - 2).ToString("#0.########");

            MACCResDewPoint = double.Parse(txt_MACCResDewPoint.Text);

            txt_MACCHumRatio.Text = Utilities.Formulas.HUMRATTD(MACCResDewPoint, RAHElevation).ToString("#0.########");

            MACCHumRatio = double.Parse(txt_MACCHumRatio.Text);

            MACCDry = double.Parse(txt_MACCDry.Text);

            if (MACCHumRatio < MACCHumidity)
            {
                txt_MACCQuestion.Text = "Yes, (1) y (2) will be used";
                valRAHDBT = MACCReqDryBulb;
                valRAHDPT = MACCResDewPoint;
            }
            else
            {
                txt_MACCQuestion.Text = "No, (3) y (4) will be used";
                valRAHDBT = MACCDry;
                valRAHDPT = MACCDew;
            }

            txt_RAHCCDBT.Text = Math.Min(valRAHDBT, MADBT).ToString("#0.########");

            txt_RAHCCDPT.Text = Math.Min(valRAHDPT, MADew).ToString("#0.########");

            RAHCCDBT = double.Parse(txt_RAHCCDBT.Text);

            RAHCCDPT = double.Parse(txt_RAHCCDPT.Text);

            txt_RACCCWBT.Text = Utilities.Formulas.WbtTd(RAHCCDBT, RAHCCDPT, RAHElevation).ToString("#0.########");

            txt_RACCCWBT.Text = "50.52";

            RACCCWBT = double.Parse(txt_RACCCWBT.Text);

            txt_RAHCCEnthalpy.Text = Utilities.Formulas.ENT(RAHCCDBT, RACCCWBT, RAHElevation).ToString("#0.########");

            txt_RACCCHumidity.Text = Utilities.Formulas.HUMRATTD(RAHCCDPT, RAHElevation).ToString("#0.########");

            MAHumidity = double.Parse(txt_MAHumidity.Text);

            RACCCHumidity = double.Parse(txt_RACCCHumidity.Text);

            if (MAHumidity < RACCCHumidity)
            {
                txt_SenCoolOnly.Text = "TRUE";

            }
            else
            {
                txt_SenCoolOnly.Text = "FALSE";

            }

        }

        public void RecirculatingAirHandlerGraphicTab()
        {
            MAEnthalpy = double.Parse(txt_MAEnthalpy.Text);

            RAHCCEnthalpy = double.Parse(txt_RAHCCEnthalpy.Text);

            txt_RAHTotalEnthalpyDiff.Text = (MAEnthalpy - RAHCCEnthalpy).ToString("#0.########");

            RAHTotalEnthalpyDiff = double.Parse(txt_RAHTotalEnthalpyDiff.Text);

            txt_TotalRAHCool.Text = (MAMass * RAHTotalEnthalpyDiff).ToString("#0.########");

            TotalRAHCool = double.Parse(txt_TotalRAHCool.Text);

            txt_TotalRAHCoolTON.Text = (TotalRAHCool / 12000).ToString("#0.########");

            txt_RAHSenCoolEnthDiff.Text = (0.24 * (MADBT - RAHCCDBT)).ToString("#0.########");

            RAHSenCoolEnthDiff = double.Parse(txt_RAHSenCoolEnthDiff.Text);

            txt_RAHSenCoolCap.Text = (MAMass * RAHSenCoolEnthDiff).ToString("#0.########");

            RAHSenCoolCap = double.Parse(txt_RAHSenCoolCap.Text);

            txt_RAHSenCoolCapTON.Text = (RAHSenCoolCap / 12000).ToString("#0.########");

            txt_RAHLatCoolCap.Text = (TotalRAHCool - RAHSenCoolCap).ToString("#0.########");

            RAHLatCoolCap = double.Parse(txt_RAHLatCoolCap.Text);

            txt_RAHLatCoolCapTON.Text = (RAHLatCoolCap / 12000).ToString("#0.########");

            if (RAHCCDBT < MACCReqDryBulb)
            {
                txt_ReHeatersQ.Text = "TRUE";
                ReHeatersQ = 1;
            }
            else
            {
                txt_ReHeatersQ.Text = "FALSE";
                ReHeatersQ = 1;
            }

            if (ReHeatersQ == 1)
            {
                txt_HeatingPower.Text = (0.24 * MAMass * (MACCReqDryBulb - RAHCCDBT)).ToString("#0.########");
            }
            else
            {
                txt_HeatingPower.Text = "0";
            }

            txt_RAHeHDBT.Text = MACCReqDryBulb.ToString("#0.########");

            txt_RAHeHumRat.Text = RACCCHumidity.ToString("#0.########");

            HeatingPower = double.Parse(txt_HeatingPower.Text);

            txt_ElectricalPow.Text = (HeatingPower / 3412).ToString("#0.########");

            ElectricalPow = double.Parse(txt_ElectricalPow.Text);

            txt_ElectricalPowFlow.Text = (ElectricalPow * 1000 / MAFlow).ToString("#0.########");


            //////
            ///

            txt_RAH_DBT1.Text = RAHDBTR.ToString("#0.########");

            txt_RAH_W1.Text = MACCHumidity.ToString("#0.########");

            txt_RAH_DBT2.Text = RAHDBT.ToString("#0.########");

            txt_RAH_W2.Text = RAHHumidity.ToString("#0.########");

            txt_RAH_DBT3.Text = MADBT.ToString("#0.########");

            txt_RAH_W3.Text = MAHumidity.ToString("#0.########");

            txt_RAH_DBT4.Text = RAHCCDBT.ToString("#0.########");

            txt_RAH_W4.Text = RACCCHumidity.ToString("#0.########");

            txt_ReH_DBT1.Text = RAHCCDBT.ToString("#0.########");

            txt_ReH_W1.Text = RACCCHumidity.ToString("#0.########");

            RAHeHDBT = double.Parse(txt_RAHeHDBT.Text);

            txt_ReH_DBT2.Text = RAHeHDBT.ToString("#0.########");

            RAHeHumRat = double.Parse(txt_RAHeHumRat.Text);

            txt_ReH_W2.Text = RAHeHumRat.ToString("#0.########");
        }




        private void Btn_ImageF2_Click(object sender, EventArgs e)
        {
            string ruta = "2";
            frm_Image image = new frm_Image(ruta);
            image.Show();
        }

        private void Btn_ImageF3_Click(object sender, EventArgs e)
        {
            string ruta = "3";
            frm_Image image = new frm_Image(ruta);
            image.Show();
        }

        private void Btn_imageF4_Click(object sender, EventArgs e)
        {
            string ruta = "4";
            frm_Image image = new frm_Image(ruta);
            image.Show();
        }

        private void Btn_BE_Click(object sender, EventArgs e)
        {
            string ruta = "5";
            frm_Image image = new frm_Image(ruta);
            image.Show();
        }

        private void Btn_GraphPartConc_Click(object sender, EventArgs e)
        {
            //frm_Grafico grafico = new frm_Grafico(1,null);
            //grafico.Show();
        }

        private void Btn_BE_Click_1(object sender, EventArgs e)
        {
            string ruta = "5";
            frm_Image image = new frm_Image(ruta);
            image.Show();
        }

        private void MaterialRaisedButton1_Click_2(object sender, EventArgs e)
        {
            frm_Grafico grafico = new frm_Grafico(4, CargarMUP(),Elevation);
            grafico.Show();
        }

        public double[,] CargarMUP()
        {
            MUP_DBT1 = double.Parse(txt_MUP_DBT1.Text);
            MUP_DBT2 = double.Parse(txt_MUP_DBT2.Text);

            MUP_W1 = double.Parse(txt_MUP_W1.Text);
            MUP_W2 = double.Parse(txt_MUP_W2.Text);

            matrizCP = new double[2, 2];

            matrizCP[0, 0] = MUP_DBT1;

            matrizCP[0, 1] = MUP_W1;

            matrizCP[1, 0] = MUP_DBT2;

            matrizCP[1, 1] = MUP_W2;

            return matrizCP;
        }

        private void Btn_RAH_Click(object sender, EventArgs e)
        {
            frm_Grafico grafico = new frm_Grafico(7, CargarRAH(),Elevation);
            grafico.Show();
        }

        private void Btn_Carta_Click(object sender, EventArgs e)
        {
            if (!txt_ElevationCart.Text.Trim().Equals(string.Empty))
            {
                Cursor.Current = Cursors.WaitCursor;

                double elevation = double.Parse(txt_ElevationCart.Text);

                frm_CartaPsicometricaPercentage carta = new frm_CartaPsicometricaPercentage(elevation);
                carta.Show();

                frm_CartaPsicometricaTemp cartaTemp = new frm_CartaPsicometricaTemp(elevation);
                cartaTemp.Show();

                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Por favor colocar un numero válido");
            }

        }

        private void Btn_DatosCarta_Click(object sender, EventArgs e)
        {
            frm_CartaPsicometricaTemp cartaTemp = new frm_CartaPsicometricaTemp(3200);
            cartaTemp.Show();

            frm_CartaPsicometricaPercentage carta = new frm_CartaPsicometricaPercentage(3200);
            carta.Show();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void Txt_DryBulbA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }

            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Txt_DryBulbA_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DryBulbA.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    DryBulbA = double.Parse(txt_DryBulbA.Text);

                    GuardarValor(txt_DryBulbA.Text, txt_DryBulbA.Tag.ToString());

                    //txt_WetBulbA.Text = Utilities.Formulas.WbtHR(DryBulbA, Relative, Elevation).ToString("#0.########");

                    Txt_WetBulbA_KeyDown(sender, e);

                    txt_Enthalpy.Text = Utilities.Formulas.ENT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                    txt_HumityRadioA.Text = Utilities.Formulas.HUMRAT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                    Txt_HumityRadioA_KeyDown(sender, e);

                    txt_Density.Text = Utilities.Formulas.DENS(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Relative_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Relative_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Relative.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Relative = double.Parse(txt_Relative.Text);

                    GuardarValor(txt_Relative.Text, txt_Relative.Tag.ToString());

                    //txt_WetBulbA.Text = Utilities.Formulas.WbtHR(DryBulbA, Relative, Elevation).ToString("#0.########");

                    Txt_WetBulbA_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }

        }

        private void Txt_Elevation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Elevation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Elevation.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Elevation = double.Parse(txt_Elevation.Text);

                    GuardarValor(txt_Elevation.Text, txt_Elevation.Tag.ToString());

                    //txt_WetBulbA.Text = Utilities.Formulas.WbtHR(DryBulbA, (Relative / 100), Elevation).ToString("#0.########");

                    Txt_WetBulbA_KeyDown(sender, e);

                    txt_Enthalpy.Text = Utilities.Formulas.ENT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                    txt_HumityRadioA.Text = Utilities.Formulas.HUMRAT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                    Txt_HumityRadioA_KeyDown(sender, e);

                    txt_Density.Text = Utilities.Formulas.DENS(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                    txt_HumityRadioB.Text = Utilities.Formulas.HUMRAT(DryBulbB, WetBuilB, Elevation).ToString("#0.########");

                    Txt_HumityRadioB_KeyDown(sender, e);

                    txt_ElevationMAH.Text = Elevation.ToString("#0.########");

                    txt_ElevationCooling.Text = Elevation.ToString("#0.########");

                    txt_MUHElevation.Text = Elevation.ToString("#0.########");

                    Txt_MUHElevation_KeyDown(sender, e);

                    txt_RAHElevation.Text = Elevation.ToString("#0.########");

                    Txt_RAHElevation_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }
        }

        private void Txt_DryBulbB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_DryBulbB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DryBulbA.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    DryBulbB = double.Parse(txt_DryBulbB.Text);

                    GuardarValor(txt_DryBulbB.Text, txt_DryBulbB.Tag.ToString());

                    txt_OSADBT.Text = DryBulbB.ToString("#0.########");

                    Txt_OSADBT_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_WetBuilB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LenghtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_WidthM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_AvgCeilingM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OutsideTempRoof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OutsideTempRoof.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OutsideTempRoof = double.Parse(txt_OutsideTempRoof.Text);

                    GuardarValor(txt_OutsideTempRoof.Text, txt_OutsideTempRoof.Tag.ToString());

                    txt_TempDiffRoof.Text = (OutsideTempRoof - InsideTempRoof).ToString("#0.########");

                    Txt_TempDiffRoof_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }
        }

        private void Txt_WetBulbA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                WetBulbA = double.Parse(txt_WetBulbA.Text);

                GuardarValor(txt_WetBulbA.Text, txt_WetBulbA.Tag.ToString());

                txt_Enthalpy.Text = Utilities.Formulas.ENT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                txt_HumityRadioA.Text = Utilities.Formulas.HUMRAT(DryBulbA, WetBulbA, Elevation).ToString("#0.########");

                Txt_HumityRadioA_KeyDown(sender, e);

                txt_Density.Text = Utilities.Formulas.DENS(DryBulbA, WetBulbA, Elevation).ToString("#0.########");
            }

        }

        private void Txt_HumityRadioA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HumityRadioA = double.Parse(txt_HumityRadioA.Text);

                GuardarValor(txt_HumityRadioA.Text, txt_HumityRadioA.Tag.ToString());

                txt_HumityRadioGRA.Text = (HumityRadioA * 7000).ToString("#0.########");

                Txt_HumityRadioGRA_KeyDown(sender, e);
            }
        }

        private void Txt_WetBuilB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_WetBuilB.Text.Trim().Equals(string.Empty))
                {
                    WetBuilB = double.Parse(txt_WetBuilB.Text);

                    GuardarValor(txt_WetBuilB.Text, txt_WetBuilB.Tag.ToString());

                    txt_HumityRadioB.Text = Utilities.Formulas.HUMRAT(DryBulbB, WetBuilB, Elevation).ToString("#0.########");

                    Txt_HumityRadioB_KeyDown(sender, e);
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }

        }

        private void Txt_HumityRadioB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HumityRadioB = double.Parse(txt_HumityRadioB.Text);

                GuardarValor(txt_HumityRadioB.Text, txt_HumityRadioB.Tag.ToString());

                txt_HumityRadioGRB.Text = (HumityRadioB * 7000).ToString("#0.########");

                Txt_HumityRadioGRB_KeyDown(sender, e);
            }
        }

        private void Txt_LenghtM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LenghtM.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LenghtM = double.Parse(txt_LenghtM.Text);

                    GuardarValor(txt_LenghtM.Text, txt_LenghtM.Tag.ToString());

                    txt_FloorAreaM.Text = (LenghtM * WidthM).ToString("#0.#####");

                    Txt_FloorAreaM_KeyDown(sender, e);

                    txt_WallAreaM.Text = (AvgCeilingM * 2 * (LenghtM + WidthM)).ToString("#0.#####");

                    Txt_WallAreaM_KeyDown(sender, e);

                    txt_LenghtE.Text = (LenghtM * 3.28).ToString("#0.#####");

                    Txt_LenghtE_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_WidthM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_WidthM.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    WidthM = double.Parse(txt_WidthM.Text);

                    GuardarValor(txt_WidthM.Text, txt_WidthM.Tag.ToString());

                    txt_FloorAreaM.Text = (LenghtM * WidthM).ToString("#0.#####");

                    Txt_FloorAreaM_KeyDown(sender, e);

                    txt_WallAreaM.Text = (AvgCeilingM * 2 * (LenghtM + WidthM)).ToString("#0.#####");

                    Txt_WallAreaM_KeyDown(sender, e);

                    txt_WidthE.Text = (WidthM * 3.28).ToString("#0.#####");

                    Txt_WidthE_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }


            }
        }

        private void Txt_AvgCeilingM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AvgCeilingM.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AvgCeilingM = double.Parse(txt_AvgCeilingM.Text);

                    GuardarValor(txt_AvgCeilingM.Text, txt_AvgCeilingM.Tag.ToString());

                    txt_WallAreaM.Text = (AvgCeilingM * 2 * (LenghtM + WidthM)).ToString("#0.#####");

                    Txt_WallAreaM_KeyDown(sender, e);

                    txt_VolumeM.Text = (FloorAreaM * AvgCeilingM).ToString("#0.########");

                    Txt_VolumeM_KeyDown(sender, e);

                    txt_AvgCeilingE.Text = (AvgCeilingM * 3.28).ToString("#0.#####");

                    Txt_AvgCeilingE_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FloorAreaM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                FloorAreaM = double.Parse(txt_FloorAreaM.Text);

                GuardarValor(txt_FloorAreaM.Text, txt_FloorAreaM.Tag.ToString());

                txt_VolumeM.Text = (FloorAreaM * AvgCeilingM).ToString("#0.########");

                Txt_VolumeM_KeyDown(sender, e);

                txt_FloorAreaE.Text = (FloorAreaM * Math.Pow(3.28, 2)).ToString("#0.#####");

                Txt_FloorAreaE_KeyDown(sender, e);

                txt_FloorAreaLight.Text = FloorAreaM.ToString("#0.#####");

            }
        }

        private void Txt_WallAreaM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                WallAreaM = double.Parse(txt_WallAreaM.Text);

                GuardarValor(txt_WallAreaM.Text, txt_WallAreaM.Tag.ToString());

                txt_WallAreaE.Text = (WallAreaM * Math.Pow(3.28, 2)).ToString("#0.#####");

                Txt_WallAreaE_KeyDown(sender, e);

                //txt_WallArea.Text = WallAreaM.ToString("#0.########");

                //Txt_WallArea_KeyDown(sender, e);
            }
        }

        private void Txt_VolumeM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                VolumeM = double.Parse(txt_VolumeM.Text);

                GuardarValor(txt_VolumeM.Text, txt_VolumeM.Tag.ToString());

                txt_VolumeE.Text = (VolumeM * 35.31).ToString("#0.#####");

                Txt_VolumeE_KeyDown(sender, e);

            }
        }

        private void Txt_OutsideTempRoof_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_InsideTempRoof_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_InsideTempRoof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DryBulbA.Text.Trim().Equals(string.Empty))
                {

                    InsideTempRoof = double.Parse(txt_InsideTempRoof.Text);

                    GuardarValor(txt_InsideTempRoof.Text, txt_InsideTempRoof.Tag.ToString());

                    txt_TempDiffRoof.Text = (OutsideTempRoof - InsideTempRoof).ToString("#0.########");

                    Txt_TempDiffRoof_KeyDown(sender, e);

                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }
        }

        private void Txt_UFactorRoof_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_TempDiffRoof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TempDiffRoof = double.Parse(txt_TempDiffRoof.Text);

                GuardarValor(txt_TempDiffRoof.Text, txt_TempDiffRoof.Tag.ToString());

                txt_HeatGainRoof.Text = (TempDiffRoof * UFactorRoof * RoofArea).ToString("#0.########");

                Txt_HeatGainRoof_KeyDown(sender, e);
            }
        }

        private void Txt_UFactorRoof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_UFactorRoof.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    UFactorRoof = double.Parse(txt_UFactorRoof.Text);

                    GuardarValor(txt_UFactorRoof.Text, txt_UFactorRoof.Tag.ToString());

                    txt_HeatGainRoof.Text = (TempDiffRoof * UFactorRoof * RoofArea).ToString("#0.########");

                    Txt_HeatGainRoof_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_RoofArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RoofArea = double.Parse(txt_RoofArea.Text);

                GuardarValor(txt_RoofArea.Text, txt_RoofArea.Tag.ToString());

                txt_HeatGainRoof.Text = (TempDiffRoof * UFactorRoof * RoofArea).ToString("#0.########");

                Txt_HeatGainRoof_KeyDown(sender, e);
            }
        }

        private void Txt_HeatGainRoof_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeatGainRoof = double.Parse(txt_HeatGainRoof.Text);

                GuardarValor(txt_HeatGainRoof.Text, txt_HeatGainRoof.Tag.ToString());

                txt_SubtotalFloor.Text = (HeatGainRoof + HeatGainWall + HeatGainFloor).ToString("#0.########");

                Txt_SubtotalFloor_KeyDown(sender, e);
            }
        }

        private void Txt_OutsideTempWall_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OutsideTempWall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OutsideTempWall.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OutsideTempWall = double.Parse(txt_OutsideTempWall.Text);

                    GuardarValor(txt_OutsideTempWall.Text, txt_OutsideTempWall.Tag.ToString());

                    txt_TempDiffWall.Text = (OutsideTempWall - InsideTempWall).ToString("#0.########");

                    Txt_TempDiffWall_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_InsideTempWall_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_InsideTempWall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_InsideTempWall.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    InsideTempWall = double.Parse(txt_InsideTempWall.Text);

                    GuardarValor(txt_InsideTempWall.Text, txt_InsideTempWall.Tag.ToString());

                    txt_TempDiffWall.Text = (OutsideTempWall - InsideTempWall).ToString("#0.########");

                    Txt_TempDiffWall_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_TempDiffWall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TempDiffWall = double.Parse(txt_TempDiffWall.Text);

                GuardarValor(txt_TempDiffWall.Text, txt_TempDiffWall.Tag.ToString());

                txt_HeatGainWall.Text = (TempDiffWall * UFactorWall * WallArea).ToString("#0.########");

                Txt_HeatGainWall_KeyDown(sender, e);
            }
        }

        private void Txt_UFactorWall_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_UFactorWall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_UFactorWall.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    UFactorWall = double.Parse(txt_UFactorWall.Text);

                    GuardarValor(txt_UFactorWall.Text, txt_UFactorWall.Tag.ToString());

                    WallArea = double.Parse(txt_WallArea.Text);

                    txt_HeatGainWall.Text = (TempDiffWall * UFactorWall * WallArea).ToString("#0.########");

                    Txt_HeatGainWall_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_WallArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                WallArea = double.Parse(txt_WallArea.Text);

                GuardarValor(txt_WallArea.Text, txt_WallArea.Tag.ToString());

                txt_HeatGainWall.Text = (TempDiffWall * UFactorWall * WallArea).ToString("#0.########");

                Txt_HeatGainWall_KeyDown(sender, e);
            }
        }

        private void Txt_HeatGainWall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeatGainWall = double.Parse(txt_HeatGainWall.Text);

                GuardarValor(txt_HeatGainWall.Text, txt_HeatGainWall.Tag.ToString());

                txt_SubtotalFloor.Text = (HeatGainRoof + HeatGainWall + HeatGainFloor).ToString("#0.########");

                Txt_SubtotalFloor_KeyDown(sender, e);
            }
        }

        private void Txt_OutsideTempFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OutsideTempFloor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OutsideTempFloor.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OutsideTempFloor = double.Parse(txt_OutsideTempFloor.Text);

                    GuardarValor(txt_OutsideTempFloor.Text, txt_OutsideTempFloor.Tag.ToString());

                    txt_TempDiffFloor.Text = (OutsideTempFloor - InsideTempFloor).ToString("#0.########");

                    Txt_TempDiffFloor_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_InsideTempFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_InsideTempFloor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_InsideTempFloor.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    InsideTempFloor = double.Parse(txt_InsideTempFloor.Text);

                    GuardarValor(txt_InsideTempFloor.Text, txt_InsideTempFloor.Tag.ToString());

                    txt_TempDiffFloor.Text = (OutsideTempFloor - InsideTempFloor).ToString("#0.########");

                    Txt_TempDiffFloor_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_UFactorFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_UFactorFloor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_UFactorFloor.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    UFactorFloor = double.Parse(txt_UFactorFloor.Text);

                    GuardarValor(txt_UFactorFloor.Text, txt_UFactorFloor.Tag.ToString());

                    txt_HeatGainFloor.Text = (TempDiffFloor * UFactorFloor * FloorArea).ToString("#0.########");

                    Txt_HeatGainFloor_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FloorArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                FloorArea = double.Parse(txt_FloorArea.Text);

                GuardarValor(txt_FloorArea.Text, txt_FloorArea.Tag.ToString());

                txt_HeatGainFloor.Text = (TempDiffFloor * UFactorFloor * FloorArea).ToString("#0.########");

                Txt_HeatGainFloor_KeyDown(sender, e);
            }
        }

        private void Txt_HeatGainFloor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeatGainFloor = double.Parse(txt_HeatGainFloor.Text);

                GuardarValor(txt_HeatGainFloor.Text, txt_HeatGainFloor.Tag.ToString());

                txt_SubtotalFloor.Text = (HeatGainRoof + HeatGainWall + HeatGainFloor).ToString("#0.########");

                Txt_SubtotalFloor_KeyDown(sender, e);
            }
        }

        private void Txt_SubtotalFloor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SubtotalFloor = double.Parse(txt_SubtotalFloor.Text);

                GuardarValor(txt_SubtotalFloor.Text, txt_SubtotalFloor.Tag.ToString());

                txt_GainWRF.Text = (SubtotalFloor / 3412).ToString("#0.########");

                Txt_GainWRF_KeyDown(sender, e);
            }
        }

        private void Txt_TempDiffFloor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TempDiffFloor = double.Parse(txt_TempDiffFloor.Text);

                GuardarValor(txt_TempDiffFloor.Text, txt_TempDiffFloor.Tag.ToString());

                txt_HeatGainFloor.Text = (TempDiffFloor * UFactorFloor * FloorArea).ToString("#0.########");

                Txt_HeatGainFloor_KeyDown(sender, e);
            }
        }

        private void Txt_LightDensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LightDensity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LightDensity.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LightDensity = double.Parse(txt_LightDensity.Text);

                    GuardarValor(txt_LightDensity.Text, txt_LightDensity.Tag.ToString());

                    txt_HeatGainLight.Text = (LightDensity * FloorAreaLight / 1000).ToString("#0.########");

                    Txt_HeatGainLight_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FloorAreaLight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                FloorAreaLight = double.Parse(txt_FloorAreaLight.Text);

                GuardarValor(txt_FloorAreaLight.Text, txt_FloorAreaLight.Tag.ToString());

                txt_HeatGainLight.Text = (LightDensity * FloorAreaLight / 1000).ToString("#0.########");

                Txt_HeatGainLight_KeyDown(sender, e);
            }
        }

        private void Txt_HeadcountD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HeadcountD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HeadcountD.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HeadcountD = double.Parse(txt_HeadcountD.Text);

                    GuardarValor(txt_HeadcountD.Text, txt_HeadcountD.Tag.ToString());

                    txt_SubtotalPeoGain.Text = (TotalSensibleHeat * HeadcountD).ToString("#0.########");

                    Txt_SubtotalPeoGain_KeyDown(sender, e);

                    txt_VentHeadCount.Text = HeadcountD.ToString("#0.########");

                    Txt_VentHeadCount_KeyDown(sender, e);

                    txt_HeadCountOccu.Text = HeadcountD.ToString("#0.########");

                    Txt_HeadCountOccu_KeyDown(sender, e);

                    txt_HeadcountE.Text = HeadcountD.ToString("#0.########");

                    Txt_HeadcountE_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_SeatedRest_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_SeatedLight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OfficeWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Standing_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Waking_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModerateWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LightBench_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModerateDancing_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_FastWaking_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HevyWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_SeatedRestP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_SeatedLightP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OfficeWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_StandingP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_WakingP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModerateWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LightBenchP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModerateDancingP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_FastWakingP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HevyWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        public void ActualizarSumaActividad(object sender, KeyEventArgs e)
        {
            SeatedRest = double.Parse(txt_SeatedRest.Text);
            SeatedLight = double.Parse(txt_SeatedLight.Text);
            OfficeWork = double.Parse(txt_OfficeWork.Text);
            Standing = double.Parse(txt_Standing.Text);
            Waking = double.Parse(txt_Waking.Text);
            ModerateWork = double.Parse(txt_ModerateWork.Text);
            LightBench = double.Parse(txt_LightBench.Text);
            ModerateDancing = double.Parse(txt_ModerateDancing.Text);
            FastWaking = double.Parse(txt_FastWaking.Text);
            HevyWork = double.Parse(txt_HevyWork.Text);

            SeatedRestP = double.Parse(txt_SeatedRestP.Text);
            SeatedLightP = double.Parse(txt_SeatedLightP.Text);
            OfficeWorkP = double.Parse(txt_OfficeWorkP.Text);
            StandingP = double.Parse(txt_StandingP.Text);
            WakingP = double.Parse(txt_WakingP.Text);
            ModerateWorkP = double.Parse(txt_ModerateWorkP.Text);
            LightBenchP = double.Parse(txt_LightBenchP.Text);
            ModerateDancingP = double.Parse(txt_ModerateDancingP.Text);
            FastWakingP = double.Parse(txt_FastWakingP.Text);
            HevyWorkP = double.Parse(txt_HevyWorkP.Text);

            TotalPercentage = SeatedRestP + SeatedLightP + OfficeWorkP + StandingP + WakingP + ModerateWorkP + LightBenchP + ModerateDancingP + FastWakingP + HevyWorkP;

            if (TotalPercentage < 100)
            {
                txt_TotalPercentage.Text = "Must Add 100 %";
            }
            else
            {
                txt_TotalPercentage.Text = TotalPercentage.ToString("#0.########");
            }

            TotalSensibleHeat = 0;

            if (SeatedRestP != 0)
                TotalSensibleHeat += SeatedRest * (SeatedRestP / 100);
            if (SeatedLightP != 0)
                TotalSensibleHeat += SeatedLight * (SeatedLightP / 100);
            if (OfficeWorkP != 0)
                TotalSensibleHeat += OfficeWork * (OfficeWorkP / 100);
            if (StandingP != 0)
                TotalSensibleHeat += Standing * (StandingP / 100);
            if (WakingP != 0)
                TotalSensibleHeat += Waking * (WakingP / 100);
            if (ModerateWorkP != 0)
                TotalSensibleHeat += ModerateWork * (ModerateWorkP / 100);
            if (LightBenchP != 0)
                TotalSensibleHeat += LightBench * (LightBenchP / 100);
            if (ModerateDancingP != 0)
                TotalSensibleHeat += ModerateDancing * (ModerateDancingP / 100);
            if (FastWakingP != 0)
                TotalSensibleHeat += FastWaking * (FastWakingP / 100);
            if (HevyWorkP != 0)
                TotalSensibleHeat += HevyWork * (HevyWorkP / 100);

            txt_TotalSensibleHeat.Text = TotalSensibleHeat.ToString("#0.########");

            Txt_TotalSensibleHeat_KeyDown(sender, e);
        }

        public void ActualizarSumaActLatHeat(object sender, KeyEventArgs e)
        {
            SeatedRest = double.Parse(txt_SeatedRest.Text);
            SeatedLight = double.Parse(txt_SeatedLight.Text);
            OfficeWork = double.Parse(txt_OfficeWork.Text);
            Standing = double.Parse(txt_Standing.Text);
            Waking = double.Parse(txt_Waking.Text);
            ModerateWork = double.Parse(txt_ModerateWork.Text);
            LightBench = double.Parse(txt_LightBench.Text);
            ModerateDancing = double.Parse(txt_ModerateDancing.Text);
            FastWaking = double.Parse(txt_FastWaking.Text);
            HevyWork = double.Parse(txt_HevyWork.Text);

            SeatedRestP = double.Parse(txt_SeatedRestP.Text);
            SeatedLightP = double.Parse(txt_SeatedLightP.Text);
            OfficeWorkP = double.Parse(txt_OfficeWorkP.Text);
            StandingP = double.Parse(txt_StandingP.Text);
            WakingP = double.Parse(txt_WakingP.Text);
            ModerateWorkP = double.Parse(txt_ModerateWorkP.Text);
            LightBenchP = double.Parse(txt_LightBenchP.Text);
            ModerateDancingP = double.Parse(txt_ModerateDancingP.Text);
            FastWakingP = double.Parse(txt_FastWakingP.Text);
            HevyWorkP = double.Parse(txt_HevyWorkP.Text);


            TotalLatentHeatP = SeatedP + SeatedVeLightP + OffWorkP + LabWorkP + WalkSeaP + ModWorkP + LigBenWorkP + ModDanceP + FastWalkP + HeaWorkP;

            if (TotalLatentHeatP < 100)
            {
                txt_TotalLatentHeatP.Text = "Must Add 100 %";
            }
            else
            {
                txt_TotalLatentHeatP.Text = TotalLatentHeatP.ToString("#0.########");
            }

            //TotalLatentHeat = (Seated / SeatedP) * 100 +
            //    (SeatedVeLight / SeatedVeLightP) * 100 +
            //    (OffWork / OffWorkP) * 100 +
            //    (LabWork / LabWorkP) * 100 +
            //    (WalkSea / WalkSeaP) * 100 +
            //    (ModWork / ModWorkP) * 100 +
            //    (LigBenWork / LigBenWorkP) * 100 +
            //    (ModDance / ModDanceP) * 100 +
            //    (FastWalk / FastWalkP) * 100 +
            //    (HeaWork / HeaWorkP) * 100;

            TotalLatentHeat = 0;

            if (SeatedP != 0)
                TotalLatentHeat += Seated *(SeatedP /100);
            if (SeatedVeLightP != 0)
                TotalLatentHeat += SeatedVeLight * (SeatedVeLightP / 100);
            if (OffWorkP != 0)
                TotalLatentHeat += OffWork * (OffWorkP / 100);
            if (LabWorkP != 0)
                TotalLatentHeat += LabWork * (LabWorkP / 100);
            if (WalkSeaP != 0)
                TotalLatentHeat += WalkSea * (WalkSeaP / 100);
            if (ModWorkP != 0)
                TotalLatentHeat += ModWork * (ModWorkP / 100);
            if (LigBenWorkP != 0)
                TotalLatentHeat += LigBenWork * (LigBenWorkP / 100);
            if (ModDanceP != 0)
                TotalLatentHeat += ModDance * (ModDanceP / 100);
            if (FastWalkP != 0)
                TotalLatentHeat += FastWalk * (FastWalkP / 100);
            if (HeaWorkP != 0)
                TotalLatentHeat += HeaWork * (HeaWorkP / 100);

            txt_TotalLatentHeat.Text = TotalLatentHeat.ToString("#0.########");

            Txt_TotalLatentHeat_KeyDown(sender, e);
        }

        public void ActualizarSumaPartGenerate(object sender, KeyEventArgs e)
        {
            Motionless = double.Parse(txt_Motionless.Text);
            HeadArm = double.Parse(txt_HeadArm.Text);
            FoodMotion = double.Parse(txt_FoodMotion.Text);
            StandSit = double.Parse(txt_StandSit.Text);
            Walk20 = double.Parse(txt_Walk20.Text);
            Walk35 = double.Parse(txt_Walk35.Text);
            Walk50 = double.Parse(txt_Walk50.Text);

            MotionlessP = double.Parse(txt_MotionlessP.Text);
            HeadArmP = double.Parse(txt_HeadArmP.Text);
            FoodMotionP = double.Parse(txt_FoodMotionP.Text);
            StandSitP = double.Parse(txt_StandSitP.Text);
            Walk20P = double.Parse(txt_Walk20P.Text);
            Walk35P = double.Parse(txt_Walk35P.Text);
            Walk50P = double.Parse(txt_Walk50P.Text);

            WeiAverageP = MotionlessP + HeadArmP + FoodMotionP + StandSitP + Walk20P + Walk35P + Walk50P;

            if (WeiAverageP < 100)
            {
                txt_WeiAverageP.Text = "Must Add 100 %";
            }
            else
            {
                txt_WeiAverageP.Text = WeiAverageP.ToString("#0.########");
            }

            WeiAverage = 0;

            if (MotionlessP != 0)
                WeiAverage += Motionless * (MotionlessP / 100);
            if (HeadArmP != 0)
                WeiAverage += HeadArm * (HeadArmP / 100);
            if (FoodMotionP != 0)
                WeiAverage += FoodMotion * (FoodMotionP / 100);
            if (StandSitP != 0)
                WeiAverage += StandSit * (StandSitP / 100);
            if (Walk20P != 0)
                WeiAverage += Walk20 * (Walk20P / 100);
            if (Walk35P != 0)
                WeiAverage += Walk35 * (Walk35P / 100);
            if (Walk50P != 0)
                WeiAverage += Walk50 * (Walk50P / 100);

            txt_WeiAverage.Text = WeiAverage.ToString("#0.########");

            Txt_WeiAverage_KeyDown(sender, e);
        }

        private void Txt_SeatedRestP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_SeatedRestP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SeatedRestP = double.Parse(txt_SeatedRestP.Text);

                    GuardarValor(txt_SeatedRestP.Text, txt_SeatedRestP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_SeatedRest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_SeatedRest.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SeatedRest = double.Parse(txt_SeatedRest.Text);

                    GuardarValor(txt_SeatedRest.Text, txt_SeatedRest.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_SeatedLightP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_SeatedLightP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SeatedLightP = double.Parse(txt_SeatedLightP.Text);

                    GuardarValor(txt_SeatedLightP.Text, txt_SeatedLightP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_SeatedLight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_SeatedLight.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SeatedLight = double.Parse(txt_SeatedLight.Text);

                    GuardarValor(txt_SeatedLight.Text, txt_SeatedLight.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_OfficeWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OfficeWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OfficeWorkP = double.Parse(txt_OfficeWorkP.Text);

                    GuardarValor(txt_OfficeWorkP.Text, txt_OfficeWorkP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_OfficeWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OfficeWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OfficeWork = double.Parse(txt_OfficeWork.Text);

                    GuardarValor(txt_OfficeWork.Text, txt_OfficeWork.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_StandingP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_StandingP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    StandingP = double.Parse(txt_StandingP.Text);

                    GuardarValor(txt_StandingP.Text, txt_StandingP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Standing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Standing.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Standing = double.Parse(txt_Standing.Text);

                    GuardarValor(txt_Standing.Text, txt_Standing.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_WakingP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_WakingP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    WakingP = double.Parse(txt_WakingP.Text);

                    GuardarValor(txt_WakingP.Text, txt_WakingP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Waking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Waking.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Waking = double.Parse(txt_Waking.Text);

                    GuardarValor(txt_Waking.Text, txt_Waking.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModerateWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModerateWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModerateWorkP = double.Parse(txt_ModerateWorkP.Text);

                    GuardarValor(txt_ModerateWorkP.Text, txt_ModerateWorkP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModerateWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModerateWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModerateWork = double.Parse(txt_ModerateWork.Text);

                    GuardarValor(txt_ModerateWork.Text, txt_ModerateWork.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LightBenchP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LightBenchP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LightBenchP = double.Parse(txt_LightBenchP.Text);

                    GuardarValor(txt_LightBenchP.Text, txt_LightBenchP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LightBench_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LightBench.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LightBench = double.Parse(txt_LightBench.Text);

                    GuardarValor(txt_LightBench.Text, txt_LightBench.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModerateDancingP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModerateDancingP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModerateDancingP = double.Parse(txt_ModerateDancingP.Text);

                    GuardarValor(txt_ModerateDancingP.Text, txt_ModerateDancingP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModerateDancing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModerateDancing.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModerateDancing = double.Parse(txt_ModerateDancing.Text);

                    GuardarValor(txt_ModerateDancing.Text, txt_ModerateDancing.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FastWakingP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_FastWakingP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    FastWakingP = double.Parse(txt_FastWakingP.Text);

                    GuardarValor(txt_FastWakingP.Text, txt_FastWakingP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FastWaking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_FastWaking.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    FastWaking = double.Parse(txt_FastWaking.Text);

                    GuardarValor(txt_FastWaking.Text, txt_FastWaking.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HevyWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HevyWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HevyWorkP = double.Parse(txt_HevyWorkP.Text);

                    GuardarValor(txt_HevyWorkP.Text, txt_HevyWorkP.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HevyWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HevyWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HevyWork = double.Parse(txt_HevyWork.Text);

                    GuardarValor(txt_HevyWork.Text, txt_HevyWork.Tag.ToString());

                    ActualizarSumaActividad(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_InsideTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_FloorAreaE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                FloorAreaE = double.Parse(txt_FloorAreaE.Text);

                GuardarValor(txt_FloorAreaE.Text, txt_FloorAreaE.Tag.ToString());

                txt_RoofArea.Text = FloorAreaE.ToString("#0.########");

                Txt_RoofArea_KeyDown(sender, e);

                txt_FloorArea.Text = FloorAreaE.ToString("#0.########");

                Txt_FloorArea_KeyDown(sender, e);

                txt_FloorAreaEquip.Text = FloorAreaM.ToString("#0.########");

                Txt_FloorAreaEquip_KeyDown(sender, e);
            }
        }

        private void Txt_InsideTemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_InsideTemp.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    InsideTemp = double.Parse(txt_InsideTemp.Text);

                    GuardarValor(txt_InsideTemp.Text, txt_InsideTemp.Tag.ToString());

                    txt_GainEquip.Text = ((InsideTemp * FloorAreaEquip) / 1000).ToString("#0.########");

                    Txt_GainEquip_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_GainWRF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GainWRF = double.Parse(txt_GainWRF.Text);

                GuardarValor(txt_GainWRF.Text, txt_GainWRF.Tag.ToString());

                lbl_TotalSensibleHeatKW.Text = (GainWRF + HeatGainLight + HeatGainPeople + GainEquip).ToString("#0.########");

                Lbl_TotalSensibleHeatKW_Enter(sender, ea);

            }
        }

        private void Txt_HeatGainLight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeatGainLight = double.Parse(txt_HeatGainLight.Text);

                GuardarValor(txt_HeatGainLight.Text, txt_HeatGainLight.Tag.ToString());

                lbl_TotalSensibleHeatKW.Text = (GainWRF + HeatGainLight + HeatGainPeople + GainEquip).ToString("#0.########");

                Lbl_TotalSensibleHeatKW_Enter(sender, ea);
            }
        }

        private void Txt_HeatGainPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeatGainPeople = double.Parse(txt_HeatGainPeople.Text);

                GuardarValor(txt_HeatGainPeople.Text, txt_HeatGainPeople.Tag.ToString());

                lbl_TotalSensibleHeatKW.Text = (GainWRF + HeatGainLight + HeatGainPeople + GainEquip).ToString("#0.########");

                Lbl_TotalSensibleHeatKW_Enter(sender, ea);
            }
        }

        private void Txt_GainEquip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GainEquip = double.Parse(txt_GainEquip.Text);

                GuardarValor(txt_GainEquip.Text, txt_GainEquip.Tag.ToString());

                lbl_TotalSensibleHeatKW.Text = (GainWRF + HeatGainLight + HeatGainPeople + GainEquip).ToString("#0.########");

                Lbl_TotalSensibleHeatKW_Enter(sender, ea);
            }
        }

        private void Txt_FloorAreaEquip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                FloorAreaEquip = double.Parse(txt_FloorAreaEquip.Text);

                GuardarValor(txt_FloorAreaEquip.Text, txt_FloorAreaEquip.Tag.ToString());

                txt_GainEquip.Text = ((InsideTemp * FloorAreaEquip) / 1000).ToString("#0.########");

                Txt_GainEquip_KeyDown(sender, e);
            }
        }

        private void Txt_SubtotalPeoGain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SubtotalPeoGain = double.Parse(txt_SubtotalPeoGain.Text);

                GuardarValor(txt_SubtotalPeoGain.Text, txt_SubtotalPeoGain.Tag.ToString());

                txt_HeatGainPeople.Text = (SubtotalPeoGain / 3412).ToString("#0.########");

                Txt_HeatGainPeople_KeyDown(sender, e);
            }
        }

        private void Txt_TotalSensibleHeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TotalSensibleHeat = double.Parse(txt_TotalSensibleHeat.Text);

                txt_SubtotalPeoGain.Text = (TotalSensibleHeat * HeadcountD).ToString("#0.########");

                Txt_SubtotalPeoGain_KeyDown(sender, e);
            }
        }

        private void Lbl_TotalSensibleHeatKW_Enter(object sender, EventArgs e)
        {
            TotalSensibleHeatKW = double.Parse(lbl_TotalSensibleHeatKW.Text);

            lbl_TotalSensibleHeatBTU.Text = (TotalSensibleHeatKW * 3412).ToString("#0.########");

            Lbl_TotalSensibleHeatBTU_Enter(sender, e);
        }

        private void Txt_HeadcountE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_HeadcountE.Text, txt_HeadcountE.Tag.ToString());
            }
        }

        private void Txt_SeatedP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Seated_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_SeatedVeLightP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_SeatedVeLight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OffWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OffWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LabWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LabWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_WalkSeaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_WalkSea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LigBenWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LigBenWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModDanceP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ModDance_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_FastWalkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_FastWalk_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HeaWorkP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HeaWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_TotalLatentHeatP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_TotalLatentHeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_SeatedP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_SeatedP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SeatedP = double.Parse(txt_SeatedP.Text);

                    GuardarValor(txt_SeatedP.Text, txt_SeatedP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Seated_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Seated.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Seated = double.Parse(txt_Seated.Text);

                    GuardarValor(txt_Seated.Text, txt_Seated.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_SeatedVeLightP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_SeatedVeLightP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SeatedVeLightP = double.Parse(txt_SeatedVeLightP.Text);

                    GuardarValor(txt_SeatedVeLightP.Text, txt_SeatedVeLightP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_SeatedVeLight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_SeatedVeLight.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SeatedVeLight = double.Parse(txt_SeatedVeLight.Text);

                    GuardarValor(txt_SeatedVeLight.Text, txt_SeatedVeLight.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_OffWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OffWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OffWorkP = double.Parse(txt_OffWorkP.Text);

                    GuardarValor(txt_OffWorkP.Text, txt_OffWorkP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_OffWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OffWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OffWork = double.Parse(txt_OffWork.Text);

                    GuardarValor(txt_OffWork.Text, txt_OffWork.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LabWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LabWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LabWorkP = double.Parse(txt_LabWorkP.Text);

                    GuardarValor(txt_LabWorkP.Text, txt_LabWorkP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }
        }

        private void Txt_LabWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LabWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LabWork = double.Parse(txt_LabWork.Text);

                    GuardarValor(txt_LabWork.Text, txt_LabWork.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_WalkSeaP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_WalkSeaP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    WalkSeaP = double.Parse(txt_WalkSeaP.Text);

                    GuardarValor(txt_WalkSeaP.Text, txt_WalkSeaP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_WalkSea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_WalkSea.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    WalkSea = double.Parse(txt_WalkSea.Text);

                    GuardarValor(txt_WalkSea.Text, txt_WalkSea.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModWorkP = double.Parse(txt_ModWorkP.Text);

                    GuardarValor(txt_ModWorkP.Text, txt_ModWorkP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModWork = double.Parse(txt_ModWork.Text);

                    GuardarValor(txt_ModWork.Text, txt_ModWork.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LigBenWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LigBenWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LigBenWorkP = double.Parse(txt_LigBenWorkP.Text);

                    GuardarValor(txt_LigBenWorkP.Text, txt_LigBenWorkP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LigBenWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LigBenWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LigBenWork = double.Parse(txt_LigBenWork.Text);

                    GuardarValor(txt_LigBenWork.Text, txt_LigBenWork.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModDanceP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModDanceP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModDanceP = double.Parse(txt_ModDanceP.Text);

                    GuardarValor(txt_ModDanceP.Text, txt_ModDanceP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ModDance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ModDance.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ModDance = double.Parse(txt_ModDance.Text);

                    GuardarValor(txt_ModDance.Text, txt_ModDance.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FastWalkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_FastWalkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    FastWalkP = double.Parse(txt_FastWalkP.Text);

                    GuardarValor(txt_FastWalkP.Text, txt_FastWalkP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FastWalk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_FastWalk.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    FastWalk = double.Parse(txt_FastWalk.Text);

                    GuardarValor(txt_FastWalk.Text, txt_FastWalk.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HeaWorkP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HeaWorkP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HeaWorkP = double.Parse(txt_HeaWorkP.Text);

                    GuardarValor(txt_HeaWorkP.Text, txt_HeaWorkP.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HeaWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HeaWork.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HeaWork = double.Parse(txt_HeaWork.Text);

                    GuardarValor(txt_HeaWork.Text, txt_HeaWork.Tag.ToString());

                    ActualizarSumaActLatHeat(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_TotalLatentHeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TotalLatentHeat = double.Parse(txt_TotalLatentHeat.Text);

                txt_SubtotalLatHeat.Text = (TotalLatentHeat * HeadcountE).ToString("#0.########");

                Txt_SubtotalLatHeat_KeyDown(sender, e);
            }
        }

        private void Txt_SubtotalLatHeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SubtotalLatHeat = double.Parse(txt_SubtotalLatHeat.Text);

                GuardarValor(txt_SubtotalLatHeat.Text, txt_SubtotalLatHeat.Tag.ToString());

                txt_HeatGaPeople.Text = (SubtotalLatHeat / 3412).ToString("#0.########");

                Txt_HeatGaPeople_KeyDown(sender, e);
            }
        }

        private void Txt_VolumeE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                VolumeE = double.Parse(txt_VolumeE.Text);

                GuardarValor(txt_VolumeE.Text, txt_VolumeE.Tag.ToString());

                txt_VolumeLate.Text = VolumeE.ToString("#0.########");

                Txt_VolumeLate_KeyDown(sender, e);
            }
        }

        private void Txt_HumityRadioGRA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;

                HumityRadioGRA = double.Parse(txt_HumityRadioGRA.Text);

                GuardarValor(txt_HumityRadioGRA.Text, txt_HumityRadioGRA.Tag.ToString());

                txt_HumDiff.Text = (HumityRadioGRB - HumityRadioGRA).ToString("#0.########");

                Txt_HumDiff_KeyDown(sender, e);

                Cursor.Current = Cursors.Default;
            }
        }

        private void Txt_HumityRadioGRB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;

                HumityRadioGRB = double.Parse(txt_HumityRadioGRB.Text);

                GuardarValor(txt_HumityRadioGRB.Text, txt_HumityRadioGRB.Tag.ToString());

                txt_HumDiff.Text = (HumityRadioGRB - HumityRadioGRA).ToString("#0.########");

                Txt_HumDiff_KeyDown(sender, e);

                Cursor.Current = Cursors.Default;
            }
        }
        private void Txt_HumDiff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HumDiff = double.Parse(txt_HumDiff.Text);

                GuardarValor(txt_HumDiff.Text, txt_HumDiff.Tag.ToString());

                txt_HumityFact.Text = ((HumDiff - 35) / 42.5 + 1).ToString("#0.########");

                Txt_HumityFact_KeyDown(sender, e);

                txt_HumGainGR.Text = (VolumeLate / 14 * HumDiff * HumityFact * VolumeFact * ConstructionFact * VaporFact).ToString("#0.########");

                Txt_HumGainGR_KeyDown(sender, e);
            }
        }

        private void Txt_VolumeFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ConstructionFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_VaporFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_VolumeLate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                VolumeLate = double.Parse(txt_VolumeLate.Text);

                GuardarValor(txt_VolumeLate.Text, txt_VolumeLate.Tag.ToString());

                txt_HumGainGR.Text = (VolumeLate / 14 * HumDiff * HumityFact * VolumeFact * ConstructionFact * VaporFact).ToString("#0.########");

                Txt_HumGainGR_KeyDown(sender, e);
            }
        }

        private void Txt_HumityFact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HumityFact = double.Parse(txt_HumityFact.Text);

                GuardarValor(txt_HumityFact.Text, txt_HumityFact.Tag.ToString());

                txt_HumGainGR.Text = (VolumeLate / 14 * HumDiff * HumityFact * VolumeFact * ConstructionFact * VaporFact).ToString("#0.########");

                Txt_HumGainGR_KeyDown(sender, e);
            }
        }

        private void Txt_VolumeFact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_VolumeFact.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    VolumeFact = double.Parse(txt_VolumeFact.Text);

                    GuardarValor(txt_VolumeFact.Text, txt_VolumeFact.Tag.ToString());

                    txt_HumGainGR.Text = (VolumeLate / 14 * HumDiff * HumityFact * VolumeFact * ConstructionFact * VaporFact).ToString("#0.########");

                    Txt_HumGainGR_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_ConstructionFact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_ConstructionFact.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ConstructionFact = double.Parse(txt_ConstructionFact.Text);

                    GuardarValor(txt_ConstructionFact.Text, txt_ConstructionFact.Tag.ToString());

                    txt_HumGainGR.Text = (VolumeLate / 14 * HumDiff * HumityFact * VolumeFact * ConstructionFact * VaporFact).ToString("#0.########");

                    Txt_HumGainGR_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_VaporFact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_VaporFact.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    VaporFact = double.Parse(txt_VaporFact.Text);

                    GuardarValor(txt_VaporFact.Text, txt_VaporFact.Tag.ToString());

                    txt_HumGainGR.Text = (VolumeLate / 14 * HumDiff * HumityFact * VolumeFact * ConstructionFact * VaporFact).ToString("#0.########");

                    Txt_HumGainGR_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HumGainGR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HumGainGR = double.Parse(txt_HumGainGR.Text);

                GuardarValor(txt_HumGainGR.Text, txt_HumGainGR.Tag.ToString());

                txt_HumGainLB.Text = (HumGainGR / 7000).ToString("#0.########");

                Txt_HumGainLB_KeyDown(sender, e);
            }
        }

        private void Txt_VapoHeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HumGainLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HumGainLB = double.Parse(txt_HumGainLB.Text);

                GuardarValor(txt_HumGainLB.Text, txt_HumGainLB.Tag.ToString());

                txt_SubtotalHumidity.Text = (HumGainLB * VapoHeat).ToString("#0.########");

                Txt_SubtotalHumidity_KeyDown(sender, e);
            }
        }

        private void Txt_SubtotalHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SubtotalHumidity = double.Parse(txt_SubtotalHumidity.Text);

                GuardarValor(txt_SubtotalHumidity.Text, txt_SubtotalHumidity.Tag.ToString());

                txt_HumHeatGain.Text = (SubtotalHumidity / 3412).ToString("#0.########");

                Txt_HumHeatGain_KeyDown(sender, e);
            }
        }

        private void Txt_HeatGaPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeatGaPeople = double.Parse(txt_HeatGaPeople.Text);

                lbl_TotalLatentHeatKW.Text = (HeatGaPeople + HumHeatGain).ToString("#0.########");
            }
        }

        private void Txt_HumHeatGain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HumHeatGain = double.Parse(txt_HumHeatGain.Text);

                //GuardarValor(txt_HumHeatGain.Text, txt_HumHeatGain.Tag.ToString());

                lbl_TotalLatentHeatKW.Text = (HeatGaPeople + HumHeatGain).ToString("#0.########");

                Lbl_TotalLatentHeatKW_Enter(sender, ea);
            }
        }

        private void Lbl_TotalLatentHeatKW_Enter(object sender, EventArgs e)
        {
            TotalLatentHeatKW = double.Parse(lbl_TotalLatentHeatKW.Text);

            //GuardarValor(lbl_TotalLatentHeatKW.Text, lbl_TotalLatentHeatKW.Tag.ToString());

            lbl_TotalLatentHeatBTU.Text = (TotalLatentHeatKW * 3412).ToString("#0.########");

            Lbl_TotalLatentHeatBTU_Enter(sender, e);
        }

        private void Txt_DesignDiffWG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_RegularArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_AverageArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_GoodArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_TightArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakLeakArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_RegularLeak_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_AverageLeak_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_GoodLeak_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_TightLeak_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakLoss_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_RegularLoss_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_AverageLoss_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_GoodLoss_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_TightLoss_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_DesignDiffWG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DesignDiffWG.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    DesignDiffWG = double.Parse(txt_DesignDiffWG.Text);

                    GuardarValor(txt_DesignDiffWG.Text, txt_DesignDiffWG.Tag.ToString());

                    txt_DesignDiffPA.Text = (DesignDiffWG * 248.84).ToString("#0.########");

                    txt_LeakFlow.Text = (4005 * LeakArea * LeakLeakArea * Math.Pow((DesignDiffWG / LeakLoss), 0.5)).ToString("#0.########");

                    Txt_LeakFlow_KeyDown(sender, e);

                    txt_RegularFlow.Text = (4005 * RegularArea * RegularLeak * Math.Pow((DesignDiffWG / RegularLoss), 0.5)).ToString("#0.########");

                    Txt_RegularFlow_KeyDown(sender, e);

                    txt_AverageFlow.Text = (4005 * AverageArea * AverageLeak * Math.Pow((DesignDiffWG / AverageLoss), 0.5)).ToString("#0.########");

                    Txt_AverageFlow_KeyDown(sender, e);

                    txt_GoodFlow.Text = (4005 * GoodArea * GoodLeak * Math.Pow((DesignDiffWG / GoodLoss), 0.5)).ToString("#0.########");

                    Txt_GoodFlow_KeyDown(sender, e);

                    txt_TightFlow.Text = (4005 * TightArea * TightLeak * Math.Pow((DesignDiffWG / TightLoss), 0.5)).ToString("#0.########");

                    Txt_TightFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LeakArea.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakArea = double.Parse(txt_LeakArea.Text);

                    // GuardarValor(txt_LeakArea.Text, txt_LeakArea.Tag.ToString());

                    GuardarValorFuga(txt_LeakArea.Text, txt_LeakArea.Tag.ToString(), txt_LeakArea.Name);

                    txt_LeakFlow.Text = (4005 * LeakArea * LeakLeakArea * Math.Pow((DesignDiffWG / LeakLoss), 0.5)).ToString("#0.########");

                    Txt_LeakFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_RegularArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_RegularArea.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    RegularArea = double.Parse(txt_RegularArea.Text);

                    //GuardarValor(txt_RegularArea.Text, txt_RegularArea.Tag.ToString());

                    GuardarValorFuga(txt_RegularArea.Text, txt_RegularArea.Tag.ToString(), txt_RegularArea.Name);

                    txt_RegularFlow.Text = (4005 * RegularArea * RegularLeak * Math.Pow((DesignDiffWG / RegularLoss), 0.5)).ToString("#0.########");

                    Txt_RegularFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_AverageArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AverageArea.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AverageArea = double.Parse(txt_AverageArea.Text);

                    //GuardarValor(txt_AverageArea.Text, txt_AverageArea.Tag.ToString());

                    GuardarValorFuga(txt_AverageArea.Text, txt_AverageArea.Tag.ToString(), txt_AverageArea.Name);

                    txt_AverageFlow.Text = (4005 * AverageArea * AverageLeak * Math.Pow((DesignDiffWG / AverageLoss), 0.5)).ToString("#0.########");

                    Txt_AverageFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_GoodArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GoodArea = double.Parse(txt_GoodArea.Text);

                //GuardarValor(txt_GoodArea.Text, txt_GoodArea.Tag.ToString());

                GuardarValorFuga(txt_GoodArea.Text, txt_GoodArea.Tag.ToString(), txt_GoodArea.Name);

                txt_GoodFlow.Text = (4005 * GoodArea * GoodLeak * Math.Pow((DesignDiffWG / GoodLoss), 0.5)).ToString("#0.########");

                Txt_GoodFlow_KeyDown(sender, e);
            }
        }

        private void Txt_TightArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_TightArea.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    TightArea = double.Parse(txt_TightArea.Text);

                    //GuardarValor(txt_TightArea.Text, txt_TightArea.Tag.ToString());

                    GuardarValorFuga(txt_TightArea.Text, txt_TightArea.Tag.ToString(), txt_TightArea.Name);

                    txt_TightFlow.Text = (4005 * TightArea * TightLeak * Math.Pow((DesignDiffWG / TightLoss), 0.5)).ToString("#0.########");

                    Txt_TightFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakLeakArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                if (!txt_LeakLeakArea.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakLeakArea = double.Parse(txt_LeakLeakArea.Text);

                    //GuardarValor(txt_LeakLeakArea.Text, txt_LeakLeakArea.Tag.ToString());

                    GuardarValorFuga(txt_LeakLeakArea.Text, txt_LeakLeakArea.Tag.ToString(), txt_LeakLeakArea.Name);

                    txt_LeakFlow.Text = (4005 * LeakArea * LeakLeakArea * Math.Pow((DesignDiffWG / LeakLoss), 0.5)).ToString("#0.########");

                    Txt_LeakFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_RegularLeak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_RegularLeak.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    RegularLeak = double.Parse(txt_RegularLeak.Text);

                    //GuardarValor(txt_RegularLeak.Text, txt_RegularLeak.Tag.ToString());

                    GuardarValorFuga(txt_RegularLeak.Text, txt_RegularLeak.Tag.ToString(), txt_RegularLeak.Name);

                    txt_RegularFlow.Text = (4005 * RegularArea * RegularLeak * Math.Pow((DesignDiffWG / RegularLoss), 0.5)).ToString("#0.########");

                    Txt_RegularFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_AverageLeak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AverageLeak.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AverageLeak = double.Parse(txt_AverageLeak.Text);

                    //GuardarValor(txt_AverageLeak.Text, txt_AverageLeak.Tag.ToString());

                    GuardarValorFuga(txt_AverageLeak.Text, txt_AverageLeak.Tag.ToString(), txt_AverageLeak.Name);

                    txt_AverageFlow.Text = (4005 * AverageArea * AverageLeak * Math.Pow((DesignDiffWG / AverageLoss), 0.5)).ToString("#0.########");

                    Txt_AverageFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_GoodLeak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_GoodLeak.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    GoodLeak = double.Parse(txt_GoodLeak.Text);

                    //GuardarValor(txt_GoodLeak.Text, txt_GoodLeak.Tag.ToString());

                    GuardarValorFuga(txt_GoodLeak.Text, txt_GoodLeak.Tag.ToString(), txt_GoodLeak.Name);

                    txt_GoodFlow.Text = (4005 * GoodArea * GoodLeak * Math.Pow((DesignDiffWG / GoodLoss), 0.5)).ToString("#0.########");

                    Txt_GoodFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_TightLeak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_TightLeak.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    TightLeak = double.Parse(txt_TightLeak.Text);

                    //GuardarValor(txt_TightLeak.Text, txt_TightLeak.Tag.ToString());

                    GuardarValorFuga(txt_TightLeak.Text, txt_TightLeak.Tag.ToString(), txt_TightLeak.Name);

                    txt_TightFlow.Text = (4005 * TightArea * TightLeak * Math.Pow((DesignDiffWG / TightLoss), 0.5)).ToString("#0.########");

                    Txt_TightFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LeakLoss.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakLoss = double.Parse(txt_LeakLoss.Text);

                    // GuardarValor(txt_LeakLoss.Text, txt_LeakLoss.Tag.ToString());

                    GuardarValorFuga(txt_LeakLoss.Text, txt_LeakLoss.Tag.ToString(), txt_LeakLoss.Name);

                    txt_LeakFlow.Text = (4005 * LeakArea * LeakLeakArea * Math.Pow((DesignDiffWG / LeakLoss), 0.5)).ToString("#0.########");

                    Txt_LeakFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_RegularLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_RegularLoss.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    RegularLoss = double.Parse(txt_RegularLoss.Text);

                    //GuardarValor(txt_RegularLoss.Text, txt_RegularLoss.Tag.ToString());

                    GuardarValorFuga(txt_RegularLoss.Text, txt_RegularLoss.Tag.ToString(), txt_RegularLoss.Name);

                    txt_RegularFlow.Text = (4005 * RegularArea * RegularLeak * Math.Pow((DesignDiffWG / RegularLoss), 0.5)).ToString("#0.########");

                    Txt_RegularFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_AverageLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AverageLoss.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AverageLoss = double.Parse(txt_AverageLoss.Text);

                    // GuardarValor(txt_AverageLoss.Text, txt_AverageLoss.Tag.ToString());

                    GuardarValorFuga(txt_AverageLoss.Text, txt_AverageLoss.Tag.ToString(), txt_AverageLoss.Name);

                    txt_AverageFlow.Text = (4005 * AverageArea * AverageLeak * Math.Pow((DesignDiffWG / AverageLoss), 0.5)).ToString("#0.########");

                    Txt_AverageFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_GoodLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_GoodLoss.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    GoodLoss = double.Parse(txt_GoodLoss.Text);

                    // GuardarValor(txt_GoodLoss.Text, txt_GoodLoss.Tag.ToString());

                    GuardarValorFuga(txt_GoodLoss.Text, txt_GoodLoss.Tag.ToString(), txt_GoodLoss.Name);

                    txt_GoodFlow.Text = (4005 * GoodArea * GoodLeak * Math.Pow((DesignDiffWG / GoodLoss), 0.5)).ToString("#0.########");

                    Txt_GoodFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_TightLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_TightLoss.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    TightLoss = double.Parse(txt_TightLoss.Text);

                    //GuardarValor(txt_TightLoss.Text, txt_TightLoss.Tag.ToString());

                    GuardarValorFuga(txt_TightLoss.Text, txt_TightLoss.Tag.ToString(), txt_TightLoss.Name);

                    txt_TightFlow.Text = (4005 * TightArea * TightLeak * Math.Pow((DesignDiffWG / TightLoss), 0.5)).ToString("#0.########");

                    Txt_TightFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }
        }

        private void Txt_LeakFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LeakFlow = double.Parse(txt_LeakFlow.Text);

                //GuardarValor(txt_LeakFlow.Text, txt_LeakFlow.Tag.ToString());

                GuardarValorFuga(txt_LeakFlow.Text, txt_LeakFlow.Tag.ToString(), txt_LeakFlow.Name);

                //txt_LeakFlow.Text = Math.Pow((4005 * LeakArea * LeakLeakArea * (DesignDiffWG / LeakLoss)), 0.5).ToString("#0.########");

                txt_LeaksDueBuilding.Text = (LeakFlow + RegularFlow + AverageFlow + GoodFlow + TightFlow).ToString("#0.########");

                Txt_LeaksDueBuilding_KeyDown(sender, e);
            }
        }

        private void Txt_RegularFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RegularFlow = double.Parse(txt_RegularFlow.Text);

                //GuardarValor(txt_RegularFlow.Text, txt_RegularFlow.Tag.ToString());

                GuardarValorFuga(txt_RegularFlow.Text, txt_RegularFlow.Tag.ToString(), txt_RegularFlow.Name);

                //txt_RegularFlow.Text = Math.Pow((4005 * RegularArea * RegularLeak * (DesignDiffWG / RegularLoss)), 0.5).ToString("#0.########");

                txt_LeaksDueBuilding.Text = (LeakFlow + RegularFlow + AverageFlow + GoodFlow + TightFlow).ToString("#0.########");

                Txt_LeaksDueBuilding_KeyDown(sender, e);
            }
        }

        private void Txt_AverageFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AverageFlow = double.Parse(txt_AverageFlow.Text);

                //GuardarValor(txt_AverageFlow.Text, txt_AverageFlow.Tag.ToString());

                GuardarValorFuga(txt_AverageFlow.Text, txt_AverageFlow.Tag.ToString(), txt_AverageFlow.Name);

               // txt_AverageFlow.Text = Math.Pow((4005 * AverageArea * AverageLeak * (DesignDiffWG / AverageLoss)), 0.5).ToString("#0.########");

                txt_LeaksDueBuilding.Text = (LeakFlow + RegularFlow + AverageFlow + GoodFlow + TightFlow).ToString("#0.########");

                Txt_LeaksDueBuilding_KeyDown(sender, e);
            }
        }

        private void Txt_GoodFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GoodFlow = double.Parse(txt_GoodFlow.Text);

                // GuardarValor(txt_GoodFlow.Text, txt_GoodFlow.Tag.ToString());

                GuardarValorFuga(txt_GoodFlow.Text, txt_GoodFlow.Tag.ToString(), txt_GoodFlow.Name);

               // txt_GoodFlow.Text = Math.Pow((4005 * GoodArea * GoodLeak * (DesignDiffWG / GoodLoss)), 0.5).ToString("#0.########");

                txt_LeaksDueBuilding.Text = (LeakFlow + RegularFlow + AverageFlow + GoodFlow + TightFlow).ToString("#0.########");

                Txt_LeaksDueBuilding_KeyDown(sender, e);
            }
        }

        private void Txt_TightFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TightFlow = double.Parse(txt_TightFlow.Text);

                //GuardarValor(txt_TightFlow.Text, txt_TightFlow.Tag.ToString());

                GuardarValorFuga(txt_TightFlow.Text, txt_TightFlow.Tag.ToString(), txt_TightFlow.Name);

               // txt_TightFlow.Text = Math.Pow((4005 * TightArea * TightLeak * (DesignDiffWG / TightLoss)), 0.5).ToString("#0.########");

                txt_LeaksDueBuilding.Text = (LeakFlow + RegularFlow + AverageFlow + GoodFlow + TightFlow).ToString("#0.########");

                Txt_LeaksDueBuilding_KeyDown(sender, e);
            }
        }

        private void Txt_Qty1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Qty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Qty3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Qty4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Qty5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakA3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakA4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_LeakA5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Loss1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Loss2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Loss3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Loss4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Loss5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Qty1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Qty1.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Qty1 = double.Parse(txt_Qty1.Text);

                    //GuardarValor(txt_Qty1.Text, txt_Qty1.Tag.ToString());

                    GuardarValorFuga(txt_Qty1.Text, txt_Qty1.Tag.ToString(), txt_Qty1.Name);

                    txt_Flow1.Text = (Qty1 * 4005 * LeakA1 * Math.Pow((DesignDiffWG / Loss1), 0.5)).ToString("#0.########");

                    Txt_Flow1_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }
        }

        private void Txt_Qty2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Qty2.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Qty2 = double.Parse(txt_Qty2.Text);

                    //GuardarValor(txt_Qty2.Text, txt_Qty2.Tag.ToString());

                    GuardarValorFuga(txt_Qty2.Text, txt_Qty2.Tag.ToString(), txt_Qty2.Name);

                    txt_Flow2.Text = (Qty2 * 4005 * LeakA2 * Math.Pow((DesignDiffWG / Loss2), 0.5)).ToString("#0.########");

                    Txt_Flow2_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Qty3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Qty3.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Qty3 = double.Parse(txt_Qty3.Text);

                    // GuardarValor(txt_Qty3.Text, txt_Qty3.Tag.ToString());

                    GuardarValorFuga(txt_Qty3.Text, txt_Qty3.Tag.ToString(), txt_Qty3.Name);

                    txt_Flow3.Text = (Qty3 * 4005 * LeakA3 * Math.Pow((DesignDiffWG / Loss3), 0.5)).ToString("#0.########");

                    Txt_Flow3_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }


            }
        }

        private void Txt_Qty4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Qty4.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Qty4 = double.Parse(txt_Qty4.Text);

                    //GuardarValor(txt_Qty4.Text, txt_Qty4.Tag.ToString());

                    GuardarValorFuga(txt_Qty4.Text, txt_Qty4.Tag.ToString(), txt_Qty4.Name);

                    txt_Flow4.Text = (Qty4 * 4005 * LeakA4 * Math.Pow((DesignDiffWG / Loss4), 0.5)).ToString("#0.########");

                    Txt_Flow4_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Qty5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Qty5.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Qty5 = double.Parse(txt_Qty5.Text);

                    //GuardarValor(txt_Qty5.Text, txt_Qty5.Tag.ToString());

                    GuardarValorFuga(txt_Qty5.Text, txt_Qty5.Tag.ToString(), txt_Qty5.Name);

                    txt_Flow5.Text = (Qty5 * 4005 * LeakA5 * Math.Pow((DesignDiffWG / Loss5), 0.5)).ToString("#0.########");

                    Txt_Flow5_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakA1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LeakA1.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakA1 = double.Parse(txt_LeakA1.Text);

                    //GuardarValor(txt_LeakA1.Text, txt_LeakA1.Tag.ToString());

                    GuardarValorFuga(txt_LeakA1.Text, txt_LeakA1.Tag.ToString(), txt_LeakA1.Name);

                    txt_Flow1.Text = (Qty1 * 4005 * LeakA1 * Math.Pow((DesignDiffWG / Loss1), 0.5)).ToString("#0.########");

                    Txt_Flow1_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakA2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LeakA2.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakA2 = double.Parse(txt_LeakA2.Text);

                    //GuardarValor(txt_LeakA2.Text, txt_LeakA2.Tag.ToString());

                    GuardarValorFuga(txt_LeakA2.Text, txt_LeakA2.Tag.ToString(), txt_LeakA2.Name);

                    txt_Flow2.Text = (Qty2 * 4005 * LeakA2 * Math.Pow((DesignDiffWG / Loss2), 0.5)).ToString("#0.########");

                    Txt_Flow2_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakA3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LeakA3.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakA3 = double.Parse(txt_LeakA3.Text);

                    // GuardarValor(txt_LeakA3.Text, txt_LeakA3.Tag.ToString());

                    GuardarValorFuga(txt_LeakA3.Text, txt_LeakA3.Tag.ToString(), txt_LeakA3.Name);

                    txt_Flow3.Text = (Qty3 * 4005 * LeakA3 * Math.Pow((DesignDiffWG / Loss3), 0.5)).ToString("#0.########");

                    Txt_Flow3_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakA4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LeakA4.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakA4 = double.Parse(txt_LeakA4.Text);

                    //GuardarValor(txt_LeakA4.Text, txt_LeakA4.Tag.ToString());

                    GuardarValorFuga(txt_LeakA4.Text, txt_LeakA4.Tag.ToString(), txt_LeakA4.Name);

                    txt_Flow4.Text = (Qty4 * 4005 * LeakA4 * Math.Pow((DesignDiffWG / Loss4), 0.5)).ToString("#0.########");

                    Txt_Flow4_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_LeakA5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_LeakA5.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    LeakA5 = double.Parse(txt_LeakA5.Text);

                    //GuardarValor(txt_LeakA5.Text, txt_LeakA5.Tag.ToString());

                    GuardarValorFuga(txt_LeakA5.Text, txt_LeakA5.Tag.ToString(), txt_LeakA5.Name);

                    txt_Flow5.Text = (Qty5 * 4005 * LeakA5 * Math.Pow((DesignDiffWG / Loss5), 0.5)).ToString("#0.########");

                    Txt_Flow5_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Loss1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DryBulbA.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Loss1 = double.Parse(txt_Loss1.Text);

                    //GuardarValor(txt_Loss1.Text, txt_Loss1.Tag.ToString());

                    GuardarValorFuga(txt_Loss1.Text, txt_Loss1.Tag.ToString(), txt_Loss1.Name);

                    txt_Flow1.Text = (Qty1 * 4005 * LeakA1 * Math.Pow((DesignDiffWG / Loss1), 0.5)).ToString("#0.########");

                    Txt_Flow1_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Loss2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Loss2.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Loss2 = double.Parse(txt_Loss2.Text);

                    //GuardarValor(txt_Loss2.Text, txt_Loss2.Tag.ToString());

                    GuardarValorFuga(txt_Loss2.Text, txt_Loss2.Tag.ToString(), txt_Loss2.Name);

                    txt_Flow2.Text = (Qty2 * 4005 * LeakA2 * Math.Pow((DesignDiffWG / Loss2), 0.5)).ToString("#0.########");

                    Txt_Flow2_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Loss3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Loss3.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Loss3 = double.Parse(txt_Loss3.Text);

                    //GuardarValor(txt_Loss3.Text, txt_Loss3.Tag.ToString());

                    GuardarValorFuga(txt_Loss3.Text, txt_Loss3.Tag.ToString(), txt_Loss3.Name);

                    txt_Flow3.Text = (Qty3 * 4005 * LeakA3 * Math.Pow((DesignDiffWG / Loss3), 0.5)).ToString("#0.########");

                    Txt_Flow3_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Loss4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Loss4.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Loss4 = double.Parse(txt_Loss4.Text);

                    //GuardarValor(txt_Loss4.Text, txt_Loss4.Tag.ToString());

                    GuardarValorFuga(txt_Loss4.Text, txt_Loss4.Tag.ToString(), txt_Loss4.Name);

                    txt_Flow4.Text = (Qty4 * 4005 * LeakA4 * Math.Pow((DesignDiffWG / Loss4), 0.5)).ToString("#0.########");

                    Txt_Flow4_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Loss5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Loss5.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Loss5 = double.Parse(txt_Loss5.Text);

                    //GuardarValor(txt_Loss5.Text, txt_Loss5.Tag.ToString());

                    GuardarValorFuga(txt_Loss5.Text, txt_Loss5.Tag.ToString(), txt_Loss5.Name);

                    txt_Flow5.Text = (Qty5 * 4005 * LeakA5 * Math.Pow((DesignDiffWG / Loss5), 0.5)).ToString("#0.########");

                    Txt_Flow5_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Flow1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Flow1 = double.Parse(txt_Flow1.Text);

                //GuardarValor(txt_Flow1.Text, txt_Flow1.Tag.ToString());

                GuardarValorFuga(txt_Flow1.Text, txt_Flow1.Tag.ToString(), txt_Flow1.Name);

                txt_LeaksDueDoors.Text = (Flow1 + Flow2 + Flow3 + Flow4 + Flow5).ToString("#0.########");

                Txt_LeaksDueDoors_KeyDown(sender, e);
            }
        }

        private void Txt_Flow2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Flow2 = double.Parse(txt_Flow2.Text);

               // GuardarValor(txt_Flow2.Text, txt_Flow1.Tag.ToString());

                GuardarValorFuga(txt_Flow2.Text, txt_Flow2.Tag.ToString(), txt_Flow2.Name);

                txt_LeaksDueDoors.Text = (Flow1 + Flow2 + Flow3 + Flow4 + Flow5).ToString("#0.########");

                Txt_LeaksDueDoors_KeyDown(sender, e);
            }
        }

        private void Txt_Flow3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Flow3 = double.Parse(txt_Flow3.Text);

                //GuardarValor(txt_Flow3.Text, txt_Flow3.Tag.ToString());

                GuardarValorFuga(txt_Flow3.Text, txt_Flow3.Tag.ToString(), txt_Flow3.Name);

                txt_LeaksDueDoors.Text = (Flow1 + Flow2 + Flow3 + Flow4 + Flow5).ToString("#0.########");

                Txt_LeaksDueDoors_KeyDown(sender, e);
            }
        }

        private void Txt_Flow4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Flow4 = double.Parse(txt_Flow4.Text);

                GuardarValorFuga(txt_Flow4.Text, txt_Flow4.Tag.ToString(), txt_Flow4.Name);

                txt_LeaksDueDoors.Text = (Flow1 + Flow2 + Flow3 + Flow4 + Flow5).ToString("#0.########");

                Txt_LeaksDueDoors_KeyDown(sender, e);
            }
        }

        private void Txt_Flow5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Flow5 = double.Parse(txt_Flow5.Text);

                GuardarValorFuga(txt_Flow5.Text, txt_Flow5.Tag.ToString(), txt_Flow5.Name);

                txt_LeaksDueDoors.Text = (Flow1 + Flow2 + Flow3 + Flow4 + Flow5).ToString("#0.########");

                Txt_LeaksDueDoors_KeyDown(sender, e);
            }
        }

        private void Txt_GeneralExhaust_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_ProcessExhaust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ProcessExhaust = double.Parse(txt_ProcessExhaust.Text);

                GuardarValor(txt_ProcessExhaust.Text, txt_ProcessExhaust.Tag.ToString());

                txt_OSATotal.Text = (ProcessExhaust + LeaksDueBuilding + LeaksDueDoors + GeneralExhaust).ToString("#0.########");

                Txt_OSATotal_KeyDown(sender, e);
            }
        }

        private void Txt_LeaksDueBuilding_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LeaksDueBuilding = double.Parse(txt_LeaksDueBuilding.Text);

                GuardarValor(txt_LeaksDueBuilding.Text, txt_LeaksDueBuilding.Tag.ToString());

                txt_OSATotal.Text = (ProcessExhaust + LeaksDueBuilding + LeaksDueDoors + GeneralExhaust).ToString("#0.########");

                Txt_OSATotal_KeyDown(sender, e);
            }
        }

        private void Txt_LeaksDueDoors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LeaksDueDoors = double.Parse(txt_LeaksDueDoors.Text);

                GuardarValor(txt_LeaksDueDoors.Text, txt_LeaksDueDoors.Tag.ToString());

                txt_OSATotal.Text = (ProcessExhaust + LeaksDueBuilding + LeaksDueDoors + GeneralExhaust).ToString("#0.########");

                Txt_OSATotal_KeyDown(sender, e);
            }
        }

        private void Txt_GeneralExhaust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_GeneralExhaust.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    GeneralExhaust = double.Parse(txt_GeneralExhaust.Text);

                    GuardarValor(txt_GeneralExhaust.Text, txt_GeneralExhaust.Tag.ToString());

                    txt_OSATotal.Text = (ProcessExhaust + LeaksDueBuilding + LeaksDueDoors + GeneralExhaust).ToString("#0.########");

                    Txt_OSATotal_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_UnitaryVentReq_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_VentHeadCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                VentHeadCount = double.Parse(txt_VentHeadCount.Text);

                GuardarValor(txt_VentHeadCount.Text, txt_VentHeadCount.Tag.ToString());

                txt_VentilationReq.Text = (VentHeadCount * UnitaryVentReq).ToString("#0.########");

                Txt_VentilationReq_KeyDown(sender, e);
            }
        }

        private void Txt_UnitaryVentReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_UnitaryVentReq.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    UnitaryVentReq = double.Parse(txt_UnitaryVentReq.Text);

                    GuardarValor(txt_UnitaryVentReq.Text, txt_UnitaryVentReq.Tag.ToString());

                    txt_VentilationReq.Text = (VentHeadCount * UnitaryVentReq).ToString("#0.########");

                    Txt_VentilationReq_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_VentilationReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                VentilationReq = double.Parse(txt_VentilationReq.Text);

                GuardarValor(txt_VentilationReq.Text, txt_VentilationReq.Tag.ToString());
                //IF(C37>=C42,"YES","NO, Increase General Exhaust")
                if (OSATotal >= VentilationReq)
                {
                    lbl_VentilationReq.Text = "YES";
                }
                else
                {
                    lbl_VentilationReq.Text = "NO, Increase General Exhaust";
                }
            }
        }

        private void Txt_OSATotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                OSATotal = double.Parse(txt_OSATotal.Text);

                //IF(C37>=C42,"YES","NO, Increase General Exhaust")
                if (OSATotal >= VentilationReq)
                {
                    lbl_VentilationReq.Text = "YES";
                }
                else
                {
                    lbl_VentilationReq.Text = "NO, Increase General Exhaust";
                }
            }
        }

        private void Txt_AvgCeilingE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AvgCeilingE = double.Parse(txt_AvgCeilingE.Text);

                GuardarValor(txt_AvgCeilingE.Text, txt_AvgCeilingE.Tag.ToString());

                txt_EnviHeight.Text = AvgCeilingE.ToString("#0.########");

                Txt_EnviHeight_KeyDown(sender, e);
            }
        }

        private void Txt_WidthE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                WidthE = double.Parse(txt_WidthE.Text);

                GuardarValor(txt_WidthE.Text, txt_WidthE.Tag.ToString());

                txt_EnviWidth.Text = WidthE.ToString("#0.########");

                Txt_EnviWidth_KeyDown(sender, e);
            }
        }

        private void Txt_LenghtE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LenghtE = double.Parse(txt_LenghtE.Text);

                GuardarValor(txt_LenghtE.Text, txt_LenghtE.Tag.ToString());

                txt_EnviLenght.Text = LenghtE.ToString("#0.########");

                Txt_EnviLenght_KeyDown(sender, e);
            }
        }

        private void Txt_EnviHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                EnviHeight = double.Parse(txt_EnviHeight.Text);

                GuardarValor(txt_EnviHeight.Text, txt_EnviHeight.Tag.ToString());

                txt_EnviVolume.Text = (EnviLenght * EnviWidth * EnviHeight).ToString("#0.########");

                Txt_EnviVolume_KeyDown(sender, e);
            }
        }

        private void Txt_EnviWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                EnviWidth = double.Parse(txt_EnviWidth.Text);

                GuardarValor(txt_EnviWidth.Text, txt_EnviWidth.Tag.ToString());

                txt_EnviVolume.Text = (EnviLenght * EnviWidth * EnviHeight).ToString("#0.########");

                Txt_EnviVolume_KeyDown(sender, e);
            }
        }

        private void Txt_EnviLenght_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                EnviLenght = double.Parse(txt_EnviLenght.Text);

                GuardarValor(txt_EnviLenght.Text, txt_EnviLenght.Tag.ToString());

                txt_EnviVolume.Text = (EnviLenght * EnviWidth * EnviHeight).ToString("#0.########");

                Txt_EnviVolume_KeyDown(sender, e);
            }
        }

        private void Txt_MotionlessP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HeadArmP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_FoodMotionP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_StandSitP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Walk20P_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Walk35P_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Walk50P_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Motionless_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HeadArm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_FoodMotion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_StandSit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Walk20_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Walk35_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_Walk50_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_WeiAverage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                WeiAverage = double.Parse(txt_WeiAverage.Text);

                txt_PartGenDueOccu.Text = (HeadCountOccu * WeiAverage).ToString("#0.########");

                Txt_PartGenDueOccu_KeyDown(sender, e);
            }
        }

        private void Txt_MotionlessP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_MotionlessP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    MotionlessP = double.Parse(txt_MotionlessP.Text);

                    GuardarValor(txt_MotionlessP.Text, txt_MotionlessP.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Motionless_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Motionless.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Motionless = double.Parse(txt_Motionless.Text);

                    GuardarValor(txt_Motionless.Text, txt_Motionless.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HeadArmP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HeadArmP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HeadArmP = double.Parse(txt_HeadArmP.Text);

                    GuardarValor(txt_HeadArmP.Text, txt_HeadArmP.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HeadArm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HeadArm.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HeadArm = double.Parse(txt_HeadArm.Text);

                    GuardarValor(txt_HeadArm.Text, txt_HeadArm.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FoodMotionP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_FoodMotionP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    FoodMotionP = double.Parse(txt_FoodMotionP.Text);

                    GuardarValor(txt_FoodMotionP.Text, txt_FoodMotionP.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_FoodMotion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_FoodMotion.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    FoodMotion = double.Parse(txt_FoodMotion.Text);

                    GuardarValor(txt_FoodMotion.Text, txt_FoodMotion.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_StandSitP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_StandSitP.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    StandSitP = double.Parse(txt_StandSitP.Text);

                    GuardarValor(txt_StandSitP.Text, txt_StandSitP.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_StandSit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DryBulbA.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    StandSit = double.Parse(txt_StandSit.Text);

                    GuardarValor(txt_StandSit.Text, txt_StandSit.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Walk20P_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Walk20P.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Walk20P = double.Parse(txt_Walk20P.Text);

                    GuardarValor(txt_Walk20P.Text, txt_Walk20P.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Walk20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Walk20.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Walk20 = double.Parse(txt_Walk20.Text);

                    GuardarValor(txt_Walk20.Text, txt_Walk20.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Walk35P_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Walk35P.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Walk35P = double.Parse(txt_Walk35P.Text);

                    GuardarValor(txt_Walk35P.Text, txt_Walk35P.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Walk35_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Walk35.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Walk35 = double.Parse(txt_Walk35.Text);

                    GuardarValor(txt_Walk35.Text, txt_Walk35.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Walk50P_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_Walk50P.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Walk50P = double.Parse(txt_Walk50P.Text);

                    GuardarValor(txt_Walk50P.Text, txt_Walk50P.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_Walk50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DryBulbA.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Walk50 = double.Parse(txt_Walk50.Text);

                    GuardarValor(txt_Walk50.Text, txt_Walk50.Tag.ToString());

                    ActualizarSumaPartGenerate(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_PartGenDueOccu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGenDueOccu = double.Parse(txt_PartGenDueOccu.Text);

                GuardarValor(txt_PartGenDueOccu.Text, txt_PartGenDueOccu.Tag.ToString());

                txt_PartGenDueBuild.Text = (0.1 * PartGenDueOccu).ToString("#0.########");

                Txt_PartGenDueBuild_KeyDown(sender, e);

                txt_PartGenDueMfg.Text = (PartGenDueOccu * 0.25).ToString("#0.########");

                Txt_PartGenDueMfg_KeyDown(sender, e);
            }
        }

        private void Txt_PartGenDueBuild_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGenDueBuild = double.Parse(txt_PartGenDueBuild.Text);

                GuardarValor(txt_PartGenDueBuild.Text, txt_PartGenDueBuild.Tag.ToString());

                txt_TotalPartGenDue.Text = (PartGenDueOccu + PartGenDueBuild + PartGenDueMfg).ToString("#0.########");

                Txt_TotalPartGenDue_KeyDown(sender, e);
            }
        }

        private void Txt_PartGenDueMfg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGenDueMfg = double.Parse(txt_PartGenDueMfg.Text);

                GuardarValor(txt_PartGenDueMfg.Text, txt_PartGenDueMfg.Tag.ToString());

                txt_TotalPartGenDue.Text = (PartGenDueOccu + PartGenDueBuild + PartGenDueMfg).ToString("#0.########");

                Txt_TotalPartGenDue_KeyDown(sender, e);
            }
        }

        private void Txt_AirChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_EnviVolume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                EnviVolume = double.Parse(txt_EnviVolume.Text);

                GuardarValor(txt_EnviVolume.Text, txt_EnviVolume.Tag.ToString());

                txt_AirFlow.Text = (EnviVolume * AirChange / 60).ToString("#0.########");

                Txt_AirFlow_KeyDown(sender, e);
            }
        }

        private void Txt_AirChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_DryBulbA.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AirChange = double.Parse(txt_AirChange.Text);

                    GuardarValor(txt_AirChange.Text, txt_AirChange.Tag.ToString());

                    txt_AirFlow.Text = (EnviVolume * AirChange / 60).ToString("#0.########");

                    Txt_AirFlow_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_AirFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_AirDistVentilation_MouseHover(object sender, EventArgs e)
        {
            toolTipVentilation.Show("Contamination Removal Effectiveness", txt_AirDistVentilation);
        }

        private void Txt_AirDistVentilation_MouseLeave(object sender, EventArgs e)
        {
            toolTipVentilation.Hide(txt_AirDistVentilation);
        }

        private void Txt_AirDistMax_MouseHover(object sender, EventArgs e)
        {
            toolTipMAxFactor.Show("Highest particle count / average", txt_AirDistMax);
        }

        private void Txt_AirDistMax_MouseLeave(object sender, EventArgs e)
        {
            toolTipMAxFactor.Hide(txt_AirDistMax);
        }

        private void Txt_AirDistRecovery_MouseHover(object sender, EventArgs e)
        {
            toolTipRecovery.Show("Time to achieve particle count below high limit", txt_AirDistRecovery);
        }

        private void Txt_AirDistRecovery_MouseLeave(object sender, EventArgs e)
        {
            toolTipRecovery.Hide(txt_AirDistRecovery);
        }

        private void Txt_AirDistVentilation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_AirDistMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_AirDistRecovery_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_PartConBeg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_PartConBeg1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg1 = double.Parse(txt_PartConBeg1.Text);

                GuardarValor(txt_PartConBeg1.Text, txt_PartConBeg1.Tag.ToString());

                txt_PartIncome1.Text = (AirFlow * PartConBeg1 * (1 - (AirFilter / 100))).ToString("#0.########");

                txt_PartGen1.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount1.Text = (PartConBeg1 * EnviVolume).ToString("#0.########");

                txt_PartGoing1.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg1 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg1 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount1 = double.Parse(txt_PartCount1.Text);

                PartGen1 = double.Parse(txt_PartGen1.Text);

                PartIncome1 = double.Parse(txt_PartIncome1.Text);

                PartGoing1 = double.Parse(txt_PartGoing1.Text);

                txt_PartCountEnd1.Text = (PartCount1 + PartGen1 + PartIncome1 - PartGoing1).ToString("#0.########");

                PartCountEnd1 = double.Parse(txt_PartCountEnd1.Text);

                txt_PartConEndPer1.Text = (PartCountEnd1 / EnviVolume).ToString("#0.########");

                //TIME 00:01

                PartConEndPer1 = double.Parse(txt_PartConEndPer1.Text);

                txt_PartConBeg2.Text = PartConEndPer1.ToString("#0.########");

                PartConBeg2 = double.Parse(txt_PartConBeg2.Text);

                txt_PartIncome2.Text = (AirFlow * PartConBeg2 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen2.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount2.Text = (PartConBeg2 * EnviVolume).ToString("#0.########");

                txt_PartGoing2.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg2 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg2 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount2 = double.Parse(txt_PartCount2.Text);

                PartGen2 = double.Parse(txt_PartGen2.Text);

                PartIncome2 = double.Parse(txt_PartIncome2.Text);

                PartGoing2 = double.Parse(txt_PartGoing2.Text);

                txt_PartCountEnd2.Text = (PartCount2 + PartGen2 + PartIncome2 - PartGoing2).ToString("#0.########");

                PartCountEnd2 = double.Parse(txt_PartCountEnd2.Text);

                txt_PartConEndPer2.Text = (PartCountEnd2 / EnviVolume).ToString("#0.########");

                //TIME 00:02

                PartConEndPer2 = double.Parse(txt_PartConEndPer2.Text);

                txt_PartConBeg3.Text = PartConEndPer2.ToString("#0.########");

                PartConBeg3 = double.Parse(txt_PartConBeg3.Text);

                txt_PartIncome3.Text = (AirFlow * PartConBeg3 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen3.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount3.Text = (PartConBeg3 * EnviVolume).ToString("#0.########");

                txt_PartGoing3.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg3 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg3 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount3 = double.Parse(txt_PartCount3.Text);

                PartGen3 = double.Parse(txt_PartGen3.Text);

                PartIncome3 = double.Parse(txt_PartIncome3.Text);

                PartGoing3 = double.Parse(txt_PartGoing3.Text);

                txt_PartCountEnd3.Text = (PartCount3 + PartGen3 + PartIncome3 - PartGoing3).ToString("#0.########");

                PartCountEnd3 = double.Parse(txt_PartCountEnd3.Text);

                txt_PartConEndPer3.Text = (PartCountEnd3 / EnviVolume).ToString("#0.########");

                //TIME 00:03

                PartConEndPer3 = double.Parse(txt_PartConEndPer3.Text);

                txt_PartConBeg4.Text = PartConEndPer3.ToString("#0.########");

                PartConBeg4 = double.Parse(txt_PartConBeg4.Text);

                txt_PartIncome4.Text = (AirFlow * PartConBeg4 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen4.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount4.Text = (PartConBeg4 * EnviVolume).ToString("#0.########");

                txt_PartGoing4.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg4 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg4 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount4 = double.Parse(txt_PartCount4.Text);

                PartGen4 = double.Parse(txt_PartGen4.Text);

                PartIncome4 = double.Parse(txt_PartIncome4.Text);

                PartGoing4 = double.Parse(txt_PartGoing4.Text);

                txt_PartCountEnd4.Text = (PartCount4 + PartGen4 + PartIncome4 - PartGoing4).ToString("#0.########");

                PartCountEnd4 = double.Parse(txt_PartCountEnd4.Text);

                txt_PartConEndPer4.Text = (PartCountEnd4 / EnviVolume).ToString("#0.########");

                //TIME 00:04

                PartConEndPer4 = double.Parse(txt_PartConEndPer4.Text);

                txt_PartConBeg5.Text = PartConEndPer4.ToString("#0.########");

                PartConBeg5 = double.Parse(txt_PartConBeg5.Text);

                txt_PartIncome5.Text = (AirFlow * PartConBeg5 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen5.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount5.Text = (PartConBeg5 * EnviVolume).ToString("#0.########");

                txt_PartGoing5.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg5 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg5 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount5 = double.Parse(txt_PartCount5.Text);

                PartGen5 = double.Parse(txt_PartGen5.Text);

                PartIncome5 = double.Parse(txt_PartIncome5.Text);

                PartGoing5 = double.Parse(txt_PartGoing5.Text);

                txt_PartCountEnd5.Text = (PartCount5 + PartGen5 + PartIncome5 - PartGoing5).ToString("#0.########");

                PartCountEnd5 = double.Parse(txt_PartCountEnd5.Text);

                txt_PartConEndPer5.Text = (PartCountEnd5 / EnviVolume).ToString("#0.########");

                //TIME 00:05

                PartConEndPer5 = double.Parse(txt_PartConEndPer5.Text);

                txt_PartConBeg6.Text = PartConEndPer5.ToString("#0.########");

                PartConBeg6 = double.Parse(txt_PartConBeg6.Text);

                txt_PartIncome6.Text = (AirFlow * PartConBeg6 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen6.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount6.Text = (PartConBeg6 * EnviVolume).ToString("#0.########");

                txt_PartGoing6.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg6 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg6 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount6 = double.Parse(txt_PartCount6.Text);

                PartGen6 = double.Parse(txt_PartGen6.Text);

                PartIncome6 = double.Parse(txt_PartIncome6.Text);

                PartGoing6 = double.Parse(txt_PartGoing6.Text);

                txt_PartCountEnd6.Text = (PartCount6 + PartGen6 + PartIncome6 - PartGoing6).ToString("#0.########");

                PartCountEnd6 = double.Parse(txt_PartCountEnd6.Text);

                txt_PartConEndPer6.Text = (PartCountEnd6 / EnviVolume).ToString("#0.########");

                //TIME 00:06

                PartConEndPer6 = double.Parse(txt_PartConEndPer6.Text);

                txt_PartConBeg7.Text = PartConEndPer6.ToString("#0.########");

                PartConBeg7 = double.Parse(txt_PartConBeg7.Text);

                txt_PartIncome7.Text = (AirFlow * PartConBeg7 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen7.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount7.Text = (PartConBeg7 * EnviVolume).ToString("#0.########");

                txt_PartGoing7.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg7 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg7 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount7 = double.Parse(txt_PartCount7.Text);

                PartGen7 = double.Parse(txt_PartGen7.Text);

                PartIncome7 = double.Parse(txt_PartIncome7.Text);

                PartGoing7 = double.Parse(txt_PartGoing7.Text);

                txt_PartCountEnd7.Text = (PartCount7 + PartGen7 + PartIncome7 - PartGoing7).ToString("#0.########");

                PartCountEnd7 = double.Parse(txt_PartCountEnd7.Text);

                txt_PartConEndPer7.Text = (PartCountEnd7 / EnviVolume).ToString("#0.########");

                //TIME 00:07

                PartConEndPer7 = double.Parse(txt_PartConEndPer7.Text);

                txt_PartConBeg8.Text = PartConEndPer7.ToString("#0.########");

                PartConBeg8 = double.Parse(txt_PartConBeg8.Text);

                txt_PartIncome8.Text = (AirFlow * PartConBeg8 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen8.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount8.Text = (PartConBeg8 * EnviVolume).ToString("#0.########");

                txt_PartGoing8.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg8 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg8 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount8 = double.Parse(txt_PartCount8.Text);

                PartGen8 = double.Parse(txt_PartGen8.Text);

                PartIncome8 = double.Parse(txt_PartIncome8.Text);

                PartGoing8 = double.Parse(txt_PartGoing8.Text);

                txt_PartCountEnd8.Text = (PartCount8 + PartGen8 + PartIncome8 - PartGoing8).ToString("#0.########");

                PartCountEnd8 = double.Parse(txt_PartCountEnd8.Text);

                txt_PartConEndPer8.Text = (PartCountEnd8 / EnviVolume).ToString("#0.########");

                //TIME 00:08

                PartConEndPer8 = double.Parse(txt_PartConEndPer8.Text);

                txt_PartConBeg9.Text = PartConEndPer8.ToString("#0.########");

                PartConBeg9 = double.Parse(txt_PartConBeg9.Text);

                txt_PartIncome9.Text = (AirFlow * PartConBeg9 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen9.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount9.Text = (PartConBeg9 * EnviVolume).ToString("#0.########");

                txt_PartGoing9.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg9 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg9 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount9 = double.Parse(txt_PartCount9.Text);

                PartGen9 = double.Parse(txt_PartGen9.Text);

                PartIncome9 = double.Parse(txt_PartIncome9.Text);

                PartGoing9 = double.Parse(txt_PartGoing9.Text);

                txt_PartCountEnd9.Text = (PartCount9 + PartGen9 + PartIncome9 - PartGoing9).ToString("#0.########");

                PartCountEnd9 = double.Parse(txt_PartCountEnd9.Text);

                txt_PartConEndPer9.Text = (PartCountEnd9 / EnviVolume).ToString("#0.########");

                //TIME 00:09

                PartConEndPer9 = double.Parse(txt_PartConEndPer9.Text);

                txt_PartConBeg10.Text = PartConEndPer9.ToString("#0.########");

                PartConBeg10 = double.Parse(txt_PartConBeg10.Text);

                txt_PartIncome10.Text = (AirFlow * PartConBeg10 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen10.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount10.Text = (PartConBeg10 * EnviVolume).ToString("#0.########");

                txt_PartGoing10.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg10 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg10 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount10 = double.Parse(txt_PartCount10.Text);

                PartGen10 = double.Parse(txt_PartGen10.Text);

                PartIncome10 = double.Parse(txt_PartIncome10.Text);

                PartGoing10 = double.Parse(txt_PartGoing10.Text);

                txt_PartCountEnd10.Text = (PartCount10 + PartGen10 + PartIncome10 - PartGoing10).ToString("#0.########");

                PartCountEnd10 = double.Parse(txt_PartCountEnd10.Text);

                txt_PartConEndPer10.Text = (PartCountEnd10 / EnviVolume).ToString("#0.########");

                //TIME 00:10

                PartConEndPer10 = double.Parse(txt_PartConEndPer10.Text);

                txt_PartConBeg11.Text = PartConEndPer10.ToString("#0.########");

                PartConBeg11 = double.Parse(txt_PartConBeg11.Text);

                txt_PartIncome11.Text = (AirFlow * PartConBeg11 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen11.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount11.Text = (PartConBeg11 * EnviVolume).ToString("#0.########");

                txt_PartGoing11.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg11 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg11 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount11 = double.Parse(txt_PartCount11.Text);

                PartGen11 = double.Parse(txt_PartGen11.Text);

                PartIncome11 = double.Parse(txt_PartIncome11.Text);

                PartGoing11 = double.Parse(txt_PartGoing11.Text);

                txt_PartCountEnd11.Text = (PartCount11 + PartGen11 + PartIncome11 - PartGoing11).ToString("#0.########");

                PartCountEnd11 = double.Parse(txt_PartCountEnd11.Text);

                txt_PartConEndPer11.Text = (PartCountEnd11 / EnviVolume).ToString("#0.########");

                //TIME 00:11

                PartConEndPer11 = double.Parse(txt_PartConEndPer11.Text);

                txt_PartConBeg12.Text = PartConEndPer11.ToString("#0.########");

                PartConBeg12 = double.Parse(txt_PartConBeg12.Text);

                txt_PartIncome12.Text = (AirFlow * PartConBeg12 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen12.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount12.Text = (PartConBeg12 * EnviVolume).ToString("#0.########");

                txt_PartGoing12.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg12 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg12 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount12 = double.Parse(txt_PartCount12.Text);

                PartGen12 = double.Parse(txt_PartGen12.Text);

                PartIncome12 = double.Parse(txt_PartIncome12.Text);

                PartGoing12 = double.Parse(txt_PartGoing12.Text);

                txt_PartCountEnd12.Text = (PartCount12 + PartGen12 + PartIncome12 - PartGoing12).ToString("#0.########");

                PartCountEnd12 = double.Parse(txt_PartCountEnd12.Text);

                txt_PartConEndPer12.Text = (PartCountEnd12 / EnviVolume).ToString("#0.########");

                //TIME 00:12

                PartConEndPer12 = double.Parse(txt_PartConEndPer12.Text);

                txt_PartConBeg13.Text = PartConEndPer12.ToString("#0.########");

                PartConBeg13 = double.Parse(txt_PartConBeg13.Text);

                txt_PartIncome13.Text = (AirFlow * PartConBeg13 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen13.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount13.Text = (PartConBeg13 * EnviVolume).ToString("#0.########");

                txt_PartGoing13.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg13 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg13 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount13 = double.Parse(txt_PartCount13.Text);

                PartGen13 = double.Parse(txt_PartGen13.Text);

                PartIncome13 = double.Parse(txt_PartIncome13.Text);

                PartGoing13 = double.Parse(txt_PartGoing13.Text);

                txt_PartCountEnd13.Text = (PartCount13 + PartGen13 + PartIncome13 - PartGoing13).ToString("#0.########");

                PartCountEnd13 = double.Parse(txt_PartCountEnd13.Text);

                txt_PartConEndPer13.Text = (PartCountEnd13 / EnviVolume).ToString("#0.########");

                //TIME 00:13

                PartConEndPer13 = double.Parse(txt_PartConEndPer13.Text);

                txt_PartConBeg14.Text = PartConEndPer13.ToString("#0.########");

                PartConBeg14 = double.Parse(txt_PartConBeg14.Text);

                txt_PartIncome14.Text = (AirFlow * PartConBeg14 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen14.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount14.Text = (PartConBeg14 * EnviVolume).ToString("#0.########");

                txt_PartGoing14.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg14 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg14 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount14 = double.Parse(txt_PartCount14.Text);

                PartGen14 = double.Parse(txt_PartGen14.Text);

                PartIncome14 = double.Parse(txt_PartIncome14.Text);

                PartGoing14 = double.Parse(txt_PartGoing14.Text);

                txt_PartCountEnd14.Text = (PartCount14 + PartGen14 + PartIncome14 - PartGoing14).ToString("#0.########");

                PartCountEnd14 = double.Parse(txt_PartCountEnd14.Text);

                txt_PartConEndPer14.Text = (PartCountEnd14 / EnviVolume).ToString("#0.########");

                //TIME 00:14

                PartConEndPer14 = double.Parse(txt_PartConEndPer14.Text);

                txt_PartConBeg15.Text = PartConEndPer14.ToString("#0.########");

                PartConBeg15 = double.Parse(txt_PartConBeg15.Text);

                txt_PartIncome15.Text = (AirFlow * PartConBeg15 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen15.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount15.Text = (PartConBeg15 * EnviVolume).ToString("#0.########");

                txt_PartGoing15.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg15 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg15 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount15 = double.Parse(txt_PartCount15.Text);

                PartGen15 = double.Parse(txt_PartGen15.Text);

                PartIncome15 = double.Parse(txt_PartIncome15.Text);

                PartGoing15 = double.Parse(txt_PartGoing15.Text);

                txt_PartCountEnd15.Text = (PartCount15 + PartGen15 + PartIncome15 - PartGoing15).ToString("#0.########");

                PartCountEnd15 = double.Parse(txt_PartCountEnd15.Text);

                txt_PartConEndPer15.Text = (PartCountEnd15 / EnviVolume).ToString("#0.########");

                //TIME 00:15

                PartConEndPer15 = double.Parse(txt_PartConEndPer15.Text);

                txt_PartConBeg16.Text = PartConEndPer15.ToString("#0.########");

                PartConBeg16 = double.Parse(txt_PartConBeg16.Text);

                txt_PartIncome16.Text = (AirFlow * PartConBeg16 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen16.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount16.Text = (PartConBeg16 * EnviVolume).ToString("#0.########");

                txt_PartGoing16.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg16 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg16 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount16 = double.Parse(txt_PartCount16.Text);

                PartGen16 = double.Parse(txt_PartGen16.Text);

                PartIncome16 = double.Parse(txt_PartIncome16.Text);

                PartGoing16 = double.Parse(txt_PartGoing16.Text);

                txt_PartCountEnd16.Text = (PartCount16 + PartGen16 + PartIncome16 - PartGoing16).ToString("#0.########");

                PartCountEnd16 = double.Parse(txt_PartCountEnd16.Text);

                txt_PartConEndPer16.Text = (PartCountEnd16 / EnviVolume).ToString("#0.########");

                //TIME 00:16

                PartConEndPer16 = double.Parse(txt_PartConEndPer16.Text);

                txt_PartConBeg17.Text = PartConEndPer16.ToString("#0.########");

                PartConBeg17 = double.Parse(txt_PartConBeg17.Text);

                txt_PartIncome17.Text = (AirFlow * PartConBeg17 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen17.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount17.Text = (PartConBeg17 * EnviVolume).ToString("#0.########");

                txt_PartGoing17.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg17 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg17 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount17 = double.Parse(txt_PartCount17.Text);

                PartGen17 = double.Parse(txt_PartGen17.Text);

                PartIncome17 = double.Parse(txt_PartIncome17.Text);

                PartGoing17 = double.Parse(txt_PartGoing17.Text);

                txt_PartCountEnd17.Text = (PartCount17 + PartGen17 + PartIncome17 - PartGoing17).ToString("#0.########");

                PartCountEnd17 = double.Parse(txt_PartCountEnd17.Text);

                txt_PartConEndPer17.Text = (PartCountEnd17 / EnviVolume).ToString("#0.########");

                //TIME 00:17

                PartConEndPer17 = double.Parse(txt_PartConEndPer17.Text);

                txt_PartConBeg18.Text = PartConEndPer17.ToString("#0.########");

                PartConBeg18 = double.Parse(txt_PartConBeg18.Text);

                txt_PartIncome18.Text = (AirFlow * PartConBeg18 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen18.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount18.Text = (PartConBeg18 * EnviVolume).ToString("#0.########");

                txt_PartGoing18.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg18 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg18 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount18 = double.Parse(txt_PartCount18.Text);

                PartGen18 = double.Parse(txt_PartGen18.Text);

                PartIncome18 = double.Parse(txt_PartIncome18.Text);

                PartGoing18 = double.Parse(txt_PartGoing18.Text);

                txt_PartCountEnd18.Text = (PartCount18 + PartGen18 + PartIncome18 - PartGoing18).ToString("#0.########");

                PartCountEnd18 = double.Parse(txt_PartCountEnd18.Text);

                txt_PartConEndPer18.Text = (PartCountEnd18 / EnviVolume).ToString("#0.########");

                //TIME 00:18

                PartConEndPer18 = double.Parse(txt_PartConEndPer18.Text);

                txt_PartConBeg19.Text = PartConEndPer18.ToString("#0.########");

                PartConBeg19 = double.Parse(txt_PartConBeg19.Text);

                txt_PartIncome19.Text = (AirFlow * PartConBeg19 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen19.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount19.Text = (PartConBeg19 * EnviVolume).ToString("#0.########");

                txt_PartGoing19.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg19 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg19 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount19 = double.Parse(txt_PartCount19.Text);

                PartGen19 = double.Parse(txt_PartGen19.Text);

                PartIncome19 = double.Parse(txt_PartIncome19.Text);

                PartGoing19 = double.Parse(txt_PartGoing19.Text);

                txt_PartCountEnd19.Text = (PartCount19 + PartGen19 + PartIncome19 - PartGoing19).ToString("#0.########");

                PartCountEnd19 = double.Parse(txt_PartCountEnd19.Text);

                txt_PartConEndPer19.Text = (PartCountEnd19 / EnviVolume).ToString("#0.########");

                //TIME 00:19

                PartConEndPer19 = double.Parse(txt_PartConEndPer19.Text);

                txt_PartConBeg20.Text = PartConEndPer19.ToString("#0.########");

                PartConBeg20 = double.Parse(txt_PartConBeg20.Text);

                txt_PartIncome20.Text = (AirFlow * PartConBeg20 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGen20.Text = TotalPartGenDue.ToString("#0.########");

                txt_PartCount20.Text = (PartConBeg20 * EnviVolume).ToString("#0.########");

                txt_PartGoing20.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg20 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg20 * (1 - (AirFilter/100))).ToString("#0.########");

                PartCount20 = double.Parse(txt_PartCount20.Text);

                PartGen20 = double.Parse(txt_PartGen20.Text);

                PartIncome20 = double.Parse(txt_PartIncome20.Text);

                PartGoing20 = double.Parse(txt_PartGoing20.Text);

                txt_PartCountEnd20.Text = (PartCount20 + PartGen20 + PartIncome20 - PartGoing20).ToString("#0.########");

                PartCountEnd20 = double.Parse(txt_PartCountEnd20.Text);

                txt_PartConEndPer20.Text = (PartCountEnd20 / EnviVolume).ToString("#0.########");


                ////////////////////////////////////////////
                ///
                Txt_AirDistRecovery_KeyDown(sender, e);

            }
        }

        private void Txt_PartIncome1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome1 = double.Parse(txt_PartIncome1.Text);

                txt_PartCountEnd1.Text = (PartCount1 + PartGen1 + PartIncome1 - PartGoing1).ToString("#0.########");

                Txt_PartCountEnd1_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen1 = double.Parse(txt_PartGen1.Text);

                txt_PartCountEnd1.Text = (PartCount1 + PartGen1 + PartIncome1 - PartGoing1).ToString("#0.########");

                Txt_PartCountEnd1_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount1 = double.Parse(txt_PartCount1.Text);

                txt_PartCountEnd1.Text = (PartCount1 + PartGen1 + PartIncome1 - PartGoing1).ToString("#0.########");

                Txt_PartCountEnd1_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing1 = double.Parse(txt_PartGoing1.Text);

                txt_PartCountEnd1.Text = (PartCount1 + PartGen1 + PartIncome1 - PartGoing1).ToString("#0.########");

                Txt_PartCountEnd1_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd1 = double.Parse(txt_PartCountEnd1.Text);

                txt_PartConEndPer1.Text = (PartCountEnd1 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer1_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer1 = double.Parse(txt_PartConEndPer1.Text);

                txt_PartConBeg2.Text = PartConEndPer1.ToString("#0.########");

                Txt_PartConBeg2_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg2 = double.Parse(txt_PartConBeg2.Text);

                txt_PartIncome2.Text = (AirFlow * PartConBeg2 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome2_KeyDown(sender, e);

                txt_PartGen2.Text = TotalPartGenDue.ToString("#0.########");

                Txt_PartGen2_KeyDown(sender, e);

                txt_PartCount2.Text = (PartConBeg2 * EnviVolume).ToString("#0.########");

                Txt_PartCount2_KeyDown(sender, e);

                txt_PartGoing2.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg2 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg2 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing2_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome2 = double.Parse(txt_PartIncome2.Text);

                PartGoing2 = double.Parse(txt_PartGoing2.Text);

                txt_PartCountEnd2.Text = (PartCount2 + PartGen2 + PartIncome2 - PartGoing2).ToString("#0.########");

                Txt_PartCountEnd2_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen2 = double.Parse(txt_PartGen2.Text);

                txt_PartCountEnd2.Text = (PartCount2 + PartGen2 + PartIncome2 - PartGoing2).ToString("#0.########");

                Txt_PartCountEnd2_KeyDown(sender, e);

            }
        }

        private void Txt_PartCount2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount2 = double.Parse(txt_PartCount2.Text);

                txt_PartCountEnd2.Text = (PartCount2 + PartGen2 + PartIncome2 - PartGoing2).ToString("#0.########");

                Txt_PartCountEnd2_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing2 = double.Parse(txt_PartGoing2.Text);

                txt_PartCountEnd2.Text = (PartCount2 + PartGen2 + PartIncome2 - PartGoing2).ToString("#0.########");

                Txt_PartCountEnd2_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd2 = double.Parse(txt_PartCountEnd2.Text);

                txt_PartConEndPer2.Text = (PartCountEnd2 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer2_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer2 = double.Parse(txt_PartConEndPer2.Text);

                txt_PartConBeg3.Text = PartConEndPer2.ToString("#0.########");

                Txt_PartConBeg3_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg3 = double.Parse(txt_PartConBeg3.Text);

                txt_PartIncome3.Text = (AirFlow * PartConBeg3 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome3_KeyDown(sender, e);

                txt_PartGen3.Text = TotalPartGenDue.ToString("#0.########");

                Txt_PartGen3_KeyDown(sender, e);

                txt_PartCount3.Text = (PartConBeg3 * EnviVolume).ToString("#0.########");

                Txt_PartCount3_KeyDown(sender, e);

                txt_PartGoing3.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg3 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg3 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing3_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome3 = double.Parse(txt_PartIncome3.Text);

                PartGoing3 = double.Parse(txt_PartGoing3.Text);

                txt_PartCountEnd2.Text = (PartCount3 + PartGen3 + PartIncome3 - PartGoing3).ToString("#0.########");
            }
        }

        private void Txt_PartGen3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen3 = double.Parse(txt_PartGen3.Text);

                PartIncome3 = double.Parse(txt_PartIncome3.Text);

                PartGoing3 = double.Parse(txt_PartGoing3.Text);

                txt_PartCountEnd2.Text = (PartCount3 + PartGen3 + PartIncome3 - PartGoing3).ToString("#0.########");
            }
        }

        private void Txt_PartCount3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount3 = double.Parse(txt_PartCount3.Text);

                PartGen3 = double.Parse(txt_PartGen3.Text);

                PartIncome3 = double.Parse(txt_PartIncome3.Text);

                PartGoing3 = double.Parse(txt_PartGoing3.Text);

                txt_PartCountEnd2.Text = (PartCount3 + PartGen3 + PartIncome3 - PartGoing3).ToString("#0.########");
            }
        }

        private void Txt_PartGoing3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing3 = double.Parse(txt_PartGoing3.Text);

                txt_PartCountEnd3.Text = (PartCount3 + PartGen3 + PartIncome3 - PartGoing3).ToString("#0.########");

                Txt_PartCountEnd3_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd3 = double.Parse(txt_PartCountEnd3.Text);

                txt_PartConEndPer3.Text = (PartCountEnd3 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer3_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer3 = double.Parse(txt_PartConEndPer3.Text);

                txt_PartConBeg4.Text = PartConEndPer3.ToString("#0.########");

                Txt_PartConBeg4_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg4 = double.Parse(txt_PartConBeg4.Text);

                txt_PartIncome4.Text = (AirFlow * PartConBeg4 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome4_KeyDown(sender, e);

                txt_PartCount4.Text = (PartConBeg4 * EnviVolume).ToString("#0.########");

                Txt_PartCount4_KeyDown(sender, e);

                txt_PartGoing4.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg4 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg4 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing4_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome4 = double.Parse(txt_PartIncome4.Text);

                txt_PartCountEnd4.Text = (PartCount4 + PartGen4 + PartIncome4 - PartGoing4).ToString("#0.########");

                Txt_PartCountEnd4_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen4 = double.Parse(txt_PartGen4.Text);

                txt_PartCountEnd4.Text = (PartCount4 + PartGen4 + PartIncome4 - PartGoing4).ToString("#0.########");

                Txt_PartCountEnd4_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount4 = double.Parse(txt_PartCount4.Text);

                txt_PartCountEnd4.Text = (PartCount4 + PartGen4 + PartIncome4 - PartGoing4).ToString("#0.########");

                Txt_PartCountEnd4_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing4 = double.Parse(txt_PartGoing4.Text);

                txt_PartCountEnd4.Text = (PartCount4 + PartGen4 + PartIncome4 - PartGoing4).ToString("#0.########");

                Txt_PartCountEnd4_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd4 = double.Parse(txt_PartCountEnd4.Text);

                txt_PartConEndPer4.Text = (PartCountEnd4 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer4_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer4 = double.Parse(txt_PartConEndPer4.Text);

                txt_PartConBeg5.Text = PartConEndPer4.ToString("#0.########");

                Txt_PartConBeg5_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg5 = double.Parse(txt_PartConBeg5.Text);

                txt_PartIncome5.Text = (AirFlow * PartConBeg5 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartCount5.Text = (PartConBeg5 * EnviVolume).ToString("#0.########");

                Txt_PartCount5_KeyDown(sender, e);

                txt_PartGoing5.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg5 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg5 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing5_KeyDown(sender, e);
            }

        }

        private void Txt_PartIncome5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome5 = double.Parse(txt_PartIncome5.Text);

                txt_PartCountEnd5.Text = (PartCount5 + PartGen5 + PartIncome5 - PartGoing5).ToString("#0.########");

                Txt_PartCountEnd5_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen5 = double.Parse(txt_PartGen5.Text);

                txt_PartCountEnd5.Text = (PartCount5 + PartGen5 + PartIncome5 - PartGoing5).ToString("#0.########");

                Txt_PartCountEnd5_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount5 = double.Parse(txt_PartCount5.Text);

                txt_PartCountEnd5.Text = (PartCount5 + PartGen5 + PartIncome5 - PartGoing5).ToString("#0.########");

                Txt_PartCountEnd5_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing5 = double.Parse(txt_PartGoing5.Text);

                txt_PartCountEnd5.Text = (PartCount5 + PartGen5 + PartIncome5 - PartGoing5).ToString("#0.########");

                Txt_PartCountEnd5_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd5 = double.Parse(txt_PartCountEnd5.Text);

                txt_PartConEndPer5.Text = (PartCountEnd5 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer5_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer5 = double.Parse(txt_PartConEndPer5.Text);

                txt_PartConBeg6.Text = PartConEndPer5.ToString("#0.########");

                Txt_PartConBeg6_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg6 = double.Parse(txt_PartConBeg6.Text);

                txt_PartIncome6.Text = (AirFlow * PartConBeg6 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome6_KeyDown(sender, e);

                txt_PartCount6.Text = (PartConBeg6 * EnviVolume).ToString("#0.########");

                Txt_PartCount6_KeyDown(sender, e);

                txt_PartGoing6.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg6 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg6 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing6_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome6 = double.Parse(txt_PartIncome6.Text);

                txt_PartCountEnd6.Text = (PartCount6 + PartGen6 + PartIncome6 - PartGoing6).ToString("#0.########");

                Txt_PartCountEnd6_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen6 = double.Parse(txt_PartGen6.Text);

                txt_PartCountEnd6.Text = (PartCount6 + PartGen6 + PartIncome6 - PartGoing6).ToString("#0.########");

                Txt_PartCountEnd6_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount6 = double.Parse(txt_PartCount6.Text);

                txt_PartCountEnd6.Text = (PartCount6 + PartGen6 + PartIncome6 - PartGoing6).ToString("#0.########");

                Txt_PartCountEnd6_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing6 = double.Parse(txt_PartGoing6.Text);

                txt_PartCountEnd6.Text = (PartCount6 + PartGen6 + PartIncome6 - PartGoing6).ToString("#0.########");

                Txt_PartCountEnd6_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd6 = double.Parse(txt_PartCountEnd6.Text);

                txt_PartConEndPer6.Text = (PartCountEnd6 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer6_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer6 = double.Parse(txt_PartConEndPer6.Text);

                txt_PartConBeg7.Text = PartConEndPer6.ToString("#0.########");

                Txt_PartConBeg7_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg7 = double.Parse(txt_PartConBeg7.Text);

                txt_PartIncome7.Text = (AirFlow * PartConBeg7 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome7_KeyDown(sender, e);

                txt_PartCount7.Text = (PartConBeg7 * EnviVolume).ToString("#0.########");

                Txt_PartCount7_KeyDown(sender, e);

                txt_PartGoing7.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg7 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg7 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing7_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome7 = double.Parse(txt_PartIncome7.Text);

                txt_PartCountEnd7.Text = (PartCount7 + PartGen7 + PartIncome7 - PartGoing7).ToString("#0.########");

                Txt_PartCountEnd7_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen7 = double.Parse(txt_PartGen7.Text);

                txt_PartCountEnd7.Text = (PartCount7 + PartGen7 + PartIncome7 - PartGoing7).ToString("#0.########");

                Txt_PartCountEnd7_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount7 = double.Parse(txt_PartCount7.Text);

                txt_PartCountEnd7.Text = (PartCount7 + PartGen7 + PartIncome7 - PartGoing7).ToString("#0.########");

                Txt_PartCountEnd7_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing7 = double.Parse(txt_PartGoing7.Text);

                txt_PartCountEnd7.Text = (PartCount7 + PartGen7 + PartIncome7 - PartGoing7).ToString("#0.########");

                Txt_PartCountEnd7_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd7 = double.Parse(txt_PartCountEnd7.Text);

                txt_PartConEndPer7.Text = (PartCountEnd7 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer7_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer7 = double.Parse(txt_PartConEndPer7.Text);

                txt_PartConBeg8.Text = PartConEndPer7.ToString("#0.########");

                Txt_PartConBeg8_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg8 = double.Parse(txt_PartConBeg8.Text);

                txt_PartIncome8.Text = (AirFlow * PartConBeg8 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome8_KeyDown(sender, e);

                txt_PartCount8.Text = (PartConBeg8 * EnviVolume).ToString("#0.########");

                Txt_PartCount8_KeyDown(sender, e);

                txt_PartGoing8.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg8 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg8 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing8_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome8 = double.Parse(txt_PartIncome8.Text);

                txt_PartCountEnd8.Text = (PartCount8 + PartGen8 + PartIncome8 - PartGoing8).ToString("#0.########");

                Txt_PartCountEnd8_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen8 = double.Parse(txt_PartGen8.Text);

                txt_PartCountEnd8.Text = (PartCount8 + PartGen8 + PartIncome8 - PartGoing8).ToString("#0.########");

                Txt_PartCountEnd8_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount8 = double.Parse(txt_PartCount8.Text);

                txt_PartCountEnd8.Text = (PartCount8 + PartGen8 + PartIncome8 - PartGoing8).ToString("#0.########");

                Txt_PartCountEnd8_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing8 = double.Parse(txt_PartGoing8.Text);

                txt_PartCountEnd8.Text = (PartCount8 + PartGen8 + PartIncome8 - PartGoing8).ToString("#0.########");

                Txt_PartCountEnd8_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd8 = double.Parse(txt_PartCountEnd8.Text);

                txt_PartConEndPer8.Text = (PartCountEnd8 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer8_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer8 = double.Parse(txt_PartConEndPer8.Text);

                txt_PartConBeg9.Text = PartConEndPer8.ToString("#0.########");

                Txt_PartConBeg9_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg9 = double.Parse(txt_PartConBeg9.Text);

                txt_PartIncome9.Text = (AirFlow * PartConBeg9 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome9_KeyDown(sender, e);

                txt_PartCount9.Text = (PartConBeg9 * EnviVolume).ToString("#0.########");

                Txt_PartCount9_KeyDown(sender, e);

                txt_PartGoing9.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg9 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg9 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing9_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome9 = double.Parse(txt_PartIncome9.Text);

                txt_PartCountEnd9.Text = (PartCount9 + PartGen9 + PartIncome9 - PartGoing9).ToString("#0.########");

                Txt_PartCountEnd9_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen9 = double.Parse(txt_PartGen9.Text);

                txt_PartCountEnd9.Text = (PartCount9 + PartGen9 + PartIncome9 - PartGoing9).ToString("#0.########");

                Txt_PartCountEnd9_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount9 = double.Parse(txt_PartCount9.Text);

                txt_PartCountEnd9.Text = (PartCount9 + PartGen9 + PartIncome9 - PartGoing9).ToString("#0.########");

                Txt_PartCountEnd9_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing9 = double.Parse(txt_PartGoing9.Text);

                txt_PartCountEnd9.Text = (PartCount9 + PartGen9 + PartIncome9 - PartGoing9).ToString("#0.########");

                Txt_PartCountEnd9_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd9 = double.Parse(txt_PartCountEnd9.Text);

                txt_PartConEndPer9.Text = (PartCountEnd9 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer9_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer9 = double.Parse(txt_PartConEndPer9.Text);

                txt_PartConBeg10.Text = PartConEndPer9.ToString("#0.########");

                Txt_PartConBeg10_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg10_KeyDown(object sender, KeyEventArgs e)
        {
            PartConBeg10 = double.Parse(txt_PartConBeg10.Text);

            txt_PartIncome10.Text = (AirFlow * PartConBeg10 * (1 - (AirFilter/100))).ToString("#0.########");

            Txt_PartIncome10_KeyDown(sender, e);

            txt_PartCount10.Text = (PartConBeg10 * EnviVolume).ToString("#0.########");

            Txt_PartCount10_KeyDown(sender, e);

            txt_PartGoing10.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg10 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg10 * (1 - (AirFilter/100))).ToString("#0.########");

            Txt_PartGoing10_KeyDown(sender, e);
        }

        private void Txt_PartIncome10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome10 = double.Parse(txt_PartIncome10.Text);

                PartGoing10 = double.Parse(txt_PartGoing10.Text);

                txt_PartCountEnd10.Text = (PartCount10 + PartGen10 + PartIncome10 - PartGoing10).ToString("#0.########");

                Txt_PartCountEnd10_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen10 = double.Parse(txt_PartGen10.Text);

                txt_PartCountEnd10.Text = (PartCount10 + PartGen10 + PartIncome10 - PartGoing10).ToString("#0.########");

                Txt_PartCountEnd10_KeyDown(sender, e);
            }
        }
        

        private void Txt_PartCount10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount10 = double.Parse(txt_PartCount10.Text);

                txt_PartCountEnd10.Text = (PartCount10 + PartGen10 + PartIncome10 - PartGoing10).ToString("#0.########");

                Txt_PartCountEnd10_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing10 = double.Parse(txt_PartGoing10.Text);

                txt_PartCountEnd10.Text = (PartCount10 + PartGen10 + PartIncome10 - PartGoing10).ToString("#0.########");

                Txt_PartCountEnd10_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd10 = double.Parse(txt_PartCountEnd10.Text);

                txt_PartConEndPer10.Text = (PartCountEnd10 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer10_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer10 = double.Parse(txt_PartConEndPer10.Text);

                txt_PartConBeg11.Text = PartConEndPer10.ToString("#0.########");

                Txt_PartConBeg11_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg11 = double.Parse(txt_PartConBeg11.Text);

                txt_PartIncome11.Text = (AirFlow * PartConBeg11 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome11_KeyDown(sender, e);

                txt_PartCount11.Text = (PartConBeg11 * EnviVolume).ToString("#0.########");

                Txt_PartCount11_KeyDown(sender, e);

                txt_PartGoing11.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg11 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg11 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing11_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome11 = double.Parse(txt_PartIncome11.Text);

                txt_PartCountEnd11.Text = (PartCount11 + PartGen11 + PartIncome11 - PartGoing11).ToString("#0.########");

                Txt_PartCountEnd11_KeyDown(sender, e);
            }
        }
        
        private void Txt_PartGen11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen11 = double.Parse(txt_PartGen11.Text);

                txt_PartCountEnd11.Text = (PartCount11 + PartGen11 + PartIncome11 - PartGoing11).ToString("#0.########");

                Txt_PartCountEnd11_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount11 = double.Parse(txt_PartCount11.Text);

                txt_PartCountEnd11.Text = (PartCount11 + PartGen11 + PartIncome11 - PartGoing11).ToString("#0.########");

                Txt_PartCountEnd11_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing11 = double.Parse(txt_PartGoing11.Text);

                txt_PartCountEnd11.Text = (PartCount11 + PartGen11 + PartIncome11 - PartGoing11).ToString("#0.########");

                Txt_PartCountEnd11_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd11 = double.Parse(txt_PartCountEnd11.Text);

                txt_PartConEndPer11.Text = (PartCountEnd11 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer11_KeyDown(sender, e);
            }
        }
        
        private void Txt_PartConEndPer11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer11 = double.Parse(txt_PartConEndPer11.Text);

                txt_PartConBeg12.Text = PartConEndPer11.ToString("#0.########");

                Txt_PartConBeg12_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg12 = double.Parse(txt_PartConBeg12.Text);

                txt_PartIncome12.Text = (AirFlow * PartConBeg12 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome12_KeyDown(sender, e);

                txt_PartCount12.Text = (PartConBeg12 * EnviVolume).ToString("#0.########");

                Txt_PartCount12_KeyDown(sender, e);

                txt_PartGoing12.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg12 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg12 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing12_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome12 = double.Parse(txt_PartIncome12.Text);

                txt_PartCountEnd12.Text = (PartCount12 + PartGen12 + PartIncome12 - PartGoing12).ToString("#0.########");

                Txt_PartCountEnd12_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen12 = double.Parse(txt_PartGen12.Text);

                txt_PartCountEnd12.Text = (PartCount12 + PartGen12 + PartIncome12 - PartGoing12).ToString("#0.########");

                Txt_PartCountEnd12_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount12 = double.Parse(txt_PartCount12.Text);

                txt_PartCountEnd12.Text = (PartCount12 + PartGen12 + PartIncome12 - PartGoing12).ToString("#0.########");

                Txt_PartCountEnd12_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing12 = double.Parse(txt_PartGoing12.Text);

                txt_PartCountEnd12.Text = (PartCount12 + PartGen12 + PartIncome12 - PartGoing12).ToString("#0.########");

                Txt_PartCountEnd12_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd12 = double.Parse(txt_PartCountEnd12.Text);

                txt_PartConEndPer12.Text = (PartCountEnd12 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer12_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer12 = double.Parse(txt_PartConEndPer12.Text);

                txt_PartConBeg13.Text = PartConEndPer12.ToString("#0.########");

                Txt_PartConBeg13_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg13 = double.Parse(txt_PartConBeg13.Text);

                txt_PartIncome13.Text = (AirFlow * PartConBeg13 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome13_KeyDown(sender, e);

                txt_PartCount13.Text = (PartConBeg13 * EnviVolume).ToString("#0.########");

                Txt_PartCount13_KeyDown(sender, e);

                txt_PartGoing13.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg13 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg13 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing13_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome13 = double.Parse(txt_PartIncome13.Text);

                txt_PartCountEnd13.Text = (PartCount13 + PartGen13 + PartIncome13 - PartGoing13).ToString("#0.########");

                Txt_PartCountEnd13_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen13 = double.Parse(txt_PartGen13.Text);

                txt_PartCountEnd13.Text = (PartCount13 + PartGen13 + PartIncome13 - PartGoing13).ToString("#0.########");

                Txt_PartCountEnd13_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount13 = double.Parse(txt_PartCount13.Text);

                txt_PartCountEnd13.Text = (PartCount13 + PartGen13 + PartIncome13 - PartGoing13).ToString("#0.########");

                Txt_PartCountEnd13_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing13 = double.Parse(txt_PartGoing13.Text);

                txt_PartCountEnd13.Text = (PartCount13 + PartGen13 + PartIncome13 - PartGoing13).ToString("#0.########");

                Txt_PartCountEnd13_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd13 = double.Parse(txt_PartCountEnd13.Text);

                txt_PartConEndPer13.Text = (PartCountEnd13 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer13_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer13 = double.Parse(txt_PartConEndPer13.Text);

                txt_PartConBeg14.Text = PartConEndPer13.ToString("#0.########");

                Txt_PartConBeg14_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg14 = double.Parse(txt_PartConBeg14.Text);

                txt_PartIncome14.Text = (AirFlow * PartConBeg14 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome14_KeyDown(sender, e);

                txt_PartCount14.Text = (PartConBeg14 * EnviVolume).ToString("#0.########");

                Txt_PartCount14_KeyDown(sender, e);

                txt_PartGoing14.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg14 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg14 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing14_KeyDown(sender, e);
            }
        }
        
        private void Txt_PartIncome14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome14 = double.Parse(txt_PartIncome14.Text);

                txt_PartCountEnd14.Text = (PartCount14 + PartGen14 + PartIncome14 - PartGoing14).ToString("#0.########");
                
                Txt_PartCountEnd14_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen14 = double.Parse(txt_PartGen14.Text);

                txt_PartCountEnd14.Text = (PartCount14 + PartGen14 + PartIncome14 - PartGoing14).ToString("#0.########");

                Txt_PartCountEnd14_KeyDown(sender, e);
            }
        }
        

        private void Txt_PartCount14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount14 = double.Parse(txt_PartCount14.Text);

                txt_PartCountEnd14.Text = (PartCount14 + PartGen14 + PartIncome14 - PartGoing14).ToString("#0.########");

                Txt_PartCountEnd14_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing14 = double.Parse(txt_PartGoing14.Text);

                txt_PartCountEnd14.Text = (PartCount14 + PartGen14 + PartIncome14 - PartGoing14).ToString("#0.########");

                Txt_PartCountEnd14_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd14 = double.Parse(txt_PartCountEnd14.Text);

                txt_PartConEndPer14.Text = (PartCountEnd14 / EnviVolume).ToString("#0.########");
                
                Txt_PartConEndPer14_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer14 = double.Parse(txt_PartConEndPer14.Text);

                txt_PartConBeg15.Text = PartConEndPer14.ToString("#0.########");

                Txt_PartConBeg15_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg15 = double.Parse(txt_PartConBeg15.Text);

                txt_PartIncome15.Text = (AirFlow * PartConBeg15 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome15_KeyDown(sender, e);

                txt_PartCount15.Text = (PartConBeg15 * EnviVolume).ToString("#0.########");

                Txt_PartCount15_KeyDown(sender, e);

                txt_PartGoing15.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg15 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg15 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing15_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome15 = double.Parse(txt_PartIncome15.Text);

                txt_PartCountEnd15.Text = (PartCount15 + PartGen15 + PartIncome15 - PartGoing15).ToString("#0.########");

                Txt_PartCountEnd15_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen15 = double.Parse(txt_PartGen15.Text);

                txt_PartCountEnd15.Text = (PartCount15 + PartGen15 + PartIncome15 - PartGoing15).ToString("#0.########");

                Txt_PartCountEnd15_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount15 = double.Parse(txt_PartCount15.Text);

                txt_PartCountEnd15.Text = (PartCount15 + PartGen15 + PartIncome15 - PartGoing15).ToString("#0.########");

                Txt_PartCountEnd15_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing15 = double.Parse(txt_PartGoing15.Text);

                txt_PartCountEnd15.Text = (PartCount15 + PartGen15 + PartIncome15 - PartGoing15).ToString("#0.########");

                Txt_PartCountEnd15_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd15 = double.Parse(txt_PartCountEnd15.Text);

                txt_PartConEndPer15.Text = (PartCountEnd15 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer15_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer15 = double.Parse(txt_PartConEndPer15.Text);

                txt_PartConBeg16.Text = PartConEndPer15.ToString("#0.########");

                Txt_PartConBeg16_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg16 = double.Parse(txt_PartConBeg16.Text);

                txt_PartIncome16.Text = (AirFlow * PartConBeg16 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome16_KeyDown(sender, e);

                txt_PartCount16.Text = (PartConBeg16 * EnviVolume).ToString("#0.########");

                Txt_PartCount16_KeyDown(sender, e);

                txt_PartGoing16.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg16 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg16 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing16_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome16 = double.Parse(txt_PartIncome16.Text);

                txt_PartCountEnd16.Text = (PartCount16 + PartGen16 + PartIncome16 - PartGoing16).ToString("#0.########");

                Txt_PartCountEnd16_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen16 = double.Parse(txt_PartGen16.Text);

                txt_PartCountEnd16.Text = (PartCount16 + PartGen16 + PartIncome16 - PartGoing16).ToString("#0.########");

                Txt_PartCountEnd16_KeyDown(sender, e);

            }
        }

        private void Txt_PartCount16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount16 = double.Parse(txt_PartCount16.Text);

                txt_PartCountEnd16.Text = (PartCount16 + PartGen16 + PartIncome16 - PartGoing16).ToString("#0.########");

                Txt_PartCountEnd16_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing16 = double.Parse(txt_PartGoing16.Text);

                txt_PartCountEnd16.Text = (PartCount16 + PartGen16 + PartIncome16 - PartGoing16).ToString("#0.########");

                Txt_PartCountEnd16_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd16 = double.Parse(txt_PartCountEnd16.Text);

                txt_PartConEndPer16.Text = (PartCountEnd16 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer16_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer16 = double.Parse(txt_PartConEndPer16.Text);

                txt_PartConBeg17.Text = PartConEndPer16.ToString("#0.########");

                Txt_PartConBeg17_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg17 = double.Parse(txt_PartConBeg17.Text);

                txt_PartIncome17.Text = (AirFlow * PartConBeg17 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome17_KeyDown(sender, e);

                txt_PartCount17.Text = (PartConBeg17 * EnviVolume).ToString("#0.########");

                Txt_PartCount17_KeyDown(sender, e);

                txt_PartGoing17.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg17 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg17 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing17_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome17 = double.Parse(txt_PartIncome17.Text);

                txt_PartCountEnd17.Text = (PartCount17 + PartGen17 + PartIncome17 - PartGoing17).ToString("#0.########");

                Txt_PartCountEnd17_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen17 = double.Parse(txt_PartGen17.Text);

                txt_PartCountEnd17.Text = (PartCount17 + PartGen17 + PartIncome17 - PartGoing17).ToString("#0.########");

                Txt_PartCountEnd17_KeyDown(sender, e);
            }
        }
        
        private void Txt_PartCount17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount17 = double.Parse(txt_PartCount17.Text);

                txt_PartCountEnd17.Text = (PartCount17 + PartGen17 + PartIncome17 - PartGoing17).ToString("#0.########");

                Txt_PartCountEnd17_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing17 = double.Parse(txt_PartGoing17.Text);

                txt_PartCountEnd17.Text = (PartCount17 + PartGen17 + PartIncome17 - PartGoing17).ToString("#0.########");

                Txt_PartCountEnd17_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd17 = double.Parse(txt_PartCountEnd17.Text);

                txt_PartConEndPer17.Text = (PartCountEnd17 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer17_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer17 = double.Parse(txt_PartConEndPer17.Text);

                txt_PartConBeg18.Text = PartConEndPer17.ToString("#0.########");

                Txt_PartConBeg18_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg18 = double.Parse(txt_PartConBeg18.Text);

                txt_PartIncome18.Text = (AirFlow * PartConBeg18 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome18_KeyDown(sender, e);

                txt_PartCount18.Text = (PartConBeg18 * EnviVolume).ToString("#0.########");

                Txt_PartCount18_KeyDown(sender, e);

                txt_PartGoing18.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg18 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg18 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing18_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome18 = double.Parse(txt_PartIncome18.Text);

                txt_PartCountEnd18.Text = (PartCount18 + PartGen18 + PartIncome18 - PartGoing18).ToString("#0.########");

                Txt_PartCountEnd18_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen18 = double.Parse(txt_PartGen18.Text);

                txt_PartCountEnd18.Text = (PartCount18 + PartGen18 + PartIncome18 - PartGoing18).ToString("#0.########");

                Txt_PartCountEnd18_KeyDown(sender, e);

            }
        }

        private void Txt_PartCount18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount18 = double.Parse(txt_PartCount18.Text);

                txt_PartCountEnd18.Text = (PartCount18 + PartGen18 + PartIncome18 - PartGoing18).ToString("#0.########");

                Txt_PartCountEnd18_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing18 = double.Parse(txt_PartGoing18.Text);

                txt_PartCountEnd18.Text = (PartCount18 + PartGen18 + PartIncome18 - PartGoing18).ToString("#0.########");

                Txt_PartCountEnd18_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd18 = double.Parse(txt_PartCountEnd18.Text);

                txt_PartConEndPer18.Text = (PartCountEnd18 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer18_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer18 = double.Parse(txt_PartConEndPer18.Text);

                txt_PartConBeg19.Text = PartConEndPer18.ToString("#0.########");

                Txt_PartConBeg19_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg19 = double.Parse(txt_PartConBeg19.Text);

                txt_PartIncome19.Text = (AirFlow * PartConBeg19 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome19_KeyDown(sender, e);

                txt_PartCount19.Text = (PartConBeg19 * EnviVolume).ToString("#0.########");

                Txt_PartCount19_KeyDown(sender, e);

                txt_PartGoing19.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg19 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg19 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing19_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome19 = double.Parse(txt_PartIncome19.Text);

                txt_PartCountEnd19.Text = (PartCount19 + PartGen19 + PartIncome19 - PartGoing19).ToString("#0.########");

                Txt_PartCountEnd19_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen19 = double.Parse(txt_PartGen19.Text);

                txt_PartCountEnd19.Text = (PartCount19 + PartGen19 + PartIncome19 - PartGoing19).ToString("#0.########");

                Txt_PartCountEnd19_KeyDown(sender, e);
            }
        }

        private void Txt_PartCount19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount19 = double.Parse(txt_PartCount19.Text);

                txt_PartCountEnd19.Text = (PartCount19 + PartGen19 + PartIncome19 - PartGoing19).ToString("#0.########");

                Txt_PartCountEnd19_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing19 = double.Parse(txt_PartGoing19.Text);

                txt_PartCountEnd19.Text = (PartCount19 + PartGen19 + PartIncome19 - PartGoing19).ToString("#0.########");

                Txt_PartCountEnd19_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd19 = double.Parse(txt_PartCountEnd19.Text);

                txt_PartConEndPer19.Text = (PartCountEnd19 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer19_KeyDown(sender, e);
            }
        }
        
        private void Txt_PartConEndPer19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConEndPer19 = double.Parse(txt_PartConEndPer19.Text);

                txt_PartConBeg20.Text = PartConEndPer19.ToString("#0.########");

                Txt_PartConBeg20_KeyDown(sender, e);
            }
        }

        private void Txt_PartConBeg20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartConBeg20 = double.Parse(txt_PartConBeg20.Text);

                txt_PartIncome20.Text = (AirFlow * PartConBeg20 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartIncome20_KeyDown(sender, e);

                txt_PartCount20.Text = (PartConBeg20 * EnviVolume).ToString("#0.########");

                Txt_PartCount20_KeyDown(sender, e);

                txt_PartGoing20.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg20 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg20 * (1 - (AirFilter/100))).ToString("#0.########");

                Txt_PartGoing20_KeyDown(sender, e);
            }
        }

        private void Txt_PartIncome20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartIncome20 = double.Parse(txt_PartIncome20.Text);

                txt_PartCountEnd20.Text = (PartCount20 + PartGen20 + PartIncome20 - PartGoing20).ToString("#0.########");

                Txt_PartCountEnd20_KeyDown(sender, e);
            }
        }

        private void Txt_PartGen20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGen20 = double.Parse(txt_PartGen20.Text);

                txt_PartCountEnd20.Text = (PartCount20 + PartGen20 + PartIncome20 - PartGoing20).ToString("#0.########");

                Txt_PartCountEnd20_KeyDown(sender, e);
            }
        }
        
        private void Txt_PartCount20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCount20 = double.Parse(txt_PartCount20.Text);

                txt_PartCountEnd20.Text = (PartCount20 + PartGen20 + PartIncome20 - PartGoing20).ToString("#0.########");

                Txt_PartCountEnd20_KeyDown(sender, e);
            }
        }

        private void Txt_PartGoing20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartGoing20 = double.Parse(txt_PartGoing20.Text);

                txt_PartCountEnd20.Text = (PartCount20 + PartGen20 + PartIncome20 - PartGoing20).ToString("#0.########");

                Txt_PartCountEnd20_KeyDown(sender, e);
            }
        }

        private void Txt_PartCountEnd20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PartCountEnd20 = double.Parse(txt_PartCountEnd20.Text);

                txt_PartConEndPer20.Text = (PartCountEnd20 / EnviVolume).ToString("#0.########");

                Txt_PartConEndPer20_KeyDown(sender, e);
            }
        }

        private void Txt_PartConEndPer20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                nombreAvgParticle = string.Concat("txt_PartConEndPer", txt_AirDistRecovery.Text);

                TextBox tbx = this.Controls.Find(nombreAvgParticle, true)[0] as TextBox;

                txt_AvgPartConc.Text = tbx.Text;

                Txt_AvgPartConc_KeyDown(sender, e);
            }
        }

        private void Txt_AirDistMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AirDistMax.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AirDistMax = double.Parse(txt_AirDistMax.Text);

                    GuardarValor(txt_AirDistMax.Text, txt_AirDistMax.Tag.ToString());

                    txt_MaxPartConc.Text = (AirDistMax * AvgPartConc).ToString("#0.########");

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_AirDistRecovery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AirDistRecovery.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    nombreAvgParticle = string.Concat("txt_PartConEndPer", txt_AirDistRecovery.Text);

                    GuardarValor(txt_AirDistRecovery.Text, txt_AirDistRecovery.Tag.ToString());

                    TextBox tbx = this.Controls.Find(nombreAvgParticle, true)[0] as TextBox;

                    txt_AvgPartConc.Text = tbx.Text;

                    Txt_AvgPartConc_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }

            }
        }

        private void Txt_AvgPartConc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AvgPartConc = double.Parse(txt_AvgPartConc.Text);

                txt_MaxPartConc.Text = (AirDistMax * AvgPartConc).ToString("#0.########");
            }
        }

        private void Txt_OSAWBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OSADBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                OSADBT = double.Parse(txt_OSADBT.Text);

                GuardarValor(txt_OSADBT.Text, txt_OSADBT.Tag.ToString());

                txt_OSAEnthalpy.Text = Utilities.Formulas.ENT(OSADBT, OSAWBT, 3200).ToString("#0.########");

                Txt_OSAEnthalpy_KeyDown(sender, e);

                txt_OSADensity.Text = Utilities.Formulas.DENS(OSADBT, OSAWBT, 3200).ToString("#0.########");

                Txt_OSADensity_KeyDown(sender, e);

                txt_OSAHumidity.Text = Utilities.Formulas.HUMRAT(OSADBT, OSAWBT, 3200).ToString("#0.########");

                Txt_OSAHumidity_KeyDown(sender, e);

                //txt_PCCWBT.Text = Math.Min(Utilities.Formulas.WbtHR(PCCDBT, 0.95, 3200), OSAWBT).ToString("#0.########");

                Txt_PCCWBT_KeyDown(sender, e);

                txt_EnthalDiffMAH.Text = (0.24 * (OSADBT - PCCDBT)).ToString("#0.########");

                Txt_EnthalDiffMAH_KeyDown(sender, e);

                txt_MUP_DBT1.Text = OSADBT.ToString("#0.########");
            }
        }

        private void Txt_OSAWBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OSAWBT.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OSAWBT = double.Parse(txt_OSAWBT.Text);

                    GuardarValor(txt_OSAWBT.Text, txt_OSAWBT.Tag.ToString());

                    txt_OSAEnthalpy.Text = Utilities.Formulas.ENT(OSADBT, OSAWBT, 3200).ToString("#0.########");

                    Txt_OSAEnthalpy_KeyDown(sender, e);

                    txt_OSADensity.Text = Utilities.Formulas.DENS(OSADBT, OSAWBT, 3200).ToString("#0.########");

                    Txt_OSADensity_KeyDown(sender, e);

                    txt_OSAHumidity.Text = Utilities.Formulas.HUMRAT(OSADBT, OSAWBT, 3200).ToString("#0.########");

                    Txt_OSAHumidity_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_OSAFlow_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_OSAFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_OSAFlow.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    OSAFlow = double.Parse(txt_OSAFlow.Text);

                    GuardarValor(txt_OSAFlow.Text, txt_OSAFlow.Tag.ToString());

                    txt_OSAMass.Text = (OSAFlow * OSADensity * 60).ToString("#0.########");

                    Txt_OSAMass_KeyDown(sender, e);

                    txt_PCC2Flow.Text = OSAFlow.ToString("#0.########");

                    Txt_PCC2Flow_KeyDown(sender, e);

                    txt_RAHFlow.Text = OSAFlow.ToString("#0.########");

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_OSADensity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                OSADensity = double.Parse(txt_OSADensity.Text);

                GuardarValor(txt_OSADensity.Text, txt_OSADensity.Tag.ToString());

                txt_OSAMass.Text = (OSAFlow * OSADensity * 60).ToString("#0.########");

                Txt_OSAMass_KeyDown(sender, e);
            }
        }

        private void Txt_PCCDBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_PCCDBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_PCCDBT.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    PCCDBT = double.Parse(txt_PCCDBT.Text);

                    GuardarValor(txt_PCCDBT.Text, txt_PCCDBT.Tag.ToString());

                    //txt_PCCWBT.Text = Math.Min(Utilities.Formulas.WbtHR(PCCDBT, 0.95, 3200), OSAWBT).ToString("#0.########");

                    Txt_PCCWBT_KeyDown(sender, e);

                    txt_PCCEnthalpy.Text = Utilities.Formulas.ENT(PCCDBT, PCCWBT, 3200).ToString("#0.########");

                    Txt_PCCEnthalpy_KeyDown(sender, e);

                    txt_PCCHumidity.Text = Utilities.Formulas.HUMRAT(PCCDBT, PCCWBT, 3200).ToString("#0.########");

                    Txt_PCCHumidity_KeyDown(sender, e);

                    txt_EnthalDiffMAH.Text = (0.24 * (OSADBT - PCCDBT)).ToString("#0.########");

                    Txt_EnthalDiffMAH_KeyDown(sender, e);

                    txt_MUP_DBT2.Text = PCCDBT.ToString("#0.########");

                    txt_PCC2DBT.Text = PCCDBT.ToString("#0.########");

                    Txt_PCC2DBT_KeyDown(sender, e);

                    txt_CCEnthalpy.Text = Utilities.Formulas.ENT(CCDBT, CCWBT, 3200).ToString("#0.########");

                    Txt_CCEnthalpy_KeyDown(sender, e);

                    txt_CCHumidity.Text = Utilities.Formulas.HUMRAT(CCDBT, CCWBT, 3200).ToString("#0.########");

                    Txt_CCHumidity_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_PCCWBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCCWBT = double.Parse(txt_PCCWBT.Text);

                GuardarValor(txt_PCCWBT.Text, txt_PCCWBT.Tag.ToString());

                txt_PCCEnthalpy.Text = Utilities.Formulas.ENT(PCCDBT, PCCWBT, 3200).ToString("#0.########");

                Txt_PCCEnthalpy_KeyDown(sender, e);

                txt_PCCHumidity.Text = Utilities.Formulas.HUMRAT(PCCDBT, PCCWBT, 3200).ToString("#0.########");

                Txt_PCCHumidity_KeyDown(sender, e);

                txt_PCC2WBT.Text = PCCWBT.ToString("#0.########");

                Txt_PCC2WBT_KeyDown(sender, e);

                txt_CCHumidity.Text = Utilities.Formulas.HUMRAT(CCDBT, CCWBT, 3200).ToString("#0.########");

                Txt_CCHumidity_KeyDown(sender, e);
            }
        }

        private void Txt_OSAEnthalpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                OSAEnthalpy = double.Parse(txt_OSAEnthalpy.Text);

                GuardarValor(txt_OSAEnthalpy.Text, txt_OSAEnthalpy.Tag.ToString());

                txt_EnthalpyDiff.Text = (OSAEnthalpy - PCCEnthalpy).ToString("#0.########");

                Txt_EnthalpyDiff_KeyDown(sender, e);
            }
        }

        private void Txt_PCCEnthalpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCCEnthalpy = double.Parse(txt_PCCEnthalpy.Text);

                GuardarValor(txt_PCCEnthalpy.Text, txt_PCCEnthalpy.Tag.ToString());

                txt_EnthalpyDiff.Text = (OSAEnthalpy - PCCEnthalpy).ToString("#0.########");

                Txt_EnthalpyDiff_KeyDown(sender, e);
            }
        }

        private void Txt_EnthalpyDiff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                EnthalpyDiff = double.Parse(txt_EnthalpyDiff.Text);

                GuardarValor(txt_EnthalpyDiff.Text, txt_EnthalpyDiff.Tag.ToString());

                txt_TotalMAHCool.Text = (EnthalpyDiff * OSAMass).ToString("#0.########");

                Txt_TotalMAHCool_KeyDown(sender, e);
            }

        }

        private void Txt_OSAMass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                OSAMass = double.Parse(txt_OSAMass.Text);

                GuardarValor(txt_OSAMass.Text, txt_OSAMass.Tag.ToString());

                txt_TotalMAHCool.Text = (EnthalpyDiff * OSAMass).ToString("#0.########");

                Txt_TotalMAHCool_KeyDown(sender, e);

                txt_MAHSensibleCooling.Text = (OSAMass * EnthalDiffMAH).ToString("#0.########");

                Txt_MAHSensibleCooling_KeyDown(sender, e);
            }
        }

        private void Txt_TotalMAHCool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TotalMAHCool = double.Parse(txt_TotalMAHCool.Text);

                GuardarValor(txt_TotalMAHCool.Text, txt_TotalMAHCool.Tag.ToString());

                txt_TotalMAHCoolTON.Text = (TotalMAHCool / 12000).ToString("#0.########");

                txt_MAHLatentCooling.Text = (TotalMAHCool - MAHSensibleCooling).ToString("#0.########");

                Txt_MAHLatentCooling_KeyDown(sender, e);
            }
        }

        private void Txt_EnthalDiffMAH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                EnthalDiffMAH = double.Parse(txt_EnthalDiffMAH.Text);

                GuardarValor(txt_EnthalDiffMAH.Text, txt_EnthalDiffMAH.Tag.ToString());

                txt_MAHSensibleCooling.Text = (OSAMass * EnthalDiffMAH).ToString("#0.########");

                Txt_MAHSensibleCooling_KeyDown(sender, e);
            }
        }

        private void Txt_MAHSensibleCooling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAHSensibleCooling = double.Parse(txt_MAHSensibleCooling.Text);

                GuardarValor(txt_MAHSensibleCooling.Text, txt_MAHSensibleCooling.Tag.ToString());

                txt_MAHSensibleCoolingTON.Text = (MAHSensibleCooling / 12000).ToString("#0.########");

                txt_MAHLatentCooling.Text = (TotalMAHCool - MAHSensibleCooling).ToString("#0.########");

                Txt_MAHLatentCooling_KeyDown(sender, e);
            }
        }

        private void Txt_MAHLatentCooling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAHLatentCooling = double.Parse(txt_MAHLatentCooling.Text);

                GuardarValor(txt_MAHLatentCooling.Text, txt_MAHLatentCooling.Tag.ToString());

                txt_MAHLatentCoolingTON.Text = (MAHLatentCooling / 12000).ToString("#0.########");
            }
        }

        private void Txt_OSAHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                OSAHumidity = double.Parse(txt_OSAHumidity.Text);

                GuardarValor(txt_OSAHumidity.Text, txt_OSAHumidity.Tag.ToString());

                txt_MUP_W1.Text = OSAHumidity.ToString("#0.########");
            }
        }

        private void Txt_PCCHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCCHumidity = double.Parse(txt_PCCHumidity.Text);

                GuardarValor(txt_PCCHumidity.Text, txt_PCCHumidity.Tag.ToString());

                txt_MUP_W2.Text = PCCHumidity.ToString("#0.########");
            }
        }

        private void Txt_PCC2DBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCC2DBT = double.Parse(txt_PCC2DBT.Text);

                GuardarValor(txt_PCC2DBT.Text, txt_PCC2DBT.Tag.ToString());

                txt_PCC2Enthalpy.Text = Utilities.Formulas.ENT(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

                Txt_PCC2Enthalpy_KeyDown(sender, e);

                txt_PCC2Density.Text = Utilities.Formulas.DENS(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

                Txt_PCC2Density_KeyDown(sender, e);

                txt_PCC2Humidity.Text = Utilities.Formulas.HUMRAT(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

                Txt_PCC2Humidity_KeyDown(sender, e);

                txt_CCSensEnthalpyDiff.Text = (0.24 * (PCC2DBT - CCDBT)).ToString("#0.########");

                Txt_CCSensEnthalpyDiff_KeyDown(sender, e);

                txt_MUC_DBT1.Text = PCC2DBT.ToString("#0.########");
            }
        }

        private void Txt_PCC2WBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCC2WBT = double.Parse(txt_PCC2WBT.Text);

                GuardarValor(txt_PCC2WBT.Text, txt_PCC2WBT.Tag.ToString());

                txt_PCC2Enthalpy.Text = Utilities.Formulas.ENT(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

                Txt_PCC2Enthalpy_KeyDown(sender, e);

                txt_PCC2Density.Text = Utilities.Formulas.DENS(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

                Txt_PCC2Density_KeyDown(sender, e);

                txt_PCC2Humidity.Text = Utilities.Formulas.HUMRAT(PCC2DBT, PCC2WBT, 3200).ToString("#0.########");

                Txt_PCC2Humidity_KeyDown(sender, e);

              //  txt_CCWBT.Text = Math.Min(Utilities.Formulas.WbtHR(CCDBT, 0.95, 3200), PCC2WBT).ToString("#0.########");

                Txt_CCWBT_KeyDown(sender, e);
            }
        }

        private void Txt_PCC2Flow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCC2Flow = double.Parse(txt_PCC2Flow.Text);

                GuardarValor(txt_PCC2Flow.Text, txt_PCC2Flow.Tag.ToString());

                txt_PCC2Mass.Text = (PCC2Flow * PCC2Density * 60).ToString("#0.########");

                Txt_PCC2Mass_KeyDown(sender, e);

                txt_CC2Flow.Text = PCC2Flow.ToString("#0.########");

                Txt_CC2Flow_KeyDown(sender, e);
            }
        }

        private void Txt_PCC2Density_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCC2Density = double.Parse(txt_PCC2Density.Text);

                GuardarValor(txt_PCC2Density.Text, txt_PCC2Density.Tag.ToString());

                txt_PCC2Mass.Text = (PCC2Flow * PCC2Density * 60).ToString("#0.########");

                Txt_PCC2Mass_KeyDown(sender, e);
            }
        }

        private void Txt_CCDBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CCDBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_CCDBT.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    CCDBT = double.Parse(txt_CCDBT.Text);

                    GuardarValor(txt_CCDBT.Text, txt_CCDBT.Tag.ToString());

                  //  txt_CCWBT.Text = Math.Min(Utilities.Formulas.WbtHR(CCDBT, 0.95, 3200), PCC2WBT).ToString("#0.########");

                    Txt_CCWBT_KeyDown(sender, e);

                    txt_CCEnthalpy.Text = Utilities.Formulas.ENT(CCDBT, CCWBT, 3200).ToString("#0.########");

                    Txt_CCEnthalpy_KeyDown(sender, e);

                    txt_CCSensEnthalpyDiff.Text = (0.24 * (PCC2DBT - CCDBT)).ToString("#0.########");

                    Txt_CCSensEnthalpyDiff_KeyDown(sender, e);

                    txt_MUC_DBT2.Text = CCDBT.ToString("#0.########");

                    txt_CC2DBT.Text = CCDBT.ToString("#0.########");

                    Txt_CC2DBT_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_CCWBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCWBT = double.Parse(txt_CCWBT.Text);

                GuardarValor(txt_CCWBT.Text, txt_CCWBT.Tag.ToString());

                txt_CCEnthalpy.Text = Utilities.Formulas.ENT(CCDBT, CCWBT, 3200).ToString("#0.########");

                Txt_CCEnthalpy_KeyDown(sender, e);

                txt_CC2WBT.Text = CCWBT.ToString("#0.########");

                Txt_CC2WBT_KeyDown(sender, e);
            }
        }

        private void Txt_PCC2Enthalpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCC2Enthalpy = double.Parse(txt_PCC2Enthalpy.Text);

                GuardarValor(txt_PCC2Enthalpy.Text, txt_PCC2Enthalpy.Tag.ToString());

                txt_CCEnthalpyDiff.Text = (PCC2Enthalpy - CCEnthalpy).ToString("#0.########");

                Txt_CCEnthalpyDiff_KeyDown(sender, e);

            }
        }

        private void Txt_CCEnthalpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCEnthalpy = double.Parse(txt_CCEnthalpy.Text);

                GuardarValor(txt_CCEnthalpy.Text, txt_CCEnthalpy.Tag.ToString());

                txt_CCEnthalpyDiff.Text = (PCC2Enthalpy - CCEnthalpy).ToString("#0.########");

                Txt_CCEnthalpyDiff_KeyDown(sender, e);

            }
        }

        private void Txt_CCEnthalpyDiff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCEnthalpyDiff = double.Parse(txt_CCEnthalpy.Text);

                GuardarValor(txt_CCEnthalpy.Text, txt_CCEnthalpy.Tag.ToString());

                txt_CCTotalCooling.Text = (CCEnthalpyDiff * PCC2Mass).ToString("#0.########");

                Txt_CCTotalCooling_KeyDown(sender, e);
            }
        }

        private void Txt_PCC2Mass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCC2Mass = double.Parse(txt_PCC2Mass.Text);

                GuardarValor(txt_PCC2Mass.Text, txt_PCC2Mass.Tag.ToString());

                txt_CCTotalCooling.Text = (CCEnthalpyDiff * PCC2Mass).ToString("#0.########");

                Txt_CCTotalCooling_KeyDown(sender, e);

                txt_CCSensCoolCap.Text = (PCC2Mass * CCSensEnthalpyDiff).ToString("#0.########");

                Txt_CCSensCoolCap_KeyDown(sender, e);
            }
        }

        private void Txt_CCTotalCooling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCTotalCooling = double.Parse(txt_CCTotalCooling.Text);

                txt_CCTotalCoolingTON.Text = CCTotalCooling.ToString("#0.########");

                txt_CCLatCoolCap.Text = (CCTotalCooling - CCSensCoolCap).ToString("#0.########");

                Txt_CCLatCoolCap_KeyDown(sender, e);
            }
        }

        private void Txt_CCSensEnthalpyDiff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCSensEnthalpyDiff = double.Parse(txt_CCSensEnthalpyDiff.Text);

                GuardarValor(txt_CCSensEnthalpyDiff.Text, txt_CCSensEnthalpyDiff.Tag.ToString());

                txt_CCSensCoolCap.Text = (PCC2Mass * CCSensEnthalpyDiff).ToString("#0.########");

                Txt_CCSensCoolCap_KeyDown(sender, e);
            }
        }

        private void Txt_CCSensCoolCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCSensCoolCap = double.Parse(txt_CCSensCoolCap.Text);

                GuardarValor(txt_CCSensCoolCap.Text, txt_CCSensCoolCap.Tag.ToString());

                txt_CCSensCoolCapTON.Text = (CCSensCoolCap / 12000).ToString("#0.########");

                txt_CCLatCoolCap.Text = (CCTotalCooling - CCSensCoolCap).ToString("#0.########");

                Txt_CCLatCoolCap_KeyDown(sender, e);

            }
        }

        private void Txt_CCLatCoolCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCLatCoolCap = double.Parse(txt_CCLatCoolCap.Text);

                GuardarValor(txt_CCLatCoolCap.Text, txt_CCLatCoolCap.Tag.ToString());

                txt_CCLatCoolCapTON.Text = (CCLatCoolCap / 12000).ToString("#0.########");
            }
        }

        private void Txt_PCC2Humidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PCC2Humidity = double.Parse(txt_PCC2Humidity.Text);

                GuardarValor(txt_PCC2Humidity.Text, txt_PCC2Humidity.Tag.ToString());

                txt_MUC_W1.Text = PCC2Humidity.ToString("#0.########");
            }
        }

        private void Txt_CCHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CCHumidity = double.Parse(txt_CCHumidity.Text);

                GuardarValor(txt_CCHumidity.Text, txt_CCHumidity.Tag.ToString());

                txt_MUC_W2.Text = CCHumidity.ToString("#0.########");
            }
        }

        private void Txt_CC2DBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CC2DBT = double.Parse(txt_CC2DBT.Text);

                GuardarValor(txt_CC2DBT.Text, txt_CC2DBT.Tag.ToString());

                txt_CC2Enthalpy.Text = Utilities.Formulas.ENT(CC2DBT, CC2WBT, 3200).ToString("#0.########");

                txt_CC2Density.Text = Utilities.Formulas.DENS(CC2DBT, CC2WBT, 3200).ToString("#0.########");

                Txt_CC2Density_KeyDown(sender, e);

                txt_CC2Humidity.Text = Utilities.Formulas.HUMRAT(CC2DBT, CC2WBT, 3200).ToString("#0.########");

                Txt_CC2Humidity_KeyDown(sender, e);

                txt_HCEnthDifference.Text = (0.24 * (CC2DBT - HCDBT)).ToString("#0.########");

                Txt_HCEnthDifference_KeyDown(sender, e);

                txt_MUH_DBT1.Text = CC2DBT.ToString("#0.########");
            }
        }

        private void Txt_CC2WBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CC2WBT = double.Parse(txt_CC2WBT.Text);

                txt_CC2Enthalpy.Text = Utilities.Formulas.ENT(CC2DBT, CC2WBT, 3200).ToString("#0.########");

                txt_CC2Density.Text = Utilities.Formulas.DENS(CC2DBT, CC2WBT, 3200).ToString("#0.########");

                Txt_CC2Density_KeyDown(sender, e);

                txt_CC2Humidity.Text = Utilities.Formulas.HUMRAT(CC2DBT, CC2WBT, 3200).ToString("#0.########");

                Txt_CC2Humidity_KeyDown(sender, e);
            }
        }

        private void Txt_CC2Flow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CC2Flow = double.Parse(txt_CC2Flow.Text);

                txt_CC2Mass.Text = (CC2Flow * CC2Density * 60).ToString("#0.########");

                Txt_CC2Mass_KeyDown(sender, e);
            }
        }

        private void Txt_CC2Density_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CC2Density = double.Parse(txt_CC2Density.Text);

                txt_CC2Mass.Text = (CC2Flow * CC2Density * 60).ToString("#0.########");

                Txt_CC2Mass_KeyDown(sender, e);
            }
        }

        private void Txt_HCDBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_HCDBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_HCDBT.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    HCDBT = double.Parse(txt_HCDBT.Text);

                    GuardarValor(txt_HCDBT.Text, txt_HCDBT.Tag.ToString());

                    //txt_HCWBT.Text = Utilities.Formulas.WbtW(HCDBT, HCHumidity, MUHElevation).ToString("#0.########");

                    Txt_HCWBT_KeyDown(sender, e);

                    txt_HCEnthalpy.Text = Utilities.Formulas.ENT(HCDBT, HCWBT, 3200).ToString("#0.########");

                    Txt_HCEnthalpy_KeyDown(sender, e);

                    txt_HCEnthDifference.Text = (0.24 * (CC2DBT - HCDBT)).ToString("#0.########");

                    Txt_HCEnthDifference_KeyDown(sender, e);

                    txt_MUH_DBT2.Text = HCDBT.ToString("#0.########");

                    txt_RAHDBT.Text = HCDBT.ToString("#0.########");

                    Txt_RAHDBT_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HCHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCHumidity = double.Parse(txt_HCHumidity.Text);

                GuardarValor(txt_HCHumidity.Text, txt_HCHumidity.Tag.ToString());

                //txt_HCWBT.Text = Utilities.Formulas.WbtW(HCDBT, HCHumidity, MUHElevation).ToString("#0.########");

                Txt_HCWBT_KeyDown(sender, e);

                txt_MUC_W2.Text = HCHumidity.ToString("#0.########");

                txt_RAHHumidity.Text = HCHumidity.ToString("#0.########");
            }
        }

        private void Txt_MUHElevation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MUHElevation = double.Parse(txt_MUHElevation.Text);

                GuardarValor(txt_MUHElevation.Text, txt_MUHElevation.Tag.ToString());

                //txt_HCWBT.Text = Utilities.Formulas.WbtW(HCDBT, HCHumidity, MUHElevation).ToString("#0.########");

                Txt_HCWBT_KeyDown(sender, e);
            }
        }

        private void Txt_HCWBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCWBT = double.Parse(txt_HCWBT.Text);

                GuardarValor(txt_HCWBT.Text, txt_HCWBT.Tag.ToString());

                txt_HCEnthalpy.Text = Utilities.Formulas.ENT(HCDBT, HCWBT, 3200).ToString("#0.########");

                Txt_HCEnthalpy_KeyDown(sender, e);
            }
        }

        private void Txt_CC2Humidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CC2Humidity = double.Parse(txt_CC2Humidity.Text);

                GuardarValor(txt_CC2Humidity.Text, txt_CC2Humidity.Tag.ToString());

                txt_HCHumidity.Text = CC2Humidity.ToString("#0.########");

                txt_MUH_W1.Text = CC2Humidity.ToString("#0.########");

            }
        }

        private void Txt_HCEnthalpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCEnthalpy = double.Parse(txt_HCEnthalpy.Text);

                txt_HCEntDiff.Text = (CC2Enthalpy - HCEnthalpy).ToString("#0.########");

                Txt_HCEntDiff_KeyDown(sender, e);

            }
        }

        private void Txt_HCEntDiff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCEntDiff = double.Parse(txt_HCEntDiff.Text);

                txt_HCCooling.Text = (HCEntDiff * CC2Mass).ToString("#0.########");

                Txt_HCCooling_KeyDown(sender, e);
            }
        }

        private void Txt_CC2Mass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CC2Mass = double.Parse(txt_CC2Mass.Text);

                txt_HCCooling.Text = (HCEntDiff * CC2Mass).ToString("#0.########");

                Txt_HCCooling_KeyDown(sender, e);

                txt_HCSensiCool.Text = (CC2Mass * HCEnthDifference).ToString("#0.########");

                Txt_HCSensiCool_KeyDown(sender, e);
            }
        }

        private void Txt_HCCooling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCCooling = double.Parse(txt_HCCooling.Text);

                txt_HCCoolingTON.Text = (HCCooling / 12000).ToString("#0.########");

                txt_HCLatentCool.Text = (HCCooling - HCSensiCool).ToString("#0.########");

                Txt_HCLatentCool_KeyDown(sender, e);
            }
        }

        private void Txt_HCEnthDifference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCEnthDifference = double.Parse(txt_HCEnthDifference.Text);

                txt_HCSensiCool.Text = (CC2Mass * HCEnthDifference).ToString("#0.########");

                Txt_HCSensiCool_KeyDown(sender, e);

            }
        }

        private void Txt_HCSensiCool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCSensiCool = double.Parse(txt_HCSensiCool.Text);

                txt_HCSensiCoolTON.Text = (HCSensiCool / 12000).ToString("#0.########");

                txt_HCLatentCool.Text = (HCCooling - HCSensiCool).ToString("#0.########");

                Txt_HCLatentCool_KeyDown(sender, e);
            }
        }

        private void Txt_HCLatentCool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HCLatentCool = double.Parse(txt_HCLatentCool.Text);

                txt_HCLatentCoolTON.Text = (HCLatentCool / 12000).ToString("#0.########");
            }
        }

        private void Txt_RAHDBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHDBT = double.Parse(txt_RAHDBT.Text);

                txt_RAHRH.Text = (Utilities.Formulas.HRW(RAHDBT, RAHHumidity, RAHElevation) * 100).ToString("#0.########");

                //txt_RAHWBT.Text = Utilities.Formulas.WbtW(RAHDBT, RAHHumidity, RAHElevation).ToString("#0.########");

                txt_RAHEthalpy.Text = Utilities.Formulas.ENT(RAHDBT, RAHWBT, RAHElevation).ToString("#0.########");

                txt_MADBT.Text = ((RAHDBT * RAHFlow + RAHDBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MADBT_KeyDown(sender, e);

                txt_RAH_DBT2.Text = RAHDBT.ToString("#0.########");
            }
        }

        private void Txt_RAHHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHHumidity = double.Parse(txt_RAHHumidity.Text);

                txt_RAHRH.Text = (Utilities.Formulas.HRW(RAHDBT, RAHHumidity, RAHElevation) * 100).ToString("#0.########");

               // txt_RAHWBT.Text = Utilities.Formulas.WbtW(RAHDBT, RAHHumidity, RAHElevation).ToString("#0.########");

                txt_RAH_W2.Text = RAHHumidity.ToString("#0.########");
            }
        }

        private void Txt_RAHElevation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHElevation = double.Parse(txt_RAHElevation.Text);

                txt_RAHRH.Text = (Utilities.Formulas.HRW(RAHDBT, RAHHumidity, RAHElevation) * 100).ToString("#0.########");

               // txt_RAHWBT.Text = Utilities.Formulas.WbtW(RAHDBT, RAHHumidity, RAHElevation).ToString("#0.########");

                txt_RAHEthalpy.Text = Utilities.Formulas.ENT(RAHDBT, RAHWBT, RAHElevation).ToString("#0.########");

                //txt_RAHWBTR.Text = Utilities.Formulas.WbtHR(RAHDBTR, RAHRHR, RAHElevation).ToString("#0.########");

                Txt_RAHWBTR_KeyDown(sender, e);

                txt_RAHHumidityR.Text = Utilities.Formulas.HUMRAT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");


                txt_RAHEthalpyR.Text = Utilities.Formulas.ENT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

                Txt_RAHEthalpyR_KeyDown(sender, e);

                txt_MAHumidity.Text = Utilities.Formulas.HUMRAT(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                Txt_MAHumidity_KeyDown(sender, e);

                txt_MADensity.Text = Utilities.Formulas.DENS(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                Txt_MADensity_KeyDown(sender, e);

                txt_MACCDew.Text = Utilities.Formulas.TDW(MACCHumidity, RAHElevation).ToString("#0.########");

                Txt_MACCDew_KeyDown(sender, e);

                txt_MACCHumRatio.Text = Utilities.Formulas.HUMRATTD(MACCResDewPoint, RAHElevation).ToString("#0.########");

                Txt_MACCHumRatio_KeyDown(sender, e);

                txt_RACCCWBT.Text = Utilities.Formulas.WbtTd(RAHCCDBT, RAHCCDPT, RAHElevation).ToString("#0.########");

                Txt_RACCCWBT_KeyDown(sender, e);

                txt_RAHCCEnthalpy.Text = Utilities.Formulas.ENT(RAHCCDBT, RACCCWBT, RAHElevation).ToString("#0.########");

                Txt_RAHCCEnthalpy_KeyDown(sender, e);

                txt_RACCCHumidity.Text = Utilities.Formulas.HUMRATTD(RAHCCDPT, RAHElevation).ToString("#0.########");

                Txt_RACCCHumidity_KeyDown(sender, e);
            }
        }

        private void Txt_RAHWBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHWBT = double.Parse(txt_RAHWBT.Text);

                GuardarValor(txt_RAHWBT.Text, txt_RAHWBT.Tag.ToString());

                txt_RAHEthalpy.Text = Utilities.Formulas.ENT(RAHDBT, RAHWBT, RAHElevation).ToString("#0.########");

                txt_MAWBT.Text = ((RAHWBT * RAHFlow + RAHWBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MAWBT_KeyDown(sender, e);
            }
        }

        private void Txt_AirFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AirFlow = double.Parse(txt_AirFlow.Text);

                //TIME 00:00

                txt_PartIncome1.Text = (AirFlow * PartConBeg1 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing1.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg1 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg1 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:01

                txt_PartIncome2.Text = (AirFlow * PartConBeg2 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing2.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg2 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg2 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:02

                txt_PartIncome3.Text = (AirFlow * PartConBeg3 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing3.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg3 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg3 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:03

                txt_PartIncome4.Text = (AirFlow * PartConBeg4 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing4.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg4 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg4 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:04

                txt_PartIncome5.Text = (AirFlow * PartConBeg5 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing5.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg5 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg5 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:05

                txt_PartIncome6.Text = (AirFlow * PartConBeg6 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing6.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg6 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg6 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:06

                txt_PartIncome7.Text = (AirFlow * PartConBeg7 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing7.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg7 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg7 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:07

                txt_PartIncome8.Text = (AirFlow * PartConBeg8 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing8.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg8 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg8 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:08

                txt_PartIncome9.Text = (AirFlow * PartConBeg9 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing9.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg9 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg9 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:09

                txt_PartIncome10.Text = (AirFlow * PartConBeg10 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing10.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg10 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg10 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:10

                txt_PartIncome11.Text = (AirFlow * PartConBeg11 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing11.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg11 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg11 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:11

                txt_PartIncome12.Text = (AirFlow * PartConBeg12 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing12.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg12 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg12 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:12

                txt_PartIncome13.Text = (AirFlow * PartConBeg13 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing13.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg13 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg13 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:13

                txt_PartIncome14.Text = (AirFlow * PartConBeg14 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing14.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg14 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg14 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:14

                txt_PartIncome15.Text = (AirFlow * PartConBeg15 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing15.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg15 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg15 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:15

                txt_PartIncome16.Text = (AirFlow * PartConBeg16 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing16.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg16 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg16 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:16

                txt_PartIncome17.Text = (AirFlow * PartConBeg17 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing17.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg17 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg17 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:17

                txt_PartIncome18.Text = (AirFlow * PartConBeg18 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing18.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg18 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg18 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:18

                txt_PartIncome19.Text = (AirFlow * PartConBeg19 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing19.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg19 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg19 * (1 - (AirFilter/100))).ToString("#0.########");

                //TIME 00:19

                txt_PartIncome20.Text = (AirFlow * PartConBeg20 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_PartGoing20.Text = (AirFlow * (AirDistVentilation/100) * PartConBeg20 + AirFlow * (1 - (AirDistVentilation/100)) * PartConBeg20 * (1 - (AirFilter/100))).ToString("#0.########");

                txt_RAHFlowR.Text = (AirFlow - RAHFlow).ToString("#0.########");
            }
        }

        private void Txt_RAHFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHFlow = double.Parse(txt_RAHFlow.Text);

                txt_RAHFlowR.Text = (AirFlow - RAHFlow).ToString("#0.########");

                txt_MAFlow.Text = (RAHFlow + RAHFlowR).ToString("#0.########");

                Txt_MAFlow_KeyDown(sender, e);

                txt_MADBT.Text = ((RAHDBT * RAHFlow + RAHDBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MADBT_KeyDown(sender, e);

                txt_MAWBT.Text = ((RAHWBT * RAHFlow + RAHWBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MAWBT_KeyDown(sender, e);
            }
        }

        private void Txt_RAHDBTR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_RAHRHR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_RAHDBTR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_RAHDBTR.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    RAHDBTR = double.Parse(txt_RAHDBTR.Text);

                    GuardarValor(txt_RAHDBTR.Text, txt_RAHDBTR.Tag.ToString());

                    //txt_RAHWBTR.Text = Utilities.Formulas.WbtHR(RAHDBTR, RAHRHR, RAHElevation).ToString("#0.########");

                    Txt_RAHWBTR_KeyDown(sender, e);

                    txt_RAHHumidityR.Text = Utilities.Formulas.HUMRAT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

                    txt_RAHEthalpyR.Text = Utilities.Formulas.ENT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

                    Txt_RAHEthalpyR_KeyDown(sender, e);

                    txt_MADBT.Text = ((RAHDBT * RAHFlow + RAHDBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                    //Txt_MADBT_KeyDown(sender, e);

                    txt_MACCHumidity.Text = Utilities.Formulas.HUMRATH(RAHDBTR, MACCEntalphy).ToString("#0.########");

                   // Txt_MACCHumidity_KeyDown(sender, e);

                    txt_MACCReqDryBulb.Text = (RAHDBTR - MACCEntDecrease / 0.24).ToString("#0.########");

                    Txt_MACCReqDryBulb_KeyDown(sender, e);

                    txt_RAH_DBT1.Text = RAHDBTR.ToString("#0.########");

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_RAHRHR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_RAHRHR.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    RAHRHR = double.Parse(txt_RAHRHR.Text);

                    GuardarValor(txt_RAHRHR.Text, txt_RAHRHR.Tag.ToString());

                    //txt_RAHWBTR.Text = Utilities.Formulas.WbtHR(RAHDBTR, RAHRHR, RAHElevation).ToString("#0.########");

                    Txt_RAHWBTR_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_RAHWBTR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHWBTR = double.Parse(txt_RAHWBTR.Text);

                GuardarValor(txt_RAHWBTR.Text, txt_RAHWBTR.Tag.ToString());

                txt_RAHHumidityR.Text = Utilities.Formulas.HUMRAT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

                txt_RAHEthalpyR.Text = Utilities.Formulas.ENT(RAHDBTR, RAHWBTR, RAHElevation).ToString("#0.########");

                Txt_RAHEthalpyR_KeyDown(sender, e);

                txt_MAWBT.Text = ((RAHWBT * RAHFlow + RAHWBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MAWBT_KeyDown(sender, e);
            }
        }

        private void Txt_RAHFlowR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHFlowR = double.Parse(txt_RAHFlowR.Text);

                txt_MAFlow.Text = (RAHFlow + RAHFlowR).ToString("#0.########");

                Txt_MAFlow_KeyDown(sender, e);

                txt_MAWBT.Text = ((RAHWBT * RAHFlow + RAHWBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MAWBT_KeyDown(sender, e);
            }
        }

        private void Txt_MAFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAFlow = double.Parse(txt_MAFlow.Text);

                txt_MADBT.Text = ((RAHDBT * RAHFlow + RAHDBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MADBT_KeyDown(sender, e);

                txt_MAWBT.Text = ((RAHWBT * RAHFlow + RAHWBTR * RAHFlowR) / MAFlow).ToString("#0.########");

                Txt_MAWBT_KeyDown(sender, e);

                txt_MAMass.Text = (MAFlow * MADensity * 60).ToString("#0.########");

                Txt_MAMass_KeyDown(sender, e);
            }
        }

        private void Txt_MADBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MADBT = double.Parse(txt_MAFlow.Text);

                txt_MADew.Text = Utilities.Formulas.TDP(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                txt_MAEnthalpy.Text = Utilities.Formulas.ENT(MADBT, MAWBT, 3200).ToString("#0.########");

                Txt_MAEnthalpy_KeyDown(sender, e);

                txt_MAHumidity.Text = Utilities.Formulas.HUMRAT(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                Txt_MAHumidity_KeyDown(sender, e);

                txt_MADensity.Text = Utilities.Formulas.DENS(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                Txt_MADensity_KeyDown(sender, e);

                txt_RAHSenCoolEnthDiff.Text = (0.24 * (MADBT - RAHCCDBT)).ToString("#0.########");

                Txt_RAHSenCoolEnthDiff_KeyDown(sender, e);

                txt_RAH_DBT3.Text = MADBT.ToString("#0.########");
            }
        }

        private void Txt_MAWBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAWBT = double.Parse(txt_MAWBT.Text);

                txt_MADew.Text = Utilities.Formulas.TDP(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                txt_MAEnthalpy.Text = Utilities.Formulas.ENT(MADBT, MAWBT, 3200).ToString("#0.########");

                Txt_MAEnthalpy_KeyDown(sender, e);

                txt_MAHumidity.Text = Utilities.Formulas.HUMRAT(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                Txt_MAHumidity_KeyDown(sender, e);

                txt_MADensity.Text = Utilities.Formulas.DENS(MADBT, MAWBT, RAHElevation).ToString("#0.########");

                Txt_MADensity_KeyDown(sender, e);
            }
        }

        private void Txt_MADensity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MADensity = double.Parse(txt_MADensity.Text);

                txt_MAMass.Text = (MAFlow * MADensity * 60).ToString("#0.########");

                Txt_MAMass_KeyDown(sender, e);
            }
        }

        private void Lbl_TotalLatentHeatBTU_Enter(object sender, EventArgs e)
        {
            TotalLatentHeatKW = double.Parse(lbl_TotalLatentHeatKW.Text);

            lbl_TotalLatentHeatBTU.Text = (TotalLatentHeatKW * 3412).ToString("#0.########");
        }

        private void Txt_RAHEthalpyR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHEthalpyR = double.Parse(txt_RAHEthalpyR.Text);

                txt_MACCEntalphy.Text = (RAHEthalpyR - MAInternalLat / MAMass).ToString("#0.########");

                Txt_MACCEntalphy_KeyDown(sender, e);
            }
        }

        private void Txt_MAInternalLat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAInternalLat = double.Parse(txt_MAInternalLat.Text);

                txt_MACCEntalphy.Text = (RAHEthalpyR - MAInternalLat / MAMass).ToString("#0.########");

                Txt_MACCEntalphy_KeyDown(sender, e);
            }
        }

        private void Txt_MAMass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAMass = double.Parse(txt_MAMass.Text);

                txt_MACCEntalphy.Text = (RAHEthalpyR - MAInternalLat / MAMass).ToString("#0.########");

                Txt_MACCEntalphy_KeyDown(sender, e);

                txt_MACCEntDecrease.Text = (MACCInternal / MAMass).ToString("#0.########");

                Txt_MACCReqDryBulb_KeyDown(sender, e);

                txt_TotalRAHCool.Text = (MAMass * RAHTotalEnthalpyDiff).ToString("#0.########");

                Txt_TotalRAHCool_KeyDown(sender, e);

                txt_RAHSenCoolCap.Text = (MAMass * RAHSenCoolEnthDiff).ToString("#0.########");

                Txt_RAHSenCoolCap_KeyDown(sender, e);

                if (ReHeatersQ == 1)
                {
                    txt_HeatingPower.Text = (0.24 * MAMass * (MACCReqDryBulb - RAHCCDBT)).ToString("#0.########");

                }
                else
                {
                    txt_HeatingPower.Text = "0";
                }

                Txt_HeatingPower_KeyDown(sender, e);
            }
        }

        private void Txt_MACCEntalphy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCEntalphy = double.Parse(txt_MACCEntalphy.Text);

                txt_MACCHumidity.Text = Utilities.Formulas.HUMRATH(RAHDBTR, MACCEntalphy).ToString("#0.########");

                Txt_MACCHumidity_KeyDown(sender, e);
            }
        }

        private void Txt_MACCHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCHumidity = double.Parse(txt_MACCHumidity.Text);

                txt_MACCDew.Text = Utilities.Formulas.TDW(MACCHumidity, RAHElevation).ToString("#0.########");

                Txt_MACCDew_KeyDown(sender, e);

                if (MACCHumRatio < MACCHumidity)
                {
                    txt_MACCQuestion.Text = "Yes, (1) y (2) will be used";
                    valRAHDBT = MACCReqDryBulb;
                    valRAHDPT = MACCResDewPoint;
                }
                else
                {
                    txt_MACCQuestion.Text = "No, (3) y (4) will be used";
                    valRAHDBT = MACCDry;
                    valRAHDPT = MACCDew;
                }

                txt_RAHCCDBT.Text = Math.Min(valRAHDBT, MADBT).ToString("#0.########");

                Txt_RAHCCDBT_KeyDown(sender, e);

                txt_RAHCCDPT.Text = Math.Min(valRAHDPT, MADew).ToString("#0.########");

                Txt_RAHCCDPT_KeyDown(sender, e);

                txt_RAH_W1.Text = MACCHumidity.ToString("#0.########");
            }
        }

        private void Txt_MACCDew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCDew = double.Parse(txt_MACCDew.Text);

                txt_MACCDry.Text = (MACCDew + 2).ToString("#0.########");

                Txt_MACCDry_KeyDown(sender, e);
            }
        }

        private void Lbl_TotalSensibleHeatBTU_Enter(object sender, EventArgs e)
        {
                TotalSensibleHeatBTU = double.Parse(lbl_TotalSensibleHeatBTU.Text);

                txt_MACCInternal.Text = TotalSensibleHeatBTU.ToString("#0.########");

                Txt_MACCInternal_KeyDown(sender, Key);
        }

        private void Txt_MACCInternal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCInternal = double.Parse(txt_MACCInternal.Text);

                txt_MACCEntDecrease.Text = (MACCInternal / MAMass).ToString("#0.########");

                Txt_MACCReqDryBulb_KeyDown(sender, e);
            }
        }

        private void Txt_MACCEntDecrease_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCEntDecrease = double.Parse(txt_MACCEntDecrease.Text);

                txt_MACCReqDryBulb.Text = (RAHDBTR - MACCEntDecrease / 0.24).ToString("#0.########");

                Txt_MACCReqDryBulb_KeyDown(sender, e);
            }
        }

        private void Txt_MACCReqDryBulb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCReqDryBulb = double.Parse(txt_MACCReqDryBulb.Text);

                txt_MACCResDewPoint.Text = Math.Min(MADew, MACCReqDryBulb - 2).ToString("#0.########");

                Txt_MACCResDewPoint_KeyDown(sender, e);

                if (RAHCCDBT < MACCReqDryBulb)
                {
                    txt_ReHeatersQ.Text = "TRUE";
                    
                }
                else
                {
                    txt_ReHeatersQ.Text = "FALSE";
                }

                Txt_ReHeatersQ_KeyDown(sender, e);

                if (ReHeatersQ == 1)
                {
                    txt_HeatingPower.Text = (0.24 * MAMass * (MACCReqDryBulb - RAHCCDBT)).ToString("#0.########");
                }
                else
                {
                    txt_HeatingPower.Text = "0";
                }

                Txt_HeatingPower_KeyDown(sender, e);

                txt_RAHeHDBT.Text = MACCReqDryBulb.ToString("#0.########");

                Txt_RAHeHDBT_KeyDown(sender, e);
            }
        }

        private void Txt_MADew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MADew = double.Parse(txt_MADew.Text);

                txt_MACCResDewPoint.Text = Math.Min(MADew, MACCReqDryBulb - 2).ToString("#0.########");

                Txt_MACCResDewPoint_KeyDown(sender, e);

                txt_RAHCCDPT.Text = Math.Min(valRAHDPT, MADew).ToString("#0.########");

                Txt_RAHCCDPT_KeyDown(sender, e);
            }
        }

        private void Txt_MACCResDewPoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCResDewPoint = double.Parse(txt_MACCResDewPoint.Text);

                txt_MACCHumRatio.Text = Utilities.Formulas.HUMRATTD(MACCResDewPoint, RAHElevation).ToString("#0.########");

                Txt_MACCHumRatio_KeyDown(sender, e);


            }
        }

        private void Txt_MACCHumRatio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCHumRatio = double.Parse(txt_MACCHumRatio.Text);

                if (MACCHumRatio < MACCHumidity)
                {
                    txt_MACCQuestion.Text = "Yes, (1) y (2) will be used";
                    valRAHDBT = MACCReqDryBulb;
                    valRAHDPT = MACCResDewPoint;
                }
                else
                {
                    txt_MACCQuestion.Text = "No, (3) y (4) will be used";
                    valRAHDBT = MACCDry;
                    valRAHDPT = MACCDew;
                }

                txt_RAHCCDBT.Text = Math.Min(valRAHDBT, MADBT).ToString("#0.########");

                Txt_RAHCCDBT_KeyDown(sender, e);

                txt_RAHCCDPT.Text = Math.Min(valRAHDPT, MADew).ToString("#0.########");

                Txt_RAHCCDPT_KeyDown(sender, e);
            }
        }

        private void Txt_MACCDry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MACCDry = double.Parse(txt_MACCDry.Text);

                if (MACCHumRatio < MACCHumidity)
                {
                    valRAHDBT = MACCReqDryBulb;
                }
                else
                {
                    valRAHDBT = MACCDry;
                }

                txt_RAHCCDBT.Text = Math.Min(valRAHDBT, MADBT).ToString("#0.########");

                Txt_RAHCCDBT_KeyDown(sender, e);
            }
        }

        private void Txt_RAHCCDBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHCCDBT = double.Parse(txt_RAHCCDBT.Text);

                txt_RACCCWBT.Text = Utilities.Formulas.WbtTd(RAHCCDBT, RAHCCDPT, RAHElevation).ToString("#0.########");

                Txt_RACCCWBT_KeyDown(sender, e);

                txt_RAHCCEnthalpy.Text = Utilities.Formulas.ENT(RAHCCDBT, RACCCWBT, RAHElevation).ToString("#0.########");

                Txt_RAHCCEnthalpy_KeyDown(sender, e);

                txt_RAHSenCoolEnthDiff.Text = (0.24 * (MADBT - RAHCCDBT)).ToString("#0.########");

                Txt_RAHSenCoolEnthDiff_KeyDown(sender, e);

                if (RAHCCDBT < MACCReqDryBulb)
                {
                    txt_ReHeatersQ.Text = "TRUE";
                }
                else
                {
                    txt_ReHeatersQ.Text = "FALSE";
                }

                Txt_ReHeatersQ_KeyDown(sender, e);


                if (ReHeatersQ == 1)
                {
                    txt_HeatingPower.Text = (0.24 * MAMass * (MACCReqDryBulb - RAHCCDBT)).ToString("#0.########");
                }
                else
                {
                    txt_HeatingPower.Text = "0";
                }

                Txt_HeatingPower_KeyDown(sender, e);

                txt_RAH_DBT4.Text = RAHCCDBT.ToString("#0.########");

                txt_ReH_DBT1.Text = RAHCCDBT.ToString("#0.########");
            }
        }

        private void Txt_RAHCCDPT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHCCDPT = double.Parse(txt_RAHCCDPT.Text);

                txt_RACCCWBT.Text = Utilities.Formulas.WbtTd(RAHCCDBT, RAHCCDPT, RAHElevation).ToString("#0.########");

                Txt_RACCCWBT_KeyDown(sender, e);

                txt_RACCCHumidity.Text = Utilities.Formulas.HUMRATTD(RAHCCDPT, RAHElevation).ToString("#0.########");

                Txt_RACCCHumidity_KeyDown(sender, e);
            }
        }

        private void Txt_RACCCWBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RACCCWBT = double.Parse(txt_RACCCWBT.Text);

                txt_RAHCCEnthalpy.Text = Utilities.Formulas.ENT(RAHCCDBT, RACCCWBT, RAHElevation).ToString("#0.########");

                Txt_RAHCCEnthalpy_KeyDown(sender, e);
            }
        }

        private void Txt_MAHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAHumidity = double.Parse(txt_MAHumidity.Text);

                if (MAHumidity < RACCCHumidity)
                {
                    txt_SenCoolOnly.Text = "TRUE";
 
                }
                else
                {
                    txt_SenCoolOnly.Text = "FALSE";
         
                }

                txt_RAH_W3.Text = MAHumidity.ToString("#0.########");
            }
        }

        private void Txt_RACCCHumidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RACCCHumidity = double.Parse(txt_RACCCHumidity.Text);

                if (MAHumidity < RACCCHumidity)
                {
                    txt_SenCoolOnly.Text = "TRUE";
            
                }
                else
                {
                    txt_SenCoolOnly.Text = "FALSE";
           
                }

                txt_RAHeHumRat.Text = RACCCHumidity.ToString("#0.########");

                Txt_RAHeHumRat_KeyDown(sender, e);

                txt_RAH_W4.Text = RACCCHumidity.ToString("#0.########");

                txt_ReH_W1.Text = RACCCHumidity.ToString("#0.########");
            }
        }

        private void Txt_MAEnthalpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MAEnthalpy = double.Parse(txt_MAEnthalpy.Text);

                txt_RAHTotalEnthalpyDiff.Text = (MAEnthalpy - RAHCCEnthalpy).ToString("#0.########");

                Txt_RAHTotalEnthalpyDiff_KeyDown(sender, e);
            }
        }

        private void Txt_RAHCCEnthalpy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHCCEnthalpy = double.Parse(txt_RAHCCEnthalpy.Text);

                txt_RAHTotalEnthalpyDiff.Text = (MAEnthalpy - RAHCCEnthalpy).ToString("#0.########");

                Txt_RAHTotalEnthalpyDiff_KeyDown(sender, e);
            }
        }

        private void Txt_RAHTotalEnthalpyDiff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHTotalEnthalpyDiff = double.Parse(txt_RAHTotalEnthalpyDiff.Text);

                txt_TotalRAHCool.Text = (MAMass * RAHTotalEnthalpyDiff).ToString("#0.########");

                Txt_TotalRAHCool_KeyDown(sender, e);
            }
        }

        private void Txt_TotalRAHCool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TotalRAHCool = double.Parse(txt_TotalRAHCool.Text);

                txt_TotalRAHCoolTON.Text = (TotalRAHCool / 12000).ToString("#0.########");

                txt_RAHLatCoolCap.Text = (TotalRAHCool - RAHSenCoolCap).ToString("#0.########");

                Txt_RAHLatCoolCap_KeyDown(sender, e);
            }
        }

        private void Txt_RAHSenCoolEnthDiff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHSenCoolEnthDiff = double.Parse(txt_RAHSenCoolEnthDiff.Text);

                txt_RAHSenCoolCap.Text = (MAMass * RAHSenCoolEnthDiff).ToString("#0.########");

                Txt_RAHSenCoolCap_KeyDown(sender, e);
            }
        }

        private void Txt_RAHSenCoolCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHSenCoolCap = double.Parse(txt_RAHSenCoolCap.Text);

                txt_RAHSenCoolCapTON.Text = (RAHSenCoolCap / 12000).ToString("#0.########");

                txt_RAHLatCoolCap.Text = (TotalRAHCool - RAHSenCoolCap).ToString("#0.########");

                Txt_RAHLatCoolCap_KeyDown(sender, e);
            }
        }

        private void Txt_RAHLatCoolCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHLatCoolCap = double.Parse(txt_RAHLatCoolCap.Text);

                txt_RAHLatCoolCapTON.Text = (RAHLatCoolCap / 12000).ToString("#0.########");
            }
        }

        private void Txt_ReHeatersQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_ReHeatersQ.Text == "TRUE")
                {
                    ReHeatersQ = 1;
                }
                else
                {
                    ReHeatersQ = 1;
                }
            }
        }

        private void Txt_HeatingPower_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeatingPower = double.Parse(txt_HeatingPower.Text);

                txt_ElectricalPow.Text = (HeatingPower / 3412).ToString("#0.########");

                Txt_ElectricalPow_KeyDown(sender, e);
            }
        }

        private void Txt_ElectricalPow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ElectricalPow = double.Parse(txt_ElectricalPow.Text);

                txt_ElectricalPowFlow.Text = (ElectricalPow * 1000 / MAFlow).ToString("#0.########");
            }
        }

        private void Txt_RAHeHumRat_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                RAHeHumRat = double.Parse(txt_RAHeHumRat.Text);

                txt_ReH_W2.Text = RAHeHumRat.ToString("#0.########");
            }

        }

        private void Txt_RAHeHDBT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                RAHeHDBT = double.Parse(txt_RAHeHDBT.Text);

                txt_ReH_DBT2.Text = RAHeHDBT.ToString("#0.########");

            }
        }

        private void Btn_GraphPartConc_Click_1(object sender, EventArgs e)
        {
            frm_Grafico frm_Grafico = new frm_Grafico(1, ObtenerCartaPsicometrica(),Elevation);
            frm_Grafico.Show();
        }

        private double[] ObtenerCartaPsicometrica()
        {
            double[]  _lista = { PartConEndPer1, PartConEndPer2, PartConEndPer3 , PartConEndPer4 , PartConEndPer5, PartConEndPer6, PartConEndPer7, PartConEndPer8, PartConEndPer9, PartConEndPer10, PartConEndPer11, PartConEndPer12, PartConEndPer13, PartConEndPer14, PartConEndPer15, PartConEndPer16, PartConEndPer17, PartConEndPer18, PartConEndPer19, PartConEndPer20 };

            return _lista;
        }

        private void Txt_AirFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AirFilter.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AirFilter = double.Parse(txt_AirFilter.Text);

                    GuardarValor(txt_AirFilter.Text, txt_AirFilter.Tag.ToString());

                    Txt_PartConBeg1_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_EnviHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_EnviWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_EnviLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void TabGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabGeneral.SelectedTab.Text == "General Information")
            {
                tabActiva = TabActiva.TabGeneralInformation;

            }
            else if (tabGeneral.SelectedTab.Text == "Outside Air")
            {
                tabActiva = TabActiva.TabOutsideAir;

                if(tabsVisitadas["Outside_Air"]==0)
                {
                    //CargarOutsideAir();

                    //CargarFuga();

                    tabsVisitadas.Remove("Outside_Air");
                    tabsVisitadas.Add("Outside_Air", 1);
                }
            }
            else if (tabGeneral.SelectedTab.Text == "Particle Concentration")
            {
                tabActiva = TabActiva.TabParticleConc;

                if (tabsVisitadas["Particle_Concentration"] == 0)
                {
                    ///ParticleConcentration();

                    tabsVisitadas.Remove("Particle_Concentration");
                    tabsVisitadas.Add("Particle_Concentration", 1);
                }
            }
            else if (tabGeneral.SelectedTab.Text == "Make Up Precooling")
            {
                tabActiva = TabActiva.TabMUP;

                if (tabsVisitadas["Make_Up_Precooling"] == 0)
                {
                    

                    tabsVisitadas.Remove("Make_Up_Precooling");
                    tabsVisitadas.Add("Make_Up_Precooling", 1);
                }
            }
            else if (tabGeneral.SelectedTab.Text == "Make Up Cooling")
            {
                tabActiva = TabActiva.TabMUC;

                if (tabsVisitadas["Make_Up_Cooling"] == 0)
                {
                    

                    tabsVisitadas.Remove("Make_Up_Cooling");
                    tabsVisitadas.Add("Make_Up_Cooling", 1);
                }
            }
            else if (tabGeneral.SelectedTab.Text == "Make Up Heating")
            {
                tabActiva = TabActiva.TabMUH;

                if (tabsVisitadas["Make_Up_Heating"] == 0)
                {
                    

                    tabsVisitadas.Remove("Make_Up_Heating");
                    tabsVisitadas.Add("Make_Up_Heating", 1);
                }
            }
            else if (tabGeneral.SelectedTab.Text == "Recirculating Air Handler")
            {
                tabActiva = TabActiva.TabRAH;

                if (tabsVisitadas["Recirculating_Air_Handler"] == 0)
                {
                   

                    tabsVisitadas.Remove("Recirculating_Air_Handler");
                    tabsVisitadas.Add("Recirculating_Air_Handler", 1);
                }
            }
            else // Carta
            {
                tabActiva = TabActiva.TabCarta;

                if (tabsVisitadas["Carta"] == 0)
                {
                    chart1.Series["Series1"].IsVisibleInLegend = false;

                    tabsVisitadas.Remove("Carta");
                    tabsVisitadas.Add("Carta", 1);
                }
            }
        }

        public void CargarVariablesTabGenInfo()
        {
            object objeto = new object();

            Guardar = false;

            Txt_DryBulbA_KeyDown(objeto, Key);
            Txt_Relative_KeyDown(objeto, Key);
            Txt_WetBulbA_KeyDown(objeto, Key);
            Txt_HumityRadioA_KeyDown(objeto, Key);
            Txt_HumityRadioGRA_KeyDown(objeto, Key);

            Txt_DryBulbB_KeyDown(objeto, Key);
            Txt_WetBuilB_KeyDown(objeto, Key);
            Txt_HumityRadioB_KeyDown(objeto, Key);
            Txt_HumityRadioGRB_KeyDown(objeto, Key);

            Txt_LenghtM_KeyDown(objeto, Key);
            Txt_WidthM_KeyDown(objeto, Key);
            Txt_AvgCeilingM_KeyDown(objeto, Key);
            Txt_FloorAreaM_KeyDown(objeto, Key);
            Txt_WallAreaM_KeyDown(objeto, Key);
            Txt_VolumeM_KeyDown(objeto, Key);
            Txt_LenghtE_KeyDown(objeto, Key);
            Txt_WidthE_KeyDown(objeto, Key);
            Txt_AvgCeilingE_KeyDown(objeto, Key);
            Txt_FloorAreaE_KeyDown(objeto, Key);
            Txt_VolumeE_KeyDown(objeto, Key);

            Txt_OutsideTempRoof_KeyDown(objeto, Key);
            Txt_InsideTempRoof_KeyDown(objeto, Key);
            Txt_TempDiffRoof_KeyDown(objeto, Key);
            Txt_UFactorRoof_KeyDown(objeto, Key);
            Txt_RoofArea_KeyDown(objeto, Key);
            Txt_HeatGainRoof_KeyDown(objeto, Key);

            Txt_OutsideTempWall_KeyDown(objeto, Key);
            Txt_InsideTempWall_KeyDown(objeto, Key);
            Txt_TempDiffWall_KeyDown(objeto, Key);
            Txt_UFactorWall_KeyDown(objeto, Key);
            Txt_WallArea_KeyDown(objeto, Key);
            Txt_HeatGainWall_KeyDown(objeto, Key);

            Txt_OutsideTempFloor_KeyDown(objeto, Key);
            Txt_InsideTempFloor_KeyDown(objeto, Key);
            Txt_TempDiffFloor_KeyDown(objeto, Key);
            Txt_UFactorFloor_KeyDown(objeto, Key);
            Txt_FloorArea_KeyDown(objeto, Key);
            Txt_HeatGainFloor_KeyDown(objeto, Key);

            Txt_SubtotalFloor_KeyDown(objeto, Key);
            Txt_GainWRF_KeyDown(objeto, Key);
            Txt_LightDensity_KeyDown(objeto, Key);
            Txt_FloorAreaLight_KeyDown(objeto, Key);
            Txt_HeatGainLight_KeyDown(objeto, Key);
            Txt_HeadcountD_KeyDown(objeto, Key);

            Txt_SeatedRest_KeyDown(objeto, Key);
            Txt_SeatedLight_KeyDown(objeto, Key);
            Txt_OfficeWork_KeyDown(objeto, Key);
            Txt_Standing_KeyDown(objeto, Key);
            Txt_Waking_KeyDown(objeto, Key);
            Txt_ModerateWork_KeyDown(objeto, Key);
            Txt_LightBench_KeyDown(objeto, Key);
            Txt_ModerateDancing_KeyDown(objeto, Key);
            Txt_FastWaking_KeyDown(objeto, Key);
            Txt_HevyWork_KeyDown(objeto, Key);

            Txt_SeatedRestP_KeyDown(objeto, Key);
            Txt_SeatedLightP_KeyDown(objeto, Key);
            Txt_OfficeWorkP_KeyDown(objeto, Key);
            Txt_StandingP_KeyDown(objeto, Key);
            Txt_WakingP_KeyDown(objeto, Key);
            Txt_ModerateWorkP_KeyDown(objeto, Key);
            Txt_LightBenchP_KeyDown(objeto, Key);
            Txt_ModerateDancingP_KeyDown(objeto, Key);
            Txt_FastWakingP_KeyDown(objeto, Key);
            Txt_HevyWorkP_KeyDown(objeto, Key);

            Txt_SubtotalPeoGain_KeyDown(objeto, Key);
            Txt_HeatGainPeople_KeyDown(objeto, Key);

            Txt_InsideTemp_KeyDown(objeto, Key);
            Txt_FloorAreaEquip_KeyDown(objeto, Key);
            Txt_GainEquip_KeyDown(objeto, Key);

            Txt_HeadcountE_KeyDown(objeto, Key);


            Txt_Seated_KeyDown(objeto, Key);
            Txt_SeatedVeLight_KeyDown(objeto, Key);
            Txt_OffWork_KeyDown(objeto, Key);
            Txt_LabWork_KeyDown(objeto, Key);
            Txt_WalkSea_KeyDown(objeto, Key);
            Txt_ModWork_KeyDown(objeto, Key);
            Txt_LigBenWork_KeyDown(objeto, Key);
            Txt_ModDance_KeyDown(objeto, Key);
            Txt_FastWalk_KeyDown(objeto, Key);
            Txt_HeaWork_KeyDown(objeto, Key);

            Txt_SeatedP_KeyDown(objeto, Key);
            Txt_SeatedVeLightP_KeyDown(objeto, Key);
            Txt_OffWorkP_KeyDown(objeto, Key);
            Txt_LabWorkP_KeyDown(objeto, Key);
            Txt_WalkSeaP_KeyDown(objeto, Key);
            Txt_ModWorkP_KeyDown(objeto, Key);
            Txt_LigBenWorkP_KeyDown(objeto, Key);
            Txt_ModDanceP_KeyDown(objeto, Key);
            Txt_FastWalkP_KeyDown(objeto, Key);
            Txt_HeaWorkP_KeyDown(objeto, Key);

            Txt_SubtotalLatHeat_KeyDown(objeto, Key);
            Txt_HeatGaPeople_KeyDown(objeto, Key);

            Txt_VolumeLate_KeyDown(objeto, Key);
            Txt_HumDiff_KeyDown(objeto, Key);
            Txt_HumityFact_KeyDown(objeto, Key);
            Txt_VolumeFact_KeyDown(objeto, Key);
            Txt_ConstructionFact_KeyDown(objeto, Key);
            Txt_VaporFact_KeyDown(objeto, Key);

            Txt_HumGainGR_KeyDown(objeto, Key);
            Txt_HumGainLB_KeyDown(objeto, Key);

            Guardar = true;
        }

        private void Tabs_General_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs_General.SelectedTab.Text == "Design Cond")
            {
                tabActivaGeneralInfo = TabActivaGeneralInfo.TabDesignCond;

                if (tabsVisitadas["Design"] == 0)
                {
                   // CargarDesignCond();

                    tabsVisitadas.Remove("Design");
                    tabsVisitadas.Add("Design", 1);
                }
                
            }
            else if (tabs_General.SelectedTab.Text == "Internal SHL")
            {
                tabActivaGeneralInfo = TabActivaGeneralInfo.TabInternalSHL;

                if (tabsVisitadas["SHL"] == 0)
                {
                    //CargarInternalSHL();

                    tabsVisitadas.Remove("SHL");
                    tabsVisitadas.Add("SHL", 1);
                }
                
            }
            else 
            {
                tabActivaGeneralInfo = TabActivaGeneralInfo.TabInternalLHL;

                if (tabsVisitadas["LHL"] == 0)
                {
                   
                   // CargarInternalLHL();

                    tabsVisitadas.Remove("LHL");
                    tabsVisitadas.Add("LHL", 1);
                }
                
            }
        }

        private void Txt_Density_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_WallAreaE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                WallAreaE = double.Parse(txt_WallAreaE.Text);

                GuardarValor(txt_WallAreaE.Text, txt_WallAreaE.Tag.ToString());

                txt_WallArea.Text = WallAreaE.ToString("#0.########");

            }
        }

        private void Txt_VapoHeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_VapoHeat.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    VapoHeat = double.Parse(txt_VapoHeat.Text);

                    GuardarValor(txt_VapoHeat.Text, txt_VapoHeat.Tag.ToString());

                    txt_SubtotalHumidity.Text = (HumGainLB * VapoHeat).ToString("#0.########");

                    Txt_SubtotalHumidity_KeyDown(sender, e);

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void Txt_HeadCountOccu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                HeadCountOccu = double.Parse(txt_HeadCountOccu.Text);

                GuardarValor(txt_HeadCountOccu.Text, txt_HeadCountOccu.Tag.ToString());

            }
        }

        private void Txt_TotalPartGenDue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TotalPartGenDue = double.Parse(txt_TotalPartGenDue.Text);

                LlenarParticleGeneration();

                //Txt_PartConBeg1_KeyDown(sender, e);
            }
        }

        private void LlenarParticleGeneration()
        {
            txt_PartCount1.Text = TotalPartGenDue.ToString("#0.########");

            PartCount1 = double.Parse(txt_PartCount1.Text);

            txt_PartCount2.Text = TotalPartGenDue.ToString("#0.########");

            PartCount2 = double.Parse(txt_PartCount2.Text);

            txt_PartCount3.Text = TotalPartGenDue.ToString("#0.########");

            PartCount3 = double.Parse(txt_PartCount3.Text);

            txt_PartCount4.Text = TotalPartGenDue.ToString("#0.########");

            PartCount4 = double.Parse(txt_PartCount4.Text);

            txt_PartCount5.Text = TotalPartGenDue.ToString("#0.########");

            PartCount5 = double.Parse(txt_PartCount5.Text);

            txt_PartCount6.Text = TotalPartGenDue.ToString("#0.########");

            PartCount6 = double.Parse(txt_PartCount6.Text);

            txt_PartCount7.Text = TotalPartGenDue.ToString("#0.########");

            PartCount7 = double.Parse(txt_PartCount7.Text);

            txt_PartCount8.Text = TotalPartGenDue.ToString("#0.########");

            PartCount8 = double.Parse(txt_PartCount8.Text);

            txt_PartCount9.Text = TotalPartGenDue.ToString("#0.########");

            PartCount9 = double.Parse(txt_PartCount9.Text);

            txt_PartCount10.Text = TotalPartGenDue.ToString("#0.########");

            PartCount10 = double.Parse(txt_PartCount10.Text);

            txt_PartCount11.Text = TotalPartGenDue.ToString("#0.########");

            PartCount11 = double.Parse(txt_PartCount11.Text);

            txt_PartCount12.Text = TotalPartGenDue.ToString("#0.########");

            PartCount12 = double.Parse(txt_PartCount12.Text);

            txt_PartCount13.Text = TotalPartGenDue.ToString("#0.########");

            PartCount13 = double.Parse(txt_PartCount13.Text);

            txt_PartCount14.Text = TotalPartGenDue.ToString("#0.########");

            PartCount14 = double.Parse(txt_PartCount14.Text);

            txt_PartCount15.Text = TotalPartGenDue.ToString("#0.########");

            PartCount15 = double.Parse(txt_PartCount15.Text);

            txt_PartCount16.Text = TotalPartGenDue.ToString("#0.########");

            PartCount16 = double.Parse(txt_PartCount16.Text);

            txt_PartCount17.Text = TotalPartGenDue.ToString("#0.########");

            PartCount17 = double.Parse(txt_PartCount17.Text);

            txt_PartCount18.Text = TotalPartGenDue.ToString("#0.########");

            PartCount18 = double.Parse(txt_PartCount18.Text);

            txt_PartCount19.Text = TotalPartGenDue.ToString("#0.########");

            PartCount19 = double.Parse(txt_PartCount19.Text);

            txt_PartCount20.Text = TotalPartGenDue.ToString("#0.########");

            PartCount20 = double.Parse(txt_PartCount20.Text);
        }

        private void TabsParticleCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsParticleCon.SelectedTab.Text == "Particle Concentration")
            {
                tabActivaGeneralInfo = TabActivaGeneralInfo.TabDesignCond;

                if (tabsVisitadas["PC"] == 0)
                {
                    tabsVisitadas.Remove("PC");
                    tabsVisitadas.Add("PC", 1);
                }

            }
            else if (tabsParticleCon.SelectedTab.Text == "Graphic")
            {
                tabActivaGeneralInfo = TabActivaGeneralInfo.TabInternalSHL;

                if (tabsVisitadas["Graphic"] == 0)
                {
                   // Txt_PartConBeg1_KeyDown(sender, Key);

                    tabsVisitadas.Remove("Graphic");
                    tabsVisitadas.Add("Graphic", 1);
                }

            }
        }

        private void Txt_AirDistVentilation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txt_AirDistVentilation.Text.Trim().Equals(string.Empty))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    AirDistVentilation = double.Parse(txt_AirDistVentilation.Text);

                    GuardarValor(txt_AirDistVentilation.Text, txt_AirDistVentilation.Tag.ToString());

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Por favor colocar un numero válido");
                }
            }
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            frm_Grafico grafico = new frm_Grafico(5, CargarMUC(), Elevation);
            grafico.Show();
        }

        public double[,] CargarMUC()
        {
            MUC_DBT1 = double.Parse(txt_MUC_DBT1.Text);
            MUC_DBT2 = double.Parse(txt_MUC_DBT2.Text);

            MUC_W1 = double.Parse(txt_MUC_W1.Text);
            MUC_W2 = double.Parse(txt_MUC_W2.Text);

            matrizMUC = new double[2, 2];

            matrizMUC[0, 0] = MUC_DBT1;

            matrizMUC[0, 1] = MUC_W1;

            matrizMUC[1, 0] = MUC_DBT2;

            matrizMUC[1, 1] = MUC_W2;

            return matrizMUC;
        }

        private void MaterialRaisedButton3_Click(object sender, EventArgs e)
        {
            frm_Grafico grafico = new frm_Grafico(6, CargarMUH(),Elevation);
            grafico.Show();
        }


        public double[,] CargarMUH()
        {
            MUH_DBT1 = double.Parse(txt_MUH_DBT1.Text);
            MUH_DBT2 = double.Parse(txt_MUH_DBT2.Text);

            MUH_W1 = double.Parse(txt_MUH_W1.Text);
            MUH_W2 = double.Parse(txt_MUH_W2.Text);

            matrizMUC = new double[2, 2];

            matrizMUC[0, 0] = MUH_DBT1;

            matrizMUC[0, 1] = MUH_W1;

            matrizMUC[1, 0] = MUH_DBT2;

            matrizMUC[1, 1] = MUH_W2;

            return matrizMUC;
        }


        private void Txt_CP_Point1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Dbt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_W1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Comment1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Point2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Dbt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_W2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Comment2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Point3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Dbt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_W3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Comment3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Point4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Dbt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_W4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Txt_CP_Comment4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }

            // we only allow one decimal point here
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }


        private void Txt_CP_Point1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Point1.Text, txt_CP_Point1.Tag.ToString());
            }
        }

        private void Txt_CP_Dbt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Dbt1.Text, txt_CP_Dbt1.Tag.ToString());
            }
        }

        private void Txt_CP_W1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_W1.Text, txt_CP_W1.Tag.ToString());
            }
        }

        private void Txt_CP_Comment1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Comment1.Text, txt_CP_Comment1.Tag.ToString());
            }
        }

        private void Txt_CP_Point2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Point2.Text, txt_CP_Point2.Tag.ToString());
            }
        }

        private void Txt_CP_Dbt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Dbt2.Text, txt_CP_Dbt2.Tag.ToString());
            }
        }

        private void Txt_CP_W2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_W2.Text, txt_CP_W2.Tag.ToString());
            }
        }

        private void Txt_CP_Comment2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Comment2.Text, txt_CP_Comment2.Tag.ToString());
            }
        }

        private void Txt_CP_Point3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Point3.Text, txt_CP_Point3.Tag.ToString());
            }
        }

        private void Txt_CP_Dbt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Dbt3.Text, txt_CP_Dbt3.Tag.ToString());
            }
        }

        private void Txt_CP_W3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_W3.Text, txt_CP_W3.Tag.ToString());
            }
        }

        private void Txt_CP_Comment3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Comment3.Text, txt_CP_Comment3.Tag.ToString());
            }
        }

        private void Txt_CP_Point4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Point4.Text, txt_CP_Point4.Tag.ToString());
            }
        }

        private void Txt_CP_Dbt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Dbt4.Text, txt_CP_Dbt4.Tag.ToString());
            }
        }

        private void Txt_CP_W4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_W4.Text, txt_CP_W4.Tag.ToString());
            }
        }

        private void Txt_CP_Comment4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GuardarValor(txt_CP_Comment4.Text, txt_CP_Comment4.Tag.ToString());
            }
        }

        private void Btn_GenerarGrafico_Click(object sender, EventArgs e)
        {
            if(!txt_ElevationCart.Text.Trim().Equals(string.Empty))
            {
                frm_Grafico grafico = new frm_Grafico(8, CargarCarta(), double.Parse(txt_ElevationCart.Text));
                grafico.Show();
            }
            else
            {
                MessageBox.Show("Por favor colocar una elevacion valida");
            }
        }

        public double[,] CargarRAH()
        {
            RAH_DBT1 = double.Parse(txt_RAH_DBT1.Text);
            RAH_W1 = double.Parse(txt_RAH_W1.Text);

            RAH_DBT2 = double.Parse(txt_RAH_DBT2.Text);
            RAH_W2 = double.Parse(txt_RAH_W2.Text);

            RAH_DBT3 = double.Parse(txt_RAH_DBT3.Text);
            RAH_W3 = double.Parse(txt_RAH_W3.Text);

            RAH_DBT4 = double.Parse(txt_RAH_DBT4.Text);
            RAH_W4 = double.Parse(txt_RAH_W4.Text);

            // REH

            ReH_DBT1 = double.Parse(txt_ReH_DBT1.Text);
            ReH_W1 = double.Parse(txt_ReH_W1.Text);

            ReH_DBT2 = double.Parse(txt_ReH_DBT1.Text);
            ReH_W2 = double.Parse(txt_ReH_W2.Text);


            matrizRAH = new double[6, 2];

            matrizRAH[0, 0] = RAH_DBT1;

            matrizRAH[0, 1] = RAH_W1;

            matrizRAH[1, 0] = RAH_DBT2;

            matrizRAH[1, 1] = RAH_W2;

            matrizRAH[2, 0] = RAH_DBT3;

            matrizRAH[2, 1] = RAH_W3;

            matrizRAH[3, 0] = RAH_DBT4;

            matrizRAH[3, 1] = RAH_W4;

            // REH
            matrizRAH[4, 0] = ReH_DBT1;

            matrizRAH[4, 1] = ReH_W2;

            matrizRAH[5, 0] = ReH_DBT1;

            matrizRAH[5, 1] = ReH_W2;


            return matrizRAH;
        }

        public double[,] CargarCarta()
        {
            CP_Dbt1 = double.Parse(txt_CP_Dbt1.Text);
            CP_W1 = double.Parse(txt_CP_W1.Text);

            CP_Dbt2 = double.Parse(txt_CP_Dbt2.Text);
            CP_W2 = double.Parse(txt_CP_W2.Text);

            CP_Dbt3 = double.Parse(txt_CP_Dbt3.Text);
            CP_W3 = double.Parse(txt_CP_W3.Text);

            CP_Dbt4 = double.Parse(txt_CP_Dbt4.Text);
            CP_W4 = double.Parse(txt_CP_W4.Text);


            matrizCarta = new double[4, 2];

            matrizCarta[0, 0] = CP_Dbt1;

            matrizCarta[0, 1] = CP_W1;

            matrizCarta[1, 0] = CP_Dbt2;

            matrizCarta[1, 1] = CP_W2;

            matrizCarta[2, 0] = CP_Dbt3;

            matrizCarta[2, 1] = CP_W3;

            matrizCarta[3, 0] = CP_Dbt4;

            matrizCarta[3, 1] = CP_W4;


            return matrizCarta;
        }

        private void Txt_MACCResDewPoint_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
