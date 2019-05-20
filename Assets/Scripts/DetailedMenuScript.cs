using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DetailedMenuScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject[] toBeHide;
    public GameObject[] toBeUnhide;
    private bool mutex = false;

    private void switchMenu()
    {
        for(int i = 0; i < toBeHide.Length; i++)
        {
            toBeHide[i].SetActive(false);
        }

        for(int i = 0; i < toBeUnhide.Length; i++)
        {
            toBeUnhide[i].SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !(mutex))
            switchMenu();
    }

    public void goToMainMenu()
    {
         SceneManager.LoadScene("MainMenu");
    }
    
    public void OnPointerEnter (PointerEventData eventData)
    {
        mutex = true;
    }

    public void OnPointerExit (PointerEventData eventData)
    {
        mutex = false;
    }
}
