using PassiveElement;
using System.ComponentModel;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
		/// Cписок элементов
		/// </summary>
		private BindingList<PassiveElementBase> _elementsList = new();

        /// <summary>
        /// Отфильтрованый список
        /// </summary>
        private BindingList<PassiveElementBase> _filteredList = new();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Выделение памяти
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
        /// Добавление нового элемента.
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