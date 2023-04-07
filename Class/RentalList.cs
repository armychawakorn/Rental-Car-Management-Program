using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Car_Management_Program.Class
{
    public class RentalList
    {
        private Person Customer_Information;
        private Car Customer_Car;
        private decimal Price;
        private DateTime TimeStart;
        private DateTime TimeEnd;
        public RentalList(Person customer_Information, Car customer_Car, decimal price, DateTime timeStart, DateTime timeEnd)
        {
            this.Customer_Car = customer_Car;
            this.Customer_Information = customer_Information;
            this.Price = price;
            this.TimeStart = timeStart;
            this.TimeEnd = timeEnd;
        }
        public Car getCustomerCar()
        {
            return Customer_Car;
        }
        public Person getCustomer()
        {
            return Customer_Information;
        }
        public decimal getPrice()
        {
            return Price;
        }
        public DateTime getTimeStart()
        {
            return TimeStart;
        }
        public DateTime getTimeEnd()
        {
            return TimeEnd;
        }
    }
}
