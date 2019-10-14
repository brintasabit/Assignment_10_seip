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
        //RefrigeratorHome refrigeratorHome=new RefrigeratorHome();
        public VehicleHome()
        {
            InitializeComponent();
        }

        //private Vehicle vehicle;
        Vehicle vehicle=new Vehicle();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicle.VehicleName = textBoxVehicleName.Text;
            vehicle.RegNumber = textBoxRegNo.Text;
            //vehicle=new Vehicle(textBoxVehicleName.Text,textBoxRegNo.Text);
            textBoxVehicleName.Clear();
            textBoxRegNo.Clear();
            MessageBox.Show("Created");
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            //vehicle=new Vehicle();
            vehicle.Speed = Convert.ToInt32(textBoxSpeed.Text);
            vehicle.SpeedList(vehicle.Speed);
            textBoxSpeed.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            textBoxMinSpeed.Text = Convert.ToString(vehicle.MinSpeed());
            textBoxMaxSpeed.Text = Convert.ToString(vehicle.MaxSpeed());
            textBoxAverageSpeed.Text = Convert.ToString(vehicle.AvgSpeed());
            MessageBox.Show("Name: " + vehicle.VehicleName + " Reg No: " + vehicle.RegNumber+" Min: "+ vehicle.MinSpeed()+ " Max: "+vehicle.MaxSpeed()+" Avg: "+ vehicle.AvgSpeed());
        }

        //private void RefrigeratorButton_Click(object sender, EventArgs e)
        //{
        //    if (refrigeratorHome.IsDisposed)
        //    {
        //        refrigeratorHome=new RefrigeratorHome();
        //    }
        //    refrigeratorHome.Show();
        //    refrigeratorHome.BringToFront();
        //}
    }
}
