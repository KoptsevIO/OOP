namespace View
{
    /// <summary>
    /// Класс-дизайнер формы фильтра.
    /// </summary>
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filterGroupBox = new GroupBox();
            label1 = new Label();
            CondenserCheckBox = new CheckBox();
            InductorCheckBox = new CheckBox();
            ResistorCheckBox = new CheckBox();
            filterButton = new Button();
            ImpedanceCheckBox = new CheckBox();
            ImpedanceTextBox = new TextBox();
            Impedancelabel = new Label();
            ImpedanceTextBox2 = new TextBox();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // filterGroupBox
            // 
            filterGroupBox.BackColor = SystemColors.Control;
            filterGroupBox.Controls.Add(label1);
            filterGroupBox.Controls.Add(CondenserCheckBox);
            filterGroupBox.Controls.Add(InductorCheckBox);
            filterGroupBox.Controls.Add(ResistorCheckBox);
            filterGroupBox.Location = new Point(10, 21);
            filterGroupBox.Margin = new Padding(3, 2, 3, 2);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Padding = new Padding(3, 2, 3, 2);
            filterGroupBox.Size = new Size(260, 155);
            filterGroupBox.TabIndex = 0;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Параметры фильтрации";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 123);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 7;
            label1.Text = "+ j";
            // 
            // CondenserCheckBox
            // 
            CondenserCheckBox.AutoSize = true;
            CondenserCheckBox.Location = new Point(10, 88);
            CondenserCheckBox.Margin = new Padding(3, 2, 3, 2);
            CondenserCheckBox.Name = "CondenserCheckBox";
            CondenserCheckBox.Size = new Size(97, 19);
            CondenserCheckBox.TabIndex = 2;
            CondenserCheckBox.Text = "Конденсатор";
            CondenserCheckBox.UseVisualStyleBackColor = true;
            // 
            // InductorCheckBox
            // 
            InductorCheckBox.AutoSize = true;
            InductorCheckBox.Location = new Point(10, 57);
            InductorCheckBox.Margin = new Padding(3, 2, 3, 2);
            InductorCheckBox.Name = "InductorCheckBox";
            InductorCheckBox.Size = new Size(158, 19);
            InductorCheckBox.TabIndex = 1;
            InductorCheckBox.Text = "Катушка индуктивности";
            InductorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResistorCheckBox
            // 
            ResistorCheckBox.AutoSize = true;
            ResistorCheckBox.Location = new Point(10, 26);
            ResistorCheckBox.Margin = new Padding(3, 2, 3, 2);
            ResistorCheckBox.Name = "ResistorCheckBox";
            ResistorCheckBox.Size = new Size(76, 19);
            ResistorCheckBox.TabIndex = 0;
            ResistorCheckBox.Text = "Резистор";
            ResistorCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(12, 180);
            filterButton.Margin = new Padding(3, 2, 3, 2);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(258, 22);
            filterButton.TabIndex = 1;
            filterButton.Text = "Запуск фильтрации";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += buttonFilter_Click;
            // 
            // ImpedanceCheckBox
            // 
            ImpedanceCheckBox.AutoSize = true;
            ImpedanceCheckBox.Location = new Point(20, 142);
            ImpedanceCheckBox.Margin = new Padding(3, 2, 3, 2);
            ImpedanceCheckBox.Name = "ImpedanceCheckBox";
            ImpedanceCheckBox.Size = new Size(113, 19);
            ImpedanceCheckBox.TabIndex = 3;
            ImpedanceCheckBox.Text = "Сопротивление";
            ImpedanceCheckBox.UseVisualStyleBackColor = true;
            ImpedanceCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ImpedanceTextBox
            // 
            ImpedanceTextBox.Location = new Point(148, 140);
            ImpedanceTextBox.Margin = new Padding(3, 2, 3, 2);
            ImpedanceTextBox.Name = "ImpedanceTextBox";
            ImpedanceTextBox.Size = new Size(27, 23);
            ImpedanceTextBox.TabIndex = 4;
            // 
            // Impedancelabel
            // 
            Impedancelabel.AutoSize = true;
            Impedancelabel.Location = new Point(235, 146);
            Impedancelabel.Name = "Impedancelabel";
            Impedancelabel.Size = new Size(25, 15);
            Impedancelabel.TabIndex = 5;
            Impedancelabel.Text = "Ом";
            // 
            // ImpedanceTextBox2
            // 
            ImpedanceTextBox2.Location = new Point(200, 140);
            ImpedanceTextBox2.Margin = new Padding(3, 2, 3, 2);
            ImpedanceTextBox2.Name = "ImpedanceTextBox2";
            ImpedanceTextBox2.Size = new Size(27, 23);
            ImpedanceTextBox2.TabIndex = 6;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 212);
            Controls.Add(ImpedanceTextBox2);
            Controls.Add(Impedancelabel);
            Controls.Add(ImpedanceTextBox);
            Controls.Add(ImpedanceCheckBox);
            Controls.Add(filterButton);
            Controls.Add(filterGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FilterForm";
            Text = "Фильтр";
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox filterGroupBox;
        private Button filterButton;
        private CheckBox InductorCheckBox;
        private CheckBox ResistorCheckBox;
        private CheckBox CondenserCheckBox;
        private CheckBox ImpedanceCheckBox;
        private TextBox ImpedanceTextBox;
        private Label Impedancelabel;
        private TextBox ImpedanceTextBox2;
        private Label label1;
    }
}