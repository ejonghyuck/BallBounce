using UnityEngine;
using System.Collections;

public class BallCheck : MonoBehaviour
{
    // 이 컬라이더에 다른 컬라이더가 들어왔을때 호출됨.
    private void OnTriggerEnter(Collider col)
    {
        // 들어온 컬라이더는 볼일테니까 볼의 컴포넌트 가져옴.
        var ball = col.GetComponent<BallController>();
        // 위로 가는 애는 아래로, 아래로 가는 애는 위로 가게 boolean값 변화.
        ball.isUp = !ball.isUp;
    }
}
