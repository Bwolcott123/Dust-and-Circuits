using UnityEngine;

namespace script.Game
{
    public class Weapon : MonoBehaviour
    {
        public int clip = 30; // # of shots per reload
        public int rof = 60; // # of hit checks per burst
        public float spread; //max disdens from target miss can landed
        public float damage = 5; //how much it hurts
        public float reload = 1; //time to reload
        public int accuracy = 5; //chance to hit
        
        [Tooltip("Weapon picture, may be empty")] public Transform sprite;
    }
}