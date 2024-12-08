namespace Tyuiu.ArapovTY.Sprint6.Task2.V27
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_ATY = new GroupBox();
            textBoxTask_ATY = new TextBox();
            groupBoxCondition2_ATY = new GroupBox();
            textBoxStopValue_ATY = new TextBox();
            textBoxCondStopVal_ATY = new TextBox();
            textBoxStartValue_ATY = new TextBox();
            textBoxCondStartVal_ATY = new TextBox();
            buttonDone_ATY = new Button();
            buttonHelp_ATY = new Button();
            groupBoxRes_ATY = new GroupBox();
            chartFunction_ATY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxRes = new TextBox();
            dataGridViewFunction_ATY = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBoxCondition_ATY.SuspendLayout();
            groupBoxCondition2_ATY.SuspendLayout();
            groupBoxRes_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ATY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_ATY).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_ATY
            // 
            groupBoxCondition_ATY.Controls.Add(textBoxTask_ATY);
            groupBoxCondition_ATY.Location = new Point(12, 12);
            groupBoxCondition_ATY.Name = "groupBoxCondition_ATY";
            groupBoxCondition_ATY.Size = new Size(510, 311);
            groupBoxCondition_ATY.TabIndex = 1;
            groupBoxCondition_ATY.TabStop = false;
            groupBoxCondition_ATY.Text = "Условие";
            // 
            // textBoxTask_ATY
            // 
            textBoxTask_ATY.BackColor = SystemColors.Control;
            textBoxTask_ATY.BorderStyle = BorderStyle.None;
            textBoxTask_ATY.ForeColor = SystemColors.ControlText;
            textBoxTask_ATY.Location = new Point(6, 36);
            textBoxTask_ATY.Multiline = true;
            textBoxTask_ATY.Name = "textBoxTask_ATY";
            textBoxTask_ATY.Size = new Size(460, 111);
            textBoxTask_ATY.TabIndex = 1;
            textBoxTask_ATY.Text = "Протабулировать функцию y=(2x-3)/(cos(x)-2x)+5x-sin(x)\r\nна заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.\r\n";
            // 
            // groupBoxCondition2_ATY
            // 
            groupBoxCondition2_ATY.Controls.Add(textBoxStopValue_ATY);
            groupBoxCondition2_ATY.Controls.Add(textBoxCondStopVal_ATY);
            groupBoxCondition2_ATY.Controls.Add(textBoxStartValue_ATY);
            groupBoxCondition2_ATY.Controls.Add(textBoxCondStartVal_ATY);
            groupBoxCondition2_ATY.Location = new Point(-1, 321);
            groupBoxCondition2_ATY.Name = "groupBoxCondition2_ATY";
            groupBoxCondition2_ATY.Size = new Size(319, 117);
            groupBoxCondition2_ATY.TabIndex = 2;
            groupBoxCondition2_ATY.TabStop = false;
            groupBoxCondition2_ATY.Text = "Ввод данных";
            // 
            // textBoxStopValue_ATY
            // 
            textBoxStopValue_ATY.Location = new Point(188, 71);
            textBoxStopValue_ATY.Name = "textBoxStopValue_ATY";
            textBoxStopValue_ATY.Size = new Size(125, 27);
            textBoxStopValue_ATY.TabIndex = 3;
            textBoxStopValue_ATY.Text = "5";
            textBoxStopValue_ATY.KeyPress += textBoxStopValue_ATY_KeyPress;
            // 
            // textBoxCondStopVal_ATY
            // 
            textBoxCondStopVal_ATY.BackColor = SystemColors.Control;
            textBoxCondStopVal_ATY.BorderStyle = BorderStyle.None;
            textBoxCondStopVal_ATY.Location = new Point(202, 39);
            textBoxCondStopVal_ATY.Name = "textBoxCondStopVal_ATY";
            textBoxCondStopVal_ATY.Size = new Size(125, 20);
            textBoxCondStopVal_ATY.TabIndex = 2;
            textBoxCondStopVal_ATY.Text = "Конец шага:";
            // 
            // textBoxStartValue_ATY
            // 
            textBoxStartValue_ATY.BackColor = SystemColors.Window;
            textBoxStartValue_ATY.Location = new Point(24, 71);
            textBoxStartValue_ATY.Name = "textBoxStartValue_ATY";
            textBoxStartValue_ATY.Size = new Size(125, 27);
            textBoxStartValue_ATY.TabIndex = 1;
            textBoxStartValue_ATY.Text = "-5";
            textBoxStartValue_ATY.KeyPress += textBoxStartValue_ATY_KeyPress;
            // 
            // textBoxCondStartVal_ATY
            // 
            textBoxCondStartVal_ATY.BackColor = SystemColors.Control;
            textBoxCondStartVal_ATY.BorderStyle = BorderStyle.None;
            textBoxCondStartVal_ATY.Location = new Point(24, 39);
            textBoxCondStartVal_ATY.Name = "textBoxCondStartVal_ATY";
            textBoxCondStartVal_ATY.Size = new Size(142, 20);
            textBoxCondStartVal_ATY.TabIndex = 0;
            textBoxCondStartVal_ATY.Text = "Старт шага:";
            // 
            // buttonDone_ATY
            // 
            buttonDone_ATY.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_ATY.Location = new Point(426, 340);
            buttonDone_ATY.Name = "buttonDone_ATY";
            buttonDone_ATY.Size = new Size(96, 85);
            buttonDone_ATY.TabIndex = 6;
            buttonDone_ATY.Text = "Выполнить";
            buttonDone_ATY.UseVisualStyleBackColor = false;
            buttonDone_ATY.Click += buttonDone_ATY_Click;
            // 
            // buttonHelp_ATY
            // 
            buttonHelp_ATY.BackColor = Color.Blue;
            buttonHelp_ATY.Location = new Point(324, 340);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(96, 85);
            buttonHelp_ATY.TabIndex = 6;
            buttonHelp_ATY.Text = "Справка";
            buttonHelp_ATY.UseVisualStyleBackColor = false;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            // 
            // groupBoxRes_ATY
            // 
            groupBoxRes_ATY.Controls.Add(chartFunction_ATY);
            groupBoxRes_ATY.Controls.Add(textBoxRes);
            groupBoxRes_ATY.Controls.Add(dataGridViewFunction_ATY);
            groupBoxRes_ATY.Location = new Point(528, 23);
            groupBoxRes_ATY.Name = "groupBoxRes_ATY";
            groupBoxRes_ATY.Size = new Size(587, 402);
            groupBoxRes_ATY.TabIndex = 7;
            groupBoxRes_ATY.TabStop = false;
            groupBoxRes_ATY.Text = "Вывод данных";
            // 
            // chartFunction_ATY
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ATY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_ATY.Legends.Add(legend1);
            chartFunction_ATY.Location = new Point(180, 27);
            chartFunction_ATY.Name = "chartFunction_ATY";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_ATY.Series.Add(series1);
            chartFunction_ATY.Size = new Size(401, 375);
            chartFunction_ATY.TabIndex = 2;
            chartFunction_ATY.Text = "chart1";
            chartFunction_ATY.MouseDown += chartFunction_ATY_MouseDown;
            chartFunction_ATY.MouseEnter += chartFunction_ATY_MouseEnter;
            chartFunction_ATY.MouseLeave += chartFunction_ATY_MouseLeave;
            // 
            // textBoxRes
            // 
            textBoxRes.BackColor = SystemColors.Control;
            textBoxRes.BorderStyle = BorderStyle.None;
            textBoxRes.Location = new Point(6, 26);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(168, 20);
            textBoxRes.TabIndex = 1;
            textBoxRes.Text = "Результат:";
            // 
            // dataGridViewFunction_ATY
            // 
            dataGridViewFunction_ATY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_ATY.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction_ATY.Location = new Point(6, 52);
            dataGridViewFunction_ATY.Name = "dataGridViewFunction_ATY";
            dataGridViewFunction_ATY.RowHeadersVisible = false;
            dataGridViewFunction_ATY.RowHeadersWidth = 51;
            dataGridViewFunction_ATY.Size = new Size(153, 344);
            dataGridViewFunction_ATY.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 75;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 450);
            Controls.Add(groupBoxRes_ATY);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(buttonDone_ATY);
            Controls.Add(groupBoxCondition2_ATY);
            Controls.Add(groupBoxCondition_ATY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Арапов Т.Я.";
            groupBoxCondition_ATY.ResumeLayout(false);
            groupBoxCondition_ATY.PerformLayout();
            groupBoxCondition2_ATY.ResumeLayout(false);
            groupBoxCondition2_ATY.PerformLayout();
            groupBoxRes_ATY.ResumeLayout(false);
            groupBoxRes_ATY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ATY).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_ATY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_ATY;
        private TextBox textBoxTask_ATY;
        private GroupBox groupBoxCondition2_ATY;
        private TextBox textBoxCondStartVal_ATY;
        private TextBox textBoxStartValue_ATY;
        private Button buttonDone_ATY;
        private Button buttonHelp_ATY;
        private TextBox textBoxStopValue_ATY;
        private TextBox textBoxCondStopVal_ATY;
        private GroupBox groupBoxRes_ATY;
        private TextBox textBoxRes;
        private DataGridView dataGridViewFunction_ATY;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ATY;

    }
}
