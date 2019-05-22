using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Artist
    {
        public string Name { get; }

        public City Hometown;
        public int  DateOfBirth;
        public List<Masterpiece> ArtWorks = new List<Masterpiece>();

        public Artist(string HisName)
        {
            Name = HisName;
        }

        public Artist(string HisName, City BirthPlace, int  BirthTime)
        {
            Name = HisName;
            Hometown = BirthPlace;
            DateOfBirth = BirthTime;
        }

        public void AddArtWork(Masterpiece NewPiece)
        {
            ArtWorks.Add(NewPiece);
        }

        public string GetBirthPlace()
        {
            return Hometown.CityName;
        }

        public List<string> GetArtworksAsString()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < ArtWorks.Count; i++)
            {
                result.Add(ArtWorks[i].Title);
            }
            return result;
        }
    }
}
