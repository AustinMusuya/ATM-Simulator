namespace TopicFive
{
    partial class CashMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdWithdraw = new System.Windows.Forms.Button();
            this.cmdWithdrawWithReceipt = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.cmdBalance = new System.Windows.Forms.Button();
            this.cmdDeny = new System.Windows.Forms.Button();
            this.updateDisplay = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdLastTransaction = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.updateDisplay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdWithdraw
            // 
            this.cmdWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWithdraw.Location = new System.Drawing.Point(20, 66);
            this.cmdWithdraw.Name = "cmdWithdraw";
            this.cmdWithdraw.Size = new System.Drawing.Size(172, 41);
            this.cmdWithdraw.TabIndex = 1;
            this.cmdWithdraw.Text = "Withdraw";
            this.cmdWithdraw.UseVisualStyleBackColor = true;
            this.cmdWithdraw.Click += new System.EventHandler(this.cmdWithdraw_Click);
            // 
            // cmdWithdrawWithReceipt
            // 
            this.cmdWithdrawWithReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWithdrawWithReceipt.Location = new System.Drawing.Point(20, 132);
            this.cmdWithdrawWithReceipt.Name = "cmdWithdrawWithReceipt";
            this.cmdWithdrawWithReceipt.Size = new System.Drawing.Size(172, 54);
            this.cmdWithdrawWithReceipt.TabIndex = 2;
            this.cmdWithdrawWithReceipt.Text = "Withdraw with Receipt";
            this.cmdWithdrawWithReceipt.UseVisualStyleBackColor = true;
            this.cmdWithdrawWithReceipt.Click += new System.EventHandler(this.cmdWithdrawWithReceipt_Click);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirm.Location = new System.Drawing.Point(20, 209);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(172, 47);
            this.cmdConfirm.TabIndex = 3;
            this.cmdConfirm.Text = "Confirm";
            this.cmdConfirm.UseVisualStyleBackColor = true;
            this.cmdConfirm.Click += new System.EventHandler(this.cmdConfirm_Click);
            // 
            // cmdBalance
            // 
            this.cmdBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBalance.Location = new System.Drawing.Point(20, 14);
            this.cmdBalance.Name = "cmdBalance";
            this.cmdBalance.Size = new System.Drawing.Size(172, 40);
            this.cmdBalance.TabIndex = 4;
            this.cmdBalance.Text = "Balance";
            this.cmdBalance.UseVisualStyleBackColor = true;
            this.cmdBalance.Click += new System.EventHandler(this.cmdBalance_Click);
            // 
            // cmdDeny
            // 
            this.cmdDeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeny.Location = new System.Drawing.Point(20, 275);
            this.cmdDeny.Name = "cmdDeny";
            this.cmdDeny.Size = new System.Drawing.Size(172, 46);
            this.cmdDeny.TabIndex = 5;
            this.cmdDeny.Text = "Deny";
            this.cmdDeny.UseVisualStyleBackColor = true;
            this.cmdDeny.Click += new System.EventHandler(this.cmdDeny_Click);
            // 
            // updateDisplay
            // 
            this.updateDisplay.BackColor = System.Drawing.Color.Black;
            this.updateDisplay.Controls.Add(this.lblOutput);
            this.updateDisplay.Controls.Add(this.label1);
            this.updateDisplay.ForeColor = System.Drawing.Color.Transparent;
            this.updateDisplay.Location = new System.Drawing.Point(223, 26);
            this.updateDisplay.Name = "updateDisplay";
            this.updateDisplay.Size = new System.Drawing.Size(446, 322);
            this.updateDisplay.TabIndex = 6;
            this.updateDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.updateDisplay_Paint);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(19, 107);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(244, 16);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Enter Your Account Number to log in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money Market Place";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 46);
            this.button7.TabIndex = 8;
            this.button7.Text = "A";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(14, 125);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(53, 46);
            this.btnOne.TabIndex = 9;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(83, 125);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(53, 46);
            this.btnTwo.TabIndex = 10;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(83, 17);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(53, 46);
            this.btnEight.TabIndex = 14;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(14, 17);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(53, 46);
            this.btnSeven.TabIndex = 13;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(14, 69);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(53, 46);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(83, 69);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(53, 46);
            this.btnFive.TabIndex = 11;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(147, 17);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(53, 46);
            this.btnNine.TabIndex = 18;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(147, 69);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(53, 46);
            this.btnSix.TabIndex = 17;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(147, 125);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(53, 46);
            this.btnThree.TabIndex = 16;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 46);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(83, 177);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(53, 46);
            this.btnZero.TabIndex = 19;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.btnZero);
            this.panel2.Controls.Add(this.btnFive);
            this.panel2.Controls.Add(this.btnNine);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btnSix);
            this.panel2.Controls.Add(this.btnOne);
            this.panel2.Controls.Add(this.btnThree);
            this.panel2.Controls.Add(this.btnTwo);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnFour);
            this.panel2.Controls.Add(this.btnEight);
            this.panel2.Controls.Add(this.btnSeven);
            this.panel2.Location = new System.Drawing.Point(691, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 255);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.cmdLastTransaction);
            this.panel3.Controls.Add(this.cmdWithdraw);
            this.panel3.Controls.Add(this.cmdWithdrawWithReceipt);
            this.panel3.Controls.Add(this.cmdDeny);
            this.panel3.Controls.Add(this.cmdConfirm);
            this.panel3.Controls.Add(this.cmdBalance);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 426);
            this.panel3.TabIndex = 2;
            // 
            // cmdLastTransaction
            // 
            this.cmdLastTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLastTransaction.Location = new System.Drawing.Point(20, 349);
            this.cmdLastTransaction.Name = "cmdLastTransaction";
            this.cmdLastTransaction.Size = new System.Drawing.Size(172, 50);
            this.cmdLastTransaction.TabIndex = 6;
            this.cmdLastTransaction.Text = "Last Transaction";
            this.cmdLastTransaction.UseVisualStyleBackColor = true;
            this.cmdLastTransaction.Click += new System.EventHandler(this.cmdLastTransaction_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(691, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 18);
            this.panel4.TabIndex = 21;
            // 
            // CashMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.updateDisplay);
            this.Name = "CashMachine";
            this.Text = "Electronic Cash Machine";
            this.Load += new System.EventHandler(this.CashMachine_Load);
            this.updateDisplay.ResumeLayout(false);
            this.updateDisplay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdWithdraw;
        private System.Windows.Forms.Button cmdWithdrawWithReceipt;
        private System.Windows.Forms.Button cmdConfirm;
        private System.Windows.Forms.Button cmdBalance;
        private System.Windows.Forms.Button cmdDeny;
        private System.Windows.Forms.Panel updateDisplay;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cmdLastTransaction;
    }
}

