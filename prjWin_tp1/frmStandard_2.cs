using System;
using System.Windows.Forms;

namespace prjWin_tp1
{
    public partial class frmStandard_2 : Form
    {
        private double accumulator = 0;
        private char lastOperation;

        public frmStandard_2()
        {
            InitializeComponent();
        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            
            // Quand on clique sur un operateur , il le stoque dans lastOperation;
            char operation = (sender as Button).Text[0];
            if (operation == 'C')
            {
                accumulator = 0;
            }
            else
            {
                double currentValue = double.Parse(lblResultats.Text);
                switch (lastOperation)
                {   
                    case '+': accumulator += currentValue;
                        break;
                    case '-': accumulator -= currentValue;
                        break;
                    case '*': accumulator *= currentValue;
                        break;
                    case '/': accumulator /= currentValue;
                        break;
                    default: accumulator = currentValue;
                        break;
                }
            }

            lastOperation = operation;
            lblResultats.Text = operation == '=' ? accumulator.ToString() : "0";
        }

        private void Number_Pressed(object sender, EventArgs e)
        {
            // Ajouter les valeurs a LabelResultats
            string number = (sender as Button).Text;
            lblResultats.Text = lblResultats.Text == "0" ? number : lblResultats.Text + number;
        }

        private void frmStandard_2_Load(object sender, EventArgs e)
        {

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text != "")
            {
                if (accumulator != 0)
                {
                    lblResultats.Text = "0";
                }
                else
                {
                    lblResultats.Text = lblResultats.Text.Remove(lblResultats.Text.Length - 1);
                }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            lblResultats.Text = "0";
            accumulator = 0;
        }

        private void btnEraseAll_Click(object sender, EventArgs e)
        {
            lblResultats.Text = "0";
        }

        private void btnExp2_Click(object sender, EventArgs e)
        {
            
            Double rslt = Math.Pow(Convert.ToDouble(lblResultats.Text), 2);
            lblResultats.Text = Convert.ToString(rslt);
            
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
         if (lblResultats.Text != "")
            {
                Double sqrt = Math.Sqrt(Convert.ToDouble(lblResultats.Text));
                lblResultats.Text = Convert.ToString(sqrt);
            }
         
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            accumulator = 0;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            accumulator += Convert.ToDouble(lblResultats.Text);
        }
    }
}
