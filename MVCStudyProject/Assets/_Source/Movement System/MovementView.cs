using UnityEngine;

namespace MovementSystem
{
    public class MovementView : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        public void AnimateMovement(bool isMoving)
        {
            animator.SetBool("IsMoving", isMoving);
        }
    }
}