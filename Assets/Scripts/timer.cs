using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float countDown;

    // Start is called before the first frame update
    void Start()
    {
        countDown = 0;
        timerText.text = "Count me out: " + countDown;
    }

    // Update is called once per frame
    void Update()
    {
        countDown = countDown - Time.deltaTime;
        timerText.text = "Count me out: " + countDown.ToString("#.00");
    }
}
