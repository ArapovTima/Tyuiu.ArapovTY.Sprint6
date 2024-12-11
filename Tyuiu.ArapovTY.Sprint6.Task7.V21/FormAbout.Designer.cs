namespace Tyuiu.ArapovTY.Sprint6.Task7.V21
{
    partial class FormAbout
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
            textBoxInfo_ATY = new TextBox();
            buttonOK_ATY = new Button();
            SuspendLayout();
            // 
            // textBoxInfo_ATY
            // 
            textBoxInfo_ATY.Location = new Point(1, 5);
            textBoxInfo_ATY.Multiline = true;
            textBoxInfo_ATY.Name = "textBoxInfo_ATY";
            textBoxInfo_ATY.Size = new Size(441, 213);
            textBoxInfo_ATY.TabIndex = 0;
            textBoxInfo_ATY.Text = "Разработчик: Арапов Тимофей Яковлевич\r\nГруппа: АСОиУб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\n\r\nТюменский Индустриальный университет\r\nВысшая школа цифровых технологий";
            // 
            // buttonOK_ATY
            // 
            buttonOK_ATY.Location = new Point(328, 224);
            buttonOK_ATY.Name = "buttonOK_ATY";
            buttonOK_ATY.Size = new Size(94, 29);
            buttonOK_ATY.TabIndex = 1;
            buttonOK_ATY.Text = "OK";
            buttonOK_ATY.UseVisualStyleBackColor = true;
            buttonOK_ATY.Click += buttonOK_ATY_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 264);
            Controls.Add(buttonOK_ATY);
            Controls.Add(textBoxInfo_ATY);
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_ATY;
        private Button buttonOK_ATY;
    }
}