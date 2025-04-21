using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Reflection.Classes
{
    public class Payer
    {
        public IPaySystem ipaySystem;

        public Payer(IPaySystem ipaySystem)
        {
            this.ipaySystem = ipaySystem;
        }


        public string Pay(decimal ammount)
        {
            return ipaySystem.Pay(ammount);
        }
    }
}
