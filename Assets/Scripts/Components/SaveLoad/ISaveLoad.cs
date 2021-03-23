namespace SaveLoad.System
{
    public interface ISaveLoad
    {
        ISave Save { get; }
        ILoad Load { get; }
    }
}