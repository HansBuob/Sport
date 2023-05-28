using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using twr;
using Sport.Common;

namespace Sport
{
    /// <summary>
    /// Summary description for frmProtokoll.
    /// </summary>
    public class frmProtokollRennvelo : frmForm//: System.Windows.Forms.Form
    {
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn18;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn20;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmProtokollRennvelo()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGrid.CaptionVisible = false;
            this.dataGrid.DataMember = "";
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(1347, 461);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle});
            // 
            // dataGridTableStyle
            // 
            this.dataGridTableStyle.DataGrid = this.dataGrid;
            this.dataGridTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle.PreferredColumnWidth = 150;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.Width = -1;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.Width = -1;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.Width = -1;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.Width = -1;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.Width = -1;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.Width = -1;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.Width = -1;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.Width = -1;
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.Width = -1;
            // 
            // dataGridTextBoxColumn11
            // 
            this.dataGridTextBoxColumn11.Format = "";
            this.dataGridTextBoxColumn11.FormatInfo = null;
            this.dataGridTextBoxColumn11.Width = -1;
            // 
            // dataGridTextBoxColumn12
            // 
            this.dataGridTextBoxColumn12.Format = "";
            this.dataGridTextBoxColumn12.FormatInfo = null;
            this.dataGridTextBoxColumn12.Width = -1;
            // 
            // dataGridTextBoxColumn13
            // 
            this.dataGridTextBoxColumn13.Format = "";
            this.dataGridTextBoxColumn13.FormatInfo = null;
            this.dataGridTextBoxColumn13.Width = -1;
            // 
            // dataGridTextBoxColumn14
            // 
            this.dataGridTextBoxColumn14.Format = "";
            this.dataGridTextBoxColumn14.FormatInfo = null;
            this.dataGridTextBoxColumn14.Width = -1;
            // 
            // dataGridTextBoxColumn15
            // 
            this.dataGridTextBoxColumn15.Format = "";
            this.dataGridTextBoxColumn15.FormatInfo = null;
            this.dataGridTextBoxColumn15.Width = -1;
            // 
            // dataGridTextBoxColumn16
            // 
            this.dataGridTextBoxColumn16.Format = "";
            this.dataGridTextBoxColumn16.FormatInfo = null;
            this.dataGridTextBoxColumn16.Width = -1;
            // 
            // dataGridTextBoxColumn17
            // 
            this.dataGridTextBoxColumn17.Format = "";
            this.dataGridTextBoxColumn17.FormatInfo = null;
            this.dataGridTextBoxColumn17.Width = -1;
            // 
            // dataGridTextBoxColumn18
            // 
            this.dataGridTextBoxColumn18.Format = "";
            this.dataGridTextBoxColumn18.FormatInfo = null;
            this.dataGridTextBoxColumn18.Width = -1;
            // 
            // dataGridTextBoxColumn19
            // 
            this.dataGridTextBoxColumn19.Format = "";
            this.dataGridTextBoxColumn19.FormatInfo = null;
            this.dataGridTextBoxColumn19.Width = -1;
            // 
            // dataGridTextBoxColumn20
            // 
            this.dataGridTextBoxColumn20.Format = "";
            this.dataGridTextBoxColumn20.FormatInfo = null;
            this.dataGridTextBoxColumn20.Width = -1;
            // 
            // frmProtokollRennvelo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1347, 461);
            this.Controls.Add(this.dataGrid);
            this.Name = "frmProtokollRennvelo";
            this.Text = "Protokoll";
            this.Load += new System.EventHandler(this.frmProtokoll_Load);
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //		string _Link="";
        private DataTable _DataTable;

        private Sport _rv = new Sport();

        public Sport setRV
        {
            set
            {
                _rv = value;
            }
        }

        //private DataColumn AddColumn(string columnTitle, int width = 75)
        //{
        //    var textBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
        //    textBoxColumn.HeaderText = columnTitle;
        //    textBoxColumn.MappingName = textBoxColumn.HeaderText;

        //    textBoxColumn.Format = "";
        //    textBoxColumn.FormatInfo = null;
        //    textBoxColumn.Width = width;

        //    textBoxColumn.NullText = "";
        //    dataGridTableStyle.GridColumnStyles.Add(textBoxColumn);
        //    var column = _DataTable.Columns.Add(columnTitle);

        //    return column;
        //}

        private void frmProtokoll_Load(object sender, System.EventArgs e)
        {
            this.Text = "Rennvelo-Info";
            this.Text += " (" + Settings.Jahr + ")";
            //lblInfo.Text = "Datum und berechnete Daten";
            //f.DoXPStyle(this);
            //OnResize(null, null);

            this.MaximizeBox = true;
            this.MinimizeBox = true;


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

            var columnDatum = dataGridTableStyle.AddColumn("Datum");
            var columnStrecke = dataGridTableStyle.AddColumn("Strecke", 150);
            var columnDauer = dataGridTableStyle.AddColumn("Dauer", horizontalAlignment: HorizontalAlignment.Right);
            var columnZwischenZeit1 = dataGridTableStyle.AddColumn("ZwischenZeit1", 100);
            var columnZwischenZeit2 = dataGridTableStyle.AddColumn("ZwischenZeit2", 100);
            var columnZwischenZeit3 = dataGridTableStyle.AddColumn("ZwischenZeit3", 100);
            var columnZwischenZeit4 = dataGridTableStyle.AddColumn("ZwischenZeit4", 100);
            var columnZwischenZeit5 = dataGridTableStyle.AddColumn("ZwischenZeit5", 100);
            var columnZwischenZeit6 = dataGridTableStyle.AddColumn("ZwischenZeit6", 100);
            var columnZwischenZeit7 = dataGridTableStyle.AddColumn("ZwischenZeit7", 100);
            var columnHoechst = dataGridTableStyle.AddColumn("Hoechst", horizontalAlignment: HorizontalAlignment.Right);
            var columnARS = dataGridTableStyle.AddColumn("ARS", horizontalAlignment: HorizontalAlignment.Right);
            var columnKcal = dataGridTableStyle.AddColumn("Kcal", horizontalAlignment: HorizontalAlignment.Right);
            var columnDurchschnitt = dataGridTableStyle.AddColumn("Durchschnitt", horizontalAlignment: HorizontalAlignment.Right);
            var columnGewicht = dataGridTableStyle.AddColumn("Gewicht", horizontalAlignment: HorizontalAlignment.Right);
            var columnBemerkung = dataGridTableStyle.AddColumn("Bemerkung", 350);



            var rvDaten = _rv.RvDaten.OrderBy(_ => _.Strecke).ToList();

            var previousStrecke = "";

            for (var index = 0; index < rvDaten.Count; index++)
            {
                //if (previousStrecke != rvDaten[index].Strecke)
                //{
                //    //if(previousStrecke != "")
                //    //    _DataTable.Rows.Add(_DataTable.NewRow());

                //    //var newStreckeRow = _DataTable.NewRow();
                //    //_DataTable.Rows.Add(newStreckeRow);
                //    //newStreckeRow[columnDatum] = rvDaten[index].Strecke;

                //    previousStrecke = rvDaten[index].Strecke;
                //}

                var newRow = _DataTable.NewRow();
                _DataTable.Rows.Add(newRow);

                newRow[columnStrecke] = rvDaten[index].Strecke;
                newRow[columnDatum] = rvDaten[index].Datum.ToString("yyyy.MM.dd");
                newRow[columnDauer] = rvDaten[index].Dauer.ToString("F2");
                newRow[columnHoechst] = rvDaten[index].Hoechst.ToString("F1");
                newRow[columnARS] = rvDaten[index].ARS;
                newRow[columnDurchschnitt] = rvDaten[index].Durchschnitt.ToString("F2");
                newRow[columnKcal] = rvDaten[index].Kcal.ToString("N0");
                newRow[columnZwischenZeit1] = rvDaten[index].ZwischenZeit1?.ToString("F2");
                newRow[columnZwischenZeit2] = rvDaten[index].ZwischenZeit2?.ToString("F2");
                newRow[columnZwischenZeit3] = rvDaten[index].ZwischenZeit3?.ToString("F2");
                newRow[columnZwischenZeit4] = rvDaten[index].ZwischenZeit4?.ToString("F2");
                newRow[columnZwischenZeit5] = rvDaten[index].ZwischenZeit5?.ToString("F2");
                newRow[columnZwischenZeit6] = rvDaten[index].ZwischenZeit6?.ToString("F2");
                newRow[columnZwischenZeit7] = rvDaten[index].ZwischenZeit7?.ToString("F2");
                //newRow[13] = rvDaten[index].Gewicht;

                newRow[columnGewicht] = rvDaten[index].Gewicht.ToString("F1");
                newRow[columnBemerkung] = rvDaten[index].Bemerkung;

                if (newRow[columnZwischenZeit4] is DBNull)
                    newRow[columnZwischenZeit4] = "";

                if (newRow[columnZwischenZeit5] is DBNull)
                    newRow[columnZwischenZeit5] = "";

                if (newRow[columnZwischenZeit6] is DBNull)
                    newRow[columnZwischenZeit6] = "";

                if (newRow[columnZwischenZeit7] is DBNull)
                    newRow[columnZwischenZeit7] = "";
            }

            //var tZeit = 0.0;
            //var tkm = 0.0;
            //var tkcal = 0.0;
            //for (var i = 0; i < _rv.RvDaten.Count; i++)
            //{
            //    var rv = _rv.RvDaten[i];
            //    var newRow = _DataTable.NewRow();

            //    tZeit += rv.TotalZeit;
            //    tkcal += rv.Kcal;

            //    _DataTable.Rows.Add(newRow);
            //    _DataTable.Rows[i][0] = rv.StringDatum;
            //    _DataTable.Rows[i][1] = tkcal.ToString("0");
            //    _DataTable.Rows[i][2] = (tkcal / 9300).ToString("0.00");
            //    _DataTable.Rows[i][4] = (tZeit / 60).ToString("0.00");

            //    _DataTable.Rows[i][6] = rv.Strecke;

            //    var sd = _rv.SDInfo(rv.Strecke);
            //    if (sd == null)
            //        continue;
            //    tkm += sd.Distanz;
            //    _DataTable.Rows[i][3] = tkm.ToString("0.00");
            //    var durchschnitt = tkm / (tZeit / 60.0);
            //    _DataTable.Rows[i][5] = durchschnitt.ToString("0.00");
            //    _DataTable.Rows[i][6] = sd.Rundfahrt;
            //    _DataTable.Rows[i][7] = rv.Bemerkung;
            //}
            //			_DataTable.Rows[0][0]="file";//finder.ArrFiles[i].ToString();

            //			object missing = System.Reflection.Missing.Value;
            //			_Link=@"D:\Programme\C++\bin\dokumenteninformationen.htm";
            //			this.axWebBrowser.Navigate(_Link, ref missing, ref missing, ref missing, ref missing);

            //			this.axWebBrowser.Navigate(_Link, ref missing, ref missing, ref missing, ref missing);

            //			this.axWebBrowser.LocationURL=@"D:\Programme\C++\bin\dokumenteninformationen.htm";
        }

        private void OnResize(object sender, System.EventArgs e)
        {
            //			this.Left

            dataGrid.Width = this.Width - 3 * dataGrid.Left;
            dataGrid.Height = this.Height - dataGrid.Top - 40;
        }
    }
}