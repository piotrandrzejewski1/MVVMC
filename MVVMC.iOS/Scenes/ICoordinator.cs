using System;
namespace MVVMC.iOS.Scenes
{
    public interface ICoordinator
    {
        void Start();

        void Finish();

        void AddChild(ICoordinator child);

        void RemoveChild(ICoordinator child);

        void RemoveChildren();
    }
}
