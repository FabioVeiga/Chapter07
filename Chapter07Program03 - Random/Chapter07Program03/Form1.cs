using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07Program03
{
    public partial class frmMain : Form
    {
        const int MAXITERATIONS = 2000000; //Limit loop passes

        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            bool flag;
            int counter;
            int max;
            int last;
            int current;
            Random randomNumber = new Random();

            flag = int.TryParse(txtMax.Text, out max);
            if(flag == false)
            {
                MessageBox.Show("Digit characters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMax.Focus();
                txtMax.Clear();
                return;
            }
            counter = 0;
            last = (int)randomNumber.Next(max);
            do
            {
                current = randomNumber.Next(max);
                if (last == current)
                {
                    break;
                }
                last = current;
                counter++;
            } while (counter < MAXITERATIONS);

            if(counter < MAXITERATIONS)
            {
                lblAnswer.Text = "It took " + counter.ToString() + " passes to match";
            }
            else
            {
                lblAnswer.Text = "No back-to-back match";
            }
        }
    }
}
