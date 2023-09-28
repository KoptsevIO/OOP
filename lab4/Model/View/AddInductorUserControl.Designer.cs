namespace View
{
    /// <summary>
    /// Дизайн формы AddInductorUserControl.
    /// </summary>
    partial class AddInductorUserControl
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
            Inductance = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 0;
            label2.Text = "Индуктивность";
            // 
            // Inductance
            // 
            Inductance.Location = new Point(168, 23);
            Inductance.Margin = new Padding(3, 2, 3, 2);
            Inductance.Name = "Inductance";
            Inductance.Size = new Size(64, 23);
            Inductance.TabIndex = 1;
            Inductance.KeyPress += Inductance_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 26);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "мГн";
            // 
            // AddInductorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(Inductance);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddInductorUserControl";
            Size = new Size(300, 67);
            Load += AddInductorUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox Inductance;
        private Label label1;
    }
}
