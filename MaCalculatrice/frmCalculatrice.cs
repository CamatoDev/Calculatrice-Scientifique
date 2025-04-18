using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaCalculatrice
{
    public partial class frmCalculatrice : Form
    {
        public frmCalculatrice()
        {
            InitializeComponent();
        }

        Double memo;
        char op;
        int a;

        public void Ecrire(string valeur)
        {
            if(txtR.Text == "0" || txtR.Text == "Math Error (X/0 impossible)")
            {
                txtR.Text = valeur;
            }
            else
            {
                txtR.Text += valeur;
            }
        }

        public void Operation(char p)
        {
            memo = double.Parse(txtR.Text);
            op = p;
            txtR.Text = "0";
        }

        private void frmCalculatrice_Load(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width + 5;
            txtR.Width = this.Width - 20;
        }

        private void stantardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width + 5;
            txtR.Width = this.Width - 20;
        }

        private void scientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width + pnlScientifique.Width;
            txtR.Width = this.Width - 20;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Ecrire("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Ecrire("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Ecrire("1");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Ecrire("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Ecrire("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Ecrire("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Ecrire("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Ecrire("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Ecrire("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Ecrire("0");
        }

        private void btnPlusMoins_Click(object sender, EventArgs e)
        {
            memo = (double.Parse(txtR.Text)) * (-1);
            txtR.Text = memo.ToString();
        }

        private void btn1surX_Click(object sender, EventArgs e)
        {
            memo = 1/(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(txtR.Text)),2);
            txtR.Text = memo.ToString();
        }

        private void btnRacine_Click(object sender, EventArgs e)
        {
            memo = Math.Sqrt((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation('+');
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            if(op == '+')
            {
                memo += double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }

            if (op == '-')
            {
                memo -= double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }

            if (op == '*')
            {
                memo = memo * double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }

            if (op == '/')
            {
                if(txtR.Text == "0")
                {
                    txtR.Text = "Math Error (X/0 impossible)";
                }
                else
                {
                    memo = memo / double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
                }
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            Operation('-');
        }

        private void btnFois_Click(object sender, EventArgs e)
        {
            Operation('*');
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operation('/');
        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            if (txtR.Text.Contains(",") == false)
            {
                txtR.Text += ",";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtR.Text = "0";
            lblShowOp.Text = ""; 
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtR.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (txtR.Text.Length > 0)
            {
                txtR.Text = txtR.Text.Remove(txtR.Text.Length - 1, 1);
            }

            if (txtR.Text == "")
            {
                txtR.Text = "0";
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            memo = Math.Exp(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            memo = Math.Log(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            memo = Math.Log10(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            memo = Math.Sin(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            memo = Math.Cos(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            memo = Math.Tan(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            Ecrire(Math.PI.ToString());
        }

        private void btnPourcentage_Click(object sender, EventArgs e)
        {
            memo = double.Parse(txtR.Text) / Convert.ToDouble(100);
            txtR.Text = memo.ToString();
        }

        private void btnSin1_Click(object sender, EventArgs e)
        {
            memo = 1.0 / Math.Sin(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnCos1_Click(object sender, EventArgs e)
        {
            memo = 1.0 / Math.Cos(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnTan1_Click(object sender, EventArgs e)
        {
            memo = 1.0 / Math.Tan(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(txtR.Text)), 3);
            txtR.Text = memo.ToString();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtR.Text);
            txtR.Text = System.Convert.ToString(a, 2);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtR.Text);
            txtR.Text = System.Convert.ToString(a, 8);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtR.Text);
            txtR.Text = System.Convert.ToString(a, 16);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtR.Text);
            txtR.Text = System.Convert.ToString(a);
        }
    }
}
