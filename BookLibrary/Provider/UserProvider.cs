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
            LibraryEntities Context = new LibraryEntities();


            Context.Users.Add(UserToAdd);

            Context.SaveChanges();
        }
    }
}