using Car_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mashini_MDI
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            MainForm frm = new MainForm(MainForm.load(openFile.FileName), openFile.FileName);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
