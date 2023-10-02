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
        //TODO: нарушение инкапсуляции +
        /// <summary>
        /// Словарь UserControl.
        /// </summary>
        private Dictionary<string, UserControl> dictionaryUserControl;

        /// <summary>
        /// Событие добавления элемента.
        /// </summary>
        public EventHandler<EventArgs> ElementAdded;

        //TODO: нарушение инкапсуляции +
        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl userControl;

        /// <summary>
        /// Форма добавления фигур.
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

            dictionaryUserControl = new Dictionary<string,
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
        private void choicElementComboBox_SelectedIndexChanged(object sender,
            EventArgs e)
        {
            string elementType = choicElementComboBox.SelectedItem.ToString();

            foreach (var (i, userControl) in dictionaryUserControl)
            {
                userControl.Visible = false;
                if (elementType == i)
                {
                    userControl.Visible = true;
                    confirmationButton.Enabled = true;
                    this.userControl = userControl;
                }
            }

        }

        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void confirmationButton_Click(object sender,
            EventArgs e)
        {
            try
            {
                var currentFigureControlName =
                    choicElementComboBox.SelectedItem.ToString();

                var currentFigureControl =
                    dictionaryUserControl[currentFigureControlName];

                var eventArgs =
                    new ElementEventArgs(((IAddElement)
                    currentFigureControl).AddElement());
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
        private void canselButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Рандом.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void randomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            choicElementComboBox.SelectedIndex = random.Next(0, 3);

            foreach (TextBox textbox in userControl.Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Text = random.Next(1, 100).ToString();
                }
            }
        }
    }
}
