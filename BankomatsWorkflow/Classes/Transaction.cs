using System;
using System.Collections.Generic;
using System.Text;

namespace BankomatWorkflowLibrary
{
    public abstract class Transaction
    {
        public string accountNumber;
        public BankDatabase bankDatabase;
        public Transaction(string userAccountNumber, BankDatabase atmBankDatabase)
        {
            accountNumber = userAccountNumber;
            bankDatabase = atmBankDatabase;
        }
        abstract public void Execute();
    }
}
