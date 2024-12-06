using Tyuiu.ArapovTY.Sprint6.Task0.V15.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task0.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_ATY_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_ATY.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_ATY.Text)));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 ||  e.KeyChar >= 58) && (e.KeyChar != ',') &&  (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 0 выполнил студент группы ј—ќи”б-24-1 јрапов “имофей яковлевич", "—правка");
        }
    }
}
