using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadButton : MonoBehaviour
{
    public Button[] buttons;

    void Update()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            if(buttons[i].GetComponent<SaveSlot>().isSelected && buttons[i].GetComponent<SaveSlot>().isFilled)
            {
                gameObject.GetComponent<Button>().interactable = true;
                return;
            }
        }

        gameObject.GetComponent<Button>().interactable = false;
    }
}
