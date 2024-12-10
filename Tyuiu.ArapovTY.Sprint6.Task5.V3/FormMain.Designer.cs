namespace Tyuiu.ArapovTY.Sprint6.Task5.V3
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
            chartFunction_ATY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave_ATY = new Button();
            groupBoxRes_ATY = new GroupBox();
            dataGridViewResult_ATY = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            groupBoxCondition_ATY.SuspendLayout();
            groupBoxCondition2_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ATY).BeginInit();
            groupBoxRes_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ATY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_ATY
            // 
            groupBoxCondition_ATY.Controls.Add(textBoxTask_ATY);
            groupBoxCondition_ATY.Location = new Point(12, 12);
            groupBoxCondition_ATY.Name = "groupBoxCondition_ATY";
            groupBoxCondition_ATY.Size = new Size(496, 117);
            groupBoxCondition_ATY.TabIndex = 1;
            groupBoxCondition_ATY.TabStop = false;
            groupBoxCondition_ATY.Text = "Условие";
            // 
            // textBoxTask_ATY
            // 
            textBoxTask_ATY.BackColor = SystemColors.Control;
            textBoxTask_ATY.BorderStyle = BorderStyle.None;
            textBoxTask_ATY.ForeColor = SystemColors.ControlText;
            textBoxTask_ATY.Location = new Point(6, 26);
            textBoxTask_ATY.Multiline = true;
            textBoxTask_ATY.Name = "textBoxTask_ATY";
            textBoxTask_ATY.Size = new Size(484, 104);
            textBoxTask_ATY.TabIndex = 1;
            textBoxTask_ATY.Text = "Прочитать данные из файла InPutFileTask5.txt. \r\nВывести в DataGridView все вещественные значения.\r\nПостроить диаграмму по этим значениям.";
            // 
            // groupBoxCondition2_ATY
            // 
            groupBoxCondition2_ATY.Controls.Add(textBoxStopValue_ATY);
            groupBoxCondition2_ATY.Controls.Add(textBoxCondStopVal_ATY);
            groupBoxCondition2_ATY.Controls.Add(textBoxStartValue_ATY);
            groupBoxCondition2_ATY.Controls.Add(textBoxCondStartVal_ATY);
            groupBoxCondition2_ATY.Location = new Point(538, 12);
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
            buttonDone_ATY.Location = new Point(891, 25);
            buttonDone_ATY.Name = "buttonDone_ATY";
            buttonDone_ATY.Size = new Size(134, 85);
            buttonDone_ATY.TabIndex = 6;
            buttonDone_ATY.Text = "Выполнить";
            buttonDone_ATY.UseVisualStyleBackColor = false;
            buttonDone_ATY.Click += buttonDone_ATY_Click;
            // 
            // buttonHelp_ATY
            // 
            buttonHelp_ATY.BackColor = Color.Blue;
            buttonHelp_ATY.Location = new Point(1237, 25);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(160, 85);
            buttonHelp_ATY.TabIndex = 6;
            buttonHelp_ATY.Text = "Справка";
            buttonHelp_ATY.UseVisualStyleBackColor = false;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            // 
            // chartFunction_ATY
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ATY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_ATY.Legends.Add(legend1);
            chartFunction_ATY.Location = new Point(355, 148);
            chartFunction_ATY.Name = "chartFunction_ATY";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_ATY.Series.Add(series1);
            chartFunction_ATY.Size = new Size(1057, 371);
            chartFunction_ATY.TabIndex = 2;
            chartFunction_ATY.Text = "chart1";
            // 
            // buttonSave_ATY
            // 
            buttonSave_ATY.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_ATY.Location = new Point(1056, 25);
            buttonSave_ATY.Name = "buttonSave_ATY";
            buttonSave_ATY.Size = new Size(148, 87);
            buttonSave_ATY.TabIndex = 8;
            buttonSave_ATY.Text = "Открыть файл";
            buttonSave_ATY.UseVisualStyleBackColor = false;
            buttonSave_ATY.Click += buttonSave_ATY_Click;
            // 
            // groupBoxRes_ATY
            // 
            groupBoxRes_ATY.Controls.Add(dataGridViewResult_ATY);
            groupBoxRes_ATY.Controls.Add(dataGridView1);
            groupBoxRes_ATY.Location = new Point(18, 135);
            groupBoxRes_ATY.Name = "groupBoxRes_ATY";
            groupBoxRes_ATY.Size = new Size(331, 390);
            groupBoxRes_ATY.TabIndex = 7;
            groupBoxRes_ATY.TabStop = false;
            groupBoxRes_ATY.Text = "Вывод данных";
            // 
            // dataGridViewResult_ATY
            // 
            dataGridViewResult_ATY.BackgroundColor = SystemColors.Control;
            dataGridViewResult_ATY.BorderStyle = BorderStyle.None;
            dataGridViewResult_ATY.ColumnHeadersHeight = 29;
            dataGridViewResult_ATY.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewResult_ATY.Location = new Point(6, 35);
            dataGridViewResult_ATY.Name = "dataGridViewResult_ATY";
            dataGridViewResult_ATY.RowHeadersVisible = false;
            dataGridViewResult_ATY.RowHeadersWidth = 51;
            dataGridViewResult_ATY.Size = new Size(319, 349);
            dataGridViewResult_ATY.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(388, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 616);
            Controls.Add(buttonSave_ATY);
            Controls.Add(groupBoxRes_ATY);
            Controls.Add(chartFunction_ATY);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(buttonDone_ATY);
            Controls.Add(groupBoxCondition2_ATY);
            Controls.Add(groupBoxCondition_ATY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 3 | Арапов Т.Я.";
            groupBoxCondition_ATY.ResumeLayout(false);
            groupBoxCondition_ATY.PerformLayout();
            groupBoxCondition2_ATY.ResumeLayout(false);
            groupBoxCondition2_ATY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ATY).EndInit();
            groupBoxRes_ATY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ATY).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ATY;
        private Button buttonSave_ATY;
        private GroupBox groupBoxRes_ATY;
        private DataGridView dataGridViewResult_ATY;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dataGridView1;
    }
}
