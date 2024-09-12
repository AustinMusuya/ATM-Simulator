using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicFive
{

    public partial class CashMachine : Form
    {
        public CashMachine()
        {
            InitializeComponent();
        }
        Boolean inputPermitted;
        String enteredText; 
        //private UserAccount account1, account2, account3, account4; 
        private UserAccount current ;

        private string enteredPin;
        private String enteredNumber;

        /*string current*/
        private bool withdrawing;
        private bool receipt;

        List<UserAccount> myaccounts;

        public void addAccount (String an, String pin, int balance)
        {
            UserAccount tempAccount;
            tempAccount = new UserAccount(an, pin, balance);

            myaccounts.Add(tempAccount);
        }

        public void addBasicAccount(String an, String pin, int balance)
        {
            UserAccount tempAccount;

            tempAccount = new UserAccount(an, pin, balance); myaccounts.Add(tempAccount);
        }

        public void addExtendedAccount(String an, String pin, int balance, double ir)
        {
            UserAccount tempAccount;

            tempAccount = new ExtendedAccount(an, pin, balance, ir);

            myaccounts.Add(tempAccount);
        }



        private void CashMachine_Load(object sender, EventArgs e)
        {
            myaccounts = new List<UserAccount>();
            enteredText = "";
            enteredNumber = "";
            enteredPin = "";
            
            addAccount("20","4796", 50000);
            addAccount("30", "2461", 20000);
            addAccount("40","1687", 15000);
            addAccount("50","4978", 80000);
            inputPermitted = true;      
        }

        private void Display()
        {
            lblOutput.Text = enteredText;
        }

        private UserAccount findAccount(String num, String pin)
        {
            UserAccount acc;

            for (int i = 0; i < myaccounts.Count; i++)
            {
                acc = myaccounts[i];    

                if (acc.checkPIN(num, pin) == true)
                {
                    return acc;
                }
            }
            return null;
            /*
            if (account1.checkPIN(num, pin))
            {
                return account1;
            }
            if (account2.checkPIN(num, pin))
            {
                return account2;
            }
            if (account3.checkPIN(num, pin))
            {
                return account3;
            }
            if (account4.checkPIN(num, pin))
            {
                return account4;
            }
            return null;*/
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return; 
            }
            enteredText += "0";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnZero.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "3";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnThree.Text;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "2";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnTwo.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "1";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnOne.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "6";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnSix.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "5";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnFive.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "4";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnFour.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "9";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnNine.Text;
        }

        private void updateDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            Boolean ret;
            if (current == null)
            {
                if (enteredNumber.Length == 0)
                {
                    enteredNumber = enteredText;
                    enteredText = "";

                    lblOutput.Text = "Enter PIN";
                    return;
                }
                if (enteredPin.Length == 0)
                {
                    enteredPin = enteredText;
                    enteredText = "";
                }
                Console.WriteLine("Entered :" + enteredNumber + " " + enteredPin);

                if (enteredNumber.Length > 0 && enteredPin.Length > 0)
                {
                    current = findAccount(enteredNumber, enteredPin);
                }

            }
            if (current != null)
            {
                if (withdrawing)
                {
                    ret = current.withdraw(Int32.Parse(enteredText));
                    
                    if (ret == true)
                    {
                        lblOutput.Text = "Transaction Successful";

                        if (receipt)
                        {
                            lblOutput.Text = lblOutput.Text + "\nLast Transaction: "
                                + current.getLastTransaction();
                        }

                        lblOutput.Text += "\n Transaction Succesful. You have a "
                            + current.queryType() + "account";
                    }
                    else
                    {
                        lblOutput.Text = "insufficient Funds";
                    }
                    enteredText = "";
                    enteredNumber = "";
                    enteredPin = "";
                    withdrawing = false;
                    inputPermitted = false;
                }
                else
                {
                    lblOutput.Text = "Logged in -  choose transaction";
                    enteredText = "";
                }
            }
            else
            {
                lblOutput.Text = "Invalid Pin";
                enteredText = "";
                enteredNumber = "";
                enteredPin = "";
                inputPermitted = true;
                Display();
            }
        }

        private void cmdBalance_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                lblOutput.Text = "Balance is KES " + current.getBalance();
            }
        }

        private void cmdDeny_Click(object sender, EventArgs e)
        {
            enteredText = "";
            withdrawing = false;

            if (current != null)
            {
                lblOutput.Text = "Choose transaction";
            }
            else
            {
                lblOutput.Text = "Enter PIN";
            }

        }

        private void cmdWithdrawWithReceipt_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                lblOutput.Text = "Enter PIN";
                return;
            }
            lblOutput.Text = "Enter Amount";
            inputPermitted = true;
            withdrawing = true;
            receipt = true;
        }

        private void cmdWithdraw_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                lblOutput.Text = "Enter PIN";
                return;
            }
            lblOutput.Text = "Enter Amount";
            inputPermitted = true;
            withdrawing = true;
            receipt = false;
        }

        private void cmdLastTransaction_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                lblOutput.Text = "Last Transactions " + current.getLastTransaction();
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "8";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnEight.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText += "7";
            Display();

            //lblOutput.Text = "";
            //lblOutput.Text += btnSeven.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredText = "";
            Display();
            //lblOutput.Text = "";
            //lblOutput.Text = string.Empty;
        }
    }

}
