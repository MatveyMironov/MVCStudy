namespace HealthSystem
{
    public class HealthController
    {
        private HealthModel _healthModel;
        private HealthView _healthView;

        public HealthController(HealthModel healthModel, HealthView healthView)
        {
            _healthModel = healthModel;
            _healthView = healthView;

            healthModel.OnHealthChanged += ShowHealth;
            ShowHealth();
        }

        private void ShowHealth()
        {
            _healthView.ShowHealth(_healthModel.CurrentHealth, _healthModel.MaxHealth);
        }
    }
}