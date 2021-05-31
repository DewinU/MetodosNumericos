using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetodosNumericos.Forms
{
    public partial class BiseccionForm : Form
    {
        byte fx = 0;
        string f, h, g;
        double a;
        double b;
        double error;

        public BiseccionForm()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.chart.Series["g(x)"].Points.Clear();
            this.chart.Series["h(x)"].Points.Clear();

            float a = float.Parse(txtag.Text);
            float b = float.Parse(txtbg.Text);


            h = txthx.Text;
            g = txtgx.Text;

            Function hx = new Function($@"Fx(x) = {h}");
            Function gx = new Function($@"Fx(x) = {g}");

            //if (hx.calculate().ToString().Equals("NaN") || gx.calculate().ToString().Equals("NaN"))
            //{

            //    MessageBox.Show("Funcion no valida", "Error de funcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}


            //-----------------------------------------------
            // h(x)

            for (float i = a; i <= b; i = ((float)(i + 0.5)))
            {
                Expression e1 = new Expression($"Fx({i})", gx);
                this.chart.Series["g(x)"].Points.AddXY(i, float.Parse(e1.calculate().ToString()));
            }

            //------------------------------------------------
            // g(x)
            for (float i = a; i <= b; i = ((float)(i + 0.5)))
            {
                Expression e2 = new Expression($"Fx({i})", hx);
                this.chart.Series["h(x)"].Points.AddXY(i, float.Parse(e2.calculate().ToString()));
            }
        }



        //-----------------------------------------------------------------------------------------------
        // Metodo del grafico para poder ver la posicion en el mouse
        // mediante un menu contextual

        ToolTip tt = null;
        Point tl = Point.Empty;
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

        //-----------------------------------------------------------------------------------------------
        // Metodo para expandir el grafico con un doble click
        private void chart_DoubleClick(object sender, EventArgs e)
        {

            (new GraficoForm(float.Parse(txtag.Text), float.Parse(txtbg.Text), h, g)).Show();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            label1.Location = new System.Drawing.Point(433, 97);
            txtB.Location = new System.Drawing.Point(437, 130);
            txtB.Size = new System.Drawing.Size(386, 37);
            txtA.Size = new System.Drawing.Size(386, 37);
            txtResult.Width = 805;
            pnlBunifu.Visible = false;
            bunifuTransitionOpen.Show(pnlBunifuCerrao);
            txtFuncion.Width = 805;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            label1.Location = new System.Drawing.Point(262, 97);
            txtB.Location = new System.Drawing.Point(256, 130);
            txtB.Size = new System.Drawing.Size(200, 37);
            txtA.Size = new System.Drawing.Size(200, 37);
            pnlBunifuCerrao.Visible = false;
            bunifuTransitionOpen.Show(pnlBunifu);
            txtFuncion.Width = 479;
            txtResult.Width = 479;
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "x";
                    break;
                case 2:
                    txthx.Text = getLastString() + "x";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "x";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "(";
                    break;
                case 2:
                    txthx.Text = getLastString() + "(";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "(";
                    break;
                default:
                    break;
            }
        }

        // Hacer un swich:  1 = txtFuncion
        //                  2 = txthx
        //                  3 = txtgx
        // con el objetivo de buscar el focus de cada txt

        private string getLastString()
        {
            string r;
            switch (fx)
            {
                case 1:
                    r = txtFuncion.Text;
                    return r;
                case 2:
                    r = txthx.Text;
                    return r;
                case 3:
                    r = txtgx.Text;
                    return r;
            }

            return "";
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + ")";
                    break;
                case 2:
                    txthx.Text = getLastString() + ")";
                    break;
                case 3:
                    txtgx.Text = getLastString() + ")";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (getLastString().Length - 1 < 0)
            {
                return;
            }
            else
            {
                switch (fx)
                {
                    case 1:
                        txtFuncion.Text = getLastString().Remove(getLastString().Length - 1);
                        break;
                    case 2:
                        txthx.Text = getLastString().Remove(getLastString().Length - 1);
                        break;
                    case 3:
                        txtgx.Text = getLastString().Remove(getLastString().Length - 1);
                        break;
                    default:
                        break;
                }
            }

         


        }

        private void bunifuButton44_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + " ";
                    break;
                case 2:
                    txthx.Text = getLastString() + " ";
                    break;
                case 3:
                    txtgx.Text = getLastString() + " ";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "[";
                    break;
                case 2:
                    txthx.Text = getLastString() + "[";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "[";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "]";
                    break;
                case 2:
                    txthx.Text = getLastString() + "]";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "]";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "/";
                    break;
                case 2:
                    txthx.Text = getLastString() + "/";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "/";
                    break;
                default:
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "7";
                    break;
                case 2:
                    txthx.Text = getLastString() + "7";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "7";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "8";
                    break;
                case 2:
                    txthx.Text = getLastString() + "8";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "8";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "9";
                    break;
                case 2:
                    txthx.Text = getLastString() + "9";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "9";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton17_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "*";
                    break;
                case 2:
                    txthx.Text = getLastString() + "*";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "*";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "^";
                    break;
                case 2:
                    txthx.Text = getLastString() + "^";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "^";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "4";
                    break;
                case 2:
                    txthx.Text = getLastString() + "4";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "4";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "5";
                    break;
                case 2:
                    txthx.Text = getLastString() + "5";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "5";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "6";
                    break;
                case 2:
                    txthx.Text = getLastString() + "6";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "6";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton18_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "+";
                    break;
                case 2:
                    txthx.Text = getLastString() + "+";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "+";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "1";
                    break;
                case 2:
                    txthx.Text = getLastString() + "1";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "1";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "2";
                    break;
                case 2:
                    txthx.Text = getLastString() + "2";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "2";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "3";
                    break;
                case 2:
                    txthx.Text = getLastString() + "3";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "3";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton19_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "-";
                    break;
                case 2:
                    txthx.Text = getLastString() + "-";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "-";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = "";
                    break;
                case 2:
                    txthx.Text = "";
                    break;
                case 3:
                    txtgx.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "0";
                    break;
                case 2:
                    txthx.Text = getLastString() + "0";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "0";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "root(indice,radicando)";
                    break;
                case 2:
                    txthx.Text = getLastString() + "root(indice,radicando)";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "root(indice,radicando)";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "cos";
                    break;
                case 2:
                    txthx.Text = getLastString() + "cos";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "cos";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "sin";
                    break;
                case 2:
                    txthx.Text = getLastString() + "sin";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "sin";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "tan";
                    break;
                case 2:
                    txthx.Text = getLastString() + "tan";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "tan";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "sec";
                    break;
                case 2:
                    txthx.Text = getLastString() + "sec";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "sec";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "cot";
                    break;
                case 2:
                    txthx.Text = getLastString() + "cot";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "cot";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton34_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "arcsin";
                    break;
                case 2:
                    txthx.Text = getLastString() + "arcsin";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "arcsin";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton36_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "arctan";
                    break;
                case 2:
                    txthx.Text = getLastString() + "arctan";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "arctan";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton37_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "arccot";
                    break;
                case 2:
                    txthx.Text = getLastString() + "arccot";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "arccot";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton38_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "arcsec";
                    break;
                case 2:
                    txthx.Text = getLastString() + "arcsec";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "aecsec";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "csc";
                    break;
                case 2:
                    txthx.Text = getLastString() + "csc";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "csc";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton35_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "arccos";
                    break;
                case 2:
                    txthx.Text = getLastString() + "arccos";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "arccos";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton39_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "arccsc";
                    break;
                case 2:
                    txthx.Text = getLastString() + "arccsc";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "arccsc";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton30_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "pi";
                    break;
                case 2:
                    txthx.Text = getLastString() + "pi";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "pi";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton40_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "log10";
                    break;
                case 2:
                    txthx.Text = getLastString() + "log10";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "log10";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton41_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "log2";
                    break;
                case 2:
                    txthx.Text = getLastString() + "log2";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "log2";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton33_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + ".";
                    break;
                case 2:
                    txthx.Text = getLastString() + ".";
                    break;
                case 3:
                    txtgx.Text = getLastString() + ".";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton42_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "ln";
                    break;
                case 2:
                    txthx.Text = getLastString() + "ln";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "ln";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton31_Click(object sender, EventArgs e)
        {
            switch (fx)
            {
                case 1:
                    txtFuncion.Text = getLastString() + "e";
                    break;
                case 2:
                    txthx.Text = getLastString() + "e";
                    break;
                case 3:
                    txtgx.Text = getLastString() + "e";
                    break;
                default:
                    break;
            }
        }

        private void bunifuButton45_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFuncion.Text) || String.IsNullOrEmpty(txtA.Text) || String.IsNullOrEmpty(txtB.Text) || String.IsNullOrEmpty(txtError.Text))
            {

                MessageBox.Show("No puede haber parametros vacios", "Error de funcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            switch (fx)
            {
                case 1:
                    f = txtFuncion.Text;
                    break;
                case 2:
                    f = txthx.Text;
                    break;
                case 3:
                    f = txtgx.Text;
                    break;
                default:
                    break;
            }
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
                BiseccionCalculo bs = new BiseccionCalculo();
                bs.getDatos(f, a, b, error);
                bs.ShowDialog();
            }
            else
            {
                txtResult.Text = e1.getExpressionString() + " = " + e1.calculate().ToString() + " " + e2.getExpressionString() + " = " + e2.calculate().ToString() + " " + "Falso";
            }
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

        private void btngx_Click(object sender, EventArgs e)
        {
            fx = 3;
        }
        private void btnhx_Click(object sender, EventArgs e)
        {
            fx = 2;
        }

        private void txtgx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFuncion_Click(object sender, EventArgs e)
        {
            fx = 1;
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
