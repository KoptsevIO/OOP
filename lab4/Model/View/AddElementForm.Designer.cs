namespace View
{
    partial class AddElementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should
        /// be disposed; otherwise, false.</param>
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
            choicElementGroupBox = new GroupBox();
            addResistorUserControl1 = new AddResistorUserControl();
            addInductorUserControl1 = new AddInductorUserControl();
            addCondenserUserControl1 = new AddCapacitorUserControl();
            choicElementComboBox = new ComboBox();
            canselButton = new Button();
            confirmationButton = new Button();
            randomButton = new Button();
            choicElementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // choicElementGroupBox
            // 
            choicElementGroupBox.Controls.Add(addResistorUserControl1);
            choicElementGroupBox.Controls.Add(addInductorUserControl1);
            choicElementGroupBox.Controls.Add(addCondenserUserControl1);
            choicElementGroupBox.Controls.Add(choicElementComboBox);
            choicElementGroupBox.Location = new Point(22, 11);
            choicElementGroupBox.Margin = new Padding(3, 2, 3, 2);
            choicElementGroupBox.Name = "choicElementGroupBox";
            choicElementGroupBox.Padding = new Padding(3, 2, 3, 2);
            choicElementGroupBox.Size = new Size(399, 206);
            choicElementGroupBox.TabIndex = 0;
            choicElementGroupBox.TabStop = false;
            choicElementGroupBox.Text = "Выбор элемента";
            // 
            // addResistorUserControl1
            // 
            addResistorUserControl1.Location = new Point(47, 86);
            addResistorUserControl1.Margin = new Padding(3, 2, 3, 2);
            addResistorUserControl1.Name = "addResistorUserControl1";
            addResistorUserControl1.Size = new Size(352, 83);
            addResistorUserControl1.TabIndex = 5;
            // 
            // addInductorUserControl1
            // 
            addInductorUserControl1.Location = new Point(42, 87);
            addInductorUserControl1.Margin = new Padding(3, 2, 3, 2);
            addInductorUserControl1.Name = "addInductorUserControl1";
            addInductorUserControl1.Size = new Size(341, 83);
            addInductorUserControl1.TabIndex = 4;
            // 
            // addCondenserUserControl1
            // 
            addCondenserUserControl1.Location = new Point(33, 71);
            addCondenserUserControl1.Margin = new Padding(3, 2, 3, 2);
            addCondenserUserControl1.Name = "addCondenserUserControl1";
            addCondenserUserControl1.Size = new Size(350, 83);
            addCondenserUserControl1.TabIndex = 3;
            // 
            // choicElementComboBox
            // 
            choicElementComboBox.FormattingEnabled = true;
            choicElementComboBox.Location = new Point(10, 42);
            choicElementComboBox.Margin = new Padding(3, 2, 3, 2);
            choicElementComboBox.Name = "choicElementComboBox";
            choicElementComboBox.Size = new Size(178, 23);
            choicElementComboBox.TabIndex = 2;
            choicElementComboBox.SelectedIndexChanged += 
                choicElementComboBox_SelectedIndexChanged;
            // 
            // canselButton
            // 
            canselButton.Location = new Point(149, 222);
            canselButton.Margin = new Padding(3, 2, 3, 2);
            canselButton.Name = "canselButton";
            canselButton.Size = new Size(114, 22);
            canselButton.TabIndex = 1;
            canselButton.Text = "Отмена";
            canselButton.UseVisualStyleBackColor = true;
            canselButton.Click += canselButton_Click;
            // 
            // confirmationButton
            // 
            confirmationButton.Location = new Point(22, 222);
            confirmationButton.Margin = new Padding(3, 2, 3, 2);
            confirmationButton.Name = "confirmationButton";
            confirmationButton.Size = new Size(114, 22);
            confirmationButton.TabIndex = 0;
            confirmationButton.Text = "OK";
            confirmationButton.UseVisualStyleBackColor = true;
            confirmationButton.Click += confirmationButton_Click;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(276, 222);
            randomButton.Margin = new Padding(3, 2, 3, 2);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(145, 22);
            randomButton.TabIndex = 2;
            randomButton.Text = "Случайный элемент";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // AddElementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 248);
            Controls.Add(randomButton);
            Controls.Add(choicElementGroupBox);
            Controls.Add(canselButton);
            Controls.Add(confirmationButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddElementForm";
            Text = "Добавить элемент";
            Load += AddElementForm_Load;
            choicElementGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            FormBorderStyle = 
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        #endregion

        private GroupBox choicElementGroupBox;
        private Button canselButton;
        private Button confirmationButton;
        private ComboBox choicElementComboBox;
        private AddResistorUserControl addResistorUserControl1;
        private AddInductorUserControl addInductorUserControl1;
        private AddCapacitorUserControl addCondenserUserControl1;
        private Button randomButton;
    }
}