using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardFlipAnim : MonoBehaviour
{
    private SpriteRenderer rend;

    [SerializeField]
    private Sprite faceSprite, backSprite;
    private bool coroutineAllowed;
  
    private TextMeshProUGUI situationDescriptionText;
    private TextMeshProUGUI topicText;
    public string[] situationDescription = new string[9];
    public static int topicIndex;
    private string[] allTopics = new string[9];


    void Awake()
    {
        situationDescriptionText = GameObject.FindGameObjectWithTag("Description").GetComponent<TextMeshProUGUI>();
        topicText = GameObject.FindGameObjectWithTag("Topic").GetComponent<TextMeshProUGUI>();

        allTopics[0] = "Food";
        allTopics[1] = "Habitats";
        allTopics[2] = "Personality";
        allTopics[3] = "Toxic Objects";
        allTopics[4] = "Exercise";
        allTopics[5] = "Hygiene";
        allTopics[6] = "Enrichment";
        allTopics[7] = "Health Screening";
        allTopics[8] = "Materials";
        topicIndex = Random.Range(0, 8);
        topicText.text = allTopics[topicIndex];
     


    }

    // Start is called before the first frame update
    void Start()
    {
     
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = backSprite;

        coroutineAllowed = true;
        //StartCoroutine(RotateCard());
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
        
          
            topicText.text = "Situation";

            
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
  
}
