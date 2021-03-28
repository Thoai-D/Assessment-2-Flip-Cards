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
        private string filename;
        private Deck deck;
        private Card card;
        private bool QuizMode;


        public Form1()
        {
            InitializeComponent();
            AnswerTextBox.Visible = false;
            SubmitAnswerButton.Visible = false;
            QuizMode = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QuizMode == false)
            {
                openFileDialog1.ShowDialog();
                filename = openFileDialog1.FileName;

                textBox1.Text = filename;
            }
        }
        

        /// <summary>
        /// Loads in a new deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && QuizMode == false)
            {
                deck = new Deck(textBox1.Text);
                card = deck.GetTopCard();
                CardText.Text = card.GetText();
            }
        }


        /// <summary>
        /// Gets the next card in the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(deck != null)
            {
                card = deck.GetNextCard();
                CardText.Text = card.GetText();
            }
        }

        /// <summary>
        /// Gets the previous card in the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (deck != null)
            {
                card = deck.GetPreviousCard();
                CardText.Text = card.GetText();
            }
        }


        /// <summary>
        /// flips the card that is displayed on the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipButton_Click(object sender, EventArgs e)
        {
            if (deck != null)
            {
                card.FlipCard();
                CardText.Text = card.GetText();         
            }
        }


        /// <summary>
        /// shuffles the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            if (deck != null)
            {
                deck.ShuffleDeck();
                card = deck.GetTopCard();
                CardText.Text = card.GetText();
            }
        }


        /// <summary>
        /// Gets a random card but does not set the top to the random card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomCardButton_Click(object sender, EventArgs e)
        {
            if (deck != null)
            {
                card = deck.GetRandomCard();
                CardText.Text = card.GetText();
            }
        }

        /// <summary>
        /// Toggles the autoflip method within the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoFlipButton_Click(object sender, EventArgs e)
        {
            if (deck != null)
            {
                deck.ToggleAutoFlip();
                if (deck.GetAutoFlipStatus() == true)
                {
                    AutoFlipButton.Text = "Automatically Flip: On";
                }
                else if (deck.GetAutoFlipStatus() == false)
                {
                    AutoFlipButton.Text = "Automatically Flip: Off";
                }
            }
        }



        /// <summary>
        /// Toggles the quiz mode and makes the buttons visible or invisible depending on the mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuizModeButton_Click(object sender, EventArgs e)
        {
            if (QuizMode == false && deck != null)
            {
                SubmitAnswerButton.Visible = true;
                AnswerTextBox.Visible = true;
                QuizModeButton.Text = "End Quiz";
                QuizMode = true;
                PreviousButton.Visible = false;
                FlipButton.Visible = false;
                NextButton.Visible = false;
                RandomCardButton.Visible = false;
                AutoFlipButton.Visible = false;
                ShuffleButton.Visible = false;
                flipAllCards();
                card = deck.GetRandomCard();
                CardText.Text = card.GetText();
            }
            else if (QuizMode == true)
            {
                SubmitAnswerButton.Visible = false;
                AnswerTextBox.Visible = false;
                QuizModeButton.Text = "Quiz Mode";
                QuizMode = false;
                PreviousButton.Visible = true;
                FlipButton.Visible = true;
                NextButton.Visible = true;
                RandomCardButton.Visible = true;
                ShuffleButton.Visible = true;
                AutoFlipButton.Visible = true;
                deck.SetTopToZero();
                card = deck.GetTopCard();
                CardText.Text = card.GetText();
            }
        }

        public void SubmitAnswerButton_Click(object sender, EventArgs e)
        {
            if (SubmitAnswerButton.Text == "Submit")
            {
                card.FlipCard();
                string UserAnswer = AnswerTextBox.Text;
                if (UserAnswer == card.GetText())
                {
                    CardText.Text = "Correct!";
                    card.FlipCard();
                }
                else
                {
                    CardText.Text = "Wrong! The answer is " + card.GetText();
                    card.FlipCard();
                }
                AnswerTextBox.Text = "";
                SubmitAnswerButton.Text = "Next";
            }
            else
            {
                card = deck.GetRandomCard();
                CardText.Text = card.GetText();
                SubmitAnswerButton.Text = "Submit";
            }
        }




        public void flipAllCards()
        {
            deck.SetTopToZero();
            card = deck.GetTopCard();
            if(deck.GetAutoFlipStatus() == true)
            {
                deck.ToggleAutoFlip();
                for (int i = 0; i < deck.GetFileLength(filename); i++)
                {
                    if (card.IsFlipped() == false)
                    {
                        card.FlipCard();
                        card = deck.GetNextCard();
                    }
                }
                deck.ToggleAutoFlip();
            }
            else
            {
                for (int i = 0; i < deck.GetFileLength(filename); i++)
                {
                    if (card.IsFlipped() == false)
                    {
                        card.FlipCard();
                        card = deck.GetNextCard();
                    }
                }
            }
        }
        
    }
}
