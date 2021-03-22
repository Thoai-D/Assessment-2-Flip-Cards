using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2_Flip_Cards
{ 
    public partial class Form1 : Form
    {
        string filename;
        Deck deck;
        Card card;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;

            textBox1.Text = filename;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                deck = new Deck(textBox1.Text);
                card = deck.GetTopCard();
                CardText.Text = card.GetText();
                comboBox1.Text = filename;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(deck != null)
            {
                card = deck.GetNextCard();
                CardText.Text = card.GetText();
            }
        }


        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (deck != null)
            {
                card = deck.GetPreviousCard();
                CardText.Text = card.GetText();
            }
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            if (deck != null)
            {
                card.FlipCard();
                CardText.Text = card.GetText();         
            }
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            deck.ShuffleDeck();
            card = deck.GetTopCard();
            textBox1.Text = card.GetText();
        }

        private void RandomCardButton_Click(object sender, EventArgs e)
        {
            card = deck.GetRandomCard();
            textBox1.Text = card.GetText();
        }
    }
}
