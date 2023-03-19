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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void nextform_button_Click(object sender, EventArgs e)
        {
            SecondWindform form2 = new SecondWindform();
            form2.Show();
            nextform_button.Enabled = false;
            if (true_cek.Checked == true && nextform_button.Enabled == false)
            {
                enter.Enabled = true;
            }
        }

        private void true_cek_CheckedChanged(object sender, EventArgs e)
        {
            if (true_cek.Checked == true && true_cek.Enabled == false)
            {
                enter.Enabled = true;
            }
            if (true_cek.Checked == false && nextform_button.Enabled == false)
            {
                enter.Enabled = false;
            }

        }

        private void enter_Click(object sender, EventArgs e)
        {
            SecondWindform form2 = new SecondWindform();
            if (true_cek.Checked == true && nextform_button.Enabled == false)
            {
                enter.Enabled = true;
            }
            string nama = Convert.ToString(nama_text.Text);
            if (nama_text.Text == "")
            {
                MessageBox.Show("Enter the correct Input");
            }
            if (artist.Text == "")
            {
                MessageBox.Show("Enter the correct Input");
            }
            string favrtist = Convert.ToString(artist.Text);
            form2.Show();
        }
        public void background(Color color)
        {
            this.BackColor = color;
        }

    }
}

