using ERP.Domain.Abstract;
using System;
using System.Dynamic;
using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder;
using System.Runtime.CompilerServices;

namespace ERP.Domain.Concrete {
    public abstract class Node<T> : DynamicObject, INode<T> where T : class, INode<T>{
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

        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}