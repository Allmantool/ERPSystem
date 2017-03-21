using System;
using System.Collections.Generic;

namespace ERP.Domain.Abstract {
    /// <summary>
    /// Узел
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface INode<T> where T : INode<T>, IDisposable {
        T _children { get; set; }
        ICollection<T> Ancestors { get; set; }
        ICollection<T> Descendants { get; set; }
        ICollection<T> Siblings { get; set; }
        int Depth { get; set; }
        T Root { get; set; }
        T Parent { get; set; }

        void AddChild(T child);
    }
}