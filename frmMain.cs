using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using twr;
using f = twr.DFunktionen;

namespace Sport
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmMain : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.StatusBar StatusBar;
        private System.Windows.Forms.StatusBarPanel statusBarPanel3;
        private System.Windows.Forms.Label Work;
        private System.Windows.Forms.ToolBar ToolBar;
        private System.Windows.Forms.StatusBarPanel sbPanelDatei;
        private System.Windows.Forms.StatusBarPanel sbPanelAnzahl;
        public System.Windows.Forms.StatusBarPanel sbInfo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.ComponentModel.IContainer components;

        public frmMain()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.StatusBar = new System.Windows.Forms.StatusBar();
            this.sbInfo = new System.Windows.Forms.StatusBarPanel();
            this.sbPanelDatei = new System.Windows.Forms.StatusBarPanel();
            this.sbPanelAnzahl = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.ToolBar = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Work = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelDatei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelAnzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem6,
            this.menuItem1});
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem13,
            this.menuItem15});
            this.menuItem3.Text = "Eingabe";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR;
            this.menuItem4.Text = "RV-Eingabe";
            this.menuItem4.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH;
            this.menuItem13.Text = "HT-Eingabe";
            this.menuItem13.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 2;
            this.menuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftJ;
            this.menuItem15.Text = "JO-Eingabe";
            this.menuItem15.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.menuItem9,
            this.menuItem12});
            this.menuItem6.Text = "Ansicht";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.menuItem7.Text = "Grafik betrachten";
            this.menuItem7.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.menuItem8.Text = "Excel-Informationen";
            this.menuItem8.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.Text = "Gewichtskurve";
            this.menuItem9.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlK;
            this.menuItem12.Text = "Kalender";
            this.menuItem12.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10,
            this.menuItem11,
            this.menuItem14});
            this.menuItem1.Text = "Protokoll";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItem10.Text = "Rennvelo";
            this.menuItem10.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 1;
            this.menuItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuItem11.Text = "Heimtrainer";
            this.menuItem11.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlJ;
            this.menuItem14.Text = "Joggen";
            this.menuItem14.Click += new System.EventHandler(this.OnMenuClick);
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 440);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbInfo,
            this.sbPanelDatei,
            this.sbPanelAnzahl,
            this.statusBarPanel3});
            this.StatusBar.ShowPanels = true;
            this.StatusBar.Size = new System.Drawing.Size(830, 19);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.StatusBar_PanelClick);
            this.StatusBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.StatusBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStatusBarMouseDown);
            this.StatusBar.MouseLeave += new System.EventHandler(this.OnStatusbarMouseLeave);
            this.StatusBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnStatusbarMouseMove);
            // 
            // sbInfo
            // 
            this.sbInfo.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sbInfo.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.sbInfo.Name = "sbInfo";
            this.sbInfo.Width = 783;
            // 
            // sbPanelDatei
            // 
            this.sbPanelDatei.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbPanelDatei.Name = "sbPanelDatei";
            this.sbPanelDatei.Width = 10;
            // 
            // sbPanelAnzahl
            // 
            this.sbPanelAnzahl.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbPanelAnzahl.Name = "sbPanelAnzahl";
            this.sbPanelAnzahl.Width = 10;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Width = 10;
            // 
            // ToolBar
            // 
            this.ToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton4,
            this.toolBarButton2,
            this.toolBarButton3});
            this.ToolBar.ButtonSize = new System.Drawing.Size(16, 16);
            this.ToolBar.DropDownArrows = true;
            this.ToolBar.ImageList = this.imageList1;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.ShowToolTips = true;
            this.ToolBar.Size = new System.Drawing.Size(830, 28);
            this.ToolBar.TabIndex = 2;
            this.ToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.OnToolBarButtonClick);
            this.ToolBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFormKeyDown);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.ToolTipText = "Grafik betrachten";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 1;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.ToolTipText = "Gewichtskurve";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.ToolTipText = "Excel-Informationen";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // Work
            // 
            this.Work.BackColor = System.Drawing.SystemColors.Control;
            this.Work.Location = new System.Drawing.Point(23, 50);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(544, 307);
            this.Work.TabIndex = 3;
            this.Work.Click += new System.EventHandler(this.OnClick);
            this.Work.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.Work.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnWorkMouseMove);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(830, 459);
            this.Controls.Add(this.Work);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.StatusBar);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Sport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnFormKeyDown);
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.sbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelDatei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelAnzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            frmMain app = null;
            app = new frmMain();

            Application.AddMessageFilter(new DMessageFilter(app));
            Application.Run(app);
        }

        private Sport _rv = new Sport();

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
        }

        private List<RVDaten> _arrShownData = new List<RVDaten>();

        private MDI _mdi = new MDI();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var reg = new DRegistry();
            Settings._DataPfad = reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\Sport", "Data", "");

            Settings._DataPfad = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Programmdaten\\Sport\\";

            Settings._Jahr = reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\Sport", "Datei", "");

            if (Settings._DataPfad.Length == 0)
            {
                var tmp = Environment.CurrentDirectory;
                var pos = tmp.LastIndexOf("\\", StringComparison.Ordinal);
                if (pos != -1)
                    tmp = tmp.Substring(0, pos);
                pos = tmp.LastIndexOf("\\", StringComparison.Ordinal);
                if (pos != -1)
                    tmp = tmp.Substring(0, pos + 1);

                var finder = new DFileFind();
                finder.FindFiles(tmp, "*.csv", 1);
                for (var i = 0; i < finder.ArrDir.Count; i++)
                {
                    tmp = finder.ArrDir[i].ToString().ToLower();
                    if (tmp.IndexOf("data", StringComparison.Ordinal) == -1)
                        continue;

                    Settings._DataPfad = tmp + "\\";
                    break;
                }
            }
            if ((Settings._Jahr.Length == 0) && (Settings._DataPfad.Length != 0))
            {
                //DateTime dt=new DateTime();
                Settings._Jahr = DateTime.Now.Year.ToString();
                /*				DFileFind finder =new DFileFind();
                                finder.FindFiles(Settings._DataPfad, "*.csv", 1);
                                if(finder.ArrFiles.Count>0)
                                {
                                    string tmp=finder.ArrFiles[0].ToString();
                                    tmp=System.IO.Path.GetFileName(tmp);
                                    tmp=f.HeadFromList(ref tmp, ".csv");
                                    tmp=tmp.Substring(tmp.Length-4);
                                    Settings._Jahr=tmp;
                                }*/
            }
#if DEBUG
            //				Settings._DataPfad=@"D:\Programme\dNET\RVdv\";
#endif

            _rv.Jahr = Settings._Jahr;
            _rv.Pfad = Settings._DataPfad;
            _rv.Load();

            //			_rv.SaveData();

            sbPanelDatei.Text = Settings._Jahr;
            //			sbPanelAnzahl.Text="Anzahl Daten: " + _rv.RvDaten.Count.ToString();
            sbPanelAnzahl.Text = "Anzahl Daten: (" + _rv.RvDaten.Count + "/" + _rv.HtDaten.Count + "/" + _rv.JoDaten.Count + ")";

            Work.Visible = false;
            Work.BackColor = Color.Black;

            _mdi.AddWindows(this, mainMenu1);

            //			toolTip.SetToolTip(Work, "Es war\r\neinmal");

            //			StatusBar.Panels[1].Text=Settings._Jahr;
        }

        private List<double> _aGewicht = new List<double>();
        private List<double> _avGewicht = new List<double>();

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (!Work.Visible)
                return;

            OnResize(null, null);

            var startY = Work.Bottom - 10 - 90;
            var startX = 40;

            var l = Work.Right - 20 - 40;
            var h = Work.Bottom - 90 - Work.Top + 10 - 40;
            var pen = new Pen(Color.FromArgb(15, 190, 255));

            if (_rvGrafik)
            {
                _arrShownData.Clear();
                var anzDaten = _rv.RvDaten.Count;
                if (anzDaten == 0)
                    return;

                //			Work.BackColor.ToString(

                //			// Create pen.
                //			Pen blackPen = new Pen(Color.Black, 3);
                //			// Create coordinates of points that define line.
                //			float x1 = 100.0F;
                //			float y1 = 100.0F;
                //			float x2 = 500.0F;
                //			float y2 = 100.0F;
                //			// Draw line to screen.
                //			e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
                //			e.Graphics.DrawRectangle(Pens.White,209,-159,1209,1000);
                //			e.Graphics.DrawRectangle(Pens.White,-209,159,1209,1000);
                //			e.Graphics.DrawRectangle(Pens.White,-209,-159,1209,1000);

                //			e.Graphics.DrawRectangle(pen,209,159,1209,1000);

                var hstep = h / 4;
                var step = l / anzDaten;

                //			Pen HELLGRUENBLAU = new Pen(Color.FromArgb(160,250,160));
                //			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(160,250,160)), 10,10,10,10);
                //			e.Graphics.FillRectangle(new SolidBrush(Color.Red), 20,10,10,10);

                for (var a = 0; a < _rv.SdDaten.Count; a++)
                {
                    for (var i = 0; i < _rv.RvDaten.Count; i++)
                    {
                        var rvSDDaten = _rv.SdDaten[a];
                        var rvDaten = _rv.RvDaten[i];
                        if ((rvSDDaten.Strecke == rvDaten.Strecke) || (rvSDDaten.Rundfahrt.ToLower() == rvDaten.Strecke.ToLower()))
                        {
                            _arrShownData.Add(rvDaten);
                        }
                    }
                }

                var oldStrecke = "";
                for (var i = 0; i < _arrShownData.Count; i++)
                {
                    var rvDaten = _arrShownData[i];
                    var durchschnitt = rvDaten.Durchschnitt - 20.0;
                    var total = rvDaten.Total - 20.0;

                    durchschnitt /= 5;
                    durchschnitt *= hstep;

                    total /= 5;
                    total *= hstep;

                    if (durchschnitt > 0.0)
                    {
                        if (total > durchschnitt)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.Red), startX + i * step, startY - (int)total, step, (int)total);
                            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(160, 250, 160)), startX + i * step, startY - (int)durchschnitt, step, (int)durchschnitt);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(160, 250, 160)), startX + i * step, startY - (int)durchschnitt, step, (int)durchschnitt);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Red), startX + i * step, startY - (int)total, step, (int)total);
                        }
                    }
                    else
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(160, 250, 160)), startX + i * step, startY, step, startY - (int)durchschnitt);

                    if (total > 0.0)
                    {
                        //	e.Graphics.FillRectangle(new SolidBrush(Color.Red), startX+i*step,startY-(int)total, step,(int)total);
                    }
                    else
                        e.Graphics.FillRectangle(new SolidBrush(Color.Red), startX + i * step, startY, step, startY - (int)total);

                    if (oldStrecke != rvDaten.Strecke)
                    {
                        //					e.Graphics.FillRectangle(new SolidBrush(Color.Red),startX+1+i*step,startY-2,2,20);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), startX + i * step, 55, 1, startY - 55);
                        e.Graphics.DrawString(rvDaten.Strecke, new Font("Microsoft Sans Serif", 8), new SolidBrush(Color.FromArgb(255, 180, 80)), 40 + i * step + 2, Work.Bottom - 10 - 90 + 1);
                    }
                    oldStrecke = rvDaten.Strecke;
                }

                for (var i = 0; i < h; i++)
                {
                    e.Graphics.DrawRectangle(pen, 30, Work.Bottom - 10 - 90 - (i * hstep), Work.Right - 20 - 30, 1);
                }
                var zahl = 15;
                for (var i = 0; i < h; i++)
                {
                    zahl = zahl + 5;
                    e.Graphics.DrawString(zahl.ToString(), new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 5, Work.Bottom - 10 - 90 - (i * hstep) - 10);
                }

                e.Graphics.DrawLine(pen, 40, Work.Top + 10, 40, Work.Bottom - 90);
                e.Graphics.DrawLine(pen, 41, Work.Top + 10, 41, Work.Bottom - 90);
                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90, Work.Right - 20, Work.Bottom - 90 - 10);
                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90 + 1, Work.Right - 20, Work.Bottom - 90 - 10 + 1);

                for (var i = 0; i < anzDaten; i++)
                {
                    e.Graphics.DrawLine(pen, 40 + i * step, Work.Bottom - 10 - 90 - 5, 40 + i * step, Work.Bottom - 10 - 90 + 5);
                    e.Graphics.DrawLine(pen, 40 + i * step + 1, Work.Bottom - 10 - 90 - 5, 40 + i * step + 1, Work.Bottom - 10 - 90 + 5);

                    //				e.Graphics.DrawString("N", new Font("Microsoft Sans Serif", 8), new SolidBrush(Color.FromArgb(255,180,80)),40+i*step+2,Work.Bottom-10-90+1);
                }
            }
            if (_gewichtskurve)
            {
                var tlht = new Hashtable();
                var trv = new Sport();
                trv.Pfad = Settings._DataPfad;
                trv.Jahr = (f.ConvertToInt(Settings._Jahr) - 1).ToString();

                trv.Load();

                for (var i = 0; i < trv.RvDaten.Count; i++)
                {
                    var rvDaten = trv.RvDaten[i];
                    if (!tlht.ContainsKey(rvDaten.StringDatum))
                        tlht.Add(rvDaten.StringDatum, rvDaten.Gewicht);
                }
                for (var i = 0; i < trv.HtDaten.Count; i++)
                {
                    var rvDaten = trv.HtDaten[i];
                    if (rvDaten.Gewicht == 0.0)
                        continue;

                    if (!tlht.ContainsKey(rvDaten.StringDatum))
                        tlht.Add(rvDaten.StringDatum, rvDaten.Gewicht);
                }
                for (var i = 0; i < trv.JoDaten.Count; i++)
                {
                    var rvDaten = trv.JoDaten[i];
                    if (rvDaten.Gewicht == 0.0)
                        continue;

                    if (!tlht.ContainsKey(rvDaten.StringDatum))
                        tlht.Add(rvDaten.StringDatum, rvDaten.Gewicht);
                }

                _aGewicht.Clear();
                _avGewicht.Clear();
                e.Graphics.DrawLine(pen, 40, Work.Top + 10, 40, Work.Bottom - 90);
                e.Graphics.DrawLine(pen, 41, Work.Top + 10, 41, Work.Bottom - 90);
                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90, Work.Right - 20, Work.Bottom - 90 - 10);
                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90 + 1, Work.Right - 20, Work.Bottom - 90 - 10 + 1);

                var tht = new Hashtable();
                double tKgMin = 200;
                double tKgMax = 0;
                var maxdate = new DateTime(1900, 1, 1);
                for (var i = 0; i < _rv.RvDaten.Count; i++)
                {
                    var rvDaten = _rv.RvDaten[i];
                    if (!tht.ContainsKey(rvDaten.StringDatum))
                        tht.Add(rvDaten.StringDatum, rvDaten.Gewicht);
                    //				tarr.Add(rvDaten.Datum + "-" + rvDaten.Gewicht.ToString());

                    //					if(rvDaten.Gewicht==85.5)
                    //						continue;

                    if (rvDaten.Gewicht > tKgMax)
                        tKgMax = rvDaten.Gewicht;
                    if (rvDaten.Gewicht < tKgMin)
                        tKgMin = rvDaten.Gewicht;

                    if (rvDaten.Datum > maxdate)
                        maxdate = rvDaten.Datum;

                    //				tarr.Add(_rv)
                }
                for (var i = 0; i < _rv.HtDaten.Count; i++)
                {
                    var rvDaten = _rv.HtDaten[i];
                    if (rvDaten.Gewicht == 0.0)
                        continue;

                    if (!tht.ContainsKey(rvDaten.StringDatum))
                        tht.Add(rvDaten.StringDatum, rvDaten.Gewicht);
                    //				tarr.Add(rvDaten.Datum + "-" + rvDaten.Gewicht.ToString());

                    if (rvDaten.Gewicht > tKgMax)
                        tKgMax = rvDaten.Gewicht;
                    if (rvDaten.Gewicht < tKgMin)
                        tKgMin = rvDaten.Gewicht;

                    if (rvDaten.Datum > maxdate)
                        maxdate = rvDaten.Datum;
                }

                for (var i = 0; i < _rv.JoDaten.Count; i++)
                {
                    var rvDaten = _rv.JoDaten[i];
                    if (rvDaten.Gewicht == 0.0)
                        continue;

                    if (!tht.ContainsKey(rvDaten.StringDatum))
                        tht.Add(rvDaten.StringDatum, rvDaten.Gewicht);
                    //				tarr.Add(rvDaten.Datum + "-" + rvDaten.Gewicht.ToString());

                    if (rvDaten.Gewicht > tKgMax)
                        tKgMax = rvDaten.Gewicht;
                    if (rvDaten.Gewicht < tKgMin)
                        tKgMin = rvDaten.Gewicht;

                    if (rvDaten.Datum > maxdate)
                        maxdate = rvDaten.Datum;
                }

                //				Console.WriteLine(tKgMin);

                //				tKgMin=80;
                var startGewicht = 80;
                if (tKgMin <= 80)
                    startGewicht = 75;

                if (tKgMax <= 90)
                    startGewicht = 75;

                //95
                //85
                //80
                //75
                //			//70

                var kg = ((double)h) / 4;
                //			tarr.Sort();

                var ad = DateTime.DaysInMonth(f.ConvertToInt(Settings._Jahr), 2);

                var w = ((double)l) / 366;

                var penRot = new Pen(Color.FromArgb(160, 250, 160));
                //			int ii=0;
                //			e.Graphics.DrawLine(penRot,40 + (int)((double)ii*w),Work.Bottom-10-90,40+(int)((double)(ii+1)*w), Work.Bottom-90-10);

                double gewicht = startGewicht;
                double lgewicht = startGewicht;
                //				double lgewicht=0.0;
                var lpos = -1;
                var llpos = -1;
                var found = false;
                var lfound = false;

                var av = 0.0;
                var days = 0;
                var ldg = 0.0;

                for (var i = 0; i < 366; i++)
                {
                    var dt = new DateTime(f.ConvertToInt(Settings._Jahr), 1, 1);
                    dt = dt.AddDays(i);
                    var day = dt.ToString("yyyyMMdd");
                    if (dt <= maxdate)
                    {
                        if (dt > DateTime.Now)
                            break;

                        //DateTime FormatDate
                        if (tht.ContainsKey(day))
                        {
                            gewicht = (double)tht[day];
                            //if (gewicht!=0.0)
                            found = true;
                        }

                        var tgewicht = gewicht - startGewicht;
                        tgewicht /= 5;
                        tgewicht *= kg;

                        //				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(160,250,160)),40 + (int)((double)i*w),Work.Bottom-10-90-(float)tgewicht, ((int)w)+1, (float)tgewicht);

                        days++;
                        _aGewicht.Add(gewicht);
                        if (found)
                        {
                            av += gewicht;
                            if (lpos == -1)
                                lpos = (int)(Work.Bottom - 90 - 10 - (float)tgewicht);
                            e.Graphics.DrawLine(penRot, 40 + (int)(i * w), lpos, 40 + (int)((i + 1) * w), Work.Bottom - 90 - 10 - (float)tgewicht);
                            lpos = (int)(Work.Bottom - 90 - 10 - (float)tgewicht);
                        }
                    }

                    //DateTime FormatDate
                    var y = f.ConvertToInt(day);
                    y -= 10000;
                    if (tlht.ContainsKey(y.ToString()))
                    {
                        lgewicht = (double)tlht[y.ToString()];
                        //if (lgewicht!=0.0)
                        lfound = true;
                    }

                    var tlgewicht = lgewicht - startGewicht;
                    tlgewicht /= 5;
                    tlgewicht *= kg;

                    _avGewicht.Add(lgewicht);

                    if (lfound)
                    {
                        var pen2 = new Pen(Color.SteelBlue);
                        if (llpos == -1)
                            llpos = (int)(Work.Bottom - 90 - 10 - (float)tlgewicht);
                        e.Graphics.DrawLine(pen2, 40 + (int)(i * w), llpos, 40 + (int)((i + 1) * w), Work.Bottom - 90 - 10 - (float)tlgewicht);
                        llpos = (int)(Work.Bottom - 90 - 10 - (float)tlgewicht);
                    }

                    var dg = 0.0;
                    if (days != 0)
                        dg = av / days;

                    var pldg = ldg - startGewicht;
                    pldg /= 5;
                    pldg *= kg;

                    if (ldg == 0.0)
                    {
                        ldg = dg;
                        continue;
                    }

                    ldg = dg;

                    dg -= startGewicht;
                    dg /= 5;
                    dg *= kg;

                    var rot = new Pen(Color.Red);

                    e.Graphics.DrawLine(rot, 40 + (int)(i * w), Work.Bottom - 90 - 10 - (float)pldg, 40 + (int)((i + 1) * w), Work.Bottom - 90 - 10 - (float)dg);
                }
                var lmonth = 0;
                for (var i = 0; i < 367; i++)
                {
                    var dt = new DateTime(f.ConvertToInt(Settings._Jahr), 1, 1);
                    dt = dt.AddDays(i);
                    if (lmonth != dt.Month)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(15, 190, 255)), 40 + (int)(i * w), Work.Bottom - 90 - 10 - 5, 2, 10);
                    }
                    lmonth = dt.Month;
                }
                av /= days;

                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90 - (int)kg, Work.Right - 20, Work.Bottom - 90 - 10 - (int)kg);
                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90 - 2 * (int)kg, Work.Right - 20, Work.Bottom - 90 - 10 - 2 * (int)kg);
                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90 - 3 * (int)kg, Work.Right - 20, Work.Bottom - 90 - 10 - 3 * (int)kg);
                e.Graphics.DrawLine(pen, 30, Work.Bottom - 10 - 90 - 4 * (int)kg, Work.Right - 20, Work.Bottom - 90 - 10 - 4 * (int)kg);

                var hstep = h / 4;

                var start = 0;
                if (startGewicht == 75)
                    start = hstep * -1;
                //				start=0;
                //				start-=hstep;

                e.Graphics.DrawString("100", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 5, Work.Bottom - 10 - 90 - (4 * hstep) - 10 + start);
                e.Graphics.DrawString("95", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 5, Work.Bottom - 10 - 90 - (3 * hstep) - 10 + start);
                e.Graphics.DrawString("90", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 5, Work.Bottom - 10 - 90 - (2 * hstep) - 10 + start);
                e.Graphics.DrawString("85", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 5, Work.Bottom - 10 - 90 - (1 * hstep) - 10 + start);
                e.Graphics.DrawString("80", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 5, Work.Bottom - 10 - 90 - (0 * hstep) - 10 + start);
                e.Graphics.DrawString("75", new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 5, Work.Bottom - 10 - 90 - (-1 * hstep) - 10 + start);

                var info = "Max: " + tKgMax + ", Min: " + tKgMin + ", Durchschnitt: " + av.ToString("0.00");

                e.Graphics.DrawString(info, new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.FromArgb(255, 180, 80)), 45, Work.Bottom - 10 - 90 - (0 * hstep) - 10 + 20);
                e.Graphics.DrawString(info, new Font("Microsoft Sans Serif", 9), new SolidBrush(Color.Salmon), 45, Work.Bottom - 10 - 90 - (0 * hstep) - 10 + 20);
            }

            //			Settings._Jahr;

            //			Pen hellorange = new Pen(Color.FromArgb(255,180,80));
        }

        private void OnResize(object sender, System.EventArgs e)
        {
            Work.Top = ToolBar.Top + 30;
            Work.Left = 1;

            Work.Height = this.Height - ToolBar.Top - 106;
            Work.Width = this.Width - 11 - 2;
            //StatusBar

            /*
            int l=Work.Left;
            int r=Work.Right;
            int top=Work.Top;//+ToolBar.Height;
            //			int t=this.Top+ToolBar.Height;

            Work.Top=ToolBar.Height;

            int b=0;//hScrollBar.Bottom;
            b=StatusBar.Bottom;
            int h=this.ClientSize.Height;
            Work.Height=h-top-StatusBar.Height;//+ToolBar.Height;

            Work.Height=StatusBar.Height;

            Work.Width=this.Width-8;*/
        }

        private void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Work.Visible = false;
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            if (Work.Visible)
            {
                toolTip.Active = false;
                Work.Visible = false;
            }
            else
                Work.Visible = true;
        }

        private void OnStatusbarMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var aktPanel = DFormHelper.GetStatusbarPanel(StatusBar, e.X, e.Y);

            if (aktPanel == 1)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Arrow;
        }

        private void OnStatusbarMouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void OnStatusBarMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var aktPanel = DFormHelper.GetStatusbarPanel(StatusBar, e.X, e.Y);
            if (aktPanel == 1)
            {
                var dlg = new frmDatei();
                dlg.ShowDialog(this);
                if (dlg.Ok)
                {
                    _rv.Jahr = Settings._Jahr;
                    //					_rv.Pfad=Settings._DataPfad;
                    _rv.Load();

                    sbPanelDatei.Text = Settings._Jahr;
                    sbPanelAnzahl.Text = "Anzahl Daten: (" + _rv.RvDaten.Count + "/" + _rv.HtDaten.Count + "/" + _rv.JoDaten.Count + ")";

                    this.Work.Invalidate();
                }

                sbInfo.Text = "";
            }
        }

        private void OnWorkMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //			this.toolTip.Active=false;

            if (_gewichtskurve)
            {
                if (e.X < 40)
                {
                    toolTip.Active = false;
                    return;
                }

                var l = Work.Right - 20 - 40;
                var pos = e.X - 40;
                var w = l / 366.0;
                var day = (int)(pos / w);
                //				day++;
                //				day++;

                var dt = new DateTime(f.ConvertToInt(Settings._Jahr), 1, 1);
                dt = dt.AddDays(day);

                if ((day + 1) > this._aGewicht.Count)
                {
                    if ((day + 1) > _avGewicht.Count)
                    {
                        this.toolTip.Active = false;
                        return;
                    }
                }

                var sinfo = f.Datum(dt.ToString("yyyMMdd")) + "\r\n";

                if (day >= _aGewicht.Count)
                {
                    sinfo += "\r\n";

                    if (day < _avGewicht.Count)
                        sinfo += "Vorjahr: " + _avGewicht[day] + " Kg";
                    else
                        sinfo += "\r\n";
                }
                else
                {
                    sinfo += "Aktuell: " + _aGewicht[day] + " Kg\r\n";
                    sinfo += "Vorjahr: " + _avGewicht[day] + " Kg";

                    //BMI = Körpergewicht in Kilogramm/(Köpergrösse in Meter)^2

                    var bmi = _aGewicht[day] / 1.83 / 1.83;
                    sinfo += "\r\n\r\nDiff: " + (Math.Round(_aGewicht[day] - _avGewicht[day], 2)) + " Kg";
                    sinfo += "\r\nBMI: " + $"{bmi:F2}";
                }
                var soToolTip = toolTip.GetToolTip(Work);
                if (soToolTip != sinfo)
                    toolTip.SetToolTip(Work, sinfo);
                if (!toolTip.Active)
                    toolTip.Active = true;
            }

            if (_rvGrafik)
            {
                if (e.X < 40)
                {
                    toolTip.Active = false;
                    return;
                }

                var anzDaten = _rv.RvDaten.Count;
                if (anzDaten == 0)
                    return;

                var l = Work.Right - 20 - 40;
                var step = l / anzDaten;

                var info = (e.X - 40) / step;

                if ((info < 0) || (info >= _arrShownData.Count))
                {
                    toolTip.Active = false;
                    return;
                }

                var rvDaten = (RVDaten)_arrShownData[info];

                var sd = _rv.SDInfo(rvDaten.Strecke);
                /*			for(int i=0;i<_rv.SdDaten.Count;i++)
                            {
                            }
                */

                var sinfo = f.Datum(rvDaten.StringDatum) + "\r\n";
                if (sd != null)
                    sinfo += "Rundfahrt: " + sd.Rundfahrt + "\r\n";
                //			sinfo+="Höchst: " + rvDaten.Hoechst.ToString() + "\r\n";
                //			sinfo+="Total: " + rvDaten.Total.ToString() + "\r\n";
                sinfo += "Durchschnitt: " + rvDaten.Durchschnitt + " Km/h\r\n";
                sinfo += "Fahrzeit: " + rvDaten.TotalZeit + " Min.\r\n";
                sinfo += "Gewicht: " + rvDaten.Gewicht + " Kg\r\n";
                if (rvDaten.Bemerkung.Length != 0)
                    sinfo += "Bemerkung: " + rvDaten.Bemerkung + "\r\n";

                sinfo = sinfo.Trim();

                var soToolTip = toolTip.GetToolTip(Work);
                if (soToolTip != sinfo)
                    toolTip.SetToolTip(Work, sinfo);
                if (!toolTip.Active)
                    toolTip.Active = true;
            }
        }

        private bool _rvGrafik;
        private bool _gewichtskurve;

        private void OnMenuClick(object sender, System.EventArgs e)
        {
            _rvGrafik = false;
            _gewichtskurve = false;

            //var mItem=(System.Windows.Forms.MenuItem)(sender);
            var menuText = ((MenuItem)(sender)).Text;
            if (menuText == "Grafik betrachten")
            {
                _rvGrafik = true;
                Work.Visible = true;
                Work.Invalidate();
                return;
            }
            if (menuText == "Gewichtskurve")
            {
                _gewichtskurve = true;
                Work.Visible = true;
                Work.Invalidate();
                return;
            }

            if (menuText == "Kalender")
            {
                var frm = new frmKalender();
                frm.Owner = this.Owner;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }

            Work.Visible = false;

            if (menuText == "Rennvelo")
            {
                var frm = new frmStreckenSortiert();
                frm.Owner = this.Owner;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }
            if (menuText == "Heimtrainer")
            {
                var frm = new frmProtokollHomeTrainer();
                frm.Owner = this.Owner;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }

            if (menuText == "Joggen")
            {
                var frm = new frmProtokollJoggen();
                frm.Owner = this.Owner;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }

            if (menuText == "222")
            {
                var frm = new frmGProtokoll();
                frm.Owner = this.Owner;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }

            if (menuText == "Excel-Informationen")
            {
                var frm = new frmExcelInfo();
                frm.Owner = this.Owner;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }
            if (menuText == "Zwischenzeiten sortiert nach Strecken")
            {
                var frm = new frmProtokoll();
                frm.Owner = this.Owner;
                //				frm.init();
                //				frm.axWebBrowser.Parent=frm.Parent;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }
            if (menuText == "RV-Eingabe")
            {
                var frm = new frmRVEingabe();
                frm.setRV = _rv;
                frm.ShowDialog(this);

                sbPanelAnzahl.Text = "Anzahl Daten: (" + _rv.RvDaten.Count + "/" + _rv.HtDaten.Count + "/" + _rv.JoDaten.Count + ")";
            }
            if (menuText == "HT-Eingabe")
            {
                var frm = new frmHTEingabe();
                frm.setRV = _rv;
                frm.ShowDialog(this);
                sbPanelAnzahl.Text = "Anzahl Daten: (" + _rv.RvDaten.Count + "/" + _rv.HtDaten.Count + "/" + _rv.JoDaten.Count + ")";
            }

            if (menuText == "JO-Eingabe")
            {
                var frm = new frmJOEingabe();
                frm.setRV = _rv;
                frm.ShowDialog(this);
                sbPanelAnzahl.Text = "Anzahl Daten: (" + _rv.RvDaten.Count + "/" + _rv.HtDaten.Count + "/" + _rv.JoDaten.Count + ")";
            }
        }

        private void OnToolBarButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            /*			if(_mdi._hasWindows==false)
                            Settings._IsMdiLayout=false;
                        else
                            Settings._IsMdiLayout=true;
            */
            _rvGrafik = false;
            _gewichtskurve = false;

            if (e.Button.ToolTipText == "Grafik betrachten")
            {
                _rvGrafik = true;
                Work.Visible = true;
                Work.Invalidate();
                return;
            }
            if (e.Button.ToolTipText == "Gewichtskurve")
            {
                _gewichtskurve = true;
                Work.Visible = true;
                Work.Invalidate();
                return;
            }

            Work.Visible = false;
            if (e.Button.ToolTipText == "Excel-Informationen")
            {
                var frm = new frmExcelInfo();
                frm.Owner = this.Owner;
                frm.MdiParent = this;
                frm.setRV = _rv;
                frm.Show();
            }
            this.Focus();
            //			this.Focus()=true;
        }

        private bool IsWorkVisible()
        {
            for (var i = 0; i < this.Controls.Count; i++)
            {
                var cname = this.Controls[i].Name.ToLower();
                if (cname == "work")
                {
                    if (this.Controls[i].Visible)
                        return true;
                }
            }
            return false;
        }

        private void OnFormKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (!IsWorkVisible())
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();
            }
        }

        public bool HandleESC()
        {
            var forms = this.MdiChildren;
            if (forms.Length == 0)
            {
                if (this.OwnedForms.Length != 0)
                    return false;

                if (IsWorkVisible())
                    return false;
                return true;
            }
            return false;
        }

        private void StatusBar_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
    }

    public class DMessageFilter : IMessageFilter
    {
        private readonly frmMain _App;

        public DMessageFilter(frmMain app)
        {
            _App = app;
        }

        public bool PreFilterMessage(ref Message m)
        {
            // 0x100 is the id for the message that is
            // sent when a key is pressed down.
            if (m.Msg == 0x100)
            {
                if ((int)(m.WParam) == (int)Keys.Escape)
                {
                    if (_App.HandleESC())
                    {
                        Application.Exit();
                        return true;
                    }
                    for (var i = 0; i < _App.Controls.Count; i++)
                    {
                        var cname = _App.Controls[i].Name.ToLower();
                        if (cname == "work")
                        {
                            if (_App.Controls[i].Visible)
                            {
                                _App.Controls[i].Visible = false;
                                return true;
                            }
                        }
                        //						}
                    }
                }
            }

            return false;
        }
    }
}