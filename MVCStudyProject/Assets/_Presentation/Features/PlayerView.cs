using HealthSystem;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private LoadCapacityDisplayer healthDisplayer;

        public void ShowHealth(HealthModel playerHealth)
        {
            healthDisplayer.DisplayLoadAndCapacity(playerHealth.CurrentHealth, playerHealth.MaxHealth);
        }
    }
}