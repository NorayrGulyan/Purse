using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class Controller : MonoBehaviour
    {
        [SerializeField]
        Mediator mediator;

        public void Nullify(int index) => mediator.Model.Purses[index].GetPures.Nullify();

        public void IncreaseDecrease(int index, int value) => mediator.Model.Purses[index].GetPures.IncreaseDecrease(value);

        public void Save(int index) => mediator.Model.Purses[index].Save();

        public void Load(int index) => mediator.Model.Purses[index].Load();
    }
}


