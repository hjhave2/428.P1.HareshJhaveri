using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;

public class WorldTimeAPI : MonoBehaviour
{
    public GameObject timeTextObject;
        string url = "https://worldtimeapi.org/api/timezone/America/Chicago";

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("GetDataFromWeb", 2f, 1f);
    }

    void GetDataFromWeb()
    {
        StartCoroutine(GetRequest(url));
    }

    IEnumerator GetRequest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();


            if (webRequest.result ==  UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the weather data to make sure it makes sense
                Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

                string timeData = webRequest.downloadHandler.text;
                
                int datetime = timeData.IndexOf("datetime", 0);
                int startHourIndex = timeData.IndexOf("T", datetime + 8);
                int endHourIndex = timeData.IndexOf(":", startHourIndex);
                int endMinuteIndex = timeData.IndexOf(":", endHourIndex+1);
                int hour = Int32.Parse(timeData.Substring(startHourIndex+1, (endHourIndex-startHourIndex-1)));
                string am_or_pm = "am";
                if(hour >= 12)
                {
                    am_or_pm = "pm";
                    hour -= 12;
                }
                if(hour == 0)
                {
                    hour = 12;
                }
                string minute = timeData.Substring(endHourIndex+1, (endMinuteIndex-endHourIndex-1));
                string time = hour.ToString() + ":" + minute + am_or_pm;
                
                timeTextObject.GetComponent<TextMeshPro>().text = "" + time;
                //Debug.Log(time);
            }
        }
    }
}
