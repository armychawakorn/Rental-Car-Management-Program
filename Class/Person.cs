using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_for_rent.Class
{
    public class Person
    {
        private string ID;
        private string Name;
        private string Phone;
        private string Address;
        public Person(string iD, string name, string phone, string address)
        {
            this.ID = iD;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }
        public string getPersonalInformation(EPersonal personal)
        {
            string Data = null;
            switch(personal)
            {
                case EPersonal.ID:
                    Data = this.ID;
                    break;
                case EPersonal.Name:
                    Data = this.Name;
                    break;
                case EPersonal.Phone:
                    Data = this.Phone;
                    break;
                case EPersonal.Address:
                    Data = this.Address;
                    break;
            }
            return Data;
        }
    }
    public enum EPersonal
    {
        ID,
        Name,
        Phone,
        Address
    }
}
