using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuUI;
     
    [SerializeField] private GameObject defaultImageObj;
    [SerializeField] private GameObject activImageObj;

    [SerializeField] private List<GameObject> defaultObjects;
    [SerializeField] private List<GameObject> activeObjects;  
    public void OpenMenuButton()
    {
        CloseMenuButton();
        defaultImageObj.gameObject.SetActive(false); 
        activImageObj.gameObject.SetActive(true);
        MenuUI.gameObject.SetActive(true);
    }

    public void CloseMenuButton()
    { 
        MenuUI.gameObject.SetActive(false);
        foreach(GameObject go in activeObjects)
        {
            go.SetActive(false);
        }
        foreach (GameObject go in defaultObjects)
        {
            go.SetActive(true);
        }
    }
 
}
