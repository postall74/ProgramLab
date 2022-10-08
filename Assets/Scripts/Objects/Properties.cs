using UnityEngine;

public class Properties : MonoBehaviour
{
    private const string _IsOpen = "IsOpen";
    private const string _IsClose = "IsClose";

    [SerializeField] private ParticleSystem[] _effects;
    [SerializeField] private Animator _animator;

    private bool _isActive = false;

    public void ShowAbility()
    {
        if (!_isActive)
        {
            _isActive = true;
            for (int i = 0; i < _effects.Length; i++)
                _effects[i].gameObject.SetActive(true);

            _animator.SetBool(_IsOpen, true);
            _animator.SetBool(_IsClose, false);
        }
        else
        {
            _isActive = false;
            for (int i = 0; i < _effects.Length; i++)
                _effects[i].gameObject.SetActive(false);

            _animator.SetBool(_IsClose,true);
            _animator.SetBool(_IsOpen, false);
        }
    }
}
