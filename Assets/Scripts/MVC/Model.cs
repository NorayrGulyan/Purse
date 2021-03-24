using SaveLoad.System;
using Data.System;
using System.Collections.Generic;
using UnityEngine;
using composite;

namespace MVC
{
    public class Model : MonoBehaviour
    {
        [SerializeField]
        Mediator mediator;

        ISaveLoad saveLoadSystem;
        IDataSystem data;

        public List<IComposite> Purses { get; private set; } = new List<IComposite>();

        private void Awake()
        {
            saveLoadSystem = new SaveLoadSystem(SaveLoadMode.PlayerPrefs);

            data = new DataSystem(DataMode.String);

            CreatePurse();
        }

        private void CreatePurse()
        {
            Purses.Add(new Composite(saveLoadSystem, data, "coins", "coins", 100));
            Purses.Add(new Composite(saveLoadSystem, data, "crystals", "crystals", 10));
        }
    }
}


