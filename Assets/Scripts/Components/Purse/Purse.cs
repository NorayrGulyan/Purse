using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Pures.System
{
    internal sealed class Purse : PurseData, IPures
    {

        public new string Name { get => base.Name; }

        public new int Value { get => base.Value; }

        public new string Key { get => base.Key; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="key">Key</param>
        /// <param name="value"> Value</param>
        internal Purse(in string name,in string key,in int value = 0)
        {
            base.Name = name;
            base.Key = key;
            base.Value = value;
        }

        public void Nullify()
        {
            base.Value = 0;
        }

        public void IncreaseDecrease(in int value)
        {
            base.Value += value;
        }

        public void SetValue(in int value)
        {

            base.Value = value;
        }

    }
}


