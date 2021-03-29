using System.IO;
using System.Xml;
using twr.common;
using f = twr.DFunktionen;

namespace Sport
{
    public class RVDaten : SportDaten
    {
        //		bool _bNewFormat=false;
        public RVDaten() { }

        public RVDaten(string Strecke)
        {
        }

        public bool Serialize(XmlNode dataNode)
        {
            string zeit1 = "0.00", zeit2 = "0.00", zeit3 = "0.00", zeit4 = "0.00", zeit5 = "0.00", zeit6 = "0.00", zeit7 = "0.00", zeit8 = "0.00", zeit9 = "0.00", zeit10 = "0.00";
            for (; ; )
            {
                if (dataNode == null)
                    break;
                if (dataNode.LocalName.ToLower() == "datum")
                    StringDatum = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "strecke")
                    Strecke = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit1")
                    zeit1 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit2")
                    zeit2 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit3")
                    zeit3 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit4")
                    zeit4 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit5")
                    zeit5 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit6")
                    zeit6 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit7")
                    zeit7 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit8")
                    zeit8 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit9")
                    zeit9 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "zeit10")
                    zeit10 = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "avs")
                    _Durchschnitt = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "mxs")
                    _Hoechst = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "gewicht")
                    this.Gewicht = dataNode.InnerXml.ToDouble();
                else if (dataNode.LocalName.ToLower() == "bemerkung")
                    this.Bemerkung = dataNode.InnerXml;
                else
                {
                    System.Diagnostics.Debug.Assert(false);
                    return false;
                }

                dataNode = dataNode.NextSibling;
                //_bNewFormat=true;
            }
            _Total = "0.00";//Durchschnitt auf bestimmte Strecke
            _ZwischenZeit1 = zeit1;
            _ZwischenZeit2 = zeit2;
            _ZwischenZeit3 = zeit3;
            _ZwischenZeit4 = zeit4;
            _ZwischenZeit5 = zeit5;
            _ZwischenZeit6 = zeit6;
            _ZwischenZeit7 = zeit7;

            _TotalZeit = _ZwischenZeit7;
            if (f.ConvertToDouble(_TotalZeit) == 0)
                _TotalZeit = _ZwischenZeit6;
            if (f.ConvertToDouble(_TotalZeit) == 0)
                _TotalZeit = _ZwischenZeit5;
            if (f.ConvertToDouble(_TotalZeit) == 0)
                _TotalZeit = _ZwischenZeit4;
            if (f.ConvertToDouble(_TotalZeit) == 0)
                _TotalZeit = _ZwischenZeit3;
            if (f.ConvertToDouble(_TotalZeit) == 0)
                _TotalZeit = _ZwischenZeit2;
            if (f.ConvertToDouble(_TotalZeit) == 0)
                _TotalZeit = _ZwischenZeit1;

            //_ARS aus total.dat immer automatisch bestimmen, es sei den bereits vorhanden

            //_ZwischenZeit8=zeit1;
            //_ZwischenZeit9=zeit1;
            //_ZwischenZeit10=zeit1;

            return true;
        }

        public bool Serialize(object stream)
        {
            if (stream is StreamReader)
            {
                var sr = (StreamReader)stream;
                var data = "";
again:
                data = sr.ReadLine();
                if (data == null)
                    return false;
                if (data == "")
                    goto again;

                var str = data + ",";

                _ABCStrecke = f.ConvertToInt(f.HeadFromList(ref str, ","));
                _Strecke = f.HeadFromList(ref str, ",");
                _Durchschnitt = f.HeadFromList(ref str, ",");
                _Hoechst = f.HeadFromList(ref str, ",");
                this.Gewicht = f.HeadFromList(ref str, ",").ToDouble();
                _TotalZeit = f.HeadFromList(ref str, ",");
                _ARS = f.ConvertToInt(f.HeadFromList(ref str, ","));
                _ZwischenZeit1 = f.HeadFromList(ref str, ",");
                _ZwischenZeit2 = f.HeadFromList(ref str, ",");
                _ZwischenZeit3 = f.HeadFromList(ref str, ",");

                _ZwischenZeit4 = f.HeadFromList(ref str, ",");
                _ZwischenZeit5 = f.HeadFromList(ref str, ",");
                _ZwischenZeit6 = f.HeadFromList(ref str, ",");
                _ZwischenZeit7 = f.HeadFromList(ref str, ",");
                _Total = f.HeadFromList(ref str, ",");
                this.StringDatum = f.HeadFromList(ref str, ",");
                //		m_Datum=ChangeDatum(m_Datum);

                this.Bemerkung = f.HeadFromList(ref str, ",");
                this.Bemerkung = this.Bemerkung.Replace("{K}", ",");

                return true;
            }
            if (stream is StreamWriter)
            {
                var sw = (StreamWriter)stream;

                var data = "";
                data = _ABCStrecke + ",";
                data += _Strecke + ",";
                data += _Durchschnitt + ",";
                data += _Hoechst + ",";
                data += this.Gewicht.ToString() + ",";
                data += _TotalZeit + ",";
                data += _ARS.ToString() + ",";
                data += _ZwischenZeit1 + ",";
                data += _ZwischenZeit2 + ",";
                data += _ZwischenZeit3 + ",";

                data += _ZwischenZeit4 + ",";
                data += _ZwischenZeit5 + ",";
                data += _ZwischenZeit6 + ",";
                data += _ZwischenZeit7 + ",";
                data += _Total + ",";
                data += this.StringDatum + ",";
                //		m_Datum=ChangeDatum(m_Datum);

                data += this.Bemerkung.Replace(",", "{K}") + ",";

                sw.WriteLine(data);
                return true;
            }

            /*		if(stream.CanRead)
                    {
                        stream
                    }
                    if(stream.CanWrite)
                    {
                    }
            */
            return false;
        }

        private int _ABCStrecke;
        private string _Strecke;
        private string _Durchschnitt;
        private string _Hoechst;

        //		string _Gewicht;
        private string _TotalZeit;

        private long _ARS;
        private string _ZwischenZeit1;
        private string _ZwischenZeit2;
        private string _ZwischenZeit3;
        private string _ZwischenZeit4;
        private string _ZwischenZeit5;
        private string _ZwischenZeit6;
        private string _ZwischenZeit7;

        private string _Total;

        //		string _Datum;
        //		string _Bemerkung;

        public double Kcal
        {
            get
            {
                //				return 0.0;

                var kcal = 0.0525 * f.ConvertToDouble(_TotalZeit) + 0.125 * (double)this.ARS * this.Gewicht;
                return kcal;
                //				Kcal=0.0525 * m_Total + 0.125 * m_ARS * m_Gewicht;
            }
        }

        public double Km
        {
            get
            {
                return (Durchschnitt * TotalZeit) / 60.0;
            }
        }

        public string Strecke
        {
            get
            {
                /*				_Strecke=_Strecke.Trim();
                                if(_Strecke.Length>0)
                                {
                                    string tmp=_Strecke.Substring(0).ToUpper();
                                    _Strecke=_Strecke.Substring(1);
                                    _Strecke=tmp+_Strecke;
                                }*/
                return _Strecke;
            }
            set
            {
                _Strecke = value;
            }
        }

        public double Durchschnitt
        {
            get
            {
                return f.ConvertToDouble(_Durchschnitt);
            }
            set
            {
                _Durchschnitt = value.ToString();
            }
        }

        public double Hoechst
        {
            get
            {
                return f.ConvertToDouble(_Hoechst);
            }
            set
            {
                _Hoechst = value.ToString();
            }
        }

        /*
                public double Gewicht
                {
                    get
                    {
                        return f.ConvertToDouble(_Gewicht);
                    }
                    set
                    {
                        _Gewicht=value.ToString();
                    }
                }*/

        public double TotalZeit
        {
            get
            {
                return f.ConvertToDouble(_TotalZeit);
            }
            set
            {
                _TotalZeit = value.ToString();
            }
        }

        public long ARS
        {
            get
            {
                if (_ARS != 0.0)
                    return _ARS;

                var ars = 0.00133 * this.Durchschnitt;
                ars = this.TotalZeit * this.Durchschnitt * ars;
                _ARS = (long)ars;
                return _ARS;
            }
            //set
            //{
            //    _ARS=value;
            //}
        }

        public double Total
        {
            get
            {
                return f.ConvertToDouble(_Total);
            }
            set
            {
                _Total = value.ToString();
            }
        }

        /*
                public string Datum
                {
                    get
                    {
                        return _Datum;
                    }
                    set
                    {
                        _Datum=value;
                    }
                }*/
        /*
                public string Bemerkung
                {
                    get
                    {
                        return _Bemerkung;
                    }
                    set
                    {
                        _Bemerkung=value;
                    }
                }*/

        public double ZwischenZeit1
        {
            get
            {
                return f.ConvertToDouble(_ZwischenZeit1);
            }
            set
            {
                _ZwischenZeit1 = value.ToString();
            }
        }

        public double ZwischenZeit2
        {
            get
            {
                return f.ConvertToDouble(_ZwischenZeit2);
            }
            set
            {
                _ZwischenZeit2 = value.ToString();
            }
        }

        public double ZwischenZeit3
        {
            get
            {
                return f.ConvertToDouble(_ZwischenZeit3);
            }
            set
            {
                _ZwischenZeit3 = value.ToString();
            }
        }

        public double ZwischenZeit4
        {
            get
            {
                return f.ConvertToDouble(_ZwischenZeit4);
            }
            set
            {
                _ZwischenZeit4 = value.ToString();
            }
        }

        public double ZwischenZeit5
        {
            get
            {
                return f.ConvertToDouble(_ZwischenZeit5);
            }
            set
            {
                _ZwischenZeit5 = value.ToString();
            }
        }

        public double ZwischenZeit6
        {
            get
            {
                return f.ConvertToDouble(_ZwischenZeit6);
            }
            set
            {
                _ZwischenZeit6 = value.ToString();
            }
        }

        public double ZwischenZeit7
        {
            get
            {
                return f.ConvertToDouble(_ZwischenZeit7);
            }
            set
            {
                _ZwischenZeit7 = value.ToString();
            }
        }
    }
}