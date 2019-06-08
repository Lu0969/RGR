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
    public partial class MainForm : Form
    {
        List<Car> listOfCars = new List<Car>();
        List<Truck> listOfTrucks = new List<Truck>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addTool_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.ShowDialog();
            if(edit.IsTruck)
            {
                listOfTrucks.Add(edit.SavedTruck);
                carList.Items.Add("T " + edit.SavedTruck.Brand + " " + edit.SavedTruck.Power + " " + edit.SavedTruck.Tonnage + " " + edit.SavedTruck.Price);
            }
            else
            {
                listOfCars.Add(edit.SavedCar);
                carList.Items.Add("C " + edit.SavedCar.Brand + " " + edit.SavedCar.Power + " " + edit.SavedCar.Price);
            }
        }

        private void delTool_Click(object sender, EventArgs e)
        {
            if(carList.SelectedItem != null)
            {
                deleteItem();
                carList.Items.Remove(carList.SelectedItem);
            }
        }

        private void deleteItem()
        {
            if (carList.SelectedItem != null)
            {
                String item = carList.SelectedItem.ToString();
                String[] split = item.Split(' ');
                if (split[0] == "T")
                {
                    listOfTrucks.Remove((Truck)GetSelectedItem());
                }
                else
                {
                    listOfCars.Remove(GetSelectedItem());
                }
            }
        }

        private Car GetSelectedItem()
        {
            if (carList.SelectedItem != null)
            {
                String car = carList.SelectedItem.ToString();
                String[] split = car.Split(' ');
                if (split[0] == "T")
                {
                    foreach (Truck item in listOfTrucks)
                        if (split[1] == item.Brand && Int32.Parse(split[2]) == item.Power && Int32.Parse(split[3]) == item.Tonnage && Int32.Parse(split[4]) == item.Price)
                            return item;
                }
                else
                {
                    foreach (Car item in listOfCars)
                        if (split[1] == item.Brand && Int32.Parse(split[2]) == item.Power && Int32.Parse(split[3]) == item.Price)
                            return item;
                }
            }
            return null;
        }

        private void editTool_Click(object sender, EventArgs e)
        {
            if (carList.SelectedItem != null)
            {
                String item = carList.SelectedItem.ToString();
                String[] split = item.Split(' ');
                EditForm edit = new EditForm(split[0], GetSelectedItem());
                edit.ShowDialog();
                if (edit.IsTruck)
                {
                    listOfTrucks.Add(edit.SavedTruck);
                    carList.Items.Add("T " + edit.SavedTruck.Brand + " " + edit.SavedTruck.Power + " " + edit.SavedTruck.Tonnage + " " + edit.SavedTruck.Price);
                }
                else
                {
                    listOfCars.Add(edit.SavedCar);
                    carList.Items.Add("C " + edit.SavedCar.Brand + " " + edit.SavedCar.Power + " " + edit.SavedCar.Price);
                }
                deleteItem();
                carList.Items.Remove(carList.SelectedItem);
            }
        }

        private void viewTool_Click(object sender, EventArgs e)
        {
            if (carList.SelectedItem != null)
            {
                String item = carList.SelectedItem.ToString();
                String[] split = item.Split(' ');
                OpenForm open = new OpenForm(split[0], GetSelectedItem());
                open.ShowDialog();              
            }
        }
    }
}
