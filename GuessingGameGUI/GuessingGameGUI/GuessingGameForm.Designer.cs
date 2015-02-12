namespace GuessingGameGUI
{
   partial class GuessingGameForm
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
         this.lblQuestion = new System.Windows.Forms.Label();
         this.btnNewGame = new System.Windows.Forms.Button();
         this.btnExit = new System.Windows.Forms.Button();
         this.lblInstruction = new System.Windows.Forms.Label();
         this.rtxHistory = new System.Windows.Forms.RichTextBox();
         this.lblNumGuessesTitle = new System.Windows.Forms.Label();
         this.lblNumGuesses = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtGuess = new System.Windows.Forms.TextBox();
         this.lblSecret = new System.Windows.Forms.Label();
         this.lblMessage = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblQuestion
         // 
         this.lblQuestion.AutoSize = true;
         this.lblQuestion.Location = new System.Drawing.Point(22, 12);
         this.lblQuestion.Name = "lblQuestion";
         this.lblQuestion.Size = new System.Drawing.Size(169, 26);
         this.lblQuestion.TabIndex = 0;
         this.lblQuestion.Text = "I have a number between 1 and\r\n1000. Can you guess the number?";
         // 
         // btnNewGame
         // 
         this.btnNewGame.Location = new System.Drawing.Point(237, 12);
         this.btnNewGame.Name = "btnNewGame";
         this.btnNewGame.Size = new System.Drawing.Size(75, 23);
         this.btnNewGame.TabIndex = 1;
         this.btnNewGame.Text = "&New Game";
         this.btnNewGame.UseVisualStyleBackColor = true;
         this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(237, 41);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(75, 23);
         this.btnExit.TabIndex = 2;
         this.btnExit.Text = "E&xit";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // lblInstruction
         // 
         this.lblInstruction.AutoSize = true;
         this.lblInstruction.Location = new System.Drawing.Point(12, 73);
         this.lblInstruction.Name = "lblInstruction";
         this.lblInstruction.Size = new System.Drawing.Size(77, 13);
         this.lblInstruction.TabIndex = 3;
         this.lblInstruction.Text = "Enter a Guess:";
         // 
         // rtxHistory
         // 
         this.rtxHistory.Location = new System.Drawing.Point(15, 103);
         this.rtxHistory.Name = "rtxHistory";
         this.rtxHistory.Size = new System.Drawing.Size(216, 124);
         this.rtxHistory.TabIndex = 5;
         this.rtxHistory.Text = "";
         // 
         // lblNumGuessesTitle
         // 
         this.lblNumGuessesTitle.AutoSize = true;
         this.lblNumGuessesTitle.Location = new System.Drawing.Point(12, 239);
         this.lblNumGuessesTitle.Name = "lblNumGuessesTitle";
         this.lblNumGuessesTitle.Size = new System.Drawing.Size(103, 13);
         this.lblNumGuessesTitle.TabIndex = 7;
         this.lblNumGuessesTitle.Text = "Number of Guesses:";
         // 
         // lblNumGuesses
         // 
         this.lblNumGuesses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblNumGuesses.Location = new System.Drawing.Point(121, 236);
         this.lblNumGuesses.Name = "lblNumGuesses";
         this.lblNumGuesses.Size = new System.Drawing.Size(29, 20);
         this.lblNumGuesses.TabIndex = 8;
         this.lblNumGuesses.Text = "0";
         this.lblNumGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(12, 268);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(40, 13);
         this.label1.TabIndex = 9;
         // 
         // txtGuess
         // 
         this.txtGuess.Location = new System.Drawing.Point(91, 69);
         this.txtGuess.Name = "txtGuess";
         this.txtGuess.Size = new System.Drawing.Size(37, 20);
         this.txtGuess.TabIndex = 10;
         // 
         // lblSecret
         // 
         this.lblSecret.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblSecret.Location = new System.Drawing.Point(194, 69);
         this.lblSecret.Name = "lblSecret";
         this.lblSecret.Size = new System.Drawing.Size(37, 20);
         this.lblSecret.TabIndex = 4;
         this.lblSecret.Text = "0";
         this.lblSecret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblMessage
         // 
         this.lblMessage.AutoSize = true;
         this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblMessage.Location = new System.Drawing.Point(12, 268);
         this.lblMessage.Name = "lblMessage";
         this.lblMessage.Size = new System.Drawing.Size(41, 13);
         this.lblMessage.TabIndex = 11;
         this.lblMessage.Text = "label2";
         // 
         // GuessingGameForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(324, 299);
         this.Controls.Add(this.lblMessage);
         this.Controls.Add(this.txtGuess);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lblNumGuesses);
         this.Controls.Add(this.lblNumGuessesTitle);
         this.Controls.Add(this.rtxHistory);
         this.Controls.Add(this.lblSecret);
         this.Controls.Add(this.lblInstruction);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.btnNewGame);
         this.Controls.Add(this.lblQuestion);
         this.KeyPreview = true;
         this.Name = "GuessingGameForm";
         this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
         this.Text = "Guessing Game";
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuessingGameForm_KeyDown);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblQuestion;
      private System.Windows.Forms.Button btnNewGame;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Label lblInstruction;
      private System.Windows.Forms.RichTextBox rtxHistory;
      private System.Windows.Forms.Label lblNumGuessesTitle;
      private System.Windows.Forms.Label lblNumGuesses;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtGuess;
      private System.Windows.Forms.Label lblSecret;
      private System.Windows.Forms.Label lblMessage;
   }
}

