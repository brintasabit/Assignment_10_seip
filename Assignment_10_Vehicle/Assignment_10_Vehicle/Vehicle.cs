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
       // List<int> speedList = new List<int>();
        public int Speed
        {
            set { this.speed = value; }
            get { return this.speed; }
           // speedList.Add(speed);
        }
        
      /*  public int MinSpeed()
        {
            
            
            int min = speedList.Min();
            return min;

        }*/
    }
}
