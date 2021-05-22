using System;
using org.mariuszgromada.math.mxparser;
using System.Windows.Forms;

namespace MetodosNumericos.Forms
{
    public partial class Newton : Form
    {
        string f;
        double a;
        double b;
        double error;
        public Newton()
        {
            InitializeComponent();
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "x";
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "(";
        }

        private string getLastString()
        {
            string r = txtFuncion.Text;

            return r;
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + ")";
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (getLastString().Length - 1 < 0)
            {
                return;
            }
            else
            {
                txtFuncion.Text = getLastString().Remove(getLastString().Length - 1);
            }


        }

        private void bunifuButton44_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + " ";
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "[";
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "]";
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "/";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "7";
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "8";
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "9";
        }

        private void bunifuButton17_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "*";
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "^";
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "4";
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "5";
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "6";
        }

        private void bunifuButton18_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "+";
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "1";
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "2";
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "3";
        }

        private void bunifuButton19_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "-";
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = "";
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "0";
        }

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "root(indice,radicando)";
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "cos";
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "sin";
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "tan";
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "sec";
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "cot";
        }

        private void bunifuButton34_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arcsin";
        }

        private void bunifuButton36_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arctan";
        }

        private void bunifuButton37_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arccot";
        }

        private void bunifuButton38_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arcsec";
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "csc";
        }

        private void bunifuButton35_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arccos";
        }

        private void bunifuButton39_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arccsc";
        }

        private void bunifuButton30_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "pi";
        }

        private void bunifuButton40_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "log10";
        }

        private void bunifuButton41_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "log2";
        }

        private void bunifuButton33_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + ".";
        }

        private void bunifuButton42_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "ln";
        }

        private void bunifuButton31_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "e";
        }

        private void bunifuButton45_Click(object sender, EventArgs e)
        {
            f = txtFuncion.Text;
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
            error = double.Parse(txtError.Text);
            Function Fx = new Function($@"Fx(x) = {f}");
            Expression e1 = new Expression($"Fx({a})", Fx);
            Expression e2 = new Expression($"Fx({b})", Fx);
            double result = e1.calculate() * e2.calculate();

            if (e1.calculate().ToString().Equals("NaN"))
            {

                MessageBox.Show("Funcion no valida", "Error de funcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (result < 0)
            {

                txtResult.Text = e1.getExpressionString() + " = " + e1.calculate().ToString() + " " + e2.getExpressionString() + " = " + e2.calculate().ToString() + " " + "Verdadero";
            }
            else
            {
                txtResult.Text = e1.getExpressionString() + " = " + e1.calculate().ToString() + " " + e2.getExpressionString() + " = " + e2.calculate().ToString() + " " + "Falso";
            }

        }

        private void bunifuButton32_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {

        }

        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFuncion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.') && !(e.KeyChar == '*') && !(e.KeyChar == '+') && !(e.KeyChar == '-') && !(e.KeyChar == '/') && !(e.KeyChar == '^') && !(e.KeyChar == 'x') && !(e.KeyChar == '(')
               && !(e.KeyChar == ')') && !(e.KeyChar == '[') && !(e.KeyChar == ']'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.') && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.') && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            BiseccionCalculo bs = new BiseccionCalculo();
            bs.getDatos(f, a, b, error);
            bs.ShowDialog();
        }
    }
}
