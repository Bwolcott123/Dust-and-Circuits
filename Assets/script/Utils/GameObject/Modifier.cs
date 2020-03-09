using UnityEngine;

namespace Utils.GameObject
{
    public class Modifier<T> : MonoBehaviour
    {
        protected T modified;

        protected virtual void Awake()
        {
            modified = GetComponent<T>();
        }
    }
}