using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class SpeedScreen : UserControl
    {
        public SpeedScreen()
        {
            InitializeComponent();
        }

        private void anyButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            GameScreen.pauseTime = 130 * Convert.ToInt16(button.Tag);

            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
