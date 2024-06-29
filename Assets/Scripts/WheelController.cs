using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WheelController : MonoBehaviour
{
    int randVal;
    private float timeInterval;
    private bool isCoroutine;
    private int finalAngle;

    public Text winText;
    public int section;
    float totalAngle;
    public string[] selectedCharacter;
    public AudioSource spinnerSound;

    // Start is called before the first frame update
    private void Start()
    {
        isCoroutine = true;
        totalAngle = 360 / section;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isCoroutine)
        {
            StartCoroutine(Spin());
            spinnerSound.Play();
        }
    }

    private IEnumerator Spin()
    {
        isCoroutine = false;
        randVal = Random.Range(80, 200);
        timeInterval = 0.0001f * Time.deltaTime * 2;
        for (int i = 0; i < randVal; i++)
        {
            transform.Rotate(0, 0, (totalAngle / 2));
            if (i > Mathf.RoundToInt(randVal * 0.2f))
                timeInterval = 0.5f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.5f))
                timeInterval = 1f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.7f))
                timeInterval = 1.5f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.8f))
                timeInterval = 2f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.9f))
                timeInterval = 2.5f * Time.deltaTime;
            yield return new WaitForSeconds(timeInterval);
        }

        if (Mathf.RoundToInt(transform.eulerAngles.z) % totalAngle != 0)
            transform.Rotate(0, 0, totalAngle / 2);
        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);
        print(finalAngle);
        for (int i = 0; i < section; i++)
        {
            if (finalAngle == i * totalAngle)
                winText.text = selectedCharacter[i];
            
        }

        yield return new WaitForSeconds(1f);

        GameObject persistantObj = GameObject.FindGameObjectWithTag("PersistentObj") as GameObject;
        persistantObj.GetComponent<PersistenceScript>().winText = winText.text;
        SceneManager.LoadScene("IntroductionScene");

    }

}
