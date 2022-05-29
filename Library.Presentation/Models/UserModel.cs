using FileHelpers;
using Library.Business;
using Library.Data.Domain;

namespace Library.Presentation.Models
{
    [DelimitedRecord(",")]

    public class UserModel
    {
        public UserModel()
        {

        }
        public UserModel(User user)
        {
            this.UserID = user.UserID;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Email = user.Email;
            this.IndexNumber = user.IndexNumber;
            this.Phone = user.Phone;
            this.Role = (RoleTypes)user.RoleID;
            this.Password = user.Password;
        }
        [FieldHidden]
        public int UserID { get; set; }

        [FieldCaption("First Name")]
        public string FirstName { get; set; }

        [FieldCaption("Last Name")]
        public string LastName { get; set; }

        [FieldCaption("Email")]
        public string Email { get; set; }
        [FieldCaption("Password")]
        public string Password { get; set; }

        [FieldCaption("Index Number")]
        public string IndexNumber { get; set; }

        [FieldCaption("Phone")]
        public string Phone { get; set; }
        [FieldHidden]
        public RoleTypes Role { get; set; }
    }
}

