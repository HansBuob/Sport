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
    public partial class frmProtokollJoggen : System.Windows.Forms.Form
    {
        public frmProtokollJoggen()
        {
            InitializeComponent();
        }

        private DataTable _DataTable;

        private void frmProtokollJoggen_Load(object sender, EventArgs e)
        {
            this.Text = "Joggen-Info";
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

            var joggenData= frmMain.SportInstance.JoDaten;

            var columnDatum = dataGridTableStyle.AddColumn("Datum");
            var columnZeit = dataGridTableStyle.AddColumn("Zeit", horizontalAlignment: HorizontalAlignment.Right);
            var columnPosition1 = dataGridTableStyle.AddColumn("Position-1");

            var columnPosition2 = dataGridTableStyle.AddColumn("Position-2");
            var columnPosition3 = dataGridTableStyle.AddColumn("Position-3");
            var columnPosition4 = dataGridTableStyle.AddColumn("Position-4");
            var columnPosition5 = dataGridTableStyle.AddColumn("Position-5");
            var columnPosition6 = dataGridTableStyle.AddColumn("Position-6");

            var columnGewicht = dataGridTableStyle.AddColumn("Gewicht", horizontalAlignment: HorizontalAlignment.Right);
            var columnStrecke = dataGridTableStyle.AddColumn("Strecke", 200);
            var columnBemerkung = dataGridTableStyle.AddColumn("Bemerkung", 500);


            foreach (var data in joggenData)
            {

                var newRow = _DataTable.NewRow();
                _DataTable.Rows.Add(newRow);

                newRow[columnDatum] = data.Datum.ToString("yyyy.MM.dd");//"dd.MM.yyyy"
                newRow[columnZeit] = data.Dauer.ToString("F2");
                newRow[columnPosition1] = data.Position1.ToString("F2")+ " / " + (data.Position2- data.Position1).ToString("F2");
                newRow[columnPosition2] = data.Position2.ToString("F2");
                newRow[columnPosition3] = data.Position3.ToString("F2");
                newRow[columnPosition4] = data.Position4.ToString("F2");
                newRow[columnPosition5] = data.Position5.ToString("F2");
                newRow[columnPosition6] = data.Position6.ToString("F2");
                newRow[columnGewicht] = data.Gewicht.ToString("F1");
                newRow[columnStrecke] = data.Strecke;
                newRow[columnBemerkung] = data.Bemerkung;

            }

        }
    }
}
