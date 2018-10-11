namespace TestAssessment
{
    partial class TestEditor
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.msmEditor = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnExit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(13, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(261, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Создание нового тестирования";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(13, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Категория";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(13, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Имя";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(13, 223);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Тема";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(266, 121);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(183, 25);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Количество вопросов";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(455, 126);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(111, 174);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(390, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Location = new System.Drawing.Point(111, 228);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(390, 20);
            this.textBoxTheme.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOK.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnOK.Location = new System.Drawing.Point(359, 265);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // msmEditor
            // 
            this.msmEditor.Owner = this;
            // 
            // btnExit
            // 
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.Location = new System.Drawing.Point(455, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TestEditor";
            this.Resizable = false;
            this.Text = "Редактор тестов";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTheme;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Components.MetroStyleManager msmEditor;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}