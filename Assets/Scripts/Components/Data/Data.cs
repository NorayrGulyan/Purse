using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.System
{
    public enum DataMode
    {
        String,
        Binary
    }

    public sealed class DataSystem : IData
    {
        IData data;

        public DataSystem(DataMode data)
        {
            switch (data)
            {
                case DataMode.String:
                    this.data = new StringData();
                    break;

                case DataMode.Binary:
                    throw new NotImplementedException();
            }
        }

        public string GetFormat(string value) => data.GetFormat(value);

        public string SetFormat(string value) => data.SetFormat(value);
    }
}


