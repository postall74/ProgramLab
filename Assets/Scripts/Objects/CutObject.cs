using UnityEngine;

public class CutObject : MonoBehaviour
{
    [SerializeField] private GameObject _fullObject;

    public void Cut()
    {
        if (_fullObject.activeSelf)
            _fullObject.SetActive(false);
        else
            _fullObject.SetActive(true);
    }
}
