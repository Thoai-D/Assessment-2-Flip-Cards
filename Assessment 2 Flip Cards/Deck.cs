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



    }
}
