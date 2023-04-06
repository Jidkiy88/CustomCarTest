using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class CarPaint : MonoBehaviour
    {
        [SerializeField] private MeshRenderer meshRenderer;
        [SerializeField] private List<Material> materials;

        public void PaintCar(int id)
        {
            meshRenderer.material = materials[id];
        }

        public void ResetPaint()
        {
            meshRenderer.material = materials[0];
        }
    }
}
