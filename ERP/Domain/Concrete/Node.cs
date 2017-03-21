using System.Collections.Generic;
using ERP.Domain.Abstract;

namespace ERP.Domain.Concrete {
    public abstract class Node<T> : INode<T> where T : INode<T> {
        public ICollection<T> Ancestors { get; set; }

        public int Depth { get; set; }

        public ICollection<T> Descendants { get; set; }

        public T Parent { get; set; }

        public T Root { get; set; }

        public ICollection<T> Siblings { get; set; }

        protected T Value { get; set; }

        public T _children { get; set; }

        public virtual void AddChild(T child) {
            throw new NotImplementedException();
        }
    }
}