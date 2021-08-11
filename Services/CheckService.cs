using System;

using System.Linq;

using Interfaces;


namespace Services
{
   public class CheckService : ICheck 
    {
        private  int _checkWork;    
        public string DoSomething()
        {
            _checkWork = 1;
            
            return $"{_checkWork}";
        }

        public string CheckPublication()
        {
            if (ISave._publication.Contains("new publication with content"))
            {
                
                return "Checked , all ok";
            }
            else
            {
                return "Checked , not ok";
            }
        }
    }
}
