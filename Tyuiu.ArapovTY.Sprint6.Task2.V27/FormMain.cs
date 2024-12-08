using Tyuiu.ArapovTY.Sprint6.Task2.V27.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task2.V27
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
                this.chartFunction_ATY.Titles.Add("√рафик функции (2x-3)/(cosx-2x)+5x-sinx");
                this.chartFunction_ATY.ChartAreas[0].AxisX.Title = "ќсь X";
                this.chartFunction_ATY.ChartAreas[0].AxisY.Title = "ќсь Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_ATY.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_ATY.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_ATY_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ATY.BackColor = Color.Red;
        }

        private void chartFunction_ATY_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ATY.BackColor = Color.Green;
        }

        private void chartFunction_ATY_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_ATY.BackColor = Color.Blue;
        }

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 2 выполнил студент группы ј—ќи”б-24-1 јрапов “имофей яковлевич", "—правка");
        }

        private void textBoxStopValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxStartValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
