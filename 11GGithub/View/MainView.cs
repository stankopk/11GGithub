using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11GGithub.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double a = Int32.Parse(txtA.Text);
            double b = Int32.Parse(txtB.Text);
            double output = a / b;
            lblOutput.Text = output.ToString();
        }

        //UMNOJENIE NA A VURHU B
        private void btn2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double result = Convert.ToDouble(Math.Pow(a,b));
            lblOutput.Text = result.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtA.Text);
            double b = Double.Parse(txtB.Text);
            double c = a + b;
            lblOutput.Text = c.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            lblOutput.Text = Convert.ToString(a * b);
        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtA.Text);
            int lblOutput = (a + b);
            
        }
        //function for minus
        private void btn12_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtA.Text);
            int b = Int32.Parse(txtB.Text);
            int output = a - b;
            lblOutput.Text = output.ToString();
        }

        private void btnPK_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtA.Text + txtB.Text;
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
