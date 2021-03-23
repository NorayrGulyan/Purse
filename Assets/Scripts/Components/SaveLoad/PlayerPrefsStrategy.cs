using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveLoad.System
{
    public struct PlayerPrefsStrategy : ISave, ILoad
    {
        /// <summary>
        /// Saves data using PlayerPrefs
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>

        public void Save(in string key,in string value)
        {
            PlayerPrefs.SetString(key, value);
        }
        
        /// <summary>
        /// Load data using PlayerPrefs
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">Out Value</param>
        /// <returns>Status</returns>

        public bool Load(in string key, out string value)
        {
            if (PlayerPrefs.HasKey(key))
            {
                value = PlayerPrefs.GetString(key);
                return true;
            }
            else
            {
                value = "";
                return false;
            }

        }
    }
}


