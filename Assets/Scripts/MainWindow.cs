using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class MainWindow : Window
    {
        [SerializeField] private Button workshopButton;


        private void Awake()
        {
            workshopButton.onClick.AddListener(OpenWorkshop);
        }

        private void OpenWorkshop()
        {
            OpenAnotherWindow("WorkshopWindow");
        }
    }
}
