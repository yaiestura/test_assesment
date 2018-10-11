namespace TestAssessment
{
    partial class UsualMain
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblQW = new MetroFramework.Controls.MetroLabel();
            this.lblVariables = new MetroFramework.Controls.MetroLabel();
            this.lblQuestion = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnNextQW = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblQW);
            this.metroPanel1.Controls.Add(this.lblVariables);
            this.metroPanel1.Controls.Add(this.lblQuestion);
            this.metroPanel1.Controls.Add(this.metroRadioButton4);
            this.metroPanel1.Controls.Add(this.metroRadioButton3);
            this.metroPanel1.Controls.Add(this.metroRadioButton2);
            this.metroPanel1.Controls.Add(this.metroRadioButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(494, 291);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblQW
            // 
            this.lblQW.AutoSize = true;
            this.lblQW.Location = new System.Drawing.Point(28, 33);
            this.lblQW.Name = "lblQW";
            this.lblQW.Size = new System.Drawing.Size(83, 19);
            this.lblQW.TabIndex = 8;
            this.lblQW.Text = "metroLabel1";
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Location = new System.Drawing.Point(28, 104);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(111, 19);
            this.lblVariables.TabIndex = 7;
            this.lblVariables.Text = "Выбор варианта";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(28, 10);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(55, 19);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "Вопрос";
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(28, 261);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton4.TabIndex = 5;
            this.metroRadioButton4.Text = "metroRadioButton4";
            this.metroRadioButton4.UseSelectable = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(28, 223);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton3.TabIndex = 4;
            this.metroRadioButton3.Text = "metroRadioButton3";
            this.metroRadioButton3.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(28, 184);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton2.TabIndex = 3;
            this.metroRadioButton2.Text = "metroRadioButton2";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(28, 146);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton1.TabIndex = 2;
            this.metroRadioButton1.Text = "metroRadioButton1";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.Location = new System.Drawing.Point(442, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNextQW
            // 
            this.btnNextQW.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNextQW.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNextQW.Location = new System.Drawing.Point(256, 374);
            this.btnNextQW.Name = "btnNextQW";
            this.btnNextQW.Size = new System.Drawing.Size(156, 23);
            this.btnNextQW.TabIndex = 2;
            this.btnNextQW.Text = "Следующий вопрос";
            this.btnNextQW.UseSelectable = true;
            this.btnNextQW.Click += new System.EventHandler(this.btnNextQW_Click);
            // 
            // UsualMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 420);
            this.Controls.Add(this.btnNextQW);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UsualMain";
            this.Text = "Тестирование";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnNextQW;
        private MetroFramework.Controls.MetroLabel lblVariables;
        private MetroFramework.Controls.MetroLabel lblQuestion;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroLabel lblQW;
    }
}