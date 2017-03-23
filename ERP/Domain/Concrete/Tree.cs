using System.Collections.Generic;
using ERP.Domain.Abstract;
using System;

namespace ERP.Domain.Concrete {
    public sealed class Tree<T> : ITree<T> where T : class {
        public ICollection<T> Nodes { get; private set; }

        public Tree() {
            Nodes = new HashSet<T>();
        }

        public void AddNode(T node) {
            Nodes.Add(node);
        }

        public void Remove(T node) {
            Nodes.Remove(node);
        }

        public void RemoveNode(T node) {
            throw new NotImplementedException();
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}