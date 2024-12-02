using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] private BallInputController BallInputController;

    public Vector3 GetBallDirection(){
        return BallInputController.ballDirection;
    }
}