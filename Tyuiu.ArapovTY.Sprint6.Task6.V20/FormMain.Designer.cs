namespace Tyuiu.ArapovTY.Sprint6.Task6.V20
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_ATY = new GroupBox();
            textBox1 = new TextBox();
            groupBoxResult_ATY = new GroupBox();
            textBoxLoadFromFile_ATY = new TextBox();
            groupBoxRes_ATY = new GroupBox();
            textBoxResult_ATY = new TextBox();
            openFileDialogTask_ATY = new OpenFileDialog();
            toolTipTask_ATY = new ToolTip(components);
            buttonOpenFile_ATY = new Button();
            buttonDone_ATY = new Button();
            buttonHelp_ATY = new Button();
            groupBoxCondition_ATY.SuspendLayout();
            groupBoxResult_ATY.SuspendLayout();
            groupBoxRes_ATY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_ATY
            // 
            groupBoxCondition_ATY.Controls.Add(textBox1);
            groupBoxCondition_ATY.Location = new Point(7, 66);
            groupBoxCondition_ATY.Name = "groupBoxCondition_ATY";
            groupBoxCondition_ATY.Size = new Size(791, 77);
            groupBoxCondition_ATY.TabIndex = 1;
            groupBoxCondition_ATY.TabStop = false;
            groupBoxCondition_ATY.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(0, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(781, 45);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxResult_ATY
            // 
            groupBoxResult_ATY.Controls.Add(textBoxLoadFromFile_ATY);
            groupBoxResult_ATY.Location = new Point(7, 149);
            groupBoxResult_ATY.Name = "groupBoxResult_ATY";
            groupBoxResult_ATY.Size = new Size(387, 289);
            groupBoxResult_ATY.TabIndex = 2;
            groupBoxResult_ATY.TabStop = false;
            groupBoxResult_ATY.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_ATY
            // 
            textBoxLoadFromFile_ATY.Location = new Point(6, 26);
            textBoxLoadFromFile_ATY.Multiline = true;
            textBoxLoadFromFile_ATY.Name = "textBoxLoadFromFile_ATY";
            textBoxLoadFromFile_ATY.Size = new Size(375, 257);
            textBoxLoadFromFile_ATY.TabIndex = 0;
            // 
            // groupBoxRes_ATY
            // 
            groupBoxRes_ATY.Controls.Add(textBoxResult_ATY);
            groupBoxRes_ATY.Location = new Point(400, 149);
            groupBoxRes_ATY.Name = "groupBoxRes_ATY";
            groupBoxRes_ATY.Size = new Size(388, 289);
            groupBoxRes_ATY.TabIndex = 3;
            groupBoxRes_ATY.TabStop = false;
            groupBoxRes_ATY.Text = "Вывод:";
            // 
            // textBoxResult_ATY
            // 
            textBoxResult_ATY.Location = new Point(6, 26);
            textBoxResult_ATY.Multiline = true;
            textBoxResult_ATY.Name = "textBoxResult_ATY";
            textBoxResult_ATY.Size = new Size(382, 257);
            textBoxResult_ATY.TabIndex = 0;
            // 
            // openFileDialogTask_ATY
            // 
            openFileDialogTask_ATY.FileName = "openFileDialog1";
            // 
            // toolTipTask_ATY
            // 
            toolTipTask_ATY.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_ATY.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_ATY
            // 
            buttonOpenFile_ATY.BackColor = SystemColors.Control;
            buttonOpenFile_ATY.Image = (Image)resources.GetObject("buttonOpenFile_ATY.Image");
            buttonOpenFile_ATY.Location = new Point(7, 12);
            buttonOpenFile_ATY.Name = "buttonOpenFile_ATY";
            buttonOpenFile_ATY.Size = new Size(73, 48);
            buttonOpenFile_ATY.TabIndex = 4;
            toolTipTask_ATY.SetToolTip(buttonOpenFile_ATY, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_ATY.UseVisualStyleBackColor = false;
            buttonOpenFile_ATY.Click += buttonOpenFile_ATY_Click;
            buttonOpenFile_ATY.MouseEnter += buttonOpenFile_ATY_MouseEnter;
            // 
            // buttonDone_ATY
            // 
            buttonDone_ATY.Enabled = false;
            buttonDone_ATY.FlatStyle = FlatStyle.Flat;
            buttonDone_ATY.Image = (Image)resources.GetObject("buttonDone_ATY.Image");
            buttonDone_ATY.Location = new Point(100, 12);
            buttonDone_ATY.Name = "buttonDone_ATY";
            buttonDone_ATY.Size = new Size(72, 48);
            buttonDone_ATY.TabIndex = 5;
            toolTipTask_ATY.SetToolTip(buttonDone_ATY, "Выводит каждое второе слово новой строки");
            buttonDone_ATY.UseVisualStyleBackColor = true;
            buttonDone_ATY.Click += buttonDone_ATY_Click;
            // 
            // buttonHelp_ATY
            // 
            buttonHelp_ATY.Image = (Image)resources.GetObject("buttonHelp_ATY.Image");
            buttonHelp_ATY.Location = new Point(717, 12);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(75, 58);
            buttonHelp_ATY.TabIndex = 6;
            toolTipTask_ATY.SetToolTip(buttonHelp_ATY, "Показать информацию об ученике\r\n");
            buttonHelp_ATY.UseVisualStyleBackColor = true;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            buttonHelp_ATY.MouseEnter += buttonHelp_ATY_MouseEnter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(buttonDone_ATY);
            Controls.Add(buttonOpenFile_ATY);
            Controls.Add(groupBoxRes_ATY);
            Controls.Add(groupBoxResult_ATY);
            Controls.Add(groupBoxCondition_ATY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 20 | Арапов Т.Я.";
            groupBoxCondition_ATY.ResumeLayout(false);
            groupBoxCondition_ATY.PerformLayout();
            groupBoxResult_ATY.ResumeLayout(false);
            groupBoxResult_ATY.PerformLayout();
            groupBoxRes_ATY.ResumeLayout(false);
            groupBoxRes_ATY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_ATY;
        private TextBox textBox1;
        private GroupBox groupBoxResult_ATY;
        private GroupBox groupBoxRes_ATY;
        private OpenFileDialog openFileDialogTask_ATY;
        private ToolTip toolTipTask_ATY;
        private Button buttonOpenFile_ATY;
        private Button buttonDone_ATY;
        private Button buttonHelp_ATY;
        private TextBox textBoxLoadFromFile_ATY;
        private TextBox textBoxResult_ATY;
    }
}
