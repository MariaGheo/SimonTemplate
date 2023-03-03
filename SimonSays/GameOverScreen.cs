using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e) //set up and show the high scores
        {
            lengthLabel.Text = $"{Form1.pattern.Count}";
            scoresLabel.Text = "";
            
            if(Form1.pattern.Count > Form1.highScore[2])
            {
                newHighScoreLabel.Visible = true;

                Form1.highScore[3] = Form1.pattern.Count;
                Array.Sort(Form1.highScore);
                Array.Reverse(Form1.highScore);
            }
            else
            {
                newHighScoreLabel.Visible = false;
            }

            for(int i = 0; i < 3; i++)
            {
                scoresLabel.Text += $"{i + 1}. {Form1.highScore[i]}\n";
            }
        }

        private void closeButton_Click(object sender, EventArgs e) //close this screen and open the MenuScreen
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
