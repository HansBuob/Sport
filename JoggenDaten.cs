using System;
using System.IO;
using System.Xml;
using twr.common;
using f = twr.DFunktionen;

namespace Sport
{
    public class JoggenDaten : SportDaten
    {
        private string _strecke;

        public override double Dauer
        {
            get
            {
                var time = 0.0;
                //time += f.ConvertToDouble(_G1);
                //time += f.ConvertToDouble(_W1);
                //time += f.ConvertToDouble(_G2);
                //time += f.ConvertToDouble(_W2);
                //time += f.ConvertToDouble(_G3);
                //time += f.ConvertToDouble(_W3);
                //time += f.ConvertToDouble(_G4);
                //time += f.ConvertToDouble(_W4);
                //time += f.ConvertToDouble(_G5);
                //time += f.ConvertToDouble(_W5);

                if (time == 0.0)
                    time = Position6;
                if (time == 0.0)
                    time = Position5;
                if (time == 0.0)
                    time = Position4;
                if (time == 0.0)
                    time = Position3;
                if (time == 0.0)
                    time = Position2;
                if (time == 0.0)
                    time = Position1;

                return time;
            }
            set
            {
                base.Dauer = value;
            }
        }

        public string Bemerkung { get; set; }

        public double Peace { get; set; }

        public string Link { get; set; }
        public double Position1 { get; set; }
        public double Position2 { get; set; }
        public double Position3 { get; set; }
        public double Position4 { get; set; }
        public double Position5 { get; set; }
        public double Position6 { get; set; }

        public string Strecke
        {
            get => _strecke;
            set
            {
                _strecke = value;
                _strecke = _strecke.Trim();
                if (_strecke.Length > 0)
                {
                    var tmp = _strecke.Substring(0, 1).ToUpper();
                    _strecke = _strecke.Substring(1);
                    _strecke = tmp + _strecke;
                }
            }
        }

        //public static double GetZwischenZeit(double zeit1, double zeit2)
        //{
        //    if (!TimeSpan.TryParse("00:" + zeit1.ToString("0.00").Replace(".", ":"), out var timeSpan1))
        //        return 0.0;
        //    if (!TimeSpan.TryParse("00:" + zeit2.ToString("0.00").Replace(".", ":"), out var timeSpan2))
        //        return 0.0;

        //    var timeSpan = timeSpan1 - timeSpan2;

        //    double d = timeSpan.Minutes;
        //    d += ((double)timeSpan.Seconds) / 100;

        //    return d;// Math.Abs(timeSpan.TotalMinutes);
        //}

        public bool Serialize(XmlNode dataNode)
        {
            for (; ; )
            {
                if (dataNode == null)
                    break;
                if (dataNode.LocalName.ToLower() == "datum")
                {
                    //this.SetDatum(dataNode.InnerXml);
                    this.StringDatum = dataNode.InnerXml;
                }
                else if (dataNode.LocalName.ToLower() == "strecke")
                    this.Strecke = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "gewicht")
                    this.Gewicht = dataNode.InnerXml.ToDouble();
                else if (dataNode.LocalName.ToLower() == "position1")
                    this.Position1 = f.ConvertToDouble(dataNode.InnerXml);
                else if (dataNode.LocalName.ToLower() == "position2")
                    this.Position2 = f.ConvertToDouble(dataNode.InnerXml);
                else if (dataNode.LocalName.ToLower() == "position3")
                    this.Position3 = f.ConvertToDouble(dataNode.InnerXml);
                else if (dataNode.LocalName.ToLower() == "position4")
                    this.Position4 = f.ConvertToDouble(dataNode.InnerXml);
                else if (dataNode.LocalName.ToLower() == "position5")
                    this.Position5 = f.ConvertToDouble(dataNode.InnerXml);
                else if (dataNode.LocalName.ToLower() == "position6")
                    this.Position6 = f.ConvertToDouble(dataNode.InnerXml);
                else if (dataNode.LocalName.ToLower() == "Bemerkung".ToLower())
                    this.Bemerkung = dataNode.InnerXml;
                else if (dataNode.LocalName.ToLower() == "Peace".ToLower())
                {
                    this.Peace = 0.0;
                    if (double.TryParse(dataNode.InnerXml, out var result))
                        this.Peace = result;
                }
                else if (dataNode.LocalName.ToLower() == "Link".ToLower())
                    this.Link = dataNode.InnerXml;
                else
                {
                    //System.Diagnostics.Debug.Assert(false);
                    //return false;
                }

                dataNode = dataNode.NextSibling;
            }
            return true;
        }

        public bool Serialize(object stream, ref long version)
        {
            var tmp = "";
            if (version < 1)
                version = 1;

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
                if (data.IndexOf("Datum") != -1)
                {
                    version = 2;
                    goto again;
                }

                var str = data + ",";
                str += ",,,,,,,";

                this.StringDatum = f.HeadFromList(ref str, ",");
                this.Gewicht = f.HeadFromList(ref str, ",").ToDouble();
                tmp = f.HeadFromList(ref str, ",");
                Strecke = tmp.Replace("{K}", ",");
                this.Dauer = f.HeadFromList(ref str, ",").ToDouble();
                var G1 = f.HeadFromList(ref str, ",").ToDouble();
                var W1 = f.HeadFromList(ref str, ",").ToDouble();

                var G2 = f.HeadFromList(ref str, ",").ToDouble();
                var W2 = f.HeadFromList(ref str, ",").ToDouble();
                var G3 = f.HeadFromList(ref str, ",").ToDouble();
                var W3 = f.HeadFromList(ref str, ",").ToDouble();
                var G4 = f.HeadFromList(ref str, ",").ToDouble();
                var W4 = f.HeadFromList(ref str, ",").ToDouble();
                var G5 = f.HeadFromList(ref str, ",").ToDouble();
                var W5 = f.HeadFromList(ref str, ",").ToDouble();
                var G6 = f.HeadFromList(ref str, ",").ToDouble();
                var W6 = f.HeadFromList(ref str, ",").ToDouble();
                var G7 = f.HeadFromList(ref str, ",").ToDouble();

                tmp = f.HeadFromList(ref str, ",");
                Bemerkung = tmp.Replace("{K}", ",");

                if (version == 2)
                {
                    //G7 = G7 - W6 - G6;
                    //G6 = G6 - W5 - G5;
                    //G5 = G5 - W4 - G4;
                    //G4 = G4 - W3 - G3;
                    //G3 = G3 - W2 - G2;
                    //G2 = G2 - W1 - G1;

                    if (G7 != 0.0)
                        G7 = G7 - G6;
                    if (G6 != 0.0)
                        G6 = G6 - G5;
                    G5 = G5 - G4;
                    G4 = G4 - G3;
                    G3 = G3 - G2;
                    G2 = G2 - G1;

                    Position1 = G1;
                    Position2 = G2;
                    Position3 = G3;
                    Position4 = G4;
                    Position5 = G5;
                    Position6 = G6;

                    if ((Position2 != 0) && (Position2 < Position1))
                        Position2 += Position1;
                    if ((Position3 != 0) && (Position3 < Position2))
                        Position3 += Position2;
                    if ((Position4 != 0) && (Position4 < Position3))
                        Position4 += Position3;
                    if ((Position5 != 0) && (Position5 < Position4))
                        Position5 += Position4;
                    if ((Position6 != 0) && (Position6 < Position5))
                        Position6 += Position5;

                    //					_LP1=G1;
                    //					_LP2=G2;
                    //					_LP3=G3;
                    //					_LP4=G4;
                    //					_LP5=G5;
                    //					_LP6=G6;
                }

//                var format = @"
//  <Data>
//    <Datum>{0}</Datum>
//    <Strecke>{1}</Strecke>
//    <Gewicht>{2}</Gewicht>
//    <Position1>{3}</Position1>
//    <Position2>{4}</Position2>
//    <Position3>{5}</Position3>
//    <Position4>{6}</Position4>
//    <Position5>{7}</Position5>
//    <Bemerkung>{8}</Bemerkung>
//  </Data>
//";
                //02.01.2011
                //var xml = string.Format(format, this.StringDatum.Substring(6, 2) + "." + this.StringDatum.Substring(4, 2) + "." + this.StringDatum.Substring(0, 4), this.Strecke, this.Gewicht.ToString(),
                //    this.Position1.ToString(),
                //    this.Position2.ToString(),
                //    this.Position3.ToString(),
                //    this.Position4.ToString(),
                //    this.Position5.ToString(),
                //    this.Bemerkung);
                //Console.WriteLine("  " + xml.Trim());
                //<Data>
                //  <Datum>11.06.2011</Datum>
                //  <Strecke>Hergiswil</Strecke>
                //  <Gewicht>81.0</Gewicht>
                //  <Position1>11.20</Position1>
                //  <Position2>21.10</Position2>
                //  <Position3>30.20</Position3>
                //  <Position4>40.57</Position4>
                //  <Position5>0.00</Position5>
                //  <Bemerkung></Bemerkung>
                //</Data>
                return true;
            }
            //if (stream is StreamWriter)
            //{
            //    StreamWriter sw = (StreamWriter)stream;

            //    string line = "";
            //    line = line + this.StringDatum + ",";
            //    line += this.Gewicht + ",";
            //    line += this.Strecke + ",";
            //    line += ",";
            //    line += this.G1.ToString() + ",";
            //    line += this.W1.ToString() + ",";
            //    line += this.G2.ToString() + ",";
            //    line += this.W2.ToString() + ",";
            //    line += this.G3.ToString() + ",";
            //    line += this.W3.ToString() + ",";
            //    line += this.G4.ToString() + ",";
            //    line += this.W4.ToString() + ",";
            //    line += this.G5.ToString() + ",";
            //    line += this.W5.ToString() + ",";
            //    line += this.G6.ToString() + ",";
            //    line += this.W6.ToString() + ",";
            //    line += this.G7.ToString() + ",";
            //    //				line+=this.W7.ToString() + ",";
            //    //				line+=this.G8.ToString() + ",";
            //    //				line+=this.W8.ToString() + ",";
            //    //				line+=this.G9.ToString() + ",";
            //    //				line+=this.W10.ToString() + ",";
            //    //				line+=this.G10.ToString() + ",";
            //    //				line+=this.W9.ToString() + ",,,,,,,,,,,";
            //    tmp = Bemerkung.Replace(",", "{K}");
            //    line += tmp + ",";
            //    sw.WriteLine(line);

            //    return true;
            //}

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
    }
}