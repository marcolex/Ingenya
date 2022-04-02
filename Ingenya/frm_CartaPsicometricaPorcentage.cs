using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenya
{
    public partial class frm_CartaPsicometricaPercentage : Form
    {
        double valElevacion;
        double Dbt1;
        double P1;
        double Dbt2;
        double P2;
        double Dbt3;
        double P3;
        double Dbt4;
        double P4;
        double Dbt5;
        double P5;
        double Dbt6;
        double Dbt7;
        double Dbt8;
        double Dbt9;
        double Dbt10;
        double Dbt11;
        double Dbt12;
        double Dbt13;
        double Dbt14;
        double Dbt15;
        double Dbt16;
        double Dbt17;
        double Dbt18;
        double Dbt19;
        double Dbt20;
        double Dbt21;
        double Dbt22;
        double Dbt23;
        double Dbt24;
        double Dbt25;
        double Dbt26;
        double Dbt27;
        double Dbt28;
        double Dbt29;
        double Dbt30;
        double Dbt31;
        double Dbt32;
        double Dbt33;
        double Dbt34;
        public frm_CartaPsicometricaPercentage()
        {
            InitializeComponent();
        }

        public frm_CartaPsicometricaPercentage(double elevacion)
        {
            InitializeComponent();

            valElevacion = elevacion;

            CargarCartaPsicometrica();
        }

        public void CargarCartaPsicometrica()
        {
            //100%
            Dbt1 = double.Parse(lbl_Dbt1.Text);
            
            P1 = double.Parse(lbl_P1.Text.Replace("%", ""));

            P1 = P1 / 100;

            txt_1_1.Text = Utilities.Formulas.HUMRATHR(Dbt1, P1, valElevacion).ToString("#0.########");

            Dbt2 = double.Parse(lbl_Dbt2.Text);

            txt_1_2.Text = Utilities.Formulas.HUMRATHR(Dbt2, P1, valElevacion).ToString("#0.########");

            Dbt3 = double.Parse(lbl_Dbt3.Text);

            txt_1_3.Text = Utilities.Formulas.HUMRATHR(Dbt3, P1, valElevacion).ToString("#0.########");

            Dbt4 = double.Parse(lbl_Dbt4.Text);

            txt_1_4.Text = Utilities.Formulas.HUMRATHR(Dbt4, P1, valElevacion).ToString("#0.########");

            Dbt5 = double.Parse(lbl_Dbt5.Text);

            txt_1_5.Text = Utilities.Formulas.HUMRATHR(Dbt5, P1, valElevacion).ToString("#0.########");

            Dbt6 = double.Parse(lbl_Dbt6.Text);

            txt_1_6.Text = Utilities.Formulas.HUMRATHR(Dbt6, P1, valElevacion).ToString("#0.########");

            Dbt7 = double.Parse(lbl_Dbt7.Text);

            txt_1_7.Text = Utilities.Formulas.HUMRATHR(Dbt7, P1, valElevacion).ToString("#0.########");

            Dbt8 = double.Parse(lbl_Dbt8.Text);

            txt_1_8.Text = Utilities.Formulas.HUMRATHR(Dbt8, P1, valElevacion).ToString("#0.########");

            Dbt9 = double.Parse(lbl_Dbt9.Text);

            txt_1_9.Text = Utilities.Formulas.HUMRATHR(Dbt9, P1, valElevacion).ToString("#0.########");

            Dbt10 = double.Parse(lbl_Dbt10.Text);

            txt_1_10.Text = Utilities.Formulas.HUMRATHR(Dbt10, P1, valElevacion).ToString("#0.########");

            Dbt11 = double.Parse(lbl_Dbt11.Text);

            txt_1_11.Text = Utilities.Formulas.HUMRATHR(Dbt11, P1, valElevacion).ToString("#0.########");

            Dbt12 = double.Parse(lbl_Dbt12.Text);

            txt_1_12.Text = Utilities.Formulas.HUMRATHR(Dbt12, P1, valElevacion).ToString("#0.########");

            Dbt13 = double.Parse(lbl_Dbt13.Text);

            txt_1_13.Text = Utilities.Formulas.HUMRATHR(Dbt13, P1, valElevacion).ToString("#0.########");

            Dbt14 = double.Parse(lbl_Dbt14.Text);

            txt_1_14.Text = Utilities.Formulas.HUMRATHR(Dbt14, P1, valElevacion).ToString("#0.########");

            Dbt15 = double.Parse(lbl_Dbt15.Text);

            txt_1_15.Text = Utilities.Formulas.HUMRATHR(Dbt15, P1, valElevacion).ToString("#0.########");

            Dbt16 = double.Parse(lbl_Dbt16.Text);

            txt_1_16.Text = Utilities.Formulas.HUMRATHR(Dbt16, P1, valElevacion).ToString("#0.########");

            Dbt17 = double.Parse(lbl_Dbt17.Text);

            txt_1_17.Text = Utilities.Formulas.HUMRATHR(Dbt17, P1, valElevacion).ToString("#0.########");

            Dbt18 = double.Parse(lbl_Dbt18.Text);

            txt_1_18.Text = Utilities.Formulas.HUMRATHR(Dbt18, P1, valElevacion).ToString("#0.########");

            Dbt19 = double.Parse(lbl_Dbt19.Text);

            txt_1_19.Text = Utilities.Formulas.HUMRATHR(Dbt19, P1, valElevacion).ToString("#0.########");

            Dbt20 = double.Parse(lbl_Dbt20.Text);

            txt_1_20.Text = Utilities.Formulas.HUMRATHR(Dbt20, P1, valElevacion).ToString("#0.########");

            Dbt21 = double.Parse(lbl_Dbt21.Text);

            txt_1_21.Text = Utilities.Formulas.HUMRATHR(Dbt21, P1, valElevacion).ToString("#0.########");

            Dbt22 = double.Parse(lbl_Dbt22.Text);

            txt_1_22.Text = Utilities.Formulas.HUMRATHR(Dbt22, P1, valElevacion).ToString("#0.########");

            Dbt23 = double.Parse(lbl_Dbt23.Text);

            txt_1_23.Text = Utilities.Formulas.HUMRATHR(Dbt23, P1, valElevacion).ToString("#0.########");

            Dbt24 = double.Parse(lbl_Dbt24.Text);

            txt_1_24.Text = Utilities.Formulas.HUMRATHR(Dbt24, P1, valElevacion).ToString("#0.########");

            Dbt25 = double.Parse(lbl_Dbt25.Text);

            txt_1_25.Text = Utilities.Formulas.HUMRATHR(Dbt25, P1, valElevacion).ToString("#0.########");

            Dbt26 = double.Parse(lbl_Dbt26.Text);

            txt_1_26.Text = Utilities.Formulas.HUMRATHR(Dbt26, P1, valElevacion).ToString("#0.########");

            Dbt27 = double.Parse(lbl_Dbt27.Text);

            txt_1_27.Text = Utilities.Formulas.HUMRATHR(Dbt27, P1, valElevacion).ToString("#0.########");

            Dbt28 = double.Parse(lbl_Dbt28.Text);

            txt_1_28.Text = Utilities.Formulas.HUMRATHR(Dbt28, P1, valElevacion).ToString("#0.########");

            Dbt29 = double.Parse(lbl_Dbt29.Text);

            txt_1_29.Text = Utilities.Formulas.HUMRATHR(Dbt29, P1, valElevacion).ToString("#0.########");

            Dbt30 = double.Parse(lbl_Dbt30.Text);

            txt_1_30.Text = Utilities.Formulas.HUMRATHR(Dbt30, P1, valElevacion).ToString("#0.########");

            Dbt31 = double.Parse(lbl_Dbt31.Text);

            txt_1_31.Text = Utilities.Formulas.HUMRATHR(Dbt31, P1, valElevacion).ToString("#0.########");

            Dbt32 = double.Parse(lbl_Dbt32.Text);

            txt_1_32.Text = Utilities.Formulas.HUMRATHR(Dbt32, P1, valElevacion).ToString("#0.########");

            Dbt33 = double.Parse(lbl_Dbt33.Text);

            txt_1_33.Text = Utilities.Formulas.HUMRATHR(Dbt33, P1, valElevacion).ToString("#0.########");

            Dbt34 = double.Parse(lbl_Dbt34.Text);

            txt_1_34.Text = Utilities.Formulas.HUMRATHR(Dbt34, P1, valElevacion).ToString("#0.########");


            //80%
            P2 = double.Parse(lbl_P2.Text.Replace("%", ""));

            P2 = P2 / 100;

            txt_2_1.Text = Utilities.Formulas.HUMRATHR(Dbt1, P2, valElevacion).ToString("#0.########");

            txt_2_2.Text = Utilities.Formulas.HUMRATHR(Dbt2, P2, valElevacion).ToString("#0.########");

            txt_2_3.Text = Utilities.Formulas.HUMRATHR(Dbt3, P2, valElevacion).ToString("#0.########");

            txt_2_4.Text = Utilities.Formulas.HUMRATHR(Dbt4, P2, valElevacion).ToString("#0.########");

            txt_2_5.Text = Utilities.Formulas.HUMRATHR(Dbt5, P2, valElevacion).ToString("#0.########");

            txt_2_6.Text = Utilities.Formulas.HUMRATHR(Dbt6, P2, valElevacion).ToString("#0.########");

            txt_2_7.Text = Utilities.Formulas.HUMRATHR(Dbt7, P2, valElevacion).ToString("#0.########");

            txt_2_8.Text = Utilities.Formulas.HUMRATHR(Dbt8, P2, valElevacion).ToString("#0.########");

            txt_2_9.Text = Utilities.Formulas.HUMRATHR(Dbt9, P2, valElevacion).ToString("#0.########");

            txt_2_10.Text = Utilities.Formulas.HUMRATHR(Dbt10, P2, valElevacion).ToString("#0.########");

            txt_2_11.Text = Utilities.Formulas.HUMRATHR(Dbt11, P2, valElevacion).ToString("#0.########");

            txt_2_12.Text = Utilities.Formulas.HUMRATHR(Dbt12, P2, valElevacion).ToString("#0.########");

            txt_2_13.Text = Utilities.Formulas.HUMRATHR(Dbt13, P2, valElevacion).ToString("#0.########");

            txt_2_14.Text = Utilities.Formulas.HUMRATHR(Dbt14, P2, valElevacion).ToString("#0.########");

            txt_2_15.Text = Utilities.Formulas.HUMRATHR(Dbt15, P2, valElevacion).ToString("#0.########");

            txt_2_16.Text = Utilities.Formulas.HUMRATHR(Dbt16, P2, valElevacion).ToString("#0.########");

            txt_2_17.Text = Utilities.Formulas.HUMRATHR(Dbt17, P2, valElevacion).ToString("#0.########");

            txt_2_18.Text = Utilities.Formulas.HUMRATHR(Dbt18, P2, valElevacion).ToString("#0.########");

            txt_2_19.Text = Utilities.Formulas.HUMRATHR(Dbt19, P2, valElevacion).ToString("#0.########");

            txt_2_20.Text = Utilities.Formulas.HUMRATHR(Dbt20, P2, valElevacion).ToString("#0.########");

            txt_2_21.Text = Utilities.Formulas.HUMRATHR(Dbt21, P2, valElevacion).ToString("#0.########");

            txt_2_22.Text = Utilities.Formulas.HUMRATHR(Dbt22, P2, valElevacion).ToString("#0.########");

            txt_2_23.Text = Utilities.Formulas.HUMRATHR(Dbt23, P2, valElevacion).ToString("#0.########");

            txt_2_24.Text = Utilities.Formulas.HUMRATHR(Dbt24, P2, valElevacion).ToString("#0.########");

            txt_2_25.Text = Utilities.Formulas.HUMRATHR(Dbt25, P2, valElevacion).ToString("#0.########");

            txt_2_26.Text = Utilities.Formulas.HUMRATHR(Dbt26, P2, valElevacion).ToString("#0.########");

            txt_2_27.Text = Utilities.Formulas.HUMRATHR(Dbt27, P2, valElevacion).ToString("#0.########");

            txt_2_28.Text = Utilities.Formulas.HUMRATHR(Dbt28, P2, valElevacion).ToString("#0.########");

            txt_2_29.Text = Utilities.Formulas.HUMRATHR(Dbt29, P2, valElevacion).ToString("#0.########");

            txt_2_30.Text = Utilities.Formulas.HUMRATHR(Dbt30, P2, valElevacion).ToString("#0.########");

            txt_2_31.Text = Utilities.Formulas.HUMRATHR(Dbt31, P2, valElevacion).ToString("#0.########");

            txt_2_32.Text = Utilities.Formulas.HUMRATHR(Dbt32, P2, valElevacion).ToString("#0.########");

            txt_2_33.Text = Utilities.Formulas.HUMRATHR(Dbt33, P2, valElevacion).ToString("#0.########");

            txt_2_34.Text = Utilities.Formulas.HUMRATHR(Dbt34, P2, valElevacion).ToString("#0.########");


            //60%
            P3 = double.Parse(lbl_P3.Text.Replace("%", ""));

            P3 = P3 / 100;

            txt_3_1.Text = Utilities.Formulas.HUMRATHR(Dbt1, P3, valElevacion).ToString("#0.########");

            txt_3_2.Text = Utilities.Formulas.HUMRATHR(Dbt2, P3, valElevacion).ToString("#0.########");

            txt_3_3.Text = Utilities.Formulas.HUMRATHR(Dbt3, P3, valElevacion).ToString("#0.########");

            txt_3_4.Text = Utilities.Formulas.HUMRATHR(Dbt4, P3, valElevacion).ToString("#0.########");

            txt_3_5.Text = Utilities.Formulas.HUMRATHR(Dbt5, P3, valElevacion).ToString("#0.########");

            txt_3_6.Text = Utilities.Formulas.HUMRATHR(Dbt6, P3, valElevacion).ToString("#0.########");

            txt_3_7.Text = Utilities.Formulas.HUMRATHR(Dbt7, P3, valElevacion).ToString("#0.########");

            txt_3_8.Text = Utilities.Formulas.HUMRATHR(Dbt8, P3, valElevacion).ToString("#0.########");

            txt_3_9.Text = Utilities.Formulas.HUMRATHR(Dbt9, P3, valElevacion).ToString("#0.########");

            txt_3_10.Text = Utilities.Formulas.HUMRATHR(Dbt10, P3, valElevacion).ToString("#0.########");

            txt_3_11.Text = Utilities.Formulas.HUMRATHR(Dbt11, P3, valElevacion).ToString("#0.########");

            txt_3_12.Text = Utilities.Formulas.HUMRATHR(Dbt12, P3, valElevacion).ToString("#0.########");

            txt_3_13.Text = Utilities.Formulas.HUMRATHR(Dbt13, P3, valElevacion).ToString("#0.########");

            txt_3_14.Text = Utilities.Formulas.HUMRATHR(Dbt14, P3, valElevacion).ToString("#0.########");

            txt_3_15.Text = Utilities.Formulas.HUMRATHR(Dbt15, P3, valElevacion).ToString("#0.########");

            txt_3_16.Text = Utilities.Formulas.HUMRATHR(Dbt16, P3, valElevacion).ToString("#0.########");

            txt_3_17.Text = Utilities.Formulas.HUMRATHR(Dbt17, P3, valElevacion).ToString("#0.########");

            txt_3_18.Text = Utilities.Formulas.HUMRATHR(Dbt18, P3, valElevacion).ToString("#0.########");

            txt_3_19.Text = Utilities.Formulas.HUMRATHR(Dbt19, P3, valElevacion).ToString("#0.########");

            txt_3_20.Text = Utilities.Formulas.HUMRATHR(Dbt20, P3, valElevacion).ToString("#0.########");

            txt_3_21.Text = Utilities.Formulas.HUMRATHR(Dbt21, P3, valElevacion).ToString("#0.########");

            txt_3_22.Text = Utilities.Formulas.HUMRATHR(Dbt22, P3, valElevacion).ToString("#0.########");

            txt_3_23.Text = Utilities.Formulas.HUMRATHR(Dbt23, P3, valElevacion).ToString("#0.########");

            txt_3_24.Text = Utilities.Formulas.HUMRATHR(Dbt24, P3, valElevacion).ToString("#0.########");

            txt_3_25.Text = Utilities.Formulas.HUMRATHR(Dbt25, P3, valElevacion).ToString("#0.########");

            txt_3_26.Text = Utilities.Formulas.HUMRATHR(Dbt26, P3, valElevacion).ToString("#0.########");

            txt_3_27.Text = Utilities.Formulas.HUMRATHR(Dbt27, P3, valElevacion).ToString("#0.########");

            txt_3_28.Text = Utilities.Formulas.HUMRATHR(Dbt28, P3, valElevacion).ToString("#0.########");

            txt_3_29.Text = Utilities.Formulas.HUMRATHR(Dbt29, P3, valElevacion).ToString("#0.########");

            txt_3_30.Text = Utilities.Formulas.HUMRATHR(Dbt30, P3, valElevacion).ToString("#0.########");

            txt_3_31.Text = Utilities.Formulas.HUMRATHR(Dbt31, P3, valElevacion).ToString("#0.########");

            txt_3_32.Text = Utilities.Formulas.HUMRATHR(Dbt32, P3, valElevacion).ToString("#0.########");

            txt_3_33.Text = Utilities.Formulas.HUMRATHR(Dbt33, P3, valElevacion).ToString("#0.########");

            txt_3_34.Text = Utilities.Formulas.HUMRATHR(Dbt34, P3, valElevacion).ToString("#0.########");


            //40%
            P4 = double.Parse(lbl_P4.Text.Replace("%", ""));

            P4 = P4 / 100;

            txt_4_1.Text = Utilities.Formulas.HUMRATHR(Dbt1, P4, valElevacion).ToString("#0.########");

            txt_4_2.Text = Utilities.Formulas.HUMRATHR(Dbt2, P4, valElevacion).ToString("#0.########");

            txt_4_3.Text = Utilities.Formulas.HUMRATHR(Dbt3, P4, valElevacion).ToString("#0.########");

            txt_4_4.Text = Utilities.Formulas.HUMRATHR(Dbt4, P4, valElevacion).ToString("#0.########");

            txt_4_5.Text = Utilities.Formulas.HUMRATHR(Dbt5, P4, valElevacion).ToString("#0.########");

            txt_4_6.Text = Utilities.Formulas.HUMRATHR(Dbt6, P4, valElevacion).ToString("#0.########");

            txt_4_7.Text = Utilities.Formulas.HUMRATHR(Dbt7, P4, valElevacion).ToString("#0.########");

            txt_4_8.Text = Utilities.Formulas.HUMRATHR(Dbt8, P4, valElevacion).ToString("#0.########");

            txt_4_9.Text = Utilities.Formulas.HUMRATHR(Dbt9, P4, valElevacion).ToString("#0.########");

            txt_4_10.Text = Utilities.Formulas.HUMRATHR(Dbt10, P4, valElevacion).ToString("#0.########");

            txt_4_11.Text = Utilities.Formulas.HUMRATHR(Dbt11, P4, valElevacion).ToString("#0.########");

            txt_4_12.Text = Utilities.Formulas.HUMRATHR(Dbt12, P4, valElevacion).ToString("#0.########");

            txt_4_13.Text = Utilities.Formulas.HUMRATHR(Dbt13, P4, valElevacion).ToString("#0.########");

            txt_4_14.Text = Utilities.Formulas.HUMRATHR(Dbt14, P4, valElevacion).ToString("#0.########");

            txt_4_15.Text = Utilities.Formulas.HUMRATHR(Dbt15, P4, valElevacion).ToString("#0.########");

            txt_4_16.Text = Utilities.Formulas.HUMRATHR(Dbt16, P4, valElevacion).ToString("#0.########");

            txt_4_17.Text = Utilities.Formulas.HUMRATHR(Dbt17, P4, valElevacion).ToString("#0.########");

            txt_4_18.Text = Utilities.Formulas.HUMRATHR(Dbt18, P4, valElevacion).ToString("#0.########");

            txt_4_19.Text = Utilities.Formulas.HUMRATHR(Dbt19, P4, valElevacion).ToString("#0.########");

            txt_4_20.Text = Utilities.Formulas.HUMRATHR(Dbt20, P4, valElevacion).ToString("#0.########");

            txt_4_21.Text = Utilities.Formulas.HUMRATHR(Dbt21, P4, valElevacion).ToString("#0.########");

            txt_4_22.Text = Utilities.Formulas.HUMRATHR(Dbt22, P4, valElevacion).ToString("#0.########");

            txt_4_23.Text = Utilities.Formulas.HUMRATHR(Dbt23, P4, valElevacion).ToString("#0.########");

            txt_4_24.Text = Utilities.Formulas.HUMRATHR(Dbt24, P4, valElevacion).ToString("#0.########");

            txt_4_25.Text = Utilities.Formulas.HUMRATHR(Dbt25, P4, valElevacion).ToString("#0.########");

            txt_4_26.Text = Utilities.Formulas.HUMRATHR(Dbt26, P4, valElevacion).ToString("#0.########");

            txt_4_27.Text = Utilities.Formulas.HUMRATHR(Dbt27, P4, valElevacion).ToString("#0.########");

            txt_4_28.Text = Utilities.Formulas.HUMRATHR(Dbt28, P4, valElevacion).ToString("#0.########");

            txt_4_29.Text = Utilities.Formulas.HUMRATHR(Dbt29, P4, valElevacion).ToString("#0.########");

            txt_4_30.Text = Utilities.Formulas.HUMRATHR(Dbt30, P4, valElevacion).ToString("#0.########");

            txt_4_31.Text = Utilities.Formulas.HUMRATHR(Dbt31, P4, valElevacion).ToString("#0.########");

            txt_4_32.Text = Utilities.Formulas.HUMRATHR(Dbt32, P4, valElevacion).ToString("#0.########");

            txt_4_33.Text = Utilities.Formulas.HUMRATHR(Dbt33, P4, valElevacion).ToString("#0.########");

            txt_4_34.Text = Utilities.Formulas.HUMRATHR(Dbt34, P4, valElevacion).ToString("#0.########");


            //20%
            P5 = double.Parse(lbl_P5.Text.Replace("%", ""));

            P5 = P5 / 100;

            txt_5_1.Text = Utilities.Formulas.HUMRATHR(Dbt1, P5, valElevacion).ToString("#0.########");

            txt_5_2.Text = Utilities.Formulas.HUMRATHR(Dbt2, P5, valElevacion).ToString("#0.########");

            txt_5_3.Text = Utilities.Formulas.HUMRATHR(Dbt3, P5, valElevacion).ToString("#0.########");

            txt_5_4.Text = Utilities.Formulas.HUMRATHR(Dbt4, P5, valElevacion).ToString("#0.########");

            txt_5_5.Text = Utilities.Formulas.HUMRATHR(Dbt5, P5, valElevacion).ToString("#0.########");

            txt_5_6.Text = Utilities.Formulas.HUMRATHR(Dbt6, P5, valElevacion).ToString("#0.########");

            txt_5_7.Text = Utilities.Formulas.HUMRATHR(Dbt7, P5, valElevacion).ToString("#0.########");

            txt_5_8.Text = Utilities.Formulas.HUMRATHR(Dbt8, P5, valElevacion).ToString("#0.########");

            txt_5_9.Text = Utilities.Formulas.HUMRATHR(Dbt9, P5, valElevacion).ToString("#0.########");

            txt_5_10.Text = Utilities.Formulas.HUMRATHR(Dbt10, P5, valElevacion).ToString("#0.########");

            txt_5_11.Text = Utilities.Formulas.HUMRATHR(Dbt11, P5, valElevacion).ToString("#0.########");

            txt_5_12.Text = Utilities.Formulas.HUMRATHR(Dbt12, P5, valElevacion).ToString("#0.########");

            txt_5_13.Text = Utilities.Formulas.HUMRATHR(Dbt13, P5, valElevacion).ToString("#0.########");

            txt_5_14.Text = Utilities.Formulas.HUMRATHR(Dbt14, P5, valElevacion).ToString("#0.########");

            txt_5_15.Text = Utilities.Formulas.HUMRATHR(Dbt15, P5, valElevacion).ToString("#0.########");

            txt_5_16.Text = Utilities.Formulas.HUMRATHR(Dbt16, P5, valElevacion).ToString("#0.########");

            txt_5_17.Text = Utilities.Formulas.HUMRATHR(Dbt17, P5, valElevacion).ToString("#0.########");

            txt_5_18.Text = Utilities.Formulas.HUMRATHR(Dbt18, P5, valElevacion).ToString("#0.########");

            txt_5_19.Text = Utilities.Formulas.HUMRATHR(Dbt19, P5, valElevacion).ToString("#0.########");

            txt_5_20.Text = Utilities.Formulas.HUMRATHR(Dbt20, P5, valElevacion).ToString("#0.########");

            txt_5_21.Text = Utilities.Formulas.HUMRATHR(Dbt21, P5, valElevacion).ToString("#0.########");

            txt_5_22.Text = Utilities.Formulas.HUMRATHR(Dbt22, P5, valElevacion).ToString("#0.########");

            txt_5_23.Text = Utilities.Formulas.HUMRATHR(Dbt23, P5, valElevacion).ToString("#0.########");

            txt_5_24.Text = Utilities.Formulas.HUMRATHR(Dbt24, P5, valElevacion).ToString("#0.########");

            txt_5_25.Text = Utilities.Formulas.HUMRATHR(Dbt25, P5, valElevacion).ToString("#0.########");

            txt_5_26.Text = Utilities.Formulas.HUMRATHR(Dbt26, P5, valElevacion).ToString("#0.########");

            txt_5_27.Text = Utilities.Formulas.HUMRATHR(Dbt27, P5, valElevacion).ToString("#0.########");

            txt_5_28.Text = Utilities.Formulas.HUMRATHR(Dbt28, P5, valElevacion).ToString("#0.########");

            txt_5_29.Text = Utilities.Formulas.HUMRATHR(Dbt29, P5, valElevacion).ToString("#0.########");

            txt_5_30.Text = Utilities.Formulas.HUMRATHR(Dbt30, P5, valElevacion).ToString("#0.########");

            txt_5_31.Text = Utilities.Formulas.HUMRATHR(Dbt31, P5, valElevacion).ToString("#0.########");

            txt_5_32.Text = Utilities.Formulas.HUMRATHR(Dbt32, P5, valElevacion).ToString("#0.########");

            txt_5_33.Text = Utilities.Formulas.HUMRATHR(Dbt33, P5, valElevacion).ToString("#0.########");

            txt_5_34.Text = Utilities.Formulas.HUMRATHR(Dbt34, P5, valElevacion).ToString("#0.########");

        }
    }
}
