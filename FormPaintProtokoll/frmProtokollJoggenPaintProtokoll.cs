using System.Drawing;

using twr;

namespace Sport
{
    /// <summary>
    /// Summary description for frmProtokollJoggenPaintProtokoll.
    /// </summary>
    public class frmProtokollJoggenPaintProtokoll : frmPaintProtokoll//: System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmProtokollJoggenPaintProtokoll()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Size = new System.Drawing.Size(300, 300);
            this.Text = "frmProtokollJoggenPaintProtokoll";
        }

        #endregion

        private Sport _rv = new Sport();

        public Sport setRV
        {
            set
            {
                _rv = value;
            }
        }

        protected override void OnInitial()
        {
            //			SetData(2,0,11.2345,2);

            this.Text = "Joggen-Info";
            this.Text += " (" + Settings.Jahr + ")";

            SetTitel(" Datum     Zeit   G1 /W1  G2 /W2  G3 /W3  G4 /W4  G5   Gewicht Strecke               Bemerkung ");
            SetTitel(" Datum       Zeit    Position-1    Position-2    Position-3    Position-4    Position-5    Position-6   Gewicht Strecke          Bemerkung ");
            //
            //			double tZeit=0.0;
            //			double tKJoul=0.0;
            //			double tKm=0.0;
            for (var i = 0; i < _rv.JoDaten.Count; i++)
            {
                var jo = _rv.JoDaten[i];
                //
                var datum = jo.StringDatum.Substring(6, 2) + "." + jo.StringDatum.Substring(4, 2) + "." + jo.StringDatum.Substring(0, 4);

                SetData(1, i, datum);//"Monat            Km     Std     Km/h     mal      ");

                SetData(15, i, jo.Dauer, 2);
                if (jo.Position1 != 0.0)
                    SetData(23, i, jo.Position1, 2);
                if (jo.Position2 != 0.0)
                    SetData(23 + 6, i, Sport.GetZwischenZeit(jo.Position2, jo.Position1), 2, Color.Beige);

                //string ss=jo.ZZ1;

                //                if(jo.W1!=0.0)
                //                {
                //                    if(jo.W1>=1.0)
                //                        SetData(23,i, jo.W1,0);
                //                    else
                //                    {
                //                        SetData(22,i, jo.W1,1);
                ////						SetData(22,i, "<1");
                //                    }
                //                    SetData(23-2,i, "/");
                //                }
                //                if(jo.G2!=0.0)SetData(27,i, jo.G2,1);
                if (jo.Position2 != 0.0)
                    SetData(37, i, jo.Position2, 2);
                if (jo.Position3 != 0.0)
                    SetData(37 + 6, i, Sport.GetZwischenZeit(jo.Position3, jo.Position2), 2, Color.Beige);

                //if(jo.W2!=0.0)
                //{
                //    if(jo.W2>=1.0)
                //        SetData(31,i, jo.W2,0);
                //    else
                //    {
                //        SetData(30,i, jo.W2,1);
                //    //	SetData(30,i, "<1");
                //    }

                //    SetData(31-2,i, "/");
                //}
                //if(jo.G3!=0.0)SetData(35,i, jo.G3,1);
                if (jo.Position3 != 0.0)
                    SetData(51, i, jo.Position3, 2);
                if (jo.Position4 != 0.0)
                    SetData(51 + 6, i, Sport.GetZwischenZeit(jo.Position4, jo.Position3), 2, Color.Beige);

                //				if(jo.W3!=0.0)
                //				{
                //					if(jo.W3>=1.0)
                //						SetData(39,i, jo.W3,0);
                //					else
                //					{
                //						SetData(38,i, jo.W3,1);
                //					//	SetData(38,i, "<1");
                //					}
                //					SetData(39-2,i, "/");
                //				}
                //				if(jo.G4!=0.0)SetData(43,i, jo.G4,1);
                if (jo.Position4 != 0.0)
                    SetData(65, i, jo.Position4, 2);
                if (jo.Position5 != 0.0)
                    SetData(65 + 6, i, Sport.GetZwischenZeit(jo.Position5, jo.Position4), 2, Color.Beige);

                //				if(jo.W4!=0.0)
                //				{
                //					SetData(47,i, jo.W4,0);
                //					SetData(47-2,i, "/");
                //				}
                //				if(jo.G5!=0.0)SetData(51,i, jo.G5,1);
                if (jo.Position5 != 0.0)
                    SetData(79, i, jo.Position5, 2);
                if (jo.Position6 != 0.0)
                    SetData(79 + 6, i, Sport.GetZwischenZeit(jo.Position6, jo.Position5), 2, Color.Beige);

                if (jo.Position6 != 0.0)
                    SetData(93, i, jo.Position6, 2);
                //if(jo.Position6!=0.0)
                //	SetData(93+5, i, jo.Position6-jo.Position5, 1, Color.Beige);

                //if(jo.W5!=0.0)SetData(55,i, jo.W5,0);

                if (jo.Gewicht != 0.0)
                    SetData(106, i, jo.Gewicht, 1);

                SetData(112, i, jo.Strecke);
                //				SetData(35, i, f.ConvertToDouble(jo.Zeit),2);
                if (!string.IsNullOrWhiteSpace(jo.Bemerkung))
                {
                    SetData(127, i, "                                 ");
                    SetData(127, i, "  " + jo.Bemerkung);
                }

                //				SetData(15, i, ht.Belastung,1);
                //				SetData(25, i, f.ConvertToDouble(ht.Zeit),2);
                //				SetData(34, i, ht.PulsschlagVor,0);
                //				SetData(34, i, "/");
                //				SetData(38, i, ht.PulsschlagNach,0);
                //				SetData(44, i, ht.Distanz,1);
                //				SetData(52, i, 60*ht.Distanz/f.ConvertToDouble(ht.Zeit),2);
                //				SetData(65, i, ht.KJoul,0);
                //				SetData(71, i, ht.KJoul/4.186,0);
                //				SetData(78, i, f.ConvertToDouble(ht.Gewicht),1);
                //
                //				tZeit+=f.ConvertToDouble(ht.Zeit);
                //				tKm+=ht.Distanz;
                //				tKJoul+=ht.KJoul;
            }
            //
            //
            //			int y=_rv.HtDaten.Count+2;
            //			SetData(1, y, _rv.HtDaten.Count.ToString());
            //			SetData(25, y, tZeit/60,2);
            //			SetData(29, y, "Std");
            //			SetData(44, y, tKm,1);
            //			SetData(47, y, "Km");
            //			//SetData(65, y, tKJoul/4.186,2);
            //			SetData(68, y, tKJoul/4.186/900/10,2);
            //			SetData(72, y, "Kg");
        }
    }
}