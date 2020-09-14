using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;

namespace MVVMC.iOS.Scenes
{
    public abstract class CoordinatorBase : ICoordinator
    {
        protected readonly UINavigationController navigationController;

        public CoordinatorBase(UINavigationController navigationController)
        {
            this.navigationController = navigationController;
        }

        public abstract void Start();

        public virtual void ChildFinished(ICoordinator child)
        {
        }
    }
}
