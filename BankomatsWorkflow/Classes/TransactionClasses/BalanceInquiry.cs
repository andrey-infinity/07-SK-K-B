using System;
using System.Collections.Generic;
using System.Text;

namespace BankomatWorkflowLibrary
{
    public class BalanceInquiry : Transaction
	{
        public BalanceInquiry(string userAccountNumber,
           BankDatabase atmBankDatabase)
            : base(userAccountNumber,atmBankDatabase) { }
        public override void Execute()
        {
        }
	}
}
