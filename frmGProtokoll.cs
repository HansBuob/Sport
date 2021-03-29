using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using twr;
using f = twr.DFunktionen;

namespace Sport
{
    /// <summary>
    /// Summary description for frmGProtokoll.
    /// </summary>
    public class frmGProtokoll : frmForm//:*/ System.Windows.Forms.Form
    {
        public class SColor
        {
            public SColor()
            {
            }

            public int _x = 0;
            public int _y = 0;
            public int _l = 0;
            public System.Drawing.Color _color;
        }

        private System.ComponentModel.IContainer components;

        public frmGProtokoll()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGProtokoll));
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbwork = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // toolBar
            //
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton4,
            this.toolBarButton2,
            this.toolBarButton3});
            this.toolBar.DropDownArrows = true;
            this.toolBar.ImageList = this.imageList;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new System.Drawing.Size(292, 28);
            this.toolBar.TabIndex = 0;
            //
            // toolBarButton1
            //
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            //
            // toolBarButton4
            //
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            //
            // toolBarButton2
            //
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            //
            // toolBarButton3
            //
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            //
            // imageList
            //
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            //
            // lbwork
            //
            this.lbwork.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwork.Location = new System.Drawing.Point(10, 36);
            this.lbwork.Name = "lbwork";
            this.lbwork.Size = new System.Drawing.Size(225, 184);
            this.lbwork.TabIndex = 1;
            this.lbwork.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            //
            // frmGProtokoll
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.lbwork);
            this.Controls.Add(this.toolBar);
            this.Name = "frmGProtokoll";
            this.Text = "frmGProtokoll";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.frmGProtokoll_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ImageList imageList;

        private Sport _rv = new Sport();

        private int _FontSize = 10;
        private int _AnzZeilen = 30;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.Label lbwork;

        protected virtual void OnInitial()
        {
        }

        private ArrayList _aData = new ArrayList();
        private ArrayList _aColor = new ArrayList();

        public void SetData(int x, int y, double data, int anzZeichen)
        {
            var str = "";
            var format = "0.000000000000000000000000000000";
            if (anzZeichen <= 0)
            {
                str = data.ToString("0");
            }
            else
            {
                format = format.Substring(0, anzZeichen + 2);
                str = data.ToString(format);
            }

            var pos = str.IndexOf(".");
            if (pos != -1)
            {
                var leer = "            ";
                leer = leer.Substring(0, pos) + str;
            }
            else
            {
                x = x - str.Length;
                //				string leer="            ";
                //				leer=leer.Substring(0, str.Length) + str;
            }

            SetData(x, y, str);
        }

        public void SetData(int x, int y, string data)
        {
            for (var i = _aData.Count; i < (y + 1); i++)
                _aData.Add("                                                                                                                           ");

            var tmp = _aData[y].ToString();

            var pos = data.IndexOf(".");
            if (pos != -1)
            {
                if (x > pos)
                    x -= pos;
            }
            if (x < 0) x = 0;

            var start = tmp.Substring(0, x);
            tmp = tmp.Substring(x + data.Length);

            _aData[y] = start + data + tmp;
        }

        private string _Titel = "";
        private Color _TitelColor;

        public void SetTitel(string titel)
        {
            SetTitel(titel, Color.FromArgb(255, 180, 80));
        }

        public void SetTitel(string titel, Color color)
        {
            _Titel = titel;
            //color=Color.FromArgb(255,180,80);
            _TitelColor = color;
        }

        private int _Start = 0;

        public void SetColor(int x, int y, int l, Color color)
        {
            var tcolor = new SColor();
            tcolor._x = x;
            tcolor._y = y;
            tcolor._l = l;
            tcolor._color = color;

            _aColor.Add(tcolor);

            //_aColor.Add(x.ToString() + "-" + y.ToString()

            //			for(int i=_aData.Count;i<(y+1);i++)
            //				_aData.Add("                                                                                                                           ");

            //			string tmp=_aData[y].ToString();

            //			string start=tmp.Substring(0,x);
            //			tmp=tmp.Substring(x+data.Length);

            //			_aData[y]=start + data + tmp;
        }

        static public int MeasureDisplayStringWidth(Graphics graphics, string text,
            Font font)
        {
            const int width = 32;

            var bitmap = new System.Drawing.Bitmap(width, 1,
                graphics);
            var size = graphics.MeasureString(text, font);
            var anagra = System.Drawing.Graphics.FromImage(bitmap);

            var measured_width = (int)size.Width;

            if (anagra != null)
            {
                anagra.Clear(Color.White);
                anagra.DrawString(text + "|", font, Brushes.Black,
                    width - measured_width, -font.Height / 2);

                for (var i = width - 1; i >= 0; i--)
                {
                    measured_width--;
                    if (bitmap.GetPixel(i, 0).R != 255)    // found a non-white pixel ?
                        break;
                }
            }

            return measured_width;
        }

        private bool _Rahmen = false;

        private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //			ArrayList _aData=new ArrayList();
            //			_aData.Add("Zeit1   ZW1-2  Zeit2   ZW2-3  Zeit3   ZW3-4  Zeit4   ZW4-5  Zeit5   ZW5-6  ");
            //			_aData.Add("10.23");
            //			_aData.Add(" 9.57");

            var start = 0;
            if (toolBar.Visible)
                start = toolBar.Height;

            //			e.Graphics.FillRectangle(new SolidBrush(Color.FromKnownColor(System.Drawing.KnownColor.Control)),0,0,this.Width-8, this.Height-28-4);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), 5, 5, this.Width - 8 - 10, this.Height - 28 - 4 - 10);
            var pen = new Pen(Color.White);
            if (_Rahmen)
                e.Graphics.DrawRectangle(pen, 10 + 5, 10 + 5, lbwork.Width - 16 - 10, lbwork.Height - 15 - 10);// . 5+5,5+5,lbwork.Leftthis.Width-8-10-10-20, this.Height-28-4-10-10-60);
                                                                                                               //			e.Graphics.DrawRectangle(pen,5+5,5+5,this.Width-8-10-10-20, this.Height-28-4-10-10-60);
                                                                                                               //			e.Graphics.FillRectangle(new SolidBrush(Color.White),5,5,this.Width-8-10, this.Height-28-4-10);

            var font = new Font("Courier New", _FontSize);

            var diff = MeasureDisplayStringWidth(e.Graphics, "ii", font) - MeasureDisplayStringWidth(e.Graphics, "i", font);
            var fontHeight = (int)e.Graphics.MeasureString("i", font).Height;
            //			ww=MeasureDisplayStringWidth(e.Graphics, "w", font);

            var startX = 8 + 5;
            var startY = fontHeight - 10 - 4 + 5;

            //			e.Graphics.DrawString("TWR", font, new SolidBrush(Color.Yellow),10-2, fontHeight-10-4);
            //			e.Graphics.DrawString("WWW", font, new SolidBrush(Color.Yellow),10-2, fontHeight-10-4+fontHeight);
            //			e.Graphics.DrawString("iw-", font, new SolidBrush(Color.Black),20, 10 +5 + fontHeight);

            if (_Titel.Length != 0)
                e.Graphics.DrawString(_Titel, font, new SolidBrush(_TitelColor), startX, startY);
            //			e.Graphics.DrawString(_Titel, font, new SolidBrush(_TitelColor),3+5-2-2+1, 10 +5);

            var end = (_Start + 1) * _AnzZeilen;
            if (end > _aData.Count)
                end = _aData.Count;
            for (var i = (_Start * _AnzZeilen); i < end; i++)
            //			for(int i=0;i<_aData.Count;i++)
            {
                var apos = i * fontHeight - (_Start * _AnzZeilen) * fontHeight + startY;
                e.Graphics.DrawString(_aData[i].ToString(), font, new SolidBrush(Color.FromArgb(15, 190, 255)), startX, startY + apos + _FontSize - 5);

                //				int apos=i*20-(_Start*_AnzZeilen)*20+20;
                //				e.Graphics.DrawString(_aData[i].ToString(), font, new SolidBrush(Color.FromArgb(15,190,255)), 5+1, 10 +5+ apos);

                //				e.Graphics.DrawString(_aData[i].ToString(), font, new SolidBrush(Color.FromArgb(15,190,255)), 5+1, 10 +5+ apos);
                //				Console.WriteLine(_aData[i].ToString());
            }

            //			for(int i=0;i<_aColor.Count;i++)
            //			{
            //				SColor tcolor=(SColor)_aColor[i];
            //
            //				string text=_aData[tcolor._y].ToString();
            //				text=text.Substring(tcolor._x, tcolor._l);
            //
            //
            //				float len=e.Graphics.MeasureString("_", font).Width;
            //				len=len-4;
            //
            //				int strlen=(int)e.Graphics.MeasureString("w", font).Width;
            ////				strlen-=1;
            //
            //				strlen=10;
            //				int xstart=10*tcolor._x+1;
            //
            ////				int xstart=(int)(len*(double)(tcolor._x));
            ////				e.Graphics.FillRectangle(new SolidBrush(Color.Black),xstart, 10 +5+ tcolor._y*20, strlen, 20);
            //				e.Graphics.FillRectangle(new SolidBrush(Color.Black),xstart+3+5, 10 +5+ tcolor._y*20, text.Length*strlen, 20);
            //
            ////				e.Graphics.DrawString(text, font, new SolidBrush(tcolor._color), 5+tcolor._x*_FontSize, 10 +5+ tcolor._y*20);
            //				e.Graphics.DrawString(text, font, new SolidBrush(tcolor._color), xstart+3+5-2-2+1, 10 +5+ tcolor._y*20);
            //
            //			}

            /*
                        e.Graphics.DrawString("abc2", new Font("Courier New", _FontSize), new SolidBrush(Color.FromArgb(255,180,80)), 0,28);
                        e.Graphics.DrawString("mwei", new Font("Courier New", _FontSize), new SolidBrush(Color.FromArgb(255,180,80)), 0,44);
                        e.Graphics.DrawString("14", new Font("Courier New", _FontSize), new SolidBrush(Color.FromArgb(255,180,80)), 0,60);
                        e.Graphics.DrawString("1234", new Font("Courier New", _FontSize), new SolidBrush(Color.FromArgb(255,180,80)), 0,76);
            */
        }

        private void OnResize(object sender, System.EventArgs e)
        {
            lbwork.Left = 5;
            lbwork.Top = toolBar.Height + 5;
            lbwork.Width = this.Width - 5 - 5 - 10;
            lbwork.Height = this.Height - toolBar.Height - 45;
        }

        private void frmGProtokoll_Load(object sender, System.EventArgs e)
        {
            OnInitial();
            var dialogname = this.Text;
            if (dialogname.IndexOf("(") != -1)
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

            var fontsize = f.ConvertToInt(reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "fontsize"));

            if (fontsize < 4)
                _FontSize = 10;
            else
                _FontSize = fontsize;

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            OnResize(null, null);
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
                return;

            if (Settings._IsMdiLayout)
                return;

            var dialogname = this.Text;
            if (dialogname.IndexOf("(") != -1)
                dialogname = f.HeadFromList(ref dialogname, "(");

            var reg = new DRegistry();
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "width", Width.ToString());
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "height", Height.ToString());
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "fontsize", _FontSize.ToString());
        }

        private void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                if (((_Start + 1) * _AnzZeilen) > _aData.Count)
                {
                    _Start = 0;
                }
                else
                    _Start += 1;
                lbwork.Invalidate();
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta < 0)
                _FontSize++;
            else
            {
                if (_FontSize < 2)
                    return;
                _FontSize--;
            }

            lbwork.Invalidate();

            base.OnMouseWheel(e);
        }

        public Sport setRV
        {
            set
            {
                _rv = value;
            }
        }
    }
}