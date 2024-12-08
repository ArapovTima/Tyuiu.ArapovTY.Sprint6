namespace Tyuiu.ArapovTY.Sprint6.Task1.V5
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
            textBoxTask_ATY = new TextBox();
            groupBoxCondition2_ATY = new GroupBox();
            textBoxStopValue_ATY = new TextBox();
            textBoxCondStopVal_ATY = new TextBox();
            textBoxStartValue_ATY = new TextBox();
            textBoxCondStartVal_ATY = new TextBox();
            buttonDone_ATY = new Button();
            buttonHelp_ATY = new Button();
            groupBoxResult_ATY = new GroupBox();
            textBoxResult_ATY = new TextBox();
            textBoxRes_ATY = new TextBox();
            groupBoxCondition_ATY.SuspendLayout();
            groupBoxCondition2_ATY.SuspendLayout();
            groupBoxResult_ATY.SuspendLayout();
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
            textBoxTask_ATY.Text = "Протабулировать функцию y=sin(x)+(cos(2x)/2)-1,5x на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
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
            // groupBoxResult_ATY
            // 
            groupBoxResult_ATY.Controls.Add(textBoxResult_ATY);
            groupBoxResult_ATY.Controls.Add(textBoxRes_ATY);
            groupBoxResult_ATY.Location = new Point(528, 12);
            groupBoxResult_ATY.Name = "groupBoxResult_ATY";
            groupBoxResult_ATY.Size = new Size(260, 413);
            groupBoxResult_ATY.TabIndex = 7;
            groupBoxResult_ATY.TabStop = false;
            groupBoxResult_ATY.Text = "Вывод данных";
            // 
            // textBoxResult_ATY
            // 
            textBoxResult_ATY.BackColor = SystemColors.Control;
            textBoxResult_ATY.BorderStyle = BorderStyle.None;
            textBoxResult_ATY.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_ATY.Location = new Point(6, 62);
            textBoxResult_ATY.Multiline = true;
            textBoxResult_ATY.Name = "textBoxResult_ATY";
            textBoxResult_ATY.Size = new Size(248, 345);
            textBoxResult_ATY.TabIndex = 1;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult_ATY);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(buttonDone_ATY);
            Controls.Add(groupBoxCondition2_ATY);
            Controls.Add(groupBoxCondition_ATY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 5 | Арапов Т.Я.";
            groupBoxCondition_ATY.ResumeLayout(false);
            groupBoxCondition_ATY.PerformLayout();
            groupBoxCondition2_ATY.ResumeLayout(false);
            groupBoxCondition2_ATY.PerformLayout();
            groupBoxResult_ATY.ResumeLayout(false);
            groupBoxResult_ATY.PerformLayout();
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
        private GroupBox groupBoxResult_ATY;
        private TextBox textBoxRes_ATY;
        private TextBox textBoxResult_ATY;
    }
}
