using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{
    public class AudioManager : SingletonMono<AudioManager>
    {
        public void Play(string soundName)
        {
            Debug.Log($"[AudioManager] {soundName} 재생");
        }
    }
}