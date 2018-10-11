namespace TestAssessment
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblUser = new MetroFramework.Controls.MetroLink();
            this.metroBtnExit = new MetroFramework.Controls.MetroButton();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnEditTest = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.msmMenu = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblUser.Location = new System.Drawing.Point(250, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.UseSelectable = true;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // metroBtnExit
            // 
            this.metroBtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroBtnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtnExit.Location = new System.Drawing.Point(276, 321);
            this.metroBtnExit.Name = "metroBtnExit";
            this.metroBtnExit.Size = new System.Drawing.Size(78, 29);
            this.metroBtnExit.TabIndex = 3;
            this.metroBtnExit.Text = "Выйти";
            this.metroBtnExit.UseSelectable = true;
            this.metroBtnExit.Click += new System.EventHandler(this.metroBtnExit_Click);
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonBack.Location = new System.Drawing.Point(175, 321);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(78, 29);
            this.metroButtonBack.TabIndex = 4;
            this.metroButtonBack.Text = "Назад";
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStart.Location = new System.Drawing.Point(103, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 50);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Начать";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEditTest
            // 
            this.btnEditTest.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEditTest.Location = new System.Drawing.Point(103, 158);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(150, 50);
            this.btnEditTest.TabIndex = 6;
            this.btnEditTest.Text = "Редактор тестов";
            this.btnEditTest.UseSelectable = true;
            this.btnEditTest.Click += new System.EventHandler(this.btnEditTest_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSettings.Location = new System.Drawing.Point(103, 231);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 50);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // msmMenu
            // 
            this.msmMenu.Owner = this;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 358);
            this.ControlBox = false;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnEditTest);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.metroButtonBack);
            this.Controls.Add(this.metroBtnExit);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Resizable = false;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.msmMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lblUser;
        private MetroFramework.Controls.MetroButton metroBtnExit;
        private MetroFramework.Controls.MetroButton metroButtonBack;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroButton btnEditTest;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Components.MetroStyleManager msmMenu;
    }
}