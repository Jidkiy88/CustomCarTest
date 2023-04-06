using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class WorkshopWindow : Window
    {
        [SerializeField] private Button closeButton;
        [SerializeField] private Button customButton;
        [SerializeField] private WorkshopManager workshopManager;

        private void Awake()
        {
            closeButton.onClick.AddListener(CloseWorkshopWindow);
            customButton.onClick.AddListener(OpenCustom);
        }

        private void OnEnable()
        {
            workshopManager.OpenPanel(ItemType.Car);
        }

        public void CloseWorkshopWindow()
        {
            OpenAnotherWindow("MainWindow");
        }

        private void OpenCustom()
        {
            workshopManager.OpenPanel(ItemType.Parts);
        }
    }
}
