using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicFive
{
    internal class BasicAccount : UserAccount
    {
        private int overdraft;
        public BasicAccount(String an, string p, int b ) : base(an, p, b)
        {
            overdraft = 100;
        }
        public int Overdraft
        {
            get { return overdraft; }
            set { overdraft = value; }
        }

        public override bool queryValidTransaction(int amount)
        {
            int newAmount = this.getBalance() - amount;

            if (newAmount < -1 * overdraft)
            {
                return false;
            }
            return true;
        }

        public override string queryType()
        {
            return "Basic";
        }
    }
}
