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

namespace MetodosNumericos.Forms
{
    public partial class ReglaFalsaCalculoForm : Form
    {
        string f;
        double a;
        double b;
        double error;
        public ReglaFalsaCalculoForm()
        {
            InitializeComponent();
        }
        private void ReglaFalsaCalculoForm_Load(object sender, EventArgs e)
        {

            Function Fx = new Function($@"Fx(x) = {f}");
            for (int i = 0; i < 100; i++)
            {
                dataGridView.Rows.Add();
                if (i == 0)
                {
                    Expression e1 = new Expression($"Fx({a})", Fx);
                    dataGridView.Rows[i].Cells["clmIteracion"].Value = i;
                    dataGridView.Rows[i].Cells["clmxi"].Value = a;
                    dataGridView.Rows[i].Cells["clmxs"].Value = b;

                    Expression e2 = new Expression($"Fx({b})", Fx);
                    dataGridView.Rows[i].Cells["clmFxi"].Value = e1.calculate();
                    dataGridView.Rows[i].Cells["clmFxs"].Value = e2.calculate();
                    
                    

                    dataGridView.Rows[i].Cells["clmxr"].Value = b - ( ( (e2.calculate())*(a-b) )/(e1.calculate() - e2.calculate()) );

                    dataGridView.Rows[i].Cells["clmFxr"].Value = new Expression($"Fx({(dataGridView.Rows[i].Cells["clmxr"].Value.ToString())})", Fx).calculate();

                    dataGridView.Rows[i].Cells["clmFxiFxr"].Value = e1.calculate() * new Expression($"Fx({(dataGridView.Rows[i].Cells["clmxr"].Value.ToString())})", Fx).calculate();


                    dataGridView.Rows[i].Cells["clmError"].Value = 0;
                    dataGridView.Rows[i].Cells["clmCriterio"].Value = error;
                }
                else
                {

                    dataGridView.Rows[i].Cells["clmIteracion"].Value = i;
                    if ((double.Parse(dataGridView.Rows[i - 1].Cells["clmFxiFxr"].Value.ToString())) < 0)
                    {
                        dataGridView.Rows[i].Cells["clmxi"].Value = dataGridView.Rows[i - 1].Cells["clmxi"].Value;
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells["clmxi"].Value = dataGridView.Rows[i - 1].Cells["clmxr"].Value;
                    }

                    if ((double.Parse(dataGridView.Rows[i - 1].Cells["clmFxiFxr"].Value.ToString())) > 0)
                    {
                        dataGridView.Rows[i].Cells["clmxs"].Value = dataGridView.Rows[i - 1].Cells["clmxs"].Value;
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells["clmxs"].Value = dataGridView.Rows[i - 1].Cells["clmxr"].Value;
                    }

                    Expression e3 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmxi"].Value.ToString())})", Fx);
                    dataGridView.Rows[i].Cells["clmFxi"].Value = e3.calculate();
                    Expression e4 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmxs"].Value.ToString())})", Fx);
                    dataGridView.Rows[i].Cells["clmFxs"].Value = e4.calculate();

                    dataGridView.Rows[i].Cells["clmxr"].Value = double.Parse(dataGridView.Rows[i].Cells["clmxs"].Value.ToString()) - (((e4.calculate()) * (double.Parse(dataGridView.Rows[i].Cells["clmxi"].Value.ToString())
                                                                - double.Parse(dataGridView.Rows[i].Cells["clmxs"].Value.ToString()))) / (e3.calculate() - e4.calculate()));

                    Expression e5 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmxr"].Value.ToString())})", Fx);
                    dataGridView.Rows[i].Cells["clmFxr"].Value = e5.calculate();


                    dataGridView.Rows[i].Cells["clmFxiFxr"].Value = e3.calculate() * e5.calculate();
                    dataGridView.Rows[i].Cells["clmError"].Value = Math.Abs(double.Parse(dataGridView.Rows[i].Cells["clmxr"].Value.ToString()) - double.Parse(dataGridView.Rows[i - 1].Cells["clmxr"].Value.ToString()));
                    

                    if ((double.Parse(dataGridView.Rows[i].Cells["clmError"].Value.ToString()) < error))
                    {

                        dataGridView.Rows[i].Cells["clmCriterio"].Value = "Verdadero";
                        return;
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells["clmCriterio"].Value = "Falso";

                    }


                }
            }
        }
        public void getDatos(string funcion, double a, double b, double error)
        {

            f = funcion;
            this.a = a;
            this.b = b;
            this.error = error;

        }
    }
}
