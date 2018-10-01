using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner_2._0
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            costLabel.Text = cost.ToString("C");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void costLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
