using UnityEngine;

namespace MovementSystem
{
    public class InputListener : MonoBehaviour
    {
        private MovementModel _movementModel;

        private Vector2 _movementInput;

        private void Update()
        {
            GetMovementInput();
        }

        public void Setup(MovementModel movementModel)
        {
            _movementModel = movementModel;
        }

        private void GetMovementInput()
        {
            _movementInput.x = Input.GetAxis("Horizontal");
            _movementInput.y = Input.GetAxis("Vertical");

            if (_movementModel != null)
            {
                _movementModel.SetMovementDirection(_movementInput);
            }
        }
    }
}