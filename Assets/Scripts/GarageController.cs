using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class GarageController : MonoBehaviour
    {
        [SerializeField] private List<Car> cars;

        public Action OnCarChange;

        private Car _currentCar;

        private void Awake()
        {
            _currentCar = cars[0];
            SpawnCar();
        }

        public Car GetCurrentCar()
        {
            return _currentCar;
        }

        public void ChooseCar(int id)
        {
            _currentCar = cars.Find(c => c.GetId() == id);
            SpawnCar();
        }

        private void SpawnCar()
        {
            cars.ForEach(c => c.Hide());
            _currentCar.Select();
            OnCarChange?.Invoke();
        }

        public void ResetCurrentCar()
        {
            _currentCar.ResetParts();
        }

        public void ChangePart(int id, ItemType type)
        {
            _currentCar.ChangePart(id, type);
        }

        public void ChangePaint(int id)
        {
            _currentCar.ChangePaint(id);
        }
    }
}
