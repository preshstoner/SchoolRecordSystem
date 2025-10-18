# 🧑‍🎓 Student Registration System

This is a Windows Forms application built with C# that allows users to register student details into a MySQL database. It features a user-friendly interface for data entry and stores information such as name, age, gender, date of birth, address, parental details, citizenship status, academic grade, division, and major subject.

## 🚀 Features

- Windows Forms UI with:
  - TextBoxes for student details
  - ComboBoxes for gender and grade selection
  - CheckBox for Spanish citizenship
  - DatePicker for date of birth
  - Submit button to save data
- MySQL database integration
- Input validation for age and required fields
- Clean and modular code structure

## 🛠 Technologies Used

- C# (.NET Framework)
- Windows Forms
- MySQL
- MySql.Data NuGet package

## 🗃 Database Schema

```sql
CREATE TABLE Students (
    StudentId INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Age INT,
    Gender VARCHAR(10),
    DateOfBirth DATE,
    Address VARCHAR(255),
    FathersName VARCHAR(100),
    MothersName VARCHAR(100),
    FathersOccupation VARCHAR(100),
    IsSpanishCitizen BOOLEAN,
    Grade VARCHAR(10),
    Division VARCHAR(10),
    MajorSubject VARCHAR(50)
);
📦 Setup Instructions
Clone the repository:

bash
git clone https://github.com/your-username/student-registration-app.git
Open the solution in Visual Studio.

Install the MySQL Connector:

bash
Install-Package MySql.Data
Update the connection string in Form1.cs:

csharp
string connectionString = "Server=localhost;Port=3306;Database=StudentsDB;Uid=root;Pwd=yourpassword;";
Run the application and test the form.

🤝 Contributing
Contributions are welcome! If you'd like to improve the UI, add validation, or extend functionality (e.g., edit/delete records), feel free to fork the repo and submit a pull request.

📧 Contact
For questions or collaboration, reach out via GitHub Issues or email: ministry@example.com

Code

---

Let me know if you want to add screenshots, a license, or a contribution guide. I can help you polish it even further!
