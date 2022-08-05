using Balta.NotificationContext;
namespace Balta.ContentContext
{
    public class Article: Content{

        public IList<Notification> Notification { get; set; }
        public Article(string title, string url)
        :base(title, url ){
                 
        }
    }
}