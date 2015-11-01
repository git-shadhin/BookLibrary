using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookLibrary.DAL;

namespace BookLibrary.BL
{
    public class CityDTO
    {
        public CityDTO()
        {

        }
        public CityDTO(City CityBE)
        {
            this.ID = CityBE.ID;
            this.Title = CityBE.Title;
           


        }

        public City ConvertToBE()
        {
            City UserBE = new City();
            UserBE.ID = this.ID;
            UserBE.Title = this.Title;

            return UserBE;

        }

        public int ID { get; set; }
        public string Title { get; set; }
    }
}