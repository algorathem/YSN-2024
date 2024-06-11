using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndDrag : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //If you use 2D sprite as drop target, use this code

    public Collider2D collider2d;

    private Canvas canvas;
    public Rect ScreenBounds;
    public bool DrawBoundary;
    private Vector2 pos;





    private void Awake()
    {
     
        collider2d = GetComponent<Collider2D>();
        canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
       
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        collider2d.enabled = false;
        print("begin");
       
    }
    public void OnDrag(PointerEventData eventData)
    {
        /* transform.position = eventData.pointerCurrentRaycast.worldPosition;*/
        
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out pos);
        Vector3 draggablePos = transform.position;
        transform.position = canvas.transform.TransformPoint(pos);
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        collider2d.enabled = true;
        Debug.Log("end");

    }

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

