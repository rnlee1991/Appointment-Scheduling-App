using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969___PA
{
    public abstract class Customers 
    {
          public int customerID { get; set; }
          public string customerName { get; set; }
          public int addressID { get; set; }
          public int active { get; set; }

    }
    public class RemoteCustomer : Customers // Polymorphism demonstrated in overloaded constructor, inheritance from base class to subclass.
    {
        public int remote { get; set; }

        public RemoteCustomer(int p1, string p2, int p3, int p4, int p5)
        {
            customerID = p1;
            customerName = p2;
            addressID = p3;
            active = p4;
            remote = p5;
        }
    }

    public class LocalCustomer : Customers // Polymorphism demonstrated in overloaded constructor, inheritance from base class to subclass.
    {
        public string localOffice { get; set; }

        public LocalCustomer(int p1, string p2, int p3, int p4, string p5)
        {
            customerID = p1;
            customerName = p2;
            addressID = p3;
            active = p4;
            localOffice = p5;
        }
    }

}
