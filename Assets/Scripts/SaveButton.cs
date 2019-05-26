using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public Button[] buttons;

    void Update()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            if(buttons[i].GetComponent<SaveSlot>().isSelected)
            {
                gameObject.GetComponent<Button>().interactable = true;
                return;
            }
        }

        gameObject.GetComponent<Button>().interactable = false;
    }
}
