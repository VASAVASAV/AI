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

        public void AddArtWork (Masterpiece NewPiece)
        {
            ArtworksStored.Add(NewPiece);
        }

        public List<string> GetHabitansAsString()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < ArtistCitizens.Count; i++)
            {
                result.Add(ArtistCitizens[i].Name);
            }
            return result;
        }

        public List<string> GetArtworksAsString()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < ArtworksStored.Count; i++)
            {
                result.Add(ArtworksStored[i].Title);
            }
            return result;
        }
    }
}
