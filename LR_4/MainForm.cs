using Mashini_MDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_GUI
{
    public partial class MainForm : Form
    {
        List<Car> listOfCars = new List<Car>();
        List<Truck> listOfTrucks = new List<Truck>();
        String url;

        public MainForm()
        {
            InitializeComponent();
            url = "State.bin";
            save(url);
        }

        public MainForm(Lists lists, String url)
        {
            InitializeComponent();
            listOfCars = lists.Cars;
            listOfTrucks = lists.Trucks;
            this.url = url;
        }

        private void update()
        {
            carList.Items.Clear();
            Lists lists = load(url);
            listOfTrucks = lists.Trucks;
            foreach (Car item in lists.Cars)
                carList.Items.Add(item);
            foreach (Truck item in lists.Trucks)
                carList.Items.Add(item);
        }

        private void addTool_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.ShowDialog();
            if(edit.IsTruck)
            {
                listOfTrucks.Add(edit.SavedTruck);
                carList.Items.Add(edit.SavedTruck);
            }
            else
            {
                listOfCars.Add(edit.SavedCar);
                carList.Items.Add(edit.SavedCar);
            }
            save(url);
        }

        private void delTool_Click(object sender, EventArgs e)
        {
            if(carList.SelectedItem != null)
            {
                if(carList.SelectedItem.GetType() == new Truck().GetType())
                    listOfTrucks.Remove((Truck)carList.SelectedItem);
                else
                    listOfCars.Remove((Car)carList.SelectedItem);
                carList.Items.Remove(carList.SelectedItem);
            }
            save(url);
        }

        private void editTool_Click(object sender, EventArgs e)
        {
            if (carList.SelectedItem != null)
            {
                EditForm edit = new EditForm(carList.SelectedItem);
                edit.ShowDialog();
                if (edit.IsTruck)
                {
                    listOfTrucks.Add(edit.SavedTruck);
                    carList.Items.Add(edit.SavedTruck);
                }
                else
                {
                    listOfCars.Add(edit.SavedCar);
                    carList.Items.Add(edit.SavedCar);
                }
                carList.Items.Remove(carList.SelectedItem);
                save(url);
            }
        }

        private void viewTool_Click(object sender, EventArgs e)
        {
            if (carList.SelectedItem != null)
            {
                OpenForm frm = new OpenForm(carList.SelectedItem);
                frm.ShowDialog();
            }
        }

        private void save(String file)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(file, FileMode.Create);

            Lists lists = new Lists(listOfCars, listOfTrucks);
            formatter.Serialize(stream, lists);
            stream.Close();
        }

        static public Lists load(String file)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(file, FileMode.Open);

            Lists lists = (Lists)formatter.Deserialize(stream);
            stream.Close();
            return lists;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            update();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
            url = saveFile.FileName;
            save(url);
        }
    }
}
