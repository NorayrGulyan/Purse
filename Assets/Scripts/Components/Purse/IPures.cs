
namespace Pures.System
{
    public interface IPures
    {
        string Name { get; }

        int Value { get; }

        string Key { get; }

        IPuresData PuresData { get; }

        void Nullify();

        void IncreaseDecrease(in int value);

        void Save();

        void Load();
    }
}