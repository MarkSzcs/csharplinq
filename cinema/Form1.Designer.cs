namespace Cinema
{
    partial class Form1
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
            orderBtn = new Button();
            titleCBox = new ComboBox();
            dateCBox = new ComboBox();
            listBox1 = new ListBox();
            listBoxLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // orderBtn
            // 
            orderBtn.Location = new Point(883, 311);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(163, 23);
            orderBtn.TabIndex = 2;
            orderBtn.Text = "Order Now";
            orderBtn.UseVisualStyleBackColor = true;
            // 
            // titleCBox
            // 
            titleCBox.FormattingEnabled = true;
            titleCBox.Location = new Point(882, 29);
            titleCBox.Name = "titleCBox";
            titleCBox.Size = new Size(163, 23);
            titleCBox.TabIndex = 3;
            // 
            // dateCBox
            // 
            dateCBox.FormattingEnabled = true;
            dateCBox.Location = new Point(882, 73);
            dateCBox.Name = "dateCBox";
            dateCBox.Size = new Size(163, 23);
            dateCBox.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(883, 121);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(163, 184);
            listBox1.TabIndex = 6;
            // 
            // listBoxLabel
            // 
            listBoxLabel.AutoSize = true;
            listBoxLabel.Location = new Point(883, 103);
            listBoxLabel.Name = "listBoxLabel";
            listBoxLabel.Size = new Size(42, 15);
            listBoxLabel.TabIndex = 7;
            listBoxLabel.Text = "Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(882, 11);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Select a movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(882, 55);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "Select a date";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 349);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxLabel);
            Controls.Add(listBox1);
            Controls.Add(dateCBox);
            Controls.Add(titleCBox);
            Controls.Add(orderBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button orderBtn;
        private ComboBox titleCBox;
        private ComboBox dateCBox;
        private ComboBox comboBox3;
        private ListBox listBox1;
        private Label listBoxLabel;
        private Label label2;
        private Label label3;
    }
}