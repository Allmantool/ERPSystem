using System;
using System.Collections.Generic;

namespace ERP.Domain.Abstract {
    public interface ITree<T> : IDisposable where T : class {
        void AddNode(T node);
        void RemoveNode(T node);
    }
}