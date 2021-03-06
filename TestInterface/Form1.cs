using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadrilateralTestInterface
{
    public partial class Form1 : Form
    {
        private Quadrilateral quadrilateral;
        public Form1()
        {
            InitializeComponent(); 
        }
        private void AddRectangleToChart(Quadrilateral rec)
        {
            for (int i = 0; i < 4; i++)
            {
                chart1.Series.Add("Прямая " + i);
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                this.chart1.Series[i].Color = Color.Black;
                chart1.Series[i].BorderWidth = 3;

                Point p1 = rec.points[i % 4];
                double x = p1.X;
                double y = p1.Y;
                chart1.Series[i].Points.AddXY(x, y);

                Point p2 = rec.points[(i + 1) % 4];
                x = p2.X;
                y = p2.Y;
                chart1.Series[i].Points.AddXY(x, y);
            }
        }
        private void TestButton_Click_1(object sender, EventArgs e)
        {
            Point p1 = new Point((double)Point1X.Value, (double)Point1Y.Value);
            Point p2 = new Point((double)Point2X.Value, (double)Point2Y.Value);
            Point p3 = new Point((double)Point3X.Value, (double)Point3Y.Value);
            Point p4 = new Point((double)Point4X.Value, (double)Point4Y.Value);
            try
            {
                quadrilateral = new Quadrilateral(p1, p2, p3, p4);

                RectangleInfoBox.Text = quadrilateral.ToString();
                chart1.Series.Clear();
                AddRectangleToChart(quadrilateral);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
