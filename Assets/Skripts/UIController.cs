using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{ 
    [SerializeField] private GameObject activeHero;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            LeftMouseClick();
        else
            RightMouseClick();
    }

    public void OnPointerEnter(PointerEventData eventData)
    { 
        activeHero.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    { 
        activeHero.gameObject.SetActive(false);
    }
    public virtual void LeftMouseClick()
    {
        Debug.Log(gameObject.name);
    }
    public virtual void RightMouseClick()
    {
        Debug.Log(gameObject.name);
    }
}
