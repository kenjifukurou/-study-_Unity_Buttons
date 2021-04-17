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
    public Toggle toggleButton;

    public Camera cam;
    public Slider sliderCam;

    public Dropdown dropdownItems;
    public GameObject go1;

    public InputField userInput;
    public Text userName;

    public ScrollRect scrollRectItems;

    // Start is called before the first frame update
    void Start()
    {
        countdownTime = 3.00f;
        toggleButton.isOn = false;

        cam.fieldOfView = sliderCam.value;
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonStatus)
        {
            countdownTime -= (float)(Time.deltaTime * 0.01);
            timerByButton.text = countdownTime.ToString("#.00");
        }

        if (toggleButton.isOn == true)
        {
            CreateClock();
        } else
        {
            buttonStatus = false;
        }
        
    }

    public void CreateClock() {
        buttonStatus = true;
    }

    public void UpdateCamFOVwithSlider() {
        cam.fieldOfView = sliderCam.value;
    }

    public void changesObjectSize() {

        switch (dropdownItems.value)
        {
            case 0:
                go1.transform.localScale = new Vector3(1f, 1f, 1f);
                break;
            case 1:
                go1.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                break;
            case 2:
                go1.transform.localScale = new Vector3(2f, 2f, 2f);
                break;
            default:
                go1.transform.localScale = new Vector3(1f, 1f, 1f);
                break;
        }
    }

    public void UpdateUserName() {
        userName.text = userInput.text;
    }

}
