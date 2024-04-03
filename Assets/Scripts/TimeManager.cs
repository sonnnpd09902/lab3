﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    public Text timeText;
    private float currentTime = 0;
   
    void Update()
    {
            currentTime += Time.deltaTime;
            UpdateTimeDisplay();
    }

    void UpdateTimeDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60F);
        int seconds = Mathf.FloorToInt(currentTime - minutes * 60);
        string timeString = string.Format("{0:0}:{1:00}", minutes, seconds);
        timeText.text = "Time da choi: " + timeString;
    }
}