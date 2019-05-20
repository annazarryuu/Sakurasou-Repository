using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSlot : MonoBehaviour
{
    Image image;
    Button button;
    public bool isSelected = false;
    public bool isFilled = false;
    public Button[] buttons;

    void Start()
    {
        if(isFilled)
            image = gameObject.transform.Find("SlotPicture").gameObject.transform.Find("Image").GetComponent<Image>();
        else
            image = gameObject.transform.Find("SlotPicture").GetComponent<Image>();
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(clicked);
    }

    public void selected()
    {
        float r = 150f / 255f;
        float g = 150f / 255f;
        float b = 150f / 255f;
        image.color = new Color(r ,g , b, 1f);
        isSelected = true;
    }

    public void unselected()
    {
        if(isFilled)
        {
            float r = 255f / 255f;
            float g = 255f / 255f;
            float b = 255f / 255f;
            image.color = new Color(r ,g , b, 1f);
        }
        else
        {
            float r = 200f / 255f;
            float g = 200f / 255f;
            float b = 200f / 255f;
            image.color = new Color(r ,g , b, 1f);
        }
        isSelected = false;
    }

    public void clicked()
    {
        if(isSelected)
        {
            unselected();
        }
        else
        {
            selected();
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<SaveSlot>().unselected();
            }
        }
    }
}
