using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }

        public virtual string GetDetails()
        {
            return "Name:"+firstName+" "+lastName+"Password:"+password;
        }
    }
}
