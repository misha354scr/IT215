using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GuessingGameGUI
{
   public partial class GuessingGameForm : Form
   {

      Game g; //the guessing game object.

      public GuessingGameForm()
      {
         InitializeComponent();

         //use the game's boundaries to pose question to user
         lblQuestion.Text = String.Format("I have a number between {0} and\n" +
                               "{1}. Can you guess the number?", Game.LOW, Game.HI);
         InitGame();  //create a new game object and update the GUI state
         this.KeyPreview = true;
      }


      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnNewGame_Click(object sender, EventArgs e)
      {
         InitGame();
      }

      //event handler for an enter keypress
      private void GuessingGameForm_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            e.SuppressKeyPress = true;
            AcceptGuess();
         }
      }

      //non-event handler private methods

      //reads the users guess from the textbox and drives execution
      //forward
      private void AcceptGuess()
      {
         //try to play the user's guess
         g.TryGuess(txtGuess.Text);

         //Do tasks that get done after both correct or incorrect guesses
         DoAfterGuessTasks();

         if (g.Guessed)
         //Do tasks tasks that get done only when the user guessed correctly
         {
            DoAfterCorrectGuessTasks();
         }

         else
         //Do tasks tasks that get done only when the user guessed wrong
         {
            DoAfterWrongGuessTasks();
         }
      }

      //Resets form to state it should have
      //after the user has guessed correctly
      private void DoAfterCorrectGuessTasks()
      {
         txtGuess.Enabled = false;
      }

      //Tasks that should be done after guess,
      //regardless of whether it's correct
      private void DoAfterGuessTasks()
      {
         UpdateHistory(); //update the history text box
         UpdateNumTries();

         SetBackColor();

         //update the number of tries textbox
         lblNumGuesses.Text = g.NumTries.ToString();

         //Update the status message label
         lblMessage.Text = g.Status;

         //enable the new game button
         btnNewGame.Enabled = true;

         //clear the guess textbox
         txtGuess.Clear();
      }

      //sets the controls to states they should
      //after an incorrect guess
      private void DoAfterWrongGuessTasks()
      {
         btnNewGame.Enabled = true;
         SetBackColor();
         lblNumGuesses.Text = g.NumTries.ToString();
      }

      //creates a new game object and sets gui state to new game
      private void InitGame()
      {
         g = new Game(); //get a new game object

         //set the form color to default
         this.BackColor = SystemColors.Control;

         //enable controls that make sense for this game state
         btnNewGame.Enabled = false;
         txtGuess.Enabled = true; //enable the guess textbox

         //Gather information from the game and write it to the GUI
         lblMessage.Text = g.Status;
         lblSecret.Text = g.SecretNum.ToString(); //for debugging
         UpdateNumTries();

         txtGuess.Clear(); //clear content from last games
         rtxHistory.Clear();
      }

      // sets the background color after reading a guess
      private void SetBackColor()
      {
         //if user guessed correctly, make background light green
         if (g.Guessed) this.BackColor = Color.LightGreen;

         //user guessed wrong
         else
         {
            //if this isn't the first guess and if this guess 
            //is not the same distance from the secret as the last guess
            if (g.NumTries > 1 && !g.GuessSameDistance)
            {
               if (g.GuessCloser)
               //user got closer, so make screen red for "warmer"
               {
                  this.BackColor = Color.LightSalmon;
               }
               //user is further away, so make screen blue for "cold"
               else
               {
                  this.BackColor = Color.LightBlue;
               }
            }
         }
      }

      //updates the history textbox based on the result
      //of an interaction with the user
      private void UpdateHistory()
      {
         //If the user guessed the number, the game is over, so no need to update the history box
         if (!g.Guessed)
         {
            if (!g.LastGuessValid)
            //user entered invalid input, print an error message
            {
               rtxHistory.Text += String.Format("{0}: Invalid input\n", txtGuess.Text);
            }

            else if (g.GuessHi)
            //user guessed too low
            {
               rtxHistory.Text += String.Format("{0} - Too high, guess a bit lower\n", g.UsersGuess);

            }
            else
            //the user guessed too low
            {
               rtxHistory.Text += String.Format("{0} - Too low, guess a bit higher\n", g.UsersGuess);
            }
         }
      }

      private void UpdateNumTries()
      {
         lblNumGuesses.Text = (g.NumTries + 1).ToString();
      }

   }
}
