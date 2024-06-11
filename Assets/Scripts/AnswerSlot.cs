using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Ondrop");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLIDE");
        Debug.Log("Object that collided with me: " + collision.gameObject.GetComponent<ActionFlipAnim>().isCorrect);
    }


}
