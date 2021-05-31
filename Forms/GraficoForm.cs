using org.mariuszgromada.math.mxparser;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetodosNumericos.Forms
{
    public partial class GraficoForm : Form
    {
        public GraficoForm(float a, float b, string h, string g)
        {
            InitializeComponent();



            lblhx.Text = "h(x): " + h;
            lblgx.Text = "g(x): " + g;

            Function hx = new Function($@"Fx(x) = {h}");
            Function gx = new Function($@"Fx(x) = {g}");

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

        private void lblgx_Click(object sender, EventArgs e)
        {

        }

        private void lblhx_Click(object sender, EventArgs e)
        {

        }
    }
}
