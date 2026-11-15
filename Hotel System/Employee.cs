using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System
{
    internal class Employee : Person
    {
        public int WorkingDays { get; set; }
        public string Position { get; set; }
        public double Salary { get; private set; }

        public void CalculateSalary()
        {
            double dailyRate;

            switch (Position)
            {
                case "Concierge":
                    dailyRate = 100;
                    break;
                case "Housekeeper":
                    dailyRate = 80;
                    break;
                case "Executive Chef":
                    dailyRate = 150;
                    break;
                case "Waiter/Waitress":
                    dailyRate = 70;
                    break;
                default:
                    dailyRate = 0;
                    break;
            }

            Salary = WorkingDays * dailyRate;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $"Position: {Position}\nWorking Days: {WorkingDays}\nSalary: {Salary:C}";
        }

    }
}
