using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart=0;
    public float HighScore;
    public Text textbox;
    

    // Start is called before the first frame update
    void Start()
    {
        textbox.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        textbox.text = timeStart.ToString("F2");

        PlayerPrefs.SetFloat("HighScore", timeStart);
    }
}
