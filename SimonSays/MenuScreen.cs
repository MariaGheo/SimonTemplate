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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_Load(object sender, EventArgs e) //set up the menu screen with the list of high scores
        {
            scoresLabel.Text = "";

            for (int i = 0; i < 3; i++)
            {
                scoresLabel.Text += $"{i + 1}. {Form1.highScore[i]}\n";
            }
        }

        private void newButton_Click(object sender, EventArgs e) //change the screen to let the user pick a game speed
        {
            Form1.ChangeScreen(this, new SpeedScreen());
        }

        private void exitButton_Click(object sender, EventArgs e) //exit the program
        {
            Application.Exit();
        }
    }
}
