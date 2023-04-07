using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_for_rent.Class
{
    public class Car
    {
        private string CarName;
        private string CarID;
        private decimal price;
        public Car(string CarName, string CarID, decimal price)
        {
            this.CarName = CarName;
            this.CarID = CarID;
            this.price = price;
        }
        public string getCarName()
        {
            return this.CarName;
        }
        public string getCatID()
        {
            return this.CarID;
        }
        public decimal getPrice()
        {
            return price;
        }
    }
}
