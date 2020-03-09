using script.Game;
using UnityEngine;

namespace Game
{
    public class ChangeWeaponButton : AbstractButton
    {
        public Shoot shoot;
        public Transform container;
        public Weapon weapon;
        
        public override void OnClick()
        {
            foreach (Transform child in container)
                Destroy(child.gameObject);
            var g = Instantiate(weapon, container);
            
            shoot.weapon = g;
            shoot.usedClip = g.clip;
        }
    }
}