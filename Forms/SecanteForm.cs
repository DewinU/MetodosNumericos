using org.mariuszgromada.math.mxparser;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetodosNumericos.Forms
{
    public partial class SecanteForm : Form
    {
        //Variables para calculo
        string f;
        double a;
        double b;
        double error;
        //Variables para grafico
        ToolTip tt = null;
        Point tl = Point.Empty;

        public SecanteForm()
        {
            InitializeComponent();
        }

        //Metodos de los botones y de calculo
        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "(";
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + ")";
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

        private void bunifuButton1_Click(object sender, EventArgs e)
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

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "x";
        }

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "root(indice,radicando)";
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "cos";
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "sec";
        }

        private void bunifuButton36_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arctan";
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "csc";
        }

        private void bunifuButton30_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "pi";
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "sin";
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "cot";
        }

        private void bunifuButton37_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arccot";
        }

        private void bunifuButton35_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arccos";
        }

        private void bunifuButton40_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "log10";
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "tan";
        }

        private void bunifuButton34_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arcsin";
        }

        private void bunifuButton38_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arcsec";
        }

        private void bunifuButton39_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "arccsc";
        }

        private void bunifuButton41_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "log2";
        }

        private void bunifuButton31_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "e";
        }

        private void bunifuButton42_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + "ln";
        }

        private void bunifuButton33_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + ".";
        }

        private void bunifuButton44_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = getLastString() + " ";
        }

        private void bunifuButton45_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("No ha ingresado los valores iniciales.", "Error de Valores Iniciales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                MessageBox.Show("Funcion no valida.", "Error de funcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
                txtResult.Text = e1.getExpressionString() + " = " + e1.calculate().ToString() + "     " + e2.getExpressionString() + " = " + e2.calculate().ToString() + " " + "";
        }

        //Metodos de validacion de textbox
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

        //Otros Metodos
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "" || txtError.Text == "" || txtA.Text == "" || txtB.Text == "")
            {
                MessageBox.Show("Alguno de los Campos Requeridos se encuentra Vacio.","Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SecanteCalculo bs = new SecanteCalculo();
            bs.getDatos(f, a, b, error);
            bs.ShowDialog();
        }

        private string getLastString()
        {
            string r = txtFuncion.Text;

            return r;
        }

        //Metodos Para graficar
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            pnlBunifuClose.Visible = false;
            bunifuTransitionOpen.Show(pnlBunifu);
            txtFuncion.Width = 479;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlBunifu.Visible = false;
            bunifuTransitionOpen.Show(pnlBunifuClose);
            txtFuncion.Width = 812;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.chart.Series["g(x)"].Points.Clear();
            this.chart.Series["h(x)"].Points.Clear();

            float a = float.Parse(txtIA.Text);
            float b = float.Parse(txtIB.Text);

            // X^3 - X^2 + 1

            // X^3
            //-----------------------------------------------

            for (float i = a; i <= b; i = ((float)(i + 0.5)))
            {
                this.chart.Series["g(x)"].Points.AddXY(i, Math.Pow(i, 3));
            }

            //------------------------------------------------
            // X^2 - 1
            for (float i = a; i <= b; i = ((float)(i + 0.5)))
            {
                this.chart.Series["h(x)"].Points.AddXY(i, (Math.Pow(i, 2) - 1));
            }
        }

        private void chart_DoubleClick(object sender, EventArgs e)
        {

            (new GraficoForm(float.Parse(txtIA.Text), float.Parse(txtIB.Text))).Show();
        }

        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            if (tt == null) tt = new ToolTip();

            ChartArea ca = chart.ChartAreas[0];

            if (InnerPlotPositionClientRectangle(chart, ca).Contains(e.Location))
            {
                Axis ax = ca.AxisX;
                Axis ay = ca.AxisY;
                double x = ax.PixelPositionToValue(e.X);
                double y = ay.PixelPositionToValue(e.Y);
                if (e.Location != tl)
                    tt.SetToolTip(chart, string.Format("X={0:0.00} ; Y={1:0.00}", x, y));
                tl = e.Location;
            }
            else tt.Hide(chart);
        }

        RectangleF ChartAreaClientRectangle(Chart chart, ChartArea CA)
        {
            RectangleF CAR = CA.Position.ToRectangleF();
            float pw = chart.ClientSize.Width / 100f;
            float ph = chart.ClientSize.Height / 100f;
            return new RectangleF(pw * CAR.X, ph * CAR.Y, pw * CAR.Width, ph * CAR.Height);
        }

        RectangleF InnerPlotPositionClientRectangle(Chart chart, ChartArea CA)
        {
            RectangleF IPP = CA.InnerPlotPosition.ToRectangleF();
            RectangleF CArp = ChartAreaClientRectangle(chart, CA);

            float pw = CArp.Width / 100f;
            float ph = CArp.Height / 100f;

            return new RectangleF(CArp.X + pw * IPP.X, CArp.Y + ph * IPP.Y,
                                    pw * IPP.Width, ph * IPP.Height);
        }


    }
}
