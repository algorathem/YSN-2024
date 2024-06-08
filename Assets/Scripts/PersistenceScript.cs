using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistenceScript : MonoBehaviour
{
    public string winText;
    private Button deckOfActions;
    private GameObject textParent;
    private GameObject situationCard;
    public Sprite sprite;



    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

        if (winText == "Hamster")
        {
            situationCard = GameObject.FindGameObjectWithTag("Hamster");
            situationCard.GetComponent<SpriteRenderer>().enabled = true;
            situationCard.GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            textParent = GameObject.FindGameObjectWithTag("TextParent");
            sprite = Resources.Load<Sprite>("hamster_button");
            deckOfActions.image.sprite = sprite;
            textParent.transform.localPosition = situationCard.transform.position;

        }
        else if (winText == "Cat")
        {
            situationCard = GameObject.FindGameObjectWithTag("Cat");
            situationCard.GetComponent<SpriteRenderer>().enabled = true;
            situationCard.GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            textParent = GameObject.FindGameObjectWithTag("TextParent");
            sprite = Resources.Load<Sprite>("cat_button");
            deckOfActions.image.sprite = sprite;
            textParent.transform.localPosition = situationCard.transform.localPosition;


        }
        else if (winText == "Dog")
        {
            situationCard = GameObject.FindGameObjectWithTag("Dog");
            situationCard.GetComponent<SpriteRenderer>().enabled = true;
            situationCard.GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            textParent = GameObject.FindGameObjectWithTag("TextParent");
            sprite = Resources.Load<Sprite>("dog_button");
            deckOfActions.image.sprite = sprite;
            textParent.transform.localPosition = situationCard.transform.localPosition;

        }
        else if (winText == "Rabbit")
        {
            situationCard = GameObject.FindGameObjectWithTag("Rabbit");
            situationCard.GetComponent<SpriteRenderer>().enabled = true;
            situationCard.GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            textParent = GameObject.FindGameObjectWithTag("TextParent");
            sprite = Resources.Load<Sprite>("rabbit_button");
            deckOfActions.image.sprite = sprite;
            textParent.transform.localPosition = situationCard.transform.localPosition;

        }


    }
}
