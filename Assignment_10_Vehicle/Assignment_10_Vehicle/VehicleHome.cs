using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_10_Vehicle
{
    public partial class VehicleHome : Form
    {
        public VehicleHome()
        {
            InitializeComponent();
        }
        Vehicle vehicle=new Vehicle();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicle.VehicleName = textBoxVehicleName.Text;
            vehicle.RegNumber = textBoxRegNo.Text;
            textBoxVehicleName.Clear();
            textBoxRegNo.Clear();
            MessageBox.Show("Created");
        }
        List<int> speedList = new List<int>();
        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            vehicle.Speed = Convert.ToInt32(textBoxSpeed.Text);
            
            speedList.Add(vehicle.Speed);
            
            textBoxSpeed.Clear();
            //MessageBox.Show("Entered!");
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            textBoxMinSpeed.Text = Convert.ToString(speedList.Min());
            textBoxMaxSpeed.Text = Convert.ToString(speedList.Max());
            textBoxAverageSpeed.Text = Convert.ToString(speedList.Average());
            MessageBox.Show("Name: " + vehicle.VehicleName + " Reg No: " + vehicle.RegNumber+" Min "+ speedList.Min()+ " Max "+speedList.Max()+" Avg "+ speedList.Average());
        }
    }
}
