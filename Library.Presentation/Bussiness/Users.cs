using FileHelpers;
using Library.Business;
using Library.Data.Domain;
using Library.Presentation.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library.Presentation.Bussiness
{
    public class Users
    {
        public static User GetUserLogin(string userName, string password)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var user = _unitOfWork.UserRepository.Get(u => u.Email == userName && u.Password == password && u.DeleteDateUtc == null).FirstOrDefault();
            return user;
        }
        public static void SetUser(string firstName, string lastName, string email, string password, string indexNumber, string phone)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var existUser = _unitOfWork.UserRepository.Get(u => u.IndexNumber == indexNumber && u.Phone == phone).FirstOrDefault();
            if(existUser != null)
            {
                MaterialMessageBox.Show("User already exists!");
                return;
            }
            var user = new User();
            user.RoleID = (int)RoleTypes.Student;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.Password = password;
            user.IndexNumber = indexNumber;
            user.Phone = phone;
            user.InsertDateUtc = DateTime.UtcNow;
            user.DeleteDateUtc = null;

            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Successful added user!");
        }

        public static List<UserModel> AllStudents()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var students = _unitOfWork.UserRepository.Get(u => u.DeleteDateUtc == null && u.RoleID == (int)RoleTypes.Student)
                .Select(i => new UserModel
                {
                    UserID = i.UserID,
                    FirstName = i.FirstName,
                    LastName = i.LastName,
                    IndexNumber = i.IndexNumber,
                    Email = i.Email,
                    Phone = i.Phone,
                    Password = i.Password,
                    Role = (RoleTypes)i.RoleID
                }).ToList();
            return students;
        }

        public static List<UserModel> AllEmployers()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var employers = _unitOfWork.UserRepository.Get(u => u.DeleteDateUtc == null && u.RoleID == (int)RoleTypes.Operation)
                .Select(i => new UserModel
                {
                    UserID = i.UserID,
                    FirstName = i.FirstName,
                    LastName = i.LastName,
                    Email = i.Email,
                    Phone = i.Phone,
                    Password = i.Password,
                    Role = (RoleTypes)i.RoleID
                }).ToList();
            return employers;
        }

        public static void ChangePass(string email, string newPassword)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var user = _unitOfWork.UserRepository.Get(u => u.Email == email && u.DeleteDateUtc == null).FirstOrDefault();
            if (user == null)
            {
                MaterialMessageBox.Show("Email isn't valid.");
                return;
            }
            user.Password = newPassword;
            _unitOfWork.Save();
            MaterialMessageBox.Show("Password changed successfully.");
        }
        public static void SaveUsersToCsv(DataGridView studentsDataGrid)
        {
            var students = (from row in studentsDataGrid.Rows.OfType<DataGridViewRow>()
                             select new UserModel()
                             {
                                 FirstName = row.Cells["FirstName"].Value.ToString(),
                                 LastName = row.Cells["LastName"].Value.ToString(),
                                 IndexNumber = row.Cells["IndexNumber"].Value.ToString(),
                                 Email = row.Cells["Email"].Value.ToString(),
                                 Password = row.Cells["Password"].Value.ToString(),
                                 Phone = row.Cells["Phone"].Value.ToString()
                             }).ToList();

            string path = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                FileName = "users",

                DefaultExt = "csv",
                //  Filter = "csv files (*.xlsx)|*.xlsx",
                //  FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                var engine = new FileHelperEngine<UserModel>();
                engine.HeaderText = engine.GetFileHeader();
                engine.WriteFile(path, students);
                MaterialMessageBox.Show("File was saved.");
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                MaterialMessageBox.Show("Problem with saving file.");
            }
        }

        public static void ChangeProfile(string firstName, string lastName, string email, string phone)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var user = _unitOfWork.UserRepository.Get(u => u.UserID == Program.Current.User.UserID).FirstOrDefault();

            user.Email = email;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Phone = phone;

            _unitOfWork.Save();

        }

        public static List<UserModel> GetSearchedStudents(string searchUserFirstName, string searchUserLastName, string searchUserIndexNumber)
        {

            UnitOfWork _unitOfWork = new UnitOfWork();

            var students = _unitOfWork.UserRepository.Get(u =>
            (searchUserFirstName == null || u.FirstName.Contains(searchUserFirstName)) &&
            (searchUserLastName == null || u.LastName.Contains(searchUserLastName)) &&
            (searchUserIndexNumber == null || u.IndexNumber.Contains(searchUserIndexNumber)) &&
            u.DeleteDateUtc == null &&
            u.RoleID == (int)RoleTypes.Student)
                .Select(i => new UserModel
                {
                    UserID = i.UserID,
                    FirstName = i.FirstName,
                    LastName = i.LastName,
                    IndexNumber = i.IndexNumber,
                    Email = i.Email,
                    Phone = i.Phone,
                    Password = i.Password,
                    Role = (RoleTypes)i.RoleID
                }).ToList();
            return students;
        }

        public static User GetStudentById(int studentID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var student = _unitOfWork.UserRepository.Get(u => u.UserID == studentID).FirstOrDefault();
            return student;
        }

        public static void DeleteStudent(int studentID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var student = _unitOfWork.UserRepository.GetByID(studentID);
            student.DeleteDateUtc = DateTime.UtcNow;
            _unitOfWork.UserRepository.Update(student);
            _unitOfWork.Save();
        }

        public static void AddNewStudent(string studentFirstName, string studentLastName, string studentPassword, string studentPhoneNumber, string studentEmail, string studentIndexNumber)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var existStudent = _unitOfWork.UserRepository.Get(u => u.IndexNumber == studentIndexNumber || u.Email == studentEmail || u.Phone == studentPhoneNumber).FirstOrDefault();
            if (existStudent != null)
            {
                MaterialMessageBox.Show("Student already exist");
                return;
            }
            User studentAdd = new User
            {
                FirstName = studentFirstName,
                LastName = studentLastName,
                IndexNumber = studentIndexNumber,
                Password = studentPassword,
                Email = studentEmail,
                Phone = studentPhoneNumber,
                RoleID = (int)RoleTypes.Student,
                InsertDateUtc = DateTime.Now,
                DeleteDateUtc = null
            };
            _unitOfWork.UserRepository.Insert(studentAdd);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Student was added");
        }

        public static void UpdateStudent(int studentID, string studentFirstName, string studentLastName, string studentPassword, string studentPhoneNumber, string studentEmail, string studentIndexNumber)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var student = _unitOfWork.UserRepository.Get(r => r.UserID == studentID).FirstOrDefault();

            var existStudent = _unitOfWork.UserRepository.Get(u => u.UserID != studentID && ( u.IndexNumber == studentIndexNumber || u.Email == studentEmail || u.Phone == studentPhoneNumber)).FirstOrDefault();
            if (existStudent != null)
            {
                MaterialMessageBox.Show("Student already exist");
                return;
            }

            student.FirstName = studentFirstName;
            student.LastName = studentLastName;
            student.IndexNumber = studentIndexNumber;
            student.Password = studentPassword;
            student.Email = studentEmail;
            student.Phone = studentPhoneNumber;

            _unitOfWork.UserRepository.Update(student);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Student updated");
        }

        public static List<UserModel> GetSearchEmployees(string searchEmployeeFirstName, string searchEmployeeLastName, string searchEmployeeEmail, string searchEmployeePhone)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var employees = _unitOfWork.UserRepository.Get(u =>
            (searchEmployeeFirstName == null || u.FirstName.Contains(searchEmployeeFirstName)) &&
            (searchEmployeeLastName == null || u.LastName.Contains(searchEmployeeLastName)) &&
            (searchEmployeeEmail == null || u.Email.Contains(searchEmployeeEmail)) &&
            (searchEmployeePhone == null || u.Phone.Contains(searchEmployeePhone)) &&
            u.DeleteDateUtc == null &&
            u.RoleID == (int)RoleTypes.Operation)
                .Select(i => new UserModel
                {
                    UserID = i.UserID,
                    FirstName = i.FirstName,
                    LastName = i.LastName,
                    Email = i.Email,
                    Phone = i.Phone,
                    Password = i.Password,
                    Role = (RoleTypes)i.RoleID
                }).ToList();
            return employees;
        }

        public static User GetEmployeeById(int employeeID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var employee = _unitOfWork.UserRepository.Get(u => u.UserID == employeeID).FirstOrDefault();
            return employee;
        }

        public static void AddNewEmployee(string employeeFirstName, string employeeLastName, string employeePassword, string employeePhoneNumber, string employeeEmail)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var existEmployee = _unitOfWork.UserRepository.Get(u => u.Email == employeeEmail || u.Phone == employeePhoneNumber).FirstOrDefault();
            if (existEmployee != null)
            {
                MaterialMessageBox.Show("Employee already exist");
                return;
            }
            User employeeAdd = new User
            {
                FirstName = employeeFirstName,
                LastName = employeeLastName,
                Password = employeePassword,
                Email = employeeEmail,
                Phone = employeePhoneNumber,
                RoleID = (int)RoleTypes.Operation,
                InsertDateUtc = DateTime.Now,
                DeleteDateUtc = null
            };
            _unitOfWork.UserRepository.Insert(employeeAdd);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Employee was added");
        }

        public static void UpdateEmployee(int employeeID, string employeeFirstName, string employeeLastName, string employeePassword, string employeePhoneNumber, string employeeEmail)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var employee = _unitOfWork.UserRepository.Get(r => r.UserID == employeeID).FirstOrDefault();

            var existEmployee = _unitOfWork.UserRepository.Get(u => u.UserID != employeeID && (u.Email == employeeEmail || u.Phone == employeePhoneNumber)).FirstOrDefault();
            if (existEmployee != null)
            {
                MaterialMessageBox.Show("Employee already exist");
                return;
            }

            employee.FirstName = employeeFirstName;
            employee.LastName = employeeLastName;
            employee.Password = employeePassword;
            employee.Email = employeeEmail;
            employee.Phone = employeePhoneNumber;

            _unitOfWork.UserRepository.Update(employee);
            _unitOfWork.Save();
            MaterialMessageBox.Show("Employee updated");
        }

        public static void SaveEmployeeToCsv(DataGridView employeeDataGrid)
        {
            var employees = (from row in employeeDataGrid.Rows.OfType<DataGridViewRow>()
                             select new UserModel()
                             {
                                 FirstName = row.Cells["FirstName"].Value.ToString(),
                                 LastName = row.Cells["LastName"].Value.ToString(),
                                 Email = row.Cells["Email"].Value.ToString(),
                                 Password = row.Cells["Password"].Value.ToString(),
                                 Phone = row.Cells["Phone"].Value.ToString()
                             }).ToList();
            string path = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                FileName = "employees",

                DefaultExt = "csv",
                //  Filter = "csv files (*.xlsx)|*.xlsx",
                //  FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                var engine = new FileHelperEngine<UserModel>();
                engine.HeaderText = engine.GetFileHeader();
                engine.WriteFile(path, employees);
                MaterialMessageBox.Show("File was saved.");
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                MaterialMessageBox.Show("Problem with saving file.");
            }
        }

        public static void DeleteEmployee(int employeeID)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var employee = _unitOfWork.UserRepository.GetByID(employeeID);
            employee.DeleteDateUtc = DateTime.UtcNow;
            _unitOfWork.UserRepository.Update(employee);
            _unitOfWork.Save();
        }
    }
}
