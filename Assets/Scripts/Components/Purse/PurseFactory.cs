using Data.System;
using SaveLoad.System;

namespace Pures.System
{
    public sealed class PurseFactory
    {
        ISaveLoad saveLoad;

        IDataSystem data;

        public PurseFactory(in ISaveLoad saveLoad,in IDataSystem data)
        {
            this.saveLoad = saveLoad;
            this.data = data;
        }

        public IPures NewPurse(in string name,in string key,in int value = 0)
        {
            return new Purse(name, key, saveLoad, data, value);
        }
    }
}


