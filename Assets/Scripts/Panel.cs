using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Panel : MonoBehaviour
    {
        [SerializeField] private ItemType type;
        [SerializeField] private List<Item> items;
        [SerializeField] private WorkshopManager workshopManager;
        [SerializeField] private GarageController garageController;

        private void Awake()
        {
            switch (type)
            {
                case ItemType.Car:
                    {
                        items.ForEach(i => i.OnSelect += OnCarChoose);
                        return;
                    }
                case ItemType.Parts:
                    {
                        items.ForEach(i => i.OnSelect += OnSelectType);
                        return;
                    }
                case ItemType.Paint:
                    {
                        items.ForEach(i => i.OnSelect += OnPaintChoose);
                        return;
                    }
                default:
                    {
                        items.ForEach(i => i.OnSelect += OnPartSelect);
                        return;
                    }
            }
        }
        private void OnSelectType(int id, ItemType type)
        {
            workshopManager.OpenPanel(type);
        }

        private void OnPaintChoose(int id, ItemType type)
        {
            garageController.ChangePaint(id);
        }

        private void OnPartSelect(int id, ItemType type)
        {
            garageController.ChangePart(id, type);
        }

        private void OnCarChoose(int id, ItemType type)
        {
            garageController.ChooseCar(id);
        }

        public ItemType GetItemType()
        {
            return type;
        }

        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }

        private void OnDestroy()
        {
            switch (type)
            {
                case ItemType.Car:
                    {
                        items.ForEach(i => i.OnSelect -= OnCarChoose);
                        return;
                    }
                case ItemType.Parts:
                    {
                        items.ForEach(i => i.OnSelect -= OnSelectType);
                        return;
                    }
                case ItemType.Paint:
                    {
                        items.ForEach(i => i.OnSelect -= OnPaintChoose);
                        return;
                    }
                default:
                    {
                        items.ForEach(i => i.OnSelect -= OnPartSelect);
                        return;
                    }
            }
        }
    }
}
