using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Interfaces;


namespace BankomatWorkflowLibrary
{
	public sealed partial class BankomatsWorkflow: StateMachineWorkflowActivity
	{
        public string currentAccountNumber;
        public string tryPIN = "";
        public string oldPIN = "";
        public string newPIN = "";
        public LanguageChoiseNumArgs buffer;

        #region Bankomats Classes
        DepositSlot depositSlot; 
        CashDispenser cashDispenser; 
        
        public BankDatabase BD;
        Transaction Trans;
        #endregion

        public BankomatsWorkflow()
		{
			InitializeComponent();


        }

        #region Functional
        public void WorkFlowInit(object sender,EventArgs e)
        {
            currentAccountNumber = "";
            tryPIN = "";
            oldPIN = "";
            newPIN = "";

            cashDispenser = new CashDispenser();
            depositSlot = new DepositSlot();
            BD = new BankDatabase("BankDatabase.xml");
        }
        private Transaction CreateTransaction(int type)
        {
            Transaction temp = null;
            switch ((ActionType)type)
            {
                case ActionType.BALANCE_INQUIRY:
                    temp = new BalanceInquiry(currentAccountNumber,BD);
                    break;
                case ActionType.WITHDRAWAL: 
                    temp = new Withdrawal(currentAccountNumber,BD,cashDispenser);
                    break;
                case ActionType.DEPOSIT: 
                    temp = new Deposit(currentAccountNumber,BD,depositSlot);
                    break;
            } 

            return temp;
        }
        #endregion

        #region CODE
        public void ChangeMenu(object sender, EventArgs e)
        {
            buffer.Name = 0;
        }
        #endregion

        #region Handleres
        public void GetInputCardNumber(object sender, ExternalDataEventArgs e)
        {
            GetNumArgs Args = (GetNumArgs)e;
            currentAccountNumber = currentAccountNumber + Args.Num;
        }
        public void GetInputPin(object sender, ExternalDataEventArgs e)
        {
            GetNumArgs Args = (GetNumArgs)e;
            tryPIN = tryPIN+Args.Num;
        }
        private void handleExternalEventActivity2_Invoked(object sender, ExternalDataEventArgs e)
        {
            GetNumArgs Args = (GetNumArgs)e;
            oldPIN = oldPIN + Args.Num;
        }
        public void InitTransacton(object sender, ExternalDataEventArgs e)
        {
            //GetNumArgs Args = (GetNumArgs)e;
            //Trans = CreateTransaction(Args.Num);
        }
        #endregion
        #region WWF Fileds

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public double CurrentAvailableBalance
        {
            get
            {
                return BD.GetAvailableBalanceFromAccount(currentAccountNumber);
            }

        }


        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public double CurrentTotalBalance
        {
            get
            {
                return BD.GetTotalBalanceFromAccount(currentAccountNumber);
            }

        }


        #endregion

        private void codeActivity2_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("jajututu");
        }

        private void handleExternalEventActivity3_Invoked(object sender, ExternalDataEventArgs e)
        {
            GetNumArgs Args = (GetNumArgs)e;
            newPIN = newPIN + Args.Num;
        }

        private void codeActivity2_ExecuteCode_1(object sender, EventArgs e)
        {
            Account changeAccount = new Account();
            changeAccount.accountNumber = currentAccountNumber;
            changeAccount.accountPIN = newPIN;
            changeAccount.accountAvailableBalance = BD.GetAvailableBalanceFromAccount(currentAccountNumber);
            changeAccount.accountTotalBalance = BD.GetTotalBalanceFromAccount(currentAccountNumber);
            BD.accounts[BD.GetAccInd(currentAccountNumber)] = changeAccount;
            BD.SaveToXml("BankDatabase.xml");
            Console.WriteLine("Vrode Save");
            
        }
    }

}
