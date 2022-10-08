using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefabs;

    private PoolObjects _pool;

    public void Previous()
    {
        int index = WhoActive();
        if (index == 0)
            return;

        SetInactiveObject(_pool.GetPool().First(p => p.activeSelf == true));
        SetActiveObject(_pool.GetPool()[index - 1]);
    }

    public void Next()
    {
        int index = WhoActive();
        if (index == _pool.GetPool().Count - 1)
            return;

        SetInactiveObject(_pool.GetPool().First(p => p.activeSelf == true));
        SetActiveObject(_pool.GetPool()[index + 1]);
    }


    private void Start()
    {
        _pool = PoolObjects.instance;
        PoolObjects.instance.Initialize(_prefabs);
        _pool.GetPool()[0].SetActive(true);
    }

    private void SetActiveObject(GameObject prefab) =>
        prefab.SetActive(true);

    private void SetInactiveObject(GameObject prefab) =>
        prefab.SetActive(false);

    private int WhoActive()
    {
        int index = -1;

        for (int i = 0; i < _pool.GetPool().Count; i++)
        {
            if (_pool.GetPool()[i].activeSelf)
                index = i;
        }

        return index;
    }
}
