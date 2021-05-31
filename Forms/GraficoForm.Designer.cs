
namespace MetodosNumericos.Forms
{
    partial class GraficoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraficoForm));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuLabel14 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblhx = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblgx = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.TruncatedLabels = true;
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "g(x)";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "h(x)";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(976, 681);
            this.chart.TabIndex = 9;
            this.chart.Text = "chart";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chart.Titles.Add(title1);
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // bunifuLabel14
            // 
            this.bunifuLabel14.AllowParentOverrides = false;
            this.bunifuLabel14.AutoEllipsis = false;
            this.bunifuLabel14.CursorType = null;
            this.bunifuLabel14.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel14.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel14.Location = new System.Drawing.Point(132, 16);
            this.bunifuLabel14.Name = "bunifuLabel14";
            this.bunifuLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel14.Size = new System.Drawing.Size(23, 40);
            this.bunifuLabel14.TabIndex = 48;
            this.bunifuLabel14.Text = "O";
            this.bunifuLabel14.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel14.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.CursorType = null;
            this.bunifuLabel13.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel13.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel13.Location = new System.Drawing.Point(114, 16);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(19, 40);
            this.bunifuLabel13.TabIndex = 49;
            this.bunifuLabel13.Text = "C";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.AllowParentOverrides = false;
            this.bunifuLabel12.AutoEllipsis = false;
            this.bunifuLabel12.CursorType = null;
            this.bunifuLabel12.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel12.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel12.Location = new System.Drawing.Point(103, 16);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(12, 40);
            this.bunifuLabel12.TabIndex = 50;
            this.bunifuLabel12.Text = "I";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.CursorType = null;
            this.bunifuLabel11.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel11.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel11.Location = new System.Drawing.Point(87, 16);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(17, 40);
            this.bunifuLabel11.TabIndex = 51;
            this.bunifuLabel11.Text = "F";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel10.Location = new System.Drawing.Point(69, 16);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(20, 40);
            this.bunifuLabel10.TabIndex = 52;
            this.bunifuLabel10.Text = "Á";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel9.Location = new System.Drawing.Point(48, 16);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(22, 40);
            this.bunifuLabel9.TabIndex = 53;
            this.bunifuLabel9.Text = "R";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel8.Location = new System.Drawing.Point(27, 16);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(22, 40);
            this.bunifuLabel8.TabIndex = 54;
            this.bunifuLabel8.Text = "G";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblhx
            // 
            this.lblhx.AllowParentOverrides = false;
            this.lblhx.AutoEllipsis = false;
            this.lblhx.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblhx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhx.Location = new System.Drawing.Point(290, 12);
            this.lblhx.Name = "lblhx";
            this.lblhx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblhx.Size = new System.Drawing.Size(36, 22);
            this.lblhx.TabIndex = 55;
            this.lblhx.Text = "h(x): ";
            this.lblhx.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblhx.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblhx.Click += new System.EventHandler(this.lblhx_Click);
            // 
            // lblgx
            // 
            this.lblgx.AllowParentOverrides = false;
            this.lblgx.AutoEllipsis = false;
            this.lblgx.CursorType = null;
            this.lblgx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgx.Location = new System.Drawing.Point(290, 40);
            this.lblgx.Name = "lblgx";
            this.lblgx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblgx.Size = new System.Drawing.Size(37, 22);
            this.lblgx.TabIndex = 56;
            this.lblgx.Text = "g(x): ";
            this.lblgx.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblgx.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblgx.Click += new System.EventHandler(this.lblgx_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblhx);
            this.panel1.Controls.Add(this.bunifuLabel14);
            this.panel1.Controls.Add(this.lblgx);
            this.panel1.Controls.Add(this.bunifuLabel13);
            this.panel1.Controls.Add(this.bunifuLabel8);
            this.panel1.Controls.Add(this.bunifuLabel12);
            this.panel1.Controls.Add(this.bunifuLabel9);
            this.panel1.Controls.Add(this.bunifuLabel11);
            this.panel1.Controls.Add(this.bunifuLabel10);
            this.panel1.Location = new System.Drawing.Point(79, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 69);
            this.panel1.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(250, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 18);
            this.panel2.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(250, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 18);
            this.panel3.TabIndex = 58;
            // 
            // GraficoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Name = "GraficoForm";
            this.Text = "Gráfico";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel14;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel12;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel lblhx;
        private Bunifu.UI.WinForms.BunifuLabel lblgx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}