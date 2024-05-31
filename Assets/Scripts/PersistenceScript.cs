using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistenceScript : MonoBehaviour
{
    public string winText;
    private Button deckOfActions;
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
            GameObject.FindGameObjectWithTag("Hamster").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Hamster").GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            sprite = Resources.Load<Sprite>("hamster_button");
            deckOfActions.image.sprite = sprite;

        }
        else if (winText == "Cat")
        {
            GameObject.FindGameObjectWithTag("Cat").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Cat").GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            sprite = Resources.Load<Sprite>("cat_button");
            deckOfActions.image.sprite = sprite;

        }
        else if (winText == "Dog")
        {
            GameObject.FindGameObjectWithTag("Dog").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Dog").GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            sprite = Resources.Load<Sprite>("dog_button");
            deckOfActions.image.sprite = sprite;

        }
        else if (winText == "Rabbit")
        {
            GameObject.FindGameObjectWithTag("Rabbit").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Rabbit").GetComponent<BoxCollider2D>().enabled = true;
            deckOfActions = GameObject.FindGameObjectWithTag("ActionButton").GetComponent<Button>();
            sprite = Resources.Load<Sprite>("rabbit_button");
            deckOfActions.image.sprite = sprite;

        }

        
    }
}
