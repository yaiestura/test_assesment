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
    public partial class MainMenu : MetroForm
    {
        string PersonName; //Имя пользователя
        string Username; 
        string Group;
        string PersonSurname;
        
        public MainMenu(string username, string personName, string personSurname, string group, MetroFramework.Components.MetroStyleManager msmMain)
        {
            InitializeComponent();
            Username = username;
            PersonName = personName;
            PersonSurname = personSurname;
            Group = group;
            msmMenu = msmMain;
            this.StyleManager = msmMenu;
            lblUser.Text = username;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Пользователь", Username, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void metroBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            this.Hide();
            auth.Show();
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            TestEditor TE = new TestEditor(msmMenu);
            TE.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Test test = new Test(PersonName, PersonSurname,Group);
            test.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings setup = new Settings();
            setup.ShowDialog();            
        }
    }
}
