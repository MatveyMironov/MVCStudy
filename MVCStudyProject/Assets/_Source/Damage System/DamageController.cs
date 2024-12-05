using HealthSystem;
using UnityEngine;

namespace DamageSystem
{
    public class DamageController
    {
        private DamageFinder _damageFinder;
        private HealthModel _healthModel;

        public DamageController(DamageFinder damageFinder, HealthModel healthModel)
        {
            _damageFinder = damageFinder;
            _healthModel = healthModel;

            _damageFinder.OnDamageRecieved += ApplyDamage;
        }

        private void ApplyDamage(int damage)
        {
            _healthModel.CurrentHealth -= damage;
        }
    }
}