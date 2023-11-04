namespace View
{
    /// <summary>
    /// Дизайн формы AddCondenserUserControl.
    /// </summary>
    partial class AddCapacitorUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс
        /// должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            Capacitance = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 25);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "мкФ";
            // 
            // Capacitance
            // 
            Capacitance.Location = new Point(180, 22);
            Capacitance.Margin = new Padding(3, 2, 3, 2);
            Capacitance.Name = "Capacitance";
            Capacitance.Size = new Size(61, 23);
            Capacitance.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 3;
            label1.Text = "Ёмкость конденсатора";
            // 
            // AddCapacitorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(Capacitance);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCapacitorUserControl";
            Size = new Size(300, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox Capacitance;
        private Label label1;
    }
}
