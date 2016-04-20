using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour
{
    // Racket의 움직임 속도 조절 필드.
    public float speed = 2.0f;
    // Transform 캐싱용 필드.
    private Transform _trans;

    // 씬 시작시 호출됨.
    private void Awake()
    {
        // Transform 캐싱.
        _trans = transform;
    }

    // 매 업데이트마다 호출됨.
    private void Update()
    {
        // 위쪽 화살표 누르고 있는지 체크.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // speed에 맞춰 위치 변경시킴.
            var pos = _trans.localPosition;
            pos.y += Time.deltaTime * speed;
            _trans.localPosition = pos;
        }
        // 아래쪽 화살표 누르고 있는지 체크.
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            // speed에 맞춰 위치 변경시킴.
            var pos = _trans.localPosition;
            pos.y += Time.deltaTime * speed * -1;
            _trans.localPosition = pos;
        }
    }
}
