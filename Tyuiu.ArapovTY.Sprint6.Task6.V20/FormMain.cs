using Tyuiu.ArapovTY.Sprint6.Task6.V20.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpenFile_ATY_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ATY.ShowDialog();
            openFilePath = openFileDialogTask_ATY.FileName;
            textBoxLoadFromFile_ATY.Text = File.ReadAllText(openFilePath);
            groupBoxRes_ATY.Text = groupBoxRes_ATY.Text + " " + openFileDialogTask_ATY.FileName;
            buttonDone_ATY.Enabled = true;
        }

        private void buttonDone_ATY_Click(object sender, EventArgs e)
        {
            toolTipTask_ATY.ToolTipTitle = "Выполнить";
            textBoxResult_ATY.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_ATY.ToolTipTitle = "Открыть файл";
        }

        private void buttonHelp_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_ATY.ToolTipTitle = "Справка";
        }
    }
}
