using SM_LAB2.utils;
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
    public partial class ResultVisualisation : Form
    {
        private List<KeyValuePair<double, Vector>> points;
        private int currentVar = 0;
        public ResultVisualisation(List<KeyValuePair<double, Vector>> points, double delta)
        {
            InitializeComponent();
            this.points = [.. points];

            deltaTextBox.Text = delta.ToString();

            currentVarTextBox.Text = $"x{currentVar + 1}";
            DrawChart(currentVar);

            ShowFinalStateVariable(points);
        }

        private void DrawChart(int varIndex)
        {
            ClearChart();

            var chartArea = new ChartArea();
            rungeKuttaChart.ChartAreas.Add(chartArea);

            var lineSeries = new Series
            {
                Name = " ",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.Blue
            };

            foreach (var point in points)
            {
                lineSeries.Points.AddXY(point.Key, point.Value.Get(varIndex));
            }

            rungeKuttaChart.Series.Add(lineSeries);

            chartArea.AxisX.Title = "Ось t";
            chartArea.AxisY.Title = $"Ось x{varIndex + 1}";

            var legend = new Legend();
            rungeKuttaChart.Legends.Add(legend);

        }

        private void ClearChart() {
            rungeKuttaChart.ChartAreas.Clear();
            rungeKuttaChart.Series.Clear();
            rungeKuttaChart.Legends.Clear();
        }

        private void ShowFinalStateVariable(List<KeyValuePair<double, Vector>> rungeKuttaResult) {
            Vector rungeKuttaLastVector = rungeKuttaResult[rungeKuttaResult.Count - 1].Value;
            reportTextArea.Text = $"Переменные состояния x_k(T):\n";
            for (int i = 0; i < rungeKuttaLastVector.Size; ++i) {
                reportTextArea.Text += $"x_{i + 1}(T) = {rungeKuttaLastVector.Get(i)}\n";
            }
        }

        private void nextVarButton_Click(object sender, EventArgs e)
        {
            int order = points[0].Value.Size;
            if (currentVar == order - 1)
                return;

            currentVar++;
            DrawChart(currentVar);
            currentVarTextBox.Text = $"x{currentVar + 1}";
        }

        private void prevVarButton_Click(object sender, EventArgs e)
        {
            if (currentVar == 0)
                return;

            currentVar--;
            DrawChart(currentVar);
            currentVarTextBox.Text = $"x{currentVar + 1}";
        }
    }
}
