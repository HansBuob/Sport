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

        public RVDaten(string strecke)
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
            _ZwischenZeit1 = zeit1.ToDouble();
            _ZwischenZeit2 = zeit2.ToDouble();
            _ZwischenZeit3 = zeit3.ToDouble();
            _ZwischenZeit4 = zeit4.ToDouble();
            _ZwischenZeit5 = zeit5.ToDouble();
            _ZwischenZeit6 = zeit6.ToDouble();
            _ZwischenZeit7 = zeit7.ToDouble();

            _TotalZeit = _ZwischenZeit7.GetValueOrDefault();
            if (_TotalZeit == 0)
                _TotalZeit = _ZwischenZeit6.GetValueOrDefault();
            if (_TotalZeit == 0)
                _TotalZeit = _ZwischenZeit5.GetValueOrDefault();
            if (_TotalZeit == 0)
                _TotalZeit = _ZwischenZeit4.GetValueOrDefault();
            if (_TotalZeit == 0)
                _TotalZeit = _ZwischenZeit3.GetValueOrDefault();
            if (_TotalZeit == 0)
                _TotalZeit = _ZwischenZeit2.GetValueOrDefault();
            if (_TotalZeit == 0)
                _TotalZeit = _ZwischenZeit1.GetValueOrDefault();

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
                _TotalZeit = f.HeadFromList(ref str, ",").ToDouble();
                _ARS = f.ConvertToInt(f.HeadFromList(ref str, ","));
                _ZwischenZeit1 = f.HeadFromList(ref str, ",").ToDouble();
                _ZwischenZeit2 = f.HeadFromList(ref str, ",").ToDouble();
                _ZwischenZeit3 = f.HeadFromList(ref str, ",").ToDouble();

                _ZwischenZeit4 = f.HeadFromList(ref str, ",").ToDouble();
                _ZwischenZeit5 = f.HeadFromList(ref str, ",").ToDouble();
                _ZwischenZeit6 = f.HeadFromList(ref str, ",").ToDouble();
                _ZwischenZeit7 = f.HeadFromList(ref str, ",").ToDouble();
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

        public string Bemerkung { get; set; }

        private int _ABCStrecke;
        private string _Strecke;
        private string _Durchschnitt;
        private string _Hoechst;

        //		string _Gewicht;
        private double _TotalZeit;

        private long _ARS;
        private double? _ZwischenZeit1;
        private double? _ZwischenZeit2;
        private double? _ZwischenZeit3;
        private double? _ZwischenZeit4;
        private double? _ZwischenZeit5;
        private double? _ZwischenZeit6;
        private double? _ZwischenZeit7;

        private string _Total;

        //		string _Datum;
        //		string _Bemerkung;

        [Newtonsoft.Json.JsonIgnore]
        public double Kcal
        {
            get
            {
                //				return 0.0;

                var kcal = 0.0525 * _TotalZeit + 0.125 * (double)this.ARS * this.Gewicht;
                return kcal;
                //				Kcal=0.0525 * m_Total + 0.125 * m_ARS * m_Gewicht;
            }
        }

        [Newtonsoft.Json.JsonIgnore]
        public double Km
        {
            get
            {
                return (Durchschnitt * TotalZeit) / 60.0;
            }
        }

        public string Strecke
        {
            get => _Strecke;
            set => _Strecke = value;
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

        [Newtonsoft.Json.JsonIgnore]
        public double TotalZeit
        {
            get
            {
                return _TotalZeit;
            }
            set
            {
                _TotalZeit = value;
            }
        }

        [Newtonsoft.Json.JsonIgnore]
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

        [Newtonsoft.Json.JsonIgnore]
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

        public double? ZwischenZeit1
        {
            get
            {
                if (_ZwischenZeit1 == 0.0)
                    _ZwischenZeit1 = null;

                return _ZwischenZeit1;
            }
            set => _ZwischenZeit1 = value;
        }

        public double? ZwischenZeit2
        {
            get
            {
                if (_ZwischenZeit2 == 0.0)
                    _ZwischenZeit2 = null;

                return _ZwischenZeit2;
            }
            set => _ZwischenZeit2 = value;
        }

        public double? ZwischenZeit3
        {
            get
            {
                if (_ZwischenZeit3 == 0.0)
                    _ZwischenZeit3 = null;

                return _ZwischenZeit3;
            }
            set => _ZwischenZeit3 = value;
        }

        public double? ZwischenZeit4
        {
            get
            {
                if (_ZwischenZeit4 == 0.0)
                    _ZwischenZeit4 = null;

                return _ZwischenZeit4;
            }
            set => _ZwischenZeit4 = value;
        }

        public double? ZwischenZeit5
        {
            get
            {
                if (_ZwischenZeit5 == 0.0)
                    _ZwischenZeit5 = null;

                return _ZwischenZeit5;
            }
            set => _ZwischenZeit5 = value;
        }

        public double? ZwischenZeit6
        {
            get
            {
                if (_ZwischenZeit6 == 0.0)
                    _ZwischenZeit6 = null;

                return _ZwischenZeit6;
            }
            set => _ZwischenZeit6 = value;
        }

        public double? ZwischenZeit7
        {
            get
            {
                if (_ZwischenZeit7 == 0.0)
                    _ZwischenZeit7 = null;

                return _ZwischenZeit7;
            }
            set
            {
                if (value == 0)
                    value = null;

                _ZwischenZeit7 = value;
            }
        }

        public override double Dauer
        {
            get
            {
                if (base.Dauer == 0.0)
                {
                    if (ZwischenZeit7 != null)
                        return ZwischenZeit7.GetValueOrDefault();

                    if (ZwischenZeit6 != null)
                        return ZwischenZeit6.GetValueOrDefault();
                    if (ZwischenZeit5 != null)
                        return ZwischenZeit5.GetValueOrDefault();
                    if (ZwischenZeit4 != null)
                        return ZwischenZeit4.GetValueOrDefault();
                    if (ZwischenZeit3 != null)
                        return ZwischenZeit3.GetValueOrDefault();
                    if (ZwischenZeit2 != null)
                        return ZwischenZeit2.GetValueOrDefault();
                    if (ZwischenZeit1 != null)
                        return ZwischenZeit1.GetValueOrDefault();
                }

                return base.Dauer;
            }
            set => base.Dauer = value;
        }
    }
}