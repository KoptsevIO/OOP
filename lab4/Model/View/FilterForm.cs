using PassiveElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{
    /// <summary>
    /// Форма фильтрации.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Лист фильтруемых фигур
        /// </summary>
        private BindingList<PassiveElementBase> _listElement;

        /// <summary>
        /// Лист отфильтрованных фигур
        /// </summary>
        private BindingList<PassiveElementBase> _listElementsFilter;

        /// <summary>
        /// Комплексное сопротивление.
        /// </summary>
        private Complex _impedance;

        /// <summary>
        /// Обработчик события.
        /// </summary>
        public EventHandler<EventArgs> ElementFiltered;

        /// <summary>
        /// Инициализация форм.
        /// </summary>
        public FilterForm(BindingList<PassiveElementBase> elements)
        {
            InitializeComponent();
            _listElement = elements;
            ReImpedanceTextBox.Enabled = false;
            ImImpedanceTextBox.Enabled = false;
        }

        /// <summary>
        /// Флажок активации поля ввода сопротивления.
        /// </summary>
        /// <param name="sender">/</param>
        /// <param name="e">/</param>
        private void CheckBox_CheckedChanged(object sender,
            EventArgs e)
        {
            if (ImpedanceCheckBox.Checked)
            {
                ReImpedanceTextBox.Enabled = true;
                ImImpedanceTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Кнопка поиска.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            _listElementsFilter = new BindingList<PassiveElementBase>();
            int count = 0;

            double reImpedance = 0;
            double imImpedance = 0;
            try
            {
                if (ReImpedanceTextBox.Text != "")
                {
                    reImpedance =
                        Utils.CheckNumber(ReImpedanceTextBox.Text);
                }
                if (ImImpedanceTextBox.Text != "")
                {
                    imImpedance =
                        Utils.CheckNumber(ImImpedanceTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное число!",
                    "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            _impedance = new Complex(reImpedance,imImpedance);

            if (!InductorCheckBox.Checked
                && !ResistorCheckBox.Checked
                && !CondenserCheckBox.Checked
                && !ImpedanceCheckBox.Checked)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            foreach (PassiveElementBase element in _listElement)
            {

                switch (element)
                {
                    case Resistor when ResistorCheckBox.Checked:
                    case Capacitor when CondenserCheckBox.Checked:
                    case Inductor when InductorCheckBox.Checked:
                        {
                            if (ImpedanceCheckBox.Checked)
                            {
                                if (element.Impedance == _impedance)
                                {
                                    count++;
                                    _listElementsFilter.Add(element);
                                    break;
                                }
                                break;
                            }
                            else
                            {
                                count++;
                                _listElementsFilter.Add(element);
                                break;
                            }
                        }
                }

                if (!InductorCheckBox.Checked
                    && !ResistorCheckBox.Checked
                    && !CondenserCheckBox.Checked)
                {
                    if (ImpedanceCheckBox.Checked &&
                        element.Impedance == _impedance)
                    {
                        count++;
                        _listElementsFilter.Add(element);
                    }
                }

                ElementListEventArgs eventArgs;

                if (count > 0)
                {
                    eventArgs = new ElementListEventArgs(_listElementsFilter);
                }
                else
                {
                    MessageBox.Show("Нет элементов удовлетворяющих фильтру!",
                        "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    eventArgs = new ElementListEventArgs(_listElementsFilter);
                    return;
                }


                ElementFiltered?.Invoke(this, eventArgs);
                Close();
            }

        }
    }
}
