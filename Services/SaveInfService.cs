using System;
using Interfaces;

namespace Services
{
    public class SaveInfService : ISave
    {
        private int _checkWork;
       
        public string DoSomething()
        {
            _checkWork = 5;

            return $"{_checkWork}";
        }

        

    }
}
