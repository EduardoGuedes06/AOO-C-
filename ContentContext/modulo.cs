using System.Collections.Generic;
namespace AOO.ContentContext
{
            public class Modulo
    {
        public Modulo()
        {
            Lecture = new List<Lecture>();
        }
        public int Ordem { get; set;}
        public int Titulo { get; set;}

        public IList<Lecture> Lecture { get; set;}
    }




}