using Location.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Bussines
{
    public class LocationBussines
    {
        DataBaseContext db = new DataBaseContext();

        /// <summary>
        /// Ülkelerin listelenmesi için gerekli olan listeleme fonksiyonu yazıldı.
        /// </summary>
        /// <returns></returns>
        public List<Country> ListCountry()
        {
            return db.Country.OrderBy(x => x.COUNTRY_NAME).ToList();
        }

        /// <summary>
        /// Ülkeye ait şehirlerin getirilmesi için ülkeID kullanılarak şehirler listelendi.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<City> ListCity(int countryId)
        {
            return db.City.Where(x => x.CITY_COUNTRY_ID == countryId).OrderBy(x => x.CITY_NAME).ToList();
        }
    }
}
