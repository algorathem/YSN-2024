using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSpawn : MonoBehaviour
{
    public GameObject catAction;
    public GameObject dogAction;
    public GameObject rabbitAction;
    public GameObject hamsterAction;

    //public Canvas canvas;

    private int actionCardCount = 0;
    private string animalText;
    
    private void Awake()
    {
        animalText = GameObject.FindGameObjectWithTag("PersistentObj").GetComponent<PersistenceScript>().winText;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        print("click once");
        if (actionCardCount < 3)
        {
            switch (animalText)
            {
                case "Cat":
                    Instantiate(catAction, transform.position, Quaternion.identity);
                    break;
                case "Dog":
                    Instantiate(dogAction, transform.position, Quaternion.identity);
                    break;
                case "Rabbit":
                    Instantiate(rabbitAction, transform.position, Quaternion.identity);
                    break;
                case "Hamster":
                    Instantiate(hamsterAction, transform.position, Quaternion.identity);
                    break;
            }
                actionCardCount++;
        }
        else
        {
            print( "You only have 3 action cards.");
        }
    }
}


