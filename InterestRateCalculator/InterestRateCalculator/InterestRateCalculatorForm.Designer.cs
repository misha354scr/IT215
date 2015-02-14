namespace InterestRateCalculator
{
   partial class InterestRateCalculatorForm
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
         this.grpInput = new System.Windows.Forms.GroupBox();
         this.txtYears = new System.Windows.Forms.TextBox();
         this.lblYears = new System.Windows.Forms.Label();
         this.txtInterest = new System.Windows.Forms.TextBox();
         this.lblInterest = new System.Windows.Forms.Label();
         this.txtPrincipal = new System.Windows.Forms.TextBox();
         this.lblPrincipal = new System.Windows.Forms.Label();
         this.grpCompoundFreq = new System.Windows.Forms.GroupBox();
         this.rbtAnnually = new System.Windows.Forms.RadioButton();
         this.rbtSemiAnnually = new System.Windows.Forms.RadioButton();
         this.rbtQuarterly = new System.Windows.Forms.RadioButton();
         this.rbtMonthly = new System.Windows.Forms.RadioButton();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnCalculate = new System.Windows.Forms.Button();
         this.grpResults = new System.Windows.Forms.GroupBox();
         this.txtCurrentValue = new System.Windows.Forms.TextBox();
         this.lblCurrentValue = new System.Windows.Forms.Label();
         this.lblInterestEarned = new System.Windows.Forms.Label();
         this.lblInterestEarnedValue = new System.Windows.Forms.Label();
         this.grpInput.SuspendLayout();
         this.grpCompoundFreq.SuspendLayout();
         this.grpResults.SuspendLayout();
         this.SuspendLayout();
         // 
         // grpInput
         // 
         this.grpInput.Controls.Add(this.txtYears);
         this.grpInput.Controls.Add(this.lblYears);
         this.grpInput.Controls.Add(this.txtInterest);
         this.grpInput.Controls.Add(this.lblInterest);
         this.grpInput.Controls.Add(this.txtPrincipal);
         this.grpInput.Controls.Add(this.lblPrincipal);
         this.grpInput.Location = new System.Drawing.Point(28, 28);
         this.grpInput.Name = "grpInput";
         this.grpInput.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
         this.grpInput.Size = new System.Drawing.Size(200, 109);
         this.grpInput.TabIndex = 0;
         this.grpInput.TabStop = false;
         this.grpInput.Text = "Input";
         // 
         // txtYears
         // 
         this.txtYears.Location = new System.Drawing.Point(61, 77);
         this.txtYears.Name = "txtYears";
         this.txtYears.Size = new System.Drawing.Size(100, 20);
         this.txtYears.TabIndex = 5;
         // 
         // lblYears
         // 
         this.lblYears.AutoSize = true;
         this.lblYears.Location = new System.Drawing.Point(8, 80);
         this.lblYears.Name = "lblYears";
         this.lblYears.Size = new System.Drawing.Size(34, 13);
         this.lblYears.TabIndex = 4;
         this.lblYears.Text = "Years";
         // 
         // txtInterest
         // 
         this.txtInterest.Location = new System.Drawing.Point(61, 49);
         this.txtInterest.Name = "txtInterest";
         this.txtInterest.Size = new System.Drawing.Size(100, 20);
         this.txtInterest.TabIndex = 3;
         // 
         // lblInterest
         // 
         this.lblInterest.AutoSize = true;
         this.lblInterest.Location = new System.Drawing.Point(8, 53);
         this.lblInterest.Name = "lblInterest";
         this.lblInterest.Size = new System.Drawing.Size(42, 13);
         this.lblInterest.TabIndex = 2;
         this.lblInterest.Text = "Interest";
         // 
         // txtPrincipal
         // 
         this.txtPrincipal.Location = new System.Drawing.Point(61, 22);
         this.txtPrincipal.Name = "txtPrincipal";
         this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
         this.txtPrincipal.TabIndex = 1;
         // 
         // lblPrincipal
         // 
         this.lblPrincipal.AutoSize = true;
         this.lblPrincipal.Location = new System.Drawing.Point(8, 26);
         this.lblPrincipal.Name = "lblPrincipal";
         this.lblPrincipal.Size = new System.Drawing.Size(47, 13);
         this.lblPrincipal.TabIndex = 0;
         this.lblPrincipal.Text = "Principal";
         // 
         // grpCompoundFreq
         // 
         this.grpCompoundFreq.Controls.Add(this.rbtAnnually);
         this.grpCompoundFreq.Controls.Add(this.rbtSemiAnnually);
         this.grpCompoundFreq.Controls.Add(this.rbtQuarterly);
         this.grpCompoundFreq.Controls.Add(this.rbtMonthly);
         this.grpCompoundFreq.Location = new System.Drawing.Point(261, 28);
         this.grpCompoundFreq.Name = "grpCompoundFreq";
         this.grpCompoundFreq.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
         this.grpCompoundFreq.Size = new System.Drawing.Size(152, 136);
         this.grpCompoundFreq.TabIndex = 6;
         this.grpCompoundFreq.TabStop = false;
         this.grpCompoundFreq.Text = "Compound Frequency";
         // 
         // rbtAnnually
         // 
         this.rbtAnnually.AutoSize = true;
         this.rbtAnnually.Location = new System.Drawing.Point(19, 105);
         this.rbtAnnually.Name = "rbtAnnually";
         this.rbtAnnually.Size = new System.Drawing.Size(65, 17);
         this.rbtAnnually.TabIndex = 3;
         this.rbtAnnually.Text = "Annually";
         this.rbtAnnually.UseVisualStyleBackColor = true;
         this.rbtAnnually.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtSemiAnnually
         // 
         this.rbtSemiAnnually.AutoSize = true;
         this.rbtSemiAnnually.Location = new System.Drawing.Point(19, 79);
         this.rbtSemiAnnually.Name = "rbtSemiAnnually";
         this.rbtSemiAnnually.Size = new System.Drawing.Size(91, 17);
         this.rbtSemiAnnually.TabIndex = 2;
         this.rbtSemiAnnually.Text = "Semi-Annually";
         this.rbtSemiAnnually.UseVisualStyleBackColor = true;
         this.rbtSemiAnnually.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtQuarterly
         // 
         this.rbtQuarterly.AutoSize = true;
         this.rbtQuarterly.Location = new System.Drawing.Point(19, 53);
         this.rbtQuarterly.Name = "rbtQuarterly";
         this.rbtQuarterly.Size = new System.Drawing.Size(67, 17);
         this.rbtQuarterly.TabIndex = 1;
         this.rbtQuarterly.Text = "Quarterly";
         this.rbtQuarterly.UseVisualStyleBackColor = true;
         this.rbtQuarterly.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtMonthly
         // 
         this.rbtMonthly.AutoSize = true;
         this.rbtMonthly.Checked = true;
         this.rbtMonthly.Location = new System.Drawing.Point(19, 27);
         this.rbtMonthly.Name = "rbtMonthly";
         this.rbtMonthly.Size = new System.Drawing.Size(62, 17);
         this.rbtMonthly.TabIndex = 0;
         this.rbtMonthly.TabStop = true;
         this.rbtMonthly.Text = "Monthly";
         this.rbtMonthly.UseVisualStyleBackColor = true;
         this.rbtMonthly.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(437, 75);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 23);
         this.btnClose.TabIndex = 6;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // btnCalculate
         // 
         this.btnCalculate.Location = new System.Drawing.Point(437, 43);
         this.btnCalculate.Name = "btnCalculate";
         this.btnCalculate.Size = new System.Drawing.Size(75, 23);
         this.btnCalculate.TabIndex = 7;
         this.btnCalculate.Text = "Calculate";
         this.btnCalculate.UseVisualStyleBackColor = true;
         this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
         // 
         // grpResults
         // 
         this.grpResults.Controls.Add(this.lblInterestEarnedValue);
         this.grpResults.Controls.Add(this.txtCurrentValue);
         this.grpResults.Controls.Add(this.lblCurrentValue);
         this.grpResults.Controls.Add(this.lblInterestEarned);
         this.grpResults.Location = new System.Drawing.Point(28, 177);
         this.grpResults.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
         this.grpResults.Name = "grpResults";
         this.grpResults.Padding = new System.Windows.Forms.Padding(5, 8, 3, 3);
         this.grpResults.Size = new System.Drawing.Size(466, 82);
         this.grpResults.TabIndex = 8;
         this.grpResults.TabStop = false;
         this.grpResults.Text = "Results";
         // 
         // txtCurrentValue
         // 
         this.txtCurrentValue.Location = new System.Drawing.Point(349, 26);
         this.txtCurrentValue.Name = "txtCurrentValue";
         this.txtCurrentValue.Size = new System.Drawing.Size(100, 20);
         this.txtCurrentValue.TabIndex = 3;
         // 
         // lblCurrentValue
         // 
         this.lblCurrentValue.AutoSize = true;
         this.lblCurrentValue.Location = new System.Drawing.Point(264, 30);
         this.lblCurrentValue.Name = "lblCurrentValue";
         this.lblCurrentValue.Size = new System.Drawing.Size(71, 13);
         this.lblCurrentValue.TabIndex = 2;
         this.lblCurrentValue.Text = "Current Value";
         // 
         // lblInterestEarned
         // 
         this.lblInterestEarned.AutoSize = true;
         this.lblInterestEarned.Location = new System.Drawing.Point(25, 30);
         this.lblInterestEarned.Name = "lblInterestEarned";
         this.lblInterestEarned.Size = new System.Drawing.Size(79, 13);
         this.lblInterestEarned.TabIndex = 0;
         this.lblInterestEarned.Text = "Interest Earned";
         // 
         // lblInterestEarnedValue
         // 
         this.lblInterestEarnedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblInterestEarnedValue.Location = new System.Drawing.Point(121, 26);
         this.lblInterestEarnedValue.Name = "lblInterestEarnedValue";
         this.lblInterestEarnedValue.Size = new System.Drawing.Size(100, 20);
         this.lblInterestEarnedValue.TabIndex = 4;
         this.lblInterestEarnedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // InterestRateCalculatorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(523, 262);
         this.Controls.Add(this.grpResults);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnCalculate);
         this.Controls.Add(this.grpCompoundFreq);
         this.Controls.Add(this.grpInput);
         this.Name = "InterestRateCalculatorForm";
         this.Padding = new System.Windows.Forms.Padding(25, 25, 8, 0);
         this.Text = "Interest Rate Calculator";
         this.grpInput.ResumeLayout(false);
         this.grpInput.PerformLayout();
         this.grpCompoundFreq.ResumeLayout(false);
         this.grpCompoundFreq.PerformLayout();
         this.grpResults.ResumeLayout(false);
         this.grpResults.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox grpInput;
      private System.Windows.Forms.Label lblYears;
      private System.Windows.Forms.TextBox txtInterest;
      private System.Windows.Forms.Label lblInterest;
      private System.Windows.Forms.TextBox txtPrincipal;
      private System.Windows.Forms.Label lblPrincipal;
      private System.Windows.Forms.GroupBox grpCompoundFreq;
      private System.Windows.Forms.RadioButton rbtAnnually;
      private System.Windows.Forms.RadioButton rbtSemiAnnually;
      private System.Windows.Forms.RadioButton rbtQuarterly;
      private System.Windows.Forms.RadioButton rbtMonthly;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnCalculate;
      private System.Windows.Forms.GroupBox grpResults;
      private System.Windows.Forms.TextBox txtCurrentValue;
      private System.Windows.Forms.Label lblCurrentValue;
      private System.Windows.Forms.Label lblInterestEarned;
      private System.Windows.Forms.TextBox txtYears;
      private System.Windows.Forms.Label lblInterestEarnedValue;
   }
}

