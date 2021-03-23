using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class Mediator : MonoBehaviour
    {

        [SerializeField]
        Model model;

        [SerializeField]
        Controller controller;

        [SerializeField]
        View view;

        public Model Model { get => model; }

        public Controller Controller { get => controller; }

        public View View { get => view; }
    }
}
