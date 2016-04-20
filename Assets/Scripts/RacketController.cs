using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour
{
    public float speed = 2.0f;

    private Transform _trans;

    private void Awake()
    {
        _trans = transform;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            var pos = _trans.localPosition;
            pos.y += Time.deltaTime * speed;
            _trans.localPosition = pos;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            var pos = _trans.localPosition;
            pos.y += Time.deltaTime * speed * -1;
            _trans.localPosition = pos;
        }
    }
}
