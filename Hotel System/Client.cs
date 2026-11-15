using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_System
{
    internal class Client: Person
    {

        public int Age { get; set; }
        public int Phone { get; set; }
        public int ID { get; set; }
        public string Gender { get; set; }

        public override string GetDetails()
        {
            return base.GetDetails()+ "Name :" + firstName+" "+lastName+ "\n Age :" + Age + "\n ID :"+ID+ "\n Gender : " + Gender+"\n Phone No.:"+Phone;
        }
    }
}
