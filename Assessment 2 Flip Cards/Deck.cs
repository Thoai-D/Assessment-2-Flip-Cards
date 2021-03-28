using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Assessment_2_Flip_Cards
{
    class Deck
    {
        private Card[] Cards;
        private string FileName;
        private int top;
        private bool AutomaticallyFlip = true;

        public Deck(string FileName)
        {
            Cards = new Card[GetFileLength(FileName)];
            LoadDeck(FileName);
        }

        /// <summary>
        /// Loads the deck onto the program
        /// </summary>
        /// <param name="FileName"></param>
        public void LoadDeck(string FileName)
        {
            StreamReader FileReader = new StreamReader(FileName);
            string line;
            int count = 0;
            this.FileName = FileName;
            while((line = FileReader.ReadLine()) != null)
            {
                string[] cells = line.Split(',');
                string cardname = cells[0];
                string definition = cells[1];
                Cards[count] = new Card(cardname, definition);
                count++;
            }
        }
        

        /// <summary>
        /// Gets the length of the deck
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns>an int</returns>
        public int GetFileLength(string FileName)
        {
                StreamReader FileReader = new StreamReader(FileName);
                string line;
                int count = 0;
                while ((line = FileReader.ReadLine()) != null)
                {
                    count++;
                }
                return count;
        }



        /// <summary>
        /// Shuffles the deck by the size of the deck + 20
        /// </summary>
        public void ShuffleDeck()
        {

            //This loop flips the cards back to its definitions again before shuffling to avoid complexity
            for (int i = 0; i < GetFileLength(FileName); i++)
            {
                if(Cards[i].IsFlipped() == true)
                {
                    Cards[i].FlipCard();
                }
            }

            //shuffle the cards by how many cards there are +20 more shuffles to be sure it is shuffled
            for(int i = 0; i < (GetFileLength(FileName) + 20); i++)
            {
                Random r1 = new Random();
                Random r2 = new Random();
                int Random1 = r1.Next(0, GetFileLength(FileName));
                int Random2 = r2.Next(0, GetFileLength(FileName));
                Card TempCard;

                TempCard = Cards[Random1];
                Cards[Random1] = Cards[Random2];
                Cards[Random2] = Cards[Random1];
            }
            top = 0;
        }


        /// <summary>
        /// Gets a random card from the deck
        /// </summary>
        /// <returns>a card</returns>
        public Card GetRandomCard()
        {
            Random r = new Random();
            int Random = r.Next(0, GetFileLength(FileName));
            return Cards[Random];
        }

        /// <summary>
        /// Gets the card that is on top of the deck
        /// </summary>
        /// <returns>a card</returns>
        public Card GetTopCard()
        {
            return Cards[top];
        }

        /// <summary>
        /// Sets the top of the deck. Adds the value of n to the "top" variable
        /// </summary>
        /// <param name="n"></param>
        public void SetTop(int n)
        {
            top += n;
        }


        /// <summary>
        /// Sets the top of the deck to zero
        /// </summary>
        public void SetTopToZero()
        {
            top = 0;
        }

        /// <summary>
        /// Gets the next card in the deck
        /// </summary>
        /// <returns>returns the next card in the deck</returns>
        public Card GetNextCard()
        {
            if (AutomaticallyFlip == true && Cards[top].IsFlipped() == true)
            {
                Cards[top].FlipCard();
            }

            if (top == (GetFileLength(FileName) - 1)) //This is to make sure that it does not go out of bounds of the deck size
            {
                SetTop(-GetFileLength(FileName) + 1);
                return Cards[top];
            }
            else
            {
                SetTop(1);
                return Cards[top];
            }
        }


        /// <summary>
        /// Gets the previous card from the deck
        /// </summary>
        /// <returns>Returns the previous card</returns>
        public Card GetPreviousCard()
        {
            if(AutomaticallyFlip == true && Cards[top].IsFlipped() == true)
            {
                Cards[top].FlipCard();
            }


            if (top == 0) //This is to make sure that it does not go out of bounds of the deck size
            {
                SetTop(GetFileLength(FileName) - 1);
                return Cards[top];
            }
            else
            {
                SetTop(-1);
                return Cards[top];
            }
        }

        /// <summary>
        /// Toggles the automatically flipped boolean
        /// </summary>
        public void ToggleAutoFlip()
        {
            if (AutomaticallyFlip == true) { AutomaticallyFlip = false; }
            else if (AutomaticallyFlip == false) { AutomaticallyFlip = true; }
        }


        /// <summary>
        /// Gets the status of the AutomaticallyFlipped boolean
        /// </summary>
        /// <returns>the boolean value of Automatically Flip</returns>
        public bool GetAutoFlipStatus()
        {
            return AutomaticallyFlip;
        }
    }
}
