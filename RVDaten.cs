using System.Globalization;
using System.IO;
using System.Xml;
using twr.common;
using f = twr.DFunktionen;

namespace Sport
{
    public class RVDaten : SportDaten
    {
        public RVDaten()
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
                    Durchschnitt = dataNode.InnerXml.ToDouble();
                else if (dataNode.LocalName.ToLower() == "mxs")
                    Hoechst = dataNode.InnerXml.ToDouble();
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
            this.Total = 0.0;//Durchschnitt auf bestimmte Strecke
            _zwischenZeit1 = zeit1.ToDouble();
            _zwischenZeit2 = zeit2.ToDouble();
            _zwischenZeit3 = zeit3.ToDouble();
            _zwischenZeit4 = zeit4.ToDouble();
            _zwischenZeit5 = zeit5.ToDouble();
            _zwischenZeit6 = zeit6.ToDouble();
            _zwischenZeit7 = zeit7.ToDouble();

            TotalZeit = _zwischenZeit7.GetValueOrDefault();
            if (TotalZeit == 0)
                TotalZeit = _zwischenZeit6.GetValueOrDefault();
            if (TotalZeit == 0)
                TotalZeit = _zwischenZeit5.GetValueOrDefault();
            if (TotalZeit == 0)
                TotalZeit = _zwischenZeit4.GetValueOrDefault();
            if (TotalZeit == 0)
                TotalZeit = _zwischenZeit3.GetValueOrDefault();
            if (TotalZeit == 0)
                TotalZeit = _zwischenZeit2.GetValueOrDefault();
            if (TotalZeit == 0)
                TotalZeit = _zwischenZeit1.GetValueOrDefault();

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

                _abcStrecke = f.ConvertToInt(f.HeadFromList(ref str, ","));
                Strecke = f.HeadFromList(ref str, ",");
                Durchschnitt = f.HeadFromList(ref str, ",").ToDouble();
                this.Hoechst = f.HeadFromList(ref str, ",").ToDouble();
                this.Gewicht = f.HeadFromList(ref str, ",").ToDouble();
                this.TotalZeit = f.HeadFromList(ref str, ",").ToDouble();
                _ars = f.ConvertToInt(f.HeadFromList(ref str, ","));
                this.ZwischenZeit1 = f.HeadFromList(ref str, ",").ToDouble();
                this.ZwischenZeit2 = f.HeadFromList(ref str, ",").ToDouble();
                this.ZwischenZeit3 = f.HeadFromList(ref str, ",").ToDouble();

                this.ZwischenZeit4 = f.HeadFromList(ref str, ",").ToDouble();
                this.ZwischenZeit5 = f.HeadFromList(ref str, ",").ToDouble();
                this.ZwischenZeit6 = f.HeadFromList(ref str, ",").ToDouble();
                this.ZwischenZeit7 = f.HeadFromList(ref str, ",").ToDouble();
                this.Total = f.HeadFromList(ref str, ",").ToDouble();
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
                data = _abcStrecke + ",";
                data += this.Strecke + ",";
                data += this.Durchschnitt.ToString(CultureInfo.InvariantCulture) + ",";
                data += this.Hoechst.ToString(CultureInfo.InvariantCulture) + ",";
                data += this.Gewicht.ToString(CultureInfo.InvariantCulture) + ",";
                data += this.TotalZeit.ToString(CultureInfo.InvariantCulture) + ",";
                data += _ars.ToString() + ",";
                data += this.ZwischenZeit1 + ",";
                data += this.ZwischenZeit2 + ",";
                data += this.ZwischenZeit3 + ",";

                data += this.ZwischenZeit4 + ",";
                data += this.ZwischenZeit5 + ",";
                data += this.ZwischenZeit6 + ",";
                data += this.ZwischenZeit7 + ",";
                data += this.Total + ",";
                data += this.Datum.ToString("yyyyMMdd") + ",";
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

        private int _abcStrecke;

        //		string _Gewicht;

        private long _ars;
        private double? _zwischenZeit1;
        private double? _zwischenZeit2;
        private double? _zwischenZeit3;
        private double? _zwischenZeit4;
        private double? _zwischenZeit5;
        private double? _zwischenZeit6;
        private double? _zwischenZeit7;

        //		string _Datum;
        //		string _Bemerkung;

        [Newtonsoft.Json.JsonIgnore]
        public double Kcal
        {
            get
            {
                //				return 0.0;

                var kcal = 0.0525 * TotalZeit + 0.125 * this.ARS * this.Gewicht;
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

        public string Strecke { get; set; }

        public double Durchschnitt { get; set; }

        public double Hoechst { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public double TotalZeit { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public long ARS
        {
            get
            {
                if (_ars != 0.0)
                    return _ars;

                var ars = 0.00133 * this.Durchschnitt;
                ars = this.TotalZeit * this.Durchschnitt * ars;
                _ars = (long)ars;
                return _ars;
            }
            //set
            //{
            //    _ARS=value;
            //}
        }

        [Newtonsoft.Json.JsonIgnore]
        public double Total { get; set; }

        public double? ZwischenZeit1
        {
            get
            {
                if (_zwischenZeit1 == 0.0)
                    _zwischenZeit1 = null;

                return _zwischenZeit1;
            }
            set => _zwischenZeit1 = value;
        }

        public double? ZwischenZeit2
        {
            get
            {
                if (_zwischenZeit2 == 0.0)
                    _zwischenZeit2 = null;

                return _zwischenZeit2;
            }
            set => _zwischenZeit2 = value;
        }

        public double? ZwischenZeit3
        {
            get
            {
                if (_zwischenZeit3 == 0.0)
                    _zwischenZeit3 = null;

                return _zwischenZeit3;
            }
            set => _zwischenZeit3 = value;
        }

        public double? ZwischenZeit4
        {
            get
            {
                if (_zwischenZeit4 == 0.0)
                    _zwischenZeit4 = null;

                return _zwischenZeit4;
            }
            set => _zwischenZeit4 = value;
        }

        public double? ZwischenZeit5
        {
            get
            {
                if (_zwischenZeit5 == 0.0)
                    _zwischenZeit5 = null;

                return _zwischenZeit5;
            }
            set => _zwischenZeit5 = value;
        }

        public double? ZwischenZeit6
        {
            get
            {
                if (_zwischenZeit6 == 0.0)
                    _zwischenZeit6 = null;

                return _zwischenZeit6;
            }
            set => _zwischenZeit6 = value;
        }

        public double? ZwischenZeit7
        {
            get
            {
                if (_zwischenZeit7 == 0.0)
                    _zwischenZeit7 = null;

                return _zwischenZeit7;
            }
            set
            {
                if (value == 0)
                    value = null;

                _zwischenZeit7 = value;
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