using script.Game;
using UnityEngine;

namespace Game
{
    public class ChangeWeaponButton : AbstractButton
    {
        public Shoot shoot;
        public Transform spriteContainer;
        public Weapon weapon;
        
        public override void OnClick()
        {
            shoot.weapon = weapon;
            shoot.usedClip = weapon.clip;
            
            foreach (Transform child in spriteContainer)
                Destroy(child.gameObject);
            var g = Instantiate(weapon.sprite, spriteContainer);
            g.gameObject.SetActive(true);
        }
    }
}