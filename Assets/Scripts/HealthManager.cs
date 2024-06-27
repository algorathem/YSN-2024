using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject heartPrefab;
    public float health, naxHealth;

    private void Start()
    {
        DrawHeart();
    }

    public void DrawHeart()
    {
        CreateEmptyHeart();
    }
    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.localScale = new Vector3(1, 1, 1);
        //newHeart.transform.SetParent(transform);

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();
        heartComponent.SetHeartImage(HealthHeart.HeartStatus.Full);

    }
}
