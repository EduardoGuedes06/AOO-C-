using System;
using System.Collections.Generic;
using System.Linq;
using AOO.ContentContext;
using AOO.ContentContext.Enums;

namespace AOO{
    class program{
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article("Artigo sobre OOP","orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#","orientacao-csharp"));
            articles.Add(new Article("Artigo sobre ASP.NET","orientacao-aspnet"));

            //foreach(var article in articles)
            //{
            //    Console.WriteLine(article.Id );
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>(); 
            var course_OOP = new Course("Fundamentos OOP","fundamentos-oop"); 
            var course_C = new Course("Fundamentos C#","fundamentos-csharp"); 
            var course_ASP = new Course("Fundamentos ASP.NET","fundamentos-aspnet");
            courses.Add(course_OOP);
            courses.Add(course_C);
            courses.Add(course_ASP);

            var carres = new List<Carrer>(); 
            var carrerDotNet = new Carrer("Especialista.net","especialista-dotnet");
            var CarrerItem = new CarrerItem(1,"Comece por aqui","",null);
            var CarrerItem1 = new CarrerItem(2, "Aprenda OOP", "", null);
            var CarrerItem2 = new CarrerItem(3, "Aprenda .NET", "",null);
            carrerDotNet.Items.Add(CarrerItem);
            carrerDotNet.Items.Add(CarrerItem1);
            carrerDotNet.Items.Add(CarrerItem2);
            carres.Add(carrerDotNet);

            foreach (var carrer in carres)
            {
                Console.WriteLine(carrer.Title);
                foreach (var item in carrer.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
        }
        

    }

}   