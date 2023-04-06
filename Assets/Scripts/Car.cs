using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Car : MonoBehaviour
    {
        [SerializeField] private int carId;
        [SerializeField] private ItemType type;
        [SerializeField] private List<PartsHolder> partsHolders;
        [SerializeField] private CarPaint carPaint;

        public int GetId()
        {
            return carId;
        }

        public void ChangePart(int id, ItemType type)
        {
            partsHolders.Find(h => h.GetItemType() == type).SelectPart(id);
        }

        public void ChangePaint(int id)
        {
            carPaint.PaintCar(id);
        }

        public void ResetParts()
        {
            partsHolders.ForEach(h => h.ResetToDefault());
            carPaint.ResetPaint();
        }

        public void Select()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
