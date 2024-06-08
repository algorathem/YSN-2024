using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistenceScript : MonoBehaviour
{
    public string winText;
    private Button deckOfActions;
    private GameObject textParent;
    public Sprite sprite;

    public GameObject dogCard;
    public GameObject catCard;
    public GameObject rabbitCard;
    public GameObject hamsterCard;

    private bool situationCardExists = false;



    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (situationCardExists == false)
        {

            if (winText == "Hamster")
            {
                Instantiate(hamsterCard, Vector3.zero, Quaternion.identity);
                deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
                textParent = GameObject.FindGameObjectWithTag("TextParent");
                sprite = Resources.Load<Sprite>("hamster_button");
                deckOfActions.image.sprite = sprite;
                textParent.transform.localPosition = hamsterCard.transform.position;
                situationCardExists = true;

            }
            else if (winText == "Cat")
            {
                Instantiate(catCard, Vector3.zero, Quaternion.identity);
                deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
                textParent = GameObject.FindGameObjectWithTag("TextParent");
                sprite = Resources.Load<Sprite>("cat_button");
                deckOfActions.image.sprite = sprite;
                textParent.transform.localPosition = catCard.transform.localPosition;
                situationCardExists = true;


            }
            else if (winText == "Dog")
            {
                Instantiate(dogCard, Vector3.zero, Quaternion.identity);
                deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
                textParent = GameObject.FindGameObjectWithTag("TextParent");
                sprite = Resources.Load<Sprite>("dog_button");
                deckOfActions.image.sprite = sprite;
                textParent.transform.localPosition = dogCard.transform.localPosition;
                situationCardExists = true;

            }
            else if (winText == "Rabbit")
            {
                Instantiate(rabbitCard, Vector3.zero, Quaternion.identity);
                deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
                textParent = GameObject.FindGameObjectWithTag("TextParent");
                sprite = Resources.Load<Sprite>("rabbit_button");
                deckOfActions.image.sprite = sprite;
                textParent.transform.localPosition = rabbitCard.transform.localPosition;
                situationCardExists = true;

            }
        }


    }
}
