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

        public string GetText()
        {
            if (Flipped)
            {
                return CardName;
            }
            else if (!Flipped)
            {
                return Definition;
            }
        }
        public bool IsFlipped()
        {
            return Flipped;
        }
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
