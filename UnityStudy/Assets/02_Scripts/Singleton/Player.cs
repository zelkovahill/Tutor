using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{
    public class Player : MonoBehaviour
    {
        private Managers _managers;
        private UIManager _uiManager;

        private void Awake()
        {
            _managers = Managers.Instance;
            _uiManager = new UIManager();
        }

        private void Start()
        {
            _managers.UI.ShowPopup("게임 시작!");
            _managers.Sound.Play("BGM");

            _uiManager.ShowPopup("게임 끝!");
        }
    }
}