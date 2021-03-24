using Data.System;
using SaveLoad.System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace composite
{
    public sealed class CompositeFactory
    {
        ISaveLoad saveLoad;
        IData data;

        public CompositeFactory(ISaveLoad saveLoad, IData data)
        {
            this.saveLoad = saveLoad;
            this.data = data;
        }

        public IComposite NewComposite(in string name, in string key, in int value = 0)
        {
            return new Composite(saveLoad, data, name, key, value);
        }
    }
}

