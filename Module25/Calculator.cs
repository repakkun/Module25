using System;
using System.Collections.Generic;
using System.Text;

namespace Module25
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateBaseInterest(BaseAccount account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
            Console.WriteLine(account.Interest);
        }
        public static void CalculateSalaryInterest(SalaryAccount account)
        {
            account.Interest = account.Balance * 0.5;
            Console.WriteLine(account.Interest);
        }
    }
}
