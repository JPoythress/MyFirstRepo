using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Player
    {
        //Atrubutes (instance variables)
        private string name;
        private int score;
        private int livesLeft;

        //Constructors (generates a new object)
        public Player(string name)
        {
            this.name = name;
        }//end method

        public Player(string name, int startingLives) 
        {
            this.name = name;
            livesLeft = startingLives;
        }//end method

        //Methods = behaviors or tasks that the object can perform

        public int GetScore()
        { 
            return score; 
        }//end method

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }//end method

        public void Kill()
        {
            //We make sure that they cant get negative lines
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }
        public int GetLivesLeft()
        {
            return livesLeft;
        }//end method
        
    } //end class
} //end namespace
