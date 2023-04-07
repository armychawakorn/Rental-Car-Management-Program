using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Car_Management_Program.Class
{
    public class Cars
    {
        public static List<Car> AllCar = new List<Car>()
        {
            new Car("Toyota Camry", "91218", 10000),
            new Car("Honda Civic", "14142", 8000),
            new Car("Ford Mustang", "34534", 20000),
            new Car("Mazda CX-5", "36425", 12000),
            new Car("Nissan Altima", "34634", 15000),
            new Car("Chevrolet Impala", "32512", 18000),
            new Car("BMW X3", "32523", 30000),
            new Car("Audi A4", "43634", 28000),
            new Car("Volkswagen Jetta", "23521", 10000),
            new Car("Hyundai Sonata", "25352", 9000)
        };
    }
}
