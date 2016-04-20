using UnityEngine;
using System.Collections;

public class BallCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        var ball = col.GetComponent<BallController>();
        ball.isUp = !ball.isUp;
    }
}
