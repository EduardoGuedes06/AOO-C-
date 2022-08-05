using System;
using AOO.ContentContext.Enums;
using System.Collections.Generic;
namespace AOO.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
             Modules =  new List<Module>();
        }
        public int Tag { get; set;}
        public IList<Module> Modules { get; set;}

        public int DurationInMinutes { get; set;}

        public EContentLevel Level { get; set;}

    }
}