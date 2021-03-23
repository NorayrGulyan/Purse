using SaveLoad.System;
using Data.System;
using Pures.System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MVC
{
    public class Model : MonoBehaviour
    {
        [SerializeField]
        Mediator mediator;

        ISaveLoad saveLoadSystem;
        IDataSystem data;
        PurseFactory purseFactory;

        public List<IPures> Purses = new List<IPures>();

        private void Awake()
        {
            saveLoadSystem = new SaveLoadSystem(SaveLoadMode.PlayerPrefs);

            data = new DataSystem(DataMode.String);

            purseFactory = new PurseFactory(saveLoadSystem, data);

            CreatePurse();
        }

        private void CreatePurse()
        {
            Purses.Add(purseFactory.NewPurse("coins", "coins", 100));
            Purses.Add(purseFactory.NewPurse("crystals", "crystals", 10));
        }
    }
}


