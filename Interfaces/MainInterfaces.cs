using System;
using System.Collections.Generic;
using System.Text;
using System.Workflow.Activities;
using System.Workflow.ComponentModel;

namespace Interfaces
{
    [ExternalDataExchange]
    public interface IFormService
    {
        event EventHandler<LanguageChoiseNumArgs> GetNewAction;
        void DisplayLanguage();
        void DisplayAuthMenu();
        void AuthFailed();
        void WelcomeMessage();
        void DisplayMenu();
        void SendBackMessage(string message);
        void SendBackMessageLine(string message);
        void NewPinCodeInvite();
        void ViewBalance(double accountAvailableBalance, double accountTotalBalance);
        event EventHandler<GetNumArgs> GetNewNum;

    }


    #region Arguments
    
    [Serializable]
    public class GetNumArgs : ExternalDataEventArgs
    {
        private string _num;

        public string Num
        {
            get { return _num; }
            set { _num = value; }
        }
        public GetNumArgs(Guid instanceId, string newnum)
            : base(instanceId)
        {
            Num = newnum;
        }
    }    

    [Serializable]
    public class LanguageChoiseNumArgs : ExternalDataEventArgs
    {
        private int _Name;

        public int Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public LanguageChoiseNumArgs(Guid instanceId, int nickname)
            : base(instanceId)
        {
            Name = nickname;
        }
    }
   /*
    [Serializable]
    public class ViewBalanceEventArgs : ExternalDataEventArgs
    {
        private int _accountAvailableBalance;
        public int accountAvailableBalance
        {
            get { return _accountAvailableBalance; }
            set { _accountAvailableBalance = value; }
        }
        private int _accountTotalBalance;
        public int accountTotalBalance
        {
            get { return _accountTotalBalance; }
            set { _accountTotalBalance = value; }
        }

        public ViewBalanceEventArgs(Guid instanceId, int a,int b)
            : base(instanceId)
        {
            accountTotalBalance = a;
            accountAvailableBalance = b;

        }
    }    
    */
    #endregion


    public enum ActionType
    {
        BALANCE_INQUIRY=1,
        WITHDRAWAL=2,
        DEPOSIT=3
    }
}
