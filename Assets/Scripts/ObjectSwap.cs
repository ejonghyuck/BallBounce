using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSwap : MonoBehaviour
{
    public Transform[] rackets;
    public Transform[] balls;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < rackets.Length; i++)
            {
                Vector3 tempRacket = rackets[i].localPosition;
                Vector3 tempBall = balls[i].localPosition;
                int random = 0;
                do
                {
                    random = Random.Range(0, rackets.Length);
                }
                while (random == i);

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
