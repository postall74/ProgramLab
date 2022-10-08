using UnityEngine;

public class Description : MonoBehaviour
{
    [SerializeField, TextArea] private string _description;

    private void OnEnable() =>
        UIManager.instance.SetDescriptionText(_description);

    private void OnDisable() =>
        UIManager.instance.ClearDescriptionText();
}
