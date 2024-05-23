using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopicSpawn : MonoBehaviour
{
    public TextMeshProUGUI topicText;
    private string[] allTopics = new string[9];
    public int topicIndex;


    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        topicIndex = Random.Range(0, 8);
    }
}

