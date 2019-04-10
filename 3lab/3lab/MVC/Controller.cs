using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Controller
    {
        MainForm MyForm;
        Model MyModel;
        public string[] CitiesArr = new string[0];//{ "Невідомо"};
        public string[] AuthorsArr = new string[0]; //{ "Невідомый" };
        public string[] MasterpiecesArr = new string[0];
        public Controller(MainForm InpForm, Model InpModel)
        {
            MyForm = InpForm;
            MyModel = InpModel;
            MyModel.MyCont = this;
            MyForm.MyCont = this;
            FoundCity("Невідомо", -1);
            BirthOfMan("Невідомий", "Невідомо",-1);
        }

        public void FoundCity(string Name, int Date)
        {
            MyModel.AddCity(Name, Date);
            MyForm.AddCityName(Name);
            var temp = (CitiesArr.ToList());
            temp.Add(Name);
            CitiesArr = temp.ToArray();
        }

        public void BirthOfMan(string Name, string City, int Date)
        {
            if (Date < MyModel.GetCityByName(City).FoundationTime)
            {
                MyForm.ShowMessage("This man couldnt be born before city was founded. Operation interrupted");
                return;
            }
            MyModel.AddAuthor(Name, City, Date);
            MyForm.AddAuthorName(Name);
        }

        public void CreationOfMasterpiece(string Name, string City, string Author, int Date)
        {
            MyModel.AddMasterpiece(Name, City, Author, Date);
            MyForm.AddCityName(Name);
        }

        public Tuple<List<string>,List<string>, int> GetCityInf(string CityName)
        {
            List<string> Artworks = new List<string>();
            List<string> People = new List<string>();
            City Target = MyModel.GetCityByName(CityName);
            People = Target.GetHabitansAsString();
            Artworks = Target.GetArtworksAsString();
            return new Tuple<List<string>,List<string>,int>(People,Artworks,Target.FoundationTime);
        }
    }
}
