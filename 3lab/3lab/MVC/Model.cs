﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Model
    {
        public Controller MyCont;

        public List<City> Cities = new List<City>();
        public List<Artist> Authors = new List<Artist>();
        public List<Masterpiece> Artworks = new List<Masterpiece>();

        bool CitiesContains(string Name)
        {
            for (int i = 0; i < Cities.Count; i++)
            {
                if (Cities[i].CityName == Name)
                    return true;
            }
            return false;
        }

        bool AuthorsContains(string Name)
        {
            for (int i = 0; i < Authors.Count; i++)
            {
                if (Authors[i].Name == Name)
                    return true;
            }
            return false;
        }

        bool MasterpiecesContains(string Name)
        {
            for (int i = 0; i < Artworks.Count; i++)
            {
                if (Artworks[i].Title == Name)
                    return true;
            }
            return false;
        }

        public void AddCity(string CityName, int Date)
        {
            if (CityName != null && !CitiesContains(CityName))
            {
                City NewCity = new City(CityName, Date);
                Cities.Add(NewCity);
            }
        }

        public void AddAuthor(string ArtistName, string CityName, int BirthTime)
        {
            if (ArtistName != null && !AuthorsContains(ArtistName))
            {
                Artist NewArt = new Artist(ArtistName, GetCityByName(CityName), BirthTime);
                Authors.Add(NewArt);
                Cities.Find(x => x == GetCityByName(CityName)).AddArtist(NewArt);
            }
        }

        public void AddMasterpiece(string PieceName, string CityName, string AuthorName, int Date)
        {
            if (PieceName != null && !MasterpiecesContains(PieceName))
            {
                Masterpiece NewPiece = new Masterpiece(PieceName, GetCityByName(CityName), GetAuthorByName(AuthorName),Date);
                Artworks.Add(NewPiece);
                Cities.Find(x => x == GetCityByName(CityName)).AddArtWork(NewPiece);
                Authors.Find(x => x == GetAuthorByName(AuthorName)).AddArtWork(NewPiece);
            }
        }

        public City GetCityByName(string Name)
        {
            for (int i = 0; i < Cities.Count; i++)
            {
                if (Cities[i].CityName == Name)
                    return Cities[i];
            }
            return null;
        }

        public Artist GetAuthorByName(string Name)
        {
            for (int i = 0; i < Authors.Count; i++)
            {
                if (Authors[i].Name == Name)
                    return Authors[i];
            }
            return null;
        }

        public Masterpiece GetPieceByName(string Name)
        {
            for (int i = 0; i < Artworks.Count; i++)
            {
                if (Artworks[i].Title == Name)
                    return Artworks[i];
            }
            return null;
        }
    }
}
