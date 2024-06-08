using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    //If you use 2D sprite as drop target, use this code
    
        private SpriteRenderer spriteRenderer;
        private Collider2D collider2d;

        private Canvas canvas;
        private Vector2 pos;

        public Sprite initialSprite;
        public Sprite draggingSprite;   



        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            collider2d = GetComponent<Collider2D>();
            canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
            spriteRenderer.sprite = initialSprite;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            collider2d.enabled = false;
            spriteRenderer.sprite = draggingSprite;
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
            spriteRenderer.sprite = initialSprite;
        }
    



}
