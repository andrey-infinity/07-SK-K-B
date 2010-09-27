using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BankomatWorkflowLibrary
{
    public class BankDatabase
    {
        public BankDatabase(string _FileName)
        {
            XmlTextReader reader=null;
            try
            {
                reader = new XmlTextReader(_FileName);
                int texttype = 0;
                Account newAccount = null;
                while (reader.Read())
                {


                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name == "Account")
                            {
                                newAccount = new Account();
                                newAccount.accountNumber = reader.GetAttribute("id");
                            }
                            if (reader.Name == "accountPIN")
                            {
                                texttype = 1;
                            }
                            if (reader.Name == "accountTotalBalance")
                            {
                                texttype = 2;
                            }
                            if (reader.Name == "accountAvailableBalance")
                            {
                                texttype = 3;

                            }
                            if (reader.Name == "accountPrefLanguage")
                            {
                                texttype = 4;
                            }
                            break;

                        case XmlNodeType.Text:
                            switch (texttype)
                            {
                                case 1: newAccount.accountPIN = reader.Value;
                                    break;
                                case 2: newAccount.accountTotalBalance = Convert.ToInt32(reader.Value);
                                    break;
                                case 3: newAccount.accountAvailableBalance = Convert.ToInt32(reader.Value);
                                    break;
                                case 4: newAccount.accountLanguage = reader.Value;
                                    break;
                            }
                            texttype = 0;
                            break;
                        case XmlNodeType.EndElement:
                            if (reader.Name == "Account")
                            {
                                accounts.Add(newAccount);
                                newAccount = null;
                            }
                            break;
                    }
                }
            }
            catch (XmlException e)
            {
                Console.WriteLine("error occured: " + e.Message);
            }
            finally
            {
                reader.Close();   
            }

        }
        public int GetAccInd(string a)
        {
            int ret = -1;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].accountNumber == a)
                {
                    ret = i;
                }
            }
            return ret;
        }
        public void SaveToXml(string _FileName)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(_FileName,null);
                writer.WriteStartDocument();
                writer.WriteStartElement("Accounts");
                for (int i = 0; i < accounts.Count; i++)
                {
                    writer.WriteStartElement("Account");
                    
                    writer.WriteStartAttribute("id");
                    writer.WriteString(accounts[i].accountNumber);
                    writer.WriteEndAttribute();
                    writer.WriteStartElement("accountPIN");
                    writer.WriteString(accounts[i].accountPIN);
                    writer.WriteEndElement();
                    writer.WriteStartElement("accountTotalBalance");
                    writer.WriteString(accounts[i].accountPIN);
                    writer.WriteEndElement();
                    writer.WriteStartElement("accountAvailableBalance");
                    writer.WriteString(accounts[i].accountPIN);
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                writer.WriteEndElement();
                writer.Flush();
                writer.Close();   
            }
        }
        private Account GetAccountByNumber(string accountNumber)
        {
            Account t = null;
            foreach (Account currentAccount in accounts)
            {
                if (currentAccount.accountNumber == accountNumber)
                {
                    t = currentAccount;
                }
            }
            return t;
        }
        public bool ValidateAccount(string _TryAccountNumber, string _TryPIN)
        {
            Account userAccount = GetAccountByNumber(_TryAccountNumber);

            if (userAccount != null)
                return userAccount.CheckPIN(_TryPIN);
            else
                return false;
        }
        #region cash methodes
        public double GetAvailableBalanceFromAccount(string userAccountNumber)
        {
            return GetAccountByNumber(userAccountNumber).accountAvailableBalance;

        }
        public double GetTotalBalanceFromAccount(string _AccountNumber)
        {
            return GetAccountByNumber(_AccountNumber).accountTotalBalance;
        }
        public void AddCashToAccount(string _AccountNumber, double _amount)
        {
            GetAccountByNumber(_AccountNumber).AddCash(_amount);
        }
        public void DeleteCashFromAccount(string _AccountNumber, double _amount)
        {
            GetAccountByNumber(_AccountNumber).DeleteCash(_amount);
        }
        #endregion
        public List<Account> accounts = new List<Account>();
    }
}
