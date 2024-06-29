using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthHeart : MonoBehaviour
{
    public Sprite emptyHeart, oneQHeart, halfHeart, threeQHeart, fulLHeart;
    Image heartImage;

    private void Awake()
    {
        heartImage = GetComponent<Image>();
    }

    public void SetHeartImage(HeartStatus status)
    {
        switch (status)
        {
            case HeartStatus.Empty:
                heartImage.sprite = emptyHeart;
                break;
            case HeartStatus.OneQ:
                heartImage.sprite = oneQHeart;
                break;
            case HeartStatus.Half:
                heartImage.sprite = halfHeart;
                break;
            case HeartStatus.ThreeQ:
                heartImage.sprite = threeQHeart;
                break;
            case HeartStatus.Full:
                heartImage.sprite = fulLHeart;
                break;
        }
    }
    public enum HeartStatus
    {
        Empty = 0,
        OneQ = 1,
        Half = 2,
        ThreeQ = 3,
        Full = 4

    }
    




}


