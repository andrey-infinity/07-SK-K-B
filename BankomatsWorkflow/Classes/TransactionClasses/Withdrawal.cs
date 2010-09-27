using System;
using System.Collections.Generic;
using System.Text;

namespace BankomatWorkflowLibrary
{
    public class Withdrawal : Transaction
    {
        #region Fields
        private CashDispenser cashDispenser;
        private double amount;
        #endregion

        public Withdrawal(string currentAcccount, BankDatabase BD_, CashDispenser _cashDespenser):base(currentAcccount,BD_)
        {
            cashDispenser = _cashDespenser;
        }
        public override void Execute()
        {
        }
	}
}
