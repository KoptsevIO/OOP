using PassiveElement;
using System.ComponentModel;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
		/// C����� ���������
		/// </summary>
		private BindingList<PassiveElementBase> _elementsList = new();

        /// <summary>
        /// �������������� ������
        /// </summary>
        private BindingList<PassiveElementBase> _filteredList = new();

        /// <summary>
        /// ��������� ����� AddForm.
        /// </summary>
        private AddElementForm _addForm = new AddElementForm();

        /// <summary>
        /// ������� ���������� ��������.
        /// </summary>
        public EventHandler<EventArgs> ElementAdded;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ��������� ������
            _elementsList = new BindingList<PassiveElementBase>();
            CreateTable(_elementsList, dataGridView1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFiterElement(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ���������� ������ ��������.
        /// </summary>
        /// <param name="sender">name.</param>
        /// <param name="e">name.</param>
        private void addElement_Click(object sender, EventArgs e)
        {
            var addElementForm = new AddElementForm();

            addElementForm.ElementAdded += (sender, figureEventArgs) =>
            {
                _elementsList.Add(((ElementEventArgs)figureEventArgs).Element);
            };
            addElementForm.ShowDialog();
        }

        public static void CreateTable(BindingList<PassiveElementBase> elements,
      DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(elements, null);
            dataGridView.DataSource = source;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void deletElement_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    _elementsList.Remove(row.DataBoundItem as PassiveElementBase);

                    _filteredList.Remove(row.DataBoundItem as PassiveElementBase);
                }
            }
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Random random = new Random();
            
        //    ComboBox comboBox = _addForm.choicElementComboBox;            

        //    comboBox.SelectedIndex = random.Next(0, 3);

        //    UserControl userControl = _addForm.userControl;

        //    foreach (TextBox textbox in userControl.Controls.OfType<TextBox>())
        //    {
        //        if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
        //        {
        //            textbox.Text = random.Next(1, 100).ToString();
        //        }
        //    }

        //    Dictionary<string, UserControl> dictionaryUserControl = _addForm.dictionaryUserControl;


        //    var currentFigureControlName = comboBox.SelectedItem.ToString();
        //    var currentFigureControl = dictionaryUserControl[currentFigureControlName];
        //    var eventArgs = new ElementEventArgs(((IAddElement)currentFigureControl).AddElement());
        //    ElementAdded?.Invoke(this, eventArgs);
        //    //DialogResult = DialogResult.OK;

        //    _addForm.ElementAdded += (sender, figureEventArgs) =>
        //    {
        //        _elementsList.Add(((ElementEventArgs)figureEventArgs).Element);
        //    };

        //}
    }
}