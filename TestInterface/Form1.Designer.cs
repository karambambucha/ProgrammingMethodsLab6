namespace QuadrilateralTestInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.RectangleInfoBox = new System.Windows.Forms.RichTextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Point4Y = new System.Windows.Forms.NumericUpDown();
            this.Point4X = new System.Windows.Forms.NumericUpDown();
            this.Point3Y = new System.Windows.Forms.NumericUpDown();
            this.Point3X = new System.Windows.Forms.NumericUpDown();
            this.Point2Y = new System.Windows.Forms.NumericUpDown();
            this.Point2X = new System.Windows.Forms.NumericUpDown();
            this.Point1Y = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Point1X = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Point4Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point4X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point3Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point3X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point1X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.RectangleInfoBox);
            this.splitContainer1.Panel1.Controls.Add(this.TestButton);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Point4Y);
            this.splitContainer1.Panel1.Controls.Add(this.Point4X);
            this.splitContainer1.Panel1.Controls.Add(this.Point3Y);
            this.splitContainer1.Panel1.Controls.Add(this.Point3X);
            this.splitContainer1.Panel1.Controls.Add(this.Point2Y);
            this.splitContainer1.Panel1.Controls.Add(this.Point2X);
            this.splitContainer1.Panel1.Controls.Add(this.Point1Y);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Point1X);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(935, 535);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Результаты";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RectangleInfoBox
            // 
            this.RectangleInfoBox.Location = new System.Drawing.Point(18, 357);
            this.RectangleInfoBox.Name = "RectangleInfoBox";
            this.RectangleInfoBox.ReadOnly = true;
            this.RectangleInfoBox.Size = new System.Drawing.Size(257, 166);
            this.RectangleInfoBox.TabIndex = 42;
            this.RectangleInfoBox.Text = "";
            // 
            // TestButton
            // 
            this.TestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TestButton.Location = new System.Drawing.Point(109, 272);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 41;
            this.TestButton.Text = "Запуск";
            this.TestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 32);
            this.label7.TabIndex = 40;
            this.label7.Text = "Координата Y\r\n4 точки";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 32);
            this.label8.TabIndex = 39;
            this.label8.Text = "Координата X\r\n4 точки";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Координата Y\r\n3 точки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "Координата X\r\n3 точки";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 36;
            this.label3.Text = "Координата Y\r\n2 точки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Координата X\r\n2 точки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Координата Y\r\n1 точки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Point4Y
            // 
            this.Point4Y.DecimalPlaces = 2;
            this.Point4Y.Location = new System.Drawing.Point(155, 244);
            this.Point4Y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point4Y.Name = "Point4Y";
            this.Point4Y.Size = new System.Drawing.Size(120, 22);
            this.Point4Y.TabIndex = 33;
            // 
            // Point4X
            // 
            this.Point4X.DecimalPlaces = 2;
            this.Point4X.Location = new System.Drawing.Point(17, 244);
            this.Point4X.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point4X.Name = "Point4X";
            this.Point4X.Size = new System.Drawing.Size(120, 22);
            this.Point4X.TabIndex = 32;
            // 
            // Point3Y
            // 
            this.Point3Y.DecimalPlaces = 2;
            this.Point3Y.Location = new System.Drawing.Point(155, 184);
            this.Point3Y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point3Y.Name = "Point3Y";
            this.Point3Y.Size = new System.Drawing.Size(120, 22);
            this.Point3Y.TabIndex = 31;
            // 
            // Point3X
            // 
            this.Point3X.DecimalPlaces = 2;
            this.Point3X.Location = new System.Drawing.Point(18, 184);
            this.Point3X.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point3X.Name = "Point3X";
            this.Point3X.Size = new System.Drawing.Size(120, 22);
            this.Point3X.TabIndex = 30;
            // 
            // Point2Y
            // 
            this.Point2Y.DecimalPlaces = 2;
            this.Point2Y.Location = new System.Drawing.Point(155, 116);
            this.Point2Y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point2Y.Name = "Point2Y";
            this.Point2Y.Size = new System.Drawing.Size(120, 22);
            this.Point2Y.TabIndex = 29;
            // 
            // Point2X
            // 
            this.Point2X.DecimalPlaces = 2;
            this.Point2X.Location = new System.Drawing.Point(18, 116);
            this.Point2X.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point2X.Name = "Point2X";
            this.Point2X.Size = new System.Drawing.Size(120, 22);
            this.Point2X.TabIndex = 28;
            // 
            // Point1Y
            // 
            this.Point1Y.DecimalPlaces = 2;
            this.Point1Y.Location = new System.Drawing.Point(155, 56);
            this.Point1Y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point1Y.Name = "Point1Y";
            this.Point1Y.Size = new System.Drawing.Size(120, 22);
            this.Point1Y.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Координата X\r\n1 точки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Point1X
            // 
            this.Point1X.DecimalPlaces = 2;
            this.Point1X.Location = new System.Drawing.Point(18, 56);
            this.Point1X.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Point1X.Name = "Point1X";
            this.Point1X.Size = new System.Drawing.Size(120, 22);
            this.Point1X.TabIndex = 25;
            // 
            // chart1
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Maximum = 5D;
            chartArea2.AxisX.Minimum = -5D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.Maximum = 5D;
            chartArea2.AxisY.Minimum = -5D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Fuchsia;
            series2.MarkerColor = System.Drawing.Color.Thistle;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(631, 535);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 535);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Point4Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point4X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point3Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point3X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point1X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox RectangleInfoBox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Point4Y;
        private System.Windows.Forms.NumericUpDown Point4X;
        private System.Windows.Forms.NumericUpDown Point3Y;
        private System.Windows.Forms.NumericUpDown Point3X;
        private System.Windows.Forms.NumericUpDown Point2Y;
        private System.Windows.Forms.NumericUpDown Point2X;
        private System.Windows.Forms.NumericUpDown Point1Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Point1X;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

