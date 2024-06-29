using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    public bool isCorrectSlot;
    public static float health = 2;
    private HealthManager healthParent;
  
  
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Ondrop");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthManager healthParent = GameObject.FindGameObjectWithTag("HealthParent").GetComponent<HealthManager>();
       
        healthParent.ResetHeart();
        if (isCorrectSlot)
        {
            if (collision.gameObject.GetComponent<ActionFlipAnim>().isCorrect == true)
            {
                health++;
                healthParent.CreateNewHeart();
                print("add");
            }
            else if(collision.gameObject.GetComponent<ActionFlipAnim>().isCorrect == false)
            {
                health--;
                healthParent.CreateNewHeart();
                print("del");
            }
            
        }
        else if (!isCorrectSlot)
        {
            if (collision.gameObject.GetComponent<ActionFlipAnim>().isCorrect == true)
            {
                health--;
                healthParent.CreateNewHeart();
            }
            else if (collision.gameObject.GetComponent<ActionFlipAnim>().isCorrect == false)
            {
                health++;
                healthParent.CreateNewHeart();
            }
           
        }
    }


}
