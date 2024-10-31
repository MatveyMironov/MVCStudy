using HealthSystem;

namespace PlayerSystem
{
    public class HealthController
    {
        public HealthController(HealthModel healthModel, PlayerView playerView)
        {
            healthModel.OnHealthChanged += () => playerView.ShowHealth(healthModel);
            playerView.ShowHealth(healthModel);
        }
    }
}