using System;
using System.Collections.Generic;
using UIKit;

namespace MVVMC.iOS.Scenes
{
    public interface ICoordinator
    {
        void Start();

        void ChildFinished(ICoordinator child);
    }
}
