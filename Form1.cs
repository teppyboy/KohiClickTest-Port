using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KohiClickTest_Port
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countnum = 0;

        double clicked = 0;

        bool timerstart = false;

        private void clickbutton_Click(object sender, EventArgs e)
        {
            if (timerstart == false)
            {
                time.Visible = true;
                time.Text = "0";
                timerstart = true;
                count.Start();
                clicked++;
                clickcount.Text = "Clicks: " + clicked.ToString();
            }
            else
            {
                clicked++;
                clickcount.Text = "Clicks: " + clicked.ToString();
            }
        }

        private void counttick(object sender, EventArgs e)
        {
            countnum++;
            if (countnum == 10)
            {
                restart.Visible = true;
                timerstart = false;
                time.Visible = false;
                clickcount.Text = "Result: " + (clicked / 10).ToString() + " CPS";
                countnum = 0;
                clickbutton.Visible = false;
                count.Stop();
            }
            else
            {
                time.Text = countnum.ToString();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            countnum = 0;
            clicked = 0;
            timerstart = false;
            clickbutton.Visible = true;
            restart.Visible = false;
            clickcount.Text = "Clicks: 0";
        }
    }
}
