using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Artist
    {
        string Name;

        City Hometown;
        DateTime DateOfBirth;
        List<Masterpiece> ArtWorks = new List<Masterpiece>();

        public Artist(string HisName)
        {
            Name = HisName;
        }

        public Artist(string HisName, City BirthPlace, DateTime BirthTime)
        {
            Name = HisName;
            Hometown = BirthPlace;
            DateOfBirth = BirthTime;
        }
    }
}
