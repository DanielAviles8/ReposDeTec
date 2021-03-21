using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer 
{
    private float hour;
    private float minute;
    private float second;

    public Timer(float ahour, float aminute, float asecond)
    {
        hour = ahour;
        minute = aminute;
        second = asecond;
    }

    public float GetHour
    {
        get { return hour; }
        set { hour = value; }
    }
    public float GetMinute
    {
        get { return minute; }
        set { minute = value; }
    }
    public float GetSecond
    {
        get { return second; }
        set { second = value; }
    }
}
