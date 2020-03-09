using UnityEngine;
using UnityEngine.UI;
using Utils.GameObject;

namespace Game
{
    [RequireComponent(typeof(Button))]
    public abstract class AbstractButton : Modifier<Button>
    {
        void Start()
        {
            modified.onClick.AddListener(OnClick);
        }

        void OnDestroy()
        {
            modified?.onClick?.RemoveListener(OnClick);
        }

        public abstract void OnClick();
    }
}