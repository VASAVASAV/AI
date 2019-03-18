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
        public string[] CitiesArr = new string[] { "Невідомо"};
        public string[] AuthorsArr = new string[] { "Невідомый" };
        public string[] MasterpiecesArr = new string[0];
        public Controller(MainForm InpForm, Model InpModel)
        {
            MyForm = InpForm;
            MyModel = InpModel;
            MyModel.MyCont = this;
            MyForm.MyCont = this;
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
            MyModel.AddAuthor(Name, City, Date);
            MyForm.AddAuthorName(Name);
        }

        public void CreationOfMasterpiece(string Name)
        {
            //MyModel.AddCity(Name);
            MyForm.AddCityName(Name);
        }

        public Tuple<string,string, int> GetCityInf(string CityName)
        {
            return null; 
        }
    }
}
