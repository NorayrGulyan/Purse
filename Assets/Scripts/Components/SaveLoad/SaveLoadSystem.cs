using System;

namespace SaveLoad.System 
{
    public enum SaveLoadMode
    {
        PlayerPrefs,
        Json,
        Xml
    }

    public sealed class SaveLoadSystem : ISaveLoad
    {
        public ISave Save { get; private set; }
        public ILoad Load { get; private set; }

        /// <summary>
        /// Creates save mode ( PlayerPrefs, Json, Xml)
        /// </summary>
        /// <param name="dataMode">Data mode</param>
        /// <exception cref="NotImplementedException">
        /// throws an exception when there is no implementation</exception>
        public SaveLoadSystem(in SaveLoadMode saveLoadMode)
        {
            switch (saveLoadMode)
            {
                case SaveLoadMode.PlayerPrefs:
                    Save = new PlayerPrefsStrategy();
                    Load = new PlayerPrefsStrategy();
                    break;

                case SaveLoadMode.Json:
                    throw new NotImplementedException();

                case SaveLoadMode.Xml:
                    throw new NotImplementedException();
            }
        }
    }
}


