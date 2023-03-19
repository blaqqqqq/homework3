using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace codetkhome3
{
    public partial class SecondWindform : Form
    {
        public SecondWindform()
        {
            InitializeComponent();
        }
        public void labeltext(string name, string artist)
        {
            labeltxt.Text = "Hi, my name is " + name + "and my favorite artist is" + artist;
        }

        private void magic_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (agre.Checked == true && yes.Checked == true)
            {
                magic.Enabled = true;
            }
            mainform form1 = new mainform();
            if (red.Checked == true)
            {
                form1.BackColor = Color.Red;
                check = true;
            }
            else if (green.Checked == true)
            {
                form1.BackColor = Color.Green;
                check = true;
            }
            else if (blue.Checked == true)
            {
                form1.BackColor = Color.Blue;
                check = true;
            }
            else if (yellow.Checked == true)
            {
                form1.BackColor = Color.Yellow;
                check = true;
            }
            if (pink.Checked == true)
            {
                form1.ForeColor = Color.Pink;
                check = true;
            }
            else if (orange.Checked == true)
            {
                form1.ForeColor = Color.Purple;
                check = true;
            }
            else if (black.Checked == true)
            {
                form1.ForeColor = Color.Orange;
                check = true;
            }
            if (check == false)
            {
                MessageBox.Show("choose the color");
            }

            form1.Show();
        }

        private void agre_CheckedChanged(object sender, EventArgs e)
        {
            if (agre.Checked == true && yes.Checked == true)
            {
                magic.Enabled = true;
            }
        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {

            if (agre.Checked == true && yes.Checked == true)
            {
                magic.Enabled = true;
            }
        }

    }
}











