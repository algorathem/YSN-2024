using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Canvas canvas;
    private Vector2 pos;
    public GameObject draggableObject;
    public Rect ScreenBounds;
    public bool DrawBoundary;

    private void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
        draggableObject = this.gameObject;

    }

    //Code to handle card zooming
    public void OnHoverEnter()
    {
        Debug.Log("time to zoom");
        gameObject.transform.localScale = new Vector3(2, 2, 2);
    }

    public void OnHoverExit()
    {
        Debug.Log("ZOOM OUT");
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }


    //Code to handle Drag And Drop events
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
        Vector3 draggablePos = draggableObject.transform.position;
        transform.position = canvas.transform.TransformPoint(pos);


    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Debug.Log("OnEndDrag");

    }


    //Code to handle Card boundaries
    void LateUpdate()
    {

        clampToBoundary();
    }

    private void clampToBoundary()
    {
        Rect boundary = ScreenBounds;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax),
            transform.position.z
        );
    }

    void OnDrawGizmos()
    {

        if (!DrawBoundary)
            return;

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(new Vector2(ScreenBounds.xMin, ScreenBounds.yMin), new Vector2(ScreenBounds.xMax, ScreenBounds.yMin));
        Gizmos.DrawLine(new Vector2(ScreenBounds.xMax, ScreenBounds.yMin), new Vector2(ScreenBounds.xMax, ScreenBounds.yMax));

        Gizmos.DrawLine(new Vector2(ScreenBounds.xMin, ScreenBounds.yMax), new Vector2(ScreenBounds.xMin, ScreenBounds.yMin));
        Gizmos.DrawLine(new Vector2(ScreenBounds.xMax, ScreenBounds.yMax), new Vector2(ScreenBounds.xMin, ScreenBounds.yMax));

    }
}