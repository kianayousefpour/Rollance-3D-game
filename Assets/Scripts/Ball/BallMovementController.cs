using UnityEngine;

public class BallMovmentController : MonoBehaviour
{
    [SerializeField] private BallDataTransmiter BallDataTransmiter;
    [SerializeField] private float ballMoveSpeed;

    private void Update(){
        SetBallMovement();
    }
    private void SetBallMovement(){
        transform.position += BallDataTransmiter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
