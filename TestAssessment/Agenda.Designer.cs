namespace TestAssessment
{
    partial class Agenda
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
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblSurname = new MetroFramework.Controls.MetroLabel();
            this.lblGroup = new MetroFramework.Controls.MetroLabel();
            this.lblNumQ = new MetroFramework.Controls.MetroLabel();
            this.lblRight = new MetroFramework.Controls.MetroLabel();
            this.lblTheme = new MetroFramework.Controls.MetroLabel();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя тестируемого";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(23, 100);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(151, 19);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Фамилия тестируемого";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(23, 134);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(52, 19);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Группа";
            // 
            // lblNumQ
            // 
            this.lblNumQ.AutoSize = true;
            this.lblNumQ.Location = new System.Drawing.Point(23, 198);
            this.lblNumQ.Name = "lblNumQ";
            this.lblNumQ.Size = new System.Drawing.Size(122, 19);
            this.lblNumQ.TabIndex = 3;
            this.lblNumQ.Text = "Вопросов в тесте :";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(23, 233);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(177, 19);
            this.lblRight.TabIndex = 4;
            this.lblRight.Text = "Дано правильных ответов :";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(23, 166);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(127, 19);
            this.lblTheme.TabIndex = 5;
            this.lblTheme.Text = "Тема тестирования";
            // 
            // btnOK
            // 
            this.btnOK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOK.Location = new System.Drawing.Point(388, 271);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblNumQ);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "Agenda";
            this.Text = "Итоги тестирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblSurname;
        private MetroFramework.Controls.MetroLabel lblGroup;
        private MetroFramework.Controls.MetroLabel lblNumQ;
        private MetroFramework.Controls.MetroLabel lblRight;
        private MetroFramework.Controls.MetroLabel lblTheme;
        private MetroFramework.Controls.MetroButton btnOK;
    }
}