using System;
using System.Collections.Generic;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class ggnrttnehw4gw : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private List<rewgrehtrn> levelButtons;

        public event Action gwegwgwegewg
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }

        public event Action<int> egwegwgewgwegw;

        protected override void qewretgryht()
        {
            for (int i = 0; i < levelButtons.Count; i++)
            {
                var id = i;
                levelButtons[i].wgwegwegweg += () => egwegwgewgwegw?.Invoke(id);
            }
        }

        public void gwegwgewgwegew(int levelsCount)
        {
            for (int i = 0; i < Mathf.Min(levelsCount+1, levelButtons.Count); i++)
            {
                var fadeValue = i < levelsCount+1 ? 1 : 0.16f;
                levelButtons[i].CG.alpha = fadeValue;
            }
        }
        
        protected override void ewregtrhnht() => ytrhtgfsd.ewregtrh.ewregthrnhg<BackgroundScreen>().rherherherherher();
    }
}