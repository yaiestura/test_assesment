namespace TestAssessment
{
    partial class panelLogin
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSettings = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpConnection = new MetroFramework.Controls.MetroTabPage();
            this.mtpTheme = new MetroFramework.Controls.MetroTabPage();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.pnlCenter = new MetroFramework.Controls.MetroPanel();
            this.pnlSettings.SuspendLayout();
            this.mtcSettings.SuspendLayout();
            this.mtpTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.Controls.Add(this.panel1);
            this.pnlSettings.Controls.Add(this.mtcSettings);
            this.pnlSettings.Controls.Add(this.lnkBack);
            this.pnlSettings.HorizontalScrollbarBarColor = true;
            this.pnlSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSettings.HorizontalScrollbarSize = 10;
            this.pnlSettings.Location = new System.Drawing.Point(442, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(266, 379);
            this.pnlSettings.TabIndex = 1;
            this.pnlSettings.VerticalScrollbarBarColor = true;
            this.pnlSettings.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSettings.VerticalScrollbarSize = 10;
            this.pnlSettings.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1, 379);
            this.panel1.TabIndex = 2;
            // 
            // mtcSettings
            // 
            this.mtcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcSettings.Controls.Add(this.mtpConnection);
            this.mtcSettings.Controls.Add(this.mtpTheme);
            this.mtcSettings.Location = new System.Drawing.Point(0, 62);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 1;
            this.mtcSettings.Size = new System.Drawing.Size(272, 320);
            this.mtcSettings.TabIndex = 3;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpConnection
            // 
            this.mtpConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 38);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(258, 278);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&assistance";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // mtpTheme
            // 
            this.mtpTheme.Controls.Add(this.mrbLight);
            this.mtpTheme.Controls.Add(this.mrbDark);
            this.mtpTheme.Controls.Add(this.metroLabel2);
            this.mtpTheme.Controls.Add(this.metroLabel1);
            this.mtpTheme.Controls.Add(this.flpSettings);
            this.mtpTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtpTheme.HorizontalScrollbarBarColor = true;
            this.mtpTheme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpTheme.HorizontalScrollbarSize = 10;
            this.mtpTheme.Location = new System.Drawing.Point(4, 38);
            this.mtpTheme.Name = "mtpTheme";
            this.mtpTheme.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.mtpTheme.Size = new System.Drawing.Size(264, 278);
            this.mtpTheme.TabIndex = 1;
            this.mtpTheme.Text = "&theme";
            this.mtpTheme.VerticalScrollbarBarColor = true;
            this.mtpTheme.VerticalScrollbarHighlightOnWheel = false;
            this.mtpTheme.VerticalScrollbarSize = 10;
            // 
            // mrbLight
            // 
            this.mrbLight.AutoSize = true;
            this.mrbLight.Checked = true;
            this.mrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbLight.Location = new System.Drawing.Point(77, 22);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(56, 19);
            this.mrbLight.TabIndex = 6;
            this.mrbLight.TabStop = true;
            this.mrbLight.Text = "&Light";
            this.mrbLight.UseSelectable = true;
            this.mrbLight.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // mrbDark
            // 
            this.mrbDark.AutoSize = true;
            this.mrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDark.Location = new System.Drawing.Point(3, 22);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(54, 19);
            this.mrbDark.TabIndex = 5;
            this.mrbDark.Text = "&Dark";
            this.mrbDark.UseSelectable = true;
            this.mrbDark.CheckedChanged += new System.EventHandler(this.mrbDark_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Style";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Theme";
            // 
            // flpSettings
            // 
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSettings.Location = new System.Drawing.Point(0, 80);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(264, 198);
            this.flpSettings.TabIndex = 2;
            // 
            // lnkBack
            // 
            this.lnkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkBack.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.lnkBack.Image = global::TestAssessment.Properties.Resources.back_logo_icon_27727;
            this.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.ImageSize = 32;
            this.lnkBack.Location = new System.Drawing.Point(3, 3);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.NoFocusImage = global::TestAssessment.Properties.Resources.back_logo_icon_27727;
            this.lnkBack.Size = new System.Drawing.Size(154, 36);
            this.lnkBack.TabIndex = 2;
            this.lnkBack.Text = "&Настройки";
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenter.HorizontalScrollbarBarColor = true;
            this.pnlCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCenter.HorizontalScrollbarSize = 10;
            this.pnlCenter.Location = new System.Drawing.Point(0, 84);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(708, 211);
            this.pnlCenter.TabIndex = 2;
            this.pnlCenter.VerticalScrollbarBarColor = true;
            this.pnlCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCenter.VerticalScrollbarSize = 10;
            // 
            // panelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlCenter);
            this.Name = "panelLogin";
            this.Size = new System.Drawing.Size(702, 379);
            this.pnlSettings.ResumeLayout(false);
            this.mtcSettings.ResumeLayout(false);
            this.mtpTheme.ResumeLayout(false);
            this.mtpTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnlSettings;
        private MetroFramework.Controls.MetroLink lnkBack;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpConnection;
        private MetroFramework.Controls.MetroTabPage mtpTheme;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private MetroFramework.Controls.MetroPanel pnlCenter;
    }
}
