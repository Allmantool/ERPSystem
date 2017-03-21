using System.Collections.Generic;
using ERP.Domain.Abstract;
using System;

namespace ERP.Domain.Concrete {
    public abstract class TreeNode<T> : ITreeNode<T> where T : INode<T>, IDisposable {
        public ICollection<T> Nodes { get; set; }


        public TreeNode() {
            Nodes = new HashSet<T>();
        }

        public void AddNode(T node) {
            Nodes.Add(node);
        }

        public void Remove(T node) {
            Nodes.Remove(node);
        }
    }
}