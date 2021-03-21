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
        bool loaded = false;

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
                CardText.Text = deck.GetCard().GetText();
                loaded = true;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && deck.GetTop() == deck.GetFileLength(filename) && loaded == true)
            {
                deck.SetTop(-deck.GetFileLength(filename));
                CardText.Text = deck.GetCard().GetText();
            }
            else if(textBox1.Text != "" && loaded == true)
            {
                deck.SetTop(1);
                CardText.Text = deck.GetCard().GetText();
            }
        }


        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && deck.GetTop() == 0 && loaded == true)
            {
                deck.SetTop(deck.GetFileLength(filename));
                CardText.Text = deck.GetCard().GetText();
            }
            else if(textBox1.Text != "" and loaded == true)
            {
                deck.SetTop(-1);
                CardText.Text = deck.GetCard().GetText();
            }
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && loaded == true)
            {
                deck.GetCard().FlipCard();
                CardText.Text = deck.GetCard().GetText();
            }
        }

    }
}
