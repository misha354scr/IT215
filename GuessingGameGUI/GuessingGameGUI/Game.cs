using System;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GuessingGameGUI
{

    public class Game
    {
        //constants - the low and high numbers for the guess range
        public const int LOW = 1;
        public const int HI = 1000;

        //fields

        //the random numbers generator
        private static Random rand  = new Random();

        //instance variables related to the guessing process
        private bool lastGuessValid; //was the last guess the user tried to set valid?
        private int numTries; //the number of guesses the user has attempted so far
        private int secretNum;       //the secret number the user is trying to guess
        private int usersGuess;   //The users's guess
        private int lastGuess; 	 //the user's last guess
        private bool guessCloser; //true if current guess closer than the last one
        private bool guessSameDistance; //true if the user repeated the same guess twice

        //a status message to give to the user
        private string status;

        //Proprties

        //true if the user has guessed the number
        public bool Guessed
        {
            get
            {
                return UsersGuess == secretNum;
            }
        }

        //true if this guess is better than the last guess
        public bool GuessCloser
        {
            get 
            {
               return guessCloser;
            }
        }

        //True if the user's guess is too low
        public bool GuessLow
        {
            get
            {
                return UsersGuess < SecretNum;
            }
        }

        //True if the user's guess is too hi
        public bool GuessHi
        {
            get
            {
                return UsersGuess > SecretNum;
            }
        }

        public bool GuessSameDistance 
        {
            get
            {
                return guessSameDistance;
            }
        }

        //returns true if the last time TryGuess was called it had a valid
        //argument, false otherwise. Returns true initially.
        public bool LastGuessValid
        {
            get
            {
                return lastGuessValid;
            }
        }

        //the maximum number of guesses that the user needs to make
        public int MaxNumTries
        {
            get
            {
                return (int)Math.Ceiling(Math.Log(HI - LOW) / Math.Log(2));
            }
        }

        //the number of times the user has tried to guess
        public int NumTries
        {
            get
            {
                return numTries;
            }
        }

        //This game's secret number
        public int SecretNum
        {
            get
            {
                return secretNum;
            }
        }

        //the user's current guess
        public int UsersGuess
        {
            get
            {
                return usersGuess;
            }
        }

        public string Status 
        {
            get 
            {
                return status;
            }
        }


        /**constructor
         */
        public Game()
        {
            numTries = 0;
            secretNum = rand.Next(HI) + 1;

            status = "New game in progress.";
            lastGuessValid = false;
        }

        //public methods

        //Parses the user's guess.  If guess is invalid, exits
        //and sets the LastGuessValid property to false.
        //Otherwise, saves the user's guess, increments the tries counter
        //and updates the status property if the guess was correct.
        //Parameter:
        //guess - a string containing the users Guess.
        public void TryGuess(string guess)
        {
            int value = 0;

           //try reading the user's guess
            try
            {
                value = Convert.ToInt32(guess); //parse the guess string

                //check to make sure that the guess is in range
                if (value < Game.LOW || value > Game.HI)
                {
                    throw new ArgumentException();
                }

                usersGuess = value; //save the users guess
                guessCloser = IsCloser(); //determine whether it's closer than the last one
                guessSameDistance = IsSameDistance(); //determine whether this guess is a repeat of the last one 

                //this guess will be the "last guess" on the next call
                lastGuess = usersGuess;

                UpdateNumTries(); //update the try counter
                SetStatus(); //update the game's status string
                lastGuessValid = true; //lets the client know that a guess was accepted
            }

            catch
            //the guess was out of range or not an integer
            {
                lastGuessValid = false;
            }
        }

        public int getWinningNumTries()
        {
            return (int)Math.Ceiling(Math.Log(HI - LOW) / Math.Log(2));
        }

        //Private methods

        private bool IsCloser() 
        {
            return Math.Abs(secretNum - usersGuess) < Math.Abs(secretNum - lastGuess);
        }

        private bool IsSameDistance()
        {
           return Math.Abs(usersGuess - secretNum) == 
                  Math.Abs(lastGuess - secretNum);
        }

        //sets the status string after a guess has been entered
        //three possible outcomes
        //1) if guess not correct, status left alone
        //2) user guessed the number, but used more tries than necessary - berate 
        //3 user guessed the number, and used correct number of guesses - praise
        private void SetStatus()
        {
            if (Guessed)
            {
                if (NumTries <= MaxNumTries)
                {
                    status = "Congratulations! You have guessed the number.";
                }
                else
                {
                    status = "You have guessed the number, but you can do better.";
                }
            }
        }

        private void UpdateNumTries()
        {
            numTries++;
        }
    }
}
