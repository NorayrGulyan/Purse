using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SaveLoad.System;
using Data.System;
using Pures.System;
using System;

namespace composite 
{
    public class Composite : IComposite
    {
        ISaveLoad saveLoad;
        IDataSystem data;
        IPures pures;

        int valueFinal;

        public IPures GetPures => pures;

        public Composite(ISaveLoad saveLoad, IDataSystem data, in string name, in string key, in int value = 0)
        {
            this.saveLoad = saveLoad;
            this.data = data;

            string valueLoad = default;

            if (Load(key, out valueLoad))
            {
                int outValue;

                if (ParseToInt(valueLoad, out outValue))
                {
                    pures = new Purse(name, key, outValue);
                }
                else throw new NotSupportedException();
            }
            else
            {
                pures = new Purse(name, key, value);
            }
        }

        public void Save()
        {
            saveLoad.Save.Save(pures.Key, data.Data_.SetFormat(pures.Value.ToString()));
        }

        public bool Load()
        {
            string value;

            bool staus = saveLoad.Load.Load(pures.Key, out value);

            if (staus)
            {
                value = data.Data_.GetFormat(value);

                int valueInt;

                ParseToInt(value, out valueInt);

                pures.SetValue(valueInt);
            }

            return staus;
        }

        private bool Load(in string key, out string value)
        {
            bool staus = saveLoad.Load.Load(key, out value);

            if (staus)
            {
                string valueFormat = data.Data_.GetFormat(value);

                ParseToInt(valueFormat, out valueFinal);
            }

            return staus;
        }

        private bool ParseToInt(in string valueIn, out int outValue)
        {
            try
            {

                outValue = int.Parse(valueIn);

                return true;
            }
            catch (Exception ex)
            {

                Debug.LogWarning($"{ex.Message} |");

                outValue = default;

                return false;
            }
        }
    }
}



