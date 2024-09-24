using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;


namespace ZeroSDK.UIBuilder.Core.UIElements
{
    [RequireComponent(typeof(CanvasGroup))]
    public class kiujyhtgrfedw : MonoBehaviour
    {
        public CanvasGroup CG;
        public RectTransform Rect;

        [HideInInspector] public Action hytgrfedw = delegate { };
        [HideInInspector] public Action mjhnygtbrvfeds = delegate { };
        [HideInInspector] public Action ikujythgrefdws = delegate { };
        [HideInInspector] public Action ikujyhtgrefdws = delegate { };
        [HideInInspector] public Queue<Action> ewfrgthyn = new Queue<Action>();
        [HideInInspector] public Queue<Action> ewrgtrhytn = new Queue<Action>();
        [HideInInspector] public Queue<Action> yhtujyh = new Queue<Action>();
        [HideInInspector] public Queue<Action> qewregtrhytnj = new Queue<Action>();



        public void gnhfgbdfv()
        {
            hytgrfedw += ewregtrhnht;
            mjhnygtbrvfeds += ewregtrhngj;
            ikujythgrefdws += wegretrhnh;
            ikujyhtgrefdws += wreegtrhn;

            ikujyhtgrefdws += ewregtrhn;
            hytgrfedw += wreegtrhghng;

            hytgrfedw += () => erwtegtrhynthjg(ewfrgthyn);
            mjhnygtbrvfeds += () => erwtegtrhynthjg(ewrgtrhytn);
            ikujythgrefdws += () => erwtegtrhynthjg(yhtujyh);
            ikujyhtgrefdws += () => erwtegtrhynthjg(qewregtrhytnj);

            qewretgryht();

            if (!gameObject.activeSelf)
            {
                mhnfgbdfvsd(false, false);
            }
        }


        public async UniTask egwegwegebrberberb(bool qwergtrh = true, bool weregtrhg = true)
        {
            if(CG.alpha > 0.99f)
                return;
            
            if (qwergtrh)
                hytgrfedw?.Invoke();

            float weregtrhng = 0f;

            while (weregtrhng < 0.15f)
            {
                weregtrhng += Time.deltaTime;
                CG.alpha = Mathf.Clamp01(weregtrhng / 0.15f);
                await UniTask.Yield();
            }

            CG.alpha = 1f;
            CG.blocksRaycasts = true;

            if (weregtrhg)
                mjhnygtbrvfeds?.Invoke();
        }


        public void jghngfdfsdgfh(bool wreegtrhfng = false, bool rwregtfhn = true, bool erwfregtrgnh = true)
        {
            if (rwregtfhn)
                hytgrfedw?.Invoke();

            CG.alpha = 1;
            CG.blocksRaycasts = true;
            
            if (erwfregtrgnh)
                mjhnygtbrvfeds?.Invoke();
        }

        public async UniTask erberberber(bool ewregtrhfn = true, bool wqrewgrethr = true)
        {
            
            if(CG.alpha < 0.01f)
                return;
            
            if (ewregtrhfn)
                hytgrfedw?.Invoke();

            float elapsedTime = 0f;

            while (elapsedTime < 0.15f)
            {
                elapsedTime += Time.deltaTime;
                CG.alpha = Mathf.Clamp01(1 - (elapsedTime / 0.15f));
                await UniTask.Yield();
            }

            CG.alpha = 0f;
            CG.blocksRaycasts = false;

            if (wqrewgrethr)
                mjhnygtbrvfeds?.Invoke();
        }


        public void mhnfgbdfvsd(bool startCallback = true, bool endCallback = true)
        {
            if (startCallback)
                ikujythgrefdws?.Invoke();

            CG.blocksRaycasts = false;
            CG.alpha = 0;
            
            if (endCallback)
                ikujyhtgrefdws?.Invoke();
        }

        public void wreegtrhghng()
        {
            gameObject.SetActive(true);
        }


        public void ewregtrhn()
        {
            gameObject.SetActive(false);
        }


        protected virtual void qewretgryht()
        {
        }


        protected virtual void ewregtrhnht()
        {
        }


        protected virtual void ewregtrhngj()
        {
        }


        protected virtual void wegretrhnh()
        {
        }


        protected virtual void wreegtrhn()
        {
        }


        private void erwtegtrhynthjg(Queue<Action> queue)
        {
            while (queue.Count > 0)
            {
                queue.Dequeue().Invoke();
            }
        }


#if UNITY_EDITOR
        protected virtual void Reset()
        {
            CG = GetComponent<CanvasGroup>();
            Rect = GetComponent<RectTransform>();
            if (ytrhtgfsd.ewregtrh.Config != null)
            {
                rwegtrhytnh();
            }
        }


        protected virtual void rwegtrhytnh()
        {
        }
#endif
    }
}