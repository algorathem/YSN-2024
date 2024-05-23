using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardFlipAnim : MonoBehaviour
{
    private SpriteRenderer rend;

    [SerializeField]
    private Sprite faceSprite, backSprite;
    private bool coroutineAllowed, facedUp;

    public TextMeshProUGUI situationDescriptionText;
    public string[] situationDescription = new string[9];
    public GameObject topic;
    private int topicIndex;

    // Start is called before the first frame update
    void Start()
    {
        topicIndex = topic.GetComponent<TopicSpawn>().topicIndex;
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = backSprite;
        coroutineAllowed = true;
        facedUp = false;
        
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
            topic.GetComponent<TextMeshProUGUI>().enabled = false;
            for (float i = 0f; i <= 180f; i += 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                    {
                        rend.sprite = faceSprite;
                    }
                yield return new WaitForSeconds(0.01f);
                situationDescriptionText.text = situationDescription[topicIndex];
            }
        }
        else if (facedUp)
        {
            topic.GetComponent<TextMeshProUGUI>().enabled = true;
            situationDescriptionText.text = "";
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
