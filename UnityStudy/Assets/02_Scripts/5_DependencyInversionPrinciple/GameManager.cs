using UnityEngine;

namespace DependencyInversion
{
    public class SoundManager
    {
        public void PlayMusic()
        {
            Debug.Log("배경음 재생");
        }

        public void PlaySoundEffect(string soundName)
        {
            Debug.Log($"효과음 : {soundName} 재생");
        }
    }

    public class GameManager : MonoBehaviour
    {
        private SoundManager _soundManager;

        private void Awake()
        {
            _soundManager = new SoundManager();
        }

        private void Start()
        {
            _soundManager.PlayMusic();
            _soundManager.PlaySoundEffect("StartGame");
        }

    }
}