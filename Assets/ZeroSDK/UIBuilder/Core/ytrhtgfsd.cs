using System;
using UnityEngine;
using ZeroSDK.GameCore.Manager;
using ZeroSDK.UIBuilder.Config;
using ZeroSDK.UIBuilder.Core.UIElements;


namespace ZeroSDK.UIBuilder.Core
{
    public class ytrhtgfsd : hnfgbdfv<ytrhtgfsd>
    {
        [SerializeField] private Camera uiCamera;
        [SerializeField] private werfgtfbhgn werfgtfbhgn;
        [SerializeField] private erwregtrfbhn config;
        [SerializeField] private thygtfrdsd[] screens;

        public Camera UICamera => uiCamera;
        public werfgtfbhgn Effects => werfgtfbhgn;
        public erwregtrfbhn Config => config;

        public override void fhhngbdfgsd()
        {
            var weregtrhn = screens.Length;
            for (var i = 0; i < weregtrhn; i++)
            {
                var ewregtrhgn = screens[i];
                ewregtrhgn.gnhfgbdfv();

                ewregtrhgn.mhnfgbdfvsd();

                if (ewregtrhgn.ShowOnInit)
                {
                    ewregtrhgn.jghngfdfsdgfh();
                }
            }
        }

        public thygtfrdsd mjhngbfvdfdgf(Type type, bool isSolo = true, bool startCallback = true, bool endCallback = true)
        {
            var ewrgehtr = default(thygtfrdsd);
            var rwgrethrn = screens.Length;
            for (var i = 0; i < rwgrethrn; i++)
            {
                var ewtegthrgfnh = screens[i];
                if (ewtegthrgfnh.Ignore) continue;

                if (ewrgehtr == null && ewtegthrgfnh.GetType() == type)
                {
                    ewrgehtr = ewtegthrgfnh;
                    ewtegthrgfnh.egwegwegebrberberb(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        ewtegthrgfnh.erberberber(startCallback, endCallback);
                    }
                }
            }

            return ewrgehtr;
        }


        public T erfgfhgn<T>(bool isSolo = true, bool startCallback = true, bool endCallback = true) where T : thygtfrdsd
        {
            // Debug.Log(typeof(T));
            var rewegtrh = default(thygtfrdsd);
            var wegrehtnr = screens.Length;
            for (var i = 0; i < wegrehtnr; i++)
            {
                var wgrehtnr = screens[i];
                if (wgrehtnr.Ignore) continue;

                if (rewegtrh == null && wgrehtnr is T)
                {
                    rewegtrh = wgrehtnr;
                    wgrehtnr.egwegwegebrberberb(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        wgrehtnr.erberberber(startCallback, endCallback);
                    }
                }
            }

            return rewegtrh as T;
        }


        public T ewrtegtrhtgn<T>(bool isSolo = true, bool startCallback = true, bool endCallback = true)
            where T : thygtfrdsd
        {
            // Debug.Log(typeof(T));
            var werreghrgn = default(thygtfrdsd);
            var wrgreth = screens.Length;
            for (var i = 0; i < wrgreth; i++)
            {
                var wregthgfnh = screens[i];
                if (wregthgfnh.Ignore) continue;

                if (werreghrgn == null && wregthgfnh is T)
                {
                    werreghrgn = wregthgfnh;
                    wregthgfnh.jghngfdfsdgfh(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        wregthgfnh.mhnfgbdfvsd(startCallback, endCallback);
                    }
                }
            }

            return werreghrgn as T;
        }


        public T qwtrethrn<T>(bool startCallback = true, bool endCallback = true) where T : thygtfrdsd
        {
            var ewrgethrn = default(thygtfrdsd);
            var wreeghg = screens.Length;
            for (var i = 0; i < wreeghg; i++)
            {
                var wreegthrn = screens[i];
                if (wreegthrn.Ignore) continue;
                if (ewrgethrn == null && wreegthrn is T)
                {
                    ewrgethrn = wreegthrn;
                    wreegthrn.erberberber(startCallback, endCallback);
                }
            }

            return ewrgethrn as T;
        }


        public T rwetgrhng<T>(bool startCallback = true, bool endCallback = true) where T : thygtfrdsd
        {
            var wreegtrhn = default(thygtfrdsd);
            var wtreghtr = screens.Length;
            for (var i = 0; i < wtreghtr; i++)
            {
                var qewetgrhyt = screens[i];
                if (qewetgrhyt.Ignore) continue;
                if (wreegtrhn == null && qewetgrhyt is T)
                {
                    wreegtrhn = qewetgrhyt;
                    qewetgrhyt.mhnfgbdfvsd(startCallback, endCallback);
                }
            }

            return wreegtrhn as T;
        }


        public T ewregthrnhg<T>()
        {
            var weregtrhnh = screens.Length;
            for (var i = 0; i < weregtrhnh; i++)
            {
                var ujtyhgfdv = screens[i];
                if (ujtyhgfdv is T w)
                {
                    return w;
                }
            }

            return default;
        }
    }
}