using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    Timer timeController = new Timer(0, 0, 0);

    private const float realSecondsDay = 86400f;
    private float day;
    public float newHour, newMinute, newSecond;

    private GameObject clockHandHourMovement;
    private GameObject clockHandMinuteMovement;
    public GameObject setTimeButton;

    public int changeTime;
    public float scaleTime = 1;

    public Text textTime;
    public Text setTime;

    public float setHour;
    public float setMinute;
    public float setSecond;

    private void Awake()
    {
        clockHandHourMovement = GameObject.FindGameObjectWithTag("HandHour");
        clockHandMinuteMovement = GameObject.FindGameObjectWithTag("HandMinute");
        if(textTime == null) textTime = GetComponent<Text>();
    }
    void Update()
    {
        CountTime();
    }
    public void CountTime()
    {
        day += Time.deltaTime / realSecondsDay;

        float dayNormalized = day % 1f;
        float rotationsDay = 360f;

        clockHandHourMovement.gameObject.transform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationsDay);

        float hoursInDay = 24f;
        clockHandMinuteMovement.gameObject.transform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationsDay * hoursInDay);

        timeController.GetHour = Mathf.Floor(dayNormalized * hoursInDay);

        float minutesInHour = 60f;
        timeController.GetMinute = Mathf.Floor(((dayNormalized * hoursInDay) % 1f) * minutesInHour);

        float secondsInMinute = 60f;
        timeController.GetSecond = Mathf.Floor(((((dayNormalized * hoursInDay) % 1f) * minutesInHour) %1f)*secondsInMinute);

        if(timeController.GetHour >= 10)
        {
            textTime.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

            if(timeController.GetMinute >= 10)
            {
                textTime.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

                if(timeController.GetSecond >= 10)
                {
                    textTime.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if(timeController.GetSecond <= 9)
                {
                    textTime.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
            if(timeController.GetMinute <= 9)
            {
                textTime.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    textTime.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    textTime.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
        }
        if (timeController.GetHour <= 9)
        {
            textTime.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

            if(timeController.GetMinute >= 10)
            {
                textTime.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

                if(timeController.GetSecond >= 10)
                {
                    textTime.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    textTime.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
            if(timeController.GetMinute <= 9)
            {
                textTime.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;

                if(timeController.GetSecond >= 10)
                {
                    textTime.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if(timeController.GetSecond <= 9)
                {
                    textTime.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
        }
    }
    public void SetTimeButton()
    {
        day += Time.deltaTime / realSecondsDay;

        float dayNormalized = day % 1f;
        float hoursInDay = 24f;
        setHour = Mathf.Floor(dayNormalized * hoursInDay);

        float minutesInHour = 60f;
        setMinute = Mathf.Floor(((dayNormalized * hoursInDay) % 1f) * minutesInHour);

        float secondsInMinute = 60f;
        setSecond = Mathf.Floor(((((dayNormalized * hoursInDay) % 1f) * minutesInHour) % 1f) * secondsInMinute);

        if (setHour >= 10)
        {
            setTime.text = setHour + ":" + setMinute + ":" + setSecond;

            if (setMinute >= 10)
            {
                setTime.text = setHour + ":" + setMinute + ":" + setSecond;

                if (setSecond >= 10)
                {
                    setTime.text = setHour + ":" + setMinute + ":" + setSecond;
                }
                if (setSecond <= 9)
                {
                    setTime.text = setHour + ":" + setMinute + ":" + "0" + setSecond;
                }
            }
            if (setMinute <= 9)
            {
                setTime.text = setHour + ":" + "0" + setMinute + ":" + setSecond;

                if (setSecond >= 10)
                {
                    setTime.text = setHour + ":" + "0" + setMinute + ":" + setSecond;
                }
                if (setSecond <= 9)
                {
                    setTime.text = setHour + ":" + "0" + setMinute + ":" + "0" + setSecond;
                }
            }
        }
        if (setHour <= 9)
        {
            setTime.text = "0" + setHour + ":" + setMinute + ":" + setSecond;

            if (setMinute >= 10)
            {
                setTime.text = "0" + setHour + ":" + setMinute + ":" + setSecond;

                if (setSecond >= 10)
                {
                    setTime.text = "0" + setHour + ":" + "0" + setMinute + ":" + setSecond;
                }
                if (setSecond <= 9)
                {
                    setTime.text = "0" + setHour + ":" + setMinute + ":" + "0" + setSecond;
                }
            }
            if (setMinute <= 9)
            {
                setTime.text = "0" + setHour + ":" + "0" + setMinute + ":" + setSecond;

                if (setSecond >= 10)
                {
                    setTime.text = "0" + setHour + ":" + "0" + setMinute + ":" + setSecond;
                }
                if (setSecond <= 9)
                {
                    setTime.text = "0" + setHour + ":" + "0" + setMinute + ":" + "0" + setSecond;
                }
            }
        }
    }
}
