using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWin_tp1
{
    public partial class frmScientific : Form
    {
        private double memoire = 0;
        private char Operateur;
        Int16 clickToAdd = 0;
        Double factoriel;
        public frmScientific()
        {
            InitializeComponent();
        }

        private void frmScientific_Load(object sender, EventArgs e)
        {

        }
        private void Operator_Pressed(object sender, EventArgs e)
        {

            // Quand on clique sur un operateur , il le stoque dans Operateur;
            char operation = (sender as Button).Text[0];
            if (operation == 'C')
            {
                memoire = 0;
            }
            else
            {
                double ValeurActuelle = double.Parse(lblResultats.Text);
                switch (Operateur)
                {
                    case '+':
                        memoire += ValeurActuelle;
                        break;
                    case '-':
                        memoire -= ValeurActuelle;
                        break;
                    case '*':
                        memoire *= ValeurActuelle;
                        break;
                    case 'y':
                        memoire = Math.Pow(memoire, ValeurActuelle);
                        break;
                    case '%':
                        memoire %= ValeurActuelle;
                        break;
                    case '/':
                        memoire /= ValeurActuelle;
                        break;
                    case 'a':
                        lblResultats.Text = Math.Abs(Convert.ToInt32(ValeurActuelle)).ToString();
                        break;
                    default:
                        memoire = ValeurActuelle;
                        break;

                }
            }

            Operateur = operation;
            lblResultats.Text = operation == '=' ? memoire.ToString() : "0";
        }

        private void Number_Pressed(object sender, EventArgs e)
        {
            // Ajouter les valeurs a LabelResultats
            string number = (sender as Button).Text;
            lblResultats.Text = lblResultats.Text == "0" ? number : lblResultats.Text + number;
        }

        private void btnMmoins_Click(object sender, EventArgs e)
        { 
            //enlever la valeur a la memoire
            lblResultats.Text = (memoire - Convert.ToDouble(lblResultats.Text)).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnRacine_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text != "")
            {
                Double sqrt = Math.Sqrt(Convert.ToDouble(lblResultats.Text));
                lblResultats.Text = Convert.ToString(sqrt);
            }
            else
            {
                lblResultats.Text = "Enter the number firstly";
            }
        }

        private void btnExp2_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0)
            {
                Double rslt = Math.Pow(Convert.ToDouble(lblResultats.Text), 2);
                lblResultats.Text = Convert.ToString(rslt);
            }
            else if (lblResultats.Text == Convert.ToString(0))
            {
                lblResultats.Text = "Enter the number firstly";
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0 && lblResultats.Text != Convert.ToString(0))
            {
                Double rslt = Math.Log(Convert.ToDouble(lblResultats.Text));
                lblResultats.Text = Convert.ToString(rslt);
            }
            else if (lblResultats.Text == Convert.ToString(0))
            {
                lblResultats.Text = "Enter the number firstly";
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            lblResultats.Text = "0";
            memoire = 0;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text != "")
            {
                if (memoire != 0)
                {
                    lblResultats.Text = "0";
                }
                else if (lblResultats.Text == "Enter the number firstly")
                {
                    lblResultats.Text = "0";
                }

                else
                {
                    lblResultats.Text = lblResultats.Text.Remove(lblResultats.Text.Length - 1);
                }
            }
            else
            {
                lblResultats.Text = "0";
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0 && lblResultats.Text != Convert.ToString(0))
            {
                Double rslt = Math.Log(Convert.ToDouble(lblResultats.Text));
                lblResultats.Text = Convert.ToString(rslt);
            }

            else
            {
                lblResultats.Text = "Enter the number firstly";
            }
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0)
            {
                Double rslt = Math.Pow(10, Convert.ToDouble(lblResultats.Text));
                lblResultats.Text = Convert.ToString(rslt);
            }
            else
            {
                lblResultats.Text = "Enter the number firstly";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
             /* afin que le bouton fonctionne, j'ai utiliser la logique de 
              pair et impair en ajoutant 1 a chaque fois qu'on clique sur le bouton.
             */
            clickToAdd += 1;
            if (clickToAdd % 2 == 0)
            {
                btn10x.Visible = btnExp2.Visible = btnRacine.Visible = btnLog.Visible = btnXY.Visible = btnLn.Visible = true;
                btn2fuctX3.Visible=btnRacineCubique.Visible=btnRacineY.Visible =btn2x.Visible= false;
            }
            else
            {

                btn10x.Visible = btnExp2.Visible = btnRacine.Visible = btnLog.Visible = btnXY.Visible = btnLn.Visible = false;
                btn2fuctX3.Visible = btnRacineCubique.Visible=btnRacineY.Visible = btn2x.Visible = true;
            }

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0)
            {
                Double pi = (Convert.ToDouble(lblResultats.Text) * 3.14);
                lblResultats.Text = Convert.ToString(pi);
            }
            else
            {
                lblResultats.Text = "Enter the number firstly";
            }

        }

        private void btn2fuctX3_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0)
            {
                Double rslt = Math.Pow(Convert.ToDouble(lblResultats.Text), 3);
                lblResultats.Text = Convert.ToString(rslt);
            }
            else if (lblResultats.Text == Convert.ToString(0))
            {
                lblResultats.Text = "Enter the number firstly";
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {

        }

        private void btnValAbsolu_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0)
            {
                lblResultats.Text = Math.Abs(Convert.ToInt32(lblResultats.Text)).ToString();
            }
            else if (lblResultats.Text == Convert.ToString(0))
            {
                Operateur = 'a';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            for (double i = factoriel - 1; i >= 1; i--)
            {
                factoriel = factoriel * i;
            }
             Double resultat = factoriel;
            lblResultats.Text = resultat.ToString();
        }

        private void btn2x_Click(object sender, EventArgs e)
        {
            if (lblResultats.Text.Length != 0)
            {
                Double rslt = Math.Pow(2, Convert.ToDouble(lblResultats.Text));
                lblResultats.Text = Convert.ToString(rslt);
            }
            else if (lblResultats.Text == Convert.ToString(0))
            {
                lblResultats.Text = "Enter the number firstly";
            }
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            //ajout de la valeur a la memoire
            lblResultats.Text = (memoire + Convert.ToDouble(lblResultats.Text)).ToString();
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            // effacer la memoire en initialisant le bouton a 0
            memoire = 0;
        }
    }
}
