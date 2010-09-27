using System;
using System.Collections.Generic;
using System.Text;

namespace BankomatWorkflowLibrary
{
    public class Deposit : Transaction
    {
        #region Fields
        private double amount; 
        private DepositSlot depositSlot;
        #endregion

        public Deposit(string userAccountNumber,BankDatabase atmBankDatabase,
           DepositSlot atmDepositSlot)
            : base(userAccountNumber,atmBankDatabase)
        {
            depositSlot = atmDepositSlot;
        } 

        public override void Execute()
        {
        }
	}
}
