namespace View
{
    /// <summary>
    /// Дизайн формы AddResistorUserControl.
    /// </summary>
    partial class AddResistorUserControl
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
            label1 = new Label();
            Resistance = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "Активное сопротивление";
            // 
            // Resistance
            // 
            Resistance.Location = new Point(177, 23);
            Resistance.Margin = new Padding(3, 2, 3, 2);
            Resistance.Name = "Resistance";
            Resistance.Size = new Size(61, 23);
            Resistance.TabIndex = 1;
            Resistance.KeyPress += Resistance_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 26);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Ом";
            // 
            // AddResistorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(Resistance);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddResistorUserControl";
            Size = new Size(300, 67);
            Load += AddResistorUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Resistance;
        private Label label2;
    }
}
