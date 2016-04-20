using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    // Ball이 위로 갈지, 아래로 갈지 체크하는 용도의 boolean 필드.
    public bool isUp = true;
    // Ball의 움직임 속도 조절 필드.
    public float speed = 2.0f;
    // Transform 캐싱용 필드.
    private Transform _trans;

    // 씬 시작시 호출됨.
    private void Awake()
    {
        _trans = transform;
    }

    // 매 업데이트마다 호출됨.
    private void Update()
    {
        // speed에 맞춰 위치 변경.
        var pos = _trans.localPosition;
        pos.y += Time.deltaTime * speed * (isUp ? 1 : -1);
        _trans.localPosition = pos;
    }
}
