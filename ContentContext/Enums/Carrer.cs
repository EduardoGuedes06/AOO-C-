namespace Balta.ContentContext{
    public class Carrer: Content
    {
      public Carrer(string title, string url)
        : base(title,url)
        {
        Items = new List<CareerItem>();
        }
      public IList<CareerItem> Items {get; set;}

      public int TotalCourses => Items.Count;

    }

}