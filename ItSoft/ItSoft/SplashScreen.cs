using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItSoft
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingBarProgress();
            this.Close();

        }

        private void loadingBar_Click(object sender, EventArgs e)
        {

        }

        private void loadingBarProgress()
        {
            int i;

            loadingBar.Minimum = 0;
            loadingBar.Maximum = 100;

            for (i = 0; i < loadingBar.Maximum; i++)
            {
                Thread.Sleep(30);
                loadingBar.Value = i;
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
