using Tyuiu.ArapovTY.Sprint6.Task1.V5.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task1.V5
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
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_ATY.Text = "";
                textBoxResult_ATY.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_ATY.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_ATY.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_ATY.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_ATY.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 1 выполнил студент группы ј—ќи”б-24-1 јрапов “имофей яковлевич", "—правка");
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
