namespace Data.System
{
    internal struct StringData : IData
    {
        public string GetFormat(string value)
        {
            return value;
        }

        public string SetFormat(string value)
        {
            return value;
        }
    }
}