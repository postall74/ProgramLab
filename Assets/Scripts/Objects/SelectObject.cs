using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [SerializeField] private Material _selectedMaterial;
    [SerializeField] private string _nameObject;

    private Material _standartMaterial;

    private void Start() => 
        _standartMaterial = GetComponent<Renderer>().material;

    private void OnMouseOver()
    {
        GetComponent<Renderer>().material = _selectedMaterial;
        UIManager.instance.SetHoverText(_nameObject);
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = _standartMaterial;
        UIManager.instance.ClearHoverText();
    }
}
