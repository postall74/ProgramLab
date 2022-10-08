using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private PoolObjects _pool;

    public void Cut()
    {
        for (int i = 0; i < _pool.GetPool().Count; i++)
        {
            if (_pool.GetPool()[i].TryGetComponent(out CutObject obj))
                obj.Cut();
        }
    }

    public void Decomposition()
    {
        for (int i = 0; i < _pool.GetPool().Count; i++)
        {
            if (_pool.GetPool()[i].TryGetComponent(out Decomposition obj))
                obj.DecompositionParts();
        }
    }


    public void Ability()
    {
        for (int i = 0; i < _pool.GetPool().Count; i++)
        {
            if (_pool.GetPool()[i].TryGetComponent(out Properties obj))
                obj.ShowAbility();
        }
    }

    private void Start() =>
        _pool = PoolObjects.instance;
}
