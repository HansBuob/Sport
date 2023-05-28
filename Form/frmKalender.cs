using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using twr;
using f = twr.DFunktionen;

namespace Sport
{
    /// <summary>
    /// Summary description for frmKalender.
    /// </summary>
    public class frmKalender : frmForm
    {
        private System.Windows.Forms.Label lblWork;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmKalender()
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
            this.lblWork = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblWork
            //
            this.lblWork.Location = new System.Drawing.Point(1, 4);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(534, 306);
            this.lblWork.TabIndex = 0;
            this.lblWork.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            //
            // frmKalender
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(536, 310);
            this.Controls.Add(this.lblWork);
            this.Name = "frmKalender";
            this.Text = "Kalender";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Resize += new System.EventHandler(this.OnResize);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.frmKalender_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private Hashtable _ht = new Hashtable();

        //		RV _rv=null;
        public Sport setRV
        {
            set
            {
                var _rv = value;

                _ht = new Hashtable();

                for (var i = 0; i < _rv.RvDaten.Count; i++)
                {
                    var d = _rv.RvDaten[i];
                    if (_ht.ContainsKey(d.StringDatum))
                    {
                        Console.WriteLine("RV: doubleentry " + d.StringDatum);
                        continue;
                    }
                    _ht.Add(d.StringDatum, "RV - " + d.Gewicht.ToString("F1"));
                }
                for (var i = 0; i < _rv.JoDaten.Count; i++)
                {
                    var d = _rv.JoDaten[i];
                    if (_ht.ContainsKey(d.StringDatum))
                    {
                        Console.WriteLine("J : doubleentry " + d.StringDatum);
                        continue;
                    }
                    _ht.Add(d.StringDatum, "JO - " + d.Gewicht.ToString("F1"));
                }
                for (var i = 0; i < _rv.HtDaten.Count; i++)
                {
                    var d = _rv.HtDaten[i];
                    if (_ht.ContainsKey(d.StringDatum))
                    {
                        Console.WriteLine("R : doubleentry " + d.StringDatum);
                        continue;
                    }
                    _ht.Add(d.StringDatum, "HT - " + d.Gewicht.ToString("F1"));
                }
            }
        }

        private bool _showFirst6Months = true;
        private int _jahr = 0;

        private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //LightSteelBlue
            //e.Graphics.FillRectangle(new SolidBrush(Color.White),5,5,this.Width-8-10, this.Height-28-4-10);
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkGray), 0, 0, this.Width - 8, this.Height - 28 - 4);

            var rcClient = new Rectangle(0, 0, this.Width - 8, this.Height - 28 - 4);

            var angle = 45;
            var linGrBrush = new LinearGradientBrush(
                rcClient,
                Color.FromArgb(255, 220, 220, 220),// pale blue
                Color.FromArgb(255, 190, 190, 190),   // deep blue
                                                      //Color.FromArgb(255, 0, 72, 160),   // deep blue
                angle);

            //e.Graphics.FillRectangle(linGrBrush, rcClient);

            //lblWork
            var font = new Font("Courier New", 9);
            var fontMonat = new Font("Verdana", 8);

            if (_jahr == 0)
                _jahr = f.ConvertToInt(Settings.Jahr);

            var dt = new DateTime(_jahr, 1, 1);

            var vx = 0;
            var vy = 0;

            for (var i = 0; i < 366; i++)
            {
                if (_showFirst6Months)
                {
                    if (dt.Month > 6)
                        break;
                }
                else
                {
                    if (dt.Month < 7)
                    {
                        dt = dt.AddDays(1);
                        continue;
                    }
                }

                var info = "";
                var datum = dt.ToString("yyyyMMdd");
                if (_ht.ContainsKey(datum))
                    info = _ht[datum].ToString();

                if (info == "HT - 0.0")
                    info = "HT";
                if (info == "JO - 0.0")
                    info = "JO";

                var mColor = Color.Red;
                var day = dt.Day.ToString();
                if (dt.Day == 1)
                {
                    var monat = "";
                    if (dt.Month == 1) monat = "Januar";
                    if (dt.Month == 2) monat = "Februar";
                    if (dt.Month == 3) monat = "März";
                    if (dt.Month == 4) monat = "April";
                    if (dt.Month == 5) monat = "Mai";
                    if (dt.Month == 6) monat = "Juni";
                    if (dt.Month == 7) monat = "Juli";
                    if (dt.Month == 8) monat = "August";
                    if (dt.Month == 9) monat = "September";
                    if (dt.Month == 10) monat = "Oktober";
                    if (dt.Month == 11) monat = "November";
                    if (dt.Month == 12) monat = "Dezember";

                    if ((dt.Month == 1) || (dt.Month == 4) || (dt.Month == 7) || (dt.Month == 10))
                        mColor = Color.Red;
                    if ((dt.Month == 2) || (dt.Month == 5) || (dt.Month == 8) || (dt.Month == 11))
                        mColor = Color.Blue;
                    if ((dt.Month == 3) || (dt.Month == 6) || (dt.Month == 9) || (dt.Month == 12))
                        mColor = Color.Green;

                    monat += " " + _jahr.ToString();

                    vx++;
                    e.Graphics.FillRectangle(new SolidBrush(mColor), vx * 150 - 150, 0, 140, 16);
                    e.Graphics.DrawString(monat, fontMonat, new SolidBrush(Color.White), vx * 150 - 150, 0);

                    vy = 0;
                }
                if (day.Length == 1)
                    day = " " + day;

                if (dt.DayOfWeek == System.DayOfWeek.Sunday)
                    e.Graphics.DrawString(day, font, new SolidBrush(Color.Red), vx * 150 - 150, vy * 12 + 12 + 2);
                else
                    e.Graphics.DrawString(day, font, new SolidBrush(Color.Black), vx * 150 - 150, vy * 12 + 12 + 2);

                if (info.Length != 0)
                {
                    var solidBrush = new SolidBrush(Color.Black);

                    if (info.StartsWith("JO"))
                        solidBrush = new SolidBrush(Color.Brown);
                    else if (info.StartsWith("RV"))
                        solidBrush = new SolidBrush(Color.DarkOrchid);

                    e.Graphics.DrawString(info, font, solidBrush, vx * 150 - 150 + 25, vy * 12 + 12 + 2);
                }

                vy++;

                dt = dt.AddDays(1);
                //				if(i>65)
                //					break;
            }
        }

        private void OnResize(object sender, System.EventArgs e)
        {
            lblWork.Left = 5;
            lblWork.Top = 5;//toolBar.Height + 5;
            lblWork.Width = this.Width - 5 - 5 - 10;
            lblWork.Height = this.Height - 45;//toolBar.Height-45;
        }

        private void frmKalender_Load(object sender, System.EventArgs e)
        {
            this.Text += " (" + Settings.Jahr + ")";
            var dialogname = this.Text;
            if (dialogname.IndexOf("(", StringComparison.Ordinal) != -1)
                dialogname = f.HeadFromList(ref dialogname, "(");

            var reg = new DRegistry();
            var width = f.ConvertToInt(reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "width"));
            if (width == 0)
                this.Width = 960;
            if (width > 100)
                this.Width = width;
            var height = f.ConvertToInt(reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "height"));
            if (height == 0)
                height = 720;
            if (height > 100)
                this.Height = height;

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            OnResize(null, null);

            OnResize(null, null);
        }

        private void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                if (_showFirst6Months)
                    _showFirst6Months = false;
                else
                    _showFirst6Months = true;

                lblWork.Invalidate();
            }
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
                return;

            if (Settings.IsMdiLayout)
                return;

            var dialogname = this.Text;
            if (dialogname.IndexOf("(", StringComparison.Ordinal) != -1)
                dialogname = f.HeadFromList(ref dialogname, "(");

            var reg = new DRegistry();
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "width", Width.ToString());
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "height", Height.ToString());
        }
    }
}