using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOO.ContentContext
{
    public class Module
    {
        public Module()
        {
            Leactures = new List<Lecture>();
        }
        public int Order { get; set;}
        public string Title { get; set;}
        public IList<Lecture> Leactures { get; set;}
    }
}