using System.Text;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBrowseImage(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image (*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }



        private void buttonRegStudent_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"name: {this.textBoxLName.Text}, {this.textBoxFName.Text} {this.textBoxMName.Text}");

            String gender = this.radioButtonMale.Checked ? "Male" : "Female";
            sb.AppendLine($"Gender: {gender}");

            string selectedDay = this.comboBoxDay.SelectedItem?.ToString() ?? "Day not selected";
            string selectedMonth = this.comboBox2.SelectedItem?.ToString() ?? "Month not selected";
            string selectedYear = this.comboBoxYear.SelectedItem?.ToString() ?? "Year not selected";
            sb.AppendLine($"Birthdate: {selectedMonth} {selectedDay}, {selectedYear}");

            string selectedProgram = this.comboBoxSelectProg.SelectedItem?.ToString() ?? "Program not selected";
            sb.AppendLine($"Course: {selectedProgram}");

            MessageBox.Show(sb.ToString(), "Student Registration");


        }
    }
}

