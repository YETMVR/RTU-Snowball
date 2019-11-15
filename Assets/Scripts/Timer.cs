using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float GameSeconds;
    public float GameMinute;

    string stringSecond;
    string stringMinute;


    public bool isStarted = false;
    // Update is called once per frame
    void Update()
    {

        if (isStarted)
        {

            GameSeconds = GameSeconds + Time.deltaTime;
            stringSecond = GameSeconds.ToString();
            stringMinute = GameMinute.ToString();

            gameObject.GetComponent<TextMesh>().text = "Время-" + stringMinute + ":" + stringSecond;
            if (GameSeconds >= 60.0f)
            {
                GameMinute = GameMinute + 1.0f;
                GameSeconds = 0.0f;
            }
        }
    }
}
