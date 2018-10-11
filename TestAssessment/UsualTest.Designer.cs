namespace TestAssessment
{
    partial class UsualTest
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
            this.ComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.lblChoose = new MetroFramework.Controls.MetroLabel();
            this.lblPersonName = new MetroFramework.Controls.MetroLink();
            this.lblTheme = new MetroFramework.Controls.MetroLabel();
            this.lblIDTheme = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.ItemHeight = 19;
            this.ComboBox1.Location = new System.Drawing.Point(23, 92);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(156, 25);
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.UseSelectable = true;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 173);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNext.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNext.Location = new System.Drawing.Point(254, 206);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Далее";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.Location = new System.Drawing.Point(254, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выйти ";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(23, 60);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(96, 19);
            this.lblChoose.TabIndex = 5;
            this.lblChoose.Text = "Выберите тест";
            // 
            // lblPersonName
            // 
            this.lblPersonName.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblPersonName.Location = new System.Drawing.Point(254, 30);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(87, 23);
            this.lblPersonName.TabIndex = 6;
            this.lblPersonName.UseSelectable = true;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(254, 98);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(63, 19);
            this.lblTheme.TabIndex = 7;
            this.lblTheme.Text = "lblTheme";
            // 
            // lblIDTheme
            // 
            this.lblIDTheme.AutoSize = true;
            this.lblIDTheme.Location = new System.Drawing.Point(254, 60);
            this.lblIDTheme.Name = "lblIDTheme";
            this.lblIDTheme.Size = new System.Drawing.Size(73, 19);
            this.lblIDTheme.TabIndex = 2;
            this.lblIDTheme.Text = "Тема теста";
            // 
            // UsualTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 330);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblIDTheme);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ComboBox1);
            this.Name = "UsualTest";
            this.Text = "Тестирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel lblChoose;
        private MetroFramework.Controls.MetroLink lblPersonName;
        private MetroFramework.Controls.MetroLabel lblTheme;
        private MetroFramework.Controls.MetroLabel lblIDTheme;
    }
}