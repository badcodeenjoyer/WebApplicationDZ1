using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Services;

namespace Services
{
    public class LogicService : ILogic
    {
        private int _checkWork;
        public string DoSomething()
        {
            _checkWork = 3;

            return $"{_checkWork}";
        }
        
        public void DoAllLogic(IPublish publish , IContent content , ICheck check , ISave save )
        {
            
            check.CheckPublication();
            publish.Publish(content);
        }
    }
}
