using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInterface
{
    public partial class Form1 : Form
    {
        private List<Line> lines;
        private int selectedLine;
        private int series;
        public Form1()
        {
            InitializeComponent(); 
            lines = new List<Line>();
            series = 0;
        }

        private void AddLineToChart(Line rec)
        {
            int num = series;
            chart1.Series.Add("Series" + chart1.Series.Count);
            chart1.Series[num].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[num].Color = Color.Black;
            chart1.Series[num].BorderWidth = 3;

            double x = rec.X1;
            double y = rec.Y;
            chart1.Series[num].Points.AddXY(x, y);

            x = rec.X2;
            y = rec.Y;
            chart1.Series[num].Points.AddXY(x, y);
            series++;
        }
        internal void RefreshChart()
        {
            series = 0;
            chart1.Series.Clear();
            int size = lines.Count;
            for (int i = 0; i < size; i++)
            {
                AddLineToChart(lines[i]);
            }
        }
        private void AddLineButton_Click_1(object sender, EventArgs e)
        {
            Point p1 = new Point((double)LineX1.Value, (double)LineY.Value);
            Point p2 = new Point((double)LineX2.Value, (double)LineY.Value);
            try
            {
                lines.Add(new Line(p1, p2));
                AddLineToChart(new Line(p1, p2));
                WriteFigureList();
                var sortedLines = from l in lines
                                    orderby l.X1, l.length
                                    select l;
                lines = sortedLines.ToList();
                LineInfoBox.Text = "";
                foreach (var item in lines)
                {
                    LineInfoBox.Text += item.ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteFigure(object sender, EventArgs e)
        {
            lines.RemoveAt(selectedLine);
            if (lines.Count > 0)
            {
                selectedLine = 0;
                comboBox1.SelectedIndex = 0;
            }
            WriteFigureList();
            RefreshChart();
        }
        private void WriteFigureList()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < lines.Count; i++)
            {
                string str = "";
                str += "Линия №" + lines[i];
                comboBox1.Items.Add(str);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lines.Count > 0)
            {
                selectedLine = comboBox1.SelectedIndex;
            }
        }

        private void GetSumShadow(object sender, EventArgs e)
        {
            LineInfoBox.Text = "";
            foreach (var l in lines)
            {
                LineInfoBox.Text += l + "\n";
            }
            double sum = 0;
            //LineInfoBox.Text = "";
            if (lines.Count > 1)
            {
                for (int i = 0; i < lines.Count - 1; i++)
                {
                    double X1 = lines[i].X1;
                    double X2 = lines[i].X2;
                    double X3 = lines[i + 1].X1;
                    double X4 = lines[i + 1].X2;
                    if (X2 > X3 && X2 < X4)
                    {
                        sum += (X3 - X1);
                        if (i == lines.Count - 2)
                        {
                            sum += (X4 - X3);
                        }
                    }
                    else if (X2 > X3 && X2 > X4)    
                    {
                        sum += (X2 - X1);
                        i++;
                    }
                    else if (X1 == X3 && X2 == X4)
                    {
                        sum += (X2 - X1);
                        i++;
                    }
                    else if (X2 < X3 && X2 < X4)
                    {
                        sum += (X2 - X1);
                        if (i == lines.Count - 2)
                        {
                            sum += (X4 - X3);
                        }
                    }
                }
                LineInfoBox.Text += $"Суммарная длина теней: {sum}";
            }
            else
            {
                LineInfoBox.Text += $"Суммарная длина теней: {lines[0].length}";
            }
        }
    }
}
