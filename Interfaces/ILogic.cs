﻿

namespace Interfaces
{
    public interface ILogic
    {
        public string DoSomething();
        public void DoAllLogic(IPublish publish, IContent content, ICheck check, ISave save);
    }
}
