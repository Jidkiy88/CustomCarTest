using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private List<Window> windows;

        private void Awake()
        {
            windows.ForEach(w => w.OnOpenAnotherWindow += OpenWindow);
        }

        public void OpenWindow(string windowName)
        {
            windows.ForEach(w => w.Close());
            windows.Find(w => w.GetName() == windowName).Open();
        }

        private void OnDestroy()
        {
            windows.ForEach(w => w.OnOpenAnotherWindow -= OpenWindow);
        }
    }
}
