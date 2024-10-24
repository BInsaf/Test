using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Composers
    {
        IList<string> names, genres;

        public Composers()
        {
            names = new List<string> { "Bach", "Beethoven", "Chopin" };
            genres = new List<string> { "Classical", "Romantic", "Jazz" };
        }

        public IList<string> Names
        {
            get { return genres; }
        }

        public IList<string> Genres
        {
            get { return genres; }
        }
    }
}
