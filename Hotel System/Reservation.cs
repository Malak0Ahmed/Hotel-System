using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System
{
    internal class Reservation
    {
        public string Food { get; set; }
        public string PayMethod { get; set; }
        public int CheckInDay { get; set; }
        public string CheckInMonth { get; set; }
        public int CheckInYear { get; set; }
        public int NumDays { get; set; }
        public int NumAdults { get; set; }
        public double TotalAmount { get; private set; }

        public double CalculateTotalAmount()
        {
            double foodCost = 0;

            switch (Food)
            {
                case "Breakfast":
                    foodCost = 40;
                    break;
                case "All Inclusive":
                    foodCost = 150;
                    break;
                default:
                    throw new ArgumentException("Invalid Food Option");
            }

            double dayCost = NumDays * 100; // Assuming a fixed rate per day
            double adultCost = NumAdults * 50; // Assuming a fixed rate per adult

            TotalAmount = foodCost + dayCost + adultCost;
            return TotalAmount;
        }

        public string GetDetails()
        {
            return $"Check-in Date: {CheckInDay}-{CheckInMonth}-{CheckInYear}\n" +
                   $"Number of Days: {NumDays}\n" +
                   $"Number of Adults: {NumAdults}\n" +
                   $"Food Option: {Food}\n" +
                   $"Payment Method: {PayMethod}\n" +
                   $"Total Amount: {TotalAmount}$";
        }
    }
}


