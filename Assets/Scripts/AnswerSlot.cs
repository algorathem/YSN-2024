using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    public bool isCorrectSlot;
    public float health;
    public HealthManager healthParent;
    // Start is called before the first frame update
    void Start()
    {
        HealthManager healthParent = GameObject.FindGameObjectWithTag("HealthParent").GetComponent<HealthManager>();
        health = healthParent.health;
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
        //healthParent.ResetHeart();
        if (isCorrectSlot)
        {
            if (collision.gameObject.GetComponent<ActionFlipAnim>().isCorrect == true)
            {
                health++;
                healthParent.CreateNewHeart();
            }
            else if(collision.gameObject.GetComponent<ActionFlipAnim>().isCorrect == false)
            {
                health--;
                healthParent.CreateNewHeart();
            }
            else
            {
                health += 0;
                healthParent.CreateNewHeart();
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
            else
            {
                health+=0;
                healthParent.CreateNewHeart();
            }
        }
    }


}
