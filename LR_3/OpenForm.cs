using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_GUI
{
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        public OpenForm(String type, Car car)
        {
            InitializeComponent();
            if (type == "T")
            {
                Truck truck = (Truck)car;
                brandText.Text = truck.Brand;
                powerText.Text = "" + truck.Power;
                tonText.Text = "" + truck.Tonnage;
                priceText.Text = "" + truck.Price;
                foreach (DateTime item in truck.RepaireDate)
                    dateList.Items.Add(item);
            }
            else
            {
                brandText.Text = car.Brand;
                powerText.Text = "" + car.Power;
                priceText.Text = "" + car.Price;
                foreach (DateTime item in car.RepaireDate)
                    dateList.Items.Add(item);
                tonText.Visible = false;
                tonLabel.Visible = false;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
