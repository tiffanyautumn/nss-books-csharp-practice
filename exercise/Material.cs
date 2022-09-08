using System;
using System.Collections.Generic;
namespace BooksAMillion
{
    public class Material
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }

        public List<Genre> MaterialGenre { get; set; } = new List<Genre>();

        public virtual string DisplayName
        {
            get
            {
                return $"{Title} -by {Author}";
            }
        }
    }
}