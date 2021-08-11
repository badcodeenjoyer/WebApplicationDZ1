using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IContent 
    {
        public string DoSomething();

        public static string[] content = { "new publication with content" };

        public string[] AddContent()
        {

            string[] con = content;
            var Contented = new string[ISave._publication.Length + con.Length];
            ISave._publication.CopyTo(Contented, 0);
            con.CopyTo(Contented, ISave._publication.Length);
            ISave._publication = Contented;
            return ISave._publication;
        }

    }
}
