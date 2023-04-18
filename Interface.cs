using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B_OppsConcept
{
   // internal class Interface
    
     interface IBankDetails
    {
        void GetBankDetails();
    }

    class BankManager : IBankDetails
    {
        public void GetBankDetails()
        {
            Console.WriteLine("This is Bank of India");
        }
    }
}
