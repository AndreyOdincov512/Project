using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Одинцов
{
    public partial class FormAvtoriza : Form
    {
        public FormAvtoriza()
        {
            InitializeComponent();
        }
        bool newOP = true;
        int op = -1;
        double a = 0, b = 0, c = 0;

        private void tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' || e.KeyChar <= '9' || (Keys)e.KeyChar == Keys.Back || e.KeyChar == '.' ||
                e.KeyChar == ',')
            {
                if (newOP)
                {
                    tbx.Text = "";
                    newOP = false;
                }
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar == '.' && tbx.Text.IndexOf('.') > -1) e.Handled = true;
                if (e.KeyChar == '0' && tbx.Text == "0") e.Handled = true;
                if (tbx.Text == "0" && e.KeyChar >= '1' && e.KeyChar <= '9') tbx.Text = "";

            }
            else e.Handled = true;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            tbx.Text = "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            tbx.Text = "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            tbx.Text = "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tbx.Text = "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            tbx.Text = "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            tbx.Text = "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            tbx.Text = "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            tbx.Text = "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            tbx.Text = "9";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            op = -1;
            tbx.Text = "0";
            newOP = true;
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void bRavno_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(tbx.Text);

            switch (op)
            {
                case 1:
                    c = a + b;
                    break;
                case 2:
                    c = a - b;
                    break;
                case 3:
                    c = a * b;
                    break;
                case 4:
                    c = a / b;
                    break;
            }

            tbx.Text = Convert.ToString(c);
            newOP = true;
            op = -1;

        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            if (op > 0) bRavno_Click(sender, e);

            a = Convert.ToDouble(tbx.Text);
            newOP = true;
            op = 1;
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (op > 0) bRavno_Click(sender, e);

            a = Convert.ToDouble(tbx.Text);
            newOP = true;
            op = 2;
        }

        private void bYmn_Click(object sender, EventArgs e)
        {
            if (op > 0) bRavno_Click(sender, e);
            a = Convert.ToDouble(tbx.Text);
            newOP = true;
            op = 3;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (op > 0) bRavno_Click(sender, e);

            a = Convert.ToDouble(tbx.Text);
            newOP = true;
            op = 4;
        }

        private void bSin_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";
            tbx.Text = Math.Sin(Convert.ToDouble(tbx.Text)).ToString();
            newOP = true;
            op = -1;
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";
            tbx.Text = Math.Cos(Convert.ToDouble(tbx.Text)).ToString();
            newOP = true;
            op = -1;
        }

        private void bTg_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";

            tbx.Text = Math.Tan(Convert.ToDouble(tbx.Text)).ToString();
            newOP = true;
            op = -1;
        }

        private void bCtg_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";

            tbx.Text = (1 / (Math.Tan(Convert.ToDouble(tbx.Text)))).ToString();
            newOP = true;
            op = -1;
        }

        private void bN_Click(object sender, EventArgs e)
        {

        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";

            tbx.Text = Math.Sqrt(Convert.ToDouble(tbx.Text)).ToString();
            newOP = true;
            op = -1;
        }

        private void bAbs_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";

            tbx.Text = Math.Abs(Convert.ToDouble(tbx.Text)).ToString();
            newOP = true;
            op = -1;
        }

        private void bExp_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";

            tbx.Text = Math.Exp(Convert.ToDouble(tbx.Text)).ToString();
            newOP = true;
            op = -1;
        }

        private void b1_x_Click(object sender, EventArgs e)
        {

        }

        private void bLg_Click(object sender, EventArgs e)
        {
            if (tbx.Text == "") tbx.Text = "0";
            
            tbx.Text = Math.Log10(Convert.ToDouble(tbx.Text)).ToString();
            newOP = true;
            op = -1;
        }

        private void bX_y_Click(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {
            tbx.Text = "0";
        }

        private void bZap_Click(object sender, EventArgs e)
        {
            if (newOP)
            {
                tbx.Text = "0";
                newOP = false;
            }
            if (tbx.Text.IndexOf(',') == -1) tbx.Text += ',';
        }

    }
}

