using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public bool isUp = true;

    public float speed = 2.0f;

    private Transform _trans;

    private void Awake()
    {
        _trans = transform;
    }

    private void Update()
    {
        var pos = _trans.localPosition;
        pos.y += Time.deltaTime * speed * (isUp ? 1 : -1);
        _trans.localPosition = pos;
    }
}
