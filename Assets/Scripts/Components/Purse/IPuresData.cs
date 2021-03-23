using System;

namespace Pures.System
{
    public interface IPuresData
    {
        Action<string> ChangeName { get; set; }

        Action<string> ChangeKey { get; set; }

        Action<int> ChangeValue { get; set; }
    }
}
