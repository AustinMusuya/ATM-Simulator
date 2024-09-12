using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicFive
{
    internal class ExtendedAccount : UserAccount
    {
        private double interestRate;

        public ExtendedAccount(string an, string p, int b, double ir) : base(an, p, b)
        {
            interestRate = ir;
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public override string queryType()
        {
            return "Extended";
        }
    }
}
