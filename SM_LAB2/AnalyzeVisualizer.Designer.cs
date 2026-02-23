namespace SM_LAB2
{
    partial class AnalyzeVisualizer
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
            analyzeResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)analyzeResultChart).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // analyzeResultChart
            // 
            analyzeResultChart.Dock = DockStyle.Top;
            analyzeResultChart.Location = new Point(0, 0);
            analyzeResultChart.Name = "analyzeResultChart";
            analyzeResultChart.Size = new Size(800, 350);
            analyzeResultChart.TabIndex = 0;
            analyzeResultChart.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(394, 94);
            button1.TabIndex = 0;
            button1.Text = "Производительность";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(403, 3);
            button2.Name = "button2";
            button2.Size = new Size(394, 94);
            button2.TabIndex = 1;
            button2.Text = "Погрешность";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AnalyzeVisualizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(analyzeResultChart);
            Name = "AnalyzeVisualizer";
            Text = "AnalyzeVisualizer";
            ((System.ComponentModel.ISupportInitialize)analyzeResultChart).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart analyzeResultChart;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}