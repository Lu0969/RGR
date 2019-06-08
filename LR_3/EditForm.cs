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
    public partial class EditForm : Form
    {
        private List<DateTime> repaireList = new List<DateTime>();
        private Truck savedTruck;
        private Car savedCar;
        private bool isTruck = false;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(String type, Car car)
        {
            InitializeComponent();
            if (type == "T")
            {
                isTruck = true;
                Truck truck = (Truck)car;
                brandBox.Text = truck.Brand;
                comboBox.Text = "Грузовой";
                comboBox.Enabled = false;
                powerBox.Text = "" + truck.Power;
                tonBox.Text = "" + truck.Tonnage;
                priceBox.Text = "" + truck.Price;
                foreach (DateTime item in truck.RepaireDate)
                    dateList.Items.Add(item);
            }
            else if(type == "C")
            {
                brandBox.Text = car.Brand;
                comboBox.Text = "Легковой";
                comboBox.Enabled = false;
                powerBox.Text = "" + car.Power;
                priceBox.Text = "" + car.Price;
                foreach (DateTime item in car.RepaireDate)
                    dateList.Items.Add(item);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateList.Items.Add(dateTimePicker.Text);
            repaireList.Add(dateTimePicker.Value);
        }

        private void dateList_DoubleClick(object sender, EventArgs e)
        {
            dateList.Items.Remove(dateList.SelectedItem);
            repaireList.RemoveAt(dateList.SelectedIndex);
        }

        private void comboBox_TextUpdate(object sender, EventArgs e)
        {
            powerBox.Enabled = true;
            priceBox.Enabled = true;
            if (comboBox.Text == "Грузовой")
                tonBox.Enabled = true;
            else
                tonBox.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Car saveCar()
        {
            String brand = brandBox.Text;
            int power = Convert.ToInt32(powerBox.Text);
            int price = Convert.ToInt32(priceBox.Text);
            List<DateTime> list = repaireList;
            return new Car(brand, power, price, list);
        }

        private Truck saveTruck()
        {
            String brand = brandBox.Text;
            int power = Convert.ToInt32(powerBox.Text);
            int price = Convert.ToInt32(priceBox.Text);
            int tonnage = Convert.ToInt32(tonBox.Text);
            List<DateTime> list = repaireList;
            return new Truck(brand, power, tonnage, price, list);
        }

        public bool IsTruck
        {
            get { return isTruck; }
        }

        public Car SavedCar
        {
            get { return savedCar; }
        }

        public Truck SavedTruck
        {
            get { return savedTruck; }
        }

        private bool checkBoxes()
        {
            if (brandBox.Text == "" || comboBox.Text == "" || priceBox.Text == "" || powerBox.Text == "")
                return false;
            else
                return true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkBoxes())
            {
                if (comboBox.Text == "Грузовой")
                {
                    savedTruck = saveTruck();
                    isTruck = true;
                }
                else
                {
                    savedCar = saveCar();
                    isTruck = false;
                }
                Close();
            }
            else
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
