using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookLibrary.DAL;

namespace BookLibrary.BL
{
    public class CityProvider
    {
        public static List<CityDTO> GetCitiesByPrifix(string Prefix)
        {
            LibraryEntities Context = new LibraryEntities();
            List<CityDTO> Cities = new List<CityDTO>();

            List<City> DBCities = Context.Cities.Where(x => x.Title.Contains(Prefix)).ToList();

            foreach (City item in DBCities)
            {
                CityDTO NewCity = new CityDTO(item);
                Cities.Add(NewCity);
            }

            return Cities;


        }

        public static List<CityDTO> GetCities()
        {
            LibraryEntities Context = new LibraryEntities();
            List<CityDTO> Cities = new List<CityDTO>();

            List<City> DBCities = Context.Cities.ToList();

            foreach (City item in DBCities)
            {
                CityDTO NewCity = new CityDTO(item);
                Cities.Add(NewCity);
            }

            return Cities;


        }
    }
}