using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSwap : MonoBehaviour
{
    // Racket들의 Transform 캐싱.
    public Transform[] rackets;
    // Ball들의 Transform 캐싱.
    public Transform[] balls;

    // 매 업데이트마다 호출됨.
    private void Update()
    {
        // 스페이스바를 눌렀는지 체크.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < rackets.Length; i++)
            {
                // Swap을 위해 임시로 위치값을 캐싱해둠.
                Vector3 tempRacket = rackets[i].localPosition;
                Vector3 tempBall = balls[i].localPosition;
                // 어느거랑 Swap할지 랜덤하게 결정.
                int random = 0;
                do
                {
                    random = Random.Range(0, rackets.Length);
                }
                while (random == i); // 똑같은거랑 Swap할 순 없으니 똑같은 인덱스가 안나오도록 반복문 돌림.

                // 위치 변경.
                var temp = rackets[i].localPosition;
                temp.y = rackets[random].localPosition.y;
                rackets[i].localPosition = temp;

                temp = balls[i].localPosition;
                temp.y = balls[random].localPosition.y;
                balls[i].localPosition = temp;

                temp = rackets[random].localPosition;
                temp.y = tempRacket.y;
                rackets[random].localPosition = temp;

                temp = balls[random].localPosition;
                temp.y = tempBall.y;
                balls[random].localPosition = temp;
            }
        }
    }
}
