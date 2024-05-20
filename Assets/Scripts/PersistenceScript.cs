using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistenceScript : MonoBehaviour
{
    public string winText;

    // Start is called before the first frame update
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
         
        }
        else if (winText == "Cat")
        {
            GameObject.FindGameObjectWithTag("Cat").GetComponent<SpriteRenderer>().enabled = true;
         
        }
        else if (winText == "Dog")
        {
            GameObject.FindGameObjectWithTag("Dog").GetComponent<SpriteRenderer>().enabled = true;
          
        }
        else if (winText == "Rabbit")
        {
            GameObject.FindGameObjectWithTag("Rabbit").GetComponent<SpriteRenderer>().enabled = true;
          
        }


    }
}
