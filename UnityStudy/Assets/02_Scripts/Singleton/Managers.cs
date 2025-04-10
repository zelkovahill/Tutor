using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Singleton
{
    /// <summary>
    /// 모든 매니저를 통합 관리하는 클래스
    /// </summary>
    public class Managers : MonoBehaviour
    {
        // static 변수로 인스턴스를 하나만 유지
        private static Managers _instance;

        // 외부에서 접근 가능한 싱글톤 인스턴스
        public static Managers Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject go = new GameObject("Managers");
                    _instance = go.AddComponent<Managers>();
                    DontDestroyOnLoad(go);
                }
                return _instance;
            }
        }

        // 매니저들
        public UIManager UI { get; private set; }
        public SoundManager Sound { get; private set; }

        private void Awake()
        {
            Initialize();
        }

        // 매니저 인스턴스들을 생성
        private void Initialize()
        {
            UI = new UIManager();
            Sound = new SoundManager();
        }
    }

    /// <summary>
    /// UI 관련 기능을 담당하는 매니저
    /// </summary>
    public class UIManager
    {
        public void ShowPopup(string message)
        {
            Debug.Log($"[UIManager] 팝업 메세지 : {message}");
        }
    }

    // public class UIManager
    // {
    //     private static UIManager _instance;
    //     public static UIManager Instance => _instance ??= new UIManager();

    //     private UIManager() { }

    //     public void ShowPopup(string message)
    //     {
    //         Debug.Log($"[UIManager] 팝업 메시지: {message}");
    //     }
    // }

    /// <summary>
    /// 사운드 관련 기능을 담당하는 매니저
    /// </summary>
    public class SoundManager
    {
        public void Play(string soundName)
        {
            Debug.Log($"[SoundManager] 사운드 재생 : {soundName}");
        }
    }
}