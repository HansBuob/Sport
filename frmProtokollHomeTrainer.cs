using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using twr;
using f=twr.DFunktionen;
//using Sport;

namespace Sport
{
	/// <summary>
	/// Summary description for frmProtokollHomeTrainer.
	/// </summary>
	public class frmProtokollHomeTrainer : frmPaintProtokoll//frmGProtokoll//: System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public frmProtokollHomeTrainer()
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
			this.components = new System.ComponentModel.Container();
			this.Size = new System.Drawing.Size(300,300);
			this.Text = "frmProtokollHomeTrainer";
		}
		#endregion
		Sport _rv=new Sport();
		public Sport setRV
		{
			set
			{
				_rv=value;
			}
		}
		protected override void OnInitial()
		{
//			return;
			//			SetData(2,0,11.2345,2);
			
			this.Text="Heimtrainer-Info";
			this.Text+=" (" + Settings._Jahr + ")";

//			SetColor(1,0,100, Color.FromArgb(255,180,80));
			SetTitel(" Datum       Belastung  Zeit   Pulsschlag Distanz D-Geschw.  KJoul  Kcal  Gewicht");
//			SetData(1,0, "Datum      Belastung  Zeit   Puschschlag vor/nach Distanz   KJoul      Kcal   Gewicht");

			var tZeit=0.0;
			var tKJoul=0.0;
			var tKm=0.0;
			for(var i=0;i<_rv.HtDaten.Count;i++)
			{
				var heimtrainerDaten=_rv.HtDaten[i];

				var datum=heimtrainerDaten.StringDatum.Substring(6, 2) + "." + heimtrainerDaten.StringDatum.Substring(4, 2) + "." + heimtrainerDaten.StringDatum.Substring(0, 4);
				SetData(1, i, datum);//"Monat            Km     Std     Km/h     mal      ");
				SetData(16, i, heimtrainerDaten.Belastung,1);
				SetData(25, i, heimtrainerDaten.Dauer,2);
				//if(ht.PulsschlagVor!=0.0)
				//{
				//    SetData(34, i, ht.PulsschlagVor,0);
				//    SetData(34, i, "/");
				//    SetData(38, i, ht.PulsschlagNach,0);
				//}
				SetData(44, i, heimtrainerDaten.Distanz,1);
				SetData(52, i, 60*heimtrainerDaten.Distanz/heimtrainerDaten.Dauer,2);
				SetData(65, i, heimtrainerDaten.KJoul,0);
				SetData(71, i, heimtrainerDaten.KJoul/4.186,0);
				SetData(78, i, heimtrainerDaten.Gewicht,1);

				tZeit+=heimtrainerDaten.Dauer;
				tKm+=heimtrainerDaten.Distanz;
				tKJoul+=heimtrainerDaten.KJoul;
			}

			
			var y=_rv.HtDaten.Count+2;
			SetData(1, y, _rv.HtDaten.Count.ToString());
			SetData(25, y, tZeit/60,2);
			SetData(29, y, "Std");
			SetData(44, y, tKm,1);
			SetData(47, y, "Km");
			//SetData(65, y, tKJoul/4.186,2);
			SetData(68, y, tKJoul/4.186/900/10,2);
			SetData(72, y, "Kg");
		}
	}
}
