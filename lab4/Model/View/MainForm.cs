namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFiterElement(object sender, EventArgs e)
        {

        }

        private void addElement_Click(object sender, EventArgs e)
        {
            var addElementForm = new AddElementForm();

            //addElementForm.FigureAdded += (sender, figureEventArgs) =>
            //{
            //    _figureList.Add(((FigureEventArgs)figureEventArgs).Figure);
            //};
            addElementForm.ShowDialog();
        }

        private void deletElement_Click(object sender, EventArgs e)
        {

        }

        private void buttonFilterElement_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }
    }
}