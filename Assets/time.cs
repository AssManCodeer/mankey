using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public float[] Totaltime;
    public float Seconds = 0;
    public float minutes = 0;
    public float Hours = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Seconds += Time.unscaledDeltaTime;
        if(Seconds > 60)
        {
            minutes += 1;
            Seconds = 0;
        }
        if (minutes > 60)
        {
            Hours += 1;
            minutes = 0;
        }
        Totaltime = new[] { Seconds, minutes, Hours };



    }
}
