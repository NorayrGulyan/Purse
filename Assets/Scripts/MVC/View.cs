using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class View : MonoBehaviour
    {
        [SerializeField]
        Mediator mediator;

        [SerializeField]
        Text textName1,
        textCount1,
        textName2,
        textCount2;


        void Start()
        {
            mediator.Model.Purses[0].ChangeName = TextName1;
            mediator.Model.Purses[0].ChangeValue = TextCount1;
            mediator.Model.Purses[1].ChangeName = TextName2;
            mediator.Model.Purses[1].ChangeValue = TextCount2;

            textName1.text = mediator.Model.Purses[0].Name;
            textCount1.text = mediator.Model.Purses[0].Value.ToString();
            textName2.text = mediator.Model.Purses[1].Name;
            textCount2.text = mediator.Model.Purses[1].Value.ToString();

        }

        private void TextName1(string name) => textName1.text = name;
        private void TextCount1(int value) => textName1.text = value.ToString();
        private void TextName2(string name) => textName1.text = name;
        private void TextCount2(int value) => textName1.text = value.ToString();
    }
}

