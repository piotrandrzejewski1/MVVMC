using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVMC.iOS.Scenes
{
    public abstract class CoordinatorBase : ICoordinator
    {
        private List<ICoordinator> children = new List<ICoordinator>();

        public void AddChild(ICoordinator child)
        {
            children.Add(child);
        }

        public void RemoveChild(ICoordinator child)
        {
            if (!children.Contains(child))
            {
                throw new ArgumentException($"Couldn't remove coordinator: {child}. It's not a child coordinator.");
            }

            children.Remove(child);
        }

        public void RemoveChildren()
        {
            children.Clear();
        }

        public abstract void Start();

        public abstract void Finish();
    }
}
