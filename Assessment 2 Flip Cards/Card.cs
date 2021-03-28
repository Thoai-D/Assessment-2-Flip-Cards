using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Flip_Cards
{
    class Card
    {
        private string CardName;
        private string Definition;
        private bool Flipped;


        public Card(string name, string definition)
        {
            CardName = name;
            Definition = definition;
            Flipped = false;
        }



        /// <summary>
        /// Gets the text depending on whether it is flipped or not
        /// </summary>
        /// <returns>a string</returns>
        public string GetText()
        {
            if (Flipped)
            {
                return Definition;
            }
            else if (!Flipped)
            {
                return CardName;
            }
            return CardName;
        }

        
        /// <summary>
        /// checks if the card is flipped or not
        /// </summary>
        /// <returns>a bool</returns>
        public bool IsFlipped()
        {
            return Flipped;
        }


        /// <summary>
        /// Flips the card
        /// </summary>
        public void FlipCard()
        {
            if (Flipped)
            {
                Flipped = false;
            }
            else if(!Flipped)
            {
                Flipped = true;
            }
        }

    }
}
