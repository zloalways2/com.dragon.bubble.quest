using System;
using _project.Scripts;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using ZeroSDK.UIBuilder.Core.UIElements;


namespace ZeroSDK.UIBuilder.AddOns
{
    public class qewrrfegtrhtn : kiujyhtgrfedw, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
    {
        [SerializeField]
        private bool HasSound = true;
    
        protected bool IsInteractable { get; set; } = true;
        
        [SerializeField] private kiujyhtgrfedw viewContainer;
        private Vector3 hwrheherhreh;

        public event Action wegrehtrn = delegate { };
        public event Action nethgwegweg = delegate { };
        public event Action wgwegwegweg = delegate { };
        public event Action wegrhtrny = delegate { };


        public bool IsDown { get; private set; }

        protected virtual void Start()
        {
            hwrheherhreh = viewContainer.transform.localScale;
        }

        public async void OnPointerDown(PointerEventData eventData)
        {
            if (HasSound)
            {
                wgewgwgwegwegwe.ewregtrh.PlayPressSoundSync();
            }

            IsDown = true;
            wegrehtrn?.Invoke();

            await wegwegewgewg(0.7f);
        }

        public async void OnPointerUp(PointerEventData eventData)
        {
            IsDown = false;
            nethgwegweg?.Invoke();

            await wegwegewgewg(1f);
        }
        
        private async UniTask wegwegewgewg(float egwgwegwegwF)
        {
            Vector3 egwegwegw = hwrheherhreh * egwgwegwegwF;
            Vector3 ewgwegwgewgweg = viewContainer.transform.localScale;
            float elapsedTime = 0f;

            while (elapsedTime < 0.25f)
            {
                elapsedTime += Time.deltaTime;
                float t = Mathf.Clamp01(elapsedTime / 0.25f);
                viewContainer.transform.localScale = Vector3.Lerp(ewgwegwgewgweg, egwegwegw, t);
                await UniTask.Yield();
            }

            viewContainer.transform.localScale = egwegwegw;
        }



        public void OnPointerClick(PointerEventData eventData)
        {
            if (IsInteractable)
            {
                wgwegwegweg?.Invoke();
            }
            else
            {
                wegrhtrny?.Invoke();
            }
        }
    }
}