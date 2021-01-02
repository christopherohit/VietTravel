using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietTravel
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill in blank space");
            }
            else 
            {
                System.Windows.Forms.Form ovn = System.Windows.Forms.Application.OpenForms["MainHDV"];
                MessageBox.Show("Send Request Completely");
                ovn.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form ovn = System.Windows.Forms.Application.OpenForms["Future"];
            ovn.Show();
            this.Hide();
        }
    }
}
//43