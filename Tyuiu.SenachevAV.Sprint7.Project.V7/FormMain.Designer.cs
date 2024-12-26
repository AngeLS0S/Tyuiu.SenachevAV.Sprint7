namespace Tyuiu.SenachevAV.Sprint7.Project.V7
{
    partial class FormMain_SAV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SAV));
            Info_SAV = new GroupBox();
            InfoGrid_SAV = new DataGridView();
            buttonOpenFile_SAV = new Button();
            groupBoxEviction_SAV = new GroupBox();
            buttonDel_SAV = new Button();
            labelNumEnt_SAV = new Label();
            labelDeleteFlat_SAV = new Label();
            textBoxNumEntDel_SAV = new TextBox();
            textBoxNumFlatDel_SAV = new TextBox();
            groupBoxFiltr_SAV = new GroupBox();
            labelSortFlat_SAV = new Label();
            labelSortEnt_SAV = new Label();
            labelSortSumPeople_SAV = new Label();
            buttonMinNumFlat_SAV = new Button();
            buttonMinSumPeople_SAV = new Button();
            buttonMaxNumFlat_SAV = new Button();
            buttonMaxSumPeople_SAV = new Button();
            buttonMinNumEnt_SAV = new Button();
            buttonMaxNumEnt_SAV = new Button();
            groupBoxReg_SAV = new GroupBox();
            radioButtonBuy_SAV = new RadioButton();
            radioButtonRent_SAV = new RadioButton();
            buttonSave_SAV = new Button();
            labelSumRoom_SAV = new Label();
            labelAddFlat_SAV = new Label();
            labelAddEntrance_SAV = new Label();
            labelSumFlatArea_SAV = new Label();
            labelSumPep_SAV = new Label();
            labelFIO_SAV = new Label();
            textBoxSumRoom_SAV = new TextBox();
            textBoxAddFlat_SAV = new TextBox();
            textBoxAddEntrance_SAV = new TextBox();
            textBoxSumFlatArea_SAV = new TextBox();
            textBoxSumPeople_SAV = new TextBox();
            textBoxFIO_SAV = new TextBox();
            buttonHelp_SAV = new Button();
            buttonApplication_SAV = new Button();
            openFileDialog_SAV = new OpenFileDialog();
            saveFileDialog_SAV = new SaveFileDialog();
            toolTipHelp_SAV = new ToolTip(components);
            Info_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoGrid_SAV).BeginInit();
            groupBoxEviction_SAV.SuspendLayout();
            groupBoxFiltr_SAV.SuspendLayout();
            groupBoxReg_SAV.SuspendLayout();
            SuspendLayout();
            // 
            // Info_SAV
            // 
            Info_SAV.Controls.Add(InfoGrid_SAV);
            Info_SAV.Location = new Point(761, 53);
            Info_SAV.Name = "Info_SAV";
            Info_SAV.Size = new Size(406, 528);
            Info_SAV.TabIndex = 0;
            Info_SAV.TabStop = false;
            Info_SAV.Text = "Информация о кв";
            Info_SAV.Enter += Info_SAV_Enter;
            // 
            // InfoGrid_SAV
            // 
            InfoGrid_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoGrid_SAV.Dock = DockStyle.Fill;
            InfoGrid_SAV.Location = new Point(3, 19);
            InfoGrid_SAV.Name = "InfoGrid_SAV";
            InfoGrid_SAV.ReadOnly = true;
            InfoGrid_SAV.Size = new Size(400, 506);
            InfoGrid_SAV.TabIndex = 0;
            InfoGrid_SAV.CellContentClick += InfoGrid_SAV_CellContentClick;
            // 
            // buttonOpenFile_SAV
            // 
            buttonOpenFile_SAV.BackColor = Color.DarkGray;
            buttonOpenFile_SAV.Location = new Point(761, 1);
            buttonOpenFile_SAV.Name = "buttonOpenFile_SAV";
            buttonOpenFile_SAV.Size = new Size(400, 46);
            buttonOpenFile_SAV.TabIndex = 1;
            buttonOpenFile_SAV.Text = "Добавить";
            buttonOpenFile_SAV.UseVisualStyleBackColor = false;
            buttonOpenFile_SAV.Click += buttonFile_SAV_Click;
            // 
            // groupBoxEviction_SAV
            // 
            groupBoxEviction_SAV.BackColor = Color.WhiteSmoke;
            groupBoxEviction_SAV.Controls.Add(buttonDel_SAV);
            groupBoxEviction_SAV.Controls.Add(labelNumEnt_SAV);
            groupBoxEviction_SAV.Controls.Add(labelDeleteFlat_SAV);
            groupBoxEviction_SAV.Controls.Add(textBoxNumEntDel_SAV);
            groupBoxEviction_SAV.Controls.Add(textBoxNumFlatDel_SAV);
            groupBoxEviction_SAV.FlatStyle = FlatStyle.System;
            groupBoxEviction_SAV.ImeMode = ImeMode.NoControl;
            groupBoxEviction_SAV.Location = new Point(1, 157);
            groupBoxEviction_SAV.Name = "groupBoxEviction_SAV";
            groupBoxEviction_SAV.RightToLeft = RightToLeft.Yes;
            groupBoxEviction_SAV.Size = new Size(757, 130);
            groupBoxEviction_SAV.TabIndex = 0;
            groupBoxEviction_SAV.TabStop = false;
            groupBoxEviction_SAV.Text = "Выселение жильцов";
            // 
            // buttonDel_SAV
            // 
            buttonDel_SAV.Location = new Point(601, 49);
            buttonDel_SAV.Name = "buttonDel_SAV";
            buttonDel_SAV.Size = new Size(124, 34);
            buttonDel_SAV.TabIndex = 14;
            buttonDel_SAV.Text = "Удалить";
            buttonDel_SAV.UseVisualStyleBackColor = true;
            buttonDel_SAV.Click += buttonDel_SAV_Click;
            // 
            // labelNumEnt_SAV
            // 
            labelNumEnt_SAV.AutoSize = true;
            labelNumEnt_SAV.Location = new Point(170, 31);
            labelNumEnt_SAV.Name = "labelNumEnt_SAV";
            labelNumEnt_SAV.Size = new Size(98, 15);
            labelNumEnt_SAV.TabIndex = 13;
            labelNumEnt_SAV.Text = "Номер подъезда";
            // 
            // labelDeleteFlat_SAV
            // 
            labelDeleteFlat_SAV.AutoSize = true;
            labelDeleteFlat_SAV.Location = new Point(0, 31);
            labelDeleteFlat_SAV.Name = "labelDeleteFlat_SAV";
            labelDeleteFlat_SAV.Size = new Size(101, 15);
            labelDeleteFlat_SAV.TabIndex = 12;
            labelDeleteFlat_SAV.Text = "Номер квартиры";
            // 
            // textBoxNumEntDel_SAV
            // 
            textBoxNumEntDel_SAV.Location = new Point(170, 49);
            textBoxNumEntDel_SAV.Name = "textBoxNumEntDel_SAV";
            textBoxNumEntDel_SAV.Size = new Size(160, 23);
            textBoxNumEntDel_SAV.TabIndex = 11;
            // 
            // textBoxNumFlatDel_SAV
            // 
            textBoxNumFlatDel_SAV.Location = new Point(0, 49);
            textBoxNumFlatDel_SAV.Name = "textBoxNumFlatDel_SAV";
            textBoxNumFlatDel_SAV.Size = new Size(160, 23);
            textBoxNumFlatDel_SAV.TabIndex = 10;
            // 
            // groupBoxFiltr_SAV
            // 
            groupBoxFiltr_SAV.BackColor = Color.WhiteSmoke;
            groupBoxFiltr_SAV.Controls.Add(labelSortFlat_SAV);
            groupBoxFiltr_SAV.Controls.Add(labelSortEnt_SAV);
            groupBoxFiltr_SAV.Controls.Add(labelSortSumPeople_SAV);
            groupBoxFiltr_SAV.Controls.Add(buttonMinNumFlat_SAV);
            groupBoxFiltr_SAV.Controls.Add(buttonMinSumPeople_SAV);
            groupBoxFiltr_SAV.Controls.Add(buttonMaxNumFlat_SAV);
            groupBoxFiltr_SAV.Controls.Add(buttonMaxSumPeople_SAV);
            groupBoxFiltr_SAV.Controls.Add(buttonMinNumEnt_SAV);
            groupBoxFiltr_SAV.Controls.Add(buttonMaxNumEnt_SAV);
            groupBoxFiltr_SAV.FlatStyle = FlatStyle.System;
            groupBoxFiltr_SAV.Location = new Point(1, 293);
            groupBoxFiltr_SAV.Name = "groupBoxFiltr_SAV";
            groupBoxFiltr_SAV.RightToLeft = RightToLeft.Yes;
            groupBoxFiltr_SAV.Size = new Size(757, 187);
            groupBoxFiltr_SAV.TabIndex = 0;
            groupBoxFiltr_SAV.TabStop = false;
            groupBoxFiltr_SAV.Text = "Фильтр";
            groupBoxFiltr_SAV.Enter += groupBoxFiltr_SAV_Enter;
            // 
            // labelSortFlat_SAV
            // 
            labelSortFlat_SAV.AutoSize = true;
            labelSortFlat_SAV.Location = new Point(181, 4);
            labelSortFlat_SAV.Name = "labelSortFlat_SAV";
            labelSortFlat_SAV.Size = new Size(120, 15);
            labelSortFlat_SAV.TabIndex = 23;
            labelSortFlat_SAV.Text = "Сортировка по кв.м.\r\n";
            labelSortFlat_SAV.Click += label3_Click;
            // 
            // labelSortEnt_SAV
            // 
            labelSortEnt_SAV.AutoSize = true;
            labelSortEnt_SAV.Location = new Point(11, 4);
            labelSortEnt_SAV.Name = "labelSortEnt_SAV";
            labelSortEnt_SAV.Size = new Size(143, 15);
            labelSortEnt_SAV.TabIndex = 22;
            labelSortEnt_SAV.Text = "Сортировка по подъезду";
            // 
            // labelSortSumPeople_SAV
            // 
            labelSortSumPeople_SAV.AutoSize = true;
            labelSortSumPeople_SAV.Location = new Point(351, 4);
            labelSortSumPeople_SAV.Name = "labelSortSumPeople_SAV";
            labelSortSumPeople_SAV.Size = new Size(178, 15);
            labelSortSumPeople_SAV.TabIndex = 21;
            labelSortSumPeople_SAV.Text = "Сортировка по кол-ву человек";
            labelSortSumPeople_SAV.Click += label1_Click;
            // 
            // buttonMinNumFlat_SAV
            // 
            buttonMinNumFlat_SAV.Location = new Point(181, 76);
            buttonMinNumFlat_SAV.Name = "buttonMinNumFlat_SAV";
            buttonMinNumFlat_SAV.Size = new Size(149, 34);
            buttonMinNumFlat_SAV.TabIndex = 20;
            buttonMinNumFlat_SAV.Text = "Min";
            buttonMinNumFlat_SAV.UseVisualStyleBackColor = true;
            buttonMinNumFlat_SAV.Click += buttonMinNumFlat_SAV_Click;
            // 
            // buttonMinSumPeople_SAV
            // 
            buttonMinSumPeople_SAV.Location = new Point(351, 76);
            buttonMinSumPeople_SAV.Name = "buttonMinSumPeople_SAV";
            buttonMinSumPeople_SAV.Size = new Size(149, 34);
            buttonMinSumPeople_SAV.TabIndex = 19;
            buttonMinSumPeople_SAV.Text = "Min";
            buttonMinSumPeople_SAV.UseVisualStyleBackColor = true;
            buttonMinSumPeople_SAV.Click += buttonMinSumPeople_SAV_Click;
            // 
            // buttonMaxNumFlat_SAV
            // 
            buttonMaxNumFlat_SAV.Location = new Point(181, 22);
            buttonMaxNumFlat_SAV.Name = "buttonMaxNumFlat_SAV";
            buttonMaxNumFlat_SAV.Size = new Size(149, 34);
            buttonMaxNumFlat_SAV.TabIndex = 18;
            buttonMaxNumFlat_SAV.Text = "Max";
            buttonMaxNumFlat_SAV.UseVisualStyleBackColor = true;
            buttonMaxNumFlat_SAV.Click += buttonMaxNumFlat_SAV_Click;
            // 
            // buttonMaxSumPeople_SAV
            // 
            buttonMaxSumPeople_SAV.Location = new Point(351, 22);
            buttonMaxSumPeople_SAV.Name = "buttonMaxSumPeople_SAV";
            buttonMaxSumPeople_SAV.Size = new Size(149, 34);
            buttonMaxSumPeople_SAV.TabIndex = 17;
            buttonMaxSumPeople_SAV.Text = "Max";
            buttonMaxSumPeople_SAV.UseVisualStyleBackColor = true;
            buttonMaxSumPeople_SAV.Click += buttonMaxSumPeople_SAV_Click;
            // 
            // buttonMinNumEnt_SAV
            // 
            buttonMinNumEnt_SAV.Location = new Point(11, 76);
            buttonMinNumEnt_SAV.Name = "buttonMinNumEnt_SAV";
            buttonMinNumEnt_SAV.Size = new Size(149, 34);
            buttonMinNumEnt_SAV.TabIndex = 16;
            buttonMinNumEnt_SAV.Text = "Min";
            buttonMinNumEnt_SAV.UseVisualStyleBackColor = true;
            buttonMinNumEnt_SAV.Click += button2_Click;
            // 
            // buttonMaxNumEnt_SAV
            // 
            buttonMaxNumEnt_SAV.Location = new Point(11, 22);
            buttonMaxNumEnt_SAV.Name = "buttonMaxNumEnt_SAV";
            buttonMaxNumEnt_SAV.Size = new Size(149, 34);
            buttonMaxNumEnt_SAV.TabIndex = 15;
            buttonMaxNumEnt_SAV.Text = "Max";
            buttonMaxNumEnt_SAV.UseVisualStyleBackColor = true;
            buttonMaxNumEnt_SAV.Click += buttonMaxNumEnt_SAV_Click;
            // 
            // groupBoxReg_SAV
            // 
            groupBoxReg_SAV.BackColor = Color.WhiteSmoke;
            groupBoxReg_SAV.Controls.Add(radioButtonBuy_SAV);
            groupBoxReg_SAV.Controls.Add(radioButtonRent_SAV);
            groupBoxReg_SAV.Controls.Add(buttonSave_SAV);
            groupBoxReg_SAV.Controls.Add(labelSumRoom_SAV);
            groupBoxReg_SAV.Controls.Add(labelAddFlat_SAV);
            groupBoxReg_SAV.Controls.Add(labelAddEntrance_SAV);
            groupBoxReg_SAV.Controls.Add(labelSumFlatArea_SAV);
            groupBoxReg_SAV.Controls.Add(labelSumPep_SAV);
            groupBoxReg_SAV.Controls.Add(labelFIO_SAV);
            groupBoxReg_SAV.Controls.Add(textBoxSumRoom_SAV);
            groupBoxReg_SAV.Controls.Add(textBoxAddFlat_SAV);
            groupBoxReg_SAV.Controls.Add(textBoxAddEntrance_SAV);
            groupBoxReg_SAV.Controls.Add(textBoxSumFlatArea_SAV);
            groupBoxReg_SAV.Controls.Add(textBoxSumPeople_SAV);
            groupBoxReg_SAV.Controls.Add(textBoxFIO_SAV);
            groupBoxReg_SAV.FlatStyle = FlatStyle.System;
            groupBoxReg_SAV.Location = new Point(1, 1);
            groupBoxReg_SAV.Name = "groupBoxReg_SAV";
            groupBoxReg_SAV.RightToLeft = RightToLeft.Yes;
            groupBoxReg_SAV.Size = new Size(757, 150);
            groupBoxReg_SAV.TabIndex = 1;
            groupBoxReg_SAV.TabStop = false;
            groupBoxReg_SAV.Text = "Оформление жильцов";
            // 
            // radioButtonBuy_SAV
            // 
            radioButtonBuy_SAV.AutoSize = true;
            radioButtonBuy_SAV.Location = new Point(0, 125);
            radioButtonBuy_SAV.Name = "radioButtonBuy_SAV";
            radioButtonBuy_SAV.Size = new Size(72, 19);
            radioButtonBuy_SAV.TabIndex = 17;
            radioButtonBuy_SAV.TabStop = true;
            radioButtonBuy_SAV.Text = "Покупка";
            radioButtonBuy_SAV.UseVisualStyleBackColor = true;
            radioButtonBuy_SAV.CheckedChanged += radioButtonBuy_SAV_CheckedChanged;
            // 
            // radioButtonRent_SAV
            // 
            radioButtonRent_SAV.AutoSize = true;
            radioButtonRent_SAV.Location = new Point(7, 100);
            radioButtonRent_SAV.Name = "radioButtonRent_SAV";
            radioButtonRent_SAV.Size = new Size(65, 19);
            radioButtonRent_SAV.TabIndex = 16;
            radioButtonRent_SAV.TabStop = true;
            radioButtonRent_SAV.Text = "Аренда";
            radioButtonRent_SAV.UseVisualStyleBackColor = true;
            // 
            // buttonSave_SAV
            // 
            buttonSave_SAV.Location = new Point(601, 45);
            buttonSave_SAV.Name = "buttonSave_SAV";
            buttonSave_SAV.Size = new Size(124, 34);
            buttonSave_SAV.TabIndex = 0;
            buttonSave_SAV.Text = "Добавить";
            buttonSave_SAV.UseVisualStyleBackColor = true;
            buttonSave_SAV.Click += buttonSave_SAV_Click;
            // 
            // labelSumRoom_SAV
            // 
            labelSumRoom_SAV.AutoSize = true;
            labelSumRoom_SAV.Location = new Point(340, 53);
            labelSumRoom_SAV.Name = "labelSumRoom_SAV";
            labelSumRoom_SAV.Size = new Size(115, 15);
            labelSumRoom_SAV.TabIndex = 15;
            labelSumRoom_SAV.Text = "Количество комнат";
            // 
            // labelAddFlat_SAV
            // 
            labelAddFlat_SAV.AutoSize = true;
            labelAddFlat_SAV.Location = new Point(170, 53);
            labelAddFlat_SAV.Name = "labelAddFlat_SAV";
            labelAddFlat_SAV.Size = new Size(101, 15);
            labelAddFlat_SAV.TabIndex = 14;
            labelAddFlat_SAV.Text = "Номер квартиры";
            // 
            // labelAddEntrance_SAV
            // 
            labelAddEntrance_SAV.AutoSize = true;
            labelAddEntrance_SAV.Location = new Point(0, 53);
            labelAddEntrance_SAV.Name = "labelAddEntrance_SAV";
            labelAddEntrance_SAV.Size = new Size(98, 15);
            labelAddEntrance_SAV.TabIndex = 13;
            labelAddEntrance_SAV.Text = "Номер подъезда";
            // 
            // labelSumFlatArea_SAV
            // 
            labelSumFlatArea_SAV.AutoSize = true;
            labelSumFlatArea_SAV.Location = new Point(340, 5);
            labelSumFlatArea_SAV.Name = "labelSumFlatArea_SAV";
            labelSumFlatArea_SAV.Size = new Size(73, 15);
            labelSumFlatArea_SAV.TabIndex = 12;
            labelSumFlatArea_SAV.Text = "Кол-во кв.м";
            // 
            // labelSumPep_SAV
            // 
            labelSumPep_SAV.AutoSize = true;
            labelSumPep_SAV.Location = new Point(170, 8);
            labelSumPep_SAV.Name = "labelSumPep_SAV";
            labelSumPep_SAV.Size = new Size(120, 15);
            labelSumPep_SAV.TabIndex = 11;
            labelSumPep_SAV.Text = "Количество человек";
            labelSumPep_SAV.Click += labelSumPep_SAV_Click;
            // 
            // labelFIO_SAV
            // 
            labelFIO_SAV.AutoSize = true;
            labelFIO_SAV.Location = new Point(0, 8);
            labelFIO_SAV.Name = "labelFIO_SAV";
            labelFIO_SAV.Size = new Size(34, 15);
            labelFIO_SAV.TabIndex = 10;
            labelFIO_SAV.Text = "ФИО";
            // 
            // textBoxSumRoom_SAV
            // 
            textBoxSumRoom_SAV.Location = new Point(340, 71);
            textBoxSumRoom_SAV.Name = "textBoxSumRoom_SAV";
            textBoxSumRoom_SAV.Size = new Size(160, 23);
            textBoxSumRoom_SAV.TabIndex = 9;
            // 
            // textBoxAddFlat_SAV
            // 
            textBoxAddFlat_SAV.Location = new Point(170, 71);
            textBoxAddFlat_SAV.Name = "textBoxAddFlat_SAV";
            textBoxAddFlat_SAV.Size = new Size(160, 23);
            textBoxAddFlat_SAV.TabIndex = 8;
            // 
            // textBoxAddEntrance_SAV
            // 
            textBoxAddEntrance_SAV.Location = new Point(0, 71);
            textBoxAddEntrance_SAV.Name = "textBoxAddEntrance_SAV";
            textBoxAddEntrance_SAV.Size = new Size(160, 23);
            textBoxAddEntrance_SAV.TabIndex = 7;
            // 
            // textBoxSumFlatArea_SAV
            // 
            textBoxSumFlatArea_SAV.Location = new Point(340, 23);
            textBoxSumFlatArea_SAV.Name = "textBoxSumFlatArea_SAV";
            textBoxSumFlatArea_SAV.Size = new Size(160, 23);
            textBoxSumFlatArea_SAV.TabIndex = 6;
            textBoxSumFlatArea_SAV.TextChanged += textBox3_TextChanged;
            // 
            // textBoxSumPeople_SAV
            // 
            textBoxSumPeople_SAV.Location = new Point(170, 23);
            textBoxSumPeople_SAV.Name = "textBoxSumPeople_SAV";
            textBoxSumPeople_SAV.Size = new Size(160, 23);
            textBoxSumPeople_SAV.TabIndex = 5;
            // 
            // textBoxFIO_SAV
            // 
            textBoxFIO_SAV.Location = new Point(0, 23);
            textBoxFIO_SAV.Name = "textBoxFIO_SAV";
            textBoxFIO_SAV.Size = new Size(160, 23);
            textBoxFIO_SAV.TabIndex = 4;
            textBoxFIO_SAV.TextChanged += textBoxFIO_SAV_TextChanged;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.BackColor = Color.Silver;
            buttonHelp_SAV.Location = new Point(1, 495);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(107, 83);
            buttonHelp_SAV.TabIndex = 2;
            buttonHelp_SAV.Text = "Помощь";
            buttonHelp_SAV.UseVisualStyleBackColor = false;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // buttonApplication_SAV
            // 
            buttonApplication_SAV.BackColor = Color.Silver;
            buttonApplication_SAV.Location = new Point(114, 495);
            buttonApplication_SAV.Name = "buttonApplication_SAV";
            buttonApplication_SAV.Size = new Size(107, 83);
            buttonApplication_SAV.TabIndex = 3;
            buttonApplication_SAV.Text = "О приложении";
            buttonApplication_SAV.UseVisualStyleBackColor = false;
            buttonApplication_SAV.Click += buttonApplication_SAV_Click;
            // 
            // openFileDialog_SAV
            // 
            openFileDialog_SAV.FileName = "openFileDialog1";
            // 
            // toolTipHelp_SAV
            // 
            toolTipHelp_SAV.Popup += toolTip1_Popup;
            // 
            // FormMain_SAV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1165, 578);
            Controls.Add(buttonApplication_SAV);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(groupBoxFiltr_SAV);
            Controls.Add(groupBoxEviction_SAV);
            Controls.Add(groupBoxReg_SAV);
            Controls.Add(buttonOpenFile_SAV);
            Controls.Add(Info_SAV);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain_SAV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домоуправление";
            toolTipHelp_SAV.SetToolTip(this, "Если не знаешь что это делает, то есть кнопка \"Помощь\")\r\n");
            TransparencyKey = Color.Black;
            Info_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InfoGrid_SAV).EndInit();
            groupBoxEviction_SAV.ResumeLayout(false);
            groupBoxEviction_SAV.PerformLayout();
            groupBoxFiltr_SAV.ResumeLayout(false);
            groupBoxFiltr_SAV.PerformLayout();
            groupBoxReg_SAV.ResumeLayout(false);
            groupBoxReg_SAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Info_SAV;
        private DataGridView InfoGrid_SAV;
        private Button buttonOpenFile_SAV;
        private GroupBox groupBoxEviction_SAV;
        private GroupBox groupBox1;
        private GroupBox groupBoxFiltr_SAV;
        private GroupBox groupBoxReg_SAV;
        private Button buttonHelp_SAV;
        private Button buttonApplication_SAV;
        private TextBox textBoxSumFlatArea_SAV;
        private TextBox textBoxSumPeople_SAV;
        private TextBox textBoxFIO_SAV;
        private Label labelNumEnt_SAV;
        private Label labelDeleteFlat_SAV;
        private TextBox textBoxNumEntDel_SAV;
        private TextBox textBoxNumFlatDel_SAV;
        private Label labelSumRoom_SAV;
        private Label labelAddFlat_SAV;
        private Label labelAddEntrance_SAV;
        private Label labelSumFlatArea_SAV;
        private Label labelSumPep_SAV;
        private Label labelFIO_SAV;
        private TextBox textBoxSumRoom_SAV;
        private TextBox textBoxAddFlat_SAV;
        private TextBox textBoxAddEntrance_SAV;
        private Button buttonDel_SAV;
        private Button buttonSave_SAV;
        private Button buttonMinNumEnt_SAV;
        private Button buttonMaxNumEnt_SAV;
        private Button buttonMinNumFlat_SAV;
        private Button buttonMinSumPeople_SAV;
        private Button buttonMaxNumFlat_SAV;
        private Button buttonMaxSumPeople_SAV;
        private Label labelSortFlat_SAV;
        private Label labelSortEnt_SAV;
        private Label labelSortSumPeople_SAV;
        private RadioButton radioButtonBuy_SAV;
        private RadioButton radioButtonRent_SAV;
        private OpenFileDialog openFileDialog_SAV;
        private SaveFileDialog saveFileDialog_SAV;
        private ToolTip toolTipHelp_SAV;
    }
}
