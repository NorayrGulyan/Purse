using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SaveLoad.System;
using Data.System;

namespace Pures.System
{
    internal class Purse : PurseData, IPures
    {

        ISaveLoad saveLoad;

        IDataSystem data;

        public new string Name { get => base.Name; }

        public new int Value { get => base.Value; }

        public new string Key { get => base.Key; }

        public IPuresData PuresData => this;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="key">Key</param>
        /// <param name="data">Data</param>
        /// <param name="saveLoad">ISaveLoad</param>
        /// <param name="value"> Value</param>
        internal Purse(in string name,in string key,in ISaveLoad saveLoad,in IDataSystem data,in int value = 0)
        {
            this.saveLoad = saveLoad;

            this.data = data;

            string valueLoad = default;

            if (Load(key, out valueLoad))
            {
                base.Name = name;
                base.Key = key;
                int outValue;

                if (ParseToInt(valueLoad, out outValue))
                {
                    base.Value = outValue;
                }
            }
            else
            {
                base.Name = name;
                base.Key = key;
                base.Value = value;
            }
        }

        public void Nullify()
        {
            base.Value = 0;
        }

        public void IncreaseDecrease(in int value)
        {
            base.Value += value;
        }

        public void Save()
        {
            saveLoad.Save.Save(Key, data.Data_.SetFormat(Value.ToString()));
        }

        public void Load()
        {
            string value;

            bool staus = saveLoad.Load.Load(Key, out value);

            value = data.Data_.GetFormat(value);

            int valueInt;

            ParseToInt(value, out valueInt);

            base.Value = valueInt;
        }

        private bool Load(in string key, out string value)
        {
            bool staus = saveLoad.Load.Load(key, out value);

            value = data.Data_.GetFormat(value);

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


