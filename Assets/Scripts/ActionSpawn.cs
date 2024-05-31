using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSpawn : MonoBehaviour
{
    public GameObject catAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        print("clicked button");
        Instantiate(catAction, transform.position, Quaternion.identity);
    }
}

//when drag prfab, camera not assign. is it need use camera.main from script?

//weird behaviour when use scene dog card
