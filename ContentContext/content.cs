
namespace AOO.ContentContext
{
    public class Content
    {
        public content()
        {   
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        
    }
}