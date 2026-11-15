using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System
{
    internal class Room
    {
        public string RoomType { get; set; }
        public string RoomView { get; set; }
        public string RoomExtra { get; set; }
        public int Total_Amount { get; private set; } // Private setter to ensure it's only set internally

        public int CalculateTotalAmount()
        {
            int basePrice = 0;
            int viewPrice = 0;
            int extraPrice = 0;

            // Calculate base price based on room type
            switch (RoomType)
            {
                case "Single":
                    basePrice = 1000;
                    break;
                case "Double":
                    basePrice = 1700;
                    break;
                case "Suite":
                    basePrice = 2500;
                    break;
            }

            // Calculate additional price based on room view
            switch (RoomView)
            {
                case "Sea View":
                    viewPrice = 100;
                    break;
                case "Pool View":
                    viewPrice = 50;
                    break;
                case "City View":
                    viewPrice = 0;
                    break;
            }

            // Calculate additional price based on room extras
            switch (RoomExtra)
            {
                case "Bed":
                    extraPrice = 100;
                    break;
                case "None":
                    extraPrice = 0;
                    break;
            }

            // Calculate total amount
            Total_Amount = basePrice + viewPrice + extraPrice;
            return Total_Amount;
        }

        public string GetDetails()
        {
            return $"Room Type: {RoomType}\nRoom View: {RoomView}\nRoom Extra: {RoomExtra}\nTotal Amount: {Total_Amount}$";
        }
    }
}


