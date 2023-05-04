namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deletElement = new Button();
            addElement = new Button();
            groupBoxElements = new GroupBox();
            groupBox1 = new GroupBox();
            groupBoxElements.SuspendLayout();
            SuspendLayout();
            // 
            // deletElement
            // 
            deletElement.Location = new Point(330, 341);
            deletElement.Name = "deletElement";
            deletElement.Size = new Size(226, 39);
            deletElement.TabIndex = 5;
            deletElement.Text = "Удалить элемент";
            deletElement.UseVisualStyleBackColor = true;
            // 
            // addElement
            // 
            addElement.Location = new Point(27, 341);
            addElement.Name = "addElement";
            addElement.Size = new Size(226, 39);
            addElement.TabIndex = 4;
            addElement.Text = "Добавить элемент";
            addElement.UseVisualStyleBackColor = true;
            // 
            // groupBoxElements
            // 
            groupBoxElements.Controls.Add(groupBox1);
            groupBoxElements.Location = new Point(12, 32);
            groupBoxElements.Name = "groupBoxElements";
            groupBoxElements.Size = new Size(577, 384);
            groupBoxElements.TabIndex = 3;
            groupBoxElements.TabStop = false;
            groupBoxElements.Text = "Список элементов";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(16, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 435);
            Controls.Add(deletElement);
            Controls.Add(addElement);
            Controls.Add(groupBoxElements);
            Name = "MainForm";
            Text = "Программа расчёта комплексного сопротивлениия";
            TransparencyKey = Color.White;
            Load += MainForm_Load;
            groupBoxElements.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button deletElement;
        private Button addElement;
        private GroupBox groupBoxElements;
        private GroupBox groupBox1;
    }
}