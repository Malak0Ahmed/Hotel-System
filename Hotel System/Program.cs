using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonForm());
            Person person = new Person();

            person.firstName = "Shahd";
            person.lastName = "Mohamed";
            person.password = "my password";

            Console.WriteLine("Person Details:");
            Console.WriteLine($"First Name: {person.firstName}");
            Console.WriteLine($"Last Name: {person.lastName}");
            Console.WriteLine($"Password: {person.password}");

            Person anotherPerson = new Person();
            anotherPerson.firstName = "Malak";
            anotherPerson.lastName = "Mohamed";
            anotherPerson.password = "my password";

            Console.WriteLine("\nAnother Person Details:");
            Console.WriteLine($"First Name: {anotherPerson.firstName}");
            Console.WriteLine($"Last Name: {anotherPerson.lastName}");
            Console.WriteLine($"Password: {anotherPerson.password}");

            Console.ReadLine();

            //employee 
            Employee employee1 = new Employee();
            employee1.Position = "Concierge";
            employee1.WorkingDays = 20;

            employee1.CalculateSalary();

            Console.WriteLine("Employee 1 Details:");
            Console.WriteLine(employee1.GetDetails());

            Employee employee2 = new Employee();
            employee2.Position = "Housekeeper";
            employee2.WorkingDays = 25;

            employee2.CalculateSalary();

            Console.WriteLine("\nEmployee 2 Details:");
            Console.WriteLine(employee2.GetDetails());

            Employee employee3 = new Employee();
            employee3.Position = "Executive Chef";
            employee3.WorkingDays = 30;

            employee3.CalculateSalary();

            Console.WriteLine("\nEmployee 3 Details:");
            Console.WriteLine(employee3.GetDetails());

            Console.ReadLine();

            //client 
            Client client1 = new Client();
            client1.firstName = "Omar";
            client1.lastName = "Fkhr";
            client1.Age = 30;
            client1.Phone = 123456789;
            client1.ID = 1;
            client1.Gender = "Male";

            Console.WriteLine("Client 1 Details:");
            Console.WriteLine(client1.GetDetails());

            Client client2 = new Client();
            client2.firstName = "samira";
            client2.lastName = "saeed";
            client2.Age = 25;
            client2.Phone = 987654321;
            client2.ID = 2;
            client2.Gender = "Female";

            Console.WriteLine("\nClient 2 Details:");
            Console.WriteLine(client2.GetDetails());

            Console.ReadLine();

            //Room
            Room room1 = new Room();
            room1.RoomType = "Single";
            room1.RoomView = "Sea View";
            room1.RoomExtra = "Bed";

            room1.CalculateTotalAmount();

            Console.WriteLine("Room 1 Details:");
            Console.WriteLine(room1.GetDetails());

            Room room2 = new Room();
            room2.RoomType = "Double";
            room2.RoomView = "Pool View";
            room2.RoomExtra = "None";

            room2.CalculateTotalAmount();

            Console.WriteLine("\nRoom 2 Details:");
            Console.WriteLine(room2.GetDetails());

            Room room3 = new Room();
            room3.RoomType = "Suite";
            room3.RoomView = "City View";
            room3.RoomExtra = "Bed";

            room3.CalculateTotalAmount();

            Console.WriteLine("\nRoom 3 Details:");
            Console.WriteLine(room3.GetDetails());

            Console.ReadLine();

            //Reservation
            Reservation reservation1 = new Reservation();
            reservation1.CheckInDay = 1;
            reservation1.CheckInMonth = "January";
            reservation1.CheckInYear = 2023;
            reservation1.NumDays = 3;
            reservation1.NumAdults = 2;
            reservation1.Food = "Breakfast";
            reservation1.PayMethod = "Credit Card";

            reservation1.CalculateTotalAmount();

            Console.WriteLine("Reservation 1 Details:");
            Console.WriteLine(reservation1.GetDetails());

            Reservation reservation2 = new Reservation();
            reservation2.CheckInDay = 5;
            reservation2.CheckInMonth = "February";
            reservation2.CheckInYear = 2023;
            reservation2.NumDays = 5;
            reservation2.NumAdults = 1;
            reservation2.Food = "All Exclusive";
            reservation2.PayMethod = "Cash";

            reservation2.CalculateTotalAmount();

            Console.WriteLine("\nReservation 2 Details:");
            Console.WriteLine(reservation2.GetDetails());

            Console.ReadLine();

        }
    }
}
