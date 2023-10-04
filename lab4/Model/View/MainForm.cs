using PassiveElement;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace View
{
    /// <summary>
    /// MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
		/// C����� ���������.
		/// </summary>
		private BindingList<PassiveElementBase> _elementsList = new();

        /// <summary>
        /// �������������� ������.
        /// </summary>
        private BindingList<PassiveElementBase> _filteredList = new();


        /// <summary>
        /// ������� ���������� ��������.
        /// </summary>
        private EventHandler<EventArgs> ElementAdded;

        /// <summary>
        /// �������� �����.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ��� ������.
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<PassiveElementBase>));

        /// <summary>
        /// ��������� ������.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _elementsList = new BindingList<PassiveElementBase>();
            CreateTable(_elementsList, dataGridView1);
        }

        /// <summary>
        /// ������ ����������.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void ButtonFiterElement(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(_elementsList);
            newFilterForm.Show();
        }

        /// <summary>
        /// ���������� ������ ��������.
        /// </summary>
        /// <param name="sender">name.</param>
        /// <param name="e">name.</param>
        private void AddElement_Click(object sender, EventArgs e)
        {
            var addElementForm = new AddElementForm();

            addElementForm.ElementAdded += (sender, elementEventArgs) =>
            {
                _elementsList.Add(((ElementEventArgs)elementEventArgs).
                    Element);
            };
            addElementForm.ShowDialog();
        }

        /// <summary>
        /// �������� ������� DataGrid.
        /// </summary>
        /// <param name="elements">elements.</param>
        /// <param name="dataGridView">dataGrid.</param>
        public static void CreateTable(BindingList<PassiveElementBase>
            elements, DataGridView dataGridView)
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

        /// <summary>
        /// ������ �������� ���������.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void DeletElement_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    dataGridView1.SelectedRows)
                {
                    _elementsList.Remove(row.DataBoundItem as PassiveElementBase);
                    _filteredList.Remove(row.DataBoundItem as PassiveElementBase);
                }
            }
        }

        /// <summary>
        /// ������ ����������.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void ButtonFilterElement_Click(object sender,
            EventArgs e)
        {
            var newFilterForm = new FilterForm(_elementsList);
            newFilterForm.Show();
            newFilterForm.ElementFiltered += (sender,
                elementEventArgs) =>
            {
                dataGridView1.DataSource = ((ElementListEventArgs)
                elementEventArgs).ElementList;

                _filteredList = ((ElementListEventArgs)
                elementEventArgs).ElementList;
            };
        }

        /// <summary>
        /// �������� ������ ���������.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void ButtonDeleteElements_Click(object sender,
            EventArgs e)
        {
            _elementsList.Clear();
        }

        /// <summary>
        /// ������ ������.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            CreateTable(_elementsList, dataGridView1);
        }

        /// <summary>
        /// ���������� �����.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (_elementsList.Count == 0)
            {
                MessageBox.Show("����������� ������ ��� ����������.",
                    "������ �� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "����� (*.elm)|*.elm|��� ����� (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = System.IO.File.Create(path))
                {
                    _serializer.Serialize(file, _elementsList);
                }
                MessageBox.Show("���� ������� ��������.",
                    "���������� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// �������� �����.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void OpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "����� (*.elm)|*.elm|��� ����� (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (var file = new StreamReader(path))
                {
                    _elementsList =
                        (BindingList<PassiveElementBase>)_serializer.Deserialize(file);
                }

                dataGridView1.DataSource = _elementsList;
                dataGridView1.CurrentCell = null;
                MessageBox.Show("���� ������� ��������.",
                    "�������� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("�� ������� ��������� ����.\n" +
                    "���� �������� ��� �� ������������� �������.",
                    "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: remove? +
    }
}