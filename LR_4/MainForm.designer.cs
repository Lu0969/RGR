namespace Car_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.carList = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.viewTool = new System.Windows.Forms.ToolStripButton();
            this.addTool = new System.Windows.Forms.ToolStripButton();
            this.editTool = new System.Windows.Forms.ToolStripButton();
            this.delTool = new System.Windows.Forms.ToolStripButton();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carList
            // 
            this.carList.DisplayMember = "ListItem";
            this.carList.FormattingEnabled = true;
            this.carList.Location = new System.Drawing.Point(12, 28);
            this.carList.Name = "carList";
            this.carList.Size = new System.Drawing.Size(210, 186);
            this.carList.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTool,
            this.addTool,
            this.editTool,
            this.delTool,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(234, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // viewTool
            // 
            this.viewTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewTool.Image = ((System.Drawing.Image)(resources.GetObject("viewTool.Image")));
            this.viewTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewTool.Name = "viewTool";
            this.viewTool.Size = new System.Drawing.Size(23, 22);
            this.viewTool.Text = "Open";
            this.viewTool.Click += new System.EventHandler(this.viewTool_Click);
            // 
            // addTool
            // 
            this.addTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTool.Image = ((System.Drawing.Image)(resources.GetObject("addTool.Image")));
            this.addTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTool.Name = "addTool";
            this.addTool.Size = new System.Drawing.Size(23, 22);
            this.addTool.Text = "New";
            this.addTool.Click += new System.EventHandler(this.addTool_Click);
            // 
            // editTool
            // 
            this.editTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editTool.Image = ((System.Drawing.Image)(resources.GetObject("editTool.Image")));
            this.editTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(23, 22);
            this.editTool.Text = "Edit";
            this.editTool.Click += new System.EventHandler(this.editTool_Click);
            // 
            // delTool
            // 
            this.delTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delTool.Image = ((System.Drawing.Image)(resources.GetObject("delTool.Image")));
            this.delTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delTool.Name = "delTool";
            this.delTool.Size = new System.Drawing.Size(23, 22);
            this.delTool.Text = "Delete";
            this.delTool.Click += new System.EventHandler(this.delTool_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "(*.bin)|*.bin";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton1.Text = "Сохранить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 224);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.carList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Машины GUI";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox carList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton viewTool;
        private System.Windows.Forms.ToolStripButton addTool;
        private System.Windows.Forms.ToolStripButton editTool;
        private System.Windows.Forms.ToolStripButton delTool;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

