using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private Text _hoverText;
    [SerializeField] private TMP_Text _descriptionText;

    public void SetHoverText(string text) => 
        _hoverText.text = text;

    public void ClearHoverText() => 
        _hoverText.text = "";

    public void SetDescriptionText(string text) =>
        _descriptionText.text = text;

    public void ClearDescriptionText() =>
        _descriptionText.text = "";   
    
    private void Awake()
    {
        if (instance != null)
            return;

        instance = this;
    }
}
