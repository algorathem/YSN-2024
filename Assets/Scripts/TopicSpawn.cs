using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopicSpawn : MonoBehaviour
{
    public TextMeshProUGUI topicText;
    public string[] allTopics = new string[9];
    public string winText;
    public int topicIndex;

    // Start is called before the first frame update
    void Start()
    {
        topicIndex = Random.Range(0, 8);
        GameObject persistantObj = GameObject.FindGameObjectWithTag("PersistentObj") as GameObject;
        winText = persistantObj.GetComponent<PersistenceScript>().winText;
        
    }  

    // Update is called once per frame
    void Update()
    {
        topicText.text = allTopics[topicIndex];
    }
}

