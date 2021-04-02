using System;

namespace Sport
{
    public class SportDaten
    {
        [Obsolete]
        [Newtonsoft.Json.JsonIgnore]
        public string StringDatum
        {
            get
            {
                return Datum.ToString("yyyyMMdd");
            }
            set
            {
                //02.01.2003
                if (value.Length == 8)//19990101
                {
                    var year = value.Substring(0, 4);
                    var month = value.Substring(4, 2);
                    var day = value.Substring(6, 2);
                    this.Datum = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                }
                else
                {
                    var entries = value.Split('.');
                    var day = entries[0];
                    var month = entries[1];
                    var year = entries[2];

                    //_datum = $"{yyyy:D4}{mm:D2}{dd:D2}";

                    this.Datum = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                }
            }
        }

        public DateTime Datum { get; set; }

        public virtual double Dauer { get; set; }

        public double Gewicht { get; set; }
    }
}