namespace Car_GUI
{
    partial class EditForm
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
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.powerBox = new System.Windows.Forms.MaskedTextBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.tonLabel = new System.Windows.Forms.Label();
            this.tonBox = new System.Windows.Forms.MaskedTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.MaskedTextBox();
            this.dateList = new System.Windows.Forms.ListBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(12, 9);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(40, 13);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Марка";
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(122, 6);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(142, 20);
            this.brandBox.TabIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 38);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(26, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Тип";
            // 
            // comboBox
            // 
            this.comboBox.Items.AddRange(new object[] {
            "Легковой",
            "Грузовой"});
            this.comboBox.Location = new System.Drawing.Point(122, 35);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(142, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.comboBox.TextChanged += new System.EventHandler(this.comboBox_TextUpdate);
            // 
            // powerBox
            // 
            this.powerBox.Enabled = false;
            this.powerBox.Location = new System.Drawing.Point(122, 62);
            this.powerBox.Mask = "0000";
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(142, 20);
            this.powerBox.TabIndex = 4;
            this.powerBox.ValidatingType = typeof(int);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(12, 65);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(60, 13);
            this.powerLabel.TabIndex = 5;
            this.powerLabel.Text = "Мощность";
            // 
            // tonLabel
            // 
            this.tonLabel.AutoSize = true;
            this.tonLabel.Location = new System.Drawing.Point(12, 91);
            this.tonLabel.Name = "tonLabel";
            this.tonLabel.Size = new System.Drawing.Size(104, 13);
            this.tonLabel.TabIndex = 7;
            this.tonLabel.Text = "Грузоподъемность";
            // 
            // tonBox
            // 
            this.tonBox.Enabled = false;
            this.tonBox.Location = new System.Drawing.Point(122, 88);
            this.tonBox.Mask = "0000";
            this.tonBox.Name = "tonBox";
            this.tonBox.Size = new System.Drawing.Size(142, 20);
            this.tonBox.TabIndex = 6;
            this.tonBox.ValidatingType = typeof(int);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 146);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 13);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Даты ремонта";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(122, 140);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 117);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 13);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Цена";
            // 
            // priceBox
            // 
            this.priceBox.Enabled = false;
            this.priceBox.Location = new System.Drawing.Point(122, 114);
            this.priceBox.Mask = "000000000000";
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(142, 20);
            this.priceBox.TabIndex = 10;
            this.priceBox.ValidatingType = typeof(int);
            // 
            // dateList
            // 
            this.dateList.FormattingEnabled = true;
            this.dateList.Location = new System.Drawing.Point(122, 167);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(142, 95);
            this.dateList.TabIndex = 12;
            this.dateList.DoubleClick += new System.EventHandler(this.dateList_DoubleClick);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(122, 268);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(61, 23);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(203, 268);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(61, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 298);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.dateList);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.tonLabel);
            this.Controls.Add(this.tonBox);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.brandLabel);
            this.Name = "EditForm";
            this.Text = "editForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.MaskedTextBox powerBox;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label tonLabel;
        private System.Windows.Forms.MaskedTextBox tonBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.MaskedTextBox priceBox;
        private System.Windows.Forms.ListBox dateList;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}