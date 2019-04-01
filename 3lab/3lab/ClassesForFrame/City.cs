using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class City
    {
        public string CityName { get; }

        public int  FoundationTime;
        List<Artist> ArtistCitizens = new List<Artist>();
        List<Masterpiece> ArtworksStored = new List<Masterpiece>();

        public City(string ItsName)
        {
            CityName = ItsName;
        }

        public City(string ItsName, int  FoundatDate)
        {
            CityName = ItsName;
            FoundationTime = FoundatDate;
        }

        public void SetFoundationTime(int  FoundatDate)
        {
            FoundationTime = FoundatDate;
        }

        public void AddArtist(Artist NewBorn)
        {
            ArtistCitizens.Add(NewBorn);
        }
    }
}
