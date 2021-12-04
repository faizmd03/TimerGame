using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject losepanel;
    // Start is called before the first frame update
    public float TimeRemaining;
    public Text time;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(TimeRemaining > 0)
        {
            TimeRemaining -= Time.deltaTime;
            Debug.Log(TimeRemaining);
            time.text = TimeRemaining.ToString("F2");
        }
        else
        {
            Debug.Log("Time has ran out");
            losepanel.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
}
