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

    public class DataSystem : IDataSystem
    {
        public IData Data_ { get; private set; }

        public DataSystem(DataMode data)
        {
            switch (data)
            {
                case DataMode.String:
                    Data_ = new StringData();
                    break;

                case DataMode.Binary:
                    throw new NotImplementedException();
            }
        }
    }
}


