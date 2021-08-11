
namespace Interfaces
{
    public interface ISave
    {
        public string DoSomething();
        
        public string[] Pub()
        {
          
          return _publication;
        }
        public static string[] _publication = { "---" };
    }
}
