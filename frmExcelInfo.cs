using System.Collections;

using twr;
using f = twr.DFunktionen;

//using Rvdv;

namespace Sport
{
    public class frmExcelInfo : frmPaintProtokoll//frmGProtokoll//frmProtokollOhneGrid
    {
        private System.ComponentModel.IContainer components = null;

        public frmExcelInfo()
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
            //
            // frmExcelInfo
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(934, 430);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "frmExcelInfo";
            this.Text = "Excel-Info ()";
        }

        #endregion

        private Sport _rv = new Sport();

        protected override void OnInitial()
        {
            var aStrecke = new ArrayList();
            for (var i = 0; i < 20; i++)
            {
                aStrecke.Add(0);
            }

            //			SetData(2,0,11.2345,2);

            this.Text = "Excel-Info";
            this.Text += " (" + Settings._Jahr + ")";

            //			SetData(1,0,"Jahr: " + Settings._Jahr);
            //			SetColor(1, 0, 100, Color.PaleGreen);

            /*			SetColor(1,2,1, Color.FromArgb(255,180,80));
                        SetColor(2,3,1, Color.FromArgb(255,180,80));
                        SetColor(3,2,1, Color.FromArgb(255,180,80));
                        SetColor(4,3,1, Color.FromArgb(255,180,80));
                        SetColor(5,2,1, Color.FromArgb(255,180,80));
            */
            SetTitel("Monat            Km     Std     Km/h     mal      ");
            var titel = "Monat            Km     Std     Km/h     mal  ";
            //			SetColor(1,1,100, Color.FromArgb(255,180,80));
            //			SetData(1, 1, "Monat            Km     Std     Km/h     mal      ");
            //			SetData(1, 1, "MMMMM            Km     Std     Km/h     mal      ");
            SetData(0, 1, "Januar           _.__    _.__    _.__      0");
            //			SetData(0, 3, "Januar           _.__    _.__    _.__      0");
            SetData(0, 2, "Februar          _.__    _.__    _.__      0");
            SetData(0, 3, "März             _.__    _.__    _.__      0");
            SetData(0, 4, "April            _.__    _.__    _.__      0");
            SetData(0, 5, "Mai              _.__    _.__    _.__      0");
            SetData(0, 6, "Juni             _.__    _.__    _.__      0");
            SetData(0, 7, "Juli             _.__    _.__    _.__      0");
            SetData(0, 8, "August           _.__    _.__    _.__      0");
            SetData(0, 9, "September        _.__    _.__    _.__      0");
            SetData(0, 10, "Oktober          _.__    _.__    _.__      0");
            SetData(0, 11, "November         _.__    _.__    _.__      0");
            SetData(0, 12, "Dezember         _.__    _.__    _.__      0");

            SetData(0, 15, "Rennvelo         _.__    _.__    _.__      0");
            SetData(0, 16, "Heimtrainer      _.__    _.__    _.__      0");
            SetData(0, 17, "Joggen           _.__    _.__    _.__      0");

            for (var z = 0; z < _rv.SdDaten.Count; z++)
            {
                var sd = (SDDaten)_rv.SdDaten[z];
                //				SetData(46 + z*3, 1-1, "| " + sd.Strecke + "|");
                if (!titel.EndsWith("|"))
                    titel += "| " + sd.Strecke + "|";
                else
                    titel += " " + sd.Strecke + "|";
            }
            SetTitel(titel);
            //			SetData(0,0," ");
            for (var z = 0; z < _rv.SdDaten.Count; z++)
            {
                for (var m = 0; m < 12; m++)
                {
                    SetData(46 + z * 3, 2 + m - 1 - 1 + 1, "|  |");
                }
            }

            int monat = 0, lmonat = 0;

            int mal = 0, tmal = 0;
            double km = 0.0, tkm = 0.0;
            double zeit = 0.0, tzeit = 0.0;

            double minKg = 200;
            double maxKg = 0;
            double lkg = 0;
            var ldatum = "";
            var tkcal = 0.0;

            //			ArrayList strecken=new ArrayList();
            //strecken...Add

            var strecken = new Hashtable();
            for (var i = 0; i < _rv.RvDaten.Count; i++)
            {
                var rv = (RVDaten)_rv.RvDaten[i];
                var datum = rv.StringDatum;
                datum = datum.Substring(4, 2);
                monat = f.ConvertToInt(datum);

                tkcal += rv.Kcal;
                if (monat != lmonat)
                {
                    mal = 0;
                    km = 0.0;
                    zeit = 0.0;

                    //					if(strecken.Count!=0)
                    //					{
                    for (var z = 0; z < _rv.SdDaten.Count; z++)
                    {
                        var sd = (SDDaten)_rv.SdDaten[z];
                        if (!strecken.ContainsKey(sd.Strecke))
                            SetData(46 + z * 3, monat + 1 - 1, "|  |");
                        else
                        {
                            var anz = (int)strecken[sd.Strecke];
                            //								if(anz<10)
                            //	SetData(46 + z*3, monat+1-1-1, "| " + anz.ToString() + " |");
                            SetData(46 + z * 3 + 3, monat + 1 - 1 - 1, anz, 0);

                            var tanz = (int)aStrecke[z];
                            tanz += anz;
                            aStrecke[z] = tanz;

                            //								else
                            //									SetData(46 + z*3, monat+1-1-1, "|" + anz.ToString() + "|");
                        }
                    }
                    //46
                    //					}

                    strecken = new Hashtable();

                    //					for(int z=0;z<100;z++)
                    //						strecken.Add(0);
                }
                //				SetData(0, monat, monat.ToString());
                //rv.s
                if (rv.Gewicht > maxKg)
                    maxKg = rv.Gewicht;
                if (rv.Gewicht < minKg)
                    minKg = rv.Gewicht;
                lkg = rv.Gewicht;
                ldatum = rv.StringDatum;

                if (strecken.ContainsKey(rv.Strecke))
                {
                    var anz = (int)strecken[rv.Strecke];
                    strecken.Remove(rv.Strecke);
                    anz++;
                    strecken.Add(rv.Strecke, anz);
                }
                else
                    strecken.Add(rv.Strecke, 1);

                km += rv.Km;
                tkm += rv.Km;
                zeit += rv.TotalZeit;
                tzeit += rv.TotalZeit;

                mal++; tmal++;
                if (mal < 10)
                    SetData(44 - 1, monat + 1 - 1, mal.ToString());
                else
                    SetData(43 - 1, monat + 1 - 1, mal.ToString());

                //18
                SetData(18 + 1 - 1, monat + 1 - 1, km, 2);
                //				SetData(18+1-1, monat+1-1, km.ToString("0.00"));
                SetData(25 + 2 - 1, monat + 1 - 1, (zeit / 60.0), 2);
                if (zeit == 0.0)
                    SetData(33 + 2 - 1, monat + 1 - 1, "0.00");
                else
                    SetData(33 + 2 - 1, monat + 1 - 1, (km / (zeit / 60.0)), 2);
                //					SetData(33+2-1, monat+1-1, (km/(zeit/60.0)).ToString("0.00"));

                lmonat = monat;
            }
            for (var z = 0; z < _rv.SdDaten.Count; z++)
            {
                var sd = (SDDaten)_rv.SdDaten[z];
                if (!strecken.ContainsKey(sd.Strecke))
                    SetData(46 + z * 3, monat + 1 - 1, "|  |");
                else
                {
                    var anz = (int)strecken[sd.Strecke];
                    SetData(46 + z * 3 + 3, monat + 1 - 1, anz, 0);
                    //					if(anz<10)
                    //						SetData(46 + z*3, monat+1-1, "| " + anz.ToString() + " |");
                    //					else
                    //						SetData(46 + z*3, monat+1-1, "|" + anz.ToString() + "|");
                }
            }

            for (var i = 0; i < aStrecke.Count; i++)
            {
                if ((int)aStrecke[i] != 0)
                    SetData(46 + i * 3 + 3, 13, (int)aStrecke[i], 0);
            }

            /*
                        SetData(18+1-1,14, tkm,2);//.ToString("0.00"));
                        SetData(25+2-1,14, (tzeit/60.0),2);//.ToString("0.00"));
                        if(zeit==0.0)
                            SetData(32+2,14, 0.0 ,2);//"0.00",2);//);
                        else
                            SetData(32+2,14, (tkm/(tzeit/60.0)),2);//.ToString("0.00"));
            //			if(tmal<10)
            //				SetData(44-1,15, tmal,0);
                        SetData(44-1+1,14, tmal,0);
                        //			else
            //				SetData(43-1,15, tmal.ToString());

            */

            if (_rv.RvDaten.Count > 0)
            {
                SetData(0, 15, "Rennvelo   ");
                SetData(18, 15, tkm, 2);
                SetData(26, 15, (tzeit / 60.0), 2);
                SetData(34, 15, (tkm / (tzeit / 60.0)), 2);
                SetData(44, 15, tmal, 0);
                SetData(50 - 1, 15, tkcal / 900 / 10, 2);
            }

            var ttkm = tkm;
            var ttzeit = tzeit;
            var ttmal = tmal;
            var ttkcal = tkcal;

            if (_rv.HtDaten.Count > 0)
            {
                tkm = 0.0;
                tzeit = 0.0;
                tkcal = 0.0;
                for (var i = 0; i < _rv.HtDaten.Count; i++)
                {
                    var ht = (HeimtrainerDaten)_rv.HtDaten[i];
                    tzeit += f.ConvertToDouble(ht.Dauer);
                    tkm += ht.Distanz;
                    tkcal += ht.KJoul / 4.186;

                    if (f.ConvertToInt(ldatum) < f.ConvertToInt(ht.StringDatum))
                    {
                        lkg = ht.Gewicht;
                        ldatum = ht.StringDatum;
                    }

                    if (maxKg < ht.Gewicht)
                        maxKg = ht.Gewicht;
                    if (ht.Gewicht < minKg)
                        minKg = ht.Gewicht;
                }

                SetData(18, 16, tkm, 2);
                SetData(26, 16, (tzeit / 60.0), 2);
                if (tzeit != 0.0)
                    SetData(34, 16, (tkm / (tzeit / 60.0)), 2);
                SetData(44, 16, _rv.HtDaten.Count, 0);
                SetData(50 - 1, 16, tkcal / 900 / 10, 2);

                ttkm += tkm;
                ttzeit += tzeit;
                ttmal += _rv.HtDaten.Count;
                ttkcal += tkcal;
            }

            if (_rv.JoDaten.Count > 0)
            {
                tkm = 0.0;
                tzeit = 0.0;
                tkcal = 0.0;
                for (var i = 0; i < _rv.JoDaten.Count; i++)
                {
                    var jo = (JoggenDaten)_rv.JoDaten[i];
                    tzeit += f.ConvertToDouble(jo.Dauer);
                    //				tkm+=ht.Distanz;
                }
                tkm = tzeit / 60 * 12;//12 Km/h

                SetData(18, 17, tkm, 2);
                SetData(26, 17, (tzeit / 60.0), 2);
                if (tzeit != 0.0)
                    SetData(34, 17, (tkm / (tzeit / 60.0)), 2);
                SetData(44, 17, _rv.JoDaten.Count, 0);

                tkcal = 800 * tzeit / 60.0;
                SetData(50 - 1, 17, tkcal / 900 / 10, 2);

                ttkm += tkm;
                ttzeit += tzeit;
                ttmal += _rv.JoDaten.Count;
                ttkcal += tkcal;
            }

            SetData(0, 18, "Total   ");
            SetData(18, 18, ttkm, 2);
            SetData(26, 18, (ttzeit / 60.0), 2);
            if (ttzeit != 0.0)
                SetData(34, 18, (ttkm / (ttzeit / 60.0)), 2);
            else
                SetData(34, 18, 0.0, 2);

            SetData(44, 18, ttmal, 0);
            SetData(50 - 1, 18, ttkcal / 900 / 10, 2);

            SetData(0, 17 + 3, "(" + minKg.ToString() + "/" + maxKg.ToString() + ") " + lkg.ToString());
        }

        public Sport setRV
        {
            set
            {
                _rv = value;
            }
        }
    }
}