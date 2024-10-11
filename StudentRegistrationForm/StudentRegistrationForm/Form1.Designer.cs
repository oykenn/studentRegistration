namespace StudentRegistrationForm
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
            labelSRF = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            labelMiddleName = new Label();
            textBoxLName = new TextBox();
            textBoxFName = new TextBox();
            textBoxMName = new TextBox();
            labelGender = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            label1 = new Label();
            comboBoxDay = new ComboBox();
            comboBox2 = new ComboBox();
            comboBoxYear = new ComboBox();
            label2 = new Label();
            comboBoxSelectProg = new ComboBox();
            buttonRegStudent = new Button();
            buttonBrowseImg = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelSRF
            // 
            labelSRF.AutoSize = true;
            labelSRF.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold);
            labelSRF.Location = new Point(62, 53);
            labelSRF.Name = "labelSRF";
            labelSRF.Size = new Size(368, 37);
            labelSRF.TabIndex = 0;
            labelSRF.Text = "Student Registration Form";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(62, 124);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(133, 32);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(62, 224);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(139, 32);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name";
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Location = new Point(62, 337);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(171, 32);
            labelMiddleName.TabIndex = 3;
            labelMiddleName.Text = "Middle Name";
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(62, 159);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(548, 39);
            textBoxLName.TabIndex = 4;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(62, 259);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(548, 39);
            textBoxFName.TabIndex = 5;
            // 
            // textBoxMName
            // 
            textBoxMName.Location = new Point(62, 372);
            textBoxMName.Name = "textBoxMName";
            textBoxMName.Size = new Size(548, 39);
            textBoxMName.TabIndex = 6;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(62, 431);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(98, 32);
            labelGender.TabIndex = 7;
            labelGender.Text = "Gender";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI Historic", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonMale.Location = new Point(187, 437);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(79, 26);
            radioButtonMale.TabIndex = 9;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI Historic", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonFemale.Location = new Point(281, 437);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(94, 26);
            radioButtonFemale.TabIndex = 10;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 495);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 11;
            label1.Text = "Date of Birth";
            // 
            // comboBoxDay
            // 
            comboBoxDay.Font = new Font("Segoe UI Historic", 7F, FontStyle.Bold);
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxDay.Location = new Point(66, 535);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(89, 33);
            comboBoxDay.TabIndex = 12;
            comboBoxDay.Text = "Day";
            comboBoxDay.SelectedIndexChanged += comboBoxDay_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Historic", 7.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decembera" });
            comboBox2.Location = new Point(163, 535);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(141, 33);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "Month";
            // 
            // comboBoxYear
            // 
            comboBoxYear.Font = new Font("Segoe UI Historic", 7F, FontStyle.Bold);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "", "", "", "", "", "" });
            comboBoxYear.Location = new Point(312, 535);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(108, 33);
            comboBoxYear.TabIndex = 14;
            comboBoxYear.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 596);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 15;
            label2.Text = "Program to apply";
            // 
            // comboBoxSelectProg
            // 
            comboBoxSelectProg.BackColor = SystemColors.ControlLight;
            comboBoxSelectProg.Font = new Font("Segoe UI Historic", 8F, FontStyle.Bold);
            comboBoxSelectProg.FormattingEnabled = true;
            comboBoxSelectProg.Items.AddRange(new object[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Tourism Management" });
            comboBoxSelectProg.Location = new Point(67, 633);
            comboBoxSelectProg.Name = "comboBoxSelectProg";
            comboBoxSelectProg.Size = new Size(543, 38);
            comboBoxSelectProg.TabIndex = 16;
            comboBoxSelectProg.Text = "Select Program";
            // 
            // buttonRegStudent
            // 
            buttonRegStudent.BackColor = Color.Red;
            buttonRegStudent.ForeColor = SystemColors.ButtonFace;
            buttonRegStudent.Location = new Point(64, 687);
            buttonRegStudent.Name = "buttonRegStudent";
            buttonRegStudent.Size = new Size(546, 68);
            buttonRegStudent.TabIndex = 17;
            buttonRegStudent.Text = "Register Student";
            buttonRegStudent.UseVisualStyleBackColor = false;
            buttonRegStudent.Click += buttonRegStudent_Click;
            // 
            // buttonBrowseImg
            // 
            buttonBrowseImg.Location = new Point(745, 481);
            buttonBrowseImg.Name = "buttonBrowseImg";
            buttonBrowseImg.Size = new Size(150, 46);
            buttonBrowseImg.TabIndex = 19;
            buttonBrowseImg.Text = "Browse";
            buttonBrowseImg.UseVisualStyleBackColor = true;
            buttonBrowseImg.Click += buttonBrowseImage;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(642, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 839);
            Controls.Add(buttonBrowseImg);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegStudent);
            Controls.Add(comboBoxSelectProg);
            Controls.Add(label2);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBox2);
            Controls.Add(comboBoxDay);
            Controls.Add(label1);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(labelGender);
            Controls.Add(textBoxMName);
            Controls.Add(textBoxFName);
            Controls.Add(textBoxLName);
            Controls.Add(labelMiddleName);
            Controls.Add(labelFirstName);
            Controls.Add(labelLastName);
            Controls.Add(labelSRF);
            Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSRF;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelMiddleName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelGender;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label label1;
        private ComboBox comboBoxDay;
        private ComboBox comboBox2;
        private ComboBox comboBoxYear;
        private Label label2;
        private ComboBox comboBoxSelectProg;
        private Button buttonRegStudent;
        private Button buttonBrowseImg;
        private PictureBox pictureBox1;
        private TextBox textBoxLName;
        private TextBox textBoxFName;
        private TextBox textBoxMName;
    }
    public partial class RegistrationDetailsForm : Form
    {
        private Label labelName;
        private Label labelBirthday;
        private PictureBox pictureBoxImage;


    }
}
