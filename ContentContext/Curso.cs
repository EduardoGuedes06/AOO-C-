using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOO.ContentContext
{
    public class Curso
    {
        public Curso()
        {
            Modulos = new List<Modulo>();
        }
        public string tag { get; set;}

        public IList<Modulo> Modulos{ get; set;}
        
    }

        public class Lecture
    {
        public int Ordem { get; set;}
        public int Titulo { get; set;}
    }
}