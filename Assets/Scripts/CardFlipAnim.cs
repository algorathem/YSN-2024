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
            for (float i = 0f; i <= 180f; i += 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                    {
                        rend.sprite = faceSprite;
                    }
                yield return new WaitForSeconds(0.01f);
                situationDescriptionText.text = situationDescription[topicIndex];
               /* switch (topicIndex)
                {
                    case 0:
                        situationDescriptionText.text = situationDescription[0];
                        break;
                    case 1:
                        situationDescriptionText.text = situationDescription[1];
                        break;
                    case 2:
                        situationDescriptionText.text = situationDescription[2];
                        break;
                    case 3:
                        situationDescriptionText.text = situationDescription[3];
                        break;
                    case 4:
                        situationDescriptionText.text = situationDescription[4];
                        break;
                    case 5:
                        situationDescriptionText.text = situationDescription[5];
                        break;
                    case 6:
                        situationDescriptionText.text = situationDescription[6];
                        break;
                    case 7:
                        situationDescriptionText.text = situationDescription[7];
                        break;
                    case 8:
                        situationDescriptionText.text = situationDescription[8];
                        break;
                }*/
            }
        }
        else if (facedUp)
        {
            for(float i = 180f; i >= 0f; i -= 10f)
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
