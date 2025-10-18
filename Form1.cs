using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealProjectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Step 1: Collect data from form controls
            string name = txtName.Text;
            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return; 
            }
            string gender = cmbGender.SelectedItem?.ToString() ?? "";
            DateTime dob = dtpDateOfBirth.Value;
            string address = txtAddress.Text;
            string fathersName = txtFathersName.Text;
            string mothersName = txtMothersName.Text;
            string fathersOccupation = txtFathersOccupation.Text;
            bool isSpanishCitizen = cnkSpanishCitizen.Checked;
            string grade = cmbGrade.SelectedItem?.ToString() ?? "";
            string division = cmbDivision.Text;
            string majorSubject = txtMajorSubject.Text;

            //Step 2: Connect to database and insert 
            string connectionString = "Server=localhost; Port= 3306; Database=StudentsDB; Uid= root; Pwd=23051999;" ;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"INSERT INTO Students
                    (Name, Age, Gender, DateOfBirth, Address, FathersName, MothersName, FathersOccupation, IsSpanishCitizen, Grade, Division, MajorSubject)
                    VALUES
                    (@Name, @Age, @Gender, @DOB , @Address, @FName, @MName, @FOccupation, @Citizen, @Grade, @Division, @Major)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@FName", fathersName);
                cmd.Parameters.AddWithValue("@MName", mothersName);
                cmd.Parameters.AddWithValue("@FOccupation", fathersOccupation);
                cmd.Parameters.AddWithValue("@Citizen", isSpanishCitizen);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@Division", division);
                cmd.Parameters.AddWithValue("@Major", majorSubject);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Student record saved successfully!"); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) {
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cmbGrade.Items.AddRange(new string[] {"A", "B", "C" });
        }
    }
}
