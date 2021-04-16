using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class buttonClicked : MonoBehaviour
{
    public Text timerByButton;
    private float countdownTime;
    //public float timeMinusBySecond = 0.01f;
    private bool buttonStatus = false;

    // Start is called before the first frame update
    void Start()
    {
        countdownTime = 3.00f;
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonStatus)
        {
            countdownTime -= (float)(Time.deltaTime * 0.01);
            timerByButton.text = countdownTime.ToString("#.00");
        }
        
    }

    public void CreateClock() {
        buttonStatus = true;
    }
    
}
