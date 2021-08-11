﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces
{
    public interface ILogic
    {
        public string DoSomething();
        public void DoAllLogic(IPublish publish, IContent content, ICheck check, ISave save);
    }
}
