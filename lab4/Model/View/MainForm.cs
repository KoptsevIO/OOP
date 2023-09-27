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

        /// <summary>
        /// Экземпляр формы AddForm.
        /// </summary>
        private AddElementForm _addForm = new AddElementForm();

        /// <summary>
        /// Событие добавления элемента.
        /// </summary>
        public EventHandler<EventArgs> ElementAdded;

        /// <summary>
        /// Основная форма.
        /// </summary>
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
            var newFilterForm = new FilterForm(_elementsList);
            newFilterForm.Show();
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
            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    _elementsList.Remove(row.DataBoundItem as PassiveElementBase);

                    _filteredList.Remove(row.DataBoundItem as PassiveElementBase);
                }
            }
        }

        private void buttonFilterElement_Click(object sender,
            EventArgs e)
        {
            var newFilterForm = new FilterForm(_elementsList);
            newFilterForm.Show();
            newFilterForm.ElementFiltered += 
                (sender, elementEventArgs) =>
            {
                dataGridView1.DataSource = 
                ((ElementListEventArgs)elementEventArgs).ElementList;

                _filteredList = 
                ((ElementListEventArgs)elementEventArgs).ElementList;
            };
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

    }
}