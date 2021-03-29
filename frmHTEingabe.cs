using twr;
using twr.common;
using f = twr.DFunktionen;

namespace Sport
{
    /// <summary>
    /// Summary description for frmHTEingabe.
    /// </summary>
    public class frmHTEingabe : frmForm//: System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdOk;
        private TwrControlLibrary.DNumTextBox tbBelastung;
        private TwrControlLibrary.DNumTextBox tbDauer;
        private TwrControlLibrary.DNumTextBox tbPulsschlagV;
        private TwrControlLibrary.DNumTextBox tbPulsschlagN;
        private TwrControlLibrary.DNumTextBox tbDistanz;
        private TwrControlLibrary.DNumTextBox tbKJoul;
        private TwrControlLibrary.DNumTextBox tbGewicht;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmHTEingabe()
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBelastung = new TwrControlLibrary.DNumTextBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDauer = new TwrControlLibrary.DNumTextBox();
            this.tbPulsschlagV = new TwrControlLibrary.DNumTextBox();
            this.tbPulsschlagN = new TwrControlLibrary.DNumTextBox();
            this.tbDistanz = new TwrControlLibrary.DNumTextBox();
            this.tbKJoul = new TwrControlLibrary.DNumTextBox();
            this.tbGewicht = new TwrControlLibrary.DNumTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            //
            // tbBelastung
            //
            this.tbBelastung.Location = new System.Drawing.Point(137, 28);
            this.tbBelastung.Name = "tbBelastung";
            this.tbBelastung.Size = new System.Drawing.Size(83, 20);
            this.tbBelastung.TabIndex = 1;
            this.tbBelastung.Text = "0.00";
            this.tbBelastung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // dtDatum
            //
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatum.Location = new System.Drawing.Point(137, 7);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(93, 20);
            this.dtDatum.TabIndex = 0;
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Belastung";
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dauer";
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pulsschlag";
            //
            // label5
            //
            this.label5.Location = new System.Drawing.Point(10, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Distanz";
            //
            // label6
            //
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "KJoul";
            //
            // label7
            //
            this.label7.Location = new System.Drawing.Point(10, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gewicht";
            //
            // tbDauer
            //
            this.tbDauer.Location = new System.Drawing.Point(137, 49);
            this.tbDauer.Name = "tbDauer";
            this.tbDauer.Size = new System.Drawing.Size(83, 20);
            this.tbDauer.TabIndex = 2;
            this.tbDauer.Text = "0.00";
            this.tbDauer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbPulsschlagV
            //
            this.tbPulsschlagV.Location = new System.Drawing.Point(137, 69);
            this.tbPulsschlagV.Name = "tbPulsschlagV";
            this.tbPulsschlagV.Size = new System.Drawing.Size(83, 20);
            this.tbPulsschlagV.TabIndex = 3;
            this.tbPulsschlagV.Text = "0.00";
            this.tbPulsschlagV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbPulsschlagN
            //
            this.tbPulsschlagN.Location = new System.Drawing.Point(137, 90);
            this.tbPulsschlagN.Name = "tbPulsschlagN";
            this.tbPulsschlagN.Size = new System.Drawing.Size(83, 20);
            this.tbPulsschlagN.TabIndex = 4;
            this.tbPulsschlagN.Text = "0.00";
            this.tbPulsschlagN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbDistanz
            //
            this.tbDistanz.Location = new System.Drawing.Point(137, 111);
            this.tbDistanz.Name = "tbDistanz";
            this.tbDistanz.Size = new System.Drawing.Size(83, 20);
            this.tbDistanz.TabIndex = 5;
            this.tbDistanz.Text = "0.00";
            this.tbDistanz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbKJoul
            //
            this.tbKJoul.Location = new System.Drawing.Point(137, 132);
            this.tbKJoul.Name = "tbKJoul";
            this.tbKJoul.Size = new System.Drawing.Size(83, 20);
            this.tbKJoul.TabIndex = 6;
            this.tbKJoul.Text = "0.00";
            this.tbKJoul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbGewicht
            //
            this.tbGewicht.Location = new System.Drawing.Point(137, 154);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(83, 20);
            this.tbGewicht.TabIndex = 7;
            this.tbGewicht.Text = "0.00";
            this.tbGewicht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblInfo
            //
            this.lblInfo.Location = new System.Drawing.Point(10, 177);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(217, 15);
            this.lblInfo.TabIndex = 44;
            //
            // cmdClose
            //
            this.cmdClose.Location = new System.Drawing.Point(164, 198);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(68, 22);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Schliessen";
            //
            // cmdOk
            //
            this.cmdOk.Location = new System.Drawing.Point(84, 198);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(68, 22);
            this.cmdOk.TabIndex = 8;
            this.cmdOk.Text = "Speichern";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            //
            // frmHTEingabe
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(233, 223);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.tbGewicht);
            this.Controls.Add(this.tbKJoul);
            this.Controls.Add(this.tbDistanz);
            this.Controls.Add(this.tbPulsschlagN);
            this.Controls.Add(this.tbPulsschlagV);
            this.Controls.Add(this.tbDauer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.tbBelastung);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHTEingabe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HT-Eingabe";
            this.Load += new System.EventHandler(this.frmHTEingabe_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private Sport _rv = null;

        public Sport setRV
        {
            set
            {
                _rv = value;
            }
        }

        private void frmHTEingabe_Load(object sender, System.EventArgs e)
        {
            dtDatum.Value = dtDatum.Value.AddYears(f.ConvertToInt(Settings._Jahr) - dtDatum.Value.Year);

            if (_rv.HtDaten.Count > 0)
            {
                var data = (HeimtrainerDaten)_rv.HtDaten[_rv.HtDaten.Count - 1];
                lblInfo.Text = "Letztes Eingabedatum: " + data.StringDatum;
            }

            var init = new DInitFile();
            init.ReadFile(Settings._DataPfad + "init.ini");
            var puls = init.GetData("Puls");
            if (puls == "0")
            {
                tbPulsschlagV.Enabled = false;
                tbPulsschlagN.Enabled = false;
            }

            if (_rv.HtDaten.Count > 0)
            {
                var data = (HeimtrainerDaten)_rv.HtDaten[_rv.HtDaten.Count - 1];
                tbBelastung.Text = data.Belastung.ToString();
                tbDauer.Text = data.Dauer;

                tbBelastung.Text = data.Belastung.ToString();
                tbDistanz.Text = data.Distanz.ToString();
                tbKJoul.Text = data.KJoul.ToString();
                tbGewicht.Text = data.Gewicht.ToString();
            }
        }

        private void cmdOk_Click(object sender, System.EventArgs e)
        {
            var data = new HeimtrainerDaten();
            data.StringDatum = dtDatum.Value.ToString("yyyyMMdd"); ;
            data.Belastung = f.ConvertToDouble(tbBelastung.Text);
            data.Dauer = tbDauer.Text;
            //data.PulsschlagVor=f.ConvertToDouble(tbPulsschlagV.Text);
            //data.PulsschlagNach=f.ConvertToDouble(tbPulsschlagN.Text);
            data.Distanz = f.ConvertToDouble(tbDistanz.Text);
            data.KJoul = f.ConvertToDouble(tbKJoul.Text);
            data.Gewicht = tbGewicht.Text.ToDouble();
            _rv.HtDaten.Add(data);

            _rv.SaveData("HT");

            //			tbBelastung.Text="0.0";
            //			tbDauer.Text="0.0";
            //			tbPulsschlagV.Text="0.0";
            //			tbPulsschlagN.Text="0.0";
            //			tbDistanz.Text="0.0";
            //			tbKJoul.Text="0.0";
            //			tbGewicht.Text="0.0";

            dtDatum.Value = dtDatum.Value.AddDays(1);
            dtDatum.Focus();
        }
    }
}