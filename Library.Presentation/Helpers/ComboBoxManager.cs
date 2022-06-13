using Library.Business;
using MaterialSkin.Controls;
using System;

namespace Library.Presentation.Helpers
{
    class ComboBoxManager
    {
        public static void SetValuesToAuthorComboBox(MaterialComboBox combobox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var authors = _unitOfWork.AuthorRepository.Get(a => a.DeleteDate == null);
            foreach (var item in authors)
            {
                combobox.Items.Add(item.Name);
            }
        }
        public static void SetValuesToPublisherComboBox(MaterialComboBox combobox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var publishers = _unitOfWork.PublishingHouseRepository.GetAll();
            foreach (var item in publishers)
            {
                combobox.Items.Add(item.Name);
            }
        }
        public static void SetValuesToLanguageComboBox(MaterialComboBox combobox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var languages = _unitOfWork.LanguageRepository.GetAll();
            foreach (var item in languages)
            {
                combobox.Items.Add(item.Caption);
            }
        }

        public static void SetValuesToISBNComboBox(MaterialComboBox iSBNAddRatingComboBox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var books = _unitOfWork.BookRepository.Get(b => b.DeleteDate == null);
            foreach (var item in books)
            {
                if (!iSBNAddRatingComboBox.Items.Contains(item.ISBN))
                {
                    iSBNAddRatingComboBox.Items.Add(item.ISBN);
                }
            }
        }

        public static void SetValuesToBooksComboBox(MaterialComboBox combobox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var books = _unitOfWork.BookRepository.Get(b => b.DeleteDate == null);
            foreach (var item in books)
            {
                if (!combobox.Items.Contains(item.Name))
                {
                    combobox.Items.Add(item.Name);
                }
            }
        }

        public static void SetValuesToEmployeeComboBox(MaterialComboBox searchEmployeeFirstNameComboBox, MaterialComboBox searchEmployeeLastNameComboBox, MaterialComboBox searchEmployeeEmailComboBox, MaterialComboBox searchEmployeePhoneComboBox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var user = _unitOfWork.UserRepository.Get(u => u.RoleID == (int)RoleTypes.Operation && u.DeleteDateUtc == null);
            foreach (var item in user)
            {
                if (!searchEmployeeFirstNameComboBox.Items.Contains(item.FirstName))
                {
                    searchEmployeeFirstNameComboBox.Items.Add(item.FirstName);
                }
                if(!searchEmployeeLastNameComboBox.Items.Contains(item.LastName))
                {
                    searchEmployeeLastNameComboBox.Items.Add(item.LastName);
                }
                searchEmployeeEmailComboBox.Items.Add(item.Email);
                searchEmployeePhoneComboBox.Items.Add(item.Phone);

            }
        }

        public static void SetValuesToUsersComboBox(MaterialComboBox firstNamecombobox, MaterialComboBox lastNamecombobox, MaterialComboBox indexNumbercombobox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var user = _unitOfWork.UserRepository.Get(u => u.RoleID == (int)RoleTypes.Student && u.DeleteDateUtc == null);
            foreach (var item in user)
            {
                if(!firstNamecombobox.Items.Contains(item.FirstName))
                {
                    firstNamecombobox.Items.Add(item.FirstName);
                }
                if(!lastNamecombobox.Items.Contains(item.LastName))
                {
                    lastNamecombobox.Items.Add(item.LastName);
                }
                indexNumbercombobox.Items.Add(item.IndexNumber);

            }
        }
        public static void AddEmptyValueToSearchComboBox(params MaterialComboBox[] comboBoxs)
        {
            foreach(var item in comboBoxs)
            {
                item.Items.Add("");
            }
        }
    }
}
