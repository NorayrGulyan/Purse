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
        IData data;

        CompositeFactory compositeFactory;

        public List<IComposite> Purses { get; private set; } = new List<IComposite>();

        private void Awake()
        {
            saveLoadSystem = new SaveLoadSystem(SaveLoadMode.PlayerPrefs);

            data = new DataSystem(DataMode.String);

            compositeFactory = new CompositeFactory(saveLoadSystem, data);

            CreatePurse();
        }

        private void CreatePurse()
        {
            Purses.Add(compositeFactory.NewComposite("coins", "coins", 100));
            Purses.Add(compositeFactory.NewComposite("crystals", "crystals", 10));
        }
    }
}


