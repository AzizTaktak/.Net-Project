using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AM.Core.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return "{EmployementDate: " + EmployementDate + "|" + "Function: " + Function + "|" + "Salary: " + Salary + "}";
        }
        public override string GetPassengerType()
        {
            return base.GetPassengerType + "I am a Staff Member";
        }
    }
}
