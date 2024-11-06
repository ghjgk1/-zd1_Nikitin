using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal struct Song
    {
        //свойство автор
        public string author;
        //свойство название
        public string title;
        //свойство путь до файла с мелодией.
        public string filename;
        
        //конструктор
        public Song(string Author, string Title, string Filename)
        {
            author = Author;    
            title = Title;  
            filename = Filename;
        }
    }
}
