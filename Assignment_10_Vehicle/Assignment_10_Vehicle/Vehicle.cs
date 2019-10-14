using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10_Vehicle
{
    class Vehicle
    {
        private string vehicleName;
        private string regNumber;
        private int speed;
        private double avg;
        private int min;
        private int max;

        public Vehicle()
        {

        }
        public Vehicle(string vehicleName,string regNumber)
        {
            this.vehicleName = vehicleName;
            this.regNumber = regNumber;
        }
        public string VehicleName
        {
            set { this.vehicleName = value; }
            get { return this.vehicleName; }
        }

        public string RegNumber
        {
            set { this.regNumber = value; }
            get { return this.regNumber; }
        }

        List<int> speedList = new List<int>();
        public int Speed
        {
            set { this.speed = value; }
            get { return this.speed; }
        }

        public void SpeedList(int sp)
        {
            speedList.Add(sp);
        }

        public int MinSpeed()
        {
            min = speedList.Min();
            return min;
        }

        public int MaxSpeed()
        {
            max = speedList.Max();
            return max;
        }

        public double AvgSpeed()
        {
            avg = speedList.Average();
            return avg;
        }
    }
}
