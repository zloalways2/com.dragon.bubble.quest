using System;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class wgwegwgwegweg : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private Slider music;
        [SerializeField] private Slider sound;

        public event Action OnExitButton
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }

        protected override void qewretgryht()
        {
            {
                var v = PlayerPrefs.GetFloat("Music", 1);
                music.SetValueWithoutNotify(v);
            }

            {
                var v = PlayerPrefs.GetFloat("Effects", 1);
                sound.SetValueWithoutNotify(v);
            }

            music.onValueChanged.AddListener(v => { wgewgwgwegwegwe.ewregtrh.SetGameMusicVolumeSync(v); });

            sound.onValueChanged.AddListener(v => { wgewgwgwegwegwe.ewregtrh.SetGameEffectsVolumeSync(v); });
        }


        protected override void ewregtrhnht()
        {
            ytrhtgfsd.ewregtrh.ewregthrnhg<BackgroundScreen>().rherherherherher();
        }
    }
}