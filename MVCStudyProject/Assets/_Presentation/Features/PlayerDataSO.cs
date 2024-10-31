using UnityEngine;

namespace PlayerSystem
{
    [CreateAssetMenu(fileName = "NewPlayerData", menuName = "Player/Player Data")]
    public class PlayerDataSO : ScriptableObject
    {
        [field: SerializeField] public int MaxHealth { get; private set; }
    }
}