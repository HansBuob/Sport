using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using twr;
using f = twr.DFunktionen;

namespace Sport
{
    public class Sport
    {
        #region Properties

        public string Pfad { get; set; }
        public string Jahr { get; set; }

        #endregion

        //public Hashtable _htJOStrecken = new Hashtable();

        public List<RVDaten> RvDaten = new List<RVDaten>();
        public List<SDDaten> SdDaten = new List<SDDaten>();
        public List<HeimtrainerDaten> HtDaten = new List<HeimtrainerDaten>();
        public List<JoggenDaten> JoDaten = new List<JoggenDaten>();

        public Sport()
        {
            var reg = new DRegistry();
            this.Jahr = reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "SOFTWARE\\TWR\\Sport", "Datei", "");
        }

        public bool RVBest(string strecke, out double b1, out double w1, out double b2, out double w2
            , out double b3, out double w3
            , out double b4, out double w4
            , out double b5, out double w5
            , out double b6, out double w6
            , out double b7, out double w7)
        {
            var bFound = false;
            b1 = 100; b2 = 100; b3 = 100; b4 = 100; b5 = 100; b6 = 100; b7 = 100;
            w1 = 0; w2 = 0; w3 = 0; w4 = 0; w5 = 0; w6 = 0; w7 = 0;
            for (var i = 0; i < RvDaten.Count; i++)
            {
                var rv = RvDaten[i];
                if (rv.Strecke.ToLower() == strecke.ToLower())
                {
                    bFound = true;
                    if (rv.ZwischenZeit1 < b1)
                        b1 = rv.ZwischenZeit1.GetValueOrDefault();
                    if (rv.ZwischenZeit1 > w1)
                        w1 = rv.ZwischenZeit1.GetValueOrDefault();

                    if ((rv.ZwischenZeit2 - rv.ZwischenZeit1) < b2)
                        b2 = rv.ZwischenZeit2.GetValueOrDefault() - rv.ZwischenZeit1.GetValueOrDefault();
                    if ((rv.ZwischenZeit2 - rv.ZwischenZeit1) > w2)
                        w2 = rv.ZwischenZeit2.GetValueOrDefault() - rv.ZwischenZeit1.GetValueOrDefault();

                    if ((rv.ZwischenZeit3 - rv.ZwischenZeit2) < b3)
                        b3 = rv.ZwischenZeit3.GetValueOrDefault() - rv.ZwischenZeit2.GetValueOrDefault();
                    if ((rv.ZwischenZeit3 - rv.ZwischenZeit2) > w3)
                        w3 = rv.ZwischenZeit3.GetValueOrDefault() - rv.ZwischenZeit2.GetValueOrDefault();

                    if ((rv.ZwischenZeit4 - rv.ZwischenZeit3) < b4)
                        b4 = rv.ZwischenZeit4.GetValueOrDefault() - rv.ZwischenZeit3.GetValueOrDefault();
                    if ((rv.ZwischenZeit4 - rv.ZwischenZeit3) > w4)
                        w4 = rv.ZwischenZeit4.GetValueOrDefault() - rv.ZwischenZeit3.GetValueOrDefault();

                    if ((rv.ZwischenZeit5 - rv.ZwischenZeit4) < b5)
                        b5 = rv.ZwischenZeit5.GetValueOrDefault() - rv.ZwischenZeit4.GetValueOrDefault();
                    if ((rv.ZwischenZeit5 - rv.ZwischenZeit4) > w5)
                        w5 = rv.ZwischenZeit5.GetValueOrDefault() - rv.ZwischenZeit4.GetValueOrDefault();

                    if ((rv.ZwischenZeit6 - rv.ZwischenZeit5) < b6)
                        b6 = rv.ZwischenZeit6.GetValueOrDefault() - rv.ZwischenZeit5.GetValueOrDefault();
                    if ((rv.ZwischenZeit6 - rv.ZwischenZeit5) > w6)
                        w6 = rv.ZwischenZeit6.GetValueOrDefault() - rv.ZwischenZeit5.GetValueOrDefault();

                    if ((rv.ZwischenZeit7.GetValueOrDefault() - rv.ZwischenZeit6) < b7)
                        b7 = rv.ZwischenZeit7.GetValueOrDefault() - rv.ZwischenZeit6.GetValueOrDefault();
                    if ((rv.ZwischenZeit7 - rv.ZwischenZeit6) > w7)
                        w7 = rv.ZwischenZeit7.GetValueOrDefault() - rv.ZwischenZeit6.GetValueOrDefault();
                }
            }

            return bFound;
        }

        public SDDaten SDInfo(string strecke)
        {
            strecke = strecke.Trim().ToUpper();
            for (var i = 0; i < SdDaten.Count; i++)
            {
                var sd = SdDaten[i];
                if (sd.Strecke == strecke)
                    return sd;
            }
            return null;
        }

        public void SaveData(string typ)
        {
            var ecpwin = System.Text.Encoding.GetEncoding(1252);

            //RVDaten
            if (typ == "RV")
            {
                f.DoSichKopie(this.Pfad + this.Jahr + "\\", "*.csv");
                var pfad = this.Pfad + this.Jahr + "\\" + "RV-" + this.Jahr + ".csv";
                var sr = new StreamWriter(File.OpenWrite(pfad), ecpwin);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                for (var i = 0; i < RvDaten.Count; i++)
                {
                    var rv = RvDaten[i];
                    rv.Serialize(sr);
                }
                sr.Close();
            }
            if (typ == "HT")
            {
                f.DoSichKopie(this.Pfad + this.Jahr + "\\", "*.csv");
                var pfad = this.Pfad + this.Jahr + "\\" + "HT-" + this.Jahr + ".csv";
                var sr = new StreamWriter(File.OpenWrite(pfad), ecpwin);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                for (var i = 0; i < this.HtDaten.Count; i++)
                {
                    var rv = HtDaten[i];
                    rv.Serialize(sr);
                }
                sr.Close();
            }
            if (typ == "JO")
            {
                //_htJOStrecken = new Hashtable();

                f.DoSichKopie(this.Pfad + this.Jahr + "\\", "*.csv");
                var pfad = this.Pfad + this.Jahr + "\\" + "JO-" + this.Jahr + ".csv";
                var sr = new StreamWriter(File.OpenWrite(pfad), ecpwin);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                sr.WriteLine("Datum,Gewicht,Strecke,,L1,W1,L2,W2,L3,W3,L4,W4,L5,W5,L6,W6,L7,Bemerkung,");

                long version = 1;
                for (var i = 0; i < this.JoDaten.Count; i++)
                {
                    var jo = JoDaten[i];
                    jo.Serialize(sr, ref version);
                }
                sr.Close();
            }
        }

        public void Load(bool useJsonFileFormat = false)
        {
            var ecpwin = System.Text.Encoding.GetEncoding(1252);

            //RVDaten
            var pfad = this.Pfad + this.Jahr + "\\RV-" + this.Jahr + ".csv";
            RvDaten.Clear();
            if (File.Exists(pfad))
            {
                var sr = new StreamReader(File.OpenRead(pfad), ecpwin);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                for (; ; )
                {
                    var rv = new RVDaten();
                    if (!rv.Serialize(sr))
                        break;
                    RvDaten.Add(rv);
                }
                sr.Close();
            }

            pfad = this.Pfad + this.Jahr + "\\SD.csv";
            if (!File.Exists(pfad))
                pfad = this.Pfad + this.Jahr + "\\SD-" + this.Jahr + ".csv";

            SdDaten.Clear();
            if (File.Exists(pfad))
            {
                var sr = new StreamReader(File.OpenRead(pfad), ecpwin);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                for (; ; )
                {
                    var sd = new SDDaten();
                    if (!sd.Serialize(sr))
                        break;
                    SdDaten.Add(sd);
                }
                sr.Close();
            }

            //HeimtrainerDaten
            pfad = this.Pfad + this.Jahr + "\\HT-" + this.Jahr + ".csv";
            HtDaten.Clear();
            if (File.Exists(pfad))
            {
                var sr = new StreamReader(File.OpenRead(pfad), ecpwin);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                for (; ; )
                {
                    var htd = new HeimtrainerDaten();
                    if (!htd.Serialize(sr))
                        break;
                    HtDaten.Add(htd);
                }
                sr.Close();
            }

            //JoggenDaten
            pfad = this.Pfad + this.Jahr + "\\JO-" + this.Jahr + ".csv";
            JoDaten.Clear();
            if (File.Exists(pfad))
            {
                var sr = new StreamReader(File.OpenRead(pfad), ecpwin);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                long version = 1;
                for (; ; )
                {
                    var htd = new JoggenDaten();
                    if (!htd.Serialize(sr, ref version))
                        break;

                    var tmp = htd.Strecke.ToLower().Trim();
                    JoDaten.Add(htd);
                }
                sr.Close();
            }

            #region Load jo.xml, and save jo.json

            var jo_xml = this.Pfad + this.Jahr + "\\JO-" + this.Jahr + ".xml";
            if (!File.Exists(jo_xml))
                jo_xml = this.Pfad + this.Jahr + "\\JO.xml";

            var jsonJoFile = jo_xml.Replace(".xml", ".json");
            if (useJsonFileFormat && File.Exists(jsonJoFile))
            {
                var fileContent = File.ReadAllText(jsonJoFile, Encoding.UTF8);
                this.JoDaten = JsonConvert.DeserializeObject<List<JoggenDaten>>(fileContent);
            }
            else if (File.Exists(jo_xml))
            {
                var settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Fragment;
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                var reader = XmlReader.Create(jo_xml, settings);

                var node = FindRoot(reader);
                Serialize(node, "JO");
                reader.Close();

                var jsonString = JsonConvert.SerializeObject(this.JoDaten, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonJoFile, jsonString, Encoding.UTF8);
            }

            #endregion

            #region Load ht.xml, and save ht.json

            var ht_xml = this.Pfad + this.Jahr + "\\HT-" + this.Jahr + ".xml";
            if (!File.Exists(ht_xml))
                ht_xml = this.Pfad + this.Jahr + "\\HT.xml";

            var jsonHtFile = ht_xml.Replace(".xml", ".json");
            if (useJsonFileFormat && File.Exists(jsonHtFile))
            {
                var fileContent = File.ReadAllText(jsonHtFile, Encoding.UTF8);
                this.HtDaten = JsonConvert.DeserializeObject<List<HeimtrainerDaten>>(fileContent);
            }
            else if (File.Exists(ht_xml))
            {
                var settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Fragment;
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                var reader = XmlReader.Create(ht_xml, settings);

                var node = FindRoot(reader);
                Serialize(node, "HT");
                reader.Close();

                var jsonString = JsonConvert.SerializeObject(this.HtDaten, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonHtFile, jsonString, Encoding.UTF8);
            }

            #endregion

            #region Load rv.xml and save rv.json

            var rv_xml = this.Pfad + this.Jahr + "\\RV-" + this.Jahr + ".xml";
            if (!File.Exists(rv_xml))
                rv_xml = this.Pfad + this.Jahr + "\\RV.xml";

            var jsonRvFile = rv_xml.Replace(".xml", ".json");
            if (useJsonFileFormat && File.Exists(jsonRvFile))
            {
                var fileContent = File.ReadAllText(jsonRvFile, Encoding.UTF8);
                this.RvDaten = JsonConvert.DeserializeObject<List<RVDaten>>(fileContent);
            }
            else if (File.Exists(rv_xml))
            {
                var settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Fragment;
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                var reader = XmlReader.Create(rv_xml, settings);

                var node = FindRoot(reader);
                Serialize(node, "RV");
                reader.Close();

                var jsonString = JsonConvert.SerializeObject(this.RvDaten, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(jsonRvFile, jsonString, Encoding.UTF8);
            }

            #endregion
        }

        public XmlNode FindRoot(XmlReader reader)
        {
            var doc = new XmlDocument();
            doc.Load(reader);
            var nav = doc.CreateNavigator();
            var node = ((IHasXmlNode)nav).GetNode();

            node = node.FirstChild;
            for (; ; )
            {
                if (node == null)
                    break;
                if (node.LocalName == "root")
                    break;
                node = node.NextSibling;
            }
            return node;
        }

        private void Serialize(XmlNode node, string typ)
        {
            if (node != null)
            {
                node = node.FirstChild;
                for (; ; )
                {
                    if (node == null)
                        break;
                    if (node.LocalName.ToUpper() == "DATA")
                    {
                        if (typ == "JO")
                        {
                            var data = new JoggenDaten();
                            if (data.Serialize(node.FirstChild))
                                this.JoDaten.Add(data);
                        }
                        if (typ == "HT")
                        {
                            var data = new HeimtrainerDaten();
                            if (data.Serialize(node.FirstChild))
                                this.HtDaten.Add(data);
                        }
                        if (typ == "RV")
                        {
                            var data = new RVDaten();
                            if (data.Serialize(node.FirstChild))
                                this.RvDaten.Add(data);
                        }
                    }
                    node = node.NextSibling;
                }
            }
        }
    }
}