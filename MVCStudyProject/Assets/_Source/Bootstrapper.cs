using DamageSystem;
using HealthSystem;
using MovementSystem;
using PlayerSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;

        [Space]
        [SerializeField] private PlayerView playerViewPrefab;

        [Space]
        [SerializeField] private PlayerDataSO playerData;

        void Start()
        {
            PlayerView playerView = Instantiate(playerViewPrefab);

            Rigidbody2D playerRigidbody = playerView.Rigidbody;
            MovementView playerMovementView = playerView.MovementView;
            MovementModel playerMovementModel = new(playerRigidbody, playerData.MovementSpeed);
            MovementController movementController = new(playerMovementModel, playerMovementView);

            HealthView playerHealthView = playerView.HealthView;
            HealthModel playerHealthModel = new(playerData.MaxHealth);
            HealthController playerHealthController = new(playerHealthModel, playerHealthView);

            DamageFinder playerDamageFinder = playerView.DamageFinder;
            DamageController damageController = new(playerDamageFinder, playerHealthModel);

            inputListener.Setup(playerMovementModel);
        }
    }
}