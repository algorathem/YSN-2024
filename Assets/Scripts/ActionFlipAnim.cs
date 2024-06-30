using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class ActionFlipAnim : MonoBehaviour
{
    private SpriteRenderer rend;

    [SerializeField]
    private Sprite faceSprite, backSprite;
    private bool coroutineAllowed, facedUp;

   
    public bool isCorrect;



    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<SpriteRenderer>();
        rend.sprite = backSprite;

        coroutineAllowed = true;
        facedUp = false;

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

    }

    private void OnMouseDown()
    {
        if (coroutineAllowed)
        {
            StartCoroutine(RotateCard());

        }
    }

    private IEnumerator RotateCard()
    {
        coroutineAllowed = false;
        if (!facedUp)
        {

            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }

            for (float i = 0f; i <= 180f; i += 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    rend.sprite = faceSprite;
                }
                yield return new WaitForSeconds(0.01f);
                
            }
        }
        else if (facedUp)
        {

            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }

            for (float i = 180f; i >= 0f; i -= 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    rend.sprite = backSprite;
                }
                yield return new WaitForSeconds(0.01f);
            }

        }
        coroutineAllowed = true;
        facedUp = !facedUp;


    }
    // Update is called once per frame
    void Update()
    {

    }

}
