namespace Car_GUI
{
    partial class OpenForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tonLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.dateList = new System.Windows.Forms.ListBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.brandText = new System.Windows.Forms.Label();
            this.powerText = new System.Windows.Forms.Label();
            this.tonText = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(77, 104);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 13);
            this.priceLabel.TabIndex = 26;
            this.priceLabel.Text = "Цена";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(239, 10);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 13);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Даты ремонта";
            // 
            // tonLabel
            // 
            this.tonLabel.AutoSize = true;
            this.tonLabel.Location = new System.Drawing.Point(6, 70);
            this.tonLabel.Name = "tonLabel";
            this.tonLabel.Size = new System.Drawing.Size(104, 13);
            this.tonLabel.TabIndex = 22;
            this.tonLabel.Text = "Грузоподъемность";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(50, 40);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(60, 13);
            this.powerLabel.TabIndex = 20;
            this.powerLabel.Text = "Мощность";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(70, 10);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(40, 13);
            this.brandLabel.TabIndex = 15;
            this.brandLabel.Text = "Марка";
            // 
            // dateList
            // 
            this.dateList.BackColor = System.Drawing.SystemColors.Control;
            this.dateList.FormattingEnabled = true;
            this.dateList.Location = new System.Drawing.Point(242, 26);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(152, 95);
            this.dateList.TabIndex = 30;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(319, 127);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 32;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // brandText
            // 
            this.brandText.AutoSize = true;
            this.brandText.Location = new System.Drawing.Point(117, 9);
            this.brandText.Name = "brandText";
            this.brandText.Size = new System.Drawing.Size(35, 13);
            this.brandText.TabIndex = 33;
            this.brandText.Text = "label1";
            // 
            // powerText
            // 
            this.powerText.AutoSize = true;
            this.powerText.Location = new System.Drawing.Point(117, 40);
            this.powerText.Name = "powerText";
            this.powerText.Size = new System.Drawing.Size(35, 13);
            this.powerText.TabIndex = 34;
            this.powerText.Text = "label1";
            // 
            // tonText
            // 
            this.tonText.AutoSize = true;
            this.tonText.Location = new System.Drawing.Point(117, 70);
            this.tonText.Name = "tonText";
            this.tonText.Size = new System.Drawing.Size(35, 13);
            this.tonText.TabIndex = 35;
            this.tonText.Text = "label1";
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Location = new System.Drawing.Point(117, 104);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(35, 13);
            this.priceText.TabIndex = 36;
            this.priceText.Text = "label1";
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 159);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.tonText);
            this.Controls.Add(this.powerText);
            this.Controls.Add(this.brandText);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.dateList);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.tonLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.brandLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OpenForm";
            this.Text = "OpenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label tonLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ListBox dateList;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label brandText;
        private System.Windows.Forms.Label powerText;
        private System.Windows.Forms.Label tonText;
        private System.Windows.Forms.Label priceText;
    }
}