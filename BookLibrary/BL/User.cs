using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookLibrary.DAL;

namespace BookLibrary.BL
{
    public class UserDTO
    {

        public UserDTO()
        {

        }

        public UserDTO(User UserBE)
        {
            this.ID = UserBE.ID;
            this.FirstName = UserBE.FirstName;
            this.LastName = UserBE.LastName;
            this.Email = UserBE.Email;
            this.BirthDate = UserBE.BirthDate;
            this.CityID = UserBE.CityID;
            this.Street = UserBE.Street;
            this.UserName = UserBE.UserName;
            this.Password = UserBE.Password;

        }

        public User ConvertToBE()
        {
            User UserBE = new User();

           // UserBE.ID = this.ID;
            UserBE.FirstName = this.FirstName;
            UserBE.LastName = this.LastName;
            UserBE.Email = this.Email;
            UserBE.BirthDate = this.BirthDate;
            UserBE.CityID = this.CityID;
            UserBE.Street = this.Street;
            UserBE.UserName = this.UserName;
            UserBE.Password = this.Password;

            return UserBE;

        }

        public Nullable<int> ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> CityID { get; set; }
        public string Street { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}