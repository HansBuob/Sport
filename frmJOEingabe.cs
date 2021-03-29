using System.Windows.Forms;
using twr;
using twr.common;
using f = twr.DFunktionen;

namespace Sport
{
    /// <summary>
    /// Summary description for frmJOEingabe.
    /// </summary>
    public class frmJOEingabe : frmForm//: System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStrecke;
        private System.Windows.Forms.Label lblInfo;
        private TwrControlLibrary.DNumTextBox tbGewicht;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private TwrControlLibrary.DNumTextBox tbLp1;
        private TwrControlLibrary.DNumTextBox tbLp2;
        private TwrControlLibrary.DNumTextBox tbLp3;
        private TwrControlLibrary.DNumTextBox tbLp4;
        private TwrControlLibrary.DNumTextBox tbLp5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBemerkung;
        private TwrControlLibrary.DNumTextBox tbPause1;
        private TwrControlLibrary.DNumTextBox tbPause2;
        private TwrControlLibrary.DNumTextBox tbPause3;
        private TwrControlLibrary.DNumTextBox tbPause4;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmJOEingabe()
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
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStrecke = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbGewicht = new TwrControlLibrary.DNumTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLp1 = new TwrControlLibrary.DNumTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLp2 = new TwrControlLibrary.DNumTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLp3 = new TwrControlLibrary.DNumTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLp4 = new TwrControlLibrary.DNumTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLp5 = new TwrControlLibrary.DNumTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBemerkung = new System.Windows.Forms.TextBox();
            this.tbPause1 = new TwrControlLibrary.DNumTextBox();
            this.tbPause2 = new TwrControlLibrary.DNumTextBox();
            this.tbPause3 = new TwrControlLibrary.DNumTextBox();
            this.tbPause4 = new TwrControlLibrary.DNumTextBox();
            this.SuspendLayout();
            //
            // cmdClose
            //
            this.cmdClose.Location = new System.Drawing.Point(212, 244);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(68, 22);
            this.cmdClose.TabIndex = 14;
            this.cmdClose.Text = "Schliessen";
            //
            // cmdOk
            //
            this.cmdOk.Location = new System.Drawing.Point(134, 244);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(68, 22);
            this.cmdOk.TabIndex = 13;
            this.cmdOk.Text = "Speichern";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            //
            // dtDatum
            //
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatum.Location = new System.Drawing.Point(135, 7);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(93, 20);
            this.dtDatum.TabIndex = 0;
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datum";
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Strecke";
            //
            // cboStrecke
            //
            this.cboStrecke.Location = new System.Drawing.Point(135, 28);
            this.cboStrecke.Name = "cboStrecke";
            this.cboStrecke.Size = new System.Drawing.Size(143, 21);
            this.cboStrecke.TabIndex = 1;
            //
            // lblInfo
            //
            this.lblInfo.Location = new System.Drawing.Point(10, 224);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(217, 15);
            this.lblInfo.TabIndex = 13;
            //
            // tbGewicht
            //
            this.tbGewicht.Location = new System.Drawing.Point(135, 156);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(83, 20);
            this.tbGewicht.TabIndex = 11;
            this.tbGewicht.Text = "0.00";
            this.tbGewicht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label7
            //
            this.label7.Location = new System.Drawing.Point(10, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Gewicht";
            //
            // tbLp1
            //
            this.tbLp1.Location = new System.Drawing.Point(135, 52);
            this.tbLp1.Name = "tbLp1";
            this.tbLp1.Size = new System.Drawing.Size(83, 20);
            this.tbLp1.TabIndex = 2;
            this.tbLp1.Text = "0.00";
            this.tbLp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 49;
            this.label3.Text = "Laufposition 1";
            //
            // tbLp2
            //
            this.tbLp2.Location = new System.Drawing.Point(135, 73);
            this.tbLp2.Name = "tbLp2";
            this.tbLp2.Size = new System.Drawing.Size(83, 20);
            this.tbLp2.TabIndex = 4;
            this.tbLp2.Text = "0.00";
            this.tbLp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label4
            //
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Laufposition 2";
            //
            // tbLp3
            //
            this.tbLp3.Location = new System.Drawing.Point(135, 94);
            this.tbLp3.Name = "tbLp3";
            this.tbLp3.Size = new System.Drawing.Size(83, 20);
            this.tbLp3.TabIndex = 6;
            this.tbLp3.Text = "0.00";
            this.tbLp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label5
            //
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 53;
            this.label5.Text = "Laufposition 3";
            //
            // tbLp4
            //
            this.tbLp4.Location = new System.Drawing.Point(135, 114);
            this.tbLp4.Name = "tbLp4";
            this.tbLp4.Size = new System.Drawing.Size(83, 20);
            this.tbLp4.TabIndex = 8;
            this.tbLp4.Text = "0.00";
            this.tbLp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label6
            //
            this.label6.Location = new System.Drawing.Point(10, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "Laufposition 4";
            //
            // tbLp5
            //
            this.tbLp5.Location = new System.Drawing.Point(135, 135);
            this.tbLp5.Name = "tbLp5";
            this.tbLp5.Size = new System.Drawing.Size(83, 20);
            this.tbLp5.TabIndex = 10;
            this.tbLp5.Text = "0.00";
            this.tbLp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // label8
            //
            this.label8.Location = new System.Drawing.Point(10, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "Laufposition 5";
            //
            // label9
            //
            this.label9.Location = new System.Drawing.Point(10, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 14);
            this.label9.TabIndex = 58;
            this.label9.Text = "Bemerkung";
            //
            // tbBemerkung
            //
            this.tbBemerkung.Location = new System.Drawing.Point(10, 198);
            this.tbBemerkung.Name = "tbBemerkung";
            this.tbBemerkung.Size = new System.Drawing.Size(268, 20);
            this.tbBemerkung.TabIndex = 12;
            this.tbBemerkung.Text = "";
            //
            // tbPause1
            //
            this.tbPause1.Location = new System.Drawing.Point(242, 52);
            this.tbPause1.Name = "tbPause1";
            this.tbPause1.Size = new System.Drawing.Size(36, 20);
            this.tbPause1.TabIndex = 3;
            this.tbPause1.Text = "0.00";
            this.tbPause1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbPause2
            //
            this.tbPause2.Location = new System.Drawing.Point(242, 74);
            this.tbPause2.Name = "tbPause2";
            this.tbPause2.Size = new System.Drawing.Size(36, 20);
            this.tbPause2.TabIndex = 5;
            this.tbPause2.Text = "0.00";
            this.tbPause2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbPause3
            //
            this.tbPause3.Location = new System.Drawing.Point(242, 96);
            this.tbPause3.Name = "tbPause3";
            this.tbPause3.Size = new System.Drawing.Size(36, 20);
            this.tbPause3.TabIndex = 7;
            this.tbPause3.Text = "0.00";
            this.tbPause3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // tbPause4
            //
            this.tbPause4.Location = new System.Drawing.Point(242, 118);
            this.tbPause4.Name = "tbPause4";
            this.tbPause4.Size = new System.Drawing.Size(38, 20);
            this.tbPause4.TabIndex = 9;
            this.tbPause4.Text = "0.00";
            this.tbPause4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // frmJOEingabe
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(284, 268);
            this.Controls.Add(this.tbPause4);
            this.Controls.Add(this.tbPause3);
            this.Controls.Add(this.tbPause2);
            this.Controls.Add(this.tbPause1);
            this.Controls.Add(this.tbBemerkung);
            this.Controls.Add(this.tbLp5);
            this.Controls.Add(this.tbLp4);
            this.Controls.Add(this.tbLp3);
            this.Controls.Add(this.tbLp2);
            this.Controls.Add(this.tbLp1);
            this.Controls.Add(this.tbGewicht);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboStrecke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.label1);
            this.Name = "frmJOEingabe";
            this.Text = "JO-Eingabe";
            this.Load += new System.EventHandler(this.frmJOEingabe_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private Sport _rv;

        public Sport setRV
        {
            set
            {
                _rv = value;
            }
        }

        private void frmJOEingabe_Load(object sender, System.EventArgs e)
        {
            //this.AutoScale=false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            dtDatum.Value = dtDatum.Value.AddYears(f.ConvertToInt(Settings._Jahr) - dtDatum.Value.Year);

            if (_rv.JoDaten.Count > 0)
            {
                var data = _rv.JoDaten[_rv.JoDaten.Count - 1];
                lblInfo.Text = "Letztes Eingabedatum: " + data.StringDatum;
            }

            cboStrecke.Items.Add("");
            //var myEnumerator = _rv._htJOStrecken.GetEnumerator();
            //while (myEnumerator.MoveNext())
            //    cboStrecke.Items.Add(myEnumerator.Value.ToString());

            tbPause1.Text = "1.0";
            tbPause2.Text = "1.0";
            tbPause3.Text = "1.0";
            tbPause4.Text = "1.0";
        }

        private void cmdOk_Click(object sender, System.EventArgs e)
        {
            var data = new JoggenDaten();
            data.StringDatum = dtDatum.Value.ToString("yyyyMMdd"); ;
            data.Strecke = cboStrecke.Text;

            //if(tbPause1.Text!="1.00")
            //    data.W1=f.ConvertToDouble(tbPause1.Text);
            //if(tbPause2.Text!="1.00")
            //    data.W2=f.ConvertToDouble(tbPause2.Text);
            //if(tbPause3.Text!="1.00")
            //    data.W3=f.ConvertToDouble(tbPause3.Text);
            //if(tbPause4.Text!="1.00")
            //    data.W4=f.ConvertToDouble(tbPause4.Text);

            //data.LP1=f.ConvertToDouble(tbLp1.Text);
            //data.LP2=f.ConvertToDouble(tbLp2.Text);
            //data.LP3=f.ConvertToDouble(tbLp3.Text);
            //data.LP4=f.ConvertToDouble(tbLp4.Text);
            //data.LP5=f.ConvertToDouble(tbLp5.Text);

            //if(data.LP5==0.0)	data.W4=0.0;
            //if(data.LP4==0.0)	data.W3=0.0;
            //if(data.LP3==0.0)	data.W2=0.0;
            //if(data.LP2==0.0)	data.W1=0.0;

            /*
                        data.G1=f.ConvertToDouble(tbLp1.Text);
                        data.G2=f.ConvertToDouble(tbLp2.Text);
                        data.G3=f.ConvertToDouble(tbLp3.Text);
                        data.G4=f.ConvertToDouble(tbLp4.Text);
                        data.G5=f.ConvertToDouble(tbLp5.Text);*/
            data.Gewicht = tbGewicht.Text.ToDouble();
            data.Bemerkung = this.tbBemerkung.Text;

            /*			data.Belastung=f.ConvertToDouble(tbBelastung.Text);
                        data.Zeit=tbDauer.Text;
                        data.PulsschlagVor=f.ConvertToDouble(tbPulsschlagV.Text);
                        data.PulsschlagNach=f.ConvertToDouble(tbPulsschlagN.Text);
                        data.Distanz=f.ConvertToDouble(tbDistanz.Text);
                        data.KJoul=f.ConvertToDouble(tbKJoul.Text);
                        data.Gewicht=tbGewicht.Text;
            */
            _rv.JoDaten.Add(data);

            _rv.SaveData("JO");

            //			cboStrecke.Text="";
            tbLp1.Text = "0.0";
            tbLp2.Text = "0.0";
            tbLp3.Text = "0.0";
            tbLp4.Text = "0.0";
            tbLp5.Text = "0.0";
            tbBemerkung.Text = "";
            tbGewicht.Text = "0.0";

            /*			tbBelastung.Text="0.0";
                        tbDauer.Text="0.0";
                        tbPulsschlagV.Text="0.0";
                        tbPulsschlagN.Text="0.0";
                        tbDistanz.Text="0.0";
                        tbKJoul.Text="0.0";
                        tbGewicht.Text="0.0";
            */
        }
    }
}