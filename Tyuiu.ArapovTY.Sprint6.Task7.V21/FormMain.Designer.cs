namespace Tyuiu.ArapovTY.Sprint6.Task7.V21
{
    partial class FormMainLoad_ATY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainLoad_ATY));
            groupBoxCondition_ATY = new GroupBox();
            textBoxCond_ATY = new TextBox();
            groupBoxResult_ATY = new GroupBox();
            dataGridViewInMatrix_ATY = new DataGridView();
            groupBoxRes_ATY = new GroupBox();
            dataGridViewOutMatrix_ATY = new DataGridView();
            openFileDialogTask_ATY = new OpenFileDialog();
            toolTipTask_ATY = new ToolTip(components);
            buttonOpenFile_ATY = new Button();
            buttonDone_ATY = new Button();
            buttonHelp_ATY = new Button();
            buttonSaveFile_ATY = new Button();
            saveFileDialogMatrix_ATY = new SaveFileDialog();
            groupBoxResult_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_ATY).BeginInit();
            groupBoxRes_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_ATY).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_ATY
            // 
            groupBoxCondition_ATY.Location = new Point(7, 66);
            groupBoxCondition_ATY.Name = "groupBoxCondition_ATY";
            groupBoxCondition_ATY.Size = new Size(791, 77);
            groupBoxCondition_ATY.TabIndex = 1;
            groupBoxCondition_ATY.TabStop = false;
            groupBoxCondition_ATY.Text = "Условие";
            // 
            // textBoxCond_ATY
            // 
            textBoxCond_ATY.BackColor = SystemColors.Control;
            textBoxCond_ATY.BorderStyle = BorderStyle.None;
            textBoxCond_ATY.Location = new Point(7, 92);
            textBoxCond_ATY.Multiline = true;
            textBoxCond_ATY.Name = "textBoxCond_ATY";
            textBoxCond_ATY.Size = new Size(1122, 94);
            textBoxCond_ATY.TabIndex = 0;
            textBoxCond_ATY.Text = resources.GetString("textBoxCond_ATY.Text");
            // 
            // groupBoxResult_ATY
            // 
            groupBoxResult_ATY.Controls.Add(dataGridViewInMatrix_ATY);
            groupBoxResult_ATY.Location = new Point(7, 196);
            groupBoxResult_ATY.Name = "groupBoxResult_ATY";
            groupBoxResult_ATY.Size = new Size(554, 281);
            groupBoxResult_ATY.TabIndex = 2;
            groupBoxResult_ATY.TabStop = false;
            groupBoxResult_ATY.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_ATY
            // 
            dataGridViewInMatrix_ATY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_ATY.ColumnHeadersVisible = false;
            dataGridViewInMatrix_ATY.Location = new Point(5, 21);
            dataGridViewInMatrix_ATY.Name = "dataGridViewInMatrix_ATY";
            dataGridViewInMatrix_ATY.RowHeadersVisible = false;
            dataGridViewInMatrix_ATY.RowHeadersWidth = 51;
            dataGridViewInMatrix_ATY.Size = new Size(543, 260);
            dataGridViewInMatrix_ATY.TabIndex = 0;
            // 
            // groupBoxRes_ATY
            // 
            groupBoxRes_ATY.Controls.Add(dataGridViewOutMatrix_ATY);
            groupBoxRes_ATY.Location = new Point(586, 196);
            groupBoxRes_ATY.Name = "groupBoxRes_ATY";
            groupBoxRes_ATY.Size = new Size(519, 289);
            groupBoxRes_ATY.TabIndex = 3;
            groupBoxRes_ATY.TabStop = false;
            groupBoxRes_ATY.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_ATY
            // 
            dataGridViewOutMatrix_ATY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_ATY.ColumnHeadersVisible = false;
            dataGridViewOutMatrix_ATY.Location = new Point(6, 21);
            dataGridViewOutMatrix_ATY.Name = "dataGridViewOutMatrix_ATY";
            dataGridViewOutMatrix_ATY.RowHeadersVisible = false;
            dataGridViewOutMatrix_ATY.RowHeadersWidth = 51;
            dataGridViewOutMatrix_ATY.Size = new Size(507, 260);
            dataGridViewOutMatrix_ATY.TabIndex = 0;
            // 
            // openFileDialogTask_ATY
            // 
            openFileDialogTask_ATY.FileName = "openFileDialog1";
            // 
            // toolTipTask_ATY
            // 
            toolTipTask_ATY.IsBalloon = true;
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
            toolTipTask_ATY.SetToolTip(buttonDone_ATY, "Меняет в восьмом столбце значения не равные 5 на -1\r\n");
            buttonDone_ATY.UseVisualStyleBackColor = true;
            buttonDone_ATY.Click += buttonDone_ATY_Click;
            buttonDone_ATY.MouseEnter += buttonDone_ATY_MouseEnter;
            // 
            // buttonHelp_ATY
            // 
            buttonHelp_ATY.Image = (Image)resources.GetObject("buttonHelp_ATY.Image");
            buttonHelp_ATY.Location = new Point(1032, 7);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(97, 58);
            buttonHelp_ATY.TabIndex = 6;
            toolTipTask_ATY.SetToolTip(buttonHelp_ATY, "Показать информацию об ученике\r\n");
            buttonHelp_ATY.UseVisualStyleBackColor = true;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            buttonHelp_ATY.MouseEnter += buttonHelp_ATY_MouseEnter;
            // 
            // buttonSaveFile_ATY
            // 
            buttonSaveFile_ATY.Image = (Image)resources.GetObject("buttonSaveFile_ATY.Image");
            buttonSaveFile_ATY.Location = new Point(193, 12);
            buttonSaveFile_ATY.Name = "buttonSaveFile_ATY";
            buttonSaveFile_ATY.Size = new Size(71, 48);
            buttonSaveFile_ATY.TabIndex = 7;
            toolTipTask_ATY.SetToolTip(buttonSaveFile_ATY, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_ATY.UseVisualStyleBackColor = true;
            buttonSaveFile_ATY.Click += buttonSaveFile_ATY_Click;
            buttonSaveFile_ATY.MouseEnter += buttonSaveFile_ATY_MouseEnter;
            // 
            // FormMainLoad_ATY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 489);
            Controls.Add(buttonSaveFile_ATY);
            Controls.Add(textBoxCond_ATY);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(buttonDone_ATY);
            Controls.Add(buttonOpenFile_ATY);
            Controls.Add(groupBoxRes_ATY);
            Controls.Add(groupBoxResult_ATY);
            Controls.Add(groupBoxCondition_ATY);
            Name = "FormMainLoad_ATY";
            Text = "Спринт 6 | Таск 7 | Вариант 21 | Арапов Т.Я.";
            Load += FormMainLoad_ATY_Load;
            groupBoxResult_ATY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_ATY).EndInit();
            groupBoxRes_ATY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_ATY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCondition_ATY;
        private TextBox textBoxCond_ATY;
        private GroupBox groupBoxResult_ATY;
        private GroupBox groupBoxRes_ATY;
        private OpenFileDialog openFileDialogTask_ATY;
        private ToolTip toolTipTask_ATY;
        private Button buttonOpenFile_ATY;
        private Button buttonDone_ATY;
        private Button buttonHelp_ATY;
        private Button buttonSaveFile_ATY;
        private SaveFileDialog saveFileDialogMatrix_ATY;
        private DataGridView dataGridViewInMatrix_ATY;
        private DataGridView dataGridViewOutMatrix_ATY;
    }
}
