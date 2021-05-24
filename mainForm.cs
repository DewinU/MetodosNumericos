using MetodosNumericos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public partial class mainForm : Form
    {

        private Form currentChildForm;
        public mainForm()
        {
            InitializeComponent();

        }


        private void hideSubMenu()
        {
            if (subRaices.Visible)
            {
                subRaices.Visible = false;
            }
            if (subMatrices.Visible)
            {
                subMatrices.Visible = false;
            }
        }


        private void showSubMenu(Panel subMenu)
        {

            if (!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(subRaices);
        }

        private void btnMatrices_Click(object sender, EventArgs e)
        {
            showSubMenu(subMatrices);
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new BiseccionForm());
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReglaFalsaForm());
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SecanteForm());
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newton());
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EliminacionGaussiana());
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MetodoJacobi());
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MetodoSeidel());
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
