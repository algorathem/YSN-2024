using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButtonChanger : MonoBehaviour
{
    public Button Button;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
       sprite = Resources.Load<Sprite>("dog_button");
    }

    // Update is called once per frame
    void Update()
    {
        Button.image.sprite = sprite;
    }
}
