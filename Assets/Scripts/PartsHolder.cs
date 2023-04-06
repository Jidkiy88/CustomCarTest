using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class PartsHolder : MonoBehaviour
    {
        [SerializeField] private ItemType itemType;
        [SerializeField] private List<GameObject> parts;
        [SerializeField] private int defaultPartId;

        public ItemType GetItemType()
        {
            return itemType;
        }
        public void SelectPart(int id)
        {
            parts.ForEach(p => p.SetActive(false));
            if (id >= 0)
            {
                parts[id].SetActive(true);
            }
        }

        public void ResetToDefault()
        {
            SelectPart(defaultPartId);
        }
    }
}
