using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Services;

namespace Services
{
    public class ContentService : IContent
    {
        private int _checkWork;
        public string DoSomething()
        {
            _checkWork = 2;

            return $"{_checkWork}";
        }
        public string[] content = {"new publication with content"};
        
        public string[] AddContent(string[] con)
        {

            con = content;
            var Contented = new string[SaveInfService._publication.Length + con.Length];
            SaveInfService._publication.CopyTo(Contented, 0);
            con.CopyTo(Contented, SaveInfService._publication.Length);
            SaveInfService._publication = Contented;
            return SaveInfService._publication;
        }

    }
}
