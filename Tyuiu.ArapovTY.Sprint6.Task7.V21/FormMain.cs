using Tyuiu.ArapovTY.Sprint6.Task7.V21.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task7.V21
{
    public partial class FormMainLoad_ATY : Form
    {
        public FormMainLoad_ATY()
        {
            InitializeComponent();
            openFileDialogTask_ATY.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_ATY.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_ATY_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ATY.ShowDialog();
            openFilePath = openFileDialogTask_ATY.FileName;
            rows = 10;
            columns = 10;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInMatrix_ATY.ColumnCount = columns;
            dataGridViewInMatrix_ATY.RowCount = rows;
            dataGridViewOutMatrix_ATY.ColumnCount = columns;
            dataGridViewOutMatrix_ATY.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_ATY.Columns[i].Width = 50;
                dataGridViewOutMatrix_ATY.Columns[i].Width = 50;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_ATY.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_ATY.Enabled = true;
        }

        private void buttonDone_ATY_Click(object sender, EventArgs e)
        {
            int[,] arraysValues = new int[rows, columns];
            arraysValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_ATY.Rows[r].Cells[c].Value = arraysValues[r, c];
                }
            }

            buttonSaveFile_ATY.Enabled = true;
        }

        private void buttonSaveFile_ATY_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ATY.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_ATY.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ATY.ShowDialog();

            string path = saveFileDialogMatrix_ATY.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_ATY.RowCount;
            int columns = dataGridViewOutMatrix_ATY.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_ATY.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_ATY.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_ATY.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_ATY.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_ATY.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_ATY.ToolTipTitle = "Справка";
        }

        private void FormMainLoad_ATY_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_ATY.ColumnCount = 50;
            dataGridViewInMatrix_ATY.RowCount = 50;
            dataGridViewOutMatrix_ATY.ColumnCount = 50;
            dataGridViewOutMatrix_ATY.ColumnCount = 50;

            //panelLeft.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_ATY.Columns[i].Width = 25;
                dataGridViewOutMatrix_ATY.Columns[i].Width = 25;
            }
        }
    }
}
