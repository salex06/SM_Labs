namespace SM_LAB2
{
    partial class ResultVisualisation
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
            operationsPanel = new TableLayoutPanel();
            currentVarInfo = new Panel();
            currentVarTextBox = new TextBox();
            currentVarLabel = new Label();
            prevNextVariablePanel = new TableLayoutPanel();
            prevVarButton = new Button();
            nextVarButton = new Button();
            rungeKuttaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            deltaPanel = new Panel();
            deltaLabel = new Label();
            deltaTextBox = new TextBox();
            operationsPanel.SuspendLayout();
            currentVarInfo.SuspendLayout();
            prevNextVariablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rungeKuttaChart).BeginInit();
            deltaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // operationsPanel
            // 
            operationsPanel.ColumnCount = 2;
            operationsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            operationsPanel.Controls.Add(currentVarInfo, 0, 0);
            operationsPanel.Controls.Add(prevNextVariablePanel, 1, 0);
            operationsPanel.Controls.Add(deltaPanel, 0, 1);
            operationsPanel.Dock = DockStyle.Bottom;
            operationsPanel.Location = new Point(0, 428);
            operationsPanel.Name = "operationsPanel";
            operationsPanel.RowCount = 2;
            operationsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3333321F));
            operationsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6666679F));
            operationsPanel.Size = new Size(800, 150);
            operationsPanel.TabIndex = 1;
            // 
            // currentVarInfo
            // 
            currentVarInfo.Controls.Add(currentVarTextBox);
            currentVarInfo.Controls.Add(currentVarLabel);
            currentVarInfo.Dock = DockStyle.Fill;
            currentVarInfo.Location = new Point(3, 3);
            currentVarInfo.Name = "currentVarInfo";
            currentVarInfo.Size = new Size(394, 68);
            currentVarInfo.TabIndex = 2;
            // 
            // currentVarTextBox
            // 
            currentVarTextBox.Location = new Point(221, 19);
            currentVarTextBox.Name = "currentVarTextBox";
            currentVarTextBox.ReadOnly = true;
            currentVarTextBox.Size = new Size(170, 31);
            currentVarTextBox.TabIndex = 1;
            // 
            // currentVarLabel
            // 
            currentVarLabel.Dock = DockStyle.Left;
            currentVarLabel.Location = new Point(0, 0);
            currentVarLabel.Name = "currentVarLabel";
            currentVarLabel.Size = new Size(215, 68);
            currentVarLabel.TabIndex = 0;
            currentVarLabel.Text = "Текущяя переменная:";
            currentVarLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prevNextVariablePanel
            // 
            prevNextVariablePanel.ColumnCount = 2;
            prevNextVariablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            prevNextVariablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            prevNextVariablePanel.Controls.Add(prevVarButton, 0, 0);
            prevNextVariablePanel.Controls.Add(nextVarButton, 1, 0);
            prevNextVariablePanel.Dock = DockStyle.Fill;
            prevNextVariablePanel.Location = new Point(403, 3);
            prevNextVariablePanel.Name = "prevNextVariablePanel";
            prevNextVariablePanel.RowCount = 1;
            prevNextVariablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            prevNextVariablePanel.Size = new Size(394, 68);
            prevNextVariablePanel.TabIndex = 3;
            // 
            // prevVarButton
            // 
            prevVarButton.Dock = DockStyle.Fill;
            prevVarButton.Location = new Point(3, 3);
            prevVarButton.Name = "prevVarButton";
            prevVarButton.Size = new Size(191, 62);
            prevVarButton.TabIndex = 0;
            prevVarButton.Text = "Предыдущая";
            prevVarButton.UseVisualStyleBackColor = true;
            prevVarButton.Click += prevVarButton_Click;
            // 
            // nextVarButton
            // 
            nextVarButton.Dock = DockStyle.Fill;
            nextVarButton.Location = new Point(200, 3);
            nextVarButton.Name = "nextVarButton";
            nextVarButton.Size = new Size(191, 62);
            nextVarButton.TabIndex = 1;
            nextVarButton.Text = "Следующая";
            nextVarButton.UseVisualStyleBackColor = true;
            nextVarButton.Click += nextVarButton_Click;
            // 
            // rungeKuttaChart
            // 
            rungeKuttaChart.Dock = DockStyle.Fill;
            rungeKuttaChart.Location = new Point(0, 0);
            rungeKuttaChart.Name = "rungeKuttaChart";
            rungeKuttaChart.Size = new Size(800, 428);
            rungeKuttaChart.TabIndex = 2;
            rungeKuttaChart.Text = "chart1";
            // 
            // deltaPanel
            // 
            deltaPanel.Controls.Add(deltaTextBox);
            deltaPanel.Controls.Add(deltaLabel);
            deltaPanel.Dock = DockStyle.Fill;
            deltaPanel.Location = new Point(3, 77);
            deltaPanel.Name = "deltaPanel";
            deltaPanel.Size = new Size(394, 70);
            deltaPanel.TabIndex = 4;
            // 
            // deltaLabel
            // 
            deltaLabel.Dock = DockStyle.Left;
            deltaLabel.Location = new Point(0, 0);
            deltaLabel.Name = "deltaLabel";
            deltaLabel.Size = new Size(215, 70);
            deltaLabel.TabIndex = 0;
            deltaLabel.Text = "Погрешность, %";
            deltaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deltaTextBox
            // 
            deltaTextBox.Location = new Point(221, 20);
            deltaTextBox.Name = "deltaTextBox";
            deltaTextBox.ReadOnly = true;
            deltaTextBox.Size = new Size(170, 31);
            deltaTextBox.TabIndex = 2;
            // 
            // ResultVisualisation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 578);
            Controls.Add(rungeKuttaChart);
            Controls.Add(operationsPanel);
            Name = "ResultVisualisation";
            Text = "Результаты вычислений";
            operationsPanel.ResumeLayout(false);
            currentVarInfo.ResumeLayout(false);
            currentVarInfo.PerformLayout();
            prevNextVariablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rungeKuttaChart).EndInit();
            deltaPanel.ResumeLayout(false);
            deltaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel operationsPanel;
        private Panel currentVarInfo;
        private TextBox currentVarTextBox;
        private Label currentVarLabel;
        private TableLayoutPanel prevNextVariablePanel;
        private Button prevVarButton;
        private Button nextVarButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart rungeKuttaChart;
        private Panel deltaPanel;
        private TextBox deltaTextBox;
        private Label deltaLabel;
    }
}