using System;

namespace HealthSystem
{
    public class HealthModel
    {
        private int _maxHealth;
        private int _currentHealth;

        public HealthModel(int maxHealth)
        {
            _maxHealth = maxHealth;
            ChangeHealth(_maxHealth);
        }

        public int MaxHealth { get { return _maxHealth; } }
        public int CurrentHealth { get { return _currentHealth; } set { ChangeHealth(value); } }

        public event Action OnHealthChanged;
        public event Action OnHealthExpired;

        private void ChangeHealth(int health)
        {
            if (health < 0)
            {
                health = 0;
            }
            else if (health > _maxHealth)
            {
                health = _maxHealth;
            }

            _currentHealth = health;
            OnHealthChanged?.Invoke();

            if (_currentHealth <= 0)
            {
                OnHealthExpired?.Invoke();
            }
        }
    }
}