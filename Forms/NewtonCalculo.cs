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
    public partial class NewtonCalculo : Form
    {
        string f;
        double a;
        double b;
        double error;
        Argument x;
        public NewtonCalculo()
        {
            InitializeComponent();
        }

        private void BiseccionCalculo_Load(object sender, EventArgs e)
        {
           
            Function Fx = new Function($@"Fx(x) = {f}");
            for (int i = 0; i < 100; i++)
            {
                dataGridView.Rows.Add();
                if (i == 0)
                {
                    Expression e1 = new Expression($"Fx({a})", Fx);
                    dataGridView.Rows[i].Cells["clmIteracion"].Value = i;
                    dataGridView.Rows[i].Cells["clmXn"].Value = a;
                    Expression e2 = new Expression($"der({f}, x)", x);
                    dataGridView.Rows[i].Cells["clmfx"].Value = e1.calculate();
                    dataGridView.Rows[i].Cells["clmfxderivate"].Value = e2.calculate();
                    dataGridView.Rows[i].Cells["clmError"].Value = 0;
                    dataGridView.Rows[i].Cells["clmCriterio"].Value = error;



                }
                else
                {

                    dataGridView.Rows[i].Cells["clmIteracion"].Value = i;
                    dataGridView.Rows[i].Cells["clmXn"].Value = (double.Parse(dataGridView.Rows[i - 1].Cells["clmXn"].Value.ToString()))-((double.Parse(dataGridView.Rows[i - 1].Cells["clmfx"].Value.ToString()))/ (double.Parse(dataGridView.Rows[i - 1].Cells["clmfxderivate"].Value.ToString())));
                    Expression e3 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmXn"].Value.ToString())})", Fx);
                    dataGridView.Rows[i].Cells["clmfx"].Value = e3.calculate();
                    //Expression e4 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmFx"].Value.ToString())})", Fx);
                    x = new Argument($"x = {dataGridView.Rows[i].Cells["clmXn"].Value}");
                    Expression e4 = new Expression($"der({f}, x)", x);

                    dataGridView.Rows[i].Cells["clmfxderivate"].Value = e4.calculate();
                    dataGridView.Rows[i].Cells["clmError"].Value = Math.Abs(double.Parse(dataGridView.Rows[i].Cells["clmXn"].Value.ToString()) - double.Parse(dataGridView.Rows[i - 1].Cells["clmXn"].Value.ToString()));

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

        public void getDatos(string funcion, double a, double error)
        {
            f = funcion;
            this.a = a;
            this.error = error;
            x = new Argument($"x = {a}");
        }
    }
}
