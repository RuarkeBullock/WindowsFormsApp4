using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.

            outletLabel.Text = "4";
            Refresh();
            Thread.Sleep(1000);

            outletLabel.Text = "3";
            Refresh();
            Thread.Sleep(1000);

            outletLabel.Text = "2";
            Refresh();
            Thread.Sleep(1000);

            outletLabel.Text = "1";
            Refresh();
            Thread.Sleep(1000);

            outletLabel.Text = "go";
            Refresh();
            Thread.Sleep(1000);

        }
    }
}
