using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject heartPrefab;
    public float health = 2;

    private void Start()
    {
        CreateNewHeart();
    }

    public void ResetHeart()
    {
        Destroy(heartPrefab);
    }
    public void CreateNewHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);

        newHeart.transform.SetParent(transform, false);
        //newHeart.transform.localScale = new Vector3(1, 1, 1);

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();
        heartComponent.SetHeartImage(HealthHeart.HeartStatus.Full);

        for (int i = 0; i < 1; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp(health - (i * 2), 0, 4);
            heartComponent.SetHeartImage((HealthHeart.HeartStatus)(heartStatusRemainder));
        }
    }
}
   