using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSpawn : MonoBehaviour
{
    List<GameObject> catActionList = new List<GameObject>();
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;
    //public GameObject catAction;
    List<GameObject> dogActionList = new List<GameObject>();
    public GameObject dog1;
    public GameObject dog2;
    public GameObject dog3;
    //public GameObject dogAction;
    List<GameObject> rabbitActionList = new List<GameObject>();
    public GameObject rabbit1;
    public GameObject rabbit2;
    public GameObject rabbit3;
    //public GameObject rabbitAction;
    List<GameObject> hamsterActionList = new List<GameObject>();
    public GameObject hamster1;
    public GameObject hamster2;
    public GameObject hamster3;
    //public GameObject hamsterAction;

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

        if (actionCardCount < 3)
        {
            switch (animalText)
            {
                case "Cat":
                    //Instantiate(catAction, transform.position, Quaternion.identity);
                    catActionList.Add(cat1);
                    catActionList.Add(cat2);
                    catActionList.Add(cat3);

                    int catIndex = UnityEngine.Random.Range(0, 3);
                    Instantiate(catActionList[catIndex]);

                    break;
                case "Dog":
                    //Instantiate(dogAction, transform.position, Quaternion.identity);
                    dogActionList.Add(dog1);
                    dogActionList.Add(dog2);
                    dogActionList.Add(dog3);

                    int dogIndex = UnityEngine.Random.Range(0, 3);
                    Instantiate(dogActionList[dogIndex]);
                    break;
                case "Rabbit":
                    //Instantiate(rabbitAction, transform.position, Quaternion.identity);
                    rabbitActionList.Add(rabbit1);
                    rabbitActionList.Add(rabbit2);
                    rabbitActionList.Add(rabbit3);

                    int rabbitIndex = UnityEngine.Random.Range(0, 3);
                    Instantiate(rabbitActionList[rabbitIndex]);
                    break;
                case "Hamster":
                    //Instantiate(hamsterAction, transform.position, Quaternion.identity);
                    hamsterActionList.Add(hamster1);
                    hamsterActionList.Add(hamster2);
                    hamsterActionList.Add(hamster3);

                    int hamsterIndex = UnityEngine.Random.Range(0, 3);
                    Instantiate(hamsterActionList[hamsterIndex]);
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


