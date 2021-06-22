using MetodosNumericos.Class;
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
    public partial class MetodoJacobi : Form
    {
        public MetodoJacobi()
        {
            InitializeComponent();
        }

        private void btnJacobi_Click(object sender, EventArgs e)
        {
            txtEcuaciones.Clear();

            Jacobi mt = new Jacobi(dgvEcuaciones.RowCount, dgvEcuaciones.ColumnCount);

            double[,] matIn = llenarArray();

            for (int i = 0; i < dgvEcuaciones.RowCount; i++)
            {
                for (int j = 0; j < dgvEcuaciones.ColumnCount; j++)
                {
                    mt.SetValue(i, j, matIn[i, j]);
                }
            }

            mt.Cambio += new EventHandler<MatrizEventArgs>(mt_Cambio);
            mt.Completo += new EventHandler<MatrizEventArgs>(mt_Completo);

            mt.ApplyJacobyMethod();
        }

        private void txtEcuaciones_TextChange(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEcuaciones.Text, out int x))
            {
                txtEcuaciones.Text = "";
                return;
            }
            if (int.Parse(txtEcuaciones.Text) > 9)
            {
                txtEcuaciones.Text = "";
                return;
            }

            dgvEcuaciones.Columns.Clear();

            for (int i = 0; i <= int.Parse(txtEcuaciones.Text); i++)
            {
                if (i < int.Parse(txtEcuaciones.Text))
                {
                    dgvEcuaciones.Columns.Add("c" + (i + 1).ToString(), "X_" + (i + 1).ToString());
                }
                else
                {
                    dgvEcuaciones.Columns.Add("TI", "");
                }
            }

            dgvEcuaciones.Rows.Clear();

            for (int j = 0; j < int.Parse(txtEcuaciones.Text); j++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dgvEcuaciones.Rows.Add(dr);
            }
        }

        private double[,] llenarArray()
        {
            double[,] array = new double[dgvEcuaciones.RowCount, dgvEcuaciones.ColumnCount];
            for (int i = 0; i < dgvEcuaciones.ColumnCount; i++)
            {
                for (int j = 0; j < dgvEcuaciones.RowCount; j++)
                {
                    array[j, i] = double.Parse(dgvEcuaciones.Rows[j].Cells[i].Value.ToString());
                }
            }

            return array;
        }

        void mt_Completo(object sender, MatrizEventArgs e)
        {
            txtResult.Text = e.Text;
        }

        void mt_Cambio(object sender, MatrizEventArgs e)
        {
            txtProcess.Text += e.Text;
        }

        private void txtProcess_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEcuaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void dgvEcuaciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvEcuaciones_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }

        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //when i press enter,bellow code never run?
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
