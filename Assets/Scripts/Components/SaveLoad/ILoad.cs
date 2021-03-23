namespace SaveLoad.System
{
    public interface ILoad
    {
        bool Load(in string key, out string value);
    }
}