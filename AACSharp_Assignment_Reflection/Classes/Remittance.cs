using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Reflection.Classes
{
    public class Remittance : IPaySystem
    {
        public string Pay(decimal amount)
        {
            return amount+" TL'lik ödemeniz Havale yolu ile gerçekleştirildi.";
        }
    }
}
