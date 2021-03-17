using System;
using System.Collections.Generic;
using System.Text;

namespace Module25
{
    public class Account
    {
        public void GetAccType(IAccountType accountType)
        {
            accountType.AccType();
        }
    }
}
