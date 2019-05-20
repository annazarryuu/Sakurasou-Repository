using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InGameHoverTextChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Text textButton;
    private Button button;

    void Start()
    {
        textButton = GetComponentInChildren<Text>();
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(textToPink);
    }

    public void textToWhite()
    {
        float r = 255f / 255f;
        float g = 255f / 255f;
        float b = 255f / 255f;
        textButton.color = new Color(r, g, b, 1f);
    }

    public void textToPink()
    {
        float r = 250f / 255f;
        float g = 101f / 255f;
        float b = 147f / 255f;
        textButton.color = new Color(r, g, b, 1f);
    }

    public void OnPointerEnter (PointerEventData eventData)
    {
        textToWhite();
    }

    public void OnPointerExit (PointerEventData eventData)
    {
        textToPink();
    }
}
