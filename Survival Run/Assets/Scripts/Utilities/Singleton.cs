using UnityEngine;

namespace Utilities
{
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField]
        protected bool dontDestroy = true;

        private static T instance;

        public static T Instance
        {
            get
            {
                if (!instance) CreateInstance();
                return instance;
            }
        }

        private void Awake()
        {
            if (!instance) CreateInstance();
            if (instance != this)
                Destroy(gameObject);
            if (dontDestroy)
                DontDestroyOnLoad(gameObject);
        }

        private static void CreateInstance()
        {
            instance = FindObjectOfType<T>();
            if (instance != null) return;
            var obj = new GameObject(typeof(T).ToString());
            instance = obj.AddComponent<T>();
        }
    }
}