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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 34);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Активное сопротивление";
            // 
            // Resistance
            // 
            Resistance.Location = new Point(234, 33);
            Resistance.Name = "Resistance";
            Resistance.Size = new Size(147, 27);
            Resistance.TabIndex = 1;
            Resistance.KeyPress += Resistance_KeyPress;
            // 
            // AddResistorUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Resistance);
            Controls.Add(label1);
            Name = "AddResistorUserControl";
            Size = new Size(402, 89);
            Load += AddResistorUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Resistance;
    }
}
