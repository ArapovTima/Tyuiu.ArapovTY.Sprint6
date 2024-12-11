using System.Drawing.Drawing2D;
using Tyuiu.ArapovTY.Sprint6.Task3.V29.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -2, -13, -15, -9, -17 },
                                     { 13, -20, -15, 27, 18 },
                                     { -12, -1, -20, 13, 0 },
                                     { 15, 32, 18, -12, -18 },
                                     { 16, 5, 3, -5, -8 } };

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 3 выполнил студент группы ј—ќи”б-24-1 јрапов “имофей яковлевич", "—правка");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewRes_ATY.ColumnCount = columns;
            dataGridViewRes_ATY.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_ATY.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_ATY.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_ATY_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_ATY.ColumnCount = columns;
            dataGridViewResult_ATY.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_ATY.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_ATY.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}
