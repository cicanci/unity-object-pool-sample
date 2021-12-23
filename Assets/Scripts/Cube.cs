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
        _position = transform.position;
        _rotation = transform.rotation;
    }

    private void OnEnable()
    {
        _counter = 0;
        transform.position = _position;
        transform.rotation = _rotation;
    }

    private void Update()
    {
        _counter += Time.deltaTime;
        if (_counter > _timeToLive)
        {
            gameObject.SetActive(false);
        }
    }
}
