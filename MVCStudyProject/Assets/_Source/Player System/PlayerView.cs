using DamageSystem;
using HealthSystem;
using MovementSystem;
using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private MovementView movementView;
        [SerializeField] private HealthView healthView;
        [SerializeField] private DamageFinder damageFinder;

        public Rigidbody2D Rigidbody { get { return GetComponent<Rigidbody2D>(); } }
        public MovementView MovementView { get { return movementView; } }
        public HealthView HealthView { get { return healthView; } }
        public DamageFinder DamageFinder { get {  return damageFinder; } }
    }
}