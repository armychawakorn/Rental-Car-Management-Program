using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Car_Management_Program.Class
{
    public class Car
    {
        private string CarModel;
        private string licensePlate;
        private decimal pricePerDay;
        public Car(string CarName, string CarID, decimal price)
        {
            this.CarModel = CarName;
            this.licensePlate = CarID;
            this.pricePerDay = price;
        }
        public string getCarName()
        {
            return this.CarModel;
        }
        public string getCatID()
        {
            return this.licensePlate;
        }
        public decimal getPrice()
        {
            return pricePerDay;
        }
    }
}
