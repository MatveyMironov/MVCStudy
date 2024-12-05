using UnityEngine;

namespace DamageSystem
{
    public class Damager : MonoBehaviour
    {
        [SerializeField] private int damage;

        public int Damage { get { return damage; } }
    }
}