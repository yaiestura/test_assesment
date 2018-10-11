using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;


namespace TestAssessment
{
    public partial class panelLogin : pnlSlider
    {
        public event EventHandler SettingClosed;
        public panelLogin(Form owner) : base(owner)
        {
            InitializeComponent();

            for (int i = 3; i < 13; i++)
            {
                MetroTile _square = new MetroTile();
                _square.Size = new Size(30, 30);
                _square.Tag = i;
                _square.Click += _square_Click;
                _square.Style = (MetroFramework.MetroColorStyle)i;
                flpSettings.Controls.Add(_square);
            }
        }

        private void _square_Click(object sender, EventArgs e)
        {
            ((MetroForm)this.Parent).StyleManager.Style = (MetroFramework.MetroColorStyle)((MetroTile)sender).Tag;
                
        }

        public void ShowSettings()
        {
            pnlSettings.Visible = true;
            pnlCenter.Enabled = false;          

        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
            pnlCenter.Enabled = true;            
            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);

        }
        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked) ((MetroForm)this.Parent).StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked) ((MetroForm)this.Parent).StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
        }
    }
 }

