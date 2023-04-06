using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Window : MonoBehaviour
    {
        [SerializeField] private string windowName;

        public Action<string> OnOpenAnotherWindow;

        public string GetName()
        {
            return windowName;
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }

        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void OpenAnotherWindow(string windowName)
        {
            OnOpenAnotherWindow?.Invoke(windowName);
        }
    }
}
