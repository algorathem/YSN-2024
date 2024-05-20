using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopicSpawn : MonoBehaviour
{
    public TextMeshProUGUI topicText;
    public string[] allTopics = new string[9];
    private int topicIndex;
    // Start is called before the first frame update
    void Start()
    {
        topicIndex = Random.Range(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        topicText.text = allTopics[topicIndex];
    }
}
