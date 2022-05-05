namespace TestInterface
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AUpDown = new System.Windows.Forms.NumericUpDown();
            this.BUpDown = new System.Windows.Forms.NumericUpDown();
            this.CUpDown = new System.Windows.Forms.NumericUpDown();
            this.DUpDown = new System.Windows.Forms.NumericUpDown();
            this.EUpDown = new System.Windows.Forms.NumericUpDown();
            this.FUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeButton = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUpDown)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.InfoBox);
            this.splitContainer1.Panel1.Controls.Add(this.TypeButton);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.FUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.EUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.DUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.CUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.BUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.AUpDown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(935, 535);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 26;
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
            this.chart1.Size = new System.Drawing.Size(631, 535);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // AUpDown
            // 
            this.AUpDown.Location = new System.Drawing.Point(12, 29);
            this.AUpDown.Name = "AUpDown";
            this.AUpDown.Size = new System.Drawing.Size(90, 22);
            this.AUpDown.TabIndex = 2;
            // 
            // BUpDown
            // 
            this.BUpDown.Location = new System.Drawing.Point(108, 29);
            this.BUpDown.Name = "BUpDown";
            this.BUpDown.Size = new System.Drawing.Size(90, 22);
            this.BUpDown.TabIndex = 3;
            // 
            // CUpDown
            // 
            this.CUpDown.Location = new System.Drawing.Point(204, 29);
            this.CUpDown.Name = "CUpDown";
            this.CUpDown.Size = new System.Drawing.Size(90, 22);
            this.CUpDown.TabIndex = 3;
            // 
            // DUpDown
            // 
            this.DUpDown.Location = new System.Drawing.Point(12, 77);
            this.DUpDown.Name = "DUpDown";
            this.DUpDown.Size = new System.Drawing.Size(90, 22);
            this.DUpDown.TabIndex = 4;
            // 
            // EUpDown
            // 
            this.EUpDown.Location = new System.Drawing.Point(108, 77);
            this.EUpDown.Name = "EUpDown";
            this.EUpDown.Size = new System.Drawing.Size(90, 22);
            this.EUpDown.TabIndex = 5;
            // 
            // FUpDown
            // 
            this.FUpDown.Location = new System.Drawing.Point(204, 77);
            this.FUpDown.Name = "FUpDown";
            this.FUpDown.Size = new System.Drawing.Size(90, 22);
            this.FUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "E";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "F";
            // 
            // TypeButton
            // 
            this.TypeButton.Location = new System.Drawing.Point(92, 129);
            this.TypeButton.Name = "TypeButton";
            this.TypeButton.Size = new System.Drawing.Size(126, 39);
            this.TypeButton.TabIndex = 13;
            this.TypeButton.Text = "Определить вид";
            this.TypeButton.UseVisualStyleBackColor = true;
            this.TypeButton.Click += new System.EventHandler(this.TypeButton_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(12, 223);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(282, 96);
            this.InfoBox.TabIndex = 2;
            this.InfoBox.Text = "";
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FUpDown;
        private System.Windows.Forms.NumericUpDown EUpDown;
        private System.Windows.Forms.NumericUpDown DUpDown;
        private System.Windows.Forms.NumericUpDown CUpDown;
        private System.Windows.Forms.NumericUpDown BUpDown;
        private System.Windows.Forms.NumericUpDown AUpDown;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button TypeButton;
    }
}

