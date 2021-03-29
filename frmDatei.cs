using System;
using System.Collections;
using System.Windows.Forms;

using twr;
using f = twr.DFunktionen;

namespace Sport
{
    /// <summary>
    /// Summary description for frmDatei.
    /// </summary>
    public class frmDatei : frmForm//: System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDatei;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label lblDatei;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmDatei()
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
            this.lbDatei = new System.Windows.Forms.ListBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lblDatei = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wählen Sie aus mit welcher Datei das Programm gestartet werden soll.";
            //
            // lbDatei
            //
            this.lbDatei.Location = new System.Drawing.Point(3, 36);
            this.lbDatei.Name = "lbDatei";
            this.lbDatei.Size = new System.Drawing.Size(517, 134);
            this.lbDatei.TabIndex = 1;
            this.lbDatei.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.lbDatei.DoubleClick += new System.EventHandler(this.OnDoubleKlick);
            //
            // cmdOK
            //
            this.cmdOK.Location = new System.Drawing.Point(452, 224);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(68, 22);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "Ok";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            //
            // lblDatei
            //
            this.lblDatei.Location = new System.Drawing.Point(5, 184);
            this.lblDatei.Name = "lblDatei";
            this.lblDatei.Size = new System.Drawing.Size(515, 36);
            this.lblDatei.TabIndex = 3;
            this.lblDatei.Text = "label2";
            //
            // frmDatei
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(522, 249);
            this.Controls.Add(this.lblDatei);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lbDatei);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatei";
            this.Text = "Datei";
            this.Load += new System.EventHandler(this.frmDatei_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private void frmDatei_Load(object sender, System.EventArgs e)
        {
            lblDatei.Text = Settings._DataPfad;

            var finder = new DFileFind();
            //			finder.FindFiles(Settings._DataPfad, "RV-*.csv", 0);
            finder.FindFiles(Settings._DataPfad, "*-*.csv", 1);
            finder.ArrFiles.Sort();

            //			lbDatei.Sorted=true;
            var add = false;

            var arr = new ArrayList();

            for (var i = 0; i < finder.ArrFiles.Count; i++)
            {
                var tmp = finder.ArrFiles[finder.ArrFiles.Count - i - 1].ToString();
                if (!tmp.ToLower().EndsWith(".csv"))
                    continue;

                var ttmp = System.IO.Path.GetFileName(tmp);
                tmp = f.HeadFromList(ref tmp, "\\" + ttmp);
                tmp = System.IO.Path.GetFileName(tmp);
                //f.HeadFromList(ref tmp, "-");
                //				f.HeadFromList(ref tmp, "\\");
                //				if(!lbDatei.Items.Contains(tmp))
                //					lbDatei.Items.Add(tmp);

                if (!arr.Contains(tmp))
                    arr.Add(tmp);

                if (tmp == DateTime.Now.Year.ToString())
                    add = false;
            }
            if (add)
                arr.Add(DateTime.Now.Year.ToString());

            arr.Sort();
            for (var i = 0; i < arr.Count; i++)
                lbDatei.Items.Add(arr[arr.Count - i - 1].ToString());

            //				lbDatei.Items.Add(DateTime.Now.Year.ToString());

            lbDatei.SelectedItem = Settings._Jahr;
        }

        protected override void HandleEnter()
        {
            cmdOK_Click(null, null);
        }

        private void cmdOK_Click(object sender, System.EventArgs e)
        {
            _Ok = true;
            Settings._Jahr = lbDatei.SelectedItem.ToString();

            var reg = new DRegistry();
            reg.WriteProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\Sport", "Datei", Settings._Jahr);

            this.Close();
        }

        private void OnDoubleKlick(object sender, System.EventArgs e)
        {
            cmdOK_Click(null, null);
        }

        private void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                cmdOK_Click(null, null);
        }
    }
}