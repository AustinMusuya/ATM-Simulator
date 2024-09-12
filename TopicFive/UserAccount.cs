using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicFive
{
    internal class UserAccount
    {
        private String PIN;
        private int balance;
        private string lastTransaction;
        private String accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value;}
        }

        public UserAccount(string an, string p, int b)
        {
            PIN = p; balance = b; accountNumber = an;
        }

        public UserAccount(string p, int b)
        {
            PIN = p; balance = b;
        }


        public Boolean checkPIN(String an, String p)
        {
            if (accountNumber.ToLower().Equals(an.ToLower()) == false)
            {
                return false;
            }

            if (PIN.ToLower().Equals(p.ToLower()))
            {
                return true;
            }
            return false;
        }

        public int getBalance()
        {
            return balance;
        }
        public Boolean withdraw(int amount)
        {
            if (amount > balance)
            {
                return false;
            }
            lastTransaction =  "Balance was" + balance + ". Withdrew " + amount;
            balance -= amount;

            return true;
        }

        public virtual Boolean queryValidTransaction (int amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance -= amount;
            lastTransaction = "Balance was" + balance + "withdrew" + amount;           
            //balance -= amount;
            return true;
        }

        //lastTransaction = "Balance was" + balance + "withdrew" + amount;



        public string getLastTransaction()
        {
            if (lastTransaction != null)
            {
                return lastTransaction;
            }
            return "No transactions";
        }

        public virtual string queryType()
        {
            return "Base";
        }
    }
}