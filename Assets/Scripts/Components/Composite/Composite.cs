using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SaveLoad.System;
using Data.System;
using Pures.System;
using System;

namespace composite 
{
    public sealed class Composite : IComposite
    {
        ISaveLoad saveLoad;
        IData data;
        IPures pures;

        int valueFinal;

        public string Name => pures.Name;

        public int Value => pures.Value;

        public string Key => pures.Key;

        public Action<string> ChangeName { get => pures.ChangeName; set => pures.ChangeName = value; }

        public Action<string> ChangeKey { get => pures.ChangeKey; set => pures.ChangeKey = value ; }

        public Action<int> ChangeValue { get => pures.ChangeValue; set => pures.ChangeValue = value; }

        public Composite(ISaveLoad saveLoad, IData data, in string name, in string key, in int value = 0)
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
            saveLoad.Save.Save(pures.Key, data.SetFormat(pures.Value.ToString()));
        }

        public bool Load()
        {
            string value;

            bool staus = saveLoad.Load.Load(pures.Key, out value);

            if (staus)
            {
                value = data.GetFormat(value);

                int valueInt;

                ParseToInt(value, out valueInt);

                pures.SetValue(valueInt);
            }

            return staus;
        }

        public void Nullify() => pures.Nullify();

        public void IncreaseDecrease(in int value) => pures.IncreaseDecrease(value);

        public void SetValue(in int value) => pures.SetValue(value);

        private bool Load(in string key, out string value)
        {
            bool staus = saveLoad.Load.Load(key, out value);

            if (staus)
            {
                string valueFormat = data.GetFormat(value);

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



