using System;

namespace Pures.System
{
    internal abstract class PurseData : IPuresData
    {
        string name;
        protected string Name
        {
            get => name;
            set
            {
                ChangeName?.Invoke(value);
                name = value;
            }
        }

        /// <summary>
        /// Called when the name changed
        /// </summary>
        public Action<string> ChangeName { get; set; }

        string key;
        protected string Key
        {
            get => key;
            set
            {
                ChangeKey?.Invoke(value);
                key = value;
            }
        }

        /// <summary>
        /// Called when the key changed
        /// </summary>
        public Action<string> ChangeKey { get; set; }

        int value;
        protected int Value
        {
            get => value;
            set
            {
                ChangeValue?.Invoke(value);
                this.value = value;
            }
        }

        /// <summary>
        /// Called when the value changed
        /// </summary>
        public Action<int> ChangeValue { get; set; }
    }
}


