using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAppDatos.Models
{
    public class AuthorBook
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Chapters { get; set; }

        public int Pages { get; set; }

        public int Price { get; set; }

        public string Author { get; set; }
    }
}
