using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Services;

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
