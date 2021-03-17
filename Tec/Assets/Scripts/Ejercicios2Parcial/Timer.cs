using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer 
{
    private int hour;
    private int minute;
    private int second;

    public Timer(int ahour, int aminute, int asecond)
    {
        hour = ahour;
        minute = aminute;
        second = asecond;
    }

    public int GetHour
    {
        get { return hour; }
        set { hour = value; }
    }
    public int GetMinute
    {
        get { return minute; }
        set { minute = value; }
    }
    public int GetSecond
    {
        get { return second; }
        set { second = value; }
    }
}
