using UnityEngine;


namespace ZeroSDK.Utility.Singleton
{
    public abstract class ewregtrhngjm<T> : MonoBehaviour where T : ewregtrhngjm<T>
    {
        private static T erwetgrhng;

        public static T ewregtrh
        {
            get
            {
#if UNITY_EDITOR
                if (!Application.isPlaying && !ewregtrhng)
                {
                    erwetgrhng = FindObjectOfType<T>();
                }
#endif
                return erwetgrhng;
            }
        }

        public static bool ewregtrhng => erwetgrhng != null;


        public virtual void Awake()
        {
            if (!ewregtrhng)
            {
                erwetgrhng = this as T;
            }
        }

        public void ewregtrhtng()
        {
            erwetgrhng = this as T;
        }

        public virtual void OnDestroy()
        {
            erwetgrhng = null;
        }
    }
}