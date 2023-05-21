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
            orderButton = new Button();
            titleCBox = new ComboBox();
            dateCBox = new ComboBox();
            listBox1 = new ListBox();
            listBoxLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            timeCBox = new ComboBox();
            label1 = new Label();
            modifyButton = new Button();
            SuspendLayout();
            // 
            // orderButton
            // 
            orderButton.Location = new Point(11, 145);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(256, 23);
            orderButton.TabIndex = 2;
            orderButton.Text = "Order Now";
            orderButton.UseVisualStyleBackColor = true;
            // 
            // titleCBox
            // 
            titleCBox.FormattingEnabled = true;
            titleCBox.Location = new Point(12, 28);
            titleCBox.Name = "titleCBox";
            titleCBox.Size = new Size(255, 23);
            titleCBox.TabIndex = 3;
            titleCBox.SelectedIndexChanged += titleCBox_SelectedIndexChanged;
            // 
            // dateCBox
            // 
            dateCBox.FormattingEnabled = true;
            dateCBox.Location = new Point(11, 73);
            dateCBox.Name = "dateCBox";
            dateCBox.Size = new Size(255, 23);
            dateCBox.TabIndex = 4;
            dateCBox.SelectedIndexChanged += dateCBox_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(11, 189);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(256, 244);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBoxLabel
            // 
            listBoxLabel.AutoSize = true;
            listBoxLabel.Location = new Point(11, 171);
            listBoxLabel.Name = "listBoxLabel";
            listBoxLabel.Size = new Size(42, 15);
            listBoxLabel.TabIndex = 7;
            listBoxLabel.Text = "Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Select a movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 55);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "Select a date";
            // 
            // timeCBox
            // 
            timeCBox.FormattingEnabled = true;
            timeCBox.Location = new Point(11, 116);
            timeCBox.Name = "timeCBox";
            timeCBox.Size = new Size(255, 23);
            timeCBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 99);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 11;
            label1.Text = "Select a screen time";
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(12, 439);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(254, 23);
            modifyButton.TabIndex = 12;
            modifyButton.Text = "button1";
            modifyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 504);
            Controls.Add(modifyButton);
            Controls.Add(label1);
            Controls.Add(timeCBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxLabel);
            Controls.Add(listBox1);
            Controls.Add(dateCBox);
            Controls.Add(titleCBox);
            Controls.Add(orderButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button orderButton;
        private ComboBox titleCBox;
        private ComboBox dateCBox;
        private ComboBox comboBox3;
        private ListBox listBox1;
        private Label listBoxLabel;
        private Label label2;
        private Label label3;
        private ComboBox timeCBox;
        private Label label1;
        private Button modifyButton;
    }
}