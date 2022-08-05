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
        public int DuracaoEmMinutos { get; set;}

        public string Nivel { get; set;}

        public EConentlevel level{ get; set;}
        
    }
}