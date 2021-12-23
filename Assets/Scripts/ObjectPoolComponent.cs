using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;

    [SerializeField]
    private int _poolSize;

    [SerializeField]
    private bool _allowCreation;

    [SerializeField]
    private List<GameObject> _gameObjects;

    private void Awake()
    {
        _gameObjects = new List<GameObject>(_poolSize);
        for (int i = 0; i < _poolSize; i++)
        {
            _gameObjects.Add(CreateItem());
        }
    }

    private GameObject CreateItem(bool active = false)
    {
        GameObject item = Instantiate(_prefab);
        item.transform.SetParent(gameObject.transform);
        item.SetActive(active);
        return item;
    }

    public GameObject GetItem()
    {
        foreach (GameObject item in _gameObjects)
        {
            if (!item.activeInHierarchy)
            {
                item.SetActive(true);
                return item;
            }
        }

        if (_allowCreation)
        {
            GameObject item = CreateItem(true);
            _gameObjects.Add(item);
            return item;
        }

        return null;
    }
}
