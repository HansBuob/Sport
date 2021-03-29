using System;

namespace Sport
{
    public class SportDaten
    {
        private string _Datum = "";

        public void SetDatum(string datum)
        {
            var entries = datum.Split('.');
            var dd = entries[0];
            var mm = entries[1];
            var yyyy = entries[2];
            _Datum = $"{yyyy:D4}{mm:D2}{dd:D2}";

            this.Datum = new DateTime(int.Parse(yyyy), int.Parse(mm), int.Parse(dd));
        }

        [Obsolete]
        public string StringDatum
        {
            get
            {
                return _Datum;
            }
            set
            {
                //02.01.2003
                if (value.Length == 8)
                {
                    _Datum = value;
                }
                else
                {
                    var entries = value.Split('.');
                    var dd = entries[0];
                    var mm = entries[1];
                    var yyyy = entries[2];

                    _Datum = $"{yyyy:D4}{mm:D2}{dd:D2}";

                    this.Datum = new DateTime(int.Parse(yyyy), int.Parse(mm), int.Parse(dd));
                }
            }
        }

        public DateTime Datum { get; set; }

        public virtual string Dauer { get; set; }

        public double Gewicht { get; set; }

        public string Bemerkung { get; set; }

        public double Peace { get; set; }

        public string Link { get; set; }
    }
}