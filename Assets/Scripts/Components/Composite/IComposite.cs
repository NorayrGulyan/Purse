using Pures.System;

namespace composite
{
    public interface IComposite : IPures
    {
        void Save();

        bool Load();
    }
}
