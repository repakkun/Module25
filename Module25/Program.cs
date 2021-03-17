using System;

namespace Module25
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();           
         
            account.GetAccType(new BaseAccount());
            var account1 = new BaseAccount{ Balance = 100000000, Interest = 10000 };
            Calculator.CalculateBaseInterest(account1);

            Console.WriteLine();

            account.GetAccType(new SalaryAccount());
            var account2 = new SalaryAccount { Balance = 124000, Interest = 1240 };
            Calculator.CalculateSalaryInterest(account2);
        }
    }
}
