using System;
using System.Windows.Forms;

namespace Sport
{
    public class MDI
    {
        public bool _hasWindows = false;
        private System.Windows.Forms.Form _parentMDI;

        private MenuItem WindowMenu;

        public MDI()
        {
        }

        public void AddWindows(System.Windows.Forms.Form parentMDI, System.Windows.Forms.MainMenu mnuMain)
        {
            _parentMDI = parentMDI;
            WindowMenu = new MenuItem();
            WindowMenu.Text = "&Fenster";
            WindowMenu.MenuItems.Add("Überlappend", new EventHandler(Cascade_Click));
            WindowMenu.MenuItems.Add("Untereinander", new EventHandler(TileH_Click));
            WindowMenu.MenuItems.Add("Nebeneinander", new EventHandler(TileV_Click));
            WindowMenu.MdiList = true;
            mnuMain.MenuItems.Add(WindowMenu);
        }

        private void Cascade_Click(object sender, EventArgs e)
        {
            if (_parentMDI.MdiChildren.Length == 0)
                _hasWindows = false;
            else
            {
                _hasWindows = true;
                _parentMDI.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void TileH_Click(object sender, EventArgs e)
        {
            if (_parentMDI.MdiChildren.Length == 0)
                _hasWindows = false;
            else
            {
                _hasWindows = true;
                _parentMDI.LayoutMdi(MdiLayout.TileHorizontal);
            }
        }

        private void TileV_Click(object sender, EventArgs e)
        {
            if (_parentMDI.MdiChildren.Length == 0)
                _hasWindows = false;
            else
            {
                _hasWindows = true;
                _parentMDI.LayoutMdi(MdiLayout.TileVertical);
            }
        }
    }

    /// <summary>
    /// Summary description for Settings.
    /// </summary>
    public class Settings
    {
        static Settings()
        {
        }

        public static string _DataPfad;
        public static string _Jahr;

        public static bool _IsMdiLayout = false;
    }
}