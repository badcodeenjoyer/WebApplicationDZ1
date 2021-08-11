
using Interfaces;


namespace Services
{
    public class PublishService : IPublish
    {
        private int _checkWork;
        public string DoSomething()
        {
            _checkWork = 4;

            return $"{_checkWork}";
        }
        
        
    }
}
