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

        public Deck(string FileName)
        {
            Cards = new Card[GetFileLength(FileName)];
            LoadDeck(FileName);
        }


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


        public void ShuffleDeck()
        {
            for (int i = 0; i < GetFileLength(FileName); i++)
            {
                if(Cards[i].IsFlipped() == true)
                {
                    Cards[i].FlipCard();
                }
            }

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

        public Card GetRandomCard()
        {
            Random r = new Random();
            int Random = r.Next(0, GetFileLength(FileName));
            return Cards[Random];
        }

        public Card GetTopCard()
        {
            return Cards[top];
        }

        public void SetTop(int n)
        {
            top += n;
        }

        public int GetTop()
        {
            return top;
        }

        public Card GetNextCard()
        {
            if (top == GetFileLength(FileName))
            {
                SetTop(-GetFileLength(FileName));
                return Cards[top];
            }
            else
            {
                SetTop(1);
                return Cards[top];
            }
        }

        public Card GetPreviousCard()
        {
            if (top == 0)
            {
                SetTop(GetFileLength(FileName));
                return Cards[top];
            }
            else
            {
                SetTop(-1);
                return Cards[top];
            }
        }
    }
}
