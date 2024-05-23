using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopicSpawn : MonoBehaviour
{
   /* public GameObject[] catCards = new GameObject[9];
    public GameObject[] hamsterCards = new GameObject[9];
    public GameObject[] dogCards = new GameObject[9];
    public GameObject[] rabbitCards = new GameObject[9];*/

    public TextMeshProUGUI topicText;
    public string[] allTopics = new string[9];
    public string winText;
    public int topicIndex;
    // Start is called before the first frame update

    void Start()
    {
        topicIndex = Random.Range(0, 8);
        GameObject persistantObj = GameObject.FindGameObjectWithTag("PersistentObj") as GameObject;
        winText = persistantObj.GetComponent<PersistenceScript>().winText;
        
    }  

    // Update is called once per frame
    void Update()
    {
        topicText.text = allTopics[topicIndex];
       /* if (Input.GetMouseButtonDown(0))
        {
            if (winText == "Cat")
            {
                switch (topicIndex)
                {
                    case 0:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(catCards[0], cards.transform.position, Quaternion.identity);
                        break;
                }
            }
            else if (winText == "Dog")
            {
                switch (topicIndex)
                {
                    case 0:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(dogCards[0], cards.transform.position, Quaternion.identity);
                        break;
                }
            }
            else if (winText == "Rabbit")
            {
                switch (topicIndex)
                {
                    case 0:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                }
            }
            else
            {
                switch (topicIndex)
                {

                    case 0:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(rabbitCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(hamsterCards[0], cards.transform.position, Quaternion.identity);
                        break;
                }
            }
        }*/
    }
}

