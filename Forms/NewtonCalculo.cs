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
        double error;
        public NewtonCalculo()
        {
            InitializeComponent();
        }

        private void BiseccionCalculo_Load(object sender, EventArgs e)
        {
           
            Function Fx = new Function($@"Fx(x) = {f}");
            //for (int i = 0; i < 100; i++)
            //{
            //    dataGridView.Rows.Add();
            //    if (i == 0)
            //    {
            //        Expression e1 = new Expression($"Fx({a})", Fx);
            //        dataGridView.Rows[i].Cells["clmIteracion"].Value = i;
            //        dataGridView.Rows[i].Cells["clmA"].Value = a;
            //        dataGridView.Rows[i].Cells["clmB"].Value = b;
            //        dataGridView.Rows[i].Cells["clmPm"].Value = (a + b) / 2;
            //        double ea = double.Parse(dataGridView.Rows[i].Cells["clmPm"].Value.ToString());
            //        Expression e2 = new Expression($"Fx({ea})", Fx);
            //        dataGridView.Rows[i].Cells["clmFa"].Value = e1.calculate();
            //        dataGridView.Rows[i].Cells["clmFpm"].Value = e2.calculate();
            //        dataGridView.Rows[i].Cells["clmFaxFpm"].Value = e1.calculate() * e2.calculate();
            //        dataGridView.Rows[i].Cells["clmError"].Value = 0;
            //        dataGridView.Rows[i].Cells["clmCriterio"].Value = error;



            //    }
            //    else
            //    {

            //        dataGridView.Rows[i].Cells["clmIteracion"].Value = i;
            //        if ((double.Parse(dataGridView.Rows[i - 1].Cells["clmFaxFpm"].Value.ToString())) < 0)
            //        {
            //            dataGridView.Rows[i].Cells["clmA"].Value = dataGridView.Rows[i - 1].Cells["clmA"].Value;
            //        }
            //        else
            //        {
            //            dataGridView.Rows[i].Cells["clmA"].Value = dataGridView.Rows[i - 1].Cells["clmPm"].Value;
            //        }

            //        if ((double.Parse(dataGridView.Rows[i - 1].Cells["clmFaxFpm"].Value.ToString())) < 0)
            //        {
            //            dataGridView.Rows[i].Cells["clmB"].Value = dataGridView.Rows[i - 1].Cells["clmPm"].Value;
            //        }
            //        else
            //        {
            //            dataGridView.Rows[i].Cells["clmB"].Value = dataGridView.Rows[i - 1].Cells["clmB"].Value;
            //        }

            //        dataGridView.Rows[i].Cells["clmPm"].Value = (double.Parse(dataGridView.Rows[i].Cells["clmA"].Value.ToString()) + double.Parse(dataGridView.Rows[i].Cells["clmB"].Value.ToString())) / 2;
            //        Expression e3 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmA"].Value.ToString())})", Fx);
            //        dataGridView.Rows[i].Cells["clmFa"].Value = e3.calculate();
            //        Expression e4 = new Expression($"Fx({double.Parse(dataGridView.Rows[i].Cells["clmPm"].Value.ToString())})", Fx);
            //        dataGridView.Rows[i].Cells["clmFpm"].Value = e4.calculate();
            //        dataGridView.Rows[i].Cells["clmFaxFpm"].Value = e3.calculate() * e4.calculate();
            //        dataGridView.Rows[i].Cells["clmError"].Value = Math.Abs(double.Parse(dataGridView.Rows[i].Cells["clmFpm"].Value.ToString()) - double.Parse(dataGridView.Rows[i - 1].Cells["clmFpm"].Value.ToString()));

            //        if ((double.Parse(dataGridView.Rows[i].Cells["clmError"].Value.ToString()) < error))
            //        {

            //            dataGridView.Rows[i].Cells["clmCriterio"].Value = "Verdadero";
            //            return;
            //        }
            //        else
            //        {
            //            dataGridView.Rows[i].Cells["clmCriterio"].Value = "Falso";

            //        }


            //    }
            //}

        }

        public void getDatos(string funcion, double a, double b, double error)
        {

            f = funcion;
            this.a = a;
            this.error = error;

        }
    }
}
