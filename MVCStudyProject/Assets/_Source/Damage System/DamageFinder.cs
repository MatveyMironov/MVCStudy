using System;
using UnityEngine;

namespace DamageSystem
{
    public class DamageFinder : MonoBehaviour
    {
        public event Action<int> OnDamageRecieved;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.TryGetComponent(out Damager damager))
            {
                OnDamageRecieved?.Invoke(damager.Damage);
            }
        }
    }
}