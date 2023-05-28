using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sport.Common;

namespace Sport.Form
{
    public partial class frmProtokollHomeTrainer : System.Windows.Forms.Form
    {
        public frmProtokollHomeTrainer()
        {
            InitializeComponent();
        }

        private DataTable _DataTable;

        private void frmProtokollHomeTrainer_Load(object sender, EventArgs e)
        {
            this.Text = "Heimtrainer-Info";
            this.Text += " (" + Settings.Jahr + ")";

            _DataTable = new DataTable("DI");
            dataGrid.TableStyles[0].MappingName = "DI";
            dataGrid.TableStyles[0].AlternatingBackColor = dataGrid.AlternatingBackColor;
            dataGrid.TableStyles[0].BackColor = dataGrid.BackColor;
            dataGrid.TableStyles[0].ForeColor = dataGrid.ForeColor;
            dataGrid.TableStyles[0].GridLineColor = dataGrid.GridLineColor;
            dataGrid.TableStyles[0].HeaderBackColor = dataGrid.HeaderBackColor;
            dataGrid.TableStyles[0].HeaderForeColor = dataGrid.HeaderForeColor;
            dataGrid.TableStyles[0].LinkColor = dataGrid.LinkColor;
            dataGrid.TableStyles[0].SelectionBackColor = dataGrid.SelectionBackColor;
            dataGrid.TableStyles[0].SelectionForeColor = dataGrid.SelectionForeColor;
            dataGrid.DataSource = _DataTable;

            var heimtrainerDaten = frmMain.SportInstance.HtDaten;

            var columnDatum = dataGridTableStyle.AddColumn("Datum");
            var columnBelastung = dataGridTableStyle.AddColumn("Belastung", horizontalAlignment: HorizontalAlignment.Right);
            var columnZeit = dataGridTableStyle.AddColumn("Zeit", horizontalAlignment: HorizontalAlignment.Right);

            //var columnPuschschlag = dataGridTableStyle.AddColumn("Puschschlag");
            var columnDistanz = dataGridTableStyle.AddColumn("Distanz", horizontalAlignment: HorizontalAlignment.Right);
            var columnDGeschw = dataGridTableStyle.AddColumn("D-Geschw", horizontalAlignment: HorizontalAlignment.Right);
            var columnKJoul = dataGridTableStyle.AddColumn("KJoul", horizontalAlignment: HorizontalAlignment.Right);
            var columnKcal = dataGridTableStyle.AddColumn("Kcal", horizontalAlignment: HorizontalAlignment.Right);
            var columnGewicht = dataGridTableStyle.AddColumn("Gewicht", horizontalAlignment: HorizontalAlignment.Right);


            foreach (var data in heimtrainerDaten)
            {

                var newRow = _DataTable.NewRow();
                _DataTable.Rows.Add(newRow);

                newRow[columnDatum] = data.Datum.ToString("yyyy.MM.dd");//"dd.MM.yyyy"
                newRow[columnBelastung] = data.Belastung;
                newRow[columnZeit] = data.Dauer.ToString("F2");

                //newRow[columnPuschschlag] = data..ToString("F2");

                newRow[columnDistanz] = data.Distanz.ToString("F2");
                newRow[columnDGeschw] = (60 * data.Distanz / data.Dauer).ToString("F1");
                newRow[columnKJoul] = data.KJoul.ToString("F0");
                newRow[columnKcal] = (data.KJoul / 4.186).ToString("F0");


                //newRow[columnPosition1] = data.Position1.ToString("F2") + " / " + (data.Position2 - data.Position1).ToString("F2");
                //newRow[columnPosition2] = data.Position2.ToString("F2");
                //newRow[columnPosition3] = data.Position3.ToString("F2");
                //newRow[columnPosition4] = data.Position4.ToString("F2");
                //newRow[columnPosition5] = data.Position5.ToString("F2");
                //newRow[columnPosition6] = data.Position6.ToString("F2");
                newRow[columnGewicht] = data.Gewicht.ToString("F1");
                //newRow[columnStrecke] = data.Strecke;
                //newRow[columnBemerkung] = data.Bemerkung;

            }


            ////			SetColor(1,0,100, Color.FromArgb(255,180,80));
            //SetTitel(" Datum       Belastung  Zeit   Pulsschlag Distanz D-Geschw.  KJoul  Kcal  Gewicht");
            ////			SetData(1,0, "Datum      Belastung  Zeit   Puschschlag vor/nach Distanz   KJoul      Kcal   Gewicht");

            //var tZeit = 0.0;
            //var tKJoul = 0.0;
            //var tKm = 0.0;
            //for (var i = 0; i < _rv.HtDaten.Count; i++)
            //{
            //    var heimtrainerDaten = _rv.HtDaten[i];

            //    var datum = heimtrainerDaten.StringDatum.Substring(6, 2) + "." + heimtrainerDaten.StringDatum.Substring(4, 2) + "." + heimtrainerDaten.StringDatum.Substring(0, 4);
            //    SetData(1, i, datum);//"Monat            Km     Std     Km/h     mal      ");
            //    SetData(16, i, heimtrainerDaten.Belastung, 1);
            //    SetData(25, i, heimtrainerDaten.Dauer, 2);
            //    //if(ht.PulsschlagVor!=0.0)
            //    //{
            //    //    SetData(34, i, ht.PulsschlagVor,0);
            //    //    SetData(34, i, "/");
            //    //    SetData(38, i, ht.PulsschlagNach,0);
            //    //}
            //    SetData(44, i, heimtrainerDaten.Distanz, 1);
            //    SetData(52, i, 60 * heimtrainerDaten.Distanz / heimtrainerDaten.Dauer, 2);
            //    SetData(65, i, heimtrainerDaten.KJoul, 0);
            //    SetData(71, i, heimtrainerDaten.KJoul / 4.186, 0);
            //    SetData(78, i, heimtrainerDaten.Gewicht, 1);

            //    tZeit += heimtrainerDaten.Dauer;
            //    tKm += heimtrainerDaten.Distanz;
            //    tKJoul += heimtrainerDaten.KJoul;
            //}

            //var y = _rv.HtDaten.Count + 2;
            //SetData(1, y, _rv.HtDaten.Count.ToString());
            //SetData(25, y, tZeit / 60, 2);
            //SetData(29, y, "Std");
            //SetData(44, y, tKm, 1);
            //SetData(47, y, "Km");
            ////SetData(65, y, tKJoul/4.186,2);
            //SetData(68, y, tKJoul / 4.186 / 900 / 10, 2);
            //SetData(72, y, "Kg");
        }
    }
}
