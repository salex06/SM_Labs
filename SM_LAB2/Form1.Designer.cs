namespace SM_LAB2
{
    partial class Lab2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2));
            label1 = new Label();
            stepInfoPanel = new Panel();
            stepSizeInput = new NumericUpDown();
            label2 = new Label();
            modelPanel = new Panel();
            fourthModelPanel = new Panel();
            pictureBox1 = new PictureBox();
            thirdModelPanel = new Panel();
            thirdModelPicture = new PictureBox();
            secondModelPanel = new Panel();
            secondModelPicture = new PictureBox();
            firstModelPanel = new Panel();
            firstModelPicture = new PictureBox();
            modelTitle = new Label();
            firstModelRadio = new RadioButton();
            secondModelRadio = new RadioButton();
            modelRadioPanel = new Panel();
            fourthModelRadio = new RadioButton();
            thirdModelRadio = new RadioButton();
            calcButton = new Button();
            stepInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stepSizeInput).BeginInit();
            modelPanel.SuspendLayout();
            fourthModelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            thirdModelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thirdModelPicture).BeginInit();
            secondModelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondModelPicture).BeginInit();
            firstModelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)firstModelPicture).BeginInit();
            modelRadioPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(1201, 67);
            label1.TabIndex = 0;
            label1.Text = "ЛР 2. Имитационная модель нелинейной динамической системы";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stepInfoPanel
            // 
            stepInfoPanel.Controls.Add(stepSizeInput);
            stepInfoPanel.Controls.Add(label2);
            stepInfoPanel.Dock = DockStyle.Top;
            stepInfoPanel.Location = new Point(5, 72);
            stepInfoPanel.Name = "stepInfoPanel";
            stepInfoPanel.Size = new Size(1201, 43);
            stepInfoPanel.TabIndex = 1;
            // 
            // stepSizeInput
            // 
            stepSizeInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stepSizeInput.DecimalPlaces = 4;
            stepSizeInput.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            stepSizeInput.Location = new Point(601, 7);
            stepSizeInput.Maximum = new decimal(new int[] { 99999, 0, 0, 262144 });
            stepSizeInput.Minimum = new decimal(new int[] { 1, 0, 0, 262144 });
            stepSizeInput.Name = "stepSizeInput";
            stepSizeInput.Size = new Size(588, 31);
            stepSizeInput.TabIndex = 1;
            stepSizeInput.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(449, 43);
            label2.TabIndex = 0;
            label2.Text = "Шаг интегрирования: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modelPanel
            // 
            modelPanel.Controls.Add(fourthModelPanel);
            modelPanel.Controls.Add(thirdModelPanel);
            modelPanel.Controls.Add(secondModelPanel);
            modelPanel.Controls.Add(firstModelPanel);
            modelPanel.Controls.Add(modelTitle);
            modelPanel.Dock = DockStyle.Top;
            modelPanel.Location = new Point(5, 115);
            modelPanel.Name = "modelPanel";
            modelPanel.Size = new Size(1201, 380);
            modelPanel.TabIndex = 2;
            // 
            // fourthModelPanel
            // 
            fourthModelPanel.Controls.Add(pictureBox1);
            fourthModelPanel.Dock = DockStyle.Left;
            fourthModelPanel.Location = new Point(900, 30);
            fourthModelPanel.Name = "fourthModelPanel";
            fourthModelPanel.Padding = new Padding(3);
            fourthModelPanel.Size = new Size(300, 350);
            fourthModelPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 344);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // thirdModelPanel
            // 
            thirdModelPanel.Controls.Add(thirdModelPicture);
            thirdModelPanel.Dock = DockStyle.Left;
            thirdModelPanel.Location = new Point(600, 30);
            thirdModelPanel.Name = "thirdModelPanel";
            thirdModelPanel.Padding = new Padding(3);
            thirdModelPanel.Size = new Size(300, 350);
            thirdModelPanel.TabIndex = 3;
            // 
            // thirdModelPicture
            // 
            thirdModelPicture.BackColor = Color.White;
            thirdModelPicture.Dock = DockStyle.Fill;
            thirdModelPicture.Image = (Image)resources.GetObject("thirdModelPicture.Image");
            thirdModelPicture.Location = new Point(3, 3);
            thirdModelPicture.Name = "thirdModelPicture";
            thirdModelPicture.Size = new Size(294, 344);
            thirdModelPicture.TabIndex = 0;
            thirdModelPicture.TabStop = false;
            // 
            // secondModelPanel
            // 
            secondModelPanel.Controls.Add(secondModelPicture);
            secondModelPanel.Dock = DockStyle.Left;
            secondModelPanel.Location = new Point(300, 30);
            secondModelPanel.Name = "secondModelPanel";
            secondModelPanel.Padding = new Padding(3);
            secondModelPanel.Size = new Size(300, 350);
            secondModelPanel.TabIndex = 2;
            // 
            // secondModelPicture
            // 
            secondModelPicture.BackColor = Color.White;
            secondModelPicture.Dock = DockStyle.Fill;
            secondModelPicture.Image = (Image)resources.GetObject("secondModelPicture.Image");
            secondModelPicture.InitialImage = (Image)resources.GetObject("secondModelPicture.InitialImage");
            secondModelPicture.Location = new Point(3, 3);
            secondModelPicture.Name = "secondModelPicture";
            secondModelPicture.Size = new Size(294, 344);
            secondModelPicture.TabIndex = 0;
            secondModelPicture.TabStop = false;
            // 
            // firstModelPanel
            // 
            firstModelPanel.Controls.Add(firstModelPicture);
            firstModelPanel.Dock = DockStyle.Left;
            firstModelPanel.Location = new Point(0, 30);
            firstModelPanel.Name = "firstModelPanel";
            firstModelPanel.Padding = new Padding(3);
            firstModelPanel.Size = new Size(300, 350);
            firstModelPanel.TabIndex = 1;
            // 
            // firstModelPicture
            // 
            firstModelPicture.BackColor = Color.White;
            firstModelPicture.Dock = DockStyle.Fill;
            firstModelPicture.Image = (Image)resources.GetObject("firstModelPicture.Image");
            firstModelPicture.InitialImage = (Image)resources.GetObject("firstModelPicture.InitialImage");
            firstModelPicture.Location = new Point(3, 3);
            firstModelPicture.Name = "firstModelPicture";
            firstModelPicture.Size = new Size(294, 344);
            firstModelPicture.TabIndex = 0;
            firstModelPicture.TabStop = false;
            // 
            // modelTitle
            // 
            modelTitle.Dock = DockStyle.Top;
            modelTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            modelTitle.Location = new Point(0, 0);
            modelTitle.Name = "modelTitle";
            modelTitle.Size = new Size(1201, 30);
            modelTitle.TabIndex = 0;
            modelTitle.Text = "Выбор модели";
            modelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstModelRadio
            // 
            firstModelRadio.Checked = true;
            firstModelRadio.Dock = DockStyle.Left;
            firstModelRadio.Location = new Point(0, 0);
            firstModelRadio.Name = "firstModelRadio";
            firstModelRadio.Size = new Size(300, 59);
            firstModelRadio.TabIndex = 1;
            firstModelRadio.TabStop = true;
            firstModelRadio.Text = "Модель 1";
            firstModelRadio.UseVisualStyleBackColor = true;
            firstModelRadio.CheckedChanged += firstModelRadio_CheckedChanged;
            // 
            // secondModelRadio
            // 
            secondModelRadio.Dock = DockStyle.Left;
            secondModelRadio.Location = new Point(300, 0);
            secondModelRadio.Name = "secondModelRadio";
            secondModelRadio.Size = new Size(306, 59);
            secondModelRadio.TabIndex = 1;
            secondModelRadio.Text = "Модель 2";
            secondModelRadio.UseVisualStyleBackColor = true;
            secondModelRadio.CheckedChanged += secondModelRadio_CheckedChanged;
            // 
            // modelRadioPanel
            // 
            modelRadioPanel.Controls.Add(fourthModelRadio);
            modelRadioPanel.Controls.Add(thirdModelRadio);
            modelRadioPanel.Controls.Add(secondModelRadio);
            modelRadioPanel.Controls.Add(firstModelRadio);
            modelRadioPanel.Dock = DockStyle.Top;
            modelRadioPanel.Location = new Point(5, 495);
            modelRadioPanel.Name = "modelRadioPanel";
            modelRadioPanel.Size = new Size(1201, 59);
            modelRadioPanel.TabIndex = 3;
            // 
            // fourthModelRadio
            // 
            fourthModelRadio.Dock = DockStyle.Left;
            fourthModelRadio.Location = new Point(900, 0);
            fourthModelRadio.Name = "fourthModelRadio";
            fourthModelRadio.Size = new Size(300, 59);
            fourthModelRadio.TabIndex = 3;
            fourthModelRadio.Text = "Модель 4";
            fourthModelRadio.UseVisualStyleBackColor = true;
            // 
            // thirdModelRadio
            // 
            thirdModelRadio.Dock = DockStyle.Left;
            thirdModelRadio.Location = new Point(606, 0);
            thirdModelRadio.Name = "thirdModelRadio";
            thirdModelRadio.Size = new Size(294, 59);
            thirdModelRadio.TabIndex = 2;
            thirdModelRadio.Text = "Модель 3";
            thirdModelRadio.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            calcButton.Cursor = Cursors.Hand;
            calcButton.Dock = DockStyle.Fill;
            calcButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            calcButton.Location = new Point(5, 554);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(1201, 86);
            calcButton.TabIndex = 4;
            calcButton.Text = "Вычислить";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // Lab2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1211, 645);
            Controls.Add(calcButton);
            Controls.Add(modelRadioPanel);
            Controls.Add(modelPanel);
            Controls.Add(stepInfoPanel);
            Controls.Add(label1);
            Name = "Lab2";
            Padding = new Padding(5);
            Text = "ЛР 2. МС";
            stepInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stepSizeInput).EndInit();
            modelPanel.ResumeLayout(false);
            fourthModelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            thirdModelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)thirdModelPicture).EndInit();
            secondModelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)secondModelPicture).EndInit();
            firstModelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)firstModelPicture).EndInit();
            modelRadioPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel stepInfoPanel;
        private NumericUpDown stepSizeInput;
        private Label label2;
        private Panel modelPanel;
        private Label modelTitle;
        private Panel secondModelPanel;
        private Panel firstModelPanel;
        private PictureBox firstModelPicture;
        private RadioButton secondModelRadio;
        private PictureBox secondModelPicture;
        private RadioButton firstModelRadio;
        private Panel modelRadioPanel;
        private Panel thirdModelPanel;
        private PictureBox thirdModelPicture;
        private RadioButton thirdModelRadio;
        private Panel fourthModelPanel;
        private PictureBox pictureBox1;
        private RadioButton fourthModelRadio;
        private Button calcButton;
    }
}
