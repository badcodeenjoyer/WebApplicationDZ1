using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;




namespace Interfaces
{
    public interface IPublish
    {
        public string DoSomething();

        public string[] Publish(IContent content)
        {
            return content.AddContent().ToArray();
        }

    }
}
