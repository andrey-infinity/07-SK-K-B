using System;
using System.Collections.Generic;
using System.Text;

namespace BankomatWorkflowLibrary
{
    public class Account
    {
        public bool CheckPIN(string _PIN)
        {
            return _PIN == accountPIN;
        }
        #region CashMethodes
        public void AddCash(double amount)
        {
            accountTotalBalance += amount;
        }
        public void DeleteCash(double amount)
        {
            accountAvailableBalance -= amount;
            accountTotalBalance -= amount;
        }
        #endregion
        #region fileds
        public string accountNumber;
        public string accountPIN;
        public double accountAvailableBalance;
        public double accountTotalBalance;
        public string accountLanguage;
        #endregion
        public Account(string _AccountNumber, string _PIN, double _AvailableBalance, double _AccountTotalBalance, string _AccountLanguage)
        {
            accountAvailableBalance = _AvailableBalance;
            accountNumber = _AccountNumber;
            accountTotalBalance = _AccountTotalBalance;
            accountLanguage = _AccountLanguage;
            accountPIN = _PIN;
          
        }
        public Account()
        {
        }
    }
}
