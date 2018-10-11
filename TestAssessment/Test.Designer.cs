namespace TestAssessment
{
    partial class Test
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
            this.btnStandart = new MetroFramework.Controls.MetroButton();
            this.btnUsual = new MetroFramework.Controls.MetroButton();
            this.btnExam = new MetroFramework.Controls.MetroButton();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.metroBtnExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnStandart
            // 
            this.btnStandart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStandart.Location = new System.Drawing.Point(103, 85);
            this.btnStandart.Name = "btnStandart";
            this.btnStandart.Size = new System.Drawing.Size(150, 50);
            this.btnStandart.TabIndex = 6;
            this.btnStandart.Text = "Стандартный";
            this.btnStandart.UseSelectable = true;
            // 
            // btnUsual
            // 
            this.btnUsual.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUsual.Location = new System.Drawing.Point(103, 158);
            this.btnUsual.Name = "btnUsual";
            this.btnUsual.Size = new System.Drawing.Size(150, 50);
            this.btnUsual.TabIndex = 7;
            this.btnUsual.Text = "Обычный";
            this.btnUsual.UseSelectable = true;
            this.btnUsual.Click += new System.EventHandler(this.btnUsual_Click);
            // 
            // btnExam
            // 
            this.btnExam.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExam.Location = new System.Drawing.Point(103, 231);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(150, 50);
            this.btnExam.TabIndex = 8;
            this.btnExam.Text = "Экзамен";
            this.btnExam.UseSelectable = true;
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
            this.metroButtonBack.TabIndex = 10;
            this.metroButtonBack.Text = "Назад";
            this.metroButtonBack.UseSelectable = true;
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
            this.metroBtnExit.TabIndex = 9;
            this.metroBtnExit.Text = "Выйти";
            this.metroBtnExit.UseSelectable = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 358);
            this.Controls.Add(this.metroButtonBack);
            this.Controls.Add(this.metroBtnExit);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnUsual);
            this.Controls.Add(this.btnStandart);
            this.Name = "Test";
            this.Resizable = false;
            this.Text = "Выбор режима";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnStandart;
        private MetroFramework.Controls.MetroButton btnUsual;
        private MetroFramework.Controls.MetroButton btnExam;
        private MetroFramework.Controls.MetroButton metroButtonBack;
        private MetroFramework.Controls.MetroButton metroBtnExit;
    }
}