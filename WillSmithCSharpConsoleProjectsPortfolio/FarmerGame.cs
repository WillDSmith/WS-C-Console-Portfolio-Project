// Portfolio Program
// Programmer: Willie D Smith
// 05/12/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillSmithCSharpConsoleProjectsPortfolio
{
    class FarmerGame
    {
        public enum Direction { north, south };
        List<string> northbank;
        List<string> southbank;
        Direction farmer;

        public FarmerGame()
        {
            // State of the game
            northbank = new List<string>();
            southbank = new List<string>();
            farmer = Direction.north;
            northbank.Insert(0, "farmer");
            northbank.Add("chicken");
            northbank.Add("fox");
            northbank.Add("grain");

        }

        public Direction Farmer
        {
            get { return farmer; }
        }

        public List<string> NorthBank
        {
            get { return northbank; }
        }

        public List<string> SouthBank
        {
            get { return southbank; }
        }

        public void Move(string choice)
        {
            bool success = false;

            if (farmer == Direction.north) // Moving south
            {
                // Flag to make sure the choice string variable 
                // was successfully moved from the northbank?
                success = northbank.Remove(choice) && northbank.Remove("farmer");

                if (success == true)

                    southbank.Insert(0, "farmer");
                southbank.Add(choice);
                farmer = Direction.south;

                AnimalAteFood();
                DetermineWin();

            }
            else if (farmer == Direction.south) // Moving north
            {
                // Flag to make sure the choice string variable 
                // was successfully moved from the northbank?
                success = southbank.Remove(choice) && southbank.Remove("farmer");

                if (success == true)

                    northbank.Insert(0, "farmer");
                northbank.Add(choice);
                farmer = Direction.north;

                AnimalAteFood();
                DetermineWin();

            }
        }

        public bool AnimalAteFood()
        {
            bool animalAte = false;

            if (northbank.Contains("chicken") && northbank.Contains("fox") && farmer != Direction.north)
            {
                animalAte = true;
            }
            else if (northbank.Contains("chicken") && northbank.Contains("grain") && farmer != Direction.north)
            {
                animalAte = true;
            }
            else if (southbank.Contains("chicken") && southbank.Contains("fox") && farmer != Direction.south)
            {
                animalAte = true;
            }
            else if (southbank.Contains("chicken") && southbank.Contains("grain") && farmer != Direction.south)
            {
                animalAte = true;
            }

            return animalAte;
        }

        public bool DetermineWin()
        {
            bool factor = false;

            if (southbank.Contains("chicken") && southbank.Contains("grain") && southbank.Contains("fox"))
            {
                factor = true;
            }

            return factor;
        }

        public bool GameOver()
        {
            bool state = false;

            if (AnimalAteFood() == true)
            {
                state = true;
            }

            if (DetermineWin() == true)
            {
                state = true;
            }

            return state;
        }
    }
}
