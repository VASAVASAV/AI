using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Controller
    {
        public  MainForm MyForm;
        public Model MyModel;
        public string[] CitiesArr = new string[0];//{ "Невідомо"};
        public string[] AuthorsArr = new string[0];// { "Невідомий" };
        public string[] MasterpiecesArr = new string[0];
        public Controller(MainForm InpForm, Model InpModel)
        {
            MyForm = InpForm;
            MyModel = InpModel;
            MyModel.MyCont = this;
            MyForm.MyCont = this;
            FoundCity("Невідомо", -1);
            FoundCity("Лейден", 922);
            FoundCity("Санкт-Петербург", 1703);
            FoundCity("Ареццо", -600);
            FoundCity("Париж", -300);
            FoundCity("Амстердам", 1275);
            FoundCity("Нью-Йорк", 1624);
            FoundCity("Рим", -800);
            BirthOfMan("Мікеланджело", "Ареццо", 1475);
            BirthOfMan("Карл Брюлов", "Санкт-Петербург", 1799);
            BirthOfMan("Рембрандт", "Лейден", 1606);
            BirthOfMan("Жак-Луі Давид", "Париж", 1748);
            BirthOfMan("Невідомий", "Невідомо",-1);
            CreationOfMasterpiece("Розпис Сікстинської капели", "Рим", "Мікеланджело", 1508);
            CreationOfMasterpiece("Нічна варта", "Амстердам", "Рембрандт", 1642);
            CreationOfMasterpiece("Бонопарт на перевалі Сен-Бернар", "Париж", "Жак-Луі Давид", 1801);
            CreationOfMasterpiece("Смерть Сократа", "Нью-Йорк", "Жак-Луі Давид", 1787);
            CreationOfMasterpiece("Останній день Помпеї", "Санкт-Петербург", "Карл Брюлов", 1830);
            CreationOfMasterpiece("Клятва Гораціїв", "Париж", "Жак-Луі Давид", 1784);
            CreationOfMasterpiece("Август з Пріма-Порта", "Рим", "Невідомий", 50);
            CreationOfMasterpiece("Пьета", "Рим", "Мікеланджело", 1499);
            CreationOfMasterpiece("Повернення блудного сина", "Санкт-Петербург", "Рембрандт", 1499);
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
            var temp = (AuthorsArr.ToList());
            temp.Add(Name);
            AuthorsArr = temp.ToArray();
        }

        public void CreationOfMasterpiece(string Name, string City, string Author, int Date)
        {
            MyModel.AddMasterpiece(Name, City, Author, Date);
            MyForm.AddPieceName(Name);
            var temp = (MasterpiecesArr.ToList());
            temp.Add(Name);
            MasterpiecesArr = temp.ToArray();
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

        public Tuple<List<string>, string, int> GetAuthorInf(string AuthorName)
        {
            List<string> Artworks = new List<string>();
            Artist Target = MyModel.GetAuthorByName(AuthorName);
            string BirthPlace = Target.GetBirthPlace();
            Artworks = Target.GetArtworksAsString();
            return new Tuple<List<string>, string, int>(Artworks, BirthPlace, Target.DateOfBirth);
        }

        public Tuple<string, string, int> GetPieceInf(string PieceName)
        {
            Masterpiece Target = MyModel.GetPieceByName(PieceName);
            string CreationPlace = Target.GetCreationPlace();
            return new Tuple<string, string, int>(Target.GetAuthor(), CreationPlace, Target.CreationDate);
        }
    }
}
