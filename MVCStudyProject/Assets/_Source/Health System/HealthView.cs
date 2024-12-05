using UnityEngine;

namespace HealthSystem
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private LoadCapacityDisplayer healthDisplayer;

        [Header("Body")]
        [SerializeField] private Renderer bodyRenderer;
        [SerializeField] private Gradient healthGradient;

        public void ShowHealth(int currentHealth, int maxHealth)
        {
            healthDisplayer.DisplayLoadAndCapacity(currentHealth, maxHealth);

            bodyRenderer.material.color = healthGradient.Evaluate(1.0f - ((float)currentHealth / maxHealth));
        }
    }
}