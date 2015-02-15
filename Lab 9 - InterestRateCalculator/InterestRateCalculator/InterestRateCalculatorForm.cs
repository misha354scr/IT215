using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestRateCalculator
{
   public partial class InterestRateCalculatorForm : Form
   {

      private int nComp = 12; //number of times interest is compounded

      public InterestRateCalculatorForm()
      {
         InitializeComponent();
      }

      private void rbt_CheckedChanged(object sender, EventArgs e)
      {
         if (sender == rbtAnnually) 
         {
            nComp = 1;
         }

         else if (sender == rbtSemiAnnually) 
         {
            nComp = 2;
         }

         else if (sender == rbtQuarterly)
         {
            nComp = 4;
         }

         else if (sender == rbtMonthly)
         {
            nComp = 12;
         }

         else 
         {
            throw new InvalidOperationException("Invalid compounding choice");
         }


      }

      private void btnCalculate_Click(object sender, EventArgs e)
      {
         // declare variables to store user input
         decimal principal = 0; // store principal
         double rate = 0; // store interest rate
         int year = 0; // store number of years
         decimal amount; // store amount

         // retrieve user input
         try
         {
            principal = Convert.ToDecimal(txtPrincipal.Text);
            rate = Convert.ToDouble(txtInterest.Text);
            year = Convert.ToInt32(txtYears.Text);
         }
         catch
         {
            ;
         }

         amount = principal * (decimal)Math.Pow( 1 + rate / (nComp * 100), nComp * year);
         lblInterestEarnedValue.Text = (amount - principal).ToString("C2");
         txtCurrentValue.Text = amount.ToString("C2");
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
