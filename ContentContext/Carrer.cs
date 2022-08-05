using System;
namespace AOO.ContentContext
{
    public class Carrer : Content
    {
        public Carrer()
        {
            Items = new List<CarrerItem>() ;
        }
        public IList<CarrerItem> Items { get; set;}
        public int TotalCurses => Items.Count;
    }

}   
