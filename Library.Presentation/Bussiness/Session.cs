using Library.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presentation.Bussiness
{
    public class Session
    {
        public UserModel User { get; private set; }
        public Session()
        {

        }
        public void Initialize(UserModel user)
        {
            User = user;
        }
    }
}
