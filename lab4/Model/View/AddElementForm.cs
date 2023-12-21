using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма добавления новых элементов.
    /// </summary>
    public partial class AddElementForm : Form
    {
        /// <summary>
        /// Словарь UserControl.
        /// </summary>
        private Dictionary<string, UserControl> _dictionaryUserControl;

        /// <summary>
        /// Событие добавления элемента.
        /// </summary>
        public EventHandler<EventArgs> ElementAdded;

        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl _userControl;

        /// <summary>
        /// Форма добавления элементов.
        /// </summary>
        public AddElementForm()
        {
            InitializeComponent();

            choicElementComboBox.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            confirmationButton.Enabled = false;
#if !DEBUG
            button3.Visible = false;
#endif
            string[] elements = { "Резистор", "Индуктивность",
                "Конденсатор" };

            choicElementComboBox.Items.AddRange(elements);

            _dictionaryUserControl = new Dictionary<string,
                UserControl>()
            {
                {elements[0], addResistorUserControl1},
                {elements[1], addInductorUserControl1},
                {elements[2], addCondenserUserControl1}
            };
        }

        /// <summary>
        /// Метод загрузки форм.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void AddElementForm_Load(object sender, EventArgs e)
        {
            addResistorUserControl1.Visible = false;
            addInductorUserControl1.Visible = false;
            addCondenserUserControl1.Visible = false;
        }

        /// <summary>
        /// Выпадающий список.
        /// Действие которое выполняется когда
        /// выбрали фигуру из выпадающего списка.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void СhoicElementComboBox_SelectedIndexChanged(object sender,
            EventArgs e)
        {
            string elementType = choicElementComboBox.SelectedItem.ToString();

            foreach (var (i, userControl) in _dictionaryUserControl)
            {
                userControl.Visible = false;
                if (elementType == i)
                {
                    userControl.Visible = true;
                    confirmationButton.Enabled = true;
                    this._userControl = userControl;
                }
            }

        }

        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void СonfirmationButton_Click(object sender,
            EventArgs e)
        {
            try
            {
                var currentElementControlName =
                    choicElementComboBox.SelectedItem.ToString();

                var currentElementControl =
                    _dictionaryUserControl[currentElementControlName];

                var eventArgs =
                    new ElementEventArgs(((IAddElement)
                    currentElementControl).AddElement());
                ElementAdded?.Invoke(this, eventArgs);
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение!\n" +
                    "Введите одно положительное десятичное число" +
                    " в каждое текстовое поле.",
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void СanselButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Рандом.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            choicElementComboBox.SelectedIndex = random.Next(0, 3);

            foreach (TextBox textbox in _userControl.Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Text = random.Next(1, 100).ToString();
                }
            }
        }
    }
}
