using SnapCardGame.EnumItem;
using SnapCardGame.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapCardGame
{
    public partial class Form1 : Form
    {
        private readonly Snap myGame = null;
        public Form1()
        {
            InitializeComponent();
            myGame = new Snap();
            cmbMatchCase.DataSource = Enum.GetNames(typeof(SnapMatchCase));
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            myGame.StartGame();
            richTextBox1.Text = string.Empty;
            richTextBox1.Text += "WELCOME TO SNAP CARD GAME";
            richTextBox1.Text += "\r\nRemainig Card : " + myGame.CardsRemain;
            richTextBox1.Text += "\r\nSnap Match Case is : " + cmbMatchCase.SelectedItem.ToString();
            richTextBox1.Text += "\r\nGame Started : " + myGame.IsStarted;
            label1.Text = "Card Left in deck : " + myGame.CardsRemain;
            ((Button)sender).Enabled = false;
            cmbMatchCase.Enabled = false;
        }
        private void btnFlipCard1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (myGame.CardsRemain > 0)
            {
                myGame.FlipNextCard();
                richTextBox1.Text += string.Format("\r\n[Player {0}] # Last Two Cards: {1}", btn.Tag, myGame.TopTwoCardName());
                richTextBox1.Text += GetSeprator();
                label1.Text = "Card Left in deck : " + myGame.CardsRemain;
                UpadteButtonPanel(btn);
            }
            else
            {
                int player1Score = myGame.Score(0);
                int player2Score = myGame.Score(1);

                label1.Text = "Card Left in deck : " + myGame.CardsRemain;
                richTextBox1.Text += GetSeprator();
                richTextBox1.Text += string.Format("\r\nGame End !!!\r\nPlayer 1 Score = {0}\r\nPlayer 2 Score = {1}", player1Score, player2Score);
                if (player1Score == player2Score)
                {
                    richTextBox1.Text += "\r\nMatch Draw between the players";
                }
                else
                {
                    string playerName = player1Score > player2Score ? "Player 1" : "Player 2";
                    richTextBox1.Text += "\r\nMatch win by" + playerName;
                }
                richTextBox1.Text += GetSeprator();
            }
        }
        private void UpadteButtonPanel(Button btn)
        {
            if (btn.Tag.ToString() == "1")
            {
                btnSnapHitP2.Enabled = false;
                btnSnapHitP1.Enabled = true;
                btnFlipCard1.Enabled = false;
                btnFlipCard2.Enabled = true;
            }
            else
            {
                btnSnapHitP2.Enabled = true;
                btnSnapHitP1.Enabled = false;
                btnFlipCard1.Enabled = true;
                btnFlipCard2.Enabled = false;
            }
        }
        private string GetSeprator()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n");
            for (int i = 0; i < 180; i++)
            {
                sb.Append("-");
            }
            return sb.ToString();
        }
        private void btnSnapHitP1_Click(object sender, EventArgs e)
        {
            myGame.PlayerHitSnap(0, cmbMatchCase.SelectedItem.ToString());
            txtScoreBoard1.Text = myGame.Score(0).ToString();
            ((Button)sender).Enabled = false;
        }
        private void btnSnapHitP2_Click(object sender, EventArgs e)
        {
            myGame.PlayerHitSnap(1, cmbMatchCase.SelectedItem.ToString());
            txtScoreBoard2.Text = myGame.Score(1).ToString();
            ((Button)sender).Enabled = false;
        }
    }
}
