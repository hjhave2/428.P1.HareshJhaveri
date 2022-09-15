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
        string url = "https://worldtimeapi.org/timezone/America/Chicago";

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("GetDataFromWeb", 2f, 60f);
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

                Dictionary<string,string> timeData = JsonUtility.FromJson<Dictionary<string,string>> (webRequest.downloadHandler.text);

                string datetime = timeData["datetime"];
                int startHourIndex = datetime.IndexOf("T", 0);
                int endHourIndex = datetime.IndexOf(":", startHourIndex);
                int endMinuteIndex = datetime.IndexOf(":", endHourIndex);
                int hour = Int32.Parse(datetime.Substring(startHourIndex+1, endHourIndex));
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
                string minute = datetime.Substring(endHourIndex+1, endMinuteIndex);
                string time = hour.ToString() + ":" + minute + am_or_pm;
                
                timeTextObject.GetComponent<TextMeshPro>().text = "" ;
                Debug.Log(datetime);
                Debug.Log(time);
            }
        }
    }
}
