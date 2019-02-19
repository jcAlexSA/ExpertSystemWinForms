namespace ExpertSystemWinForms.Views.Dialogs
{
    partial class InteractiveDebug
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0,0,0,0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxInputVariables = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxOutputVariables = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.labelMinMax = new System.Windows.Forms.Label();
            this.numericUpDownInputValue = new System.Windows.Forms.NumericUpDown();
            this.chartTerms = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTerms)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxInputVariables
            // 
            this.listBoxInputVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInputVariables.FormattingEnabled = true;
            this.listBoxInputVariables.ItemHeight = 15;
            this.listBoxInputVariables.Location = new System.Drawing.Point(3, 17);
            this.listBoxInputVariables.Name = "listBoxInputVariables";
            this.listBoxInputVariables.Size = new System.Drawing.Size(143, 93);
            this.listBoxInputVariables.TabIndex = 0;
            this.listBoxInputVariables.Click += new System.EventHandler(this.ListBoxInputVariables_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBoxInputVariables);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listBoxOutputVariables);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // listBoxOutputVariables
            // 
            this.listBoxOutputVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutputVariables.FormattingEnabled = true;
            this.listBoxOutputVariables.ItemHeight = 15;
            this.listBoxOutputVariables.Location = new System.Drawing.Point(3, 17);
            this.listBoxOutputVariables.Name = "listBoxOutputVariables";
            this.listBoxOutputVariables.Size = new System.Drawing.Size(143, 93);
            this.listBoxOutputVariables.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelChart, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 238);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.Controls.Add(this.chartTerms);
            this.panelChart.Location = new System.Drawing.Point(158, 3);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.SetRowSpan(this.panelChart, 2);
            this.panelChart.Size = new System.Drawing.Size(404, 232);
            this.panelChart.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.comboBoxMethods);
            this.panelBottom.Controls.Add(this.labelMinMax);
            this.panelBottom.Controls.Add(this.numericUpDownInputValue);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottom.Location = new System.Drawing.Point(0, 0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(565, 45);
            this.panelBottom.TabIndex = 4;
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMethods.BackColor = System.Drawing.Color.White;
            this.comboBoxMethods.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxMethods.Items.AddRange(new object[] {
            "Mamdani"});
            this.comboBoxMethods.Location = new System.Drawing.Point(379, 11);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(158, 24);
            this.comboBoxMethods.TabIndex = 2;
            this.comboBoxMethods.Text = "Mamdani";
            // 
            // labelMinMax
            // 
            this.labelMinMax.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinMax.Location = new System.Drawing.Point(176, 11);
            this.labelMinMax.Name = "labelMinMax";
            this.labelMinMax.Size = new System.Drawing.Size(160, 23);
            this.labelMinMax.TabIndex = 1;
            this.labelMinMax.Text = "x: [0; 0]";
            this.labelMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownInputValue
            // 
            this.numericUpDownInputValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownInputValue.DecimalPlaces = 2;
            this.numericUpDownInputValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownInputValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownInputValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownInputValue.Location = new System.Drawing.Point(17, 11);
            this.numericUpDownInputValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownInputValue.Name = "numericUpDownInputValue";
            this.numericUpDownInputValue.Size = new System.Drawing.Size(143, 23);
            this.numericUpDownInputValue.TabIndex = 0;
            this.numericUpDownInputValue.ValueChanged += new System.EventHandler(this.NumericUpDownInputValue_ValueChanged);
            // 
            // chartTerms
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 6F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 5F);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea1.AxisY.LabelStyle.Interval = 0.2D;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 7F);
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartAreaTerms";
            this.chartTerms.ChartAreas.Add(chartArea1);
            this.chartTerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTerms.Location = new System.Drawing.Point(5, 5);
            this.chartTerms.Name = "chartTerms";
            series1.ChartArea = "ChartAreaTerms";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.Name = "SeriesLines";
            series1.Points.Add(dataPoint1);
            series1.YValuesPerPoint = 10;
            series2.ChartArea = "ChartAreaTerms";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Gray;
            series2.Name = "SeriesSplines";
            this.chartTerms.Series.Add(series1);
            this.chartTerms.Series.Add(series2);
            this.chartTerms.Size = new System.Drawing.Size(394, 222);
            this.chartTerms.TabIndex = 9;
            this.chartTerms.Text = "chart1";
            // 
            // InteractiveDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 288);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "InteractiveDebug";
            this.Text = "Interactive Debug";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTerms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInputVariables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxOutputVariables;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelMinMax;
        private System.Windows.Forms.NumericUpDown numericUpDownInputValue;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTerms;
    }
}