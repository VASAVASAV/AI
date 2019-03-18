using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Masterpiece
    {
        public string Title { get; }

        Artist Author;
        City Storage;
        int  CreationDate;

        public Masterpiece(string ItsTitle, City StoragePlace)
        {
            Title = ItsTitle;
            Storage = StoragePlace;
        }

        public Masterpiece(string ItsTitle, City StoragePlace, Artist ItsAuthor, int  DateOfCreation)
        {
            Title = ItsTitle;
            Storage = StoragePlace;
            Author = ItsAuthor;
            CreationDate = DateOfCreation;
        }
    }
}
