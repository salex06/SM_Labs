using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SM_LAB2
{
    public partial class AnalyzeVisualizer : Form
    {
        List<KeyValuePair<double, int>> hAndPerformance;
        List<KeyValuePair<double, double>> hAndDelta;
        public AnalyzeVisualizer(List<KeyValuePair<double, int>> hAndPerformance,
                                 List<KeyValuePair<double, double>> hAndDelta)
        {
            InitializeComponent();

            this.hAndPerformance = hAndPerformance;
            this.hAndDelta = hAndDelta;

            DrawChart(true);
        }

        public void DrawChart(bool isHAndPerformance)
        {
            ClearChart();

            var chartArea = new ChartArea();
            analyzeResultChart.ChartAreas.Add(chartArea);

            var lineSeries = new Series
            {
                Name = " ",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.Blue
            };

            if (isHAndPerformance)
            {
                foreach (var point in hAndPerformance)
                {
                    lineSeries.Points.AddXY(point.Key, point.Value);
                }
            }
            else
            {
                foreach (var point in hAndDelta)
                {
                    lineSeries.Points.AddXY(point.Key, point.Value);
                }
            }

            analyzeResultChart.Series.Add(lineSeries);

            chartArea.AxisX.Title = "Ось h";
            chartArea.AxisY.Title = isHAndPerformance ? "Ось t, мс" : "Погрешность, %";

            var legend = new Legend();
            analyzeResultChart.Legends.Add(legend);

        }

        private void ClearChart()
        {
            analyzeResultChart.ChartAreas.Clear();
            analyzeResultChart.Series.Clear();
            analyzeResultChart.Legends.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawChart(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawChart(false);
        }
    }
}
