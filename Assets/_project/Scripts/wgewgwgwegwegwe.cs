using UnityEngine;
using ZeroSDK.Utility.Singleton;

namespace _project.Scripts
{
    public sealed class wgewgwgwegwegwe : ewregtrhngjm<wgewgwgwegwegwe>
    {
        [SerializeField] private AudioSource musicSource;
        [SerializeField] private AudioSource pressSource;

        public override void Awake()
        {
            base.Awake();
            SetGameMusicVolumeSync(PlayerPrefs.GetFloat("Music", 1));
            SetGameEffectsVolumeSync(PlayerPrefs.GetFloat("Effects", 1));
        }

        public void SetGameMusicVolumeSync(float v)
        {
            musicSource.volume = v;
        }

        public void SetGameEffectsVolumeSync(float v)
        {
            pressSource.volume = v;
        }

        public override void OnDestroy()
        {
            PlayerPrefs.SetFloat("Music", musicSource.volume);
            PlayerPrefs.SetFloat("Effects", pressSource.volume);

            PlayerPrefs.Save();
        }

        public void PlayPressSoundSync() => pressSource.Play();
    }
}