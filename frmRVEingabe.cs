using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using twr;
using f=twr.DFunktionen;
using Sport;
using twr.common;

namespace Sport
{
	/// <summary>
	/// Summary description for frmRVEingabe.
	/// </summary>
	public class frmRVEingabe : frmForm//System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private TwrControlLibrary.AutoCompleteComboBox cbStrecke;
		private System.Windows.Forms.Label lbZwischenOrt1;
		private System.Windows.Forms.Label lbZwischenOrt2;
		private System.Windows.Forms.Label lbZwischenOrt3;
		private System.Windows.Forms.Label lbZwischenOrt4;
		private System.Windows.Forms.Label lbZwischenOrt5;
		private System.Windows.Forms.Label lbZwischenOrt6;
		private System.Windows.Forms.Label lbZwischenOrt7;
		private TwrControlLibrary.DNumTextBox tbZwischenZeit1;
		private TwrControlLibrary.DNumTextBox tbZwischenZeit2;
		private TwrControlLibrary.DNumTextBox tbZwischenZeit3;
		private TwrControlLibrary.DNumTextBox tbZwischenZeit4;
		private TwrControlLibrary.DNumTextBox tbZwischenZeit5;
		private TwrControlLibrary.DNumTextBox tbZwischenZeit6;
		private TwrControlLibrary.DNumTextBox tbZwischenZeit7;
		private System.Windows.Forms.Label lbMessposition1;
		private System.Windows.Forms.Label lbMessposition2;
		private System.Windows.Forms.Label lbMessposition3;
		private System.Windows.Forms.Label lbMessposition4;
		private System.Windows.Forms.Label lbMessposition5;
		private System.Windows.Forms.Label lbMessposition6;
		private System.Windows.Forms.Label lbMessposition7;
		private System.Windows.Forms.Label lbKmh1;
		private System.Windows.Forms.Label lbKmh2;
		private System.Windows.Forms.Label lbKmh3;
		private System.Windows.Forms.Label lbKmh4;
		private System.Windows.Forms.Label lbKmh5;
		private System.Windows.Forms.Label lbKmh6;
		private System.Windows.Forms.Label lbKmh7;
		private System.Windows.Forms.Label lbMessPos1;
		private System.Windows.Forms.Label lbMessPos2;
		private System.Windows.Forms.Label lbMessPos3;
		private System.Windows.Forms.Label lbMessPos4;
		private System.Windows.Forms.Label lbMessPos5;
		private System.Windows.Forms.Label lbMessPos6;
		private System.Windows.Forms.Label lbMessPos7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbKommentar;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.Button cmdClose;
		private TwrControlLibrary.DNumTextBox tbDurchschnitt;
		private TwrControlLibrary.DNumTextBox tbAS;
		private TwrControlLibrary.DNumTextBox tbHoechst;
		private TwrControlLibrary.DNumTextBox tbGewicht;
		private System.Windows.Forms.DateTimePicker dtDatum;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.TextBox tbASn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRVEingabe()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public Sport setRV
		{
			set
			{
				_rv=value;
			}
		}

		Sport _rv=new Sport();
		double _pos1=0.0;
		double _pos2=0.0;
		double _pos3=0.0;
		double _pos4=0.0;
		double _pos5=0.0;
		double _pos6=0.0;
		double _pos7=0.0;

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
			this.label1 = new System.Windows.Forms.Label();
			this.lbMessposition1 = new System.Windows.Forms.Label();
			this.lbMessposition2 = new System.Windows.Forms.Label();
			this.lbMessposition3 = new System.Windows.Forms.Label();
			this.lbMessposition4 = new System.Windows.Forms.Label();
			this.lbMessposition5 = new System.Windows.Forms.Label();
			this.lbMessposition6 = new System.Windows.Forms.Label();
			this.lbMessposition7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbKmh1 = new System.Windows.Forms.Label();
			this.lbKmh2 = new System.Windows.Forms.Label();
			this.lbKmh3 = new System.Windows.Forms.Label();
			this.lbKmh4 = new System.Windows.Forms.Label();
			this.lbKmh5 = new System.Windows.Forms.Label();
			this.lbKmh6 = new System.Windows.Forms.Label();
			this.lbKmh7 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.lbZwischenOrt1 = new System.Windows.Forms.Label();
			this.lbZwischenOrt2 = new System.Windows.Forms.Label();
			this.lbZwischenOrt3 = new System.Windows.Forms.Label();
			this.lbZwischenOrt4 = new System.Windows.Forms.Label();
			this.lbZwischenOrt5 = new System.Windows.Forms.Label();
			this.lbZwischenOrt6 = new System.Windows.Forms.Label();
			this.cbStrecke = new TwrControlLibrary.AutoCompleteComboBox();
			this.lbZwischenOrt7 = new System.Windows.Forms.Label();
			this.dtDatum = new System.Windows.Forms.DateTimePicker();
			this.tbZwischenZeit1 = new TwrControlLibrary.DNumTextBox();
			this.tbZwischenZeit2 = new TwrControlLibrary.DNumTextBox();
			this.tbZwischenZeit3 = new TwrControlLibrary.DNumTextBox();
			this.tbZwischenZeit4 = new TwrControlLibrary.DNumTextBox();
			this.tbZwischenZeit5 = new TwrControlLibrary.DNumTextBox();
			this.tbZwischenZeit6 = new TwrControlLibrary.DNumTextBox();
			this.tbDurchschnitt = new TwrControlLibrary.DNumTextBox();
			this.tbAS = new TwrControlLibrary.DNumTextBox();
			this.tbHoechst = new TwrControlLibrary.DNumTextBox();
			this.tbGewicht = new TwrControlLibrary.DNumTextBox();
			this.tbZwischenZeit7 = new TwrControlLibrary.DNumTextBox();
			this.lbMessPos1 = new System.Windows.Forms.Label();
			this.lbMessPos2 = new System.Windows.Forms.Label();
			this.lbMessPos3 = new System.Windows.Forms.Label();
			this.lbMessPos4 = new System.Windows.Forms.Label();
			this.lbMessPos5 = new System.Windows.Forms.Label();
			this.lbMessPos6 = new System.Windows.Forms.Label();
			this.lbMessPos7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbKommentar = new System.Windows.Forms.TextBox();
			this.cmdOk = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.tbASn = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(342, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Messposition";
			// 
			// lbMessposition1
			// 
			this.lbMessposition1.Location = new System.Drawing.Point(342, 42);
			this.lbMessposition1.Name = "lbMessposition1";
			this.lbMessposition1.Size = new System.Drawing.Size(111, 13);
			this.lbMessposition1.TabIndex = 1;
			this.lbMessposition1.Text = "label2";
			// 
			// lbMessposition2
			// 
			this.lbMessposition2.Location = new System.Drawing.Point(342, 61);
			this.lbMessposition2.Name = "lbMessposition2";
			this.lbMessposition2.Size = new System.Drawing.Size(111, 14);
			this.lbMessposition2.TabIndex = 2;
			this.lbMessposition2.Text = "label3";
			// 
			// lbMessposition3
			// 
			this.lbMessposition3.Location = new System.Drawing.Point(342, 80);
			this.lbMessposition3.Name = "lbMessposition3";
			this.lbMessposition3.Size = new System.Drawing.Size(111, 14);
			this.lbMessposition3.TabIndex = 3;
			this.lbMessposition3.Text = "label4";
			// 
			// lbMessposition4
			// 
			this.lbMessposition4.Location = new System.Drawing.Point(342, 99);
			this.lbMessposition4.Name = "lbMessposition4";
			this.lbMessposition4.Size = new System.Drawing.Size(111, 14);
			this.lbMessposition4.TabIndex = 4;
			this.lbMessposition4.Text = "label5";
			// 
			// lbMessposition5
			// 
			this.lbMessposition5.Location = new System.Drawing.Point(342, 118);
			this.lbMessposition5.Name = "lbMessposition5";
			this.lbMessposition5.Size = new System.Drawing.Size(111, 14);
			this.lbMessposition5.TabIndex = 5;
			this.lbMessposition5.Text = "label6";
			// 
			// lbMessposition6
			// 
			this.lbMessposition6.Location = new System.Drawing.Point(342, 137);
			this.lbMessposition6.Name = "lbMessposition6";
			this.lbMessposition6.Size = new System.Drawing.Size(111, 14);
			this.lbMessposition6.TabIndex = 6;
			this.lbMessposition6.Text = "label7";
			// 
			// lbMessposition7
			// 
			this.lbMessposition7.Location = new System.Drawing.Point(342, 156);
			this.lbMessposition7.Name = "lbMessposition7";
			this.lbMessposition7.Size = new System.Drawing.Size(111, 14);
			this.lbMessposition7.TabIndex = 7;
			this.lbMessposition7.Text = "label8";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(463, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Km/h";
			// 
			// lbKmh1
			// 
			this.lbKmh1.Location = new System.Drawing.Point(463, 42);
			this.lbKmh1.Name = "lbKmh1";
			this.lbKmh1.Size = new System.Drawing.Size(112, 13);
			this.lbKmh1.TabIndex = 9;
			this.lbKmh1.Text = "label10";
			// 
			// lbKmh2
			// 
			this.lbKmh2.Location = new System.Drawing.Point(463, 61);
			this.lbKmh2.Name = "lbKmh2";
			this.lbKmh2.Size = new System.Drawing.Size(112, 14);
			this.lbKmh2.TabIndex = 10;
			this.lbKmh2.Text = "label11";
			// 
			// lbKmh3
			// 
			this.lbKmh3.Location = new System.Drawing.Point(463, 80);
			this.lbKmh3.Name = "lbKmh3";
			this.lbKmh3.Size = new System.Drawing.Size(112, 14);
			this.lbKmh3.TabIndex = 11;
			this.lbKmh3.Text = "label12";
			// 
			// lbKmh4
			// 
			this.lbKmh4.Location = new System.Drawing.Point(463, 99);
			this.lbKmh4.Name = "lbKmh4";
			this.lbKmh4.Size = new System.Drawing.Size(112, 14);
			this.lbKmh4.TabIndex = 12;
			this.lbKmh4.Text = "label13";
			// 
			// lbKmh5
			// 
			this.lbKmh5.Location = new System.Drawing.Point(463, 118);
			this.lbKmh5.Name = "lbKmh5";
			this.lbKmh5.Size = new System.Drawing.Size(112, 14);
			this.lbKmh5.TabIndex = 13;
			this.lbKmh5.Text = "label14";
			// 
			// lbKmh6
			// 
			this.lbKmh6.Location = new System.Drawing.Point(463, 137);
			this.lbKmh6.Name = "lbKmh6";
			this.lbKmh6.Size = new System.Drawing.Size(112, 14);
			this.lbKmh6.TabIndex = 14;
			this.lbKmh6.Text = "label15";
			// 
			// lbKmh7
			// 
			this.lbKmh7.Location = new System.Drawing.Point(463, 156);
			this.lbKmh7.Name = "lbKmh7";
			this.lbKmh7.Size = new System.Drawing.Size(112, 14);
			this.lbKmh7.TabIndex = 15;
			this.lbKmh7.Text = "label16";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(10, 10);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(112, 14);
			this.label17.TabIndex = 16;
			this.label17.Text = "Strecke:";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(10, 31);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(112, 14);
			this.label18.TabIndex = 17;
			this.label18.Text = "Durchschnitt:";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(10, 52);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(112, 14);
			this.label19.TabIndex = 18;
			this.label19.Text = "AS:";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(10, 73);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(112, 14);
			this.label20.TabIndex = 19;
			this.label20.Text = "Höchst:";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(10, 94);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(112, 13);
			this.label21.TabIndex = 20;
			this.label21.Text = "Gewicht:";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(10, 114);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(112, 14);
			this.label22.TabIndex = 21;
			this.label22.Text = "Datum:";
			// 
			// lbZwischenOrt1
			// 
			this.lbZwischenOrt1.Location = new System.Drawing.Point(10, 135);
			this.lbZwischenOrt1.Name = "lbZwischenOrt1";
			this.lbZwischenOrt1.Size = new System.Drawing.Size(112, 14);
			this.lbZwischenOrt1.TabIndex = 22;
			this.lbZwischenOrt1.Text = "Zeit-";
			// 
			// lbZwischenOrt2
			// 
			this.lbZwischenOrt2.Location = new System.Drawing.Point(10, 156);
			this.lbZwischenOrt2.Name = "lbZwischenOrt2";
			this.lbZwischenOrt2.Size = new System.Drawing.Size(112, 14);
			this.lbZwischenOrt2.TabIndex = 23;
			this.lbZwischenOrt2.Text = "Zeit-";
			// 
			// lbZwischenOrt3
			// 
			this.lbZwischenOrt3.Location = new System.Drawing.Point(10, 177);
			this.lbZwischenOrt3.Name = "lbZwischenOrt3";
			this.lbZwischenOrt3.Size = new System.Drawing.Size(112, 14);
			this.lbZwischenOrt3.TabIndex = 24;
			this.lbZwischenOrt3.Text = "Zeit-";
			// 
			// lbZwischenOrt4
			// 
			this.lbZwischenOrt4.Location = new System.Drawing.Point(10, 198);
			this.lbZwischenOrt4.Name = "lbZwischenOrt4";
			this.lbZwischenOrt4.Size = new System.Drawing.Size(112, 13);
			this.lbZwischenOrt4.TabIndex = 25;
			this.lbZwischenOrt4.Text = "Zeit-";
			// 
			// lbZwischenOrt5
			// 
			this.lbZwischenOrt5.Location = new System.Drawing.Point(10, 218);
			this.lbZwischenOrt5.Name = "lbZwischenOrt5";
			this.lbZwischenOrt5.Size = new System.Drawing.Size(112, 14);
			this.lbZwischenOrt5.TabIndex = 26;
			this.lbZwischenOrt5.Text = "Zeit-";
			// 
			// lbZwischenOrt6
			// 
			this.lbZwischenOrt6.Location = new System.Drawing.Point(10, 239);
			this.lbZwischenOrt6.Name = "lbZwischenOrt6";
			this.lbZwischenOrt6.Size = new System.Drawing.Size(112, 14);
			this.lbZwischenOrt6.TabIndex = 27;
			this.lbZwischenOrt6.Text = "Zeit-";
			// 
			// cbStrecke
			// 
			this.cbStrecke.LimitToList = true;
			this.cbStrecke.Location = new System.Drawing.Point(128, 7);
			this.cbStrecke.Name = "cbStrecke";
			this.cbStrecke.Size = new System.Drawing.Size(137, 21);
			this.cbStrecke.Sorted = true;
			this.cbStrecke.TabIndex = 0;
			this.cbStrecke.Text = "comboBox1";
			this.cbStrecke.Leave += new System.EventHandler(this.OnLeaveStrecke);
			this.cbStrecke.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChangedStrecke);
			// 
			// lbZwischenOrt7
			// 
			this.lbZwischenOrt7.Location = new System.Drawing.Point(10, 260);
			this.lbZwischenOrt7.Name = "lbZwischenOrt7";
			this.lbZwischenOrt7.Size = new System.Drawing.Size(112, 14);
			this.lbZwischenOrt7.TabIndex = 29;
			this.lbZwischenOrt7.Text = "Zeit-";
			// 
			// dtDatum
			// 
			this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDatum.Location = new System.Drawing.Point(128, 113);
			this.dtDatum.Name = "dtDatum";
			this.dtDatum.Size = new System.Drawing.Size(100, 20);
			this.dtDatum.TabIndex = 5;
			// 
			// tbZwischenZeit1
			// 
			this.tbZwischenZeit1.Location = new System.Drawing.Point(128, 133);
			this.tbZwischenZeit1.Name = "tbZwischenZeit1";
			this.tbZwischenZeit1.Size = new System.Drawing.Size(84, 20);
			this.tbZwischenZeit1.TabIndex = 6;
			this.tbZwischenZeit1.Text = "0.00";
			this.tbZwischenZeit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbZwischenZeit1.Leave += new System.EventHandler(this.OnLeaveZwischenZeit1);
			// 
			// tbZwischenZeit2
			// 
			this.tbZwischenZeit2.Location = new System.Drawing.Point(128, 154);
			this.tbZwischenZeit2.Name = "tbZwischenZeit2";
			this.tbZwischenZeit2.Size = new System.Drawing.Size(84, 20);
			this.tbZwischenZeit2.TabIndex = 7;
			this.tbZwischenZeit2.Text = "0.00";
			this.tbZwischenZeit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbZwischenZeit2.Leave += new System.EventHandler(this.OnLeaveZwischenZeit2);
			// 
			// tbZwischenZeit3
			// 
			this.tbZwischenZeit3.Location = new System.Drawing.Point(128, 175);
			this.tbZwischenZeit3.Name = "tbZwischenZeit3";
			this.tbZwischenZeit3.Size = new System.Drawing.Size(84, 20);
			this.tbZwischenZeit3.TabIndex = 8;
			this.tbZwischenZeit3.Text = "0.00";
			this.tbZwischenZeit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbZwischenZeit3.Leave += new System.EventHandler(this.OnLeaveZwischenZeit3);
			// 
			// tbZwischenZeit4
			// 
			this.tbZwischenZeit4.Location = new System.Drawing.Point(128, 196);
			this.tbZwischenZeit4.Name = "tbZwischenZeit4";
			this.tbZwischenZeit4.Size = new System.Drawing.Size(84, 20);
			this.tbZwischenZeit4.TabIndex = 9;
			this.tbZwischenZeit4.Text = "0.00";
			this.tbZwischenZeit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbZwischenZeit4.Leave += new System.EventHandler(this.OnLeaveZwischenZeit4);
			// 
			// tbZwischenZeit5
			// 
			this.tbZwischenZeit5.Location = new System.Drawing.Point(128, 217);
			this.tbZwischenZeit5.Name = "tbZwischenZeit5";
			this.tbZwischenZeit5.Size = new System.Drawing.Size(84, 20);
			this.tbZwischenZeit5.TabIndex = 10;
			this.tbZwischenZeit5.Text = "0.00";
			this.tbZwischenZeit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbZwischenZeit5.Leave += new System.EventHandler(this.OnLeaveZwischenZeit5);
			// 
			// tbZwischenZeit6
			// 
			this.tbZwischenZeit6.Location = new System.Drawing.Point(128, 237);
			this.tbZwischenZeit6.Name = "tbZwischenZeit6";
			this.tbZwischenZeit6.Size = new System.Drawing.Size(84, 20);
			this.tbZwischenZeit6.TabIndex = 11;
			this.tbZwischenZeit6.Text = "0.00";
			this.tbZwischenZeit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbZwischenZeit6.Leave += new System.EventHandler(this.OnLeaveZwischenZeit6);
			// 
			// tbDurchschnitt
			// 
			this.tbDurchschnitt.Location = new System.Drawing.Point(128, 31);
			this.tbDurchschnitt.Name = "tbDurchschnitt";
			this.tbDurchschnitt.Size = new System.Drawing.Size(84, 20);
			this.tbDurchschnitt.TabIndex = 1;
			this.tbDurchschnitt.Text = "0.00";
			this.tbDurchschnitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbAS
			// 
			this.tbAS.Location = new System.Drawing.Point(128, 52);
			this.tbAS.Name = "tbAS";
			this.tbAS.Size = new System.Drawing.Size(84, 20);
			this.tbAS.TabIndex = 2;
			this.tbAS.Text = "0.00";
			this.tbAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbHoechst
			// 
			this.tbHoechst.Location = new System.Drawing.Point(128, 73);
			this.tbHoechst.Name = "tbHoechst";
			this.tbHoechst.Size = new System.Drawing.Size(84, 20);
			this.tbHoechst.TabIndex = 3;
			this.tbHoechst.Text = "0.00";
			this.tbHoechst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbGewicht
			// 
			this.tbGewicht.Location = new System.Drawing.Point(128, 92);
			this.tbGewicht.Name = "tbGewicht";
			this.tbGewicht.Size = new System.Drawing.Size(84, 20);
			this.tbGewicht.TabIndex = 4;
			this.tbGewicht.Text = "0.00";
			this.tbGewicht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbZwischenZeit7
			// 
			this.tbZwischenZeit7.Location = new System.Drawing.Point(128, 258);
			this.tbZwischenZeit7.Name = "tbZwischenZeit7";
			this.tbZwischenZeit7.Size = new System.Drawing.Size(84, 20);
			this.tbZwischenZeit7.TabIndex = 12;
			this.tbZwischenZeit7.Text = "0.00";
			this.tbZwischenZeit7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbZwischenZeit7.Leave += new System.EventHandler(this.OnLeaveZwischenZeit7);
			// 
			// lbMessPos1
			// 
			this.lbMessPos1.Location = new System.Drawing.Point(328, 42);
			this.lbMessPos1.Name = "lbMessPos1";
			this.lbMessPos1.Size = new System.Drawing.Size(10, 13);
			this.lbMessPos1.TabIndex = 30;
			this.lbMessPos1.Text = "+";
			// 
			// lbMessPos2
			// 
			this.lbMessPos2.Location = new System.Drawing.Point(328, 61);
			this.lbMessPos2.Name = "lbMessPos2";
			this.lbMessPos2.Size = new System.Drawing.Size(10, 14);
			this.lbMessPos2.TabIndex = 31;
			this.lbMessPos2.Text = "+";
			// 
			// lbMessPos3
			// 
			this.lbMessPos3.Location = new System.Drawing.Point(328, 80);
			this.lbMessPos3.Name = "lbMessPos3";
			this.lbMessPos3.Size = new System.Drawing.Size(10, 14);
			this.lbMessPos3.TabIndex = 32;
			this.lbMessPos3.Text = "+";
			// 
			// lbMessPos4
			// 
			this.lbMessPos4.Location = new System.Drawing.Point(328, 99);
			this.lbMessPos4.Name = "lbMessPos4";
			this.lbMessPos4.Size = new System.Drawing.Size(10, 14);
			this.lbMessPos4.TabIndex = 33;
			this.lbMessPos4.Text = "+";
			// 
			// lbMessPos5
			// 
			this.lbMessPos5.Location = new System.Drawing.Point(328, 118);
			this.lbMessPos5.Name = "lbMessPos5";
			this.lbMessPos5.Size = new System.Drawing.Size(10, 14);
			this.lbMessPos5.TabIndex = 34;
			this.lbMessPos5.Text = "+";
			// 
			// lbMessPos6
			// 
			this.lbMessPos6.Location = new System.Drawing.Point(328, 137);
			this.lbMessPos6.Name = "lbMessPos6";
			this.lbMessPos6.Size = new System.Drawing.Size(10, 14);
			this.lbMessPos6.TabIndex = 35;
			this.lbMessPos6.Text = "+";
			// 
			// lbMessPos7
			// 
			this.lbMessPos7.Location = new System.Drawing.Point(328, 156);
			this.lbMessPos7.Name = "lbMessPos7";
			this.lbMessPos7.Size = new System.Drawing.Size(10, 14);
			this.lbMessPos7.TabIndex = 36;
			this.lbMessPos7.Text = "+";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 14);
			this.label2.TabIndex = 37;
			this.label2.Text = "Kommentar:";
			// 
			// tbKommentar
			// 
			this.tbKommentar.Location = new System.Drawing.Point(128, 279);
			this.tbKommentar.Name = "tbKommentar";
			this.tbKommentar.Size = new System.Drawing.Size(169, 20);
			this.tbKommentar.TabIndex = 38;
			this.tbKommentar.Text = "";
			this.tbKommentar.Enter += new System.EventHandler(this.OnEnterKommentar);
			// 
			// cmdOk
			// 
			this.cmdOk.Location = new System.Drawing.Point(430, 319);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size(68, 22);
			this.cmdOk.TabIndex = 39;
			this.cmdOk.Text = "Speichern";
			this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
			// 
			// cmdClose
			// 
			this.cmdClose.Location = new System.Drawing.Point(508, 319);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(68, 22);
			this.cmdClose.TabIndex = 40;
			this.cmdClose.Text = "Schliessen";
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(8, 321);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(304, 15);
			this.lblInfo.TabIndex = 41;
			// 
			// tbASn
			// 
			this.tbASn.Location = new System.Drawing.Point(222, 52);
			this.tbASn.Name = "tbASn";
			this.tbASn.ReadOnly = true;
			this.tbASn.Size = new System.Drawing.Size(61, 20);
			this.tbASn.TabIndex = 42;
			this.tbASn.Text = "";
			// 
			// frmRVEingabe
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(578, 343);
			this.Controls.Add(this.tbASn);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.tbKommentar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbMessPos7);
			this.Controls.Add(this.lbMessPos6);
			this.Controls.Add(this.lbMessPos5);
			this.Controls.Add(this.lbMessPos4);
			this.Controls.Add(this.lbMessPos3);
			this.Controls.Add(this.lbMessPos2);
			this.Controls.Add(this.lbMessPos1);
			this.Controls.Add(this.tbZwischenZeit7);
			this.Controls.Add(this.tbGewicht);
			this.Controls.Add(this.tbHoechst);
			this.Controls.Add(this.tbAS);
			this.Controls.Add(this.tbDurchschnitt);
			this.Controls.Add(this.tbZwischenZeit6);
			this.Controls.Add(this.tbZwischenZeit5);
			this.Controls.Add(this.tbZwischenZeit4);
			this.Controls.Add(this.tbZwischenZeit3);
			this.Controls.Add(this.tbZwischenZeit2);
			this.Controls.Add(this.tbZwischenZeit1);
			this.Controls.Add(this.dtDatum);
			this.Controls.Add(this.lbZwischenOrt7);
			this.Controls.Add(this.cbStrecke);
			this.Controls.Add(this.lbZwischenOrt6);
			this.Controls.Add(this.lbZwischenOrt5);
			this.Controls.Add(this.lbZwischenOrt4);
			this.Controls.Add(this.lbZwischenOrt3);
			this.Controls.Add(this.lbZwischenOrt2);
			this.Controls.Add(this.lbZwischenOrt1);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.lbKmh7);
			this.Controls.Add(this.lbKmh6);
			this.Controls.Add(this.lbKmh5);
			this.Controls.Add(this.lbKmh4);
			this.Controls.Add(this.lbKmh3);
			this.Controls.Add(this.lbKmh2);
			this.Controls.Add(this.lbKmh1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lbMessposition7);
			this.Controls.Add(this.lbMessposition6);
			this.Controls.Add(this.lbMessposition5);
			this.Controls.Add(this.lbMessposition4);
			this.Controls.Add(this.lbMessposition3);
			this.Controls.Add(this.lbMessposition2);
			this.Controls.Add(this.lbMessposition1);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmRVEingabe";
			this.Text = "Eingabe";
			this.Load += new System.EventHandler(this.frmRVEingabe_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmRVEingabe_Load(object sender, System.EventArgs e)
		{
			var init=new DInitFile();
			init.ReadFile(Settings._DataPfad + "init.ini");
			var showAS=init.GetData("AS");
			if(showAS!="1")
				tbAS.Enabled=false;

//			this.BackColor=System.Drawing.Color.Black;
//			lbZwischenOrt1.ForeColor=System.Drawing.Color.Orange;

			cbStrecke.Text="";
			cbStrecke.Items.Clear();

		
//			DRegistry reg=new DRegistry();
//			string datapfad=reg.GetProfileString(DRegistry.TRegistryKey.HKEY_CURRENT_USER, "Software\\Twr\\RVDV", "Data", "");


//			_rv.Jahr=Settings._Jahr;
//			_rv.Pfad=Settings._DataPfad;

//			_rv.Load();

			
			dtDatum.Value=dtDatum.Value.AddYears(f.ConvertToInt(Settings._Jahr)-dtDatum.Value.Year);

			for(var i=0;i<_rv.SdDaten.Count;i++)
			{
				var sd=(SDDaten)_rv.SdDaten[i];
				cbStrecke.Items.Add(sd.Rundfahrt);
			}

			if(cbStrecke.Items.Count>0)
				cbStrecke.SelectedIndex=0;

			if(_rv.RvDaten.Count>0)
			{
				var data=(RVDaten)_rv.RvDaten[_rv.RvDaten.Count-1];
				lblInfo.Text="Letztes Eingabedatum: " + data.StringDatum;
			}

			OnLeaveStrecke(null, null);

		}

		void ShowText(Label label, string text1, string text2)
		{
			if(text2=="")
				label.Visible=false;
			else
				label.Visible=true;

			label.Text=text1 + text2;


		}

		void EnableControl(bool visible, object obj1, object obj2, object obj3, object obj4)
		{
			if(obj1 is Label)
				((Label)obj1).Visible=visible;
			if(obj1 is TextBox)
				((TextBox)obj1).Visible=visible;

			if(obj2 is Label)
				((Label)obj2).Visible=visible;
			if(obj2 is TextBox)
				((TextBox)obj2).Visible=visible;

			if(obj3 is Label)
				((Label)obj3).Visible=visible;
			if(obj3 is TextBox)
				((TextBox)obj3).Visible=visible;

			if(obj4 is Label)
				((Label)obj4).Visible=visible;
			if(obj4 is TextBox)
				((TextBox)obj4).Visible=visible;

/*			if((obj2 is Label)||(obj2 is TextBox))
				((Label)obj2).Enabled=enabled;
			if((obj3 is Label)||(obj3 is TextBox))
				((Label)obj3).Enabled=enabled;
			if((obj4 is Label)||(obj4 is TextBox))
				((Label)obj4).Enabled=enabled;*/
		}



		string _Rundfahrt="";
		private void OnLeaveStrecke(object sender, System.EventArgs e)
		{
			if(cbStrecke.Enabled==true)
			{
				lbMessPos1.Visible=false;
				lbMessPos2.Visible=false;
				lbMessPos3.Visible=false;
				lbMessPos4.Visible=false;
				lbMessPos5.Visible=false;
				lbMessPos6.Visible=false;
				lbMessPos7.Visible=false;

				lbKmh1.Text="";
				lbKmh2.Text="";
				lbKmh3.Text="";
				lbKmh4.Text="";
				lbKmh5.Text="";
				lbKmh6.Text="";
				lbKmh7.Text="";

//				cbStrecke.SelectedValue=cbStrecke.SelectedText;
			}



			var found=-1;



			for(var i=0;i<_rv.SdDaten.Count;i++)
			{
				var sd=(SDDaten)_rv.SdDaten[i];
				if(sd.Rundfahrt.Trim().Length>cbStrecke.Text.Trim().Length)
				{
					var tmp=sd.Rundfahrt.ToLower().Substring(0, cbStrecke.Text.Trim().Length);
					if(tmp==cbStrecke.Text.Trim().ToLower())
						cbStrecke.Text=sd.Rundfahrt;
				}

				if(sd.Rundfahrt.ToLower()==cbStrecke.Text.Trim().ToLower())
				{
					_Rundfahrt=sd.Strecke;
					found=i;
					break;
				}
			}
			if(found==-1)
			{
				cbStrecke.Focus();
			}
			else
			{
				lbZwischenOrt1.Enabled=true;
				
				ShowText(lbZwischenOrt1, "Zeit-", ((SDDaten)_rv.SdDaten[found]).ZwischenOrt1);
				ShowText(lbZwischenOrt2, "Zeit-", ((SDDaten)_rv.SdDaten[found]).ZwischenOrt2);
				ShowText(lbZwischenOrt3, "Zeit-", ((SDDaten)_rv.SdDaten[found]).ZwischenOrt3);
				ShowText(lbZwischenOrt4, "Zeit-", ((SDDaten)_rv.SdDaten[found]).ZwischenOrt4);
				ShowText(lbZwischenOrt5, "Zeit-", ((SDDaten)_rv.SdDaten[found]).ZwischenOrt5);
				ShowText(lbZwischenOrt6, "Zeit-", ((SDDaten)_rv.SdDaten[found]).ZwischenOrt6);
				ShowText(lbZwischenOrt7, "Zeit-", ((SDDaten)_rv.SdDaten[found]).ZwischenOrt7);

				lbMessposition1.Text=((SDDaten)_rv.SdDaten[found]).ZwischenOrt1;
				lbMessposition2.Text=((SDDaten)_rv.SdDaten[found]).ZwischenOrt2;
				lbMessposition3.Text=((SDDaten)_rv.SdDaten[found]).ZwischenOrt3;
				lbMessposition4.Text=((SDDaten)_rv.SdDaten[found]).ZwischenOrt4;
				lbMessposition5.Text=((SDDaten)_rv.SdDaten[found]).ZwischenOrt5;
				lbMessposition6.Text=((SDDaten)_rv.SdDaten[found]).ZwischenOrt6;
				lbMessposition7.Text=((SDDaten)_rv.SdDaten[found]).ZwischenOrt7;

				_pos1=((SDDaten)_rv.SdDaten[found]).ZwischenDistanz1;
				_pos2=((SDDaten)_rv.SdDaten[found]).ZwischenDistanz2;
				_pos3=((SDDaten)_rv.SdDaten[found]).ZwischenDistanz3;
				_pos4=((SDDaten)_rv.SdDaten[found]).ZwischenDistanz4;
				_pos5=((SDDaten)_rv.SdDaten[found]).ZwischenDistanz5;
				_pos6=((SDDaten)_rv.SdDaten[found]).ZwischenDistanz6;
				_pos7=((SDDaten)_rv.SdDaten[found]).ZwischenDistanz7;



				if(((SDDaten)_rv.SdDaten[found]).Anzeige==1)	lbMessPos1.Visible=true;
				if(((SDDaten)_rv.SdDaten[found]).Anzeige==2)	lbMessPos2.Visible=true;
				if(((SDDaten)_rv.SdDaten[found]).Anzeige==3)	lbMessPos3.Visible=true;
				if(((SDDaten)_rv.SdDaten[found]).Anzeige==4)	lbMessPos4.Visible=true;
				if(((SDDaten)_rv.SdDaten[found]).Anzeige==5)	lbMessPos5.Visible=true;
				if(((SDDaten)_rv.SdDaten[found]).Anzeige==6)	lbMessPos6.Visible=true;
				if(((SDDaten)_rv.SdDaten[found]).Anzeige==7)	lbMessPos7.Visible=true;
			}

			EnableControl(lbZwischenOrt1.Text.Length>5, lbZwischenOrt1, tbZwischenZeit1, lbMessposition1, lbKmh1);
			EnableControl(lbZwischenOrt2.Text.Length>5, lbZwischenOrt2, tbZwischenZeit2, lbMessposition2, lbKmh2);
			EnableControl(lbZwischenOrt3.Text.Length>5, lbZwischenOrt3, tbZwischenZeit3, lbMessposition3, lbKmh3);
			EnableControl(lbZwischenOrt4.Text.Length>5, lbZwischenOrt4, tbZwischenZeit4, lbMessposition4, lbKmh4);
			EnableControl(lbZwischenOrt5.Text.Length>5, lbZwischenOrt5, tbZwischenZeit5, lbMessposition5, lbKmh5);
			EnableControl(lbZwischenOrt6.Text.Length>5, lbZwischenOrt6, tbZwischenZeit6, lbMessposition6, lbKmh6);
			EnableControl(lbZwischenOrt7.Text.Length>5, lbZwischenOrt7, tbZwischenZeit7, lbMessposition7, lbKmh7);
		}

		private void OnSelectedIndexChangedStrecke(object sender, System.EventArgs e)
		{
			OnLeaveStrecke(null, null);
		
		}

		string KMh(TextBox tb, double km)
		{
			var tmp=tb.Text;
			if(f.ConvertToDouble(tmp)<=0.0)
			{
//				tb.Focus();
				return "";
			}

			var z=f.ConvertToDouble(tmp);
			var gz=(double)f.ConvertToInt(tmp);
			z-=gz;

			z*=100;

			z/=60;
			z+=gz;

			tmp=z.ToString("0.00");
			tb.Text=tmp;

			var t=f.ConvertToDouble(tmp);

			var v=(km/t)*60;
			return v.ToString("0.00");

			


//			return "";
		}

		private void OnLeaveZwischenZeit1(object sender, System.EventArgs e)
		{
			lbKmh1.Text=KMh(tbZwischenZeit1, _pos1);
			cbStrecke.Enabled=false;
//
//			//v=s/t
//			double t=f.ConvertToDouble(tbZwischenZeit1.Text);
//			if(t==0.0)
//				tbZwischenZeit1.Focus();
//			else
//			{
//				lbKmh1.Text=KMh(tbZwischenZeit1, _pos1);
//
////				double v=(_pos1/t)*60;
//
////				lbKmh1.Text=v.ToString("0.00");
//			}
//			lbKmh1.Text=
//			_pos1
		
		}

		private void OnLeaveZwischenZeit2(object sender, System.EventArgs e)
		{
			if(f.ConvertToDouble(tbZwischenZeit2.Text)!=0.0)
				tbZwischenZeit1.Enabled=false;
			else
				tbZwischenZeit1.Enabled=true;

			lbKmh2.Text=KMh(tbZwischenZeit2, _pos2);
		}

		private void OnLeaveZwischenZeit3(object sender, System.EventArgs e)
		{
			if(f.ConvertToDouble(tbZwischenZeit3.Text)!=0.0)
				tbZwischenZeit2.Enabled=false;
			else
				tbZwischenZeit2.Enabled=true;
			
			lbKmh3.Text=KMh(tbZwischenZeit3, _pos3);
		}

		private void OnLeaveZwischenZeit4(object sender, System.EventArgs e)
		{
			if(f.ConvertToDouble(tbZwischenZeit4.Text)!=0.0)
				tbZwischenZeit3.Enabled=false;
			else
				tbZwischenZeit3.Enabled=true;

			lbKmh4.Text=KMh(tbZwischenZeit4, _pos4);
		}

		private void OnLeaveZwischenZeit5(object sender, System.EventArgs e)
		{
			if(f.ConvertToDouble(tbZwischenZeit5.Text)!=0.0)
				tbZwischenZeit4.Enabled=false;		
			else
				tbZwischenZeit4.Enabled=true;

			lbKmh5.Text=KMh(tbZwischenZeit5, _pos5);
		}

		private void OnLeaveZwischenZeit6(object sender, System.EventArgs e)
		{
			if(f.ConvertToDouble(tbZwischenZeit6.Text)!=0.0)
				tbZwischenZeit5.Enabled=false;
			else
				tbZwischenZeit5.Enabled=true;

			lbKmh6.Text=KMh(tbZwischenZeit6, _pos6);
		}

		private void OnLeaveZwischenZeit7(object sender, System.EventArgs e)
		{
			if(f.ConvertToDouble(tbZwischenZeit7.Text)!=0.0)
				tbZwischenZeit6.Enabled=false;
			else
				tbZwischenZeit6.Enabled=true;

			lbKmh7.Text=KMh(tbZwischenZeit7, _pos7);
		}

		private void cmdOk_Click(object sender, System.EventArgs e)
		{
			var data=new RVDaten();

			if(f.ConvertToDouble(tbDurchschnitt.Text)==0.0)
			{
				tbDurchschnitt.Focus();
				return;
			}
			if(f.ConvertToDouble(tbAS.Text)==0.0)	
			{
				tbAS.Focus();
				return;
			}

			if(f.ConvertToDouble(tbHoechst.Text)==0.0)
			{
				tbHoechst.Focus();
				return;
			}

			if(f.ConvertToDouble(tbGewicht.Text)==0.0)	
			{
				tbGewicht.Focus();
				return;
			}

			if(f.ConvertToDouble(tbDurchschnitt.Text)==0.0)	
			{
				tbDurchschnitt.Focus();
				return;
			}



			data.Durchschnitt=f.ConvertToDouble(tbDurchschnitt.Text);
			//data.ARS=f.ConvertToInt(tbAS.Text);
			data.Hoechst=f.ConvertToDouble(tbHoechst.Text);
			data.Gewicht = tbGewicht.Text.ToDouble();
			data.StringDatum=dtDatum.Value.ToString("yyyyMMdd");;
			data.ZwischenZeit1=f.ConvertToDouble(tbZwischenZeit1.Text);
			data.ZwischenZeit2=f.ConvertToDouble(tbZwischenZeit2.Text);
			data.ZwischenZeit3=f.ConvertToDouble(tbZwischenZeit3.Text);
			data.ZwischenZeit4=f.ConvertToDouble(tbZwischenZeit4.Text);
			data.ZwischenZeit5=f.ConvertToDouble(tbZwischenZeit5.Text);
			data.ZwischenZeit6=f.ConvertToDouble(tbZwischenZeit6.Text);
			data.ZwischenZeit7=f.ConvertToDouble(tbZwischenZeit7.Text);

			var tz=0.0;
			if(tz<f.ConvertToDouble(tbZwischenZeit7.Text))	tz=f.ConvertToDouble(tbZwischenZeit7.Text);
			if(tz<f.ConvertToDouble(tbZwischenZeit6.Text))	tz=f.ConvertToDouble(tbZwischenZeit6.Text);
			if(tz<f.ConvertToDouble(tbZwischenZeit5.Text))	tz=f.ConvertToDouble(tbZwischenZeit5.Text);
			if(tz<f.ConvertToDouble(tbZwischenZeit4.Text))	tz=f.ConvertToDouble(tbZwischenZeit4.Text);
			if(tz<f.ConvertToDouble(tbZwischenZeit3.Text))	tz=f.ConvertToDouble(tbZwischenZeit3.Text);
			if(tz<f.ConvertToDouble(tbZwischenZeit2.Text))	tz=f.ConvertToDouble(tbZwischenZeit2.Text);
			if(tz<f.ConvertToDouble(tbZwischenZeit1.Text))	tz=f.ConvertToDouble(tbZwischenZeit1.Text);

			data.TotalZeit=tz;

			if(lbMessPos1.Visible)	data.Total=f.ConvertToDouble(lbKmh1.Text);
			if(lbMessPos2.Visible)	data.Total=f.ConvertToDouble(lbKmh2.Text);
			if(lbMessPos3.Visible)	data.Total=f.ConvertToDouble(lbKmh3.Text);
			if(lbMessPos4.Visible)	data.Total=f.ConvertToDouble(lbKmh4.Text);
			if(lbMessPos5.Visible)	data.Total=f.ConvertToDouble(lbKmh5.Text);
			if(lbMessPos6.Visible)	data.Total=f.ConvertToDouble(lbKmh6.Text);
			if(lbMessPos7.Visible)	data.Total=f.ConvertToDouble(lbKmh7.Text);

			data.Strecke=_Rundfahrt;



			data.Bemerkung=tbKommentar.Text;
			_rv.RvDaten.Add(data);
			_rv.SaveData("RV");

			tbDurchschnitt.Text="0.0";
			tbAS.Text="0.0";
			tbHoechst.Text="0.0";
			tbGewicht.Text="0.0";

			tbZwischenZeit1.Text="0.0";
			tbZwischenZeit2.Text="0.0";
			tbZwischenZeit3.Text="0.0";
			tbZwischenZeit4.Text="0.0";
			tbZwischenZeit5.Text="0.0";
			tbZwischenZeit6.Text="0.0";
			tbZwischenZeit7.Text="0.0";

			tbKommentar.Text="";

			OnLeaveZwischenZeit7(null, null);
			OnLeaveZwischenZeit6(null, null);
			OnLeaveZwischenZeit5(null, null);
			OnLeaveZwischenZeit4(null, null);
			OnLeaveZwischenZeit3(null, null);
			OnLeaveZwischenZeit2(null, null);
			OnLeaveZwischenZeit1(null, null);

			cbStrecke.Enabled=true;
			cbStrecke.SelectAll();

			lbMessPos1.Visible=false;
			lbMessPos2.Visible=false;
			lbMessPos3.Visible=false;
			lbMessPos4.Visible=false;
			lbMessPos5.Visible=false;
			lbMessPos6.Visible=false;
			lbMessPos7.Visible=false;

			cbStrecke.Focus();

			var data2=(RVDaten)_rv.RvDaten[_rv.RvDaten.Count-1];
			lblInfo.Text="Letztes Eingabedatum: " + data2.StringDatum;

			tbASn.Text="";

		
		}

		private void OnEnterKommentar(object sender, System.EventArgs e)
		{
//			if(tbAS.Text.Trim().Length!=0)
//			{
//				if(tbAS.Text!="0.00")
//					return;
//			}

			var zz=f.ConvertToDouble(tbZwischenZeit7.Text);
			var d=f.ConvertToDouble(tbDurchschnitt.Text);
			if(d==0.0)
				return;

			if(zz==0.0)	zz=f.ConvertToDouble(tbZwischenZeit6.Text);
			if(zz==0.0)	zz=f.ConvertToDouble(tbZwischenZeit5.Text);
			if(zz==0.0)	zz=f.ConvertToDouble(tbZwischenZeit4.Text);
			if(zz==0.0)	zz=f.ConvertToDouble(tbZwischenZeit3.Text);
			if(zz==0.0)	zz=f.ConvertToDouble(tbZwischenZeit2.Text);
			if(zz==0.0)	zz=f.ConvertToDouble(tbZwischenZeit1.Text);

			if(zz==0.0)
				return;

			var wert=0.0;
			var zeilen=f.ReadWholeFile(Settings._DataPfad + "total.dat"); 
			for(;;)
			{
				if(zeilen.IndexOf("\r\n")==-1)
					break;

				if(d<=f.ConvertToDouble(zeilen))
				{
					f.HeadFromList(ref zeilen, "-");
					wert=f.ConvertToDouble(zeilen);
					break;
				}

				f.HeadFromList(ref zeilen, "\r\n");
			}

			wert*=zz;
			wert*=d;
			
			tbASn.Text=string.Format("{0:F0}", wert);

			if(tbAS.Text!="0.00")
				return;
			tbAS.Text=tbASn.Text;
		}

	}
}
