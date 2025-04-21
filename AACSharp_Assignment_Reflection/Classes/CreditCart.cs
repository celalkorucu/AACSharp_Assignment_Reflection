using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Reflection.Classes
{
    public class CreditCart : IPaySystem
    {
        public string Pay(decimal amount)
        {
            return amount + " TL'lik ödemeniz Kredi kartı ile gerçekleştirildi.";
        }
    }
}
