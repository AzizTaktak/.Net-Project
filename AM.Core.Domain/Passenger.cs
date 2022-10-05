 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }  //EmailAddressAttribute  
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public int Age {
            get 
            {
                if (DateTime.Now.Month - BirthDate.Month > 0 ||
                (DateTime.Now.Month - BirthDate.Month == 0 && DateTime.Now.Day - BirthDate.Day >= 0))
                   return DateTime.Now.Year - BirthDate.Year;
                else
                    return  DateTime.Now.Year -BirthDate.Year - 1; 
            }
            }
        public override string ToString()
        {
            return "{BirthDate: " + BirthDate + "|" + "PassportNumber: " + PassportNumber + "|" + "EmailAddress: " + EmailAddress + "| FirstName: " + FirstName + "LastName: " + LastName + "|" + "TelNumber: " + TelNumber + "}";
        }
        //public bool CheckProfile(string FirstName,string LastName)
        //{
        //    return (FirstName == this.FirstName&&LastName==this.LastName);
        //}
        //public bool CheckProfile(string FirstName, string LastName, string EmailAddress)
        //{
        //    return (FirstName == this.FirstName && LastName == this.LastName && this.EmailAddress == EmailAddress);
        //}
        public bool CheckProfile(string FirstName, string LastName, string EmailAddress = null)
        {
            return (FirstName == this.FirstName && LastName == this.LastName && (EmailAddress == null || this.EmailAddress == EmailAddress));
        }
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
         public void GetAge(DateTime birthDate, ref int calculatedAge) // indication on peut utiliser DateTime.Now.DayOfYear 
        {
            if (DateTime.Now.Month - birthDate.Month > 0 ||
                (DateTime.Now.Month - birthDate.Month == 0 && DateTime.Now.Day - birthDate.Day >= 0))
                calculatedAge = DateTime.Now.Year - birthDate.Year;
            else
                calculatedAge = DateTime.Now.Year - birthDate.Year - 1;
        }
        public void GetAge(Passenger aPassenger)
        {
            
            if (DateTime.Now.Month - aPassenger.BirthDate.Month > 0 ||
                (DateTime.Now.Month - aPassenger.BirthDate.Month == 0 && DateTime.Now.Day - aPassenger.BirthDate.Day >= 0))
                aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year;
            else
                aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year - 1;
            
        }




    }
}
