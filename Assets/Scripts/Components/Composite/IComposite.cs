using Pures.System;

namespace composite
{
    public interface IComposite
    {
        IPures GetPures { get; }

        void Save();

        bool Load();
    }
}
