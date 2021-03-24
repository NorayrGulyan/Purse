using System;

namespace Pures.System
{
    public interface IPures
    {
        string Name { get; }

        int Value { get; }

        string Key { get; }

        Action<string> ChangeName { get; set; }

        Action<string> ChangeKey { get; set; }

        Action<int> ChangeValue { get; set; }

        void Nullify();

        void IncreaseDecrease(in int value);

        void SetValue(in int value);
    }
}