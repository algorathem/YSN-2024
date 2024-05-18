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
        winText = GameObject.FindGameObjectWithTag("Wheel").GetComponent<WheelController>().winText.text; //problem is on update wjeel is destroyed, so null reference, refer to otis ajain to fijure
        
        if (winText == "Hamster")
        {
            /*GameObject.FindGameObjectWithTag("Cat").GetComponent<SpriteRenderer>().enabled = true;*/
            print("h");
        }
        else if (winText == "Cat")
        {
            /*GameObject.FindGameObjectWithTag("Cat").GetComponent<SpriteRenderer>().enabled = true;*/
            print("c");
        }
        else if (winText == "Dog")
        {
           /* GameObject.FindGameObjectWithTag("Cat").GetComponent<SpriteRenderer>().enabled = true;*/
            print("d");
        }
        else if (winText == "Rabbit")
        {
          /*  GameObject.FindGameObjectWithTag("Cat").GetComponent<SpriteRenderer>().enabled = true;*/
            print("r"); 
        }
      

    }
}
