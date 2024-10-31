using HealthSystem;
using PlayerSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerView playerViewPrefab;

        [Space]
        [SerializeField] private PlayerDataSO playerData;

        void Start()
        {
            PlayerView playerView = Instantiate(playerViewPrefab);
            HealthModel playerHealthModel = new(playerData.MaxHealth);
            HealthController playerController = new(playerModel, playerView);
        }
    }
}