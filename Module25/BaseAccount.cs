using System;
using System.Collections.Generic;
using System.Text;

namespace Module25
{
    public class BaseAccount :  IAccountType
    {      
        public double Balance { get; set; }
        public double Interest { get; set; }
   

        public void AccType()
        {
            Console.WriteLine("Расчет по базовому");
        }
    }
}
