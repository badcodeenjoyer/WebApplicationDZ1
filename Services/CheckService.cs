using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Services;

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
            if (SaveInfService._publication.Contains("new publication with content"))
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
