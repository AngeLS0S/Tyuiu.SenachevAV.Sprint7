namespace Tyuiu.SenachevAV.Sprint7.Project.V7
{
    partial class FormHelp_SAV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp_SAV));
            labelHelp_SAV = new Label();
            SuspendLayout();
            // 
            // labelHelp_SAV
            // 
            labelHelp_SAV.AutoSize = true;
            labelHelp_SAV.Location = new Point(4, 10);
            labelHelp_SAV.Name = "labelHelp_SAV";
            labelHelp_SAV.Size = new Size(703, 90);
            labelHelp_SAV.TabIndex = 1;
            labelHelp_SAV.Text = resources.GetString("labelHelp_SAV.Text");
            // 
            // FormHelp_SAV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 113);
            Controls.Add(labelHelp_SAV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormHelp_SAV";
            Text = "Помощь";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHelp_SAV;
    }
}