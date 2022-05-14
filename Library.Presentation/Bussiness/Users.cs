using FileHelpers;
using Library.Business;
using Library.Data.Domain;
using Library.Presentation.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presentation.Bussiness
{
    public class Users
    {
        public static void SetUser(string firstName, string lastName, string email, string password, string indexNumber, string phone)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

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
        }
        public static void SaveUsersToCsv()
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var users = _unitOfWork.UserRepository.Get(u => u.RoleID == (int)RoleTypes.Student && u.DeleteDateUtc == null)
               .Select(i => new UserModel   // select prolazi kroz svaki objekat i premapira
                {
                   FirstName = i.FirstName,
                   LastName = i.LastName,
                   Email = i.Email,
                   Phone = i.Phone,
                   IndexNumber = i.IndexNumber
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
                engine.WriteFile(path, users);
            }
        }
        
        public static void ChangeProfile(string firstName,string lastName,string email,string phone)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();

            var user = _unitOfWork.UserRepository.Get(u => u.UserID == Program.Current.User.UserID).FirstOrDefault();

            user.Email = email;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Phone = phone;

            _unitOfWork.Save();

        }


    }
}
