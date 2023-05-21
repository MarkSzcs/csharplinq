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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            adminPlaytimeTBox = new TextBox();
            adminRoomTBox = new TextBox();
            admonPlaydateTBox = new TextBox();
            adminLengthTBox = new TextBox();
            adminDirectorTBox = new TextBox();
            adminTitleTBox = new TextBox();
            adminAddMovieButton = new Button();
            label10 = new Label();
            adminModyfyCBox = new ComboBox();
            label11 = new Label();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 335);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 18;
            label4.Text = "Play Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 291);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 19;
            label5.Text = "Play Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 247);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 20;
            label6.Text = "Room";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 203);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 21;
            label7.Text = "Length";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 159);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 22;
            label8.Text = "Director";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 115);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 23;
            label9.Text = "Title";
            // 
            // adminPlaytimeTBox
            // 
            adminPlaytimeTBox.Location = new Point(287, 353);
            adminPlaytimeTBox.Name = "adminPlaytimeTBox";
            adminPlaytimeTBox.Size = new Size(241, 23);
            adminPlaytimeTBox.TabIndex = 24;
            // 
            // adminRoomTBox
            // 
            adminRoomTBox.Location = new Point(287, 265);
            adminRoomTBox.Name = "adminRoomTBox";
            adminRoomTBox.Size = new Size(241, 23);
            adminRoomTBox.TabIndex = 25;
            // 
            // admonPlaydateTBox
            // 
            admonPlaydateTBox.Location = new Point(287, 309);
            admonPlaydateTBox.Name = "admonPlaydateTBox";
            admonPlaydateTBox.Size = new Size(241, 23);
            admonPlaydateTBox.TabIndex = 26;
            // 
            // adminLengthTBox
            // 
            adminLengthTBox.Location = new Point(287, 221);
            adminLengthTBox.Name = "adminLengthTBox";
            adminLengthTBox.Size = new Size(241, 23);
            adminLengthTBox.TabIndex = 27;
            // 
            // adminDirectorTBox
            // 
            adminDirectorTBox.Location = new Point(287, 177);
            adminDirectorTBox.Name = "adminDirectorTBox";
            adminDirectorTBox.Size = new Size(241, 23);
            adminDirectorTBox.TabIndex = 28;
            // 
            // adminTitleTBox
            // 
            adminTitleTBox.Location = new Point(287, 132);
            adminTitleTBox.Name = "adminTitleTBox";
            adminTitleTBox.Size = new Size(241, 23);
            adminTitleTBox.TabIndex = 29;
            // 
            // adminAddMovieButton
            // 
            adminAddMovieButton.Location = new Point(287, 382);
            adminAddMovieButton.Name = "adminAddMovieButton";
            adminAddMovieButton.Size = new Size(241, 23);
            adminAddMovieButton.TabIndex = 30;
            adminAddMovieButton.Text = "Add Movie";
            adminAddMovieButton.UseVisualStyleBackColor = true;
            adminAddMovieButton.Click += adminAddMovieButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(287, 68);
            label10.Name = "label10";
            label10.Size = new Size(138, 15);
            label10.TabIndex = 32;
            label10.Text = "Select a movie to modify";
            // 
            // adminModyfyCBox
            // 
            adminModyfyCBox.FormattingEnabled = true;
            adminModyfyCBox.Location = new Point(287, 86);
            adminModyfyCBox.Name = "adminModyfyCBox";
            adminModyfyCBox.Size = new Size(241, 23);
            adminModyfyCBox.TabIndex = 31;
            adminModyfyCBox.SelectedIndexChanged += adminModyfyCBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(460, 28);
            label11.Name = "label11";
            label11.Size = new Size(157, 37);
            label11.TabIndex = 33;
            label11.Text = "Admin Only";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 445);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(adminModyfyCBox);
            Controls.Add(adminAddMovieButton);
            Controls.Add(adminTitleTBox);
            Controls.Add(adminDirectorTBox);
            Controls.Add(adminLengthTBox);
            Controls.Add(admonPlaydateTBox);
            Controls.Add(adminRoomTBox);
            Controls.Add(adminPlaytimeTBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox adminPlaytimeTBox;
        private TextBox adminRoomTBox;
        private TextBox admonPlaydateTBox;
        private TextBox adminLengthTBox;
        private TextBox adminDirectorTBox;
        private TextBox adminTitleTBox;
        private Button adminAddMovieButton;
        private Label label10;
        private ComboBox adminModyfyCBox;
        private Label label11;
    }
}