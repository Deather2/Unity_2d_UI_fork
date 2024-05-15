using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragonAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;
    public Canvas canv;

    private void Start()
    {
        rTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("Izdar?ts klik�is uz velkama objekta!");
    }

    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Uzs?kta vilk�ana!");
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mousePosition.x = Mathf.Clamp(mousePosition.x, 0 + rTransform.rect.width / 2, Screen.width - rTransform.rect.width / 2);
        mousePosition.y = Mathf.Clamp(mousePosition.y, 0 + rTransform.rect.height / 2, Screen.height - rTransform.rect.height / 2);

        rTransform.position = mousePosition;
        Debug.Log("x=" + mousePosition.x + " un y=" + mousePosition.y);
    }

    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("Objekts atlaists, vilk�ana p?rtraukta");
    }
}

