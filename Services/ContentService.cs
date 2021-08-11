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
       
        
        public string[] AddContent(string[] con)
        {

            con = IContent.content;
            var Contented = new string[ISave._publication.Length + con.Length];
            ISave._publication.CopyTo(Contented, 0);
            con.CopyTo(Contented, ISave._publication.Length);
            ISave._publication = Contented;
            return ISave._publication;
        }

    }
}
