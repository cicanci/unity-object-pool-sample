using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private float _timeToLive = 10;

    private float _counter;
    private Vector3 _position;
    private Quaternion _rotation;

    private void Awake()
    {
        _counter = _timeToLive;
        _position = transform.position;
        _rotation = transform.rotation;
    }

    private void OnEnable()
    {
        _timeToLive = _counter;
        transform.position = _position;
        transform.rotation = _rotation;
    }

    private void Update()
    {
        _timeToLive -= Time.deltaTime;
        if (_timeToLive < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
