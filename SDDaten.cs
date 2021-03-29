using System.IO;
using f = twr.DFunktionen;

namespace Sport
{
    public class SDDaten
    {
        public SDDaten()
        {
        }

        //	public SDDaten(string Strecke){}

        public bool Serialize(object stream)
        {
            if (stream is StreamReader)
            {
                var sr = (StreamReader)stream;
                var data = sr.ReadLine();
                if (data == null)
                    return false;

                var str = data + ",";

                str += ",,,,,,,";

                _Rundfahrt = f.HeadFromList(ref str, ",");
                _Eingabekuerzel = f.HeadFromList(ref str, ",");
                _Anzeige = f.ConvertToInt(f.HeadFromList(ref str, ","));
                _ZwischenOrt1 = f.HeadFromList(ref str, ",");
                _ZwischenOrt2 = f.HeadFromList(ref str, ",");
                _ZwischenOrt3 = f.HeadFromList(ref str, ",");
                _ZwischenOrt4 = f.HeadFromList(ref str, ",");
                _ZwischenOrt5 = f.HeadFromList(ref str, ",");
                _ZwischenOrt6 = f.HeadFromList(ref str, ",");
                _ZwischenOrt7 = f.HeadFromList(ref str, ",");

                str = sr.ReadLine();
                if (str == null)
                    return false;

                //			ar.ReadString(str);
                str += ",,,,,,,";
                f.HeadFromList(ref str, ",");
                f.HeadFromList(ref str, ",");
                f.HeadFromList(ref str, ",");
                _ZwischenDistanz1 = f.HeadFromList(ref str, ",");
                _ZwischenDistanz2 = f.HeadFromList(ref str, ",");
                _ZwischenDistanz3 = f.HeadFromList(ref str, ",");
                _ZwischenDistanz4 = f.HeadFromList(ref str, ",");
                _ZwischenDistanz5 = f.HeadFromList(ref str, ",");
                _ZwischenDistanz6 = f.HeadFromList(ref str, ",");
                _ZwischenDistanz7 = f.HeadFromList(ref str, ",");

                return true;
            }
            if (stream is StreamWriter)
            {
                var sw = (StreamWriter)stream;
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

        public long Anzeige
        {
            get
            {
                return _Anzeige;
            }
        }

        public string Rundfahrt
        {
            get
            {
                return _Rundfahrt;
            }
            set
            {
                _Rundfahrt = value;
            }
        }

        public string ZwischenOrt1
        {
            get
            {
                return _ZwischenOrt1;
            }
        }

        public string ZwischenOrt2
        {
            get
            {
                return _ZwischenOrt2;
            }
        }

        public string ZwischenOrt3
        {
            get
            {
                return _ZwischenOrt3;
            }
        }

        public string ZwischenOrt4
        {
            get
            {
                return _ZwischenOrt4;
            }
        }

        public string ZwischenOrt5
        {
            get
            {
                return _ZwischenOrt5;
            }
        }

        public string ZwischenOrt6
        {
            get
            {
                return _ZwischenOrt6;
            }
        }

        public string ZwischenOrt7
        {
            get
            {
                return _ZwischenOrt7;
            }
        }

        public double ZwischenDistanz1
        {
            get
            {
                return f.ConvertToDouble(_ZwischenDistanz1);
            }
        }

        public double ZwischenDistanz2
        {
            get
            {
                return f.ConvertToDouble(_ZwischenDistanz2);
            }
        }

        public double ZwischenDistanz3
        {
            get
            {
                return f.ConvertToDouble(_ZwischenDistanz3);
            }
        }

        public double ZwischenDistanz4
        {
            get
            {
                return f.ConvertToDouble(_ZwischenDistanz4);
            }
        }

        public double ZwischenDistanz5
        {
            get
            {
                return f.ConvertToDouble(_ZwischenDistanz5);
            }
        }

        public double ZwischenDistanz6
        {
            get
            {
                return f.ConvertToDouble(_ZwischenDistanz6);
            }
        }

        public double ZwischenDistanz7
        {
            get
            {
                return f.ConvertToDouble(_ZwischenDistanz7);
            }
        }

        public string Strecke
        {
            get
            {
                return _Eingabekuerzel;
            }
        }

        public double Distanz
        {
            get
            {
                if (f.ConvertToDouble(_ZwischenDistanz7) != 0.0) return f.ConvertToDouble(_ZwischenDistanz7);
                if (f.ConvertToDouble(_ZwischenDistanz6) != 0.0) return f.ConvertToDouble(_ZwischenDistanz6);
                if (f.ConvertToDouble(_ZwischenDistanz5) != 0.0) return f.ConvertToDouble(_ZwischenDistanz5);
                if (f.ConvertToDouble(_ZwischenDistanz4) != 0.0) return f.ConvertToDouble(_ZwischenDistanz4);
                if (f.ConvertToDouble(_ZwischenDistanz3) != 0.0) return f.ConvertToDouble(_ZwischenDistanz3);
                if (f.ConvertToDouble(_ZwischenDistanz2) != 0.0) return f.ConvertToDouble(_ZwischenDistanz2);
                if (f.ConvertToDouble(_ZwischenDistanz1) != 0.0) return f.ConvertToDouble(_ZwischenDistanz1);

                return 0.0;
            }
        }

        private string _Rundfahrt;
        private string _Eingabekuerzel;
        private long _Anzeige;
        private string _ZwischenOrt1;
        private string _ZwischenOrt2;
        private string _ZwischenOrt3;
        private string _ZwischenOrt4;
        private string _ZwischenOrt5;
        private string _ZwischenOrt6;
        private string _ZwischenOrt7;

        private string _ZwischenDistanz1;
        private string _ZwischenDistanz2;
        private string _ZwischenDistanz3;
        private string _ZwischenDistanz4;
        private string _ZwischenDistanz5;
        private string _ZwischenDistanz6;
        private string _ZwischenDistanz7;
    }
}