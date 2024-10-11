using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public PlayerScore Score; 
    public Slider OxygenTimer;

    //timer
    //0.00416

    public float TimerValue = 1f;

    // Start is called before the first frame update
    void Start()
    {
        TimerValue = 1f;
        StartCoroutine(TimerWait());

    }

    // Update is called once per frame
    void Update()
    {
        if(TimerValue < 0)
        {
            SceneManager.LoadScene("DieMenu");
        }

        Score.timervalue = TimerValue;
    }

    IEnumerator TimerWait()
    {
        yield return new WaitForSeconds(1f);
        TimerValue = TimerValue - 0.00416f;
        OxygenTimer.value = TimerValue;
        StartCoroutine(TimerWait());
    }
}
