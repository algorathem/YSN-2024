using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour
{
    public bool isDragging = false;
    private Vector2 pos;
    private Camera mainCamera_m;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera_m = Camera.main;
    }
    
    public void StartDrag()
    {
        isDragging = true;
        print("start drag");
    }

    public void EndDrag()
    {
        isDragging = false;
        print("end drg");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition.z = mainCamera_m.nearClipPlane;
        mouseposition = mainCamera_m.ScreenToWorldPoint(mouseposition);
       
        if (isDragging)
        {

            transform.position = mouseposition;
            print("is dragg");
        }
    }
}
