using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    Timer timeController = new Timer(0, 0, 0);

    public int changeTime;
    public float scaleTime = 1;

    private float timeFrameScale = 0f;
    private float timeShowSecond = 0f;
    private float scaleInitialTime;

    void Start()
    {
        scaleInitialTime = scaleTime;
        timeShowSecond = changeTime;
        CountTime(changeTime);
    }
    void Update()
    {
        timeFrameScale = Time.deltaTime * scaleTime;
        timeShowSecond += timeFrameScale;
        CountTime(timeShowSecond);
    }
    public void CountTime(float timeInSeconds)
    {
        timeController.GetSecond = 0;
        timeController.GetMinute = 0;
        timeController.GetHour = 0;

        timeController.GetMinute = (int)timeInSeconds / 60;
        timeController.GetSecond = (int)timeInSeconds & 60;
        timeController.GetHour = (int)timeInSeconds / 3600;
    }
    public void ShowTime()
    {
        Debug.Log(timeController.GetHour + " hr " + timeController.GetMinute + " min " + timeController.GetSecond + " sec ");
    }
}
