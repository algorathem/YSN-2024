using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Canvas canvas;
    private Vector2 pos;

    private void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out pos);
        Vector3 draggablePos = transform.position;
        transform.position = canvas.transform.TransformPoint(pos);
        //print("transform" + " " + transform.position);
        //print("draggablex" + " " + draggablePos.x);
        //print("draggabley" + " " + draggablePos.y);
        if (draggablePos.x <= -8)
        {
            print("outofbound");
            draggablePos.x = -8;
        }

        if (draggablePos.x >= 8)
        {
            print("outofbound");
            draggablePos.x = 8;
        }

        if (draggablePos.y <= -3)
        {
            draggablePos.y = -3;
            print("outofbound");
        }

        if (draggablePos.y >= 3)
        {
            draggablePos.y = 3;
            print("outofbound");
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

    }
}
