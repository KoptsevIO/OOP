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
            buttonReset = new Button();
            buttonFilterElement = new Button();
            groupBox1 = new GroupBox();
            groupBoxElements.SuspendLayout();
            SuspendLayout();
            // 
            // deletElement
            // 
            deletElement.Location = new Point(18, 333);
            deletElement.Name = "deletElement";
            deletElement.Size = new Size(226, 39);
            deletElement.TabIndex = 5;
            deletElement.Text = "Удалить элемент";
            deletElement.UseVisualStyleBackColor = true;
            deletElement.Click += deletElement_Click;
            // 
            // addElement
            // 
            addElement.Location = new Point(29, 318);
            addElement.Name = "addElement";
            addElement.Size = new Size(226, 39);
            addElement.TabIndex = 4;
            addElement.Text = "Добавить элемент";
            addElement.UseVisualStyleBackColor = true;
            addElement.Click += addElement_Click;
            // 
            // groupBoxElements
            // 
            groupBoxElements.Controls.Add(buttonReset);
            groupBoxElements.Controls.Add(buttonFilterElement);
            groupBoxElements.Controls.Add(deletElement);
            groupBoxElements.Controls.Add(groupBox1);
            groupBoxElements.Location = new Point(12, 32);
            groupBoxElements.Name = "groupBoxElements";
            groupBoxElements.Size = new Size(577, 384);
            groupBoxElements.TabIndex = 3;
            groupBoxElements.TabStop = false;
            groupBoxElements.Text = "Список элементов";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(442, 336);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(108, 29);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonFilterElement
            // 
            buttonFilterElement.Location = new Point(442, 293);
            buttonFilterElement.Name = "buttonFilterElement";
            buttonFilterElement.Size = new Size(108, 29);
            buttonFilterElement.TabIndex = 6;
            buttonFilterElement.Text = "Фильтр";
            buttonFilterElement.UseVisualStyleBackColor = true;
            buttonFilterElement.Click += buttonFilterElement_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(16, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 435);
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
        private Button buttonFilterElement;
        private Button buttonReset;
    }
}