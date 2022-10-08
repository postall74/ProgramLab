using System.Collections.Generic;
using UnityEngine;

public class PoolObjects : MonoBehaviour
{
    public static PoolObjects instance;

    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;

    private readonly List<GameObject> _pool = new();

    public List<GameObject> GetPool() => _pool;

    public void Initialize(GameObject prefab)
    {
        for (int i = 0; i < _capacity; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.SetActive(false);
            _pool.Add(spawned);
        }
    }

    public void Initialize(GameObject[] prefabs)
    {
        for (int i = 0; i < _capacity; i++)
        {
            GameObject spawned = Instantiate(prefabs[i], _container.transform);
            spawned.SetActive(false);
            _pool.Add(spawned);
        }
    }

    private void Awake()
    {
        if (instance != null)
            return;

        instance = this;
    }
}
