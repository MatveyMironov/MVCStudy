using HealthSystem;

namespace PlayerSystem
{
    public class PlayerModel
    {
        private PlayerDataSO _playerData;

        public HealthModel PlayerHealth { get; }

        public PlayerModel(PlayerDataSO playerData)
        {
            _playerData = playerData;
            PlayerHealth = new(_playerData.MaxHealth);
        }
    }
}