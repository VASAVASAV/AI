using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class City
    {
        string CityName;

        DateTime FoundationTime;
        List<Artist> ArtistCitizens = new List<Artist>();
        List<Masterpiece> ArtworksStored = new List<Masterpiece>();

        public City(string ItsName)
        {
            CityName = ItsName;
        }

        public City(string ItsName, DateTime FoundatDate)
        {
            CityName = ItsName;
            FoundationTime = FoundatDate;
        }
    }
}
