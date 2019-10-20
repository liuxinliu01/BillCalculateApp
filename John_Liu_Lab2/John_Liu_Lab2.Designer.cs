namespace John_Liu_Lab2
{
    partial class John_Liu_Lab2
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
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CalculateResultValue = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.UsedHoursTextBox = new System.Windows.Forms.TextBox();
            this.UsedHoursInputLabel = new System.Windows.Forms.Label();
            this.OffPeakHoursTextBox = new System.Windows.Forms.TextBox();
            this.OffPeakHoursLable = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.AccountNumTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.CustomerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SumTotalValue = new System.Windows.Forms.Label();
            this.SumTotalLabel = new System.Windows.Forms.Label();
            this.SummeryBox = new System.Windows.Forms.ListBox();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.CustomerTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.IndustrialRadioBtn = new System.Windows.Forms.RadioButton();
            this.CommercialRadioBtn = new System.Windows.Forms.RadioButton();
            this.ResidentialRadioBtn = new System.Windows.Forms.RadioButton();
            this.CustomerCountLabel = new System.Windows.Forms.Label();
            this.CustomerCountValue = new System.Windows.Forms.Label();
            this.ResidentialCountLabel = new System.Windows.Forms.Label();
            this.ResidengtialCountValue = new System.Windows.Forms.Label();
            this.CommercialCountLabel = new System.Windows.Forms.Label();
            this.commercialCountValue = new System.Windows.Forms.Label();
            this.IndustrialCountLabel = new System.Windows.Forms.Label();
            this.IndustrialCountValue = new System.Windows.Forms.Label();
            this.CustomerListGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerInfoGroupBox.SuspendLayout();
            this.CustomerTypeGroupBox.SuspendLayout();
            this.CustomerListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(541, 136);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(134, 23);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CalculateResultValue
            // 
            this.CalculateResultValue.AutoSize = true;
            this.CalculateResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateResultValue.Location = new System.Drawing.Point(291, 160);
            this.CalculateResultValue.Name = "CalculateResultValue";
            this.CalculateResultValue.Size = new System.Drawing.Size(46, 16);
            this.CalculateResultValue.TabIndex = 3;
            this.CalculateResultValue.Text = "Result";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResultLabel.Location = new System.Drawing.Point(160, 160);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(125, 16);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Your total charge is:";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Enabled = false;
            this.CalculateBtn.Location = new System.Drawing.Point(541, 111);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(134, 23);
            this.CalculateBtn.TabIndex = 7;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // UsedHoursTextBox
            // 
            this.UsedHoursTextBox.Location = new System.Drawing.Point(291, 103);
            this.UsedHoursTextBox.Name = "UsedHoursTextBox";
            this.UsedHoursTextBox.Size = new System.Drawing.Size(151, 20);
            this.UsedHoursTextBox.TabIndex = 5;
            this.UsedHoursTextBox.TextChanged += new System.EventHandler(this.UsedHoursTextBox_TextChanged);
            // 
            // UsedHoursInputLabel
            // 
            this.UsedHoursInputLabel.AutoSize = true;
            this.UsedHoursInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedHoursInputLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsedHoursInputLabel.Location = new System.Drawing.Point(83, 106);
            this.UsedHoursInputLabel.Name = "UsedHoursInputLabel";
            this.UsedHoursInputLabel.Size = new System.Drawing.Size(202, 16);
            this.UsedHoursInputLabel.TabIndex = 0;
            this.UsedHoursInputLabel.Text = "Please enter the hours you used:";
            this.UsedHoursInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OffPeakHoursTextBox
            // 
            this.OffPeakHoursTextBox.Location = new System.Drawing.Point(291, 129);
            this.OffPeakHoursTextBox.Name = "OffPeakHoursTextBox";
            this.OffPeakHoursTextBox.Size = new System.Drawing.Size(151, 20);
            this.OffPeakHoursTextBox.TabIndex = 6;
            this.OffPeakHoursTextBox.TextChanged += new System.EventHandler(this.OffPeakHoursTextBox_TextChanged);
            // 
            // OffPeakHoursLable
            // 
            this.OffPeakHoursLable.AutoSize = true;
            this.OffPeakHoursLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffPeakHoursLable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OffPeakHoursLable.Location = new System.Drawing.Point(29, 133);
            this.OffPeakHoursLable.Name = "OffPeakHoursLable";
            this.OffPeakHoursLable.Size = new System.Drawing.Size(256, 16);
            this.OffPeakHoursLable.TabIndex = 11;
            this.OffPeakHoursLable.Text = "Please enter the hours used off peak time:";
            this.OffPeakHoursLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OffPeakHoursLable.Visible = false;
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(472, 465);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(75, 23);
            this.QuitBtn.TabIndex = 11;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // AccountNumTextBox
            // 
            this.AccountNumTextBox.Location = new System.Drawing.Point(541, 74);
            this.AccountNumTextBox.Name = "AccountNumTextBox";
            this.AccountNumTextBox.Size = new System.Drawing.Size(134, 20);
            this.AccountNumTextBox.TabIndex = 4;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(154, 65);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.ClientNameTextBox.TabIndex = 3;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.Location = new System.Drawing.Point(335, 65);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(107, 16);
            this.accountNumberLabel.TabIndex = 0;
            this.accountNumberLabel.Text = "Account number:";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(43, 65);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(105, 16);
            this.clientNameLabel.TabIndex = 0;
            this.clientNameLabel.Text = "Customer name:";
            // 
            // CustomerInfoGroupBox
            // 
            this.CustomerInfoGroupBox.Controls.Add(this.SumTotalValue);
            this.CustomerInfoGroupBox.Controls.Add(this.SumTotalLabel);
            this.CustomerInfoGroupBox.Controls.Add(this.SummeryBox);
            this.CustomerInfoGroupBox.Location = new System.Drawing.Point(12, 179);
            this.CustomerInfoGroupBox.Name = "CustomerInfoGroupBox";
            this.CustomerInfoGroupBox.Size = new System.Drawing.Size(514, 266);
            this.CustomerInfoGroupBox.TabIndex = 17;
            this.CustomerInfoGroupBox.TabStop = false;
            this.CustomerInfoGroupBox.Text = "Customer Infomation";
            // 
            // SumTotalValue
            // 
            this.SumTotalValue.AutoSize = true;
            this.SumTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumTotalValue.Location = new System.Drawing.Point(143, 163);
            this.SumTotalValue.Name = "SumTotalValue";
            this.SumTotalValue.Size = new System.Drawing.Size(39, 16);
            this.SumTotalValue.TabIndex = 3;
            this.SumTotalValue.Text = "Total";
            this.SumTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SumTotalLabel
            // 
            this.SumTotalLabel.AutoSize = true;
            this.SumTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumTotalLabel.Location = new System.Drawing.Point(17, 163);
            this.SumTotalLabel.Name = "SumTotalLabel";
            this.SumTotalLabel.Size = new System.Drawing.Size(123, 16);
            this.SumTotalLabel.TabIndex = 2;
            this.SumTotalLabel.Text = "Customer Bill Total:";
            this.SumTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SummeryBox
            // 
            this.SummeryBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummeryBox.FormattingEnabled = true;
            this.SummeryBox.Location = new System.Drawing.Point(0, 19);
            this.SummeryBox.Name = "SummeryBox";
            this.SummeryBox.Size = new System.Drawing.Size(508, 134);
            this.SummeryBox.TabIndex = 19;
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.Location = new System.Drawing.Point(12, 19);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(133, 134);
            this.CustomerListBox.TabIndex = 20;
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.Location = new System.Drawing.Point(315, 465);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(107, 23);
            this.SaveFileBtn.TabIndex = 10;
            this.SaveFileBtn.Text = "Save to File";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // LoadFileBtn
            // 
            this.LoadFileBtn.Location = new System.Drawing.Point(190, 465);
            this.LoadFileBtn.Name = "LoadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(107, 23);
            this.LoadFileBtn.TabIndex = 9;
            this.LoadFileBtn.Text = "Load from File";
            this.LoadFileBtn.UseVisualStyleBackColor = true;
            this.LoadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // CustomerTypeGroupBox
            // 
            this.CustomerTypeGroupBox.Controls.Add(this.IndustrialRadioBtn);
            this.CustomerTypeGroupBox.Controls.Add(this.CommercialRadioBtn);
            this.CustomerTypeGroupBox.Controls.Add(this.ResidentialRadioBtn);
            this.CustomerTypeGroupBox.Location = new System.Drawing.Point(63, 19);
            this.CustomerTypeGroupBox.Name = "CustomerTypeGroupBox";
            this.CustomerTypeGroupBox.Size = new System.Drawing.Size(614, 40);
            this.CustomerTypeGroupBox.TabIndex = 16;
            this.CustomerTypeGroupBox.TabStop = false;
            this.CustomerTypeGroupBox.Text = "Customer Type";
            // 
            // IndustrialRadioBtn
            // 
            this.IndustrialRadioBtn.AutoSize = true;
            this.IndustrialRadioBtn.Location = new System.Drawing.Point(443, 17);
            this.IndustrialRadioBtn.Name = "IndustrialRadioBtn";
            this.IndustrialRadioBtn.Size = new System.Drawing.Size(67, 17);
            this.IndustrialRadioBtn.TabIndex = 2;
            this.IndustrialRadioBtn.TabStop = true;
            this.IndustrialRadioBtn.Text = "Industrial";
            this.IndustrialRadioBtn.UseVisualStyleBackColor = true;
            this.IndustrialRadioBtn.CheckedChanged += new System.EventHandler(this.IndustrialRadioBtn_CheckedChanged);
            // 
            // CommercialRadioBtn
            // 
            this.CommercialRadioBtn.AutoSize = true;
            this.CommercialRadioBtn.Location = new System.Drawing.Point(225, 17);
            this.CommercialRadioBtn.Name = "CommercialRadioBtn";
            this.CommercialRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.CommercialRadioBtn.TabIndex = 1;
            this.CommercialRadioBtn.TabStop = true;
            this.CommercialRadioBtn.Text = "Commercial";
            this.CommercialRadioBtn.UseVisualStyleBackColor = true;
            this.CommercialRadioBtn.CheckedChanged += new System.EventHandler(this.CommercialRadioBtn_CheckedChanged);
            // 
            // ResidentialRadioBtn
            // 
            this.ResidentialRadioBtn.AutoSize = true;
            this.ResidentialRadioBtn.Location = new System.Drawing.Point(9, 17);
            this.ResidentialRadioBtn.Name = "ResidentialRadioBtn";
            this.ResidentialRadioBtn.Size = new System.Drawing.Size(77, 17);
            this.ResidentialRadioBtn.TabIndex = 0;
            this.ResidentialRadioBtn.TabStop = true;
            this.ResidentialRadioBtn.Text = "Residential";
            this.ResidentialRadioBtn.UseVisualStyleBackColor = true;
            this.ResidentialRadioBtn.CheckedChanged += new System.EventHandler(this.ResidentialRadioBtn_CheckedChanged);
            // 
            // CustomerCountLabel
            // 
            this.CustomerCountLabel.AutoSize = true;
            this.CustomerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCountLabel.Location = new System.Drawing.Point(6, 160);
            this.CustomerCountLabel.Name = "CustomerCountLabel";
            this.CustomerCountLabel.Size = new System.Drawing.Size(109, 16);
            this.CustomerCountLabel.TabIndex = 4;
            this.CustomerCountLabel.Text = "Total Customers:";
            this.CustomerCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerCountValue
            // 
            this.CustomerCountValue.AutoSize = true;
            this.CustomerCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCountValue.Location = new System.Drawing.Point(118, 160);
            this.CustomerCountValue.Name = "CustomerCountValue";
            this.CustomerCountValue.Size = new System.Drawing.Size(17, 16);
            this.CustomerCountValue.TabIndex = 5;
            this.CustomerCountValue.Text = "C";
            // 
            // ResidentialCountLabel
            // 
            this.ResidentialCountLabel.AutoSize = true;
            this.ResidentialCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidentialCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResidentialCountLabel.Location = new System.Drawing.Point(36, 184);
            this.ResidentialCountLabel.Name = "ResidentialCountLabel";
            this.ResidentialCountLabel.Size = new System.Drawing.Size(79, 16);
            this.ResidentialCountLabel.TabIndex = 4;
            this.ResidentialCountLabel.Text = "Residential:";
            this.ResidentialCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResidengtialCountValue
            // 
            this.ResidengtialCountValue.AutoSize = true;
            this.ResidengtialCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResidengtialCountValue.Location = new System.Drawing.Point(118, 184);
            this.ResidengtialCountValue.Name = "ResidengtialCountValue";
            this.ResidengtialCountValue.Size = new System.Drawing.Size(17, 16);
            this.ResidengtialCountValue.TabIndex = 5;
            this.ResidengtialCountValue.Text = "C";
            // 
            // CommercialCountLabel
            // 
            this.CommercialCountLabel.AutoSize = true;
            this.CommercialCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommercialCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CommercialCountLabel.Location = new System.Drawing.Point(32, 204);
            this.CommercialCountLabel.Name = "CommercialCountLabel";
            this.CommercialCountLabel.Size = new System.Drawing.Size(83, 16);
            this.CommercialCountLabel.TabIndex = 4;
            this.CommercialCountLabel.Text = "Commercial:";
            this.CommercialCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // commercialCountValue
            // 
            this.commercialCountValue.AutoSize = true;
            this.commercialCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commercialCountValue.Location = new System.Drawing.Point(118, 204);
            this.commercialCountValue.Name = "commercialCountValue";
            this.commercialCountValue.Size = new System.Drawing.Size(17, 16);
            this.commercialCountValue.TabIndex = 5;
            this.commercialCountValue.Text = "C";
            // 
            // IndustrialCountLabel
            // 
            this.IndustrialCountLabel.AutoSize = true;
            this.IndustrialCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustrialCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IndustrialCountLabel.Location = new System.Drawing.Point(51, 224);
            this.IndustrialCountLabel.Name = "IndustrialCountLabel";
            this.IndustrialCountLabel.Size = new System.Drawing.Size(64, 16);
            this.IndustrialCountLabel.TabIndex = 4;
            this.IndustrialCountLabel.Text = "Industrial:";
            this.IndustrialCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IndustrialCountValue
            // 
            this.IndustrialCountValue.AutoSize = true;
            this.IndustrialCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustrialCountValue.Location = new System.Drawing.Point(118, 224);
            this.IndustrialCountValue.Name = "IndustrialCountValue";
            this.IndustrialCountValue.Size = new System.Drawing.Size(17, 16);
            this.IndustrialCountValue.TabIndex = 5;
            this.IndustrialCountValue.Text = "C";
            // 
            // CustomerListGroupBox
            // 
            this.CustomerListGroupBox.Controls.Add(this.CustomerCountValue);
            this.CustomerListGroupBox.Controls.Add(this.CustomerListBox);
            this.CustomerListGroupBox.Controls.Add(this.CustomerCountLabel);
            this.CustomerListGroupBox.Controls.Add(this.IndustrialCountValue);
            this.CustomerListGroupBox.Controls.Add(this.ResidentialCountLabel);
            this.CustomerListGroupBox.Controls.Add(this.CommercialCountLabel);
            this.CustomerListGroupBox.Controls.Add(this.commercialCountValue);
            this.CustomerListGroupBox.Controls.Add(this.IndustrialCountLabel);
            this.CustomerListGroupBox.Controls.Add(this.ResidengtialCountValue);
            this.CustomerListGroupBox.Location = new System.Drawing.Point(532, 179);
            this.CustomerListGroupBox.Name = "CustomerListGroupBox";
            this.CustomerListGroupBox.Size = new System.Drawing.Size(161, 266);
            this.CustomerListGroupBox.TabIndex = 18;
            this.CustomerListGroupBox.TabStop = false;
            this.CustomerListGroupBox.Text = "Customer List";
            // 
            // John_Liu_Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 500);
            this.Controls.Add(this.CustomerListGroupBox);
            this.Controls.Add(this.CalculateResultValue);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CustomerTypeGroupBox);
            this.Controls.Add(this.OffPeakHoursTextBox);
            this.Controls.Add(this.CustomerInfoGroupBox);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.OffPeakHoursLable);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.UsedHoursTextBox);
            this.Controls.Add(this.LoadFileBtn);
            this.Controls.Add(this.UsedHoursInputLabel);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.AccountNumTextBox);
            this.Controls.Add(this.ClientNameTextBox);
            this.Name = "John_Liu_Lab2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.John_Liu_Lab1_Load);
            this.CustomerInfoGroupBox.ResumeLayout(false);
            this.CustomerInfoGroupBox.PerformLayout();
            this.CustomerTypeGroupBox.ResumeLayout(false);
            this.CustomerTypeGroupBox.PerformLayout();
            this.CustomerListGroupBox.ResumeLayout(false);
            this.CustomerListGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox UsedHoursTextBox;
        private System.Windows.Forms.Label UsedHoursInputLabel;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox OffPeakHoursTextBox;
        private System.Windows.Forms.Label OffPeakHoursLable;
        private System.Windows.Forms.TextBox AccountNumTextBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.GroupBox CustomerInfoGroupBox;
        private System.Windows.Forms.ListBox SummeryBox;
        private System.Windows.Forms.Label CalculateResultValue;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.GroupBox CustomerTypeGroupBox;
        private System.Windows.Forms.RadioButton IndustrialRadioBtn;
        private System.Windows.Forms.RadioButton CommercialRadioBtn;
        private System.Windows.Forms.RadioButton ResidentialRadioBtn;
        private System.Windows.Forms.Label CustomerCountValue;
        private System.Windows.Forms.Label CustomerCountLabel;
        private System.Windows.Forms.Label SumTotalValue;
        private System.Windows.Forms.Label SumTotalLabel;
        private System.Windows.Forms.Label IndustrialCountValue;
        private System.Windows.Forms.Label commercialCountValue;
        private System.Windows.Forms.Label ResidengtialCountValue;
        private System.Windows.Forms.Label IndustrialCountLabel;
        private System.Windows.Forms.Label CommercialCountLabel;
        private System.Windows.Forms.Label ResidentialCountLabel;
        private System.Windows.Forms.GroupBox CustomerListGroupBox;
    }
}

