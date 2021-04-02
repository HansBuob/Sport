using System.Data;

using twr;
using f = twr.DFunktionen;

namespace Sport
{
    /// <summary>
    /// Summary description for frmProtokoll.
    /// </summary>
    public class frmProtokoll : frmForm//: System.Windows.Forms.Form
    {
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.Label lblInfo;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmProtokoll()
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
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            //
            // dataGrid
            //
            this.dataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGrid.CaptionVisible = false;
            this.dataGrid.DataMember = "";
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(6, 38);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(518, 258);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
                                                                                                 this.dataGridTableStyle1});
            //
            // dataGridTableStyle1
            //
            this.dataGridTableStyle1.DataGrid = this.dataGrid;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
                                                                                                                  this.dataGridTextBoxColumn1,
                                                                                                                  this.dataGridTextBoxColumn2,
                                                                                                                  this.dataGridTextBoxColumn3,
                                                                                                                  this.dataGridTextBoxColumn4,
                                                                                                                  this.dataGridTextBoxColumn5,
                                                                                                                  this.dataGridTextBoxColumn6,
                                                                                                                  this.dataGridTextBoxColumn7,
                                                                                                                  this.dataGridTextBoxColumn8});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "";
            this.dataGridTableStyle1.PreferredColumnWidth = 150;
            //
            // dataGridTextBoxColumn1
            //
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Datum";
            this.dataGridTextBoxColumn1.MappingName = "Datum";
            //
            // dataGridTextBoxColumn2
            //
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Kcal";
            this.dataGridTextBoxColumn2.MappingName = "Kcal";
            //
            // dataGridTextBoxColumn3
            //
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Kg";
            this.dataGridTextBoxColumn3.MappingName = "Kg";
            //
            // dataGridTextBoxColumn4
            //
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Km";
            this.dataGridTextBoxColumn4.MappingName = "Km";
            //
            // dataGridTextBoxColumn5
            //
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Zeit";
            this.dataGridTextBoxColumn5.MappingName = "Zeit";
            //
            // dataGridTextBoxColumn6
            //
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Km/h";
            this.dataGridTextBoxColumn6.MappingName = "Km/h";
            //
            // dataGridTextBoxColumn7
            //
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Strecke";
            this.dataGridTextBoxColumn7.MappingName = "Strecke";
            this.dataGridTextBoxColumn7.Width = 150;
            //
            // dataGridTextBoxColumn8
            //
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "Bemerkung";
            this.dataGridTextBoxColumn8.MappingName = "Bemerkung";
            this.dataGridTextBoxColumn8.Width = 250;
            //
            // lblInfo
            //
            this.lblInfo.Location = new System.Drawing.Point(8, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(514, 20);
            this.lblInfo.TabIndex = 1;
            //
            // frmProtokoll
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(676, 354);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dataGrid);
            this.Name = "frmProtokoll";
            this.Text = "Protokoll";
            this.Resize += new System.EventHandler(this.OnResize);
            this.Load += new System.EventHandler(this.frmProtokoll_Load);
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

        private void frmProtokoll_Load(object sender, System.EventArgs e)
        {
            lblInfo.Text = "Datum und berechnete Daten";
            f.DoXPStyle(this);
            OnResize(null, null);

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            _DataTable = new DataTable("DI");
            dataGrid.TableStyles[0].MappingName = "DI";
            DataColumn dc1, dc2, dc3, dc4, dc5, dc6, dc7, dc8;
            dc1 = _DataTable.Columns.Add("Datum");
            dc2 = _DataTable.Columns.Add("Kcal");
            dc3 = _DataTable.Columns.Add("Kg");
            dc4 = _DataTable.Columns.Add("Km");
            dc5 = _DataTable.Columns.Add("Zeit");
            dc6 = _DataTable.Columns.Add("Km/h");
            dc7 = _DataTable.Columns.Add("Strecke");
            dc8 = _DataTable.Columns.Add("Bemerkung");

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

            var tZeit = 0.0;
            var tkm = 0.0;
            var tkcal = 0.0;
            for (var i = 0; i < _rv.RvDaten.Count; i++)
            {
                var rv = _rv.RvDaten[i];
                var newRow = _DataTable.NewRow();

                tZeit += rv.TotalZeit;
                tkcal += rv.Kcal;

                _DataTable.Rows.Add(newRow);
                _DataTable.Rows[i][0] = rv.StringDatum;
                _DataTable.Rows[i][1] = tkcal.ToString("0");
                _DataTable.Rows[i][2] = (tkcal / 9300).ToString("0.00");
                _DataTable.Rows[i][4] = (tZeit / 60).ToString("0.00");

                _DataTable.Rows[i][6] = rv.Strecke;

                var sd = _rv.SDInfo(rv.Strecke);
                if (sd == null)
                    continue;
                tkm += sd.Distanz;
                _DataTable.Rows[i][3] = tkm.ToString("0.00");
                var durchschnitt = tkm / (tZeit / 60.0);
                _DataTable.Rows[i][5] = durchschnitt.ToString("0.00");
                _DataTable.Rows[i][6] = sd.Rundfahrt;
                _DataTable.Rows[i][7] = rv.Bemerkung;
            }
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