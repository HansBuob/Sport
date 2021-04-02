using System.Drawing;

using twr;
using f = twr.DFunktionen;

namespace Sport
{
    public class frmStreckenSortiertPaintProtokoll : frmPaintProtokoll//frmGProtokoll//Sport.frmProtokollOhneGrid
    {
        private System.ComponentModel.IContainer components = null;

        public frmStreckenSortiertPaintProtokoll()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
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
            //SetToolTip(1, "xxx");

            //			this.Text="Zwischenzeiten sortiert nach Strecken";

            this.Text = "Liste ausgeben (Eingegebene Strecken)";
            this.Text += " (" + Settings.Jahr + ")";

            var lrv = new Sport();
            lrv.Jahr = (f.ConvertToInt(Settings.Jahr) - 1).ToString();
            lrv.Pfad = Settings.DataDirectory;
            lrv.Load();

            //SetColor(1,0,100, Color.FromArgb(255,180,80));
            //SetData(1, 0, "Zeit1   ZW1-2  Zeit2   ZW2-3  Zeit3   ZW3-4  Zeit4   ZW4-5  Zeit5   ZW5-6  ");
            SetTitel(" Zeit1   ZW1-2  Zeit2   ZW2-3  Zeit3   ZW3-4  Zeit4   ZW4-5  Zeit5   ZW5-6  Zeit6   ZW6-7  Zeit7");

            var add = 0;
            //			int anz=0;

            double b1 = 0, w1 = 0;
            double b2 = 0, w2 = 0;
            double b3 = 0, w3 = 0;
            double b4 = 0, w4 = 0;
            double b5 = 0, w5 = 0;
            double b6 = 0, w6 = 0;
            double b7 = 0, w7 = 0;

            double lb1 = 0, lw1 = 0;
            double lb2 = 0, lw2 = 0;
            double lb3 = 0, lw3 = 0;
            double lb4 = 0, lw4 = 0;
            double lb5 = 0, lw5 = 0;
            double lb6 = 0, lw6 = 0;
            double lb7 = 0, lw7 = 0;

            for (var i = 0; i < _rv.SdDaten.Count; i++)
            {
                var sd = _rv.SdDaten[i];
                SetData(1, i + add, sd.ZwischenOrt1);
                SetData(16, i + add, sd.ZwischenOrt2);
                SetData(31, i + add, sd.ZwischenOrt3);
                SetData(46, i + add, sd.ZwischenOrt4);
                SetData(61, i + add, sd.ZwischenOrt5);
                SetData(76, i + add, sd.ZwischenOrt6);
                SetData(91, i + add, sd.ZwischenOrt7);

                //				anz++;

                //				SetData(4, 1, 9.0, 2);
                //				SetData(4, 2, 10.0, 2);

                var anzData = 0;
                for (var s = 0; s < _rv.RvDaten.Count; s++)
                {
                    if (s == 0)
                        if (!_rv.RVBest(sd.Strecke, out b1, out w1, out b2, out w2, out b3, out w3, out b4, out w4, out b5, out w5, out b6, out w6, out b7, out w7))
                            _rv.RVBest(sd.Rundfahrt, out b1, out w1, out b2, out w2, out b3, out w3, out b4, out w4, out b5, out w5, out b6, out w6, out b7, out w7);

                    var rv = _rv.RvDaten[s];

                    if (rv.Strecke != sd.Strecke)
                    {
                        if (rv.Strecke.ToLower() != sd.Rundfahrt.ToLower())
                            continue;
                    }

                    anzData++;
                    var best = Color.Green;//.Beige;
                    var worst = Color.Red;
                    var color = Color.Black;

                    if (!lrv.RVBest(sd.Strecke, out lb1, out lw1, out lb2, out lw2, out lb3, out lw3, out lb4, out lw4, out lb5, out lw5, out lb6, out lw6, out lb7, out lw7))
                        lrv.RVBest(sd.Rundfahrt, out lb1, out lw1, out lb2, out lw2, out lb3, out lw3, out lb4, out lw4, out lb5, out lw5, out lb6, out lw6, out lb7, out lw7);

                    var tooltip = lrv.Jahr + "\r\n";
                    tooltip += lb1.ToString("00.00") + " ";
                    if (lw2 != 0.0)
                        tooltip += lb2.ToString("00.00") + " ";
                    if (lw3 != 0.0)
                        tooltip += lb3.ToString("00.00") + " ";
                    if (lw4 != 0.0)
                        tooltip += lb4.ToString("00.00") + " ";
                    if (lw5 != 0.0)
                        tooltip += lb5.ToString("00.00") + " ";
                    if (lw6 != 0.0)
                        tooltip += lb6.ToString("00.00") + " ";
                    if (lw7 != 0.0)
                        tooltip += lb7.ToString("00.00") + " ";

                    tooltip += "\r\n";
                    tooltip += lw1.ToString("00.00") + " ";
                    if (lw2 != 0.0)
                        tooltip += lw2.ToString("00.00") + " ";
                    if (lw3 != 0.0)
                        tooltip += lw3.ToString("00.00") + " ";
                    if (lw4 != 0.0)
                        tooltip += lw4.ToString("00.00") + " ";
                    if (lw5 != 0.0)
                        tooltip += lw5.ToString("00.00") + " ";
                    if (lw6 != 0.0)
                        tooltip += lw6.ToString("00.00") + " ";
                    if (lw7 != 0.0)
                        tooltip += lw7.ToString("00.00") + " ";

                    SetToolTip(1 + add + i, tooltip);

                    if (rv.ZwischenZeit1 == b1) color = best;
                    if (rv.ZwischenZeit1 == w1) color = worst;

                    SetData(3, 1 + add + i, rv.ZwischenZeit1.GetValueOrDefault(), 2, color);

                    color = Color.Black;
                    if (rv.ZwischenZeit2 - rv.ZwischenZeit1 == b2) color = best;
                    if (rv.ZwischenZeit2 - rv.ZwischenZeit1 == w2) color = worst;
                    SetData(11, 1 + add + i, rv.ZwischenZeit2.GetValueOrDefault() - rv.ZwischenZeit1.GetValueOrDefault(), 2, color);
                    SetData(18, 1 + add + i, rv.ZwischenZeit2.GetValueOrDefault(), 2);

                    color = Color.Black;
                    if (rv.ZwischenZeit3 - rv.ZwischenZeit2 == b3) color = best;
                    if (rv.ZwischenZeit3 - rv.ZwischenZeit2 == w3) color = worst;
                    SetData(26, 1 + add + i, rv.ZwischenZeit3.GetValueOrDefault() - rv.ZwischenZeit2.GetValueOrDefault(), 2, color);
                    SetData(33, 1 + add + i, rv.ZwischenZeit3.GetValueOrDefault(), 2);

                    color = Color.Black;
                    if (rv.ZwischenZeit4 - rv.ZwischenZeit3 == b4) color = best;
                    if (rv.ZwischenZeit4 - rv.ZwischenZeit3 == w4) color = worst;

                    SetData(41, 1 + add + i, rv.ZwischenZeit4.GetValueOrDefault() - rv.ZwischenZeit3.GetValueOrDefault(), 2, color);
                    SetData(48, 1 + add + i, rv.ZwischenZeit4.GetValueOrDefault(), 2);
                    if (rv.ZwischenZeit5 > 0.0)
                    {
                        color = Color.Black;
                        if (rv.ZwischenZeit5 - rv.ZwischenZeit4 == b5) color = best;
                        if (rv.ZwischenZeit5 - rv.ZwischenZeit4 == w5) color = worst;
                        SetData(56, 1 + add + i, rv.ZwischenZeit5.GetValueOrDefault() - rv.ZwischenZeit4.GetValueOrDefault(), 2, color);
                        SetData(63, 1 + add + i, rv.ZwischenZeit5.GetValueOrDefault(), 2);
                    }
                    if (rv.ZwischenZeit6 > 0.0)
                    {
                        color = Color.Black;
                        if (rv.ZwischenZeit6 - rv.ZwischenZeit5 == b6) color = best;
                        if (rv.ZwischenZeit6 - rv.ZwischenZeit5 == w6) color = worst;
                        SetData(71, 1 + add + i, rv.ZwischenZeit6.GetValueOrDefault() - rv.ZwischenZeit5.GetValueOrDefault(), 2, color);
                        SetData(78, 1 + add + i, rv.ZwischenZeit6.GetValueOrDefault(), 2);
                    }
                    if (rv.ZwischenZeit7 != null)
                    {
                        color = Color.Black;
                        if (rv.ZwischenZeit7 - rv.ZwischenZeit6 == b7) color = best;
                        if (rv.ZwischenZeit7 - rv.ZwischenZeit6 == w7) color = worst;
                        SetData(86, 1 + add + i, rv.ZwischenZeit7.Value, 2);
                        SetData(93, 1 + add + i, rv.ZwischenZeit7.GetValueOrDefault() - rv.ZwischenZeit6.GetValueOrDefault(), 2, color);
                    }
                    //SetData(52, 3+ add+i, rv.ZwischenZeit7, 2);
                    add++;
                }
                if (anzData == 0)
                {
                    SetData(0, 1 + add + i, "                                                                                                    ");
                    SetData(0, 1 + add + i - 1, "                                                                                                    ");
                    add--;
                    add--;
                }
                //				else
                //					SetData(0,1+add+i,   " -                                                                                              ");

                add++;
                //				add++;
            }
        }
    }
}