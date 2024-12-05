using UnityEngine;

namespace MovementSystem
{
    public class MovementController
    {
        private MovementModel _movementModel;
        private MovementView _movementView;

        public MovementController(MovementModel movementModel, MovementView movementView)
        {
            _movementModel = movementModel;
            _movementView = movementView;

            _movementModel.OnMovementStarted += ShowMovementEffects;
            _movementModel.OnMovementStoped += ShowStopEffects;
        }

        private void ShowMovementEffects()
        {
            _movementView.AnimateMovement(true);
        }

        private void ShowStopEffects()
        {
            _movementView.AnimateMovement(false);
        }
    }
}