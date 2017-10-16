using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    class Member
    {
        protected string firstName;
        protected string lastName;
        protected string socNumber;
        protected string memPhone;
        protected string streetAddy;
        protected string city;
        protected string state;
        protected string zip;
        protected string phone;
        protected string email;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocNumber { get; set; }
        public string MemPhone { get; set; }
        public string StreetAddy { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }

 
        public Member()
        {

        }

        public Member(string firstName, string lastName, string socNumber, string memPhone, string  streetAddy, string city, string state, string zip, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SocNumber = socNumber;
            this.memPhone = memPhone;
            this.StreetAddy = streetAddy;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Email = email;              
        }



        public string ViewInfo()
        {
            return "First Name: " + firstName + "\nLastName: " + lastName + "Social Security Number: " + socNumber + "\nPhone: " + memPhone + "\nStreet Address: " + streetAddy + "\n " + city + ", " + state + ", " + zip + "\nEmail: " + email;
        }

    }
}
