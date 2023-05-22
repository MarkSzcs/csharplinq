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
            checkSeatsButton = new Button();
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
            box_1_2 = new CheckBox();
            box_2_2 = new CheckBox();
            box_3_2 = new CheckBox();
            box_4_2 = new CheckBox();
            box_5_2 = new CheckBox();
            box_5_4 = new CheckBox();
            box_4_4 = new CheckBox();
            box_3_4 = new CheckBox();
            box_2_4 = new CheckBox();
            box_1_4 = new CheckBox();
            box_5_3 = new CheckBox();
            box_4_3 = new CheckBox();
            box_3_3 = new CheckBox();
            box_2_3 = new CheckBox();
            box_1_3 = new CheckBox();
            box_5_5 = new CheckBox();
            box_4_5 = new CheckBox();
            box_3_5 = new CheckBox();
            box_2_5 = new CheckBox();
            box_1_5 = new CheckBox();
            box_5_1 = new CheckBox();
            box_4_1 = new CheckBox();
            box_3_1 = new CheckBox();
            box_2_1 = new CheckBox();
            box_1_1 = new CheckBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            orderButton = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label25 = new Label();
            SuspendLayout();
            // 
            // checkSeatsButton
            // 
            checkSeatsButton.Location = new Point(11, 145);
            checkSeatsButton.Name = "checkSeatsButton";
            checkSeatsButton.Size = new Size(256, 23);
            checkSeatsButton.TabIndex = 2;
            checkSeatsButton.Text = "Check Seats";
            checkSeatsButton.UseVisualStyleBackColor = true;
            checkSeatsButton.Click += checkSeatsButton_Click;
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
            label4.Location = new Point(514, 343);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 18;
            label4.Text = "Play Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 299);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 19;
            label5.Text = "Play Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 255);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 20;
            label6.Text = "Room";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(514, 211);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 21;
            label7.Text = "Length";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(514, 167);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 22;
            label8.Text = "Director";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(514, 123);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 23;
            label9.Text = "Title";
            // 
            // adminPlaytimeTBox
            // 
            adminPlaytimeTBox.Location = new Point(514, 361);
            adminPlaytimeTBox.Name = "adminPlaytimeTBox";
            adminPlaytimeTBox.Size = new Size(241, 23);
            adminPlaytimeTBox.TabIndex = 24;
            // 
            // adminRoomTBox
            // 
            adminRoomTBox.Location = new Point(514, 273);
            adminRoomTBox.Name = "adminRoomTBox";
            adminRoomTBox.Size = new Size(241, 23);
            adminRoomTBox.TabIndex = 25;
            // 
            // admonPlaydateTBox
            // 
            admonPlaydateTBox.Location = new Point(514, 317);
            admonPlaydateTBox.Name = "admonPlaydateTBox";
            admonPlaydateTBox.Size = new Size(241, 23);
            admonPlaydateTBox.TabIndex = 26;
            // 
            // adminLengthTBox
            // 
            adminLengthTBox.Location = new Point(514, 229);
            adminLengthTBox.Name = "adminLengthTBox";
            adminLengthTBox.Size = new Size(241, 23);
            adminLengthTBox.TabIndex = 27;
            // 
            // adminDirectorTBox
            // 
            adminDirectorTBox.Location = new Point(514, 185);
            adminDirectorTBox.Name = "adminDirectorTBox";
            adminDirectorTBox.Size = new Size(241, 23);
            adminDirectorTBox.TabIndex = 28;
            // 
            // adminTitleTBox
            // 
            adminTitleTBox.Location = new Point(514, 140);
            adminTitleTBox.Name = "adminTitleTBox";
            adminTitleTBox.Size = new Size(241, 23);
            adminTitleTBox.TabIndex = 29;
            // 
            // adminAddMovieButton
            // 
            adminAddMovieButton.Location = new Point(514, 390);
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
            label10.Location = new Point(514, 76);
            label10.Name = "label10";
            label10.Size = new Size(138, 15);
            label10.TabIndex = 32;
            label10.Text = "Select a movie to modify";
            // 
            // adminModyfyCBox
            // 
            adminModyfyCBox.FormattingEnabled = true;
            adminModyfyCBox.Location = new Point(514, 94);
            adminModyfyCBox.Name = "adminModyfyCBox";
            adminModyfyCBox.Size = new Size(241, 23);
            adminModyfyCBox.TabIndex = 31;
            adminModyfyCBox.SelectedIndexChanged += adminModyfyCBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(560, 28);
            label11.Name = "label11";
            label11.Size = new Size(157, 37);
            label11.TabIndex = 33;
            label11.Text = "Admin Only";
            // 
            // box_1_2
            // 
            box_1_2.AutoSize = true;
            box_1_2.Location = new Point(376, 107);
            box_1_2.Name = "box_1_2";
            box_1_2.Size = new Size(15, 14);
            box_1_2.TabIndex = 34;
            box_1_2.UseVisualStyleBackColor = true;
            // 
            // box_2_2
            // 
            box_2_2.AutoSize = true;
            box_2_2.Location = new Point(376, 132);
            box_2_2.Name = "box_2_2";
            box_2_2.Size = new Size(15, 14);
            box_2_2.TabIndex = 35;
            box_2_2.UseVisualStyleBackColor = true;
            // 
            // box_3_2
            // 
            box_3_2.AutoSize = true;
            box_3_2.Location = new Point(376, 152);
            box_3_2.Name = "box_3_2";
            box_3_2.Size = new Size(15, 14);
            box_3_2.TabIndex = 36;
            box_3_2.UseVisualStyleBackColor = true;
            // 
            // box_4_2
            // 
            box_4_2.AutoSize = true;
            box_4_2.Location = new Point(376, 177);
            box_4_2.Name = "box_4_2";
            box_4_2.Size = new Size(15, 14);
            box_4_2.TabIndex = 37;
            box_4_2.UseVisualStyleBackColor = true;
            // 
            // box_5_2
            // 
            box_5_2.AutoSize = true;
            box_5_2.Location = new Point(376, 202);
            box_5_2.Name = "box_5_2";
            box_5_2.Size = new Size(15, 14);
            box_5_2.TabIndex = 38;
            box_5_2.UseVisualStyleBackColor = true;
            // 
            // box_5_4
            // 
            box_5_4.AutoSize = true;
            box_5_4.Location = new Point(418, 202);
            box_5_4.Name = "box_5_4";
            box_5_4.Size = new Size(15, 14);
            box_5_4.TabIndex = 43;
            box_5_4.UseVisualStyleBackColor = true;
            // 
            // box_4_4
            // 
            box_4_4.AutoSize = true;
            box_4_4.Location = new Point(418, 177);
            box_4_4.Name = "box_4_4";
            box_4_4.Size = new Size(15, 14);
            box_4_4.TabIndex = 42;
            box_4_4.UseVisualStyleBackColor = true;
            // 
            // box_3_4
            // 
            box_3_4.AutoSize = true;
            box_3_4.Location = new Point(418, 152);
            box_3_4.Name = "box_3_4";
            box_3_4.Size = new Size(15, 14);
            box_3_4.TabIndex = 41;
            box_3_4.UseVisualStyleBackColor = true;
            // 
            // box_2_4
            // 
            box_2_4.AutoSize = true;
            box_2_4.Location = new Point(418, 132);
            box_2_4.Name = "box_2_4";
            box_2_4.Size = new Size(15, 14);
            box_2_4.TabIndex = 40;
            box_2_4.UseVisualStyleBackColor = true;
            // 
            // box_1_4
            // 
            box_1_4.AutoSize = true;
            box_1_4.Location = new Point(418, 107);
            box_1_4.Name = "box_1_4";
            box_1_4.Size = new Size(15, 14);
            box_1_4.TabIndex = 39;
            box_1_4.UseVisualStyleBackColor = true;
            // 
            // box_5_3
            // 
            box_5_3.AutoSize = true;
            box_5_3.Location = new Point(397, 202);
            box_5_3.Name = "box_5_3";
            box_5_3.Size = new Size(15, 14);
            box_5_3.TabIndex = 48;
            box_5_3.UseVisualStyleBackColor = true;
            // 
            // box_4_3
            // 
            box_4_3.AutoSize = true;
            box_4_3.Location = new Point(397, 177);
            box_4_3.Name = "box_4_3";
            box_4_3.Size = new Size(15, 14);
            box_4_3.TabIndex = 47;
            box_4_3.UseVisualStyleBackColor = true;
            // 
            // box_3_3
            // 
            box_3_3.AutoSize = true;
            box_3_3.Location = new Point(397, 152);
            box_3_3.Name = "box_3_3";
            box_3_3.Size = new Size(15, 14);
            box_3_3.TabIndex = 46;
            box_3_3.UseVisualStyleBackColor = true;
            // 
            // box_2_3
            // 
            box_2_3.AutoSize = true;
            box_2_3.Location = new Point(397, 132);
            box_2_3.Name = "box_2_3";
            box_2_3.Size = new Size(15, 14);
            box_2_3.TabIndex = 45;
            box_2_3.UseVisualStyleBackColor = true;
            // 
            // box_1_3
            // 
            box_1_3.AutoSize = true;
            box_1_3.Location = new Point(397, 107);
            box_1_3.Name = "box_1_3";
            box_1_3.Size = new Size(15, 14);
            box_1_3.TabIndex = 44;
            box_1_3.UseVisualStyleBackColor = true;
            // 
            // box_5_5
            // 
            box_5_5.AutoSize = true;
            box_5_5.Location = new Point(439, 202);
            box_5_5.Name = "box_5_5";
            box_5_5.Size = new Size(15, 14);
            box_5_5.TabIndex = 53;
            box_5_5.UseVisualStyleBackColor = true;
            // 
            // box_4_5
            // 
            box_4_5.AutoSize = true;
            box_4_5.Location = new Point(439, 177);
            box_4_5.Name = "box_4_5";
            box_4_5.Size = new Size(15, 14);
            box_4_5.TabIndex = 52;
            box_4_5.UseVisualStyleBackColor = true;
            // 
            // box_3_5
            // 
            box_3_5.AutoSize = true;
            box_3_5.Location = new Point(439, 152);
            box_3_5.Name = "box_3_5";
            box_3_5.Size = new Size(15, 14);
            box_3_5.TabIndex = 51;
            box_3_5.UseVisualStyleBackColor = true;
            // 
            // box_2_5
            // 
            box_2_5.AutoSize = true;
            box_2_5.Location = new Point(439, 132);
            box_2_5.Name = "box_2_5";
            box_2_5.Size = new Size(15, 14);
            box_2_5.TabIndex = 50;
            box_2_5.UseVisualStyleBackColor = true;
            // 
            // box_1_5
            // 
            box_1_5.AutoSize = true;
            box_1_5.Location = new Point(439, 107);
            box_1_5.Name = "box_1_5";
            box_1_5.Size = new Size(15, 14);
            box_1_5.TabIndex = 49;
            box_1_5.UseVisualStyleBackColor = true;
            // 
            // box_5_1
            // 
            box_5_1.AutoSize = true;
            box_5_1.Location = new Point(355, 202);
            box_5_1.Name = "box_5_1";
            box_5_1.Size = new Size(15, 14);
            box_5_1.TabIndex = 58;
            box_5_1.UseVisualStyleBackColor = true;
            // 
            // box_4_1
            // 
            box_4_1.AutoSize = true;
            box_4_1.Location = new Point(355, 177);
            box_4_1.Name = "box_4_1";
            box_4_1.Size = new Size(15, 14);
            box_4_1.TabIndex = 57;
            box_4_1.UseVisualStyleBackColor = true;
            // 
            // box_3_1
            // 
            box_3_1.AutoSize = true;
            box_3_1.Location = new Point(355, 152);
            box_3_1.Name = "box_3_1";
            box_3_1.Size = new Size(15, 14);
            box_3_1.TabIndex = 56;
            box_3_1.UseVisualStyleBackColor = true;
            // 
            // box_2_1
            // 
            box_2_1.AutoSize = true;
            box_2_1.Location = new Point(355, 132);
            box_2_1.Name = "box_2_1";
            box_2_1.Size = new Size(15, 14);
            box_2_1.TabIndex = 55;
            box_2_1.UseVisualStyleBackColor = true;
            // 
            // box_1_1
            // 
            box_1_1.AutoSize = true;
            box_1_1.Location = new Point(355, 107);
            box_1_1.Name = "box_1_1";
            box_1_1.Size = new Size(15, 14);
            box_1_1.TabIndex = 54;
            box_1_1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(375, 74);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 59;
            label12.Text = "Columns";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(355, 89);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 60;
            label13.Text = "1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(376, 89);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 61;
            label14.Text = "2";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(397, 89);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 62;
            label15.Text = "3";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(417, 89);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 63;
            label16.Text = "4";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(439, 90);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 64;
            label17.Text = "5";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(339, 106);
            label18.Name = "label18";
            label18.Size = new Size(13, 15);
            label18.TabIndex = 65;
            label18.Text = "1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(339, 202);
            label19.Name = "label19";
            label19.Size = new Size(13, 15);
            label19.TabIndex = 69;
            label19.Text = "5";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(339, 177);
            label20.Name = "label20";
            label20.Size = new Size(13, 15);
            label20.TabIndex = 68;
            label20.Text = "4";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(339, 152);
            label21.Name = "label21";
            label21.Size = new Size(13, 15);
            label21.TabIndex = 67;
            label21.Text = "3";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(339, 131);
            label22.Name = "label22";
            label22.Size = new Size(13, 15);
            label22.TabIndex = 66;
            label22.Text = "2";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(298, 151);
            label23.Name = "label23";
            label23.Size = new Size(35, 15);
            label23.TabIndex = 70;
            label23.Text = "Rows";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(364, 28);
            label24.Name = "label24";
            label24.Size = new Size(79, 37);
            label24.TabIndex = 71;
            label24.Text = "Seats";
            // 
            // orderButton
            // 
            orderButton.Location = new Point(355, 228);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(97, 23);
            orderButton.TabIndex = 72;
            orderButton.Text = "Place Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(355, 346);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 73;
            button1.Text = "Check order";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 23);
            textBox1.TabIndex = 74;
            // 
            // button2
            // 
            button2.Location = new Point(355, 257);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 76;
            button2.Text = "Modify";
            button2.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(355, 299);
            label25.Name = "label25";
            label25.Size = new Size(51, 15);
            label25.TabIndex = 77;
            label25.Text = "Order ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 445);
            Controls.Add(label25);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(orderButton);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(box_5_1);
            Controls.Add(box_4_1);
            Controls.Add(box_3_1);
            Controls.Add(box_2_1);
            Controls.Add(box_1_1);
            Controls.Add(box_5_5);
            Controls.Add(box_4_5);
            Controls.Add(box_3_5);
            Controls.Add(box_2_5);
            Controls.Add(box_1_5);
            Controls.Add(box_5_3);
            Controls.Add(box_4_3);
            Controls.Add(box_3_3);
            Controls.Add(box_2_3);
            Controls.Add(box_1_3);
            Controls.Add(box_5_4);
            Controls.Add(box_4_4);
            Controls.Add(box_3_4);
            Controls.Add(box_2_4);
            Controls.Add(box_1_4);
            Controls.Add(box_5_2);
            Controls.Add(box_4_2);
            Controls.Add(box_3_2);
            Controls.Add(box_2_2);
            Controls.Add(box_1_2);
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
            Controls.Add(checkSeatsButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button checkSeatsButton;
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
        private CheckBox box_1_2;
        private CheckBox box_2_2;
        private CheckBox box_3_2;
        private CheckBox box_4_2;
        private CheckBox box_5_2;
        private CheckBox box_5_4;
        private CheckBox box_4_4;
        private CheckBox box_3_4;
        private CheckBox box_2_4;
        private CheckBox box_1_4;
        private CheckBox box_5_3;
        private CheckBox box_4_3;
        private CheckBox box_3_3;
        private CheckBox box_2_3;
        private CheckBox box_1_3;
        private CheckBox box_5_5;
        private CheckBox box_4_5;
        private CheckBox box_3_5;
        private CheckBox box_2_5;
        private CheckBox box_1_5;
        private CheckBox box_5_1;
        private CheckBox box_4_1;
        private CheckBox box_3_1;
        private CheckBox box_2_1;
        private CheckBox box_1_1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button orderButton;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label25;
    }
}