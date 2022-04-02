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
    public partial class frm_CartaPsicometricaTemp : Form
    {
        double DBT1;
        double CP_1;
        double DBT2;
        double CP_2;
        double DBT3;
        double CP_3;
        double DBT4;
        double CP_4;
        double DBT5;
        double CP_5;
        double DBT6;
        double CP_6;
        double DBT7;
        double CP_7;
        double DBT8;
        double CP_8;
        double DBT9;
        double CP_9;
        double DBT10;
        double CP_10;
        double DBT11;
        double CP_11;
        double DBT12;
        double CP_12;
        double DBT13;
        double CP_13;
        double DBT14;
        double DBT15;
        double DBT16;
        double DBT17;
        double DBT18;
        double DBT19;
        double DBT20;
        double DBT21;
        double DBT22;
        double DBT23;
        double DBT24;
        double DBT25;
        double DBT26;
        double DBT27;
        double DBT28;
        double DBT29;
        double DBT30;
        double DBT31;
        double DBT32;
        double DBT33;
        double DBT34;

        double valElevacion;
        public frm_CartaPsicometricaTemp()
        {
            InitializeComponent();
        }

        public frm_CartaPsicometricaTemp(double elevacion)
        {
            InitializeComponent();

            valElevacion = elevacion;

            CargarCartaPsicometrica();
        }

        public void CargarCartaPsicometrica()
        {
            //35°F wbT
            CP_1 = double.Parse(txt_CP_1.Text);

            DBT1 = double.Parse(lbl_DBT1.Text);

            txt_1_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_1, valElevacion).ToString("#0.########");

            DBT2 = double.Parse(lbl_DBT2.Text);

            txt_1_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_1, valElevacion).ToString("#0.########");

            DBT3 = double.Parse(lbl_DBT3.Text);

            txt_1_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_1, valElevacion).ToString("#0.########");

            DBT4 = double.Parse(lbl_DBT4.Text);

            txt_1_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_1, valElevacion).ToString("#0.########");

            DBT5 = double.Parse(lbl_DBT5.Text);

            txt_1_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_1, valElevacion).ToString("#0.########");

            DBT6 = double.Parse(lbl_DBT6.Text);

            txt_1_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_1, valElevacion).ToString("#0.########");

            DBT7 = double.Parse(lbl_DBT7.Text);

            txt_1_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_1, valElevacion).ToString("#0.########");

            DBT8 = double.Parse(lbl_DBT8.Text);

            txt_1_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_1, valElevacion).ToString("#0.########");

            DBT9 = double.Parse(lbl_DBT9.Text);

            txt_1_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_1, valElevacion).ToString("#0.########");

            DBT10 = double.Parse(lbl_DBT10.Text);

            txt_1_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_1, valElevacion).ToString("#0.########");

            DBT11 = double.Parse(lbl_DBT11.Text);

            txt_1_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_1, valElevacion).ToString("#0.########");

            DBT12 = double.Parse(lbl_DBT12.Text);

            txt_1_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_1, valElevacion).ToString("#0.########");

            DBT13 = double.Parse(lbl_DBT13.Text);

            txt_1_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_1, valElevacion).ToString("#0.########");

            DBT14 = double.Parse(lbl_DBT14.Text);

            txt_1_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_1, valElevacion).ToString("#0.########");

            DBT15 = double.Parse(lbl_DBT15.Text);

            txt_1_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_1, valElevacion).ToString("#0.########");

            DBT16 = double.Parse(lbl_DBT16.Text);

            txt_1_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_1, valElevacion).ToString("#0.########");

            DBT17 = double.Parse(lbl_DBT17.Text);

            txt_1_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_1, valElevacion).ToString("#0.########");

            DBT18 = double.Parse(lbl_DBT18.Text);

            txt_1_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_1, valElevacion).ToString("#0.########");

            DBT19 = double.Parse(lbl_DBT19.Text);

            txt_1_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_1, valElevacion).ToString("#0.########");

            DBT20 = double.Parse(lbl_DBT20.Text);

            txt_1_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_1, valElevacion).ToString("#0.########");

            DBT21 = double.Parse(lbl_DBT21.Text);

            txt_1_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_1, valElevacion).ToString("#0.########");

            DBT22 = double.Parse(lbl_DBT22.Text);

            txt_1_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_1, valElevacion).ToString("#0.########");

            DBT23 = double.Parse(lbl_DBT23.Text);

            txt_1_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_1, valElevacion).ToString("#0.########");

            DBT24 = double.Parse(lbl_DBT24.Text);

            txt_1_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_1, valElevacion).ToString("#0.########");

            DBT25 = double.Parse(lbl_DBT25.Text);

            txt_1_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_1, valElevacion).ToString("#0.########");

            DBT26 = double.Parse(lbl_DBT26.Text);

            txt_1_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_1, valElevacion).ToString("#0.########");

            DBT27 = double.Parse(lbl_DBT27.Text);

            txt_1_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_1, valElevacion).ToString("#0.########");

            DBT28 = double.Parse(lbl_DBT28.Text);

            txt_1_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_1, valElevacion).ToString("#0.########");

            DBT29 = double.Parse(lbl_DBT29.Text);

            txt_1_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_1, valElevacion).ToString("#0.########");

            DBT30 = double.Parse(lbl_DBT30.Text);

            txt_1_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_1, valElevacion).ToString("#0.########");

            DBT31 = double.Parse(lbl_DBT31.Text);

            txt_1_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_1, valElevacion).ToString("#0.########");

            DBT32 = double.Parse(lbl_DBT32.Text);

            txt_1_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_1, valElevacion).ToString("#0.########");

            DBT33 = double.Parse(lbl_DBT33.Text);

            txt_1_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_1, valElevacion).ToString("#0.########");

            DBT34 = double.Parse(lbl_DBT34.Text);

            txt_1_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_1, valElevacion).ToString("#0.########");

            //45°F wbT
            CP_2 = double.Parse(txt_CP_2.Text);

            txt_2_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_2, valElevacion).ToString("#0.########");

            txt_2_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_2, valElevacion).ToString("#0.########");

            txt_2_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_2, valElevacion).ToString("#0.########");

            txt_2_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_2, valElevacion).ToString("#0.########");

            txt_2_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_2, valElevacion).ToString("#0.########");

            txt_2_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_2, valElevacion).ToString("#0.########");

            txt_2_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_2, valElevacion).ToString("#0.########");

            txt_2_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_2, valElevacion).ToString("#0.########");

            txt_2_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_2, valElevacion).ToString("#0.########");

            txt_2_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_2, valElevacion).ToString("#0.########");

            txt_2_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_2, valElevacion).ToString("#0.########");

            txt_2_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_2, valElevacion).ToString("#0.########");

            txt_2_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_2, valElevacion).ToString("#0.########");

            txt_2_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_2, valElevacion).ToString("#0.########");

            txt_2_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_2, valElevacion).ToString("#0.########");

            txt_2_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_2, valElevacion).ToString("#0.########");

            txt_2_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_2, valElevacion).ToString("#0.########");

            txt_2_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_2, valElevacion).ToString("#0.########");

            txt_2_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_2, valElevacion).ToString("#0.########");

            txt_2_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_2, valElevacion).ToString("#0.########");

            txt_2_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_2, valElevacion).ToString("#0.########");

            txt_2_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_2, valElevacion).ToString("#0.########");

            txt_2_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_2, valElevacion).ToString("#0.########");

            txt_2_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_2, valElevacion).ToString("#0.########");

            txt_2_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_2, valElevacion).ToString("#0.########");

            txt_2_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_2, valElevacion).ToString("#0.########");

            txt_2_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_2, valElevacion).ToString("#0.########");

            txt_2_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_2, valElevacion).ToString("#0.########");

            txt_2_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_2, valElevacion).ToString("#0.########");

            txt_2_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_2, valElevacion).ToString("#0.########");

            txt_2_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_2, valElevacion).ToString("#0.########");

            txt_2_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_2, valElevacion).ToString("#0.########");

            txt_2_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_2, valElevacion).ToString("#0.########");

            txt_2_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_2, valElevacion).ToString("#0.########");

            //55°F wbT
            CP_3 = double.Parse(txt_CP_3.Text);

            txt_3_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_3, valElevacion).ToString("#0.########");

            txt_3_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_3, valElevacion).ToString("#0.########");

            txt_3_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_3, valElevacion).ToString("#0.########");

            txt_3_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_3, valElevacion).ToString("#0.########");

            txt_3_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_3, valElevacion).ToString("#0.########");

            txt_3_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_3, valElevacion).ToString("#0.########");

            txt_3_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_3, valElevacion).ToString("#0.########");

            txt_3_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_3, valElevacion).ToString("#0.########");

            txt_3_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_3, valElevacion).ToString("#0.########");

            txt_3_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_3, valElevacion).ToString("#0.########");

            txt_3_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_3, valElevacion).ToString("#0.########");

            txt_3_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_3, valElevacion).ToString("#0.########");

            txt_3_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_3, valElevacion).ToString("#0.########");

            txt_3_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_3, valElevacion).ToString("#0.########");

            txt_3_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_3, valElevacion).ToString("#0.########");

            txt_3_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_3, valElevacion).ToString("#0.########");

            txt_3_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_3, valElevacion).ToString("#0.########");

            txt_3_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_3, valElevacion).ToString("#0.########");

            txt_3_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_3, valElevacion).ToString("#0.########");

            txt_3_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_3, valElevacion).ToString("#0.########");

            txt_3_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_3, valElevacion).ToString("#0.########");

            txt_3_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_3, valElevacion).ToString("#0.########");

            txt_3_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_3, valElevacion).ToString("#0.########");

            txt_3_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_3, valElevacion).ToString("#0.########");

            txt_3_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_3, valElevacion).ToString("#0.########");

            txt_3_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_3, valElevacion).ToString("#0.########");

            txt_3_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_3, valElevacion).ToString("#0.########");

            txt_3_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_3, valElevacion).ToString("#0.########");

            txt_3_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_3, valElevacion).ToString("#0.########");

            txt_3_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_3, valElevacion).ToString("#0.########");

            txt_3_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_3, valElevacion).ToString("#0.########");

            txt_3_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_3, valElevacion).ToString("#0.########");

            txt_3_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_3, valElevacion).ToString("#0.########");

            txt_3_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_3, valElevacion).ToString("#0.########");

            //65°F wbT
            CP_4 = double.Parse(txt_CP_4.Text);

            txt_4_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_4, valElevacion).ToString("#0.########");

            txt_4_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_4, valElevacion).ToString("#0.########");

            txt_4_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_4, valElevacion).ToString("#0.########");

            txt_4_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_4, valElevacion).ToString("#0.########");

            txt_4_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_4, valElevacion).ToString("#0.########");

            txt_4_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_4, valElevacion).ToString("#0.########");

            txt_4_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_4, valElevacion).ToString("#0.########");

            txt_4_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_4, valElevacion).ToString("#0.########");

            txt_4_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_4, valElevacion).ToString("#0.########");

            txt_4_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_4, valElevacion).ToString("#0.########");

            txt_4_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_4, valElevacion).ToString("#0.########");

            txt_4_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_4, valElevacion).ToString("#0.########");

            txt_4_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_4, valElevacion).ToString("#0.########");

            txt_4_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_4, valElevacion).ToString("#0.########");

            txt_4_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_4, valElevacion).ToString("#0.########");

            txt_4_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_4, valElevacion).ToString("#0.########");

            txt_4_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_4, valElevacion).ToString("#0.########");

            txt_4_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_4, valElevacion).ToString("#0.########");

            txt_4_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_4, valElevacion).ToString("#0.########");

            txt_4_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_4, valElevacion).ToString("#0.########");

            txt_4_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_4, valElevacion).ToString("#0.########");

            txt_4_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_4, valElevacion).ToString("#0.########");

            txt_4_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_4, valElevacion).ToString("#0.########");

            txt_4_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_4, valElevacion).ToString("#0.########");

            txt_4_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_4, valElevacion).ToString("#0.########");

            txt_4_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_4, valElevacion).ToString("#0.########");

            txt_4_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_4, valElevacion).ToString("#0.########");

            txt_4_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_4, valElevacion).ToString("#0.########");

            txt_4_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_4, valElevacion).ToString("#0.########");

            txt_4_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_4, valElevacion).ToString("#0.########");

            txt_4_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_4, valElevacion).ToString("#0.########");

            txt_4_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_4, valElevacion).ToString("#0.########");

            txt_4_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_4, valElevacion).ToString("#0.########");

            txt_4_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_4, valElevacion).ToString("#0.########");

            //75°F wbT
            CP_5 = double.Parse(txt_CP_5.Text);

            txt_5_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_5, valElevacion).ToString("#0.########");

            txt_5_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_5, valElevacion).ToString("#0.########");

            txt_5_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_5, valElevacion).ToString("#0.########");

            txt_5_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_5, valElevacion).ToString("#0.########");

            txt_5_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_5, valElevacion).ToString("#0.########");

            txt_5_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_5, valElevacion).ToString("#0.########");

            txt_5_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_5, valElevacion).ToString("#0.########");

            txt_5_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_5, valElevacion).ToString("#0.########");

            txt_5_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_5, valElevacion).ToString("#0.########");

            txt_5_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_5, valElevacion).ToString("#0.########");

            txt_5_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_5, valElevacion).ToString("#0.########");

            txt_5_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_5, valElevacion).ToString("#0.########");

            txt_5_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_5, valElevacion).ToString("#0.########");

            txt_5_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_5, valElevacion).ToString("#0.########");

            txt_5_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_5, valElevacion).ToString("#0.########");

            txt_5_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_5, valElevacion).ToString("#0.########");

            txt_5_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_5, valElevacion).ToString("#0.########");

            txt_5_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_5, valElevacion).ToString("#0.########");

            txt_5_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_5, valElevacion).ToString("#0.########");

            txt_5_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_5, valElevacion).ToString("#0.########");

            txt_5_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_5, valElevacion).ToString("#0.########");

            txt_5_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_5, valElevacion).ToString("#0.########");

            txt_5_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_5, valElevacion).ToString("#0.########");

            txt_5_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_5, valElevacion).ToString("#0.########");

            txt_5_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_5, valElevacion).ToString("#0.########");

            txt_5_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_5, valElevacion).ToString("#0.########");

            txt_5_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_5, valElevacion).ToString("#0.########");

            txt_5_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_5, valElevacion).ToString("#0.########");

            txt_5_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_5, valElevacion).ToString("#0.########");

            txt_5_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_5, valElevacion).ToString("#0.########");

            txt_5_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_5, valElevacion).ToString("#0.########");

            txt_5_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_5, valElevacion).ToString("#0.########");

            txt_5_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_5, valElevacion).ToString("#0.########");

            txt_5_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_5, valElevacion).ToString("#0.########");

            //85°F wbT
            CP_6 = double.Parse(txt_CP_6.Text);

            txt_6_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_6, valElevacion).ToString("#0.########");

            txt_6_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_6, valElevacion).ToString("#0.########");

            txt_6_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_6, valElevacion).ToString("#0.########");

            txt_6_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_6, valElevacion).ToString("#0.########");

            txt_6_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_6, valElevacion).ToString("#0.########");

            txt_6_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_6, valElevacion).ToString("#0.########");

            txt_6_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_6, valElevacion).ToString("#0.########");

            txt_6_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_6, valElevacion).ToString("#0.########");

            txt_6_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_6, valElevacion).ToString("#0.########");

            txt_6_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_6, valElevacion).ToString("#0.########");

            txt_6_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_6, valElevacion).ToString("#0.########");

            txt_6_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_6, valElevacion).ToString("#0.########");

            txt_6_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_6, valElevacion).ToString("#0.########");

            txt_6_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_6, valElevacion).ToString("#0.########");

            txt_6_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_6, valElevacion).ToString("#0.########");

            txt_6_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_6, valElevacion).ToString("#0.########");

            txt_6_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_6, valElevacion).ToString("#0.########");

            txt_6_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_6, valElevacion).ToString("#0.########");

            txt_6_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_6, valElevacion).ToString("#0.########");

            txt_6_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_6, valElevacion).ToString("#0.########");

            txt_6_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_6, valElevacion).ToString("#0.########");

            txt_6_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_6, valElevacion).ToString("#0.########");

            txt_6_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_6, valElevacion).ToString("#0.########");

            txt_6_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_6, valElevacion).ToString("#0.########");

            txt_6_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_6, valElevacion).ToString("#0.########");

            txt_6_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_6, valElevacion).ToString("#0.########");

            txt_6_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_6, valElevacion).ToString("#0.########");

            txt_6_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_6, valElevacion).ToString("#0.########");

            txt_6_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_6, valElevacion).ToString("#0.########");

            txt_6_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_6, valElevacion).ToString("#0.########");

            txt_6_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_6, valElevacion).ToString("#0.########");

            txt_6_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_6, valElevacion).ToString("#0.########");

            txt_6_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_6, valElevacion).ToString("#0.########");

            txt_6_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_6, valElevacion).ToString("#0.########");

            //95°F wbT
            CP_7 = double.Parse(txt_CP_7.Text);

            txt_7_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_7, valElevacion).ToString("#0.########");

            txt_7_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_7, valElevacion).ToString("#0.########");

            txt_7_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_7, valElevacion).ToString("#0.########");

            txt_7_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_7, valElevacion).ToString("#0.########");

            txt_7_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_7, valElevacion).ToString("#0.########");

            txt_7_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_7, valElevacion).ToString("#0.########");

            txt_7_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_7, valElevacion).ToString("#0.########");

            txt_7_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_7, valElevacion).ToString("#0.########");

            txt_7_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_7, valElevacion).ToString("#0.########");

            txt_7_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_7, valElevacion).ToString("#0.########");

            txt_7_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_7, valElevacion).ToString("#0.########");

            txt_7_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_7, valElevacion).ToString("#0.########");

            txt_7_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_7, valElevacion).ToString("#0.########");

            txt_7_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_7, valElevacion).ToString("#0.########");

            txt_7_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_7, valElevacion).ToString("#0.########");

            txt_7_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_7, valElevacion).ToString("#0.########");

            txt_7_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_7, valElevacion).ToString("#0.########");

            txt_7_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_7, valElevacion).ToString("#0.########");

            txt_7_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_7, valElevacion).ToString("#0.########");

            txt_7_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_7, valElevacion).ToString("#0.########");

            txt_7_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_7, valElevacion).ToString("#0.########");

            txt_7_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_7, valElevacion).ToString("#0.########");

            txt_7_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_7, valElevacion).ToString("#0.########");

            txt_7_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_7, valElevacion).ToString("#0.########");

            txt_7_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_7, valElevacion).ToString("#0.########");

            txt_7_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_7, valElevacion).ToString("#0.########");

            txt_7_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_7, valElevacion).ToString("#0.########");

            txt_7_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_7, valElevacion).ToString("#0.########");

            txt_7_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_7, valElevacion).ToString("#0.########");

            txt_7_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_7, valElevacion).ToString("#0.########");

            txt_7_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_7, valElevacion).ToString("#0.########");

            txt_7_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_7, valElevacion).ToString("#0.########");

            txt_7_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_7, valElevacion).ToString("#0.########");

            txt_7_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_7, valElevacion).ToString("#0.########");

            //105°F wbT
            CP_8 = double.Parse(txt_CP_8.Text);

            txt_8_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_8, valElevacion).ToString("#0.########");

            txt_8_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_8, valElevacion).ToString("#0.########");

            txt_8_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_8, valElevacion).ToString("#0.########");

            txt_8_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_8, valElevacion).ToString("#0.########");

            txt_8_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_8, valElevacion).ToString("#0.########");

            txt_8_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_8, valElevacion).ToString("#0.########");

            txt_8_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_8, valElevacion).ToString("#0.########");

            txt_8_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_8, valElevacion).ToString("#0.########");

            txt_8_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_8, valElevacion).ToString("#0.########");

            txt_8_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_8, valElevacion).ToString("#0.########");

            txt_8_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_8, valElevacion).ToString("#0.########");

            txt_8_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_8, valElevacion).ToString("#0.########");

            txt_8_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_8, valElevacion).ToString("#0.########");

            txt_8_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_8, valElevacion).ToString("#0.########");

            txt_8_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_8, valElevacion).ToString("#0.########");

            txt_8_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_8, valElevacion).ToString("#0.########");

            txt_8_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_8, valElevacion).ToString("#0.########");

            txt_8_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_8, valElevacion).ToString("#0.########");

            txt_8_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_8, valElevacion).ToString("#0.########");

            txt_8_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_8, valElevacion).ToString("#0.########");

            txt_8_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_8, valElevacion).ToString("#0.########");

            txt_8_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_8, valElevacion).ToString("#0.########");

            txt_8_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_8, valElevacion).ToString("#0.########");

            txt_8_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_8, valElevacion).ToString("#0.########");

            txt_8_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_8, valElevacion).ToString("#0.########");

            txt_8_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_8, valElevacion).ToString("#0.########");

            txt_8_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_8, valElevacion).ToString("#0.########");

            txt_8_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_8, valElevacion).ToString("#0.########");

            txt_8_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_8, valElevacion).ToString("#0.########");

            txt_8_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_8, valElevacion).ToString("#0.########");

            txt_8_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_8, valElevacion).ToString("#0.########");

            txt_8_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_8, valElevacion).ToString("#0.########");

            txt_8_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_8, valElevacion).ToString("#0.########");

            txt_8_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_8, valElevacion).ToString("#0.########");

            //110°F wbT
            CP_9 = double.Parse(txt_CP_9.Text);

            txt_9_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_9, valElevacion).ToString("#0.########");

            txt_9_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_9, valElevacion).ToString("#0.########");

            txt_9_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_9, valElevacion).ToString("#0.########");

            txt_9_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_9, valElevacion).ToString("#0.########");

            txt_9_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_9, valElevacion).ToString("#0.########");

            txt_9_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_9, valElevacion).ToString("#0.########");

            txt_9_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_9, valElevacion).ToString("#0.########");

            txt_9_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_9, valElevacion).ToString("#0.########");

            txt_9_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_9, valElevacion).ToString("#0.########");

            txt_9_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_9, valElevacion).ToString("#0.########");

            txt_9_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_9, valElevacion).ToString("#0.########");

            txt_9_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_9, valElevacion).ToString("#0.########");

            txt_9_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_9, valElevacion).ToString("#0.########");

            txt_9_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_9, valElevacion).ToString("#0.########");

            txt_9_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_9, valElevacion).ToString("#0.########");

            txt_9_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_9, valElevacion).ToString("#0.########");

            txt_9_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_9, valElevacion).ToString("#0.########");

            txt_9_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_9, valElevacion).ToString("#0.########");

            txt_9_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_9, valElevacion).ToString("#0.########");

            txt_9_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_9, valElevacion).ToString("#0.########");

            txt_9_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_9, valElevacion).ToString("#0.########");

            txt_9_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_9, valElevacion).ToString("#0.########");

            txt_9_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_9, valElevacion).ToString("#0.########");

            txt_9_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_9, valElevacion).ToString("#0.########");

            txt_9_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_9, valElevacion).ToString("#0.########");

            txt_9_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_9, valElevacion).ToString("#0.########");

            txt_9_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_9, valElevacion).ToString("#0.########");

            txt_9_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_9, valElevacion).ToString("#0.########");

            txt_9_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_9, valElevacion).ToString("#0.########");

            txt_9_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_9, valElevacion).ToString("#0.########");

            txt_9_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_9, valElevacion).ToString("#0.########");

            txt_9_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_9, valElevacion).ToString("#0.########");

            txt_9_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_9, valElevacion).ToString("#0.########");

            txt_9_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_9, valElevacion).ToString("#0.########");

            //115°F wbT
            CP_10 = double.Parse(txt_CP_10.Text);

            txt_10_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_10, valElevacion).ToString("#0.########");

            txt_10_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_10, valElevacion).ToString("#0.########");

            txt_10_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_10, valElevacion).ToString("#0.########");

            txt_10_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_10, valElevacion).ToString("#0.########");

            txt_10_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_10, valElevacion).ToString("#0.########");

            txt_10_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_10, valElevacion).ToString("#0.########");

            txt_10_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_10, valElevacion).ToString("#0.########");

            txt_10_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_10, valElevacion).ToString("#0.########");

            txt_10_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_10, valElevacion).ToString("#0.########");

            txt_10_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_10, valElevacion).ToString("#0.########");

            txt_10_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_10, valElevacion).ToString("#0.########");

            txt_10_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_10, valElevacion).ToString("#0.########");

            txt_10_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_10, valElevacion).ToString("#0.########");

            txt_10_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_10, valElevacion).ToString("#0.########");

            txt_10_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_10, valElevacion).ToString("#0.########");

            txt_10_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_10, valElevacion).ToString("#0.########");

            txt_10_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_10, valElevacion).ToString("#0.########");

            txt_10_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_10, valElevacion).ToString("#0.########");

            txt_10_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_10, valElevacion).ToString("#0.########");

            txt_10_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_10, valElevacion).ToString("#0.########");

            txt_10_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_10, valElevacion).ToString("#0.########");

            txt_10_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_10, valElevacion).ToString("#0.########");

            txt_10_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_10, valElevacion).ToString("#0.########");

            txt_10_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_10, valElevacion).ToString("#0.########");

            txt_10_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_10, valElevacion).ToString("#0.########");

            txt_10_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_10, valElevacion).ToString("#0.########");

            txt_10_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_10, valElevacion).ToString("#0.########");

            txt_10_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_10, valElevacion).ToString("#0.########");

            txt_10_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_10, valElevacion).ToString("#0.########");

            txt_10_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_10, valElevacion).ToString("#0.########");

            txt_10_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_10, valElevacion).ToString("#0.########");

            txt_10_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_10, valElevacion).ToString("#0.########");

            txt_10_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_10, valElevacion).ToString("#0.########");

            txt_10_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_10, valElevacion).ToString("#0.########");

            //120°F wbT
            CP_11 = double.Parse(txt_CP_11.Text);

            txt_11_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_11, valElevacion).ToString("#0.########");

            txt_11_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_11, valElevacion).ToString("#0.########");

            txt_11_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_11, valElevacion).ToString("#0.########");

            txt_11_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_11, valElevacion).ToString("#0.########");

            txt_11_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_11, valElevacion).ToString("#0.########");

            txt_11_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_11, valElevacion).ToString("#0.########");

            txt_11_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_11, valElevacion).ToString("#0.########");

            txt_11_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_11, valElevacion).ToString("#0.########");

            txt_11_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_11, valElevacion).ToString("#0.########");

            txt_11_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_11, valElevacion).ToString("#0.########");

            txt_11_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_11, valElevacion).ToString("#0.########");

            txt_11_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_11, valElevacion).ToString("#0.########");

            txt_11_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_11, valElevacion).ToString("#0.########");

            txt_11_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_11, valElevacion).ToString("#0.########");

            txt_11_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_11, valElevacion).ToString("#0.########");

            txt_11_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_11, valElevacion).ToString("#0.########");

            txt_11_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_11, valElevacion).ToString("#0.########");

            txt_11_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_11, valElevacion).ToString("#0.########");

            txt_11_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_11, valElevacion).ToString("#0.########");

            txt_11_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_11, valElevacion).ToString("#0.########");

            txt_11_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_11, valElevacion).ToString("#0.########");

            txt_11_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_11, valElevacion).ToString("#0.########");

            txt_11_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_11, valElevacion).ToString("#0.########");

            txt_11_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_11, valElevacion).ToString("#0.########");

            txt_11_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_11, valElevacion).ToString("#0.########");

            txt_11_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_11, valElevacion).ToString("#0.########");

            txt_11_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_11, valElevacion).ToString("#0.########");

            txt_11_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_11, valElevacion).ToString("#0.########");

            txt_11_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_11, valElevacion).ToString("#0.########");

            txt_11_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_11, valElevacion).ToString("#0.########");

            txt_11_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_11, valElevacion).ToString("#0.########");

            txt_11_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_11, valElevacion).ToString("#0.########");

            txt_11_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_11, valElevacion).ToString("#0.########");

            txt_11_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_11, valElevacion).ToString("#0.########");

            //125°F wbT
            CP_12 = double.Parse(txt_CP_12.Text);

            txt_12_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_12, valElevacion).ToString("#0.########");

            txt_12_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_12, valElevacion).ToString("#0.########");

            txt_12_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_12, valElevacion).ToString("#0.########");

            txt_12_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_12, valElevacion).ToString("#0.########");

            txt_12_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_12, valElevacion).ToString("#0.########");

            txt_12_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_12, valElevacion).ToString("#0.########");

            txt_12_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_12, valElevacion).ToString("#0.########");

            txt_12_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_12, valElevacion).ToString("#0.########");

            txt_12_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_12, valElevacion).ToString("#0.########");

            txt_12_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_12, valElevacion).ToString("#0.########");

            txt_12_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_12, valElevacion).ToString("#0.########");

            txt_12_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_12, valElevacion).ToString("#0.########");

            txt_12_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_12, valElevacion).ToString("#0.########");

            txt_12_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_12, valElevacion).ToString("#0.########");

            txt_12_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_12, valElevacion).ToString("#0.########");

            txt_12_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_12, valElevacion).ToString("#0.########");

            txt_12_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_12, valElevacion).ToString("#0.########");

            txt_12_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_12, valElevacion).ToString("#0.########");

            txt_12_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_12, valElevacion).ToString("#0.########");

            txt_12_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_12, valElevacion).ToString("#0.########");

            txt_12_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_12, valElevacion).ToString("#0.########");

            txt_12_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_12, valElevacion).ToString("#0.########");

            txt_12_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_12, valElevacion).ToString("#0.########");

            txt_12_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_12, valElevacion).ToString("#0.########");

            txt_12_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_12, valElevacion).ToString("#0.########");

            txt_12_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_12, valElevacion).ToString("#0.########");

            txt_12_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_12, valElevacion).ToString("#0.########");

            txt_12_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_12, valElevacion).ToString("#0.########");

            txt_12_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_12, valElevacion).ToString("#0.########");

            txt_12_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_12, valElevacion).ToString("#0.########");

            txt_12_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_12, valElevacion).ToString("#0.########");

            txt_12_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_12, valElevacion).ToString("#0.########");

            txt_12_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_12, valElevacion).ToString("#0.########");

            txt_12_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_12, valElevacion).ToString("#0.########");

            //130°F wbT
            CP_13 = double.Parse(txt_CP_13.Text);

            txt_13_1.Text = Utilities.Formulas.HUMRAT(DBT1, CP_13, valElevacion).ToString("#0.########");

            txt_13_2.Text = Utilities.Formulas.HUMRAT(DBT2, CP_13, valElevacion).ToString("#0.########");

            txt_13_3.Text = Utilities.Formulas.HUMRAT(DBT3, CP_13, valElevacion).ToString("#0.########");

            txt_13_4.Text = Utilities.Formulas.HUMRAT(DBT4, CP_13, valElevacion).ToString("#0.########");

            txt_13_5.Text = Utilities.Formulas.HUMRAT(DBT5, CP_13, valElevacion).ToString("#0.########");

            txt_13_6.Text = Utilities.Formulas.HUMRAT(DBT6, CP_13, valElevacion).ToString("#0.########");

            txt_13_7.Text = Utilities.Formulas.HUMRAT(DBT7, CP_13, valElevacion).ToString("#0.########");

            txt_13_8.Text = Utilities.Formulas.HUMRAT(DBT8, CP_13, valElevacion).ToString("#0.########");

            txt_13_9.Text = Utilities.Formulas.HUMRAT(DBT9, CP_13, valElevacion).ToString("#0.########");

            txt_13_10.Text = Utilities.Formulas.HUMRAT(DBT10, CP_13, valElevacion).ToString("#0.########");

            txt_13_11.Text = Utilities.Formulas.HUMRAT(DBT11, CP_13, valElevacion).ToString("#0.########");

            txt_13_12.Text = Utilities.Formulas.HUMRAT(DBT12, CP_13, valElevacion).ToString("#0.########");

            txt_13_13.Text = Utilities.Formulas.HUMRAT(DBT13, CP_13, valElevacion).ToString("#0.########");

            txt_13_14.Text = Utilities.Formulas.HUMRAT(DBT14, CP_13, valElevacion).ToString("#0.########");

            txt_13_15.Text = Utilities.Formulas.HUMRAT(DBT15, CP_13, valElevacion).ToString("#0.########");

            txt_13_16.Text = Utilities.Formulas.HUMRAT(DBT16, CP_13, valElevacion).ToString("#0.########");

            txt_13_17.Text = Utilities.Formulas.HUMRAT(DBT17, CP_13, valElevacion).ToString("#0.########");

            txt_13_18.Text = Utilities.Formulas.HUMRAT(DBT18, CP_13, valElevacion).ToString("#0.########");

            txt_13_19.Text = Utilities.Formulas.HUMRAT(DBT19, CP_13, valElevacion).ToString("#0.########");

            txt_13_20.Text = Utilities.Formulas.HUMRAT(DBT20, CP_13, valElevacion).ToString("#0.########");

            txt_13_21.Text = Utilities.Formulas.HUMRAT(DBT21, CP_13, valElevacion).ToString("#0.########");

            txt_13_22.Text = Utilities.Formulas.HUMRAT(DBT22, CP_13, valElevacion).ToString("#0.########");

            txt_13_23.Text = Utilities.Formulas.HUMRAT(DBT23, CP_13, valElevacion).ToString("#0.########");

            txt_13_24.Text = Utilities.Formulas.HUMRAT(DBT24, CP_13, valElevacion).ToString("#0.########");

            txt_13_25.Text = Utilities.Formulas.HUMRAT(DBT25, CP_13, valElevacion).ToString("#0.########");

            txt_13_26.Text = Utilities.Formulas.HUMRAT(DBT26, CP_13, valElevacion).ToString("#0.########");

            txt_13_27.Text = Utilities.Formulas.HUMRAT(DBT27, CP_13, valElevacion).ToString("#0.########");

            txt_13_28.Text = Utilities.Formulas.HUMRAT(DBT28, CP_13, valElevacion).ToString("#0.########");

            txt_13_29.Text = Utilities.Formulas.HUMRAT(DBT29, CP_13, valElevacion).ToString("#0.########");

            txt_13_30.Text = Utilities.Formulas.HUMRAT(DBT30, CP_13, valElevacion).ToString("#0.########");

            txt_13_31.Text = Utilities.Formulas.HUMRAT(DBT31, CP_13, valElevacion).ToString("#0.########");

            txt_13_32.Text = Utilities.Formulas.HUMRAT(DBT32, CP_13, valElevacion).ToString("#0.########");

            txt_13_33.Text = Utilities.Formulas.HUMRAT(DBT33, CP_13, valElevacion).ToString("#0.########");

            txt_13_34.Text = Utilities.Formulas.HUMRAT(DBT34, CP_13, valElevacion).ToString("#0.########");

            LimpiarDatos();

        }

        public void LimpiarDatos()
        {
            foreach (Control x in this.tlp_Carta.Controls)
            {
                //if (x is TextBox || x is Label)
                if (x is TextBox)
                {
                    if (x.Text.Equals("0") || x.Text.Equals("-1"))
                    {
                        x.Text = string.Empty;
                    }
                }
            }
        }


    }
}
