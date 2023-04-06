using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class WorkshopManager : MonoBehaviour
    {
        [SerializeField] private List<Panel> panels;
        [SerializeField] private Button confirmButton;
        [SerializeField] private Button resetButton;
        [SerializeField] private GarageController garageController;
        [SerializeField] private WorkshopWindow workshopWindow;

        private void Awake()
        {
            confirmButton.onClick.AddListener(ConfirmCustom);
            resetButton.onClick.AddListener(ResetCustom);
        }

        private void ConfirmCustom()
        {
            OpenPanel(ItemType.Car);
            workshopWindow.CloseWorkshopWindow();
        }

        private void ResetCustom()
        {
            garageController.ResetCurrentCar();
            workshopWindow.CloseWorkshopWindow();

        }
        public void OpenPanel(ItemType type)
        {
            bool state = type == ItemType.Car || type == ItemType.Parts;
            panels.ForEach(p => p.Close());
            panels.Find(p => p.GetItemType() == type).Open();
            gameObject.SetActive(!state);
        }
    }
}
