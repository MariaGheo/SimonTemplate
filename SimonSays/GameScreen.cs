using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    /* Extra stuff:
     * 1. Label that keeps track of pattern length while playing.
     * 2. Array that keeps track of the top three scores. Label that says "New high score!". Label that shows the top three scores on the menu screen and/or the game over screen.
     * 3. Make 3 speeds the user gets to choose between (after they click "new game" take them to a new user control where they choose, then use their response to set the wait time).
     */

    public partial class GameScreen : UserControl
    {
        public static int guess;
        public static int pauseTime;
        SoundPlayer[] player = { new SoundPlayer(Properties.Resources.green), new SoundPlayer(Properties.Resources.red), new SoundPlayer(Properties.Resources.yellow), new SoundPlayer(Properties.Resources.blue), new SoundPlayer(Properties.Resources.mistake) };
        Color[] highlightColor = { Color.LawnGreen, Color.Red, Color.Gold, Color.Blue };

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(1500);
            lengthLabel.Text = "0";
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            Random randGen = new Random();
            Form1.pattern.Add(randGen.Next(0, 4));
            guess = 0;
            lengthLabel.Text = $"{Form1.pattern.Count}";
            Thread.Sleep(pauseTime * 3);

            for(int i = 0; i < Form1.pattern.Count; i++)
            {
                switch (Form1.pattern[i])
                {
                    case 0:
                        ActivateButton(greenButton);
                        break;
                    case 1:
                        ActivateButton(redButton);
                        break;
                    case 2:
                        ActivateButton(yellowButton);
                        break;
                    case 3:
                        ActivateButton(blueButton);
                        break;
                }
                
                Thread.Sleep(pauseTime);
            }
        }

        private void anyButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Form1.pattern[guess] == Convert.ToInt16(button.Tag)) //if the player guesses correctly, temporarily change the button colour, play the sound effect for that specific button, and add to the guess number tracker
            {
                ActivateButton(button);
                guess++;

                if (guess == Form1.pattern.Count) //if this is the end of the sequence so far, then it is the computer's turn
                {
                    ComputerTurn();
                }
            }
            else //if the player guesses incorrectly, do the game over sequence
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            player[4].Play(); //play gameover sound
            Form1.ChangeScreen(this, new GameOverScreen()); //close this screen and open the GameOverScreen
        }

        public void ActivateButton(Button button) //temporarily switch the button colour and play its sound effect
        {
            Color originalColor = button.BackColor;
            
            button.BackColor = highlightColor[Convert.ToInt16(button.Tag)];
            player[Convert.ToInt16(button.Tag)].Play();

            Refresh();

            Thread.Sleep(pauseTime);
            button.BackColor = originalColor;

            Refresh();
        }
    }
}