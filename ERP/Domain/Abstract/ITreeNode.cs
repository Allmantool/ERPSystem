using System;
using System.Collections.Generic;

namespace ERP.Domain.Abstract {
    public interface ITreeNode<T> where T : INode<T>, IDisposable {

        ICollection<T> Nodes { get; set; }

        void AddNode(T node);
        void Remove(T node);
    }
}