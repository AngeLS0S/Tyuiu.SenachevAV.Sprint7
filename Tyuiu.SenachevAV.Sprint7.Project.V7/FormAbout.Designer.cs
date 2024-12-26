namespace Tyuiu.SenachevAV.Sprint7.Project.V7
{
    partial class FormAbout_SAV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SAV));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(477, 90);
            label1.TabIndex = 0;
            label1.Text = "Разработчик: Сеначев А.В.\r\nГруппа: АСОиУБ-24-1\r\n\r\nРазработать Desktop приложение на основе Windows Forms по предметной области.\r\n\r\nВнутреннее имя: Tyuiu.SenachevAV.Sprint7.Project.V7";
            label1.Click += label1_Click;
            // 
            // FormAbout_SAV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 117);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FormAbout_SAV";
            Text = "О приложении";
            Load += FormAbout_SAV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}