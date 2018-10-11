using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace TestAssessment
{
    public partial class Authorization : MetroForm
    {
        panelLogin login = null;

        public Authorization()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            this.Shown += MainForm_Shown;
            login = new panelLogin(this);
            login.SettingClosed += login_SettingClosed;
            login.swipe();
        }

        void login_SettingClosed(object sender, EventArgs e)
        {
            metroLinkSettings.Visible = true;
            metroButtonErase.Visible = true;
            metroBtnReady.Visible = true;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void metroLinkSettings_Click(object sender, EventArgs e)
        {
            metroLinkSettings.Visible = false;
            login.ShowSettings();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButtonErase_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroBtnReady_Click(object sender, EventArgs e)
        {
           if(mtbName.Text == "" || mtbUsername.Text == "")
            MetroMessageBox.Show(this, "Пожалуйста, заполните все данные!", "Ошибка!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
           else  
            {
                MainMenu menu = new MainMenu(mtbUsername.Text, mtbName.Text, mtbSurname.Text, mtbGroup.Text, msmMain);
                menu.Show();
                this.Visible = false;
            }
        }
    }
}
