using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private ObjectPoolComponent _cubePool;

    private void Update()
    {
        if (_cubePool == null)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            _cubePool.GetItem();
        }
    }
}
