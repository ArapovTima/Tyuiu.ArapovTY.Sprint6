namespace Tyuiu.ArapovTY.Sprint6.Task0.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_ATY = new GroupBox();
            pictureBoxFormula_ATY = new PictureBox();
            textBoxTask_ATY = new TextBox();
            groupBoxCondition2_ATY = new GroupBox();
            textBoxVarX_ATY = new TextBox();
            textBoxWindow2 = new TextBox();
            groupBoxCondition3_ATY = new GroupBox();
            textBoxResult_ATY = new TextBox();
            textBoxWindow3 = new TextBox();
            buttonDone_ATY = new Button();
            buttonHelp_ATY = new Button();
            groupBoxCondition_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ATY).BeginInit();
            groupBoxCondition2_ATY.SuspendLayout();
            groupBoxCondition3_ATY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_ATY
            // 
            groupBoxCondition_ATY.Controls.Add(pictureBoxFormula_ATY);
            groupBoxCondition_ATY.Controls.Add(textBoxTask_ATY);
            groupBoxCondition_ATY.Location = new Point(12, 12);
            groupBoxCondition_ATY.Name = "groupBoxCondition_ATY";
            groupBoxCondition_ATY.Size = new Size(776, 219);
            groupBoxCondition_ATY.TabIndex = 1;
            groupBoxCondition_ATY.TabStop = false;
            groupBoxCondition_ATY.Text = "Условие";
            // 
            // pictureBoxFormula_ATY
            // 
            pictureBoxFormula_ATY.Image = (Image)resources.GetObject("pictureBoxFormula_ATY.Image");
            pictureBoxFormula_ATY.Location = new Point(389, 26);
            pictureBoxFormula_ATY.Name = "pictureBoxFormula_ATY";
            pictureBoxFormula_ATY.Size = new Size(306, 50);
            pictureBoxFormula_ATY.TabIndex = 2;
            pictureBoxFormula_ATY.TabStop = false;
            // 
            // textBoxTask_ATY
            // 
            textBoxTask_ATY.BackColor = SystemColors.Control;
            textBoxTask_ATY.BorderStyle = BorderStyle.None;
            textBoxTask_ATY.ForeColor = SystemColors.ControlText;
            textBoxTask_ATY.Location = new Point(6, 34);
            textBoxTask_ATY.Name = "textBoxTask_ATY";
            textBoxTask_ATY.Size = new Size(256, 20);
            textBoxTask_ATY.TabIndex = 1;
            textBoxTask_ATY.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxCondition2_ATY
            // 
            groupBoxCondition2_ATY.Controls.Add(textBoxVarX_ATY);
            groupBoxCondition2_ATY.Controls.Add(textBoxWindow2);
            groupBoxCondition2_ATY.Location = new Point(12, 252);
            groupBoxCondition2_ATY.Name = "groupBoxCondition2_ATY";
            groupBoxCondition2_ATY.Size = new Size(450, 125);
            groupBoxCondition2_ATY.TabIndex = 2;
            groupBoxCondition2_ATY.TabStop = false;
            groupBoxCondition2_ATY.Text = "Ввод данных";
            // 
            // textBoxVarX_ATY
            // 
            textBoxVarX_ATY.BackColor = SystemColors.Window;
            textBoxVarX_ATY.Location = new Point(137, 65);
            textBoxVarX_ATY.Name = "textBoxVarX_ATY";
            textBoxVarX_ATY.Size = new Size(125, 27);
            textBoxVarX_ATY.TabIndex = 1;
            textBoxVarX_ATY.KeyPress += textBoxVarX_ATY_KeyPress;
            // 
            // textBoxWindow2
            // 
            textBoxWindow2.BackColor = SystemColors.Control;
            textBoxWindow2.BorderStyle = BorderStyle.None;
            textBoxWindow2.Location = new Point(142, 39);
            textBoxWindow2.Name = "textBoxWindow2";
            textBoxWindow2.Size = new Size(142, 20);
            textBoxWindow2.TabIndex = 0;
            textBoxWindow2.Text = "Переменная X:";
            // 
            // groupBoxCondition3_ATY
            // 
            groupBoxCondition3_ATY.Controls.Add(textBoxResult_ATY);
            groupBoxCondition3_ATY.Controls.Add(textBoxWindow3);
            groupBoxCondition3_ATY.Location = new Point(488, 252);
            groupBoxCondition3_ATY.Name = "groupBoxCondition3_ATY";
            groupBoxCondition3_ATY.Size = new Size(300, 125);
            groupBoxCondition3_ATY.TabIndex = 3;
            groupBoxCondition3_ATY.TabStop = false;
            groupBoxCondition3_ATY.Text = "Вывод данных";
            // 
            // textBoxResult_ATY
            // 
            textBoxResult_ATY.BackColor = SystemColors.Window;
            textBoxResult_ATY.Location = new Point(80, 65);
            textBoxResult_ATY.Name = "textBoxResult_ATY";
            textBoxResult_ATY.Size = new Size(125, 27);
            textBoxResult_ATY.TabIndex = 1;
            // 
            // textBoxWindow3
            // 
            textBoxWindow3.BackColor = SystemColors.Control;
            textBoxWindow3.BorderStyle = BorderStyle.None;
            textBoxWindow3.Location = new Point(94, 39);
            textBoxWindow3.Name = "textBoxWindow3";
            textBoxWindow3.Size = new Size(125, 20);
            textBoxWindow3.TabIndex = 0;
            textBoxWindow3.Text = "Результат:";
            // 
            // buttonDone_ATY
            // 
            buttonDone_ATY.Location = new Point(667, 409);
            buttonDone_ATY.Name = "buttonDone_ATY";
            buttonDone_ATY.Size = new Size(111, 29);
            buttonDone_ATY.TabIndex = 6;
            buttonDone_ATY.Text = "Выполнить";
            buttonDone_ATY.UseVisualStyleBackColor = true;
            buttonDone_ATY.Click += buttonDone_ATY_Click;
            // 
            // buttonHelp_ATY
            // 
            buttonHelp_ATY.Location = new Point(611, 409);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(40, 29);
            buttonHelp_ATY.TabIndex = 6;
            buttonHelp_ATY.Text = "?";
            buttonHelp_ATY.UseVisualStyleBackColor = true;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(buttonDone_ATY);
            Controls.Add(groupBoxCondition3_ATY);
            Controls.Add(groupBoxCondition2_ATY);
            Controls.Add(groupBoxCondition_ATY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 15 | Арапов Т.Я.";
            groupBoxCondition_ATY.ResumeLayout(false);
            groupBoxCondition_ATY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_ATY).EndInit();
            groupBoxCondition2_ATY.ResumeLayout(false);
            groupBoxCondition2_ATY.PerformLayout();
            groupBoxCondition3_ATY.ResumeLayout(false);
            groupBoxCondition3_ATY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_ATY;
        private TextBox textBoxTask_ATY;
        private GroupBox groupBoxCondition2_ATY;
        private TextBox textBoxWindow2;
        private GroupBox groupBoxCondition3_ATY;
        private TextBox textBoxVarX_ATY;
        private TextBox textBoxResult_ATY;
        private TextBox textBoxWindow3;
        private PictureBox pictureBoxFormula_ATY;
        private Button buttonDone_ATY;
        private Button buttonHelp_ATY;
    }
}
