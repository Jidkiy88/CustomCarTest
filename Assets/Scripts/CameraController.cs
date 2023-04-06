using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private GarageController garageController;

        [SerializeField] private float sensitivity;

        private Car _currentCar;
        private Vector3 _lookPoint;

        private void Awake()
        {
            garageController.OnCarChange += UpdateCar;
            UpdateCar();
        }

        private void UpdateCar()
        {
            _currentCar = garageController.GetCurrentCar();
        }


        private void Update()
        {
            float horizontalDirection = Input.GetAxis("Horizontal");
            Vector3 axis = new Vector3(0f, -horizontalDirection, 0f);

            transform.RotateAround(_currentCar.transform.position, axis, sensitivity);
            transform.LookAt(_currentCar.transform.position);
        }

        private void OnDestroy()
        {
            garageController.OnCarChange -= UpdateCar;
        }
    }
}
