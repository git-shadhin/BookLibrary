using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookLibrary.DAL;

namespace BookLibrary.BL
{
    public class UserProvider
    {
        public static void AddUser(UserDTO NewUser)
        {
            User UserToAdd = NewUser.ConvertToBE();
            LibraryEntities Context = GetContext();


            Context.Users.Add(UserToAdd);

            Context.SaveChanges();
        }

        public static UserDTO Login(string UserName, string Password)
        {
            LibraryEntities Context = new LibraryEntities();

            User UserBE = Context.Users.ToList().Where(x=>x.UserName==UserName && x.Password==Password).SingleOrDefault();

            UserDTO _UserDTO = null;


            if (UserBE != null)
            {
                _UserDTO = new UserDTO(UserBE);
            }

            return _UserDTO;
        }

        public static LibraryEntities GetContext()
        {
            return new LibraryEntities();
        }
    }
}