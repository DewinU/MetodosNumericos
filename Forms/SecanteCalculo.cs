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
    public partial class SecanteCalculo : Form
    {
        string f;
        double a;
        double b;
        double error;

        public SecanteCalculo()
        {
            InitializeComponent();
        }

        private void SecanteCalculo_Load(object sender, EventArgs e)
        {
            Console.WriteLine(f);
            Console.WriteLine(error);
            Function Fx = new Function($@"Fx(x) = {f}");
            for (int i = 0; i < 100; i++)
            {
                dataGridView.Rows.Add();
                if (i == 0)
                {
                    Expression e1 = new Expression($"Fx({a})", Fx);
                    dataGridView.Rows[i].Cells["clmIteracion"].Value = i + 1;
                    dataGridView.Rows[i].Cells["clmA"].Value = a;
                    dataGridView.Rows[i].Cells["clmFuncion"].Value = e1.calculate();
                    dataGridView.Rows[i].Cells["clmError"].Value = 0;
                    dataGridView.Rows[i].Cells["clmCriterio"].Value = error;

                }
                else if(i == 1)
                {
                    Expression e2 = new Expression($"Fx({b})", Fx);
                    dataGridView.Rows[i].Cells["clmIteracion"].Value = i + 1;
                    dataGridView.Rows[i].Cells["clmA"].Value = b;
                    dataGridView.Rows[i].Cells["clmFuncion"].Value = e2.calculate();
                    dataGridView.Rows[i].Cells["clmError"].Value = 0;
                    dataGridView.Rows[i].Cells["clmCriterio"].Value = error;
                }
                else
                {
                    dataGridView.Rows[i].Cells["clmIteracion"].Value = i + 1;

                    double x = double.Parse(dataGridView.Rows[i - 1].Cells["clmA"].Value.ToString());
                    double x1 = double.Parse(dataGridView.Rows[i - 2].Cells["clmA"].Value.ToString());

                    Expression e3 = new Expression($"Fx({x})", Fx);
                    Expression e4 = new Expression($"Fx({x1})", Fx);

                    dataGridView.Rows[i].Cells["clmA"].Value = (double.Parse(dataGridView.Rows[i-1].Cells["clmA"].Value.ToString()) - (e3.calculate() * (double.Parse(dataGridView.Rows[i - 1].Cells["clmA"].Value.ToString()) - double.Parse(dataGridView.Rows[i - 2].Cells["clmA"].Value.ToString())))/(e3.calculate() - e4.calculate()));
                    Expression e5 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmA"].Value.ToString())})", Fx);
                    dataGridView.Rows[i].Cells["clmFuncion"].Value = e5.calculate();
                    dataGridView.Rows[i].Cells["clmError"].Value = Math.Abs(double.Parse(dataGridView.Rows[i].Cells["clmA"].Value.ToString()) - double.Parse(dataGridView.Rows[i - 1].Cells["clmA"].Value.ToString()));

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
