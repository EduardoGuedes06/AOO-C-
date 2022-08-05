using System;
using System.Collections.Generic;
using System.Linq;
using AOO.ContentContext;
using AOO.ContentContext.Enums;

namespace AOO{
    class program{
        static void Main(string[] args)
        {
            var content = new Content();
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Iniciante;
            foreach(var item in course.Modules)
            {
                
            }
            var carrer = new Carrer();
            //carrer.TotalCurses = 25;
        }

    }

}   