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
            filterButton = new Button();
            resistanceCheckBox = new CheckBox();
            iductanceCheckBox = new CheckBox();
            condenserCheckBox = new CheckBox();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // filterGroupBox
            // 
            filterGroupBox.BackColor = SystemColors.Control;
            filterGroupBox.Controls.Add(condenserCheckBox);
            filterGroupBox.Controls.Add(iductanceCheckBox);
            filterGroupBox.Controls.Add(resistanceCheckBox);
            filterGroupBox.Location = new Point(12, 28);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(217, 147);
            filterGroupBox.TabIndex = 0;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Параметры фильтрации";
            filterGroupBox.Enter += filterGroupBox_Enter;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(12, 187);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(217, 29);
            filterButton.TabIndex = 1;
            filterButton.Text = "Запуск фильтрации";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // resistanceCheckBox
            // 
            resistanceCheckBox.AutoSize = true;
            resistanceCheckBox.Location = new Point(12, 34);
            resistanceCheckBox.Name = "resistanceCheckBox";
            resistanceCheckBox.Size = new Size(94, 24);
            resistanceCheckBox.TabIndex = 0;
            resistanceCheckBox.Text = "Резистор";
            resistanceCheckBox.UseVisualStyleBackColor = true;
            resistanceCheckBox.CheckedChanged += resistanceCheckBox_CheckedChanged;
            // 
            // iductanceCheckBox
            // 
            iductanceCheckBox.AutoSize = true;
            iductanceCheckBox.Location = new Point(12, 76);
            iductanceCheckBox.Name = "iductanceCheckBox";
            iductanceCheckBox.Size = new Size(195, 24);
            iductanceCheckBox.TabIndex = 1;
            iductanceCheckBox.Text = "Катушка индуктивности";
            iductanceCheckBox.UseVisualStyleBackColor = true;
            iductanceCheckBox.CheckedChanged += iductanceCheckBox_CheckedChanged;
            // 
            // condenserCheckBox
            // 
            condenserCheckBox.AutoSize = true;
            condenserCheckBox.Location = new Point(12, 117);
            condenserCheckBox.Name = "condenserCheckBox";
            condenserCheckBox.Size = new Size(122, 24);
            condenserCheckBox.TabIndex = 2;
            condenserCheckBox.Text = "Конденсатор";
            condenserCheckBox.UseVisualStyleBackColor = true;
            condenserCheckBox.CheckedChanged += condenserCheckBox_CheckedChanged;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 232);
            Controls.Add(filterButton);
            Controls.Add(filterGroupBox);
            Name = "FilterForm";
            Text = "Фильтр";
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox filterGroupBox;
        private Button filterButton;
        private CheckBox iductanceCheckBox;
        private CheckBox resistanceCheckBox;
        private CheckBox condenserCheckBox;
    }
}