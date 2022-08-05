
using Balta.SharedContext;
using Balta.NotificationContext;

namespace Balta.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}