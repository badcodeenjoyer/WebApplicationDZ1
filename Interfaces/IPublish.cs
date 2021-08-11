
using System.Linq;





namespace Interfaces
{
    public interface IPublish
    {
        public string DoSomething();

        public string[] Publish(IContent content)
        {
            return content.AddContent().ToArray();
        }

    }
}
