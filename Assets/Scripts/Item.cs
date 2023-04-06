using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private ItemType itemType;
        [SerializeField] private int id;
        [SerializeField] private Toggle itemToggle;
        [SerializeField] private Image image;

        public Action<int, ItemType> OnSelect;

        private void Awake()
        {
            itemToggle.onValueChanged.AddListener(OnSelectItem);
            UpdateStateIcon();
        }
        private void OnSelectItem(bool state)
        {
            UpdateStateIcon();

            if (state)
            {
                OnSelect?.Invoke(id, itemType);
            }
            else
            {
                if (itemToggle.group != null && itemToggle.group.allowSwitchOff)
                {
                    OnSelect?.Invoke(-1, itemType);
                }
            }
        }

        private void UpdateStateIcon()
        {
            if (image != null)
            {
                image.enabled = itemToggle.isOn;
            }
        }

        public int GetId()
        {
            return id;
        }

    }
    public enum ItemType
    {
        Car,
        Tires,
        Grille,
        Weapon,
        Light,
        Parts,
        Paint
    }
}
