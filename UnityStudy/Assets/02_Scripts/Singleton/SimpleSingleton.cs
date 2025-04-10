using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingleton : MonoBehaviour
{
    private static SimpleSingleton _instance;

    public static SimpleSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SimpleSingleton>();

                if (_instance == null)
                {
                    GameObject go = new GameObject(typeof(SimpleSingleton).Name);
                    _instance = go.AddComponent<SimpleSingleton>();
                    DontDestroyOnLoad(go);
                }
            }
            return _instance;
        }
    }

    public void Test()
    {
        Debug.Log("이게 뜨면 싱글톤이 잘 작동하는거다.");
    }
}
