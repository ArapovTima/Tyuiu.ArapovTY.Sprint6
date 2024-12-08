namespace Tyuiu.ArapovTY.Sprint6.Task3.V29
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
            groupBoxCondition_ATY = new GroupBox();
            dataGridViewRes_ATY = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            textBoxTask_ATY = new TextBox();
            buttonDone_ATY = new Button();
            buttonHelp_ATY = new Button();
            groupBoxResult_ATY = new GroupBox();
            textBoxRes_ATY = new TextBox();
            textBoxResult_ATY = new TextBox();
            groupBoxCondition_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_ATY).BeginInit();
            groupBoxResult_ATY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_ATY
            // 
            groupBoxCondition_ATY.Controls.Add(dataGridViewRes_ATY);
            groupBoxCondition_ATY.Controls.Add(textBoxTask_ATY);
            groupBoxCondition_ATY.Location = new Point(12, 12);
            groupBoxCondition_ATY.Name = "groupBoxCondition_ATY";
            groupBoxCondition_ATY.Size = new Size(546, 426);
            groupBoxCondition_ATY.TabIndex = 1;
            groupBoxCondition_ATY.TabStop = false;
            groupBoxCondition_ATY.Text = "Условие";
            // 
            // dataGridViewRes_ATY
            // 
            dataGridViewRes_ATY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_ATY.ColumnHeadersVisible = false;
            dataGridViewRes_ATY.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewRes_ATY.Location = new Point(45, 153);
            dataGridViewRes_ATY.Name = "dataGridViewRes_ATY";
            dataGridViewRes_ATY.RowHeadersVisible = false;
            dataGridViewRes_ATY.RowHeadersWidth = 51;
            dataGridViewRes_ATY.Size = new Size(421, 254);
            dataGridViewRes_ATY.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Число";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
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
            textBoxTask_ATY.Text = "Дан массив 5 на 5 элементов.\r\nВыполнить сортировку по возрастанию в пятом столбце.\r\nРезультат вывести в DataGridView.\r\n\r\n";
            // 
            // buttonDone_ATY
            // 
            buttonDone_ATY.BackColor = Color.White;
            buttonDone_ATY.Location = new Point(649, 402);
            buttonDone_ATY.Name = "buttonDone_ATY";
            buttonDone_ATY.Size = new Size(139, 36);
            buttonDone_ATY.TabIndex = 6;
            buttonDone_ATY.Text = "Выполнить";
            buttonDone_ATY.UseVisualStyleBackColor = false;
            buttonDone_ATY.Click += buttonDone_ATY_Click;
            // 
            // buttonHelp_ATY
            // 
            buttonHelp_ATY.BackColor = Color.White;
            buttonHelp_ATY.Location = new Point(586, 402);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(57, 36);
            buttonHelp_ATY.TabIndex = 6;
            buttonHelp_ATY.Text = "?";
            buttonHelp_ATY.UseVisualStyleBackColor = false;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            // 
            // groupBoxResult_ATY
            // 
            groupBoxResult_ATY.Controls.Add(textBoxResult_ATY);
            groupBoxResult_ATY.Controls.Add(textBoxRes_ATY);
            groupBoxResult_ATY.Location = new Point(564, 12);
            groupBoxResult_ATY.Name = "groupBoxResult_ATY";
            groupBoxResult_ATY.Size = new Size(224, 384);
            groupBoxResult_ATY.TabIndex = 7;
            groupBoxResult_ATY.TabStop = false;
            groupBoxResult_ATY.Text = "Вывод данных";
            // 
            // textBoxRes_ATY
            // 
            textBoxRes_ATY.BackColor = SystemColors.Control;
            textBoxRes_ATY.BorderStyle = BorderStyle.None;
            textBoxRes_ATY.Location = new Point(6, 36);
            textBoxRes_ATY.Name = "textBoxRes_ATY";
            textBoxRes_ATY.Size = new Size(163, 20);
            textBoxRes_ATY.TabIndex = 0;
            textBoxRes_ATY.Text = "Результат:";
            // 
            // textBoxResult_ATY
            // 
            textBoxResult_ATY.Location = new Point(6, 62);
            textBoxResult_ATY.Multiline = true;
            textBoxResult_ATY.Name = "textBoxResult_ATY";
            textBoxResult_ATY.Size = new Size(212, 316);
            textBoxResult_ATY.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult_ATY);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(buttonDone_ATY);
            Controls.Add(groupBoxCondition_ATY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Арапов Т.Я.";
            Load += FormMain_Load;
            groupBoxCondition_ATY.ResumeLayout(false);
            groupBoxCondition_ATY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_ATY).EndInit();
            groupBoxResult_ATY.ResumeLayout(false);
            groupBoxResult_ATY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_ATY;
        private TextBox textBoxTask_ATY;
        private Button buttonDone_ATY;
        private Button buttonHelp_ATY;
        private GroupBox groupBoxResult_ATY;
        private TextBox textBoxRes_ATY;
        private DataGridView dataGridViewRes_ATY;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBoxResult_ATY;
    }
}
