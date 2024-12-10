using Tyuiu.ArapovTY.Sprint6.Task4.V14.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_ATY_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_ATY.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_ATY.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_ATY.ChartAreas[0].AxisX.Title = "ќсь X";
                this.chartFunction_ATY.ChartAreas[0].AxisY.Title = "ќсь Y";
                textBoxResult_ATY.Text = "";
                chartFunction_ATY.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_ATY.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_ATY.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_ATY_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.V14.txt" });
                File.WriteAllText(path, textBoxResult_ATY.Text);
                DialogResult dialogResult = MessageBox.Show("‘айл " + path + " сохранЄн успешно!\n ќткрыть его в блокноте?", "—ообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("—бой при сохранении файла", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 4 выполнил студент группы ј—ќи”б-24-1 јрапов “имофей яковлевич", "—правка");
        }

        private void textBoxStartValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
