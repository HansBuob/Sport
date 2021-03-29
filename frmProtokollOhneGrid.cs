using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using twr;
using f=twr.DFunktionen;
using Sport;

namespace Sport
{
    
    /// <summary>
    /// Summary description for frmProtokollOhneGrid.
    /// </summary>
    public class frmProtokollOhneGrid : frmForm//: System.Windows.Forms.Form
    {
        public class SColor
        {
            public SColor(){}

            public int _x=0;
            public int _y=0;
            public int _l=0;
            public System.Drawing.Color _color;
        }

        private System.Windows.Forms.RichTextBox richTextBox;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmProtokollOhneGrid()
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
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Black;
            this.richTextBox.Font = new System.Drawing.Font("Courier New", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.richTextBox.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(15)), ((System.Byte)(190)), ((System.Byte)(255)));
            this.richTextBox.Location = new System.Drawing.Point(8, 8);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(660, 268);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            // 
            // frmProtokollOhneGrid
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(670, 336);
            this.Controls.Add(this.richTextBox);
            this.Name = "frmProtokollOhneGrid";
            this.Text = "frmProtokollOhneGrid";
            this.Resize += new System.EventHandler(this.OnResize);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.frmProtokollOhneGrid_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);

        }
        #endregion

        ArrayList _aData=new ArrayList();
        ArrayList _aColor=new ArrayList();

        public void SetData(int x, int y, double data, int anzZeichen)
        {
            var str="";
            var format="0.000000000000000000000000000000";
            if(anzZeichen<=0)
            {
                str=data.ToString("0");
            }
            else
            {
                format=format.Substring(0, anzZeichen +2);
                str=data.ToString(format);
            }

            var pos=str.IndexOf(".");
            if(pos!=-1)
            {
                var leer="            ";
                leer=leer.Substring(0, pos) + str;
            }

            SetData(x, y, str);
        }

        public void SetData(int x, int y, string data)
        {
            for(var i=_aData.Count;i<(y+1);i++)
                _aData.Add("                                                                                                                           ");

            var tmp=_aData[y].ToString();

            var pos=data.IndexOf(".");
            if(pos!=-1)
            {
                if(x>pos)
                    x-=pos;
            }
            if(x<0)x=0;

            var start=tmp.Substring(0,x);
            tmp=tmp.Substring(x+data.Length);


            _aData[y]=start + data + tmp;
        }
        public void SetColor(int x, int y, int l, Color color)
        {
            var tcolor=new SColor();
            tcolor._x=x;
            tcolor._y=y;
            tcolor._l=l;
            tcolor._color=color;

            _aColor.Add(tcolor);
            
            //_aColor.Add(x.ToString() + "-" + y.ToString() 

//			for(int i=_aData.Count;i<(y+1);i++)
//				_aData.Add("                                                                                                                           ");

//			string tmp=_aData[y].ToString();

//			string start=tmp.Substring(0,x);
//			tmp=tmp.Substring(x+data.Length);


//			_aData[y]=start + data + tmp;
        }

        protected virtual void OnInitial()
        {
        }

            
        public void frmProtokollOhneGrid_Load(object sender, System.EventArgs e)
        { 
            richTextBox.Visible=false;

            OnInitial();
//			label.Refresh();

            var dialogname=this.Text;
            if(dialogname.IndexOf("(")!=-1)
                dialogname=f.HeadFromList(ref dialogname, "(");

            var reg=new DRegistry();
            var width=f.ConvertToInt(reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "width"));
            if(width>100)
                this.Width=width;
            var height=f.ConvertToInt(reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "height"));
            if(height>100)
                this.Height=height;

            
            this.MaximizeBox=true;
            this.MinimizeBox=true;


            
            



            richTextBox.Text="";
            for(var i=0;i<_aData.Count;i++)
            {
                richTextBox.Text+=_aData[i].ToString().Substring(0,100) + "\r\n";
                //SetData
            }
    

            var line="";
            line=richTextBox.Text;
            line=line.TrimEnd();
            line=line.Replace("\n", "\r\n");
            line+="\r\n";
            richTextBox.Text="";
            for(;;)
            {
                if(line.IndexOf("\r\n")==-1)
                    break;

                var tmp=f.HeadFromList(ref line, "\r\n", false);

                tmp+="                                                                                                             ";
                tmp=tmp.Substring(0,100);
                richTextBox.Text+=tmp+="\r\n";

            }

            for(var i=0;i<_aColor.Count;i++)
            {

                var color=(SColor)_aColor[i];
                richTextBox.SelectionStart=color._y*100+color._y+color._x;
                richTextBox.SelectionLength=color._l;
                richTextBox.SelectionColor=color._color;
            }

//			richTextBox.Select(0,100);
//			richTextBox.SelectionColor=Color.FromArgb(255,180,80);
            richTextBox.Select(0,0);

            richTextBox.Visible=true;
            OnResize(null, null);

        }

        private void OnResize(object sender, System.EventArgs e)
        {
            richTextBox.Width=this.Width-3*richTextBox.Left;
            richTextBox.Height=this.Height-3*richTextBox.Top-22;

/*			label.Left=richTextBox.Left;
            label.Top=richTextBox.Top;
            label.Width=richTextBox.Width;
            label.Height=richTextBox.Height;*/
        
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(this.WindowState!=FormWindowState.Normal)
                return;

//			frmMain(this.Parent)._mdi;
            if(Settings._IsMdiLayout)
                return;

            var dialogname=this.Text;
            if(dialogname.IndexOf("(")!=-1)
                dialogname=f.HeadFromList(ref dialogname, "(");

            var reg=new DRegistry();
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "width", Width.ToString());
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV\\Dialog\\" + dialogname, "height", Height.ToString());
        }

        private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
//			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0,0,0)),richTextBox.Left, richTextBox.Top, richTextBox.Width, richTextBox.Height);
            /*			label.Left=richTextBox.Left;
            label.Top=richTextBox.Top;
            label.Width=richTextBox.Width;
            label.Height=richTextBox.Height;*/

        }
    }

}
