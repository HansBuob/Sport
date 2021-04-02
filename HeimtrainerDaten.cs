using System;
using System.IO;
using System.Xml;
using twr.common;
using f = twr.DFunktionen;

namespace Sport
{
    public class HeimtrainerDaten : SportDaten
    {
        #region Properties

        public double Belastung { get; set; }
        public double Distanz { get; set; }
        public double KJoul { get; set; }

        #endregion

        public override string ToString()
        {
            return $"{this.Datum:yyyyMMdd} - {this.Belastung}";
        }

        public bool Serialize(XmlNode dataNode)
        {
            for (; ; )
            {
                if (dataNode == null)
                    break;
                if (dataNode.LocalName.ToLower() == "Datum".ToLower())
                    Datum = dataNode.InnerXml.ToDateTime() ?? DateTime.MinValue;
                else if (dataNode.LocalName.ToLower() == "Belastung".ToLower())
                    this.Belastung = dataNode.InnerXml.ToDouble();
                else if (dataNode.LocalName.ToLower() == "Dauer".ToLower())
                    Dauer = dataNode.InnerXml.ToDouble();
                else if (dataNode.LocalName.ToLower() == "Distanz".ToLower())
                    this.Distanz = dataNode.InnerXml.ToDouble();
                else if (dataNode.LocalName.ToLower() == "KJoul".ToLower())
                    this.KJoul = dataNode.InnerXml.ToDouble();
                else if (dataNode.LocalName.ToLower() == "Gewicht".ToLower())
                    this.Gewicht = dataNode.InnerXml.ToDouble();//f.ConvertToDouble(dataNode.InnerXml);
                else
                {
                    System.Diagnostics.Debug.Assert(false);
                    return false;
                }

                dataNode = dataNode.NextSibling;
            }
            return true;
        }

        public bool Serialize(object stream)
        {
            if (stream is StreamReader streamReader)
            {
                var sr = streamReader;
                var data = "";
            again:
                data = sr.ReadLine();
                if (data == null)
                    return false;
                if (data == "")
                    goto again;
                //					return true;

                var str = data + ",";
                str += ",,,,,,,";
                this.Datum = f.HeadFromList(ref str, ",").ToDateTime() ?? DateTime.MinValue;
                this.Gewicht = f.HeadFromList(ref str, ",").ToDouble();
                this.Belastung = f.HeadFromList(ref str, ",").ToDouble();
                Dauer = f.HeadFromList(ref str, ",").ToDouble();
                //_PulsschlagVor =
                f.HeadFromList(ref str, ",");
                //_PulsschlagNach =
                f.HeadFromList(ref str, ",");
                f.HeadFromList(ref str, ",");
                this.Distanz = f.HeadFromList(ref str, ",").ToDouble();
                f.HeadFromList(ref str, ",");
                this.KJoul = f.HeadFromList(ref str, ",").ToDouble();

                /*
                                _Rundfahrt=f.HeadFromList(ref str,",");
                                _Eingabekuerzel=f.HeadFromList(ref str,",");
                                _Anzeige=f.ConvertToInt(f.HeadFromList(ref str,","));
                                _ZwischenOrt1=f.HeadFromList(ref str,",");
                                _ZwischenOrt2=f.HeadFromList(ref str,",");
                                _ZwischenOrt3=f.HeadFromList(ref str,",");
                                _ZwischenOrt4=f.HeadFromList(ref str,",");
                                _ZwischenOrt5=f.HeadFromList(ref str,",");
                                _ZwischenOrt6=f.HeadFromList(ref str,",");
                                _ZwischenOrt7=f.HeadFromList(ref str,",");

                                str=sr.ReadLine();
                                if(str==null)
                                    return false;

                                //			ar.ReadString(str);
                                str+=",,,,,,,";
                                f.HeadFromList(ref str,",");
                                f.HeadFromList(ref str,",");
                                f.HeadFromList(ref str,",");
                                _ZwischenDistanz1=f.HeadFromList(ref str,",");
                                _ZwischenDistanz2=f.HeadFromList(ref str,",");
                                _ZwischenDistanz3=f.HeadFromList(ref str,",");
                                _ZwischenDistanz4=f.HeadFromList(ref str,",");
                                _ZwischenDistanz5=f.HeadFromList(ref str,",");
                                _ZwischenDistanz6=f.HeadFromList(ref str,",");
                                _ZwischenDistanz7=f.HeadFromList(ref str,",");
                */
                return true;
            }

            if (stream is StreamWriter streamWriter)
            {
                var sw = streamWriter;

                var line = Datum.ToString("yyyyMMdd") + ",";
                line += Gewicht + ",";
                line += this.Belastung + ",";
                line += Dauer + ",";
                line += ",";
                line += ",";
                line += ",";
                line += this.Distanz + ",";
                line += ",";
                line += this.KJoul + ",";

                //				this.Datum=f.HeadFromList(ref str,",");
                //				this.Gewicht=f.HeadFromList(ref str,",");
                //				_Belastung=f.HeadFromList(ref str,",");
                //				Zeit=f.HeadFromList(ref str,",");
                //				_PulsschlagVor=f.HeadFromList(ref str,",");
                //				_PulsschlagNach=f.HeadFromList(ref str,",");
                //				f.HeadFromList(ref str,",");
                //				_Distanz=f.HeadFromList(ref str,",");
                //				f.HeadFromList(ref str,",");
                //				_KJoul=f.HeadFromList(ref str,",");

                sw.WriteLine(line);

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
    }
}