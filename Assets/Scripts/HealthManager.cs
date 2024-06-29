using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject heartPrefab;
    public float health;

    private void Start()
    {
        CreateNewHeart();
        
    }

    public void ResetHeart()
    {
        Destroy(GameObject.FindGameObjectWithTag("NewHeart"));
    }
    public void CreateNewHeart()
    {
        health = AnswerSlot.health;
        GameObject newHeart = Instantiate(heartPrefab);

        newHeart.transform.SetParent(transform, false);
        //newHeart.transform.localScale = new Vector3(1, 1, 1);

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();
        heartComponent.SetHeartImage(HealthHeart.HeartStatus.Full);

        //remove outer for loop after confirming that we only need 1 heart, modify i to accommodate no. of hearts
        for (int i = 0; i < 1; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp(health - (i * 2), 0, 4);
            heartComponent.SetHeartImage((HealthHeart.HeartStatus)(heartStatusRemainder));
        }
    }
}
   