using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7Program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int start;
            int end;
            string buff;

            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric Data only", "Input Error");
                txtStart.Focus();
                txtStart.Clear();
                return;
            }
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric Data only", "Input Error");
                txtEnd.Focus();
                txtEnd.Clear();
                return;
            }
            if(start >= end)
            {
                MessageBox.Show("Start greater than End", "Input Error");
                txtStart.Focus();
                txtStart.Clear();
                txtEnd.Clear();
                return;
            }
            for(i = start; i <= end; i++)
            {
                buff = string.Format("{0,5}{1,35}", i, i * i);
                lstOutput.Items.Add(buff);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }
    }
}
